﻿namespace DOTR_Modding_Tool
{
  using Equin.ApplicationFramework;
  using System.Collections.Generic;
  using System.Windows.Forms;

  public partial class MainForm : Form
  {
    private CardDeckLeaderAbilities cardDeckLeaderAbilities;
    private BindingListView<CardDeckLeaderAbility> cardDeckLeaderAbilitiesBinding;
    private void LoadCardDeckLeaderAbilitesData()
    {
      byte[][][] byteArray = this.dataAccess.LoadCardDeckLeaderAbilities();
      // DebugHelper.Print2DByteArray(byteArray);
      this.cardDeckLeaderAbilities = new CardDeckLeaderAbilities(byteArray);
      this.cardDeckLeaderAbilitiesBinding = new BindingListView<CardDeckLeaderAbility>(this.cardDeckLeaderAbilities.List);
      this.cardDeckLeaderAbilitiesDatagridview.DataSource = this.cardDeckLeaderAbilitiesBinding;
      this.setupDeckLeaderAbilitiesDataGridView();
    }

    private void setupDeckLeaderAbilitiesDataGridView()
    {
      this.cardDeckLeaderAbilitiesDatagridview.CellMouseClick += handleCardDeckLeaderAbilitiesDataGridViewClick;
      this.cardDeckLeaderAbilitiesContextStrip.Items.Add("Edit selected cards");
      this.cardDeckLeaderAbilitiesContextStrip.ItemClicked += ShowMultipleCardDeckLeaderAbilityEditDialog;
    }

    private void handleCardDeckLeaderAbilitiesDataGridViewClick(object sender, DataGridViewCellMouseEventArgs e)
    {
      if (e.Button == System.Windows.Forms.MouseButtons.Right)
      {
        this.cardDeckLeaderAbilitiesContextStrip.Show(Cursor.Position);
      }
    }

    private void ShowMultipleCardDeckLeaderAbilityEditDialog(object sender, ToolStripItemClickedEventArgs e)
    {
      List<CardDeckLeaderAbility> selectedCardDeckLeaderAbilityList = new List<CardDeckLeaderAbility>();

      for (int i = 0; i < this.cardDeckLeaderAbilitiesDatagridview.SelectedRows.Count; i++)
      {
        CardDeckLeaderAbility cardDeckLeaderAbility = ((ObjectView<CardDeckLeaderAbility>)this.cardDeckLeaderAbilitiesDatagridview.SelectedRows[i].DataBoundItem).Object;
        selectedCardDeckLeaderAbilityList.Add(this.cardDeckLeaderAbilities.List[cardDeckLeaderAbility.Index]);
      }

      CardDeckLeaderAbilityMultiEditForm form = new CardDeckLeaderAbilityMultiEditForm(selectedCardDeckLeaderAbilityList, ref this.cardDeckLeaderAbilities);
      form.ShowDialog();
      this.cardDeckLeaderAbilitiesDatagridview.Refresh();
    }
  }
}