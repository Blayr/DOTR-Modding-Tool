using Equin.ApplicationFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOTR_Modding_Tool
{

  public partial class MainForm : Form
  {
    private List<Deck> deckList;
    private BindingListView<CardConstant> trunkCardConstantBinding;
    private BindingListView<DeckCard> deckEditDeckCardBinding;

    private void setupDeckEditorTab()
    {
      trunkCardConstantBinding = new BindingListView<CardConstant>(CardConstant.List);
      setupDeckEditDataGridView();
      loadDeckData();
    }

    private void loadDeckData()
    {
      byte[][][] deckBytes = dataAccess.LoadDecks();
      deckList = Deck.LoadDeckListFromBytes(deckBytes);
      comboBox1.DataSource = deckList;
    }

    private void formatCardTable(DataGridView table)
    {
      table.DataBindingComplete += this.FormatCardConstantTable;
      table.DefaultCellStyle.Font = new Font("OpenSans", 9.75F, FontStyle.Regular);
      table.AutoGenerateColumns = false;
      table.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
      MainForm.EnableDoubleBuffering(table);
    }

    private void setupDeckEditDataGridView()
    {
      this.formatCardTable(this.deckEditAllCardsDataGridView);
      this.formatCardTable(this.deckEditorDataGridView);
      this.deckEditAllCardsDataGridView.DataSource = trunkCardConstantBinding;
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      Deck selectedDeck = (Deck)comboBox1.SelectedItem;
      deckEditDeckCardBinding = new BindingListView<DeckCard>(selectedDeck.CardList);
      deckEditorDataGridView.DataSource = deckEditDeckCardBinding;
    }

    private void deckEditSaveButton_Click(object sender, EventArgs e)
    {

    }

    private void applyTrunkFilter()
    {
      string searchTerm = trunkFilterTextBox.Text.ToLower().Trim();

      if (searchTerm == string.Empty)
      {
        trunkCardConstantBinding.RemoveFilter();
        return;
      }

      trunkCardConstantBinding.ApplyFilter(delegate (CardConstant cardConstant) { return cardConstant.Name.ToLower().Contains(searchTerm); });
    }

    private void trunkSearchButton_Click(object sender, EventArgs e)
    {
      applyTrunkFilter();
    }

    private void trunkClearButton_Click(object sender, EventArgs e)
    {
      trunkFilterTextBox.Clear();
      trunkCardConstantBinding.RemoveFilter();
    }
    private void trunkFilterTextbox_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        applyTrunkFilter();
        e.Handled = true;
        e.SuppressKeyPress = true;
      }
    }
  }
}