using DOTR_MODDING_TOOL.Classes;
using Equin.ApplicationFramework;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    private BindingSource deckBinding = new BindingSource();

    private void setupDeckEditorTab()
    {
      trunkCardConstantBinding = new BindingListView<CardConstant>(CardConstant.List);
      setupDeckEditDataGridView();
      deckEditRemoveSelectedMenuItem.Click += DeckEditRemoveSelectedMenuItem_Click;
      loadDeckData();
      deckEditorDataGridView.CellDoubleClick += deckEditDataGridView_DoubleClick;
      trunkDataGridView.CellDoubleClick += trunkDataGridView_DoubleClick;
    }

    private void loadDeckData()
    {
      byte[][][] deckBytes = dataAccess.LoadDecks();
      deckList = Deck.LoadDeckListFromBytes(deckBytes);
      deckDropdown.DataSource = deckList;
      refreshDeckCardCountLabel();
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
      this.formatCardTable(this.trunkDataGridView);
      this.formatCardTable(this.deckEditorDataGridView);
      this.trunkDataGridView.DataSource = trunkCardConstantBinding;
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
      Deck selectedDeck = (Deck)deckDropdown.SelectedItem;
      deckBinding.DataSource = selectedDeck.CardList;
      deckEditorDataGridView.DataSource = deckBinding;
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

    private void deckEditDataGridView_DoubleClick(Object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex < 0)
      {
        return;
      }

      DeckCard deckCard = (DeckCard)deckBinding[e.RowIndex];
      deckBinding.Remove(deckCard);
      refreshDeckCardCountLabel();
    }

    private void trunkDataGridView_DoubleClick(Object sender, DataGridViewCellEventArgs e)
    {
      CardConstant cardConstant = ((ObjectView<CardConstant>)trunkDataGridView.Rows[e.RowIndex].DataBoundItem).Object;
      DeckCard deckCard = new DeckCard(cardConstant, new DeckLeaderRank((int)DeckLeaderRankType.NCO));
      deckBinding.Add(deckCard);
      refreshDeckCardCountLabel();
    }

    private void refreshDeckCardCountLabel()
    {
      List<DeckCard> cardList = (List<DeckCard>)deckBinding.DataSource;
      deckCardCountLabel.Text = $"Cards: {cardList.Count.ToString()}/40";

      if (cardList.Count == 40)
      {
        deckCardCountLabel.ForeColor = Color.Black;
      } else
      {
        deckCardCountLabel.ForeColor = Color.Red;
      }
    }

    private void DeckEditRemoveSelectedMenuItem_Click(object sender, EventArgs e)
    {
      foreach (DataGridViewRow row in deckEditorDataGridView.SelectedRows)
      {
        DeckCard deckCard = (DeckCard)row.DataBoundItem;
        deckBinding.Remove(deckCard);
      }

      refreshDeckCardCountLabel();
    }
  }
}