namespace DOTR_Modding_Tool
{
  using Equin.ApplicationFramework;
  using System;
  using System.Collections.Generic;
  using System.IO;
  using System.Linq;
  using System.Windows.Forms;

  public partial class MainForm : Form
  {
    private CardDeckLeaderAbilities cardDeckLeaderAbilities;
    private BindingListView<CardDeckLeaderAbility> cardDeckLeaderAbilitiesBinding;
    private bool deckLeaderAbilityDataGridViewIsSetup = false;

    private void LoadCardDeckLeaderAbilitesData()
    {
      LoadCardDeckLeaderAbilitesData(this.dataAccess.LoadCardDeckLeaderAbilities());
    }
    
    private void LoadCardDeckLeaderAbilitesData(byte[][][] byteArray)
    {
      this.cardDeckLeaderAbilities = new CardDeckLeaderAbilities(byteArray);
      this.cardDeckLeaderAbilitiesBinding = new BindingListView<CardDeckLeaderAbility>(this.cardDeckLeaderAbilities.List);
      this.cardDeckLeaderAbilitiesDatagridview.DataSource = this.cardDeckLeaderAbilitiesBinding;

      if (!deckLeaderAbilityDataGridViewIsSetup)
      {
        this.setupDeckLeaderAbilitiesDataGridView();
        this.deckLeaderAbilityDataGridViewIsSetup = true;
      }
    }

    private void setupDeckLeaderAbilitiesDataGridView()
    {
      this.cardDeckLeaderAbilitiesDatagridview.AutoGenerateColumns = false;
      this.cardDeckLeaderAbilitiesDatagridview.CellMouseClick += handleCardDeckLeaderAbilitiesDataGridViewClick;
      this.cardDeckLeaderAbilitiesContextStrip.Items.Add("Edit selected cards");
      this.cardDeckLeaderAbilitiesContextStrip.ItemClicked += ShowMultipleCardDeckLeaderAbilityEditDialog;
      MainForm.EnableDoubleBuffering(this.cardDeckLeaderAbilitiesDatagridview);
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

    private void deckLeaderAbilitiesSaveButton_Click(object sender, EventArgs e)
    {
      byte[] bytes = this.cardDeckLeaderAbilities.Bytes;
      this.dataAccess.SaveCardDeckLeaderAbilities(bytes); ;
      this.LoadCardDeckLeaderAbilitesData();
      MessageBox.Show("All deck leader abilities saved.", "Save successful");
    }

    private void deckLeaderAbilitiesExportCsvButton_Click(object sender, EventArgs e)
    {
      if (OpenExportCSVDialog("deck_leader_abilities.csv"))
      {
        ExportGridToCsv(this.cardDeckLeaderAbilitiesDatagridview, this.csvExporterFileDialog.FileName);
      }
    }

    private void deckLeaderAbilitiesExportBinButton_Click(object sender, EventArgs e)
    {
      if (OpenExportBinaryDialog("deck_leader_abilities.dat"))
      {
        File.WriteAllBytes(this.binExporterFileDialog.FileName, this.cardDeckLeaderAbilities.Bytes);
        MessageBox.Show("Binaries were successfully exported.", "Export successful");
      }
    }

    private void deckLeaderAbilitiesImportBinButton_Click(object sender, EventArgs e)
    {
      if (OpenImportBinaryDialog("deck_leader_abilities.dat"))
      {
        deckLeaderAbilityDataGridViewIsSetup = false;

        using (FileStream fileStream = new FileStream(this.binImporterFileDialog.FileName, FileMode.Open))
        {
          LoadCardDeckLeaderAbilitesData(this.dataAccess.LoadCardDeckLeaderAbilities(fileStream, 0));
        }

        MessageBox.Show("Binaries were successfully imported.", "Import successful");
      }
    }
  }
}