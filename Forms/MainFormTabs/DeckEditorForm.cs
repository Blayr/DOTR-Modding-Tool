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
    private BindingSource deckListBinding = new BindingSource();
    private BindingListView<CardConstant> trunkCardConstantBinding;
    private SortableBindingList<DeckCard> deckCardListBinding;

    private void setupDeckEditorTab()
    {
      trunkCardConstantBinding = new BindingListView<CardConstant>(CardConstant.List);
      setupDeckEditDataGridView();
      deckEditRemoveSelectedMenuItem.Click += DeckEditRemoveSelectedMenuItem_Click;
      loadDeckData();
      deckEditorDataGridView.CellDoubleClick += deckEditDataGridView_DoubleClick;
      trunkDataGridView.CellDoubleClick += trunkDataGridView_DoubleClick;
      trunkContextMenuStrip.Opening += TrunkContextMenuStrip_Opening;
    }

    private void TrunkContextMenuStrip_Opening(object sender, CancelEventArgs e)
    {
      DataGridViewSelectedRowCollection selectedRows = trunkDataGridView.SelectedRows;

      trunkContextMenuStrip.Items[0].Enabled = selectedRows.Count == 1;
    }

    private void loadDeckData()
    {
      byte[][][] deckBytes = dataAccess.LoadDecks();
      deckList = Deck.LoadDeckListFromBytes(deckBytes);
      deckListBinding.DataSource = deckList;
      deckDropdown.DataSource = deckListBinding;

      deckEditDeckLeaderRankComboBox.DataSource = DeckLeaderRank.RankList();
      deckEditDeckLeaderRankComboBox.SelectedIndex = ((Deck)deckDropdown.SelectedItem).DeckLeader.Rank.Index;

      refreshDeckInfoLabels();
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
      deckCardListBinding = new SortableBindingList<DeckCard>(selectedDeck.CardList);
      deckEditorDataGridView.DataSource = deckCardListBinding;
      deckEditDeckLeaderRankComboBox.SelectedValue = ((Deck)deckDropdown.SelectedItem).DeckLeader.Rank.Index;
      refreshDeckInfoLabels();
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

      DeckCard deckCard = (DeckCard)deckCardListBinding[e.RowIndex];
      deckCardListBinding.Remove(deckCard);
      refreshDeckInfoLabels();
    }

    private void refreshDeckCardCountLabel()
    {
      List<DeckCard> cardList = (List<DeckCard>)deckCardListBinding.ToList();
      deckCardCountLabel.Text = $"Cards: {cardList.Count}/40";

      if (cardList.Count == 40)
      {
        deckCardCountLabel.ForeColor = Color.Black;
      } else
      {
        deckCardCountLabel.ForeColor = Color.Red;
      }
    }

    private void refreshDeckCostLabel()
    {
      Deck deck = new Deck();
      deck.CardList = (List<DeckCard>)deckCardListBinding.ToList();
      deckEditDeckCostLabel.Text = $"{deck.DeckCost} DC";
    }

    private void refreshDeckInfoLabels()
    {
      refreshDeckCardCountLabel();
      refreshDeckCostLabel();
    }

    private void DeckEditRemoveSelectedMenuItem_Click(object sender, EventArgs e)
    {
      foreach (DataGridViewRow row in deckEditorDataGridView.SelectedRows)
      {
        DeckCard deckCard = (DeckCard)row.DataBoundItem;
        deckCardListBinding.Remove(deckCard);
      }

      refreshDeckInfoLabels();
    }

    private void deckEditSaveButton_Click(object sender, EventArgs e)
    {
      Deck deck = (Deck)deckDropdown.SelectedItem;

      try
      {
        deck.Save(dataAccess);
        deckCardListBinding.ResetBindings();
        MessageBox.Show("Deck saved.", "Save successful");
      } catch (InvalidOperationException error)
      {
        MessageBox.Show(error.Message, "Error");
      }

    }

    private void deckEditDeckLeaderRankComboBox_SelectedIndexChanged(object sender, EventArgs e)
    {
      // Prevent invalid setting of rank, usually happens on form load when SelectedIndex is initially null
      if (deckEditDeckLeaderRankComboBox.SelectedIndex < 1)
      {
        return;
      }

      Deck selectedDeck = (Deck)deckDropdown.SelectedItem;
      selectedDeck.DeckLeader.Rank = new DeckLeaderRank(deckEditDeckLeaderRankComboBox.SelectedIndex);
    }
    private void makeDeckLeaderToolStripMenuItem_Click(object sender, EventArgs e)
    {
      CardConstant selectedCard = ((ObjectView<CardConstant>)trunkDataGridView.SelectedRows[0].DataBoundItem).Object;
      Deck deck = (Deck)deckDropdown.SelectedItem;

      deck.DeckLeader = new DeckCard(selectedCard, deck.DeckLeader.Rank);
      deckListBinding.ResetBindings(false);
    }
    private void trunkDataGridView_DoubleClick(Object sender, DataGridViewCellEventArgs e)
    {
      List<DataGridViewRow> rows = new List<DataGridViewRow> { trunkDataGridView.Rows[e.RowIndex] };
      addCardsToDeck(rows);
    }

    private void addSelectedCardsToDeckToolStripMenuItem_Click(object sender, EventArgs e)
    {
      DataGridViewSelectedRowCollection selectedRows = trunkDataGridView.SelectedRows;
      List<DataGridViewRow> rows = new List<DataGridViewRow> { };
      
      foreach (DataGridViewRow row in selectedRows)
      {
        rows.Add(row);
      }

      addCardsToDeck(rows);
    }

    private void addCardsToDeck(List<DataGridViewRow> rows)
    {
      foreach (DataGridViewRow row in rows)
      {
        CardConstant cardConstant = ((ObjectView<CardConstant>)row.DataBoundItem).Object;
        DeckLeaderRank rank = new DeckLeaderRank((int)DeckLeaderRankType.NCO);
        DeckCard deckCard = new DeckCard(cardConstant, rank);
        deckCardListBinding.Add(deckCard);
      }

      refreshDeckInfoLabels();
    }
  }
}