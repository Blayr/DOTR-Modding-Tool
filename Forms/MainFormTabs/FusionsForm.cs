namespace DOTR_Modding_Tool
{
  using Equin.ApplicationFramework;
  using System;
  using System.ComponentModel;
  using System.Windows.Forms;

  public partial class MainForm : Form
  {
    private Fusions fusions;
    private BindingListView<Fusion> fusionsBinding;
    private bool fusionDataGridviewIsSetup = false;

    private void LoadFusionData()
    {
      this.fusionsDataGridView.DataSource = null;
      byte[] fusionBytes = this.dataAccess.LoadFusionData();
      this.fusions = new Fusions(fusionBytes);

      if (!this.fusionDataGridviewIsSetup)
      {
        this.SetupFusionDataGridView();
      }

      this.fusionsBinding = new BindingListView<Fusion>(this.fusions.fusions);
      this.fusionsDataGridView.DataSource = this.fusionsBinding;
    }

    private void SetupFusionDataGridView()
    {
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

      foreach (CardConstant cardConstant in CardConstant.Monsters)
      {
        this.FusionsDataGridViewLowerCard.Items.Add(new { LowerCardName = cardConstant.Name, LowerCardIndex = cardConstant.Index });
        this.FusionsDataGridViewUpperCard.Items.Add(new { UpperCardName = cardConstant.Name, UpperCardIndex = cardConstant.Index });
        this.FusionsDataGridViewFusionCard.Items.Add(new { FusionCardName = cardConstant.Name, FusionCardIndex = cardConstant.Index });
      }

      this.fusionsDataGridView.EditingControlShowing += this.FusionEditControlShowing;
      this.fusionsDataGridView.ColumnHeaderMouseClick += this.fusionsDataGridView_SortColumns;
      MainForm.EnableDoubleBuffering(this.fusionsDataGridView);

      this.fusionDataGridviewIsSetup = true;
    }

    private void fusionsDataGridView_SortColumns(object sender, DataGridViewCellMouseEventArgs e)
    {
      string nextSortDirection = "";
      string sortColumn = "Index";

      switch (e.ColumnIndex)
      {
        case 1:
          sortColumn = "LowerCardIndex";
          break;
        case 2:
          sortColumn = "LowerCardName";
          break;
        case 3:
          sortColumn = "UpperCardIndex";
          break;
        case 4:
          sortColumn = "UpperCardName";
          break;
        case 5:
          sortColumn = "FusionCardIndex";
          break;
        case 6:
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

    private void fusionSaveButton_Click(object sender, EventArgs e)
    {
      this.dataAccess.SaveFusionData(this.fusions.Bytes);
      this.LoadFusionData();
      MessageBox.Show("All fusion combinations saved.", "Save successful");
    }

    private void fusionExportButton_Click(object sender, EventArgs e)
    {
      if (OpenExportCSVDialog("fusions.csv"))
      {
        ExportGridToCsv(this.fusionsDataGridView, this.csvExporterFileDialog.FileName);
      }
    }
  }
}
