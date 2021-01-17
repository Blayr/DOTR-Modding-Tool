namespace DOTR_Modding_Tool
{
  using DOTR_MODDING_TOOL.Forms;
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
      this.isoSelectorFileDialog.FileName = "dotr.iso";
      this.isoSelectorFileDialog.Filter = "ISO files (*.iso)|*.iso";
      this.isoSelectorFileDialog.Title = "Open DOTR ISO file";
      bool isoIsLoaded = false;
      setWindowText();

      #if DEBUG
        this.dataAccess.OpenIso("C:\\Users\\Blair\\Desktop\\duelists of the roses\\DOTR_NTSC_TEST.iso");
        this.LoadDataFromIso();
        isoIsLoaded = true;
      #else
        isoIsLoaded = OpenSelectISODialog();
      #endif

      if (!isoIsLoaded)
      {
        Close();
        return;
      } 

      this.setupDeckEditorTab();
    }

    private void setWindowText()
    {
      AssemblyName assemblyName = Assembly.GetCallingAssembly().GetName();
      Text = $"{assemblyName.Name} - v{assemblyName.Version}";
    }

    private void FileToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.OpenSelectISODialog();
    }

    private bool OpenSelectISODialog()
    {
      DialogResult isoSelectorDialogResult = isoSelectorFileDialog.ShowDialog();

      if (isoSelectorDialogResult != DialogResult.OK)
      {
        return false;
      }

      this.dataAccess.OpenIso(isoSelectorFileDialog.FileName);
      this.LoadDataFromIso();
      return true;
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

    private static void EnableDoubleBuffering(DataGridView view)
    {
      // Reflection is a hack because the DoubleBuffered property is protected. Maybe this indicates we should be subclassing DataGridView.
      PropertyInfo property = typeof(DataGridView).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance);
      property.SetValue(view, true, null);
    }
    private void dOTRMapEditorToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start("https://github.com/rjoken/DOTRMap");
    }

    private void aboutToolStripMenuItem2_Click(object sender, EventArgs e)
    {
      AboutForm aboutForm = new AboutForm();
      aboutForm.ShowDialog();
    }

    private void viewSourceOnGithubToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start("https://github.com/Blayr/DOTR-Modding-Tool");
    }

    private void clovisYoutubeChannelToolStripMenuItem_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start("https://www.youtube.com/c/ClovissenpaiDotR/featured");
    }

    private void dOTRReduxModToolStripMenuItem_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=E_Aa2xC0Gig&ab_channel=Clovis");
    }
  }
}
