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

      string configFilePath = "dotr_modding_tool_config.yml";

#if DEBUG
      // when running in debug, the executable is in bin/Debug inside the repo, let's drop the config file
      // in the root directory of the repo instead to make it easier
      configFilePath = "../../dotr_modding_tool_config.yml";
#endif

      ConfigManager.InitializeInstance(configFilePath);
      ConfigManager config = ConfigManager.Instance;

      string isoPath = config.GetIsoPath();
      bool skipIsoDialog = config.GetSkipIsoDialog();

      if (!string.IsNullOrEmpty(isoPath) && skipIsoDialog)
      {
        this.dataAccess.OpenIso(isoPath);
        this.LoadDataFromIso();
        isoIsLoaded = true;
        Console.WriteLine("ISO Path is not empty and Skip ISO Dialog is true.");
      }
      else
      {
        isoIsLoaded = OpenSelectISODialog();
        Console.WriteLine("Condition not met. ISO Path: " + isoPath + ", Skip ISO Dialog: " + skipIsoDialog);
      }

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

      String isoPath= isoSelectorFileDialog.FileName;
      this.dataAccess.OpenIso(isoPath);
      this.LoadDataFromIso();
      ConfigManager.Instance.SetIsoPath(isoPath);
      ConfigManager.Instance.SaveConfig();
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
      this.loadBatzpupMods();
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

    private void rOMMapDocumentationToolStripMenuItem_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start("https://docs.google.com/document/d/1L_hkkhuF4C3miPzkiTSF_vPPOCov48kqNyhPqQBHTZQ/edit#");
    }
  }
}
