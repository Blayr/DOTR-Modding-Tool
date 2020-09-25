namespace DOTR_Modding_Tool
{
  using Equin.ApplicationFramework;
  using System;
  using System.Collections.Generic;
  using System.ComponentModel;
  using System.Diagnostics;
  using System.Drawing;
  using System.Linq;
  using System.Runtime.CompilerServices;
  using System.Windows.Forms;

  public partial class MainForm : Form
  {
    private DataAccess dataAccess = new DataAccess();

    private Fusions fusions;
    private BindingListView<Fusion> fusionsBinding;
    private Enemies enemies;
    private BindingListView<Enemy> enemiesBinding;

    public MainForm()
    {
      this.InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Normal;
      this.toggleEnableControls(false);
      this.SetupRankThresholdDataGridView();
      this.SetupCardConstantsDataGridView();
      this.openFileDialog1.FileName = "dotr.iso";
      this.openFileDialog1.Filter = "ISO files (*.iso)|*.iso";
      this.openFileDialog1.Title = "Open DOTR ISO file";

      #if DEBUG
        this.dataAccess.OpenIso("C:\\Users\\Blair\\Desktop\\duelists of the roses\\DOTR_NTSC_TEST.iso");
        this.LoadDataFromIso();
      #else
        this.OpenSelectISODialog();
      #endif
    }

    private void LoadEnemyAI()
    {
      this.enemyAiDataGridView.AutoGenerateColumns = false;
      byte[] bytes = this.dataAccess.LoadEnemyAIData();
      this.enemies = new Enemies(bytes);
      this.enemiesBinding = new BindingListView<Enemy>(this.enemies.List);
      this.enemyAiDataGridView.DataSource = this.enemiesBinding;

      this.EnemyAiColumn.DataPropertyName = "AiId";
      this.EnemyAiColumn.ValueMember = "AiId";
      this.EnemyAiColumn.DisplayMember = "AiName";

      if (this.EnemyAiColumn.Items.Count > 0)
      {
        return;
      }

      foreach (Ai ai in Ai.All)
      {
        this.EnemyAiColumn.Items.Add(new { AiId = ai.Id, AiName = ai.Name }); ;
      }
    }

    private void FileToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.OpenSelectISODialog();
    }

    private void OpenSelectISODialog()
    {
      if (openFileDialog1.ShowDialog() != DialogResult.OK)
      {
        return;
      }

      this.dataAccess.OpenIso(openFileDialog1.FileName);
      this.LoadDataFromIso();
    }

    private void LoadDataFromIso()
    {
      this.LoadEnemyAI();
      this.LoadLeaderTresholdData();
      this.LoadCardConstantsData();
      this.LoadFusionData();
      this.LoadTreasureCardData();
      this.toggleEnableControls(true);
    }

    private void toggleEnableControls(bool enabled)
    {
      this.rankThresholdsSaveButton.Enabled = enabled;
      this.cardConstantsFilterTextbox.Enabled = enabled;
      this.cardConstantsFilterButton.Enabled = enabled;
      this.cardConstantFilterClearButton.Enabled = enabled;
      this.cardConstantsSaveButton.Enabled = enabled;
      this.fusionSaveButton.Enabled = enabled;
      this.enemyAiSaveButton.Enabled = enabled;
    }

    private void LoadFusionData()
    {
      this.fusionsDataGridView.DataSource = null;
      byte[] fusionBytes = this.dataAccess.LoadFusionData();
      this.fusions = new Fusions(fusionBytes);

      this.fusionsBinding = new BindingListView<Fusion>(this.fusions.fusions);
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

      foreach (CardConstant cardConstant in this.cardConstants.Monsters)
      {
        this.FusionsDataGridViewLowerCard.Items.Add(new { LowerCardName = cardConstant.Name, LowerCardIndex = cardConstant.Index });
        this.FusionsDataGridViewUpperCard.Items.Add(new { UpperCardName = cardConstant.Name, UpperCardIndex= cardConstant.Index });
        this.FusionsDataGridViewFusionCard.Items.Add(new { FusionCardName = cardConstant.Name, FusionCardIndex = cardConstant.Index });
      }
     
      this.fusionsDataGridView.EditingControlShowing += this.FusionEditControlShowing;
      this.fusionsDataGridView.ColumnHeaderMouseClick += this.fusionsDataGridView_SortColumns;

      this.fusionsDataGridView.DataSource = this.fusionsBinding;
    }

    private void fusionsDataGridView_SortColumns(object sender, DataGridViewCellMouseEventArgs e)
    {
      string nextSortDirection = "";
      string sortColumn = "Index";

      switch (e.ColumnIndex)
      {
        case 1:
          sortColumn = "LowerCardName";
          break;
        case 2:
          sortColumn = "UpperCardName";
          break;
        case 3:
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

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // Ensure the menustrip is focused so that the datagridview changes are commited
      this.menuStrip1.Focus();
    }

    private void fusionSaveButton_Click(object sender, EventArgs e)
    {
      this.dataAccess.SaveFusionData(this.fusions.Bytes);
      this.LoadFusionData();
    }

    private void viewSourceOnGithubToolStripMenuItem_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start("https://github.com/Blayr/DOTR-Modding-Tool");
    }

    private void enemyAiSaveButton_Click(object sender, EventArgs e)
    {
      byte[] aiBytes = this.enemies.AiBytes;
      this.dataAccess.SaveEnemyAiData(aiBytes);
      this.LoadEnemyAI();
    }
  }
}
