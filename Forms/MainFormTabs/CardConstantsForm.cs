namespace DOTR_Modding_Tool
{
  using Equin.ApplicationFramework;
  using System;
  using System.Collections.Generic;
  using System.Drawing;
  using System.Windows.Forms;

  public partial class MainForm : Form
  {
    private BindingListView<CardConstant> cardConstantsBinding;

    private void LoadCardConstantsData()
    {
      byte[][] cardConstantsBytes = dataAccess.LoadCardConstantData();
      CardConstant.LoadFromBytes(cardConstantsBytes);
      this.cardConstantsBinding = new BindingListView<CardConstant>(CardConstant.List);
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
      byte[] cardConstantsBytes = CardConstant.AllBytes;
      dataAccess.SetCardConstantData(cardConstantsBytes);
      LoadCardConstantsData();
      MessageBox.Show("All card properties saved.", "Save successful");
    }

    private void cardConstantsExportButton_Click(object sender, EventArgs e)
    {
      if (OpenExportCSVDialog("card_properties.csv"))
      {
        ExportGridToCsv(this.cardConstantsDataGridView, this.csvExporterFileDialog.FileName);
      }
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
        selectedCardConstants.Add(CardConstant.List[cardConstant.Index]);
      }

      CardConstantsMultiEditForm form = new CardConstantsMultiEditForm(selectedCardConstants);
      form.ShowDialog();
      this.cardConstantsDataGridView.Refresh();
    }

    private void FormatCardConstantTable(object sender, DataGridViewBindingCompleteEventArgs e)
    {
      DataGridView dataGridView = (DataGridView)sender;

      foreach (DataGridViewRow row in dataGridView.Rows)
      {
        CardConstant cardConstant;

        if (row.DataBoundItem.GetType() == typeof(ObjectView<CardConstant>))
        {
          cardConstant = ((ObjectView<CardConstant>)row.DataBoundItem).Object;
        } else if (row.DataBoundItem.GetType() == typeof(DeckCard))
        {
          DeckCard deckCard = (DeckCard)row.DataBoundItem;
          cardConstant = deckCard.CardConstant;
        } else if (row.DataBoundItem.GetType() == typeof(ObjectView<DeckCard>))
        {
          DeckCard deckCard = ((ObjectView<DeckCard>)row.DataBoundItem).Object;
          cardConstant = deckCard.CardConstant;
        } else
        {
          cardConstant = ((ObjectView<CardConstant>)row.DataBoundItem).Object;
        }

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