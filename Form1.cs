﻿namespace DOTR_Deck_Leader_Thresholds
{
  using System;
  using System.Diagnostics;
  using System.Windows.Forms;

  public partial class MainForm : Form
  {
    private DataAccess dataAccess = new DataAccess();
    private DeckLeaderRankThresholds originalDeckLeaderRankThresholds;
    private DeckLeaderRankThresholds newDeckLeaderRankThresholds;
    private CardConstants cardConstants;

    public MainForm()
    {
      this.InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Normal;
      this.SetupRankThresholdDataGridView();
      this.SetupCardConstantsDataGridView();
      this.openFileDialog1.FileName = "dotr.iso";
      this.openFileDialog1.Filter = "ISO files (*.iso)|*.iso";
      this.openFileDialog1.Title = "Open DOTR ISO file";

      #if DEBUG
        this.dataAccess.OpenIso("C:\\Users\\Blair\\Desktop\\DOTR_NTSC_TEST.iso");
      #else
        this.OpenSelectISODialog();
      #endif
      this.LoadDataFromIso();
    }

    private void SetupCardConstantsDataGridView()
    {
      this.cardConstantsDataGridView.AutoGenerateColumns = false;
      this.cardConstantsDataGridView.LostFocus += OnDataGridViewLostFocus;
    }

    private void OnDataGridViewLostFocus(object sender, System.EventArgs e)
    {
      // Ensure the datagridviews edits are commited when selecting the menustrip
      DataGridView dataGridView = (DataGridView)sender;

      if (dataGridView.IsCurrentCellInEditMode && dataGridView.IsCurrentCellDirty)
      {
        dataGridView.EndEdit();
      }
    }

    private void SetupRankThresholdDataGridView()
    {
      this.rankThresholdsDataGridView.AutoGenerateColumns = false;
      DataGridViewColumn rankImageColumn = new DataGridViewImageColumn();
      rankImageColumn.DataPropertyName = "RankImage";
      rankImageColumn.HeaderText = string.Empty;
      rankImageColumn.Name = "RankImage";
      rankImageColumn.ReadOnly = true;
      rankImageColumn.Width = 30;
      this.rankThresholdsDataGridView.Columns.Add(rankImageColumn);
      DataGridViewColumn rankNameColumn = new DataGridViewTextBoxColumn();
      rankNameColumn.DataPropertyName = "RankName";
      rankNameColumn.HeaderText = "Rank";
      rankNameColumn.Name = "RankName";
      rankNameColumn.ReadOnly = true;
      this.rankThresholdsDataGridView.Columns.Add(rankNameColumn);
      DataGridViewColumn rankThresholdColumn = new DataGridViewTextBoxColumn();
      rankThresholdColumn.DataPropertyName = "Threshold";
      rankThresholdColumn.HeaderText = "Threshold";
      rankThresholdColumn.Name = "Threshold";
      rankThresholdColumn.ReadOnly = false;
      this.rankThresholdsDataGridView.Columns.Add(rankThresholdColumn);
      this.rankThresholdsDataGridView.CellValueChanged += this.RankThresholdDataGridView_CellValueChanged;
      this.rankThresholdsDataGridView.DataError += this.CorrectInvalidRankThreshold;
      this.rankThresholdsDataGridView.LostFocus += OnDataGridViewLostFocus;
    }

    private void CorrectInvalidRankThreshold(object sender, DataGridViewDataErrorEventArgs e)
    {
      DataGridViewCell cell = this.rankThresholdsDataGridView[e.ColumnIndex, e.RowIndex];
      string cellValue = (string)cell.EditedFormattedValue;

      ushort newThresholdValue;
      int inputtedNumber;

      if (!Int32.TryParse(cellValue, out inputtedNumber))
      {
        newThresholdValue = (ushort)cell.Value;
      }
      else if (inputtedNumber < ushort.MinValue)
      {
        newThresholdValue = ushort.MinValue;
      }
      else if (inputtedNumber > ushort.MaxValue)
      {
        newThresholdValue = ushort.MaxValue;
      } else
      {
        newThresholdValue = (ushort)cell.Value;
      }

      cell.Value = newThresholdValue;
      e.Cancel = false;
    }

    private void RankThresholdDataGridView_CellValueChanged(
    object sender, DataGridViewCellEventArgs e)
    {
      this.DisplayThresholdBytes(this.newRankThresholdsTextbox, this.newDeckLeaderRankThresholds.Bytes);
    }

    private void DisplayThresholdBytes(TextBox textbox, byte[] bytes)
    {
      textbox.Text = BitConverter.ToString(bytes);
    }

    private void FileToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.OpenSelectISODialog();
    }

    private void OpenSelectISODialog()
    {
      if (openFileDialog1.ShowDialog() != DialogResult.OK)
      {
        return;
      }

      originalRankThresholdsTextbox.Text = openFileDialog1.FileName;
      this.dataAccess.OpenIso(openFileDialog1.FileName);
      this.LoadLeaderTresholdData();
    }

    private void LoadDataFromIso()
    {
      this.LoadLeaderTresholdData();
      this.LoadCardConstantsData();
    }

    private void LoadCardConstantsData()
    {
      byte[][] cardConstantsBytes = dataAccess.LoadCardConstantData();
      this.cardConstants = new CardConstants(cardConstantsBytes);
      this.cardConstantsDataGridView.DataSource = this.cardConstants.Constants;
    }

    private void LoadLeaderTresholdData()
    {
      byte[] byteData = this.dataAccess.LoadLeaderTresholdData();
      this.originalDeckLeaderRankThresholds = new DeckLeaderRankThresholds(byteData);
      this.newDeckLeaderRankThresholds = new DeckLeaderRankThresholds(byteData);

      this.DisplayThresholdBytes(this.originalRankThresholdsTextbox, this.originalDeckLeaderRankThresholds.Bytes);
      this.rankThresholdsDataGridView.DataSource = this.newDeckLeaderRankThresholds.Thresholds;
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      this.dataAccess.SetDeckLeaderTresholds(this.newDeckLeaderRankThresholds.Bytes);
      this.LoadLeaderTresholdData();
    }

    private void cardConstantsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void saveCardConstantsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      byte[] cardConstantsBytes = this.cardConstants.Bytes;
      this.dataAccess.SetCardConstantData(cardConstantsBytes);
      this.LoadCardConstantsData();
    }

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // Ensure the menustrip is focused so that the datagridview changes are commited
      this.menuStrip1.Focus();
    }
  }
}
