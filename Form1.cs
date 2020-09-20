﻿namespace DOTR_Deck_Leader_Thresholds
{
  using Equin.ApplicationFramework;
  using System;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.Diagnostics;
  using System.Drawing;
  using System.Linq;
  using System.Runtime.CompilerServices;
  using System.Windows.Forms;

  public partial class MainForm : Form
  {
    private DataAccess dataAccess = new DataAccess();
    private DeckLeaderRankThresholds originalDeckLeaderRankThresholds;
    private DeckLeaderRankThresholds newDeckLeaderRankThresholds;
    private CardConstants cardConstants;
    private BindingListView<CardConstant> cardConstantsBinding;
    private Fusions fusions;
    private BindingListView<Fusion> fusionsBinding;
    private Enemies enemies;
    private BindingListView<Enemy> enemiesBinding;
    private TreasureCards treasureCards;
    private TreasureCard selectedTreasureCard;

    public MainForm()
    {
      this.InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Normal;
      this.toggleEnableControls(false);
      this.SetupRankThresholdDataGridView();
      this.SetupCardConstantsDataGridView();
      this.openFileDialog1.FileName = "dotr.iso";
      this.openFileDialog1.Filter = "ISO files (*.iso)|*.iso";
      this.openFileDialog1.Title = "Open DOTR ISO file";

      #if DEBUG
        this.dataAccess.OpenIso("C:\\Users\\Blair\\Desktop\\DOTR_NTSC_TEST.iso");
        this.LoadDataFromIso();
      #else
        this.OpenSelectISODialog();
      #endif
    }

    private void LoadEnemyAI()
    {
      this.enemyAiDataGridView.AutoGenerateColumns = false;
      byte[] bytes = this.dataAccess.LoadEnemyAIData();
      this.enemies = new Enemies(bytes);
      this.enemiesBinding = new BindingListView<Enemy>(this.enemies.List);
      this.enemyAiDataGridView.DataSource = this.enemiesBinding;

      this.EnemyAiColumn.DataPropertyName = "AiId";
      this.EnemyAiColumn.ValueMember = "AiId";
      this.EnemyAiColumn.DisplayMember = "AiName";

      if (this.EnemyAiColumn.Items.Count > 0)
      {
        return;
      }

      foreach (Ai ai in Ai.All)
      {
        this.EnemyAiColumn.Items.Add(new { AiId = ai.Id, AiName = ai.Name }); ;
      }
    }

    private void SetupCardConstantsDataGridView()
    {
      this.cardConstantsDataGridView.AutoGenerateColumns = false;
      this.cardConstantsDataGridView.CellFormatting += this.FormatCardConstantTable;
    }

    private void FormatCardConstantTable(object sender, DataGridViewCellFormattingEventArgs e)
    {
      DataGridView bro = (DataGridView)sender;
      if (e.ColumnIndex != 1)
      {
        return;
      }

      ushort cardIndex = (ushort)this.cardConstantsDataGridView.Rows[e.RowIndex].Cells[0].Value;
      CardConstant cardConstant = this.cardConstants.Constants[cardIndex];
      Color rowColor;

      switch (cardConstant.CardColor)
      {
        case CardColorType.NormalMonster:
          rowColor = Color.FromArgb(160, 128, 0);
          break;
        case CardColorType.EffectMonster:
          rowColor = Color.FromArgb(160, 80, 0);
          break;
        case CardColorType.Ritual:
          rowColor = Color.FromArgb(81, 102, 141);
          break;
        case CardColorType.Trap:
          rowColor = Color.FromArgb(160, 16, 64);
          break;
        case CardColorType.Magic:
          rowColor = Color.FromArgb(0, 96, 48);
          break;
        default:
          rowColor = Color.FromArgb(160, 128, 0);
          break;
      }

      bro.Rows[e.RowIndex].DefaultCellStyle.BackColor = rowColor;
      bro.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
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
      this.LoadDataFromIso();
    }

    private void LoadDataFromIso()
    {
      this.LoadEnemyAI();
      this.LoadLeaderTresholdData();
      this.LoadCardConstantsData();
      this.LoadFusionData();
      this.LoadTreasureCardData();
      this.toggleEnableControls(true);
    }

    private void LoadTreasureCardData()
    {
      byte[] treasureCardBytes = this.dataAccess.GetTreasureCardData();
      this.treasureCards = new TreasureCards(treasureCardBytes);
      this.setupTreasureCardForm();
      this.treasureCardsListbox.DataSource = this.treasureCards.List;
    }

    private void toggleEnableControls(bool enabled)
    {
      this.rankThresholdsSaveButton.Enabled = enabled;
      this.cardConstantsFilterTextbox.Enabled = enabled;
      this.cardConstantsFilterButton.Enabled = enabled;
      this.cardConstantFilterClearButton.Enabled = enabled;
      this.cardConstantsSaveButton.Enabled = enabled;
      this.fusionSaveButton.Enabled = enabled;
      this.enemyAiSaveButton.Enabled = enabled;
    }

    private void LoadFusionData()
    {
      this.fusionsDataGridView.DataSource = null;
      byte[] fusionBytes = this.dataAccess.LoadFusionData();
      this.fusions = new Fusions(fusionBytes);

      this.fusionsBinding = new BindingListView<Fusion>(this.fusions.fusions);
      this.fusionsDataGridView.AutoGenerateColumns = false;

      this.FusionsDataGridViewLowerCard.DataPropertyName = "LowerCardIndex";
      this.FusionsDataGridViewLowerCard.ValueMember = "LowerCardIndex";
      this.FusionsDataGridViewLowerCard.DisplayMember = "LowerCardName";
      this.FusionsDataGridViewLowerCard.AutoComplete = true;
      this.FusionsDataGridViewLowerCard.FlatStyle = FlatStyle.Flat;

      this.FusionsDataGridViewUpperCard.DataPropertyName = "UpperCardIndex";
      this.FusionsDataGridViewUpperCard.ValueMember = "UpperCardIndex";
      this.FusionsDataGridViewUpperCard.DisplayMember = "UpperCardName";
      this.FusionsDataGridViewUpperCard.AutoComplete = true;
      this.FusionsDataGridViewUpperCard.FlatStyle = FlatStyle.Flat;


      this.FusionsDataGridViewFusionCard.DataPropertyName = "FusionCardIndex";
      this.FusionsDataGridViewFusionCard.ValueMember = "FusionCardIndex";
      this.FusionsDataGridViewFusionCard.DisplayMember = "FusionCardName";
      this.FusionsDataGridViewFusionCard.AutoComplete = true;
      this.FusionsDataGridViewFusionCard.FlatStyle = FlatStyle.Flat;

      foreach (CardConstant cardConstant in this.cardConstants.Monsters)
      {
        this.FusionsDataGridViewLowerCard.Items.Add(new { LowerCardName = cardConstant.Name, LowerCardIndex = cardConstant.Index });
        this.FusionsDataGridViewUpperCard.Items.Add(new { UpperCardName = cardConstant.Name, UpperCardIndex= cardConstant.Index });
        this.FusionsDataGridViewFusionCard.Items.Add(new { FusionCardName = cardConstant.Name, FusionCardIndex = cardConstant.Index });
      }
     
      this.fusionsDataGridView.EditingControlShowing += this.FusionEditControlShowing;
      this.fusionsDataGridView.ColumnHeaderMouseClick += this.fusionsDataGridView_SortColumns;

      this.fusionsDataGridView.DataSource = this.fusionsBinding;
    }

    private void fusionsDataGridView_SortColumns(object sender, DataGridViewCellMouseEventArgs e)
    {
      string nextSortDirection = "";
      string sortColumn = "Index";

      switch (e.ColumnIndex)
      {
        case 1:
          sortColumn = "LowerCardName";
          break;
        case 2:
          sortColumn = "UpperCardName";
          break;
        case 3:
          sortColumn = "FusionCardName";
          break;
        default:
          return;
      }

      if (this.fusionsBinding.SortProperty == null || this.fusionsBinding.SortProperty.Name != sortColumn)
      {
        nextSortDirection = "ASC";
      }
      else
      {
        switch (this.fusionsBinding.SortDirection)
        {
          case ListSortDirection.Ascending:
            nextSortDirection = "DESC";
            break;
          case ListSortDirection.Descending:
            sortColumn = "Index";
            nextSortDirection = "ASC";
            break;
          default:
            nextSortDirection = "ASC";
            break;
        }
      }

      this.fusionsBinding.Sort = $"{sortColumn} {nextSortDirection}";
    }

    private void FusionEditControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
    {
      if (e.Control is DataGridViewComboBoxEditingControl)
      {
        ((ComboBox)e.Control).DropDownStyle = ComboBoxStyle.DropDown;
        ((ComboBox)e.Control).AutoCompleteSource = AutoCompleteSource.ListItems;
        ((ComboBox)e.Control).AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      }
    }

    private void LoadCardConstantsData()
    {
      byte[][] cardConstantsBytes = dataAccess.LoadCardConstantData();
      this.cardConstants = new CardConstants(cardConstantsBytes);
      this.cardConstantsBinding = new BindingListView<CardConstant>(this.cardConstants.Constants);
      this.cardConstantsDataGridView.DataSource = cardConstantsBinding;
      this.cardConstantsDataGridView.DefaultCellStyle.Font = new Font("OpenSans", 9.75F, FontStyle.Regular);
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
    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // Ensure the menustrip is focused so that the datagridview changes are commited
      this.menuStrip1.Focus();
    }

    private void cardConstantsFilterTextbox_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        this.applyCardConstantSearchFilter();
        e.Handled = true;
        e.SuppressKeyPress = true;
      }
    }

    private void cardConstantsFilterButton_Click(object sender, EventArgs e)
    {
      this.applyCardConstantSearchFilter();
    }

    private void applyCardConstantSearchFilter()
    {
      string searchTerm = this.cardConstantsFilterTextbox.Text.ToLower().Trim();

      if (searchTerm == String.Empty)
      {
        this.cardConstantsBinding.RemoveFilter();
        return;
      }

      this.cardConstantsBinding.ApplyFilter(delegate (CardConstant cardConstant) { return cardConstant.Name.ToLower().Contains(searchTerm); });
    }

    private void button2_Click(object sender, EventArgs e)
    {
      this.cardConstantsFilterTextbox.Clear();
      this.cardConstantsBinding.RemoveFilter();
    }

    private void fusionSaveButton_Click(object sender, EventArgs e)
    {
      this.dataAccess.SaveFusionData(this.fusions.Bytes);
      this.LoadFusionData();
    }

    private void cardConstantsSaveButton_Click(object sender, EventArgs e)
    {
      byte[] cardConstantsBytes = this.cardConstants.Bytes;
      this.dataAccess.SetCardConstantData(cardConstantsBytes);
      this.LoadCardConstantsData();
    }

    private void viewSourceOnGithubToolStripMenuItem_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start("https://github.com/Blayr/DOTR-Modding-Tool");
    }

    private void enemyAiSaveButton_Click(object sender, EventArgs e)
    {
      byte[] aiBytes = this.enemies.AiBytes;
      this.dataAccess.SaveEnemyAiData(aiBytes);
      this.LoadEnemyAI();
    }

    private void setupTreasureCardForm()
    {
      if (this.treasureCardCardComboBox.DataSource != null)
      {
        return;
      }

      this.treasureCardCardComboBox.DataSource = this.cardConstants.Constants;
      this.treasureCardCardComboBox.DropDownStyle = ComboBoxStyle.DropDown;
      this.treasureCardCardComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.treasureCardCardComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
    }

    private void treasureCardsListbox_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.selectedTreasureCard = this.treasureCards.List[this.treasureCardsListbox.SelectedIndex];
      this.treasureCardCardComboBox.SelectedValue = this.selectedTreasureCard.CardIndex;
      this.treasureCardRowNumericUpDown.Value = (int)this.selectedTreasureCard.Row;
      this.treasureCardColumnNumericUpDown.Value = (int)this.selectedTreasureCard.Column;
    }

    private void treasureCardSaveButton_Click(object sender, EventArgs e)
    {
      this.selectedTreasureCard.CardIndex = (ushort)this.treasureCardCardComboBox.SelectedValue;

      byte rowByte = BitConverter.GetBytes((int)this.treasureCardRowNumericUpDown.Value)[0];
      byte columnByte = BitConverter.GetBytes((int)this.treasureCardColumnNumericUpDown.Value)[0];

      this.selectedTreasureCard.Row = rowByte;
      this.selectedTreasureCard.Column = columnByte;

      byte[] tempBytes = this.selectedTreasureCard.Bytes;
      TreasureCard tempTreasureCard = new TreasureCard(tempBytes);

      this.dataAccess.SaveTreasureCard(this.treasureCardsListbox.SelectedIndex, selectedTreasureCard.Bytes);
    }
  }
}
