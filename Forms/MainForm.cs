namespace DOTR_Modding_Tool
{
  using System;
  using System.Reflection;
  using System.Windows.Forms;

  public partial class MainForm : Form
  {
    private DataAccess dataAccess = new DataAccess();

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

      this.setupDeckEditorTab();
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
      this.LoadLeaderThresholdData();
      this.LoadCardConstantsData();
      this.LoadFusionData();
      this.LoadTreasureCardData();
      this.LoadCardDeckLeaderAbilitesData();
      this.LoadCardEquipData();
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

    private static void EnableDoubleBuffering(DataGridView view)
    {
      // Reflection is a hack because the DoubleBuffered property is protected. Maybe this indicates we should be subclassing DataGridView.
      PropertyInfo property = typeof(DataGridView).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance);
      property.SetValue(view, true, null);
    }
  }
}
