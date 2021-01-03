namespace DOTR_Modding_Tool
{
  using Equin.ApplicationFramework;
  using System;
  using System.Collections.Generic;
  using System.Drawing;
    using System.Reflection;
    using System.Windows.Forms;

  public partial class MainForm : Form
  {
    private CardConstants cardConstants;
    private BindingListView<CardConstant> cardConstantsBinding;

    private void LoadCardConstantsData()
    {
      byte[][] cardConstantsBytes = dataAccess.LoadCardConstantData();
      this.cardConstants = new CardConstants(cardConstantsBytes);
      this.cardConstantsBinding = new BindingListView<CardConstant>(this.cardConstants.Constants);
      this.cardConstantsDataGridView.DataSource = cardConstantsBinding;
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

    private void cardConstantsSaveButton_Click(object sender, EventArgs e)
    {
      byte[] cardConstantsBytes = this.cardConstants.Bytes;
      this.dataAccess.SetCardConstantData(cardConstantsBytes);
      this.LoadCardConstantsData();
    }

    private void SetupCardConstantsDataGridView()
    {
      this.cardConstantsDataGridView.AutoGenerateColumns = false;
      this.cardConstantsDataGridView.DefaultCellStyle.Font = new Font("OpenSans", 9.75F, FontStyle.Regular);
      this.cardConstantsDataGridView.CellMouseClick += this.handleCardConstantsDataGridViewClick;
      this.cardConstantsDataGridView.DataBindingComplete += this.FormatCardConstantTable;
      MainForm.EnableDoubleBuffering(this.cardConstantsDataGridView);

      this.cardConstantsContextStrip.Items.Add("Edit selected cards");
      this.cardConstantsContextStrip.ItemClicked += ShowMultipleEditDialog;
    }

    private void handleCardConstantsDataGridViewClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right) {
        this.cardConstantsContextStrip.Show(Cursor.Position);
      }
    }

    private void ShowMultipleEditDialog(object sender, ToolStripItemClickedEventArgs e)
    {
      List<CardConstant> selectedCardConstants = new List<CardConstant>();

      for (int i = 0; i < this.cardConstantsDataGridView.SelectedRows.Count; i++)
      {
        CardConstant cardConstant = ((ObjectView<CardConstant>)this.cardConstantsDataGridView.SelectedRows[i].DataBoundItem).Object;
        selectedCardConstants.Add(this.cardConstants.Constants[cardConstant.Index]);
      }

      CardConstantsMultiEditForm form = new CardConstantsMultiEditForm(selectedCardConstants, ref this.cardConstants);
      form.ShowDialog();
      this.cardConstantsDataGridView.Refresh();
    }

    private void FormatCardConstantTable(object sender, DataGridViewBindingCompleteEventArgs e)
    {
      foreach (DataGridViewRow row in cardConstantsDataGridView.Rows)
      {
        CardConstant cardConstant = ((ObjectView<CardConstant>)row.DataBoundItem).Object;
        row.DefaultCellStyle.BackColor = CardConstantRowColor(cardConstant);
        row.DefaultCellStyle.ForeColor = Color.White;
      }
    }

    private Color CardConstantRowColor(CardConstant cardConstant)
    {
      switch (cardConstant.CardColor)
      {
        case CardColorType.NormalMonster:
          return Color.FromArgb(160, 128, 0);
        case CardColorType.EffectMonster:
          return Color.FromArgb(160, 80, 0);
        case CardColorType.Ritual:
          return Color.FromArgb(81, 102, 141);
        case CardColorType.Trap:
          return Color.FromArgb(160, 16, 64);
        case CardColorType.Magic:
          return Color.FromArgb(0, 96, 48);
        default:
          return Color.FromArgb(160, 128, 0);
      }
    }
  }
}