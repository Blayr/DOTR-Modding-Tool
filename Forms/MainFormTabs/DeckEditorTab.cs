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
    private BindingListView<CardConstant> trunkCardBinding;
    private BindingListView<DeckCard> deckEditDeckCardBinding;

    private void setupDeckEditorTab()
    {
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
      this.deckEditAllCardsDataGridView.DataSource = cardConstantsBinding;
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      Deck selectedDeck = (Deck)comboBox1.SelectedItem;
      deckEditDeckCardBinding = new BindingListView<DeckCard>(selectedDeck.CardList);
      deckEditorDataGridView.DataSource = deckEditDeckCardBinding;
    }
  }
}