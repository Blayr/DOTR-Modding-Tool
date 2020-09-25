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

    private void saveToolStripMenuItem_Click(object sender, EventArgs e)
    {
      // Ensure the menustrip is focused so that the datagridview changes are commited
      this.menuStrip1.Focus();
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
