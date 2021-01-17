namespace DOTR_Modding_Tool
{
  using System;
  using System.Windows.Forms;

  public partial class MainForm : Form
  {
    private DeckLeaderRankThresholds originalDeckLeaderRankThresholds;
    private DeckLeaderRankThresholds newDeckLeaderRankThresholds;

    private void RankThresholdDataGridView_CellValueChanged(
    object sender, DataGridViewCellEventArgs e)
    {
      this.DisplayThresholdBytes(this.newRankThresholdsTextbox, this.newDeckLeaderRankThresholds.Bytes);
    }

    private void LoadLeaderThresholdData()
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
      this.LoadLeaderThresholdData();
      MessageBox.Show("Deck leader rank thresholds saved.", "Save successful");
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
      MainForm.EnableDoubleBuffering(this.rankThresholdsDataGridView);
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
      }
      else
      {
        newThresholdValue = (ushort)cell.Value;
      }

      cell.Value = newThresholdValue;
      e.Cancel = false;
    }

    private void DisplayThresholdBytes(TextBox textbox, byte[] bytes)
    {
      textbox.Text = BitConverter.ToString(bytes);
    }
  }
}