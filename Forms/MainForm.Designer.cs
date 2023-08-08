namespace DOTR_Modding_Tool
{
  using System.Windows.Forms;

  public partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.OpenFileDialog isoSelectorFileDialog;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem openISOMenuItem;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (this.components != null))
      {
        this.components.Dispose();
      }

      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.isoSelectorFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openISOMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.additionalResourcesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dOTRMapEditorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rOMMapDocumentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewSourceOnGithubToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.coolStuffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clovisYoutubeChannelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dOTRReduxModToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiddenCardsTab = new System.Windows.Forms.TabPage();
            this.hiddenCardsSplitContainer = new System.Windows.Forms.SplitContainer();
            this.treasureCardsListbox = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.treasureCardColumnNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.treasureCardRowNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.treasureCardSaveButton = new System.Windows.Forms.Button();
            this.treasureCardCardComboBox = new System.Windows.Forms.ComboBox();
            this.enemyAiTab = new System.Windows.Forms.TabPage();
            this.enemyAiTabSplitContainer = new System.Windows.Forms.SplitContainer();
            this.enemyAiSaveButton = new System.Windows.Forms.Button();
            this.enemyAiDataGridView = new System.Windows.Forms.DataGridView();
            this.EnemyIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnemyNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnemyAiColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fusionsTab = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.fusionTableTipLabel = new System.Windows.Forms.Label();
            this.fusionSaveButton = new System.Windows.Forms.Button();
            this.fusionsDataGridView = new System.Windows.Forms.DataGridView();
            this.FusionsDataGridViewIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LowerCardMaterialCardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FusionsDataGridViewLowerCard = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.HigherCardMaterialCardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FusionsDataGridViewUpperCard = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ResultingFusionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FusionsDataGridViewFusionCard = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cardPropertiesTab = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label8 = new System.Windows.Forms.Label();
            this.cardConstantsSaveButton = new System.Windows.Forms.Button();
            this.cardConstantFilterClearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cardConstantsFilterButton = new System.Windows.Forms.Button();
            this.cardConstantsFilterTextbox = new System.Windows.Forms.TextBox();
            this.cardConstantsDataGridView = new System.Windows.Forms.DataGridView();
            this.CardConstantId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardConstantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardConstantAttack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardConstantDefense = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardConstantsType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardConstantsAttribute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardConstantsLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardConstantDeckCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CardConstantSlots = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CardConstantIsSlotRare = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CardConstantReincarnation = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CardConstantPasswordWorks = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.leaderRankTresholdsTab = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.newRankThresholdsTextbox = new System.Windows.Forms.TextBox();
            this.originalRankThresholdsTextbox = new System.Windows.Forms.TextBox();
            this.rankThresholdsSaveButton = new System.Windows.Forms.Button();
            this.rankThresholdsDataGridView = new System.Windows.Forms.DataGridView();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.deckEditorTab = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.deckEditorTabSplitContainer = new System.Windows.Forms.SplitContainer();
            this.cardTrunkSplitContainer = new System.Windows.Forms.SplitContainer();
            this.trunkTipLabel = new System.Windows.Forms.Label();
            this.cardTrunkLabel = new System.Windows.Forms.Label();
            this.trunkFilterTextBox = new System.Windows.Forms.TextBox();
            this.trunkClearFilterButton = new System.Windows.Forms.Button();
            this.trunkApplyFilterButton = new System.Windows.Forms.Button();
            this.trunkNameFilterLabel = new System.Windows.Forms.Label();
            this.trunkDataGridView = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardTrunkAttackColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardTrunkDefenseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardTrunkLevelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardTrunkAttributeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardTrunkTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardTrunkDeckCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trunkContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.makeDeckLeaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSelectedCardsToDeckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deckEditorSplitContainer = new System.Windows.Forms.SplitContainer();
            this.deckEditTipLabel = new System.Windows.Forms.Label();
            this.deckEditDeckCostLabel = new System.Windows.Forms.Label();
            this.deckEditDeckLeaderRankComboBox = new System.Windows.Forms.ComboBox();
            this.deckCardCountLabel = new System.Windows.Forms.Label();
            this.decksLabel = new System.Windows.Forms.Label();
            this.deckLabel = new System.Windows.Forms.Label();
            this.deckDropdown = new System.Windows.Forms.ComboBox();
            this.deckEditSaveButton = new System.Windows.Forms.Button();
            this.deckEditorDataGridView = new System.Windows.Forms.DataGridView();
            this.indexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deckTableNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deckEditAttackColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deckEditDefenseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deckEditLevelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deckEditAttributeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deckEditTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deckEditDeckCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deckEditContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deckEditRemoveSelectedMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deckLeaderAbilitiesTab = new System.Windows.Forms.TabPage();
            this.cardDeckLeaderAbilitiesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.deckLeaderAbilityTabTipsLabel = new System.Windows.Forms.Label();
            this.deckLeaderAbilitiesSaveButton = new System.Windows.Forms.Button();
            this.cardDeckLeaderAbilitiesDatagridview = new System.Windows.Forms.DataGridView();
            this.cardDeckLeaderAbilitiesIndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardDeckLeaderAbilitiesNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardDeckLeaderAbilitiesEnabledAbilitiesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bytes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipCompabilityTab = new System.Windows.Forms.TabPage();
            this.equipCompabilitySplitContainer = new System.Windows.Forms.SplitContainer();
            this.cardEquipNoteLabel1 = new System.Windows.Forms.Label();
            this.equipCompatibilitySaveButton = new System.Windows.Forms.Button();
            this.equipCompatibilityDataGridView = new System.Windows.Forms.DataGridView();
            this.EquipCompatabilityCardIndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipCompatabilityCardNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompatibleEquipCountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipCompatabilityEquipCardsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.monsterCardEquipCompatibilitiesContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editMonsterEquipMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batzpupModsTab = new System.Windows.Forms.TabPage();
            this.scBatzpupSave = new System.Windows.Forms.SplitContainer();
            this.BatzpupSaveButton = new System.Windows.Forms.Button();
            this.tbBatzpup = new System.Windows.Forms.TabControl();
            this.batzpupTbMain = new System.Windows.Forms.TabPage();
            this.scBatzpupMain = new System.Windows.Forms.SplitContainer();
            this.cbNoDCRequirementPostGame = new System.Windows.Forms.CheckBox();
            this.cbKeepReincarnatedCard = new System.Windows.Forms.CheckBox();
            this.cbAddAddtionalSlotRewards = new System.Windows.Forms.CheckBox();
            this.cbAllowAllCustomDuels = new System.Windows.Forms.CheckBox();
            this.cbUseCustomMusic = new System.Windows.Forms.CheckBox();
            this.cbRemoveRNGFromSlots = new System.Windows.Forms.CheckBox();
            this.cbRemoveNegetiveXP = new System.Windows.Forms.CheckBox();
            this.cbExpandedZoom = new System.Windows.Forms.CheckBox();
            this.cbEmulatorCameraFix = new System.Windows.Forms.CheckBox();
            this.cbAllFusions = new System.Windows.Forms.CheckBox();
            this.cbFastIntro = new System.Windows.Forms.CheckBox();
            this.cbAIInputFix = new System.Windows.Forms.CheckBox();
            this.gbChangeTerrainValues = new System.Windows.Forms.GroupBox();
            this.numChangeTerrainValue = new System.Windows.Forms.NumericUpDown();
            this.cbTerrainChangeEnabled = new System.Windows.Forms.CheckBox();
            this.gbReincarnationCount = new System.Windows.Forms.GroupBox();
            this.numReincarnationCount = new System.Windows.Forms.NumericUpDown();
            this.cbReincarnationCount = new System.Windows.Forms.CheckBox();
            this.gbChangeLpCap = new System.Windows.Forms.GroupBox();
            this.numLPCap = new System.Windows.Forms.NumericUpDown();
            this.cbLPCap = new System.Windows.Forms.CheckBox();
            this.gbForceNewGameSide = new System.Windows.Forms.GroupBox();
            this.cboForceNewGameSide = new System.Windows.Forms.ComboBox();
            this.cbForceNewGameSide = new System.Windows.Forms.CheckBox();
            this.gpSideToGoFirst = new System.Windows.Forms.GroupBox();
            this.cboSideFirst = new System.Windows.Forms.ComboBox();
            this.cbSideFirst = new System.Windows.Forms.CheckBox();
            this.tbBatzpupSlotRewards = new System.Windows.Forms.TabPage();
            this.dgvSlotRewards = new System.Windows.Forms.DataGridView();
            this.SlotRewardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThreeInARow = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SlotReward = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.scMusicMain = new System.Windows.Forms.SplitContainer();
            this.lbMusicDuelists = new System.Windows.Forms.ListBox();
            this.scBatzpupMusic2 = new System.Windows.Forms.SplitContainer();
            this.lbMusicTrack = new System.Windows.Forms.ListBox();
            this.scBatzpupMusicPlayer = new System.Windows.Forms.SplitContainer();
            this.scBatzpupMusicButtons = new System.Windows.Forms.SplitContainer();
            this.btnExtractMusic = new System.Windows.Forms.Button();
            this.btnToggleMusic = new System.Windows.Forms.Button();
            this.lblCurrentMusic = new System.Windows.Forms.Label();
            this.lblCurrentlyPlayingTitle = new System.Windows.Forms.Label();
            this.lblVolume = new System.Windows.Forms.Label();
            this.tbMusicVolume = new System.Windows.Forms.TrackBar();
            this.mapEditorTab = new System.Windows.Forms.TabPage();
            this.mapEditorSaveSplitContainer = new System.Windows.Forms.SplitContainer();
            this.mapEditorSaveButton = new System.Windows.Forms.Button();
            this.scBatzpupEditMap = new System.Windows.Forms.SplitContainer();
            this.scBatzpupEditDuelMapSelect = new System.Windows.Forms.SplitContainer();
            this.lblMapToSelect = new System.Windows.Forms.Label();
            this.lbDuelistMaps = new System.Windows.Forms.ListBox();
            this.scBatzpupEditMapTiles = new System.Windows.Forms.SplitContainer();
            this.scBatzpupEditMapThanks = new System.Windows.Forms.SplitContainer();
            this.llblDotrMap = new System.Windows.Forms.LinkLabel();
            this.lblDotrMap = new System.Windows.Forms.Label();
            this.scBatzpupEditMapPallete = new System.Windows.Forms.SplitContainer();
            this.pbSelectedTile = new System.Windows.Forms.PictureBox();
            this.lblCurrentTile = new System.Windows.Forms.Label();
            this.btnLoadDefaultMaps = new System.Windows.Forms.Button();
            this.tbPallete = new System.Windows.Forms.TableLayoutPanel();
            this.pbCrush = new System.Windows.Forms.PictureBox();
            this.pbLab = new System.Windows.Forms.PictureBox();
            this.pbNormal = new System.Windows.Forms.PictureBox();
            this.pbToon = new System.Windows.Forms.PictureBox();
            this.pbDark = new System.Windows.Forms.PictureBox();
            this.pbSea = new System.Windows.Forms.PictureBox();
            this.pbMeadow = new System.Windows.Forms.PictureBox();
            this.pbMountain = new System.Windows.Forms.PictureBox();
            this.pbWasteland = new System.Windows.Forms.PictureBox();
            this.pbForest = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblWhiteSide = new System.Windows.Forms.Label();
            this.lblMap = new System.Windows.Forms.Label();
            this.cardConstantsContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cardDeckLeaderAbilitiesContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RefreshEditor = new System.Windows.Forms.Timer(this.components);
            this.gbLeaderLPRecovery = new System.Windows.Forms.GroupBox();
            this.numLpRecoveryValue = new System.Windows.Forms.NumericUpDown();
            this.cbChangeLpRecovery = new System.Windows.Forms.CheckBox();
            this.cbCrushCardChange = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.hiddenCardsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hiddenCardsSplitContainer)).BeginInit();
            this.hiddenCardsSplitContainer.Panel1.SuspendLayout();
            this.hiddenCardsSplitContainer.Panel2.SuspendLayout();
            this.hiddenCardsSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treasureCardColumnNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.treasureCardRowNumericUpDown)).BeginInit();
            this.enemyAiTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyAiTabSplitContainer)).BeginInit();
            this.enemyAiTabSplitContainer.Panel1.SuspendLayout();
            this.enemyAiTabSplitContainer.Panel2.SuspendLayout();
            this.enemyAiTabSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.enemyAiDataGridView)).BeginInit();
            this.fusionsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fusionsDataGridView)).BeginInit();
            this.cardPropertiesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardConstantsDataGridView)).BeginInit();
            this.leaderRankTresholdsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rankThresholdsDataGridView)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.deckEditorTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deckEditorTabSplitContainer)).BeginInit();
            this.deckEditorTabSplitContainer.Panel1.SuspendLayout();
            this.deckEditorTabSplitContainer.Panel2.SuspendLayout();
            this.deckEditorTabSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardTrunkSplitContainer)).BeginInit();
            this.cardTrunkSplitContainer.Panel1.SuspendLayout();
            this.cardTrunkSplitContainer.Panel2.SuspendLayout();
            this.cardTrunkSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trunkDataGridView)).BeginInit();
            this.trunkContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deckEditorSplitContainer)).BeginInit();
            this.deckEditorSplitContainer.Panel1.SuspendLayout();
            this.deckEditorSplitContainer.Panel2.SuspendLayout();
            this.deckEditorSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deckEditorDataGridView)).BeginInit();
            this.deckEditContextMenuStrip.SuspendLayout();
            this.deckLeaderAbilitiesTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardDeckLeaderAbilitiesSplitContainer)).BeginInit();
            this.cardDeckLeaderAbilitiesSplitContainer.Panel1.SuspendLayout();
            this.cardDeckLeaderAbilitiesSplitContainer.Panel2.SuspendLayout();
            this.cardDeckLeaderAbilitiesSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cardDeckLeaderAbilitiesDatagridview)).BeginInit();
            this.equipCompabilityTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipCompabilitySplitContainer)).BeginInit();
            this.equipCompabilitySplitContainer.Panel1.SuspendLayout();
            this.equipCompabilitySplitContainer.Panel2.SuspendLayout();
            this.equipCompabilitySplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipCompatibilityDataGridView)).BeginInit();
            this.monsterCardEquipCompatibilitiesContextMenuStrip.SuspendLayout();
            this.batzpupModsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBatzpupSave)).BeginInit();
            this.scBatzpupSave.Panel1.SuspendLayout();
            this.scBatzpupSave.Panel2.SuspendLayout();
            this.scBatzpupSave.SuspendLayout();
            this.tbBatzpup.SuspendLayout();
            this.batzpupTbMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBatzpupMain)).BeginInit();
            this.scBatzpupMain.Panel1.SuspendLayout();
            this.scBatzpupMain.Panel2.SuspendLayout();
            this.scBatzpupMain.SuspendLayout();
            this.gbChangeTerrainValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChangeTerrainValue)).BeginInit();
            this.gbReincarnationCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numReincarnationCount)).BeginInit();
            this.gbChangeLpCap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLPCap)).BeginInit();
            this.gbForceNewGameSide.SuspendLayout();
            this.gpSideToGoFirst.SuspendLayout();
            this.tbBatzpupSlotRewards.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlotRewards)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMusicMain)).BeginInit();
            this.scMusicMain.Panel1.SuspendLayout();
            this.scMusicMain.Panel2.SuspendLayout();
            this.scMusicMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBatzpupMusic2)).BeginInit();
            this.scBatzpupMusic2.Panel1.SuspendLayout();
            this.scBatzpupMusic2.Panel2.SuspendLayout();
            this.scBatzpupMusic2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBatzpupMusicPlayer)).BeginInit();
            this.scBatzpupMusicPlayer.Panel1.SuspendLayout();
            this.scBatzpupMusicPlayer.Panel2.SuspendLayout();
            this.scBatzpupMusicPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBatzpupMusicButtons)).BeginInit();
            this.scBatzpupMusicButtons.Panel1.SuspendLayout();
            this.scBatzpupMusicButtons.Panel2.SuspendLayout();
            this.scBatzpupMusicButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbMusicVolume)).BeginInit();
            this.mapEditorTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapEditorSaveSplitContainer)).BeginInit();
            this.mapEditorSaveSplitContainer.Panel1.SuspendLayout();
            this.mapEditorSaveSplitContainer.Panel2.SuspendLayout();
            this.mapEditorSaveSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBatzpupEditMap)).BeginInit();
            this.scBatzpupEditMap.Panel1.SuspendLayout();
            this.scBatzpupEditMap.Panel2.SuspendLayout();
            this.scBatzpupEditMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBatzpupEditDuelMapSelect)).BeginInit();
            this.scBatzpupEditDuelMapSelect.Panel1.SuspendLayout();
            this.scBatzpupEditDuelMapSelect.Panel2.SuspendLayout();
            this.scBatzpupEditDuelMapSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBatzpupEditMapTiles)).BeginInit();
            this.scBatzpupEditMapTiles.Panel1.SuspendLayout();
            this.scBatzpupEditMapTiles.Panel2.SuspendLayout();
            this.scBatzpupEditMapTiles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBatzpupEditMapThanks)).BeginInit();
            this.scBatzpupEditMapThanks.Panel1.SuspendLayout();
            this.scBatzpupEditMapThanks.Panel2.SuspendLayout();
            this.scBatzpupEditMapThanks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBatzpupEditMapPallete)).BeginInit();
            this.scBatzpupEditMapPallete.Panel1.SuspendLayout();
            this.scBatzpupEditMapPallete.Panel2.SuspendLayout();
            this.scBatzpupEditMapPallete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedTile)).BeginInit();
            this.tbPallete.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCrush)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbToon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMeadow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMountain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWasteland)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForest)).BeginInit();
            this.gbLeaderLPRecovery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLpRecoveryValue)).BeginInit();
            this.SuspendLayout();
            // 
            // isoSelectorFileDialog
            // 
            this.isoSelectorFileDialog.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openISOMenuItem,
            this.additionalResourcesToolStripMenuItem1,
            this.viewSourceOnGithubToolStripMenuItem1,
            this.aboutToolStripMenuItem2,
            this.coolStuffToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1164, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openISOMenuItem
            // 
            this.openISOMenuItem.Name = "openISOMenuItem";
            this.openISOMenuItem.Size = new System.Drawing.Size(86, 24);
            this.openISOMenuItem.Text = "Open ISO";
            this.openISOMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
            // 
            // additionalResourcesToolStripMenuItem1
            // 
            this.additionalResourcesToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dOTRMapEditorToolStripMenuItem1,
            this.rOMMapDocumentationToolStripMenuItem});
            this.additionalResourcesToolStripMenuItem1.Name = "additionalResourcesToolStripMenuItem1";
            this.additionalResourcesToolStripMenuItem1.Size = new System.Drawing.Size(163, 24);
            this.additionalResourcesToolStripMenuItem1.Text = "Additional Resources";
            // 
            // dOTRMapEditorToolStripMenuItem1
            // 
            this.dOTRMapEditorToolStripMenuItem1.Name = "dOTRMapEditorToolStripMenuItem1";
            this.dOTRMapEditorToolStripMenuItem1.Size = new System.Drawing.Size(266, 26);
            this.dOTRMapEditorToolStripMenuItem1.Text = "DOTR Map Editor";
            this.dOTRMapEditorToolStripMenuItem1.Click += new System.EventHandler(this.dOTRMapEditorToolStripMenuItem1_Click);
            // 
            // rOMMapDocumentationToolStripMenuItem
            // 
            this.rOMMapDocumentationToolStripMenuItem.Name = "rOMMapDocumentationToolStripMenuItem";
            this.rOMMapDocumentationToolStripMenuItem.Size = new System.Drawing.Size(266, 26);
            this.rOMMapDocumentationToolStripMenuItem.Text = "ROM Map Documentation";
            this.rOMMapDocumentationToolStripMenuItem.Click += new System.EventHandler(this.rOMMapDocumentationToolStripMenuItem_Click);
            // 
            // viewSourceOnGithubToolStripMenuItem1
            // 
            this.viewSourceOnGithubToolStripMenuItem1.Name = "viewSourceOnGithubToolStripMenuItem1";
            this.viewSourceOnGithubToolStripMenuItem1.Size = new System.Drawing.Size(171, 24);
            this.viewSourceOnGithubToolStripMenuItem1.Text = "View source on Github";
            this.viewSourceOnGithubToolStripMenuItem1.Click += new System.EventHandler(this.viewSourceOnGithubToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem2
            // 
            this.aboutToolStripMenuItem2.Name = "aboutToolStripMenuItem2";
            this.aboutToolStripMenuItem2.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem2.Text = "About";
            this.aboutToolStripMenuItem2.Click += new System.EventHandler(this.aboutToolStripMenuItem2_Click);
            // 
            // coolStuffToolStripMenuItem
            // 
            this.coolStuffToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.coolStuffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clovisYoutubeChannelToolStripMenuItem,
            this.dOTRReduxModToolStripMenuItem});
            this.coolStuffToolStripMenuItem.Name = "coolStuffToolStripMenuItem";
            this.coolStuffToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.coolStuffToolStripMenuItem.Text = "Cool Stuff";
            // 
            // clovisYoutubeChannelToolStripMenuItem
            // 
            this.clovisYoutubeChannelToolStripMenuItem.Name = "clovisYoutubeChannelToolStripMenuItem";
            this.clovisYoutubeChannelToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.clovisYoutubeChannelToolStripMenuItem.Text = "Clovis\' Youtube Channel";
            this.clovisYoutubeChannelToolStripMenuItem.Click += new System.EventHandler(this.clovisYoutubeChannelToolStripMenuItem_Click);
            // 
            // dOTRReduxModToolStripMenuItem
            // 
            this.dOTRReduxModToolStripMenuItem.Name = "dOTRReduxModToolStripMenuItem";
            this.dOTRReduxModToolStripMenuItem.Size = new System.Drawing.Size(249, 26);
            this.dOTRReduxModToolStripMenuItem.Text = "DOTR Redux Mod";
            this.dOTRReduxModToolStripMenuItem.Click += new System.EventHandler(this.dOTRReduxModToolStripMenuItem_Click);
            // 
            // hiddenCardsTab
            // 
            this.hiddenCardsTab.Controls.Add(this.hiddenCardsSplitContainer);
            this.hiddenCardsTab.Location = new System.Drawing.Point(4, 27);
            this.hiddenCardsTab.Name = "hiddenCardsTab";
            this.hiddenCardsTab.Padding = new System.Windows.Forms.Padding(3);
            this.hiddenCardsTab.Size = new System.Drawing.Size(1156, 677);
            this.hiddenCardsTab.TabIndex = 4;
            this.hiddenCardsTab.Text = "Hidden Cards";
            this.hiddenCardsTab.UseVisualStyleBackColor = true;
            // 
            // hiddenCardsSplitContainer
            // 
            this.hiddenCardsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hiddenCardsSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.hiddenCardsSplitContainer.Name = "hiddenCardsSplitContainer";
            // 
            // hiddenCardsSplitContainer.Panel1
            // 
            this.hiddenCardsSplitContainer.Panel1.Controls.Add(this.treasureCardsListbox);
            // 
            // hiddenCardsSplitContainer.Panel2
            // 
            this.hiddenCardsSplitContainer.Panel2.Controls.Add(this.label7);
            this.hiddenCardsSplitContainer.Panel2.Controls.Add(this.label6);
            this.hiddenCardsSplitContainer.Panel2.Controls.Add(this.label5);
            this.hiddenCardsSplitContainer.Panel2.Controls.Add(this.label4);
            this.hiddenCardsSplitContainer.Panel2.Controls.Add(this.label3);
            this.hiddenCardsSplitContainer.Panel2.Controls.Add(this.label2);
            this.hiddenCardsSplitContainer.Panel2.Controls.Add(this.treasureCardColumnNumericUpDown);
            this.hiddenCardsSplitContainer.Panel2.Controls.Add(this.treasureCardRowNumericUpDown);
            this.hiddenCardsSplitContainer.Panel2.Controls.Add(this.treasureCardSaveButton);
            this.hiddenCardsSplitContainer.Panel2.Controls.Add(this.treasureCardCardComboBox);
            this.hiddenCardsSplitContainer.Size = new System.Drawing.Size(1150, 671);
            this.hiddenCardsSplitContainer.SplitterDistance = 239;
            this.hiddenCardsSplitContainer.TabIndex = 0;
            // 
            // treasureCardsListbox
            // 
            this.treasureCardsListbox.DisplayMember = "EnemyName";
            this.treasureCardsListbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treasureCardsListbox.FormattingEnabled = true;
            this.treasureCardsListbox.ItemHeight = 18;
            this.treasureCardsListbox.Location = new System.Drawing.Point(0, 0);
            this.treasureCardsListbox.Name = "treasureCardsListbox";
            this.treasureCardsListbox.Size = new System.Drawing.Size(239, 671);
            this.treasureCardsListbox.TabIndex = 0;
            this.treasureCardsListbox.SelectedIndexChanged += new System.EventHandler(this.treasureCardsListbox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(385, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Valid Row and Column numbers are 0-6 ( total of 7 each )";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(431, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Vs Red Rose - Row # and Column # start at 0 in the bottom right";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(407, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Vs White Rose - Row # and Column # start at 0 in the top left";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Card";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Column #";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Row #";
            // 
            // treasureCardColumnNumericUpDown
            // 
            this.treasureCardColumnNumericUpDown.Location = new System.Drawing.Point(128, 92);
            this.treasureCardColumnNumericUpDown.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.treasureCardColumnNumericUpDown.Name = "treasureCardColumnNumericUpDown";
            this.treasureCardColumnNumericUpDown.Size = new System.Drawing.Size(46, 24);
            this.treasureCardColumnNumericUpDown.TabIndex = 7;
            // 
            // treasureCardRowNumericUpDown
            // 
            this.treasureCardRowNumericUpDown.Location = new System.Drawing.Point(47, 92);
            this.treasureCardRowNumericUpDown.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.treasureCardRowNumericUpDown.Name = "treasureCardRowNumericUpDown";
            this.treasureCardRowNumericUpDown.Size = new System.Drawing.Size(46, 24);
            this.treasureCardRowNumericUpDown.TabIndex = 6;
            // 
            // treasureCardSaveButton
            // 
            this.treasureCardSaveButton.Location = new System.Drawing.Point(202, 89);
            this.treasureCardSaveButton.Name = "treasureCardSaveButton";
            this.treasureCardSaveButton.Size = new System.Drawing.Size(75, 23);
            this.treasureCardSaveButton.TabIndex = 2;
            this.treasureCardSaveButton.Text = "Save";
            this.treasureCardSaveButton.UseVisualStyleBackColor = true;
            this.treasureCardSaveButton.Click += new System.EventHandler(this.treasureCardSaveButton_Click);
            // 
            // treasureCardCardComboBox
            // 
            this.treasureCardCardComboBox.DisplayMember = "Name";
            this.treasureCardCardComboBox.FormattingEnabled = true;
            this.treasureCardCardComboBox.Location = new System.Drawing.Point(47, 40);
            this.treasureCardCardComboBox.Name = "treasureCardCardComboBox";
            this.treasureCardCardComboBox.Size = new System.Drawing.Size(166, 26);
            this.treasureCardCardComboBox.TabIndex = 0;
            this.treasureCardCardComboBox.ValueMember = "Index";
            // 
            // enemyAiTab
            // 
            this.enemyAiTab.Controls.Add(this.enemyAiTabSplitContainer);
            this.enemyAiTab.Location = new System.Drawing.Point(4, 27);
            this.enemyAiTab.Name = "enemyAiTab";
            this.enemyAiTab.Padding = new System.Windows.Forms.Padding(3);
            this.enemyAiTab.Size = new System.Drawing.Size(1156, 677);
            this.enemyAiTab.TabIndex = 3;
            this.enemyAiTab.Text = "Enemy Ai";
            this.enemyAiTab.UseVisualStyleBackColor = true;
            // 
            // enemyAiTabSplitContainer
            // 
            this.enemyAiTabSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enemyAiTabSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.enemyAiTabSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.enemyAiTabSplitContainer.Name = "enemyAiTabSplitContainer";
            this.enemyAiTabSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // enemyAiTabSplitContainer.Panel1
            // 
            this.enemyAiTabSplitContainer.Panel1.Controls.Add(this.enemyAiSaveButton);
            // 
            // enemyAiTabSplitContainer.Panel2
            // 
            this.enemyAiTabSplitContainer.Panel2.Controls.Add(this.enemyAiDataGridView);
            this.enemyAiTabSplitContainer.Size = new System.Drawing.Size(1150, 671);
            this.enemyAiTabSplitContainer.SplitterDistance = 25;
            this.enemyAiTabSplitContainer.TabIndex = 1;
            // 
            // enemyAiSaveButton
            // 
            this.enemyAiSaveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.enemyAiSaveButton.Location = new System.Drawing.Point(1075, 0);
            this.enemyAiSaveButton.Name = "enemyAiSaveButton";
            this.enemyAiSaveButton.Size = new System.Drawing.Size(75, 25);
            this.enemyAiSaveButton.TabIndex = 0;
            this.enemyAiSaveButton.Text = "Save";
            this.enemyAiSaveButton.UseVisualStyleBackColor = true;
            this.enemyAiSaveButton.Click += new System.EventHandler(this.enemyAiSaveButton_Click);
            // 
            // enemyAiDataGridView
            // 
            this.enemyAiDataGridView.AllowUserToAddRows = false;
            this.enemyAiDataGridView.AllowUserToDeleteRows = false;
            this.enemyAiDataGridView.AllowUserToResizeRows = false;
            this.enemyAiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.enemyAiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EnemyIndex,
            this.EnemyNameColumn,
            this.EnemyAiColumn});
            this.enemyAiDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.enemyAiDataGridView.Location = new System.Drawing.Point(0, 0);
            this.enemyAiDataGridView.Name = "enemyAiDataGridView";
            this.enemyAiDataGridView.RowHeadersVisible = false;
            this.enemyAiDataGridView.RowHeadersWidth = 51;
            this.enemyAiDataGridView.Size = new System.Drawing.Size(1150, 642);
            this.enemyAiDataGridView.TabIndex = 0;
            // 
            // EnemyIndex
            // 
            this.EnemyIndex.DataPropertyName = "Index";
            this.EnemyIndex.HeaderText = "#";
            this.EnemyIndex.MinimumWidth = 6;
            this.EnemyIndex.Name = "EnemyIndex";
            this.EnemyIndex.ReadOnly = true;
            this.EnemyIndex.Width = 30;
            // 
            // EnemyNameColumn
            // 
            this.EnemyNameColumn.DataPropertyName = "Name";
            this.EnemyNameColumn.HeaderText = "Enemy";
            this.EnemyNameColumn.MinimumWidth = 6;
            this.EnemyNameColumn.Name = "EnemyNameColumn";
            this.EnemyNameColumn.ReadOnly = true;
            this.EnemyNameColumn.Width = 160;
            // 
            // EnemyAiColumn
            // 
            this.EnemyAiColumn.HeaderText = "Ai";
            this.EnemyAiColumn.MinimumWidth = 6;
            this.EnemyAiColumn.Name = "EnemyAiColumn";
            this.EnemyAiColumn.Width = 180;
            // 
            // fusionsTab
            // 
            this.fusionsTab.Controls.Add(this.splitContainer2);
            this.fusionsTab.Location = new System.Drawing.Point(4, 27);
            this.fusionsTab.Name = "fusionsTab";
            this.fusionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.fusionsTab.Size = new System.Drawing.Size(1156, 677);
            this.fusionsTab.TabIndex = 2;
            this.fusionsTab.Text = "Fusions";
            this.fusionsTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.fusionTableTipLabel);
            this.splitContainer2.Panel1.Controls.Add(this.fusionSaveButton);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.fusionsDataGridView);
            this.splitContainer2.Size = new System.Drawing.Size(1150, 671);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 1;
            // 
            // fusionTableTipLabel
            // 
            this.fusionTableTipLabel.AutoSize = true;
            this.fusionTableTipLabel.Location = new System.Drawing.Point(5, 8);
            this.fusionTableTipLabel.Name = "fusionTableTipLabel";
            this.fusionTableTipLabel.Size = new System.Drawing.Size(384, 18);
            this.fusionTableTipLabel.TabIndex = 1;
            this.fusionTableTipLabel.Text = "Tip: You can start typing immediately after selecting a cell.";
            // 
            // fusionSaveButton
            // 
            this.fusionSaveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.fusionSaveButton.Location = new System.Drawing.Point(1075, 0);
            this.fusionSaveButton.Name = "fusionSaveButton";
            this.fusionSaveButton.Size = new System.Drawing.Size(75, 25);
            this.fusionSaveButton.TabIndex = 0;
            this.fusionSaveButton.Text = "Save";
            this.fusionSaveButton.UseVisualStyleBackColor = false;
            this.fusionSaveButton.Click += new System.EventHandler(this.fusionSaveButton_Click);
            // 
            // fusionsDataGridView
            // 
            this.fusionsDataGridView.AllowUserToAddRows = false;
            this.fusionsDataGridView.AllowUserToDeleteRows = false;
            this.fusionsDataGridView.AllowUserToResizeRows = false;
            this.fusionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fusionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FusionsDataGridViewIndex,
            this.LowerCardMaterialCardNumber,
            this.FusionsDataGridViewLowerCard,
            this.HigherCardMaterialCardNumber,
            this.FusionsDataGridViewUpperCard,
            this.ResultingFusionId,
            this.FusionsDataGridViewFusionCard});
            this.fusionsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fusionsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.fusionsDataGridView.Name = "fusionsDataGridView";
            this.fusionsDataGridView.RowHeadersVisible = false;
            this.fusionsDataGridView.RowHeadersWidth = 51;
            this.fusionsDataGridView.Size = new System.Drawing.Size(1150, 642);
            this.fusionsDataGridView.TabIndex = 0;
            // 
            // FusionsDataGridViewIndex
            // 
            this.FusionsDataGridViewIndex.DataPropertyName = "Index";
            this.FusionsDataGridViewIndex.HeaderText = "Index";
            this.FusionsDataGridViewIndex.MinimumWidth = 6;
            this.FusionsDataGridViewIndex.Name = "FusionsDataGridViewIndex";
            this.FusionsDataGridViewIndex.ReadOnly = true;
            this.FusionsDataGridViewIndex.Width = 40;
            // 
            // LowerCardMaterialCardNumber
            // 
            this.LowerCardMaterialCardNumber.DataPropertyName = "LowerCardIndex";
            this.LowerCardMaterialCardNumber.HeaderText = "LC#";
            this.LowerCardMaterialCardNumber.MinimumWidth = 6;
            this.LowerCardMaterialCardNumber.Name = "LowerCardMaterialCardNumber";
            this.LowerCardMaterialCardNumber.ReadOnly = true;
            this.LowerCardMaterialCardNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.LowerCardMaterialCardNumber.Width = 40;
            // 
            // FusionsDataGridViewLowerCard
            // 
            this.FusionsDataGridViewLowerCard.DataPropertyName = "LowerCardIndex";
            this.FusionsDataGridViewLowerCard.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.FusionsDataGridViewLowerCard.HeaderText = "Lower card name";
            this.FusionsDataGridViewLowerCard.MinimumWidth = 6;
            this.FusionsDataGridViewLowerCard.Name = "FusionsDataGridViewLowerCard";
            this.FusionsDataGridViewLowerCard.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.FusionsDataGridViewLowerCard.Width = 200;
            // 
            // HigherCardMaterialCardNumber
            // 
            this.HigherCardMaterialCardNumber.DataPropertyName = "UpperCardIndex";
            this.HigherCardMaterialCardNumber.HeaderText = "HC#";
            this.HigherCardMaterialCardNumber.MinimumWidth = 6;
            this.HigherCardMaterialCardNumber.Name = "HigherCardMaterialCardNumber";
            this.HigherCardMaterialCardNumber.ReadOnly = true;
            this.HigherCardMaterialCardNumber.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.HigherCardMaterialCardNumber.Width = 40;
            // 
            // FusionsDataGridViewUpperCard
            // 
            this.FusionsDataGridViewUpperCard.HeaderText = "Higher card name";
            this.FusionsDataGridViewUpperCard.MinimumWidth = 6;
            this.FusionsDataGridViewUpperCard.Name = "FusionsDataGridViewUpperCard";
            this.FusionsDataGridViewUpperCard.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FusionsDataGridViewUpperCard.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.FusionsDataGridViewUpperCard.Width = 200;
            // 
            // ResultingFusionId
            // 
            this.ResultingFusionId.DataPropertyName = "FusionCardIndex";
            this.ResultingFusionId.HeaderText = "RF#";
            this.ResultingFusionId.MinimumWidth = 6;
            this.ResultingFusionId.Name = "ResultingFusionId";
            this.ResultingFusionId.ReadOnly = true;
            this.ResultingFusionId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ResultingFusionId.Width = 40;
            // 
            // FusionsDataGridViewFusionCard
            // 
            this.FusionsDataGridViewFusionCard.HeaderText = "Resulting fusion name";
            this.FusionsDataGridViewFusionCard.MinimumWidth = 6;
            this.FusionsDataGridViewFusionCard.Name = "FusionsDataGridViewFusionCard";
            this.FusionsDataGridViewFusionCard.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FusionsDataGridViewFusionCard.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.FusionsDataGridViewFusionCard.Width = 200;
            // 
            // cardPropertiesTab
            // 
            this.cardPropertiesTab.Controls.Add(this.splitContainer1);
            this.cardPropertiesTab.Location = new System.Drawing.Point(4, 27);
            this.cardPropertiesTab.Name = "cardPropertiesTab";
            this.cardPropertiesTab.Padding = new System.Windows.Forms.Padding(3);
            this.cardPropertiesTab.Size = new System.Drawing.Size(1156, 677);
            this.cardPropertiesTab.TabIndex = 1;
            this.cardPropertiesTab.Text = "Card Properties";
            this.cardPropertiesTab.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.cardConstantsSaveButton);
            this.splitContainer1.Panel1.Controls.Add(this.cardConstantFilterClearButton);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cardConstantsFilterButton);
            this.splitContainer1.Panel1.Controls.Add(this.cardConstantsFilterTextbox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.cardConstantsDataGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1150, 671);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(323, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(392, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Select multiple rows with shift or ctrl keys, right click to edit";
            // 
            // cardConstantsSaveButton
            // 
            this.cardConstantsSaveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.cardConstantsSaveButton.Location = new System.Drawing.Point(1075, 0);
            this.cardConstantsSaveButton.Name = "cardConstantsSaveButton";
            this.cardConstantsSaveButton.Size = new System.Drawing.Size(75, 25);
            this.cardConstantsSaveButton.TabIndex = 4;
            this.cardConstantsSaveButton.Text = "Save";
            this.cardConstantsSaveButton.UseVisualStyleBackColor = true;
            this.cardConstantsSaveButton.Click += new System.EventHandler(this.cardConstantsSaveButton_Click);
            // 
            // cardConstantFilterClearButton
            // 
            this.cardConstantFilterClearButton.Location = new System.Drawing.Point(242, 2);
            this.cardConstantFilterClearButton.Name = "cardConstantFilterClearButton";
            this.cardConstantFilterClearButton.Size = new System.Drawing.Size(75, 23);
            this.cardConstantFilterClearButton.TabIndex = 3;
            this.cardConstantFilterClearButton.Text = "Clear";
            this.cardConstantFilterClearButton.UseVisualStyleBackColor = true;
            this.cardConstantFilterClearButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter:";
            // 
            // cardConstantsFilterButton
            // 
            this.cardConstantsFilterButton.Location = new System.Drawing.Point(161, 2);
            this.cardConstantsFilterButton.Name = "cardConstantsFilterButton";
            this.cardConstantsFilterButton.Size = new System.Drawing.Size(75, 23);
            this.cardConstantsFilterButton.TabIndex = 1;
            this.cardConstantsFilterButton.Text = "Apply";
            this.cardConstantsFilterButton.UseVisualStyleBackColor = true;
            this.cardConstantsFilterButton.Click += new System.EventHandler(this.cardConstantsFilterButton_Click);
            // 
            // cardConstantsFilterTextbox
            // 
            this.cardConstantsFilterTextbox.Location = new System.Drawing.Point(43, 4);
            this.cardConstantsFilterTextbox.Name = "cardConstantsFilterTextbox";
            this.cardConstantsFilterTextbox.Size = new System.Drawing.Size(112, 24);
            this.cardConstantsFilterTextbox.TabIndex = 0;
            this.cardConstantsFilterTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cardConstantsFilterTextbox_KeyDown);
            // 
            // cardConstantsDataGridView
            // 
            this.cardConstantsDataGridView.AllowUserToAddRows = false;
            this.cardConstantsDataGridView.AllowUserToDeleteRows = false;
            this.cardConstantsDataGridView.AllowUserToOrderColumns = true;
            this.cardConstantsDataGridView.AllowUserToResizeRows = false;
            this.cardConstantsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cardConstantsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cardConstantsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cardConstantsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CardConstantId,
            this.CardConstantName,
            this.CardConstantAttack,
            this.CardConstantDefense,
            this.CardConstantsType,
            this.CardConstantsAttribute,
            this.CardConstantsLevel,
            this.CardConstantDeckCost,
            this.CardConstantSlots,
            this.CardConstantIsSlotRare,
            this.CardConstantReincarnation,
            this.CardConstantPasswordWorks});
            this.cardConstantsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardConstantsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.cardConstantsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.cardConstantsDataGridView.Name = "cardConstantsDataGridView";
            this.cardConstantsDataGridView.RowHeadersVisible = false;
            this.cardConstantsDataGridView.RowHeadersWidth = 51;
            this.cardConstantsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cardConstantsDataGridView.Size = new System.Drawing.Size(1150, 642);
            this.cardConstantsDataGridView.TabIndex = 0;
            // 
            // CardConstantId
            // 
            this.CardConstantId.DataPropertyName = "Index";
            this.CardConstantId.HeaderText = "ID";
            this.CardConstantId.MinimumWidth = 6;
            this.CardConstantId.Name = "CardConstantId";
            this.CardConstantId.ReadOnly = true;
            this.CardConstantId.Width = 34;
            // 
            // CardConstantName
            // 
            this.CardConstantName.DataPropertyName = "Name";
            this.CardConstantName.HeaderText = "Name";
            this.CardConstantName.MinimumWidth = 6;
            this.CardConstantName.Name = "CardConstantName";
            this.CardConstantName.ReadOnly = true;
            this.CardConstantName.Width = 160;
            // 
            // CardConstantAttack
            // 
            this.CardConstantAttack.DataPropertyName = "Attack";
            this.CardConstantAttack.HeaderText = "Atk";
            this.CardConstantAttack.MaxInputLength = 4;
            this.CardConstantAttack.MinimumWidth = 6;
            this.CardConstantAttack.Name = "CardConstantAttack";
            this.CardConstantAttack.Width = 40;
            // 
            // CardConstantDefense
            // 
            this.CardConstantDefense.DataPropertyName = "Defense";
            this.CardConstantDefense.HeaderText = "Def";
            this.CardConstantDefense.MaxInputLength = 4;
            this.CardConstantDefense.MinimumWidth = 6;
            this.CardConstantDefense.Name = "CardConstantDefense";
            this.CardConstantDefense.Width = 40;
            // 
            // CardConstantsType
            // 
            this.CardConstantsType.DataPropertyName = "Type";
            this.CardConstantsType.HeaderText = "Type";
            this.CardConstantsType.MinimumWidth = 6;
            this.CardConstantsType.Name = "CardConstantsType";
            this.CardConstantsType.ReadOnly = true;
            this.CardConstantsType.Width = 60;
            // 
            // CardConstantsAttribute
            // 
            this.CardConstantsAttribute.DataPropertyName = "AttributeName";
            this.CardConstantsAttribute.HeaderText = "Attr.";
            this.CardConstantsAttribute.MinimumWidth = 6;
            this.CardConstantsAttribute.Name = "CardConstantsAttribute";
            this.CardConstantsAttribute.ReadOnly = true;
            this.CardConstantsAttribute.Width = 50;
            // 
            // CardConstantsLevel
            // 
            this.CardConstantsLevel.DataPropertyName = "Level";
            this.CardConstantsLevel.HeaderText = "Lvl";
            this.CardConstantsLevel.MinimumWidth = 6;
            this.CardConstantsLevel.Name = "CardConstantsLevel";
            this.CardConstantsLevel.Width = 30;
            // 
            // CardConstantDeckCost
            // 
            this.CardConstantDeckCost.DataPropertyName = "DeckCost";
            this.CardConstantDeckCost.HeaderText = "DC";
            this.CardConstantDeckCost.MinimumWidth = 6;
            this.CardConstantDeckCost.Name = "CardConstantDeckCost";
            this.CardConstantDeckCost.Width = 30;
            // 
            // CardConstantSlots
            // 
            this.CardConstantSlots.DataPropertyName = "AppearsInSlotReels";
            this.CardConstantSlots.HeaderText = "Slots";
            this.CardConstantSlots.MinimumWidth = 6;
            this.CardConstantSlots.Name = "CardConstantSlots";
            this.CardConstantSlots.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CardConstantSlots.Width = 40;
            // 
            // CardConstantIsSlotRare
            // 
            this.CardConstantIsSlotRare.DataPropertyName = "IsSlotRare";
            this.CardConstantIsSlotRare.HeaderText = "Slot Rare";
            this.CardConstantIsSlotRare.MinimumWidth = 6;
            this.CardConstantIsSlotRare.Name = "CardConstantIsSlotRare";
            this.CardConstantIsSlotRare.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CardConstantIsSlotRare.Width = 40;
            // 
            // CardConstantReincarnation
            // 
            this.CardConstantReincarnation.DataPropertyName = "AppearsInReincarnation";
            this.CardConstantReincarnation.FalseValue = "false";
            this.CardConstantReincarnation.HeaderText = "Reinc.";
            this.CardConstantReincarnation.IndeterminateValue = "false";
            this.CardConstantReincarnation.MinimumWidth = 6;
            this.CardConstantReincarnation.Name = "CardConstantReincarnation";
            this.CardConstantReincarnation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CardConstantReincarnation.TrueValue = "true";
            this.CardConstantReincarnation.Width = 46;
            // 
            // CardConstantPasswordWorks
            // 
            this.CardConstantPasswordWorks.DataPropertyName = "PasswordWorks";
            this.CardConstantPasswordWorks.HeaderText = "PWD Works";
            this.CardConstantPasswordWorks.MinimumWidth = 6;
            this.CardConstantPasswordWorks.Name = "CardConstantPasswordWorks";
            this.CardConstantPasswordWorks.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CardConstantPasswordWorks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.CardConstantPasswordWorks.Width = 46;
            // 
            // leaderRankTresholdsTab
            // 
            this.leaderRankTresholdsTab.Controls.Add(this.textBox2);
            this.leaderRankTresholdsTab.Controls.Add(this.textBox1);
            this.leaderRankTresholdsTab.Controls.Add(this.newRankThresholdsTextbox);
            this.leaderRankTresholdsTab.Controls.Add(this.originalRankThresholdsTextbox);
            this.leaderRankTresholdsTab.Controls.Add(this.rankThresholdsSaveButton);
            this.leaderRankTresholdsTab.Controls.Add(this.rankThresholdsDataGridView);
            this.leaderRankTresholdsTab.Location = new System.Drawing.Point(4, 27);
            this.leaderRankTresholdsTab.Name = "leaderRankTresholdsTab";
            this.leaderRankTresholdsTab.Padding = new System.Windows.Forms.Padding(3);
            this.leaderRankTresholdsTab.Size = new System.Drawing.Size(1156, 677);
            this.leaderRankTresholdsTab.TabIndex = 0;
            this.leaderRankTresholdsTab.Text = "Rank Thresholds";
            this.leaderRankTresholdsTab.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Window;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(326, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(71, 17);
            this.textBox2.TabIndex = 22;
            this.textBox2.Text = "New Bytes:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(326, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(71, 17);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = "Orignal Bytes:";
            // 
            // newRankThresholdsTextbox
            // 
            this.newRankThresholdsTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.newRankThresholdsTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newRankThresholdsTextbox.Location = new System.Drawing.Point(403, 25);
            this.newRankThresholdsTextbox.Name = "newRankThresholdsTextbox";
            this.newRankThresholdsTextbox.ReadOnly = true;
            this.newRankThresholdsTextbox.Size = new System.Drawing.Size(493, 17);
            this.newRankThresholdsTextbox.TabIndex = 20;
            // 
            // originalRankThresholdsTextbox
            // 
            this.originalRankThresholdsTextbox.BackColor = System.Drawing.SystemColors.Window;
            this.originalRankThresholdsTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.originalRankThresholdsTextbox.Location = new System.Drawing.Point(403, 6);
            this.originalRankThresholdsTextbox.Name = "originalRankThresholdsTextbox";
            this.originalRankThresholdsTextbox.ReadOnly = true;
            this.originalRankThresholdsTextbox.Size = new System.Drawing.Size(493, 17);
            this.originalRankThresholdsTextbox.TabIndex = 0;
            // 
            // rankThresholdsSaveButton
            // 
            this.rankThresholdsSaveButton.Location = new System.Drawing.Point(445, 164);
            this.rankThresholdsSaveButton.Name = "rankThresholdsSaveButton";
            this.rankThresholdsSaveButton.Size = new System.Drawing.Size(75, 25);
            this.rankThresholdsSaveButton.TabIndex = 18;
            this.rankThresholdsSaveButton.Text = "Save";
            this.rankThresholdsSaveButton.UseVisualStyleBackColor = true;
            this.rankThresholdsSaveButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // rankThresholdsDataGridView
            // 
            this.rankThresholdsDataGridView.AllowUserToAddRows = false;
            this.rankThresholdsDataGridView.AllowUserToDeleteRows = false;
            this.rankThresholdsDataGridView.AllowUserToResizeColumns = false;
            this.rankThresholdsDataGridView.AllowUserToResizeRows = false;
            this.rankThresholdsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rankThresholdsDataGridView.Location = new System.Drawing.Point(-4, 0);
            this.rankThresholdsDataGridView.MultiSelect = false;
            this.rankThresholdsDataGridView.Name = "rankThresholdsDataGridView";
            this.rankThresholdsDataGridView.RowHeadersVisible = false;
            this.rankThresholdsDataGridView.RowHeadersWidth = 51;
            this.rankThresholdsDataGridView.RowTemplate.Height = 30;
            this.rankThresholdsDataGridView.Size = new System.Drawing.Size(315, 426);
            this.rankThresholdsDataGridView.TabIndex = 17;
            // 
            // mainTabControl
            // 
            this.mainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTabControl.Controls.Add(this.deckEditorTab);
            this.mainTabControl.Controls.Add(this.cardPropertiesTab);
            this.mainTabControl.Controls.Add(this.deckLeaderAbilitiesTab);
            this.mainTabControl.Controls.Add(this.equipCompabilityTab);
            this.mainTabControl.Controls.Add(this.fusionsTab);
            this.mainTabControl.Controls.Add(this.enemyAiTab);
            this.mainTabControl.Controls.Add(this.hiddenCardsTab);
            this.mainTabControl.Controls.Add(this.leaderRankTresholdsTab);
            this.mainTabControl.Controls.Add(this.batzpupModsTab);
            this.mainTabControl.Controls.Add(this.mapEditorTab);
            this.mainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTabControl.Location = new System.Drawing.Point(0, 27);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1164, 708);
            this.mainTabControl.TabIndex = 3;
            // 
            // deckEditorTab
            // 
            this.deckEditorTab.Controls.Add(this.button1);
            this.deckEditorTab.Controls.Add(this.deckEditorTabSplitContainer);
            this.deckEditorTab.Location = new System.Drawing.Point(4, 27);
            this.deckEditorTab.Name = "deckEditorTab";
            this.deckEditorTab.Padding = new System.Windows.Forms.Padding(3);
            this.deckEditorTab.Size = new System.Drawing.Size(1156, 677);
            this.deckEditorTab.TabIndex = 7;
            this.deckEditorTab.Text = "Deck Editor";
            this.deckEditorTab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // deckEditorTabSplitContainer
            // 
            this.deckEditorTabSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deckEditorTabSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.deckEditorTabSplitContainer.Name = "deckEditorTabSplitContainer";
            // 
            // deckEditorTabSplitContainer.Panel1
            // 
            this.deckEditorTabSplitContainer.Panel1.Controls.Add(this.cardTrunkSplitContainer);
            // 
            // deckEditorTabSplitContainer.Panel2
            // 
            this.deckEditorTabSplitContainer.Panel2.Controls.Add(this.deckEditorSplitContainer);
            this.deckEditorTabSplitContainer.Size = new System.Drawing.Size(1150, 671);
            this.deckEditorTabSplitContainer.SplitterDistance = 569;
            this.deckEditorTabSplitContainer.TabIndex = 0;
            // 
            // cardTrunkSplitContainer
            // 
            this.cardTrunkSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardTrunkSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.cardTrunkSplitContainer.IsSplitterFixed = true;
            this.cardTrunkSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.cardTrunkSplitContainer.Name = "cardTrunkSplitContainer";
            this.cardTrunkSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // cardTrunkSplitContainer.Panel1
            // 
            this.cardTrunkSplitContainer.Panel1.Controls.Add(this.trunkTipLabel);
            this.cardTrunkSplitContainer.Panel1.Controls.Add(this.cardTrunkLabel);
            this.cardTrunkSplitContainer.Panel1.Controls.Add(this.trunkFilterTextBox);
            this.cardTrunkSplitContainer.Panel1.Controls.Add(this.trunkClearFilterButton);
            this.cardTrunkSplitContainer.Panel1.Controls.Add(this.trunkApplyFilterButton);
            this.cardTrunkSplitContainer.Panel1.Controls.Add(this.trunkNameFilterLabel);
            // 
            // cardTrunkSplitContainer.Panel2
            // 
            this.cardTrunkSplitContainer.Panel2.Controls.Add(this.trunkDataGridView);
            this.cardTrunkSplitContainer.Size = new System.Drawing.Size(569, 671);
            this.cardTrunkSplitContainer.SplitterDistance = 60;
            this.cardTrunkSplitContainer.TabIndex = 1;
            // 
            // trunkTipLabel
            // 
            this.trunkTipLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trunkTipLabel.AutoSize = true;
            this.trunkTipLabel.Location = new System.Drawing.Point(272, 11);
            this.trunkTipLabel.Name = "trunkTipLabel";
            this.trunkTipLabel.Size = new System.Drawing.Size(408, 18);
            this.trunkTipLabel.TabIndex = 6;
            this.trunkTipLabel.Text = "Double click card to add to deck, right click for more options.";
            // 
            // cardTrunkLabel
            // 
            this.cardTrunkLabel.AutoSize = true;
            this.cardTrunkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cardTrunkLabel.Location = new System.Drawing.Point(5, 6);
            this.cardTrunkLabel.Name = "cardTrunkLabel";
            this.cardTrunkLabel.Size = new System.Drawing.Size(68, 25);
            this.cardTrunkLabel.TabIndex = 5;
            this.cardTrunkLabel.Text = "Trunk";
            // 
            // trunkFilterTextBox
            // 
            this.trunkFilterTextBox.Location = new System.Drawing.Point(46, 34);
            this.trunkFilterTextBox.Name = "trunkFilterTextBox";
            this.trunkFilterTextBox.Size = new System.Drawing.Size(122, 24);
            this.trunkFilterTextBox.TabIndex = 4;
            this.trunkFilterTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.trunkFilterTextbox_KeyDown);
            // 
            // trunkClearFilterButton
            // 
            this.trunkClearFilterButton.Location = new System.Drawing.Point(255, 32);
            this.trunkClearFilterButton.Name = "trunkClearFilterButton";
            this.trunkClearFilterButton.Size = new System.Drawing.Size(75, 23);
            this.trunkClearFilterButton.TabIndex = 3;
            this.trunkClearFilterButton.Text = "Clear";
            this.trunkClearFilterButton.UseVisualStyleBackColor = true;
            this.trunkClearFilterButton.Click += new System.EventHandler(this.trunkClearButton_Click);
            // 
            // trunkApplyFilterButton
            // 
            this.trunkApplyFilterButton.Location = new System.Drawing.Point(174, 32);
            this.trunkApplyFilterButton.Name = "trunkApplyFilterButton";
            this.trunkApplyFilterButton.Size = new System.Drawing.Size(75, 23);
            this.trunkApplyFilterButton.TabIndex = 2;
            this.trunkApplyFilterButton.Text = "Apply";
            this.trunkApplyFilterButton.UseVisualStyleBackColor = true;
            this.trunkApplyFilterButton.Click += new System.EventHandler(this.trunkSearchButton_Click);
            // 
            // trunkNameFilterLabel
            // 
            this.trunkNameFilterLabel.AutoSize = true;
            this.trunkNameFilterLabel.Location = new System.Drawing.Point(8, 36);
            this.trunkNameFilterLabel.Name = "trunkNameFilterLabel";
            this.trunkNameFilterLabel.Size = new System.Drawing.Size(44, 18);
            this.trunkNameFilterLabel.TabIndex = 1;
            this.trunkNameFilterLabel.Text = "Filter:";
            // 
            // trunkDataGridView
            // 
            this.trunkDataGridView.AllowUserToAddRows = false;
            this.trunkDataGridView.AllowUserToDeleteRows = false;
            this.trunkDataGridView.AllowUserToResizeRows = false;
            this.trunkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trunkDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.nameColumn,
            this.cardTrunkAttackColumn,
            this.cardTrunkDefenseColumn,
            this.cardTrunkLevelColumn,
            this.cardTrunkAttributeColumn,
            this.cardTrunkTypeColumn,
            this.cardTrunkDeckCostColumn});
            this.trunkDataGridView.ContextMenuStrip = this.trunkContextMenuStrip;
            this.trunkDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trunkDataGridView.Location = new System.Drawing.Point(0, 0);
            this.trunkDataGridView.Name = "trunkDataGridView";
            this.trunkDataGridView.RowHeadersVisible = false;
            this.trunkDataGridView.RowHeadersWidth = 51;
            this.trunkDataGridView.Size = new System.Drawing.Size(569, 607);
            this.trunkDataGridView.TabIndex = 0;
            // 
            // Index
            // 
            this.Index.DataPropertyName = "Index";
            this.Index.HeaderText = "#";
            this.Index.MinimumWidth = 6;
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            this.Index.Width = 32;
            // 
            // nameColumn
            // 
            this.nameColumn.DataPropertyName = "Name";
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.MinimumWidth = 6;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Width = 200;
            // 
            // cardTrunkAttackColumn
            // 
            this.cardTrunkAttackColumn.DataPropertyName = "Attack";
            this.cardTrunkAttackColumn.HeaderText = "Attack";
            this.cardTrunkAttackColumn.MinimumWidth = 6;
            this.cardTrunkAttackColumn.Name = "cardTrunkAttackColumn";
            this.cardTrunkAttackColumn.ReadOnly = true;
            this.cardTrunkAttackColumn.Width = 40;
            // 
            // cardTrunkDefenseColumn
            // 
            this.cardTrunkDefenseColumn.DataPropertyName = "Defense";
            this.cardTrunkDefenseColumn.HeaderText = "Defense";
            this.cardTrunkDefenseColumn.MinimumWidth = 6;
            this.cardTrunkDefenseColumn.Name = "cardTrunkDefenseColumn";
            this.cardTrunkDefenseColumn.ReadOnly = true;
            this.cardTrunkDefenseColumn.Width = 40;
            // 
            // cardTrunkLevelColumn
            // 
            this.cardTrunkLevelColumn.DataPropertyName = "Level";
            this.cardTrunkLevelColumn.HeaderText = "Lvl";
            this.cardTrunkLevelColumn.MinimumWidth = 6;
            this.cardTrunkLevelColumn.Name = "cardTrunkLevelColumn";
            this.cardTrunkLevelColumn.ReadOnly = true;
            this.cardTrunkLevelColumn.Width = 30;
            // 
            // cardTrunkAttributeColumn
            // 
            this.cardTrunkAttributeColumn.DataPropertyName = "AttributeName";
            this.cardTrunkAttributeColumn.HeaderText = "Attribute";
            this.cardTrunkAttributeColumn.MinimumWidth = 6;
            this.cardTrunkAttributeColumn.Name = "cardTrunkAttributeColumn";
            this.cardTrunkAttributeColumn.ReadOnly = true;
            this.cardTrunkAttributeColumn.Width = 50;
            // 
            // cardTrunkTypeColumn
            // 
            this.cardTrunkTypeColumn.DataPropertyName = "Type";
            this.cardTrunkTypeColumn.HeaderText = "Type";
            this.cardTrunkTypeColumn.MinimumWidth = 6;
            this.cardTrunkTypeColumn.Name = "cardTrunkTypeColumn";
            this.cardTrunkTypeColumn.ReadOnly = true;
            this.cardTrunkTypeColumn.Width = 125;
            // 
            // cardTrunkDeckCostColumn
            // 
            this.cardTrunkDeckCostColumn.DataPropertyName = "DeckCost";
            this.cardTrunkDeckCostColumn.HeaderText = "DC";
            this.cardTrunkDeckCostColumn.MinimumWidth = 6;
            this.cardTrunkDeckCostColumn.Name = "cardTrunkDeckCostColumn";
            this.cardTrunkDeckCostColumn.ReadOnly = true;
            this.cardTrunkDeckCostColumn.Width = 30;
            // 
            // trunkContextMenuStrip
            // 
            this.trunkContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.trunkContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeDeckLeaderToolStripMenuItem,
            this.addSelectedCardsToDeckToolStripMenuItem});
            this.trunkContextMenuStrip.Name = "trunkContextMenuStrip";
            this.trunkContextMenuStrip.Size = new System.Drawing.Size(258, 52);
            // 
            // makeDeckLeaderToolStripMenuItem
            // 
            this.makeDeckLeaderToolStripMenuItem.Name = "makeDeckLeaderToolStripMenuItem";
            this.makeDeckLeaderToolStripMenuItem.Size = new System.Drawing.Size(257, 24);
            this.makeDeckLeaderToolStripMenuItem.Text = "Make Deck Leader";
            this.makeDeckLeaderToolStripMenuItem.Click += new System.EventHandler(this.makeDeckLeaderToolStripMenuItem_Click);
            // 
            // addSelectedCardsToDeckToolStripMenuItem
            // 
            this.addSelectedCardsToDeckToolStripMenuItem.Name = "addSelectedCardsToDeckToolStripMenuItem";
            this.addSelectedCardsToDeckToolStripMenuItem.Size = new System.Drawing.Size(257, 24);
            this.addSelectedCardsToDeckToolStripMenuItem.Text = "Add selected cards to deck";
            this.addSelectedCardsToDeckToolStripMenuItem.Click += new System.EventHandler(this.addSelectedCardsToDeckToolStripMenuItem_Click);
            // 
            // deckEditorSplitContainer
            // 
            this.deckEditorSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deckEditorSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.deckEditorSplitContainer.IsSplitterFixed = true;
            this.deckEditorSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.deckEditorSplitContainer.Name = "deckEditorSplitContainer";
            this.deckEditorSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // deckEditorSplitContainer.Panel1
            // 
            this.deckEditorSplitContainer.Panel1.Controls.Add(this.deckEditTipLabel);
            this.deckEditorSplitContainer.Panel1.Controls.Add(this.deckEditDeckCostLabel);
            this.deckEditorSplitContainer.Panel1.Controls.Add(this.deckEditDeckLeaderRankComboBox);
            this.deckEditorSplitContainer.Panel1.Controls.Add(this.deckCardCountLabel);
            this.deckEditorSplitContainer.Panel1.Controls.Add(this.decksLabel);
            this.deckEditorSplitContainer.Panel1.Controls.Add(this.deckLabel);
            this.deckEditorSplitContainer.Panel1.Controls.Add(this.deckDropdown);
            this.deckEditorSplitContainer.Panel1.Controls.Add(this.deckEditSaveButton);
            // 
            // deckEditorSplitContainer.Panel2
            // 
            this.deckEditorSplitContainer.Panel2.Controls.Add(this.deckEditorDataGridView);
            this.deckEditorSplitContainer.Size = new System.Drawing.Size(577, 671);
            this.deckEditorSplitContainer.SplitterDistance = 60;
            this.deckEditorSplitContainer.TabIndex = 0;
            // 
            // deckEditTipLabel
            // 
            this.deckEditTipLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deckEditTipLabel.AutoSize = true;
            this.deckEditTipLabel.Location = new System.Drawing.Point(245, 11);
            this.deckEditTipLabel.Name = "deckEditTipLabel";
            this.deckEditTipLabel.Size = new System.Drawing.Size(458, 18);
            this.deckEditTipLabel.TabIndex = 10;
            this.deckEditTipLabel.Text = "Double click to remove card from deck. Right click for more options.";
            // 
            // deckEditDeckCostLabel
            // 
            this.deckEditDeckCostLabel.AutoSize = true;
            this.deckEditDeckCostLabel.Location = new System.Drawing.Point(369, 37);
            this.deckEditDeckCostLabel.Name = "deckEditDeckCostLabel";
            this.deckEditDeckCostLabel.Size = new System.Drawing.Size(66, 18);
            this.deckEditDeckCostLabel.TabIndex = 9;
            this.deckEditDeckCostLabel.Text = "7777 DC";
            // 
            // deckEditDeckLeaderRankComboBox
            // 
            this.deckEditDeckLeaderRankComboBox.DisplayMember = "Name";
            this.deckEditDeckLeaderRankComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deckEditDeckLeaderRankComboBox.FormattingEnabled = true;
            this.deckEditDeckLeaderRankComboBox.Location = new System.Drawing.Point(301, 33);
            this.deckEditDeckLeaderRankComboBox.Name = "deckEditDeckLeaderRankComboBox";
            this.deckEditDeckLeaderRankComboBox.Size = new System.Drawing.Size(57, 26);
            this.deckEditDeckLeaderRankComboBox.TabIndex = 8;
            this.deckEditDeckLeaderRankComboBox.ValueMember = "Index";
            this.deckEditDeckLeaderRankComboBox.SelectedIndexChanged += new System.EventHandler(this.deckEditDeckLeaderRankComboBox_SelectedIndexChanged);
            // 
            // deckCardCountLabel
            // 
            this.deckCardCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deckCardCountLabel.AutoSize = true;
            this.deckCardCountLabel.Location = new System.Drawing.Point(424, 37);
            this.deckCardCountLabel.Name = "deckCardCountLabel";
            this.deckCardCountLabel.Size = new System.Drawing.Size(92, 18);
            this.deckCardCountLabel.TabIndex = 7;
            this.deckCardCountLabel.Text = "Cards: 40/40";
            // 
            // decksLabel
            // 
            this.decksLabel.AutoSize = true;
            this.decksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decksLabel.Location = new System.Drawing.Point(3, 6);
            this.decksLabel.Name = "decksLabel";
            this.decksLabel.Size = new System.Drawing.Size(72, 25);
            this.decksLabel.TabIndex = 6;
            this.decksLabel.Text = "Decks";
            // 
            // deckLabel
            // 
            this.deckLabel.AutoSize = true;
            this.deckLabel.Location = new System.Drawing.Point(4, 37);
            this.deckLabel.Name = "deckLabel";
            this.deckLabel.Size = new System.Drawing.Size(47, 18);
            this.deckLabel.TabIndex = 2;
            this.deckLabel.Text = "Deck:";
            // 
            // deckDropdown
            // 
            this.deckDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deckDropdown.FormattingEnabled = true;
            this.deckDropdown.Location = new System.Drawing.Point(46, 33);
            this.deckDropdown.Name = "deckDropdown";
            this.deckDropdown.Size = new System.Drawing.Size(249, 26);
            this.deckDropdown.TabIndex = 1;
            this.deckDropdown.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // deckEditSaveButton
            // 
            this.deckEditSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deckEditSaveButton.Location = new System.Drawing.Point(499, 31);
            this.deckEditSaveButton.Name = "deckEditSaveButton";
            this.deckEditSaveButton.Size = new System.Drawing.Size(75, 25);
            this.deckEditSaveButton.TabIndex = 0;
            this.deckEditSaveButton.Text = "Save";
            this.deckEditSaveButton.UseVisualStyleBackColor = true;
            this.deckEditSaveButton.Click += new System.EventHandler(this.deckEditSaveButton_Click);
            // 
            // deckEditorDataGridView
            // 
            this.deckEditorDataGridView.AllowUserToAddRows = false;
            this.deckEditorDataGridView.AllowUserToDeleteRows = false;
            this.deckEditorDataGridView.AllowUserToResizeRows = false;
            this.deckEditorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deckEditorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.indexColumn,
            this.deckTableNameColumn,
            this.deckEditAttackColumn,
            this.deckEditDefenseColumn,
            this.deckEditLevelColumn,
            this.deckEditAttributeColumn,
            this.deckEditTypeColumn,
            this.deckEditDeckCostColumn});
            this.deckEditorDataGridView.ContextMenuStrip = this.deckEditContextMenuStrip;
            this.deckEditorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deckEditorDataGridView.Location = new System.Drawing.Point(0, 0);
            this.deckEditorDataGridView.Name = "deckEditorDataGridView";
            this.deckEditorDataGridView.RowHeadersVisible = false;
            this.deckEditorDataGridView.RowHeadersWidth = 51;
            this.deckEditorDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deckEditorDataGridView.Size = new System.Drawing.Size(577, 607);
            this.deckEditorDataGridView.TabIndex = 0;
            // 
            // indexColumn
            // 
            this.indexColumn.DataPropertyName = "Number";
            this.indexColumn.HeaderText = "#";
            this.indexColumn.MinimumWidth = 6;
            this.indexColumn.Name = "indexColumn";
            this.indexColumn.ReadOnly = true;
            this.indexColumn.Width = 32;
            // 
            // deckTableNameColumn
            // 
            this.deckTableNameColumn.DataPropertyName = "Name";
            this.deckTableNameColumn.HeaderText = "Name";
            this.deckTableNameColumn.MinimumWidth = 6;
            this.deckTableNameColumn.Name = "deckTableNameColumn";
            this.deckTableNameColumn.ReadOnly = true;
            this.deckTableNameColumn.Width = 200;
            // 
            // deckEditAttackColumn
            // 
            this.deckEditAttackColumn.DataPropertyName = "Attack";
            this.deckEditAttackColumn.HeaderText = "Attack";
            this.deckEditAttackColumn.MinimumWidth = 6;
            this.deckEditAttackColumn.Name = "deckEditAttackColumn";
            this.deckEditAttackColumn.ReadOnly = true;
            this.deckEditAttackColumn.Width = 40;
            // 
            // deckEditDefenseColumn
            // 
            this.deckEditDefenseColumn.DataPropertyName = "Defense";
            this.deckEditDefenseColumn.HeaderText = "Defense";
            this.deckEditDefenseColumn.MinimumWidth = 6;
            this.deckEditDefenseColumn.Name = "deckEditDefenseColumn";
            this.deckEditDefenseColumn.ReadOnly = true;
            this.deckEditDefenseColumn.Width = 40;
            // 
            // deckEditLevelColumn
            // 
            this.deckEditLevelColumn.DataPropertyName = "Level";
            this.deckEditLevelColumn.HeaderText = "Lvl";
            this.deckEditLevelColumn.MinimumWidth = 6;
            this.deckEditLevelColumn.Name = "deckEditLevelColumn";
            this.deckEditLevelColumn.ReadOnly = true;
            this.deckEditLevelColumn.Width = 30;
            // 
            // deckEditAttributeColumn
            // 
            this.deckEditAttributeColumn.DataPropertyName = "Attribute";
            this.deckEditAttributeColumn.HeaderText = "Attribute";
            this.deckEditAttributeColumn.MinimumWidth = 6;
            this.deckEditAttributeColumn.Name = "deckEditAttributeColumn";
            this.deckEditAttributeColumn.ReadOnly = true;
            this.deckEditAttributeColumn.Width = 50;
            // 
            // deckEditTypeColumn
            // 
            this.deckEditTypeColumn.DataPropertyName = "Type";
            this.deckEditTypeColumn.HeaderText = "Type";
            this.deckEditTypeColumn.MinimumWidth = 6;
            this.deckEditTypeColumn.Name = "deckEditTypeColumn";
            this.deckEditTypeColumn.ReadOnly = true;
            this.deckEditTypeColumn.Width = 125;
            // 
            // deckEditDeckCostColumn
            // 
            this.deckEditDeckCostColumn.DataPropertyName = "DeckCost";
            this.deckEditDeckCostColumn.HeaderText = "DC";
            this.deckEditDeckCostColumn.MinimumWidth = 6;
            this.deckEditDeckCostColumn.Name = "deckEditDeckCostColumn";
            this.deckEditDeckCostColumn.ReadOnly = true;
            this.deckEditDeckCostColumn.Width = 30;
            // 
            // deckEditContextMenuStrip
            // 
            this.deckEditContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.deckEditContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deckEditRemoveSelectedMenuItem});
            this.deckEditContextMenuStrip.Name = "deckEditContextMenuStrip";
            this.deckEditContextMenuStrip.Size = new System.Drawing.Size(231, 28);
            // 
            // deckEditRemoveSelectedMenuItem
            // 
            this.deckEditRemoveSelectedMenuItem.Name = "deckEditRemoveSelectedMenuItem";
            this.deckEditRemoveSelectedMenuItem.Size = new System.Drawing.Size(230, 24);
            this.deckEditRemoveSelectedMenuItem.Text = "Remove selected cards";
            // 
            // deckLeaderAbilitiesTab
            // 
            this.deckLeaderAbilitiesTab.Controls.Add(this.cardDeckLeaderAbilitiesSplitContainer);
            this.deckLeaderAbilitiesTab.Location = new System.Drawing.Point(4, 27);
            this.deckLeaderAbilitiesTab.Name = "deckLeaderAbilitiesTab";
            this.deckLeaderAbilitiesTab.Padding = new System.Windows.Forms.Padding(3);
            this.deckLeaderAbilitiesTab.Size = new System.Drawing.Size(1156, 677);
            this.deckLeaderAbilitiesTab.TabIndex = 5;
            this.deckLeaderAbilitiesTab.Text = "Deck Leader Abilities";
            this.deckLeaderAbilitiesTab.UseVisualStyleBackColor = true;
            // 
            // cardDeckLeaderAbilitiesSplitContainer
            // 
            this.cardDeckLeaderAbilitiesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardDeckLeaderAbilitiesSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.cardDeckLeaderAbilitiesSplitContainer.Location = new System.Drawing.Point(3, 3);
            this.cardDeckLeaderAbilitiesSplitContainer.Name = "cardDeckLeaderAbilitiesSplitContainer";
            this.cardDeckLeaderAbilitiesSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // cardDeckLeaderAbilitiesSplitContainer.Panel1
            // 
            this.cardDeckLeaderAbilitiesSplitContainer.Panel1.Controls.Add(this.deckLeaderAbilityTabTipsLabel);
            this.cardDeckLeaderAbilitiesSplitContainer.Panel1.Controls.Add(this.deckLeaderAbilitiesSaveButton);
            // 
            // cardDeckLeaderAbilitiesSplitContainer.Panel2
            // 
            this.cardDeckLeaderAbilitiesSplitContainer.Panel2.Controls.Add(this.cardDeckLeaderAbilitiesDatagridview);
            this.cardDeckLeaderAbilitiesSplitContainer.Size = new System.Drawing.Size(1150, 671);
            this.cardDeckLeaderAbilitiesSplitContainer.SplitterDistance = 25;
            this.cardDeckLeaderAbilitiesSplitContainer.TabIndex = 0;
            // 
            // deckLeaderAbilityTabTipsLabel
            // 
            this.deckLeaderAbilityTabTipsLabel.AutoSize = true;
            this.deckLeaderAbilityTabTipsLabel.Location = new System.Drawing.Point(5, 8);
            this.deckLeaderAbilityTabTipsLabel.Name = "deckLeaderAbilityTabTipsLabel";
            this.deckLeaderAbilityTabTipsLabel.Size = new System.Drawing.Size(572, 18);
            this.deckLeaderAbilityTabTipsLabel.TabIndex = 2;
            this.deckLeaderAbilityTabTipsLabel.Text = "Select multiple records with shift or control keys, right click to edit deck lead" +
    "er abilities.";
            // 
            // deckLeaderAbilitiesSaveButton
            // 
            this.deckLeaderAbilitiesSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.deckLeaderAbilitiesSaveButton.Location = new System.Drawing.Point(1075, 0);
            this.deckLeaderAbilitiesSaveButton.Name = "deckLeaderAbilitiesSaveButton";
            this.deckLeaderAbilitiesSaveButton.Size = new System.Drawing.Size(75, 25);
            this.deckLeaderAbilitiesSaveButton.TabIndex = 0;
            this.deckLeaderAbilitiesSaveButton.Text = "Save";
            this.deckLeaderAbilitiesSaveButton.UseVisualStyleBackColor = true;
            this.deckLeaderAbilitiesSaveButton.Click += new System.EventHandler(this.deckLeaderAbilitiesSaveButton_Click);
            // 
            // cardDeckLeaderAbilitiesDatagridview
            // 
            this.cardDeckLeaderAbilitiesDatagridview.AllowUserToAddRows = false;
            this.cardDeckLeaderAbilitiesDatagridview.AllowUserToDeleteRows = false;
            this.cardDeckLeaderAbilitiesDatagridview.AllowUserToResizeRows = false;
            this.cardDeckLeaderAbilitiesDatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cardDeckLeaderAbilitiesDatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cardDeckLeaderAbilitiesIndexColumn,
            this.cardDeckLeaderAbilitiesNameColumn,
            this.cardDeckLeaderAbilitiesEnabledAbilitiesColumn,
            this.Bytes});
            this.cardDeckLeaderAbilitiesDatagridview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardDeckLeaderAbilitiesDatagridview.Location = new System.Drawing.Point(0, 0);
            this.cardDeckLeaderAbilitiesDatagridview.Name = "cardDeckLeaderAbilitiesDatagridview";
            this.cardDeckLeaderAbilitiesDatagridview.RowHeadersVisible = false;
            this.cardDeckLeaderAbilitiesDatagridview.RowHeadersWidth = 51;
            this.cardDeckLeaderAbilitiesDatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cardDeckLeaderAbilitiesDatagridview.Size = new System.Drawing.Size(1150, 642);
            this.cardDeckLeaderAbilitiesDatagridview.TabIndex = 0;
            // 
            // cardDeckLeaderAbilitiesIndexColumn
            // 
            this.cardDeckLeaderAbilitiesIndexColumn.DataPropertyName = "Index";
            this.cardDeckLeaderAbilitiesIndexColumn.HeaderText = "Index";
            this.cardDeckLeaderAbilitiesIndexColumn.MinimumWidth = 6;
            this.cardDeckLeaderAbilitiesIndexColumn.Name = "cardDeckLeaderAbilitiesIndexColumn";
            this.cardDeckLeaderAbilitiesIndexColumn.ReadOnly = true;
            this.cardDeckLeaderAbilitiesIndexColumn.Width = 30;
            // 
            // cardDeckLeaderAbilitiesNameColumn
            // 
            this.cardDeckLeaderAbilitiesNameColumn.DataPropertyName = "Name";
            this.cardDeckLeaderAbilitiesNameColumn.HeaderText = "Name";
            this.cardDeckLeaderAbilitiesNameColumn.MinimumWidth = 6;
            this.cardDeckLeaderAbilitiesNameColumn.Name = "cardDeckLeaderAbilitiesNameColumn";
            this.cardDeckLeaderAbilitiesNameColumn.ReadOnly = true;
            this.cardDeckLeaderAbilitiesNameColumn.Width = 140;
            // 
            // cardDeckLeaderAbilitiesEnabledAbilitiesColumn
            // 
            this.cardDeckLeaderAbilitiesEnabledAbilitiesColumn.DataPropertyName = "EnabledAbilitiesString";
            this.cardDeckLeaderAbilitiesEnabledAbilitiesColumn.HeaderText = "Enabled Abilities";
            this.cardDeckLeaderAbilitiesEnabledAbilitiesColumn.MinimumWidth = 6;
            this.cardDeckLeaderAbilitiesEnabledAbilitiesColumn.Name = "cardDeckLeaderAbilitiesEnabledAbilitiesColumn";
            this.cardDeckLeaderAbilitiesEnabledAbilitiesColumn.ReadOnly = true;
            this.cardDeckLeaderAbilitiesEnabledAbilitiesColumn.Width = 800;
            // 
            // Bytes
            // 
            this.Bytes.DataPropertyName = "Bytes";
            this.Bytes.HeaderText = "Bytes";
            this.Bytes.MinimumWidth = 6;
            this.Bytes.Name = "Bytes";
            this.Bytes.Visible = false;
            this.Bytes.Width = 125;
            // 
            // equipCompabilityTab
            // 
            this.equipCompabilityTab.Controls.Add(this.equipCompabilitySplitContainer);
            this.equipCompabilityTab.Location = new System.Drawing.Point(4, 27);
            this.equipCompabilityTab.Name = "equipCompabilityTab";
            this.equipCompabilityTab.Padding = new System.Windows.Forms.Padding(3);
            this.equipCompabilityTab.Size = new System.Drawing.Size(1156, 677);
            this.equipCompabilityTab.TabIndex = 6;
            this.equipCompabilityTab.Text = "Equip Compatibility";
            this.equipCompabilityTab.UseVisualStyleBackColor = true;
            // 
            // equipCompabilitySplitContainer
            // 
            this.equipCompabilitySplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipCompabilitySplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.equipCompabilitySplitContainer.IsSplitterFixed = true;
            this.equipCompabilitySplitContainer.Location = new System.Drawing.Point(3, 3);
            this.equipCompabilitySplitContainer.Name = "equipCompabilitySplitContainer";
            this.equipCompabilitySplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // equipCompabilitySplitContainer.Panel1
            // 
            this.equipCompabilitySplitContainer.Panel1.Controls.Add(this.cardEquipNoteLabel1);
            this.equipCompabilitySplitContainer.Panel1.Controls.Add(this.equipCompatibilitySaveButton);
            // 
            // equipCompabilitySplitContainer.Panel2
            // 
            this.equipCompabilitySplitContainer.Panel2.Controls.Add(this.equipCompatibilityDataGridView);
            this.equipCompabilitySplitContainer.Size = new System.Drawing.Size(1150, 671);
            this.equipCompabilitySplitContainer.SplitterDistance = 25;
            this.equipCompabilitySplitContainer.TabIndex = 0;
            // 
            // cardEquipNoteLabel1
            // 
            this.cardEquipNoteLabel1.AutoSize = true;
            this.cardEquipNoteLabel1.Location = new System.Drawing.Point(5, 8);
            this.cardEquipNoteLabel1.Name = "cardEquipNoteLabel1";
            this.cardEquipNoteLabel1.Size = new System.Drawing.Size(576, 18);
            this.cardEquipNoteLabel1.TabIndex = 1;
            this.cardEquipNoteLabel1.Text = "Select multiple records with shift or control keys, right click to edit equip com" +
    "patibilities.";
            // 
            // equipCompatibilitySaveButton
            // 
            this.equipCompatibilitySaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.equipCompatibilitySaveButton.Location = new System.Drawing.Point(1075, 0);
            this.equipCompatibilitySaveButton.Name = "equipCompatibilitySaveButton";
            this.equipCompatibilitySaveButton.Size = new System.Drawing.Size(75, 25);
            this.equipCompatibilitySaveButton.TabIndex = 0;
            this.equipCompatibilitySaveButton.Text = "Save";
            this.equipCompatibilitySaveButton.UseVisualStyleBackColor = true;
            this.equipCompatibilitySaveButton.Click += new System.EventHandler(this.equipCompatibilitySaveButton_Click);
            // 
            // equipCompatibilityDataGridView
            // 
            this.equipCompatibilityDataGridView.AllowUserToAddRows = false;
            this.equipCompatibilityDataGridView.AllowUserToDeleteRows = false;
            this.equipCompatibilityDataGridView.AllowUserToResizeRows = false;
            this.equipCompatibilityDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipCompatibilityDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EquipCompatabilityCardIndexColumn,
            this.EquipCompatabilityCardNameColumn,
            this.CompatibleEquipCountColumn,
            this.EquipCompatabilityEquipCardsColumn});
            this.equipCompatibilityDataGridView.ContextMenuStrip = this.monsterCardEquipCompatibilitiesContextMenuStrip;
            this.equipCompatibilityDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipCompatibilityDataGridView.Location = new System.Drawing.Point(0, 0);
            this.equipCompatibilityDataGridView.Name = "equipCompatibilityDataGridView";
            this.equipCompatibilityDataGridView.RowHeadersVisible = false;
            this.equipCompatibilityDataGridView.RowHeadersWidth = 51;
            this.equipCompatibilityDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.equipCompatibilityDataGridView.Size = new System.Drawing.Size(1150, 642);
            this.equipCompatibilityDataGridView.TabIndex = 0;
            // 
            // EquipCompatabilityCardIndexColumn
            // 
            this.EquipCompatabilityCardIndexColumn.DataPropertyName = "Index";
            this.EquipCompatabilityCardIndexColumn.Frozen = true;
            this.EquipCompatabilityCardIndexColumn.HeaderText = "Index";
            this.EquipCompatabilityCardIndexColumn.MinimumWidth = 40;
            this.EquipCompatabilityCardIndexColumn.Name = "EquipCompatabilityCardIndexColumn";
            this.EquipCompatabilityCardIndexColumn.ReadOnly = true;
            this.EquipCompatabilityCardIndexColumn.Width = 40;
            // 
            // EquipCompatabilityCardNameColumn
            // 
            this.EquipCompatabilityCardNameColumn.DataPropertyName = "Name";
            this.EquipCompatabilityCardNameColumn.Frozen = true;
            this.EquipCompatabilityCardNameColumn.HeaderText = "Monster Name";
            this.EquipCompatabilityCardNameColumn.MinimumWidth = 6;
            this.EquipCompatabilityCardNameColumn.Name = "EquipCompatabilityCardNameColumn";
            this.EquipCompatabilityCardNameColumn.ReadOnly = true;
            this.EquipCompatabilityCardNameColumn.Width = 140;
            // 
            // CompatibleEquipCountColumn
            // 
            this.CompatibleEquipCountColumn.DataPropertyName = "CompatibleEquipCount";
            this.CompatibleEquipCountColumn.HeaderText = "Count";
            this.CompatibleEquipCountColumn.MinimumWidth = 40;
            this.CompatibleEquipCountColumn.Name = "CompatibleEquipCountColumn";
            this.CompatibleEquipCountColumn.ReadOnly = true;
            this.CompatibleEquipCountColumn.ToolTipText = "Number of compatible equip cards";
            this.CompatibleEquipCountColumn.Width = 40;
            // 
            // EquipCompatabilityEquipCardsColumn
            // 
            this.EquipCompatabilityEquipCardsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.EquipCompatabilityEquipCardsColumn.DataPropertyName = "CompatibleEquipNames";
            this.EquipCompatabilityEquipCardsColumn.HeaderText = "Compatible Equip Cards";
            this.EquipCompatabilityEquipCardsColumn.MinimumWidth = 400;
            this.EquipCompatabilityEquipCardsColumn.Name = "EquipCompatabilityEquipCardsColumn";
            this.EquipCompatabilityEquipCardsColumn.ReadOnly = true;
            // 
            // monsterCardEquipCompatibilitiesContextMenuStrip
            // 
            this.monsterCardEquipCompatibilitiesContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.monsterCardEquipCompatibilitiesContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMonsterEquipMenuItem});
            this.monsterCardEquipCompatibilitiesContextMenuStrip.Name = "monsterCardEquipCompatibilitiesContextMenuStrip";
            this.monsterCardEquipCompatibilitiesContextMenuStrip.Size = new System.Drawing.Size(204, 28);
            // 
            // editMonsterEquipMenuItem
            // 
            this.editMonsterEquipMenuItem.Name = "editMonsterEquipMenuItem";
            this.editMonsterEquipMenuItem.Size = new System.Drawing.Size(203, 24);
            this.editMonsterEquipMenuItem.Text = "Edit selected items";
            this.editMonsterEquipMenuItem.Click += new System.EventHandler(this.ShowMonsterCardEquipCompatibilityEditDialog);
            // 
            // batzpupModsTab
            // 
            this.batzpupModsTab.Controls.Add(this.scBatzpupSave);
            this.batzpupModsTab.Location = new System.Drawing.Point(4, 27);
            this.batzpupModsTab.Name = "batzpupModsTab";
            this.batzpupModsTab.Padding = new System.Windows.Forms.Padding(3);
            this.batzpupModsTab.Size = new System.Drawing.Size(1156, 677);
            this.batzpupModsTab.TabIndex = 8;
            this.batzpupModsTab.Text = "Batzpup Mods";
            this.batzpupModsTab.UseVisualStyleBackColor = true;
            // 
            // scBatzpupSave
            // 
            this.scBatzpupSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBatzpupSave.Location = new System.Drawing.Point(3, 3);
            this.scBatzpupSave.Name = "scBatzpupSave";
            this.scBatzpupSave.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scBatzpupSave.Panel1
            // 
            this.scBatzpupSave.Panel1.Controls.Add(this.BatzpupSaveButton);
            // 
            // scBatzpupSave.Panel2
            // 
            this.scBatzpupSave.Panel2.Controls.Add(this.tbBatzpup);
            this.scBatzpupSave.Size = new System.Drawing.Size(1150, 671);
            this.scBatzpupSave.SplitterDistance = 55;
            this.scBatzpupSave.TabIndex = 0;
            // 
            // BatzpupSaveButton
            // 
            this.BatzpupSaveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BatzpupSaveButton.Location = new System.Drawing.Point(0, 0);
            this.BatzpupSaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BatzpupSaveButton.Name = "BatzpupSaveButton";
            this.BatzpupSaveButton.Size = new System.Drawing.Size(1150, 55);
            this.BatzpupSaveButton.TabIndex = 1;
            this.BatzpupSaveButton.Text = "Save";
            this.BatzpupSaveButton.UseVisualStyleBackColor = true;
            this.BatzpupSaveButton.Click += new System.EventHandler(this.BatzpupSaveButton_Click);
            // 
            // tbBatzpup
            // 
            this.tbBatzpup.Controls.Add(this.batzpupTbMain);
            this.tbBatzpup.Controls.Add(this.tbBatzpupSlotRewards);
            this.tbBatzpup.Controls.Add(this.tabPage4);
            this.tbBatzpup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbBatzpup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBatzpup.Location = new System.Drawing.Point(0, 0);
            this.tbBatzpup.Name = "tbBatzpup";
            this.tbBatzpup.SelectedIndex = 0;
            this.tbBatzpup.Size = new System.Drawing.Size(1150, 612);
            this.tbBatzpup.TabIndex = 1;
            this.tbBatzpup.SelectedIndexChanged += new System.EventHandler(this.tbBatzpups_SelectedIndexChanged);
            // 
            // batzpupTbMain
            // 
            this.batzpupTbMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.batzpupTbMain.Controls.Add(this.scBatzpupMain);
            this.batzpupTbMain.Location = new System.Drawing.Point(4, 27);
            this.batzpupTbMain.Name = "batzpupTbMain";
            this.batzpupTbMain.Padding = new System.Windows.Forms.Padding(3);
            this.batzpupTbMain.Size = new System.Drawing.Size(1142, 581);
            this.batzpupTbMain.TabIndex = 0;
            this.batzpupTbMain.Text = "Main";
            // 
            // scBatzpupMain
            // 
            this.scBatzpupMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBatzpupMain.Location = new System.Drawing.Point(3, 3);
            this.scBatzpupMain.Name = "scBatzpupMain";
            // 
            // scBatzpupMain.Panel1
            // 
            this.scBatzpupMain.Panel1.Controls.Add(this.cbCrushCardChange);
            this.scBatzpupMain.Panel1.Controls.Add(this.cbNoDCRequirementPostGame);
            this.scBatzpupMain.Panel1.Controls.Add(this.cbKeepReincarnatedCard);
            this.scBatzpupMain.Panel1.Controls.Add(this.cbAddAddtionalSlotRewards);
            this.scBatzpupMain.Panel1.Controls.Add(this.cbAllowAllCustomDuels);
            this.scBatzpupMain.Panel1.Controls.Add(this.cbUseCustomMusic);
            this.scBatzpupMain.Panel1.Controls.Add(this.cbRemoveRNGFromSlots);
            this.scBatzpupMain.Panel1.Controls.Add(this.cbRemoveNegetiveXP);
            this.scBatzpupMain.Panel1.Controls.Add(this.cbExpandedZoom);
            this.scBatzpupMain.Panel1.Controls.Add(this.cbEmulatorCameraFix);
            this.scBatzpupMain.Panel1.Controls.Add(this.cbAllFusions);
            this.scBatzpupMain.Panel1.Controls.Add(this.cbFastIntro);
            this.scBatzpupMain.Panel1.Controls.Add(this.cbAIInputFix);
            // 
            // scBatzpupMain.Panel2
            // 
            this.scBatzpupMain.Panel2.Controls.Add(this.gbLeaderLPRecovery);
            this.scBatzpupMain.Panel2.Controls.Add(this.gbChangeTerrainValues);
            this.scBatzpupMain.Panel2.Controls.Add(this.gbReincarnationCount);
            this.scBatzpupMain.Panel2.Controls.Add(this.gbChangeLpCap);
            this.scBatzpupMain.Panel2.Controls.Add(this.gbForceNewGameSide);
            this.scBatzpupMain.Panel2.Controls.Add(this.gpSideToGoFirst);
            this.scBatzpupMain.Size = new System.Drawing.Size(1136, 575);
            this.scBatzpupMain.SplitterDistance = 521;
            this.scBatzpupMain.TabIndex = 0;
            // 
            // cbNoDCRequirementPostGame
            // 
            this.cbNoDCRequirementPostGame.AutoSize = true;
            this.cbNoDCRequirementPostGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbNoDCRequirementPostGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNoDCRequirementPostGame.Location = new System.Drawing.Point(0, 440);
            this.cbNoDCRequirementPostGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNoDCRequirementPostGame.Name = "cbNoDCRequirementPostGame";
            this.cbNoDCRequirementPostGame.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.cbNoDCRequirementPostGame.Size = new System.Drawing.Size(521, 40);
            this.cbNoDCRequirementPostGame.TabIndex = 22;
            this.cbNoDCRequirementPostGame.Text = "No DC Requirement Post Game";
            this.cbNoDCRequirementPostGame.UseVisualStyleBackColor = true;
            // 
            // cbKeepReincarnatedCard
            // 
            this.cbKeepReincarnatedCard.AutoSize = true;
            this.cbKeepReincarnatedCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbKeepReincarnatedCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKeepReincarnatedCard.Location = new System.Drawing.Point(0, 400);
            this.cbKeepReincarnatedCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbKeepReincarnatedCard.Name = "cbKeepReincarnatedCard";
            this.cbKeepReincarnatedCard.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.cbKeepReincarnatedCard.Size = new System.Drawing.Size(521, 40);
            this.cbKeepReincarnatedCard.TabIndex = 21;
            this.cbKeepReincarnatedCard.Text = "Keep Reincarnated Card";
            this.cbKeepReincarnatedCard.UseVisualStyleBackColor = true;
            // 
            // cbAddAddtionalSlotRewards
            // 
            this.cbAddAddtionalSlotRewards.AutoSize = true;
            this.cbAddAddtionalSlotRewards.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbAddAddtionalSlotRewards.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAddAddtionalSlotRewards.Location = new System.Drawing.Point(0, 360);
            this.cbAddAddtionalSlotRewards.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAddAddtionalSlotRewards.Name = "cbAddAddtionalSlotRewards";
            this.cbAddAddtionalSlotRewards.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.cbAddAddtionalSlotRewards.Size = new System.Drawing.Size(521, 40);
            this.cbAddAddtionalSlotRewards.TabIndex = 20;
            this.cbAddAddtionalSlotRewards.Text = "Add Additional Slot Rewards";
            this.cbAddAddtionalSlotRewards.UseVisualStyleBackColor = true;
            // 
            // cbAllowAllCustomDuels
            // 
            this.cbAllowAllCustomDuels.AutoSize = true;
            this.cbAllowAllCustomDuels.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbAllowAllCustomDuels.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAllowAllCustomDuels.Location = new System.Drawing.Point(0, 320);
            this.cbAllowAllCustomDuels.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAllowAllCustomDuels.Name = "cbAllowAllCustomDuels";
            this.cbAllowAllCustomDuels.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.cbAllowAllCustomDuels.Size = new System.Drawing.Size(521, 40);
            this.cbAllowAllCustomDuels.TabIndex = 19;
            this.cbAllowAllCustomDuels.Text = "Use All Custom Duels";
            this.cbAllowAllCustomDuels.UseVisualStyleBackColor = true;
            // 
            // cbUseCustomMusic
            // 
            this.cbUseCustomMusic.AutoSize = true;
            this.cbUseCustomMusic.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbUseCustomMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUseCustomMusic.Location = new System.Drawing.Point(0, 280);
            this.cbUseCustomMusic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUseCustomMusic.Name = "cbUseCustomMusic";
            this.cbUseCustomMusic.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.cbUseCustomMusic.Size = new System.Drawing.Size(521, 40);
            this.cbUseCustomMusic.TabIndex = 18;
            this.cbUseCustomMusic.Text = "Use Custom Music";
            this.cbUseCustomMusic.UseVisualStyleBackColor = true;
            // 
            // cbRemoveRNGFromSlots
            // 
            this.cbRemoveRNGFromSlots.AutoSize = true;
            this.cbRemoveRNGFromSlots.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbRemoveRNGFromSlots.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRemoveRNGFromSlots.Location = new System.Drawing.Point(0, 240);
            this.cbRemoveRNGFromSlots.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRemoveRNGFromSlots.Name = "cbRemoveRNGFromSlots";
            this.cbRemoveRNGFromSlots.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.cbRemoveRNGFromSlots.Size = new System.Drawing.Size(521, 40);
            this.cbRemoveRNGFromSlots.TabIndex = 17;
            this.cbRemoveRNGFromSlots.Text = "Remove RNG from slots";
            this.cbRemoveRNGFromSlots.UseVisualStyleBackColor = true;
            // 
            // cbRemoveNegetiveXP
            // 
            this.cbRemoveNegetiveXP.AutoSize = true;
            this.cbRemoveNegetiveXP.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbRemoveNegetiveXP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRemoveNegetiveXP.Location = new System.Drawing.Point(0, 200);
            this.cbRemoveNegetiveXP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRemoveNegetiveXP.Name = "cbRemoveNegetiveXP";
            this.cbRemoveNegetiveXP.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.cbRemoveNegetiveXP.Size = new System.Drawing.Size(521, 40);
            this.cbRemoveNegetiveXP.TabIndex = 16;
            this.cbRemoveNegetiveXP.Text = "Remove Exp Loss";
            this.cbRemoveNegetiveXP.UseVisualStyleBackColor = true;
            // 
            // cbExpandedZoom
            // 
            this.cbExpandedZoom.AutoSize = true;
            this.cbExpandedZoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbExpandedZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExpandedZoom.Location = new System.Drawing.Point(0, 160);
            this.cbExpandedZoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbExpandedZoom.Name = "cbExpandedZoom";
            this.cbExpandedZoom.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.cbExpandedZoom.Size = new System.Drawing.Size(521, 40);
            this.cbExpandedZoom.TabIndex = 15;
            this.cbExpandedZoom.Text = "Expanded zoom";
            this.cbExpandedZoom.UseVisualStyleBackColor = true;
            // 
            // cbEmulatorCameraFix
            // 
            this.cbEmulatorCameraFix.AutoSize = true;
            this.cbEmulatorCameraFix.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbEmulatorCameraFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEmulatorCameraFix.Location = new System.Drawing.Point(0, 120);
            this.cbEmulatorCameraFix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbEmulatorCameraFix.Name = "cbEmulatorCameraFix";
            this.cbEmulatorCameraFix.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.cbEmulatorCameraFix.Size = new System.Drawing.Size(521, 40);
            this.cbEmulatorCameraFix.TabIndex = 14;
            this.cbEmulatorCameraFix.Text = "Emulator camera fix";
            this.cbEmulatorCameraFix.UseVisualStyleBackColor = true;
            // 
            // cbAllFusions
            // 
            this.cbAllFusions.AutoSize = true;
            this.cbAllFusions.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbAllFusions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAllFusions.Location = new System.Drawing.Point(0, 80);
            this.cbAllFusions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAllFusions.Name = "cbAllFusions";
            this.cbAllFusions.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.cbAllFusions.Size = new System.Drawing.Size(521, 40);
            this.cbAllFusions.TabIndex = 13;
            this.cbAllFusions.Text = "Allow non-equip Fusions";
            this.cbAllFusions.UseVisualStyleBackColor = true;
            // 
            // cbFastIntro
            // 
            this.cbFastIntro.AutoSize = true;
            this.cbFastIntro.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbFastIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFastIntro.Location = new System.Drawing.Point(0, 40);
            this.cbFastIntro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFastIntro.Name = "cbFastIntro";
            this.cbFastIntro.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.cbFastIntro.Size = new System.Drawing.Size(521, 40);
            this.cbFastIntro.TabIndex = 12;
            this.cbFastIntro.Text = "Fast intro (recommended)";
            this.cbFastIntro.UseVisualStyleBackColor = true;
            // 
            // cbAIInputFix
            // 
            this.cbAIInputFix.AutoSize = true;
            this.cbAIInputFix.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbAIInputFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAIInputFix.Location = new System.Drawing.Point(0, 0);
            this.cbAIInputFix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAIInputFix.Name = "cbAIInputFix";
            this.cbAIInputFix.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.cbAIInputFix.Size = new System.Drawing.Size(521, 40);
            this.cbAIInputFix.TabIndex = 11;
            this.cbAIInputFix.Text = "AI Passes instead of double X (recommended)";
            this.cbAIInputFix.UseVisualStyleBackColor = true;
            // 
            // gbChangeTerrainValues
            // 
            this.gbChangeTerrainValues.Controls.Add(this.numChangeTerrainValue);
            this.gbChangeTerrainValues.Controls.Add(this.cbTerrainChangeEnabled);
            this.gbChangeTerrainValues.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbChangeTerrainValues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbChangeTerrainValues.Location = new System.Drawing.Point(0, 320);
            this.gbChangeTerrainValues.Margin = new System.Windows.Forms.Padding(3, 10, 3, 2);
            this.gbChangeTerrainValues.Name = "gbChangeTerrainValues";
            this.gbChangeTerrainValues.Padding = new System.Windows.Forms.Padding(5, 10, 3, 10);
            this.gbChangeTerrainValues.Size = new System.Drawing.Size(611, 80);
            this.gbChangeTerrainValues.TabIndex = 20;
            this.gbChangeTerrainValues.TabStop = false;
            this.gbChangeTerrainValues.Text = "Change Terrain Buff";
            // 
            // numChangeTerrainValue
            // 
            this.numChangeTerrainValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.numChangeTerrainValue.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numChangeTerrainValue.Location = new System.Drawing.Point(5, 51);
            this.numChangeTerrainValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numChangeTerrainValue.Maximum = new decimal(new int[] {
            9000,
            0,
            0,
            0});
            this.numChangeTerrainValue.Name = "numChangeTerrainValue";
            this.numChangeTerrainValue.Size = new System.Drawing.Size(603, 24);
            this.numChangeTerrainValue.TabIndex = 11;
            this.numChangeTerrainValue.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // cbTerrainChangeEnabled
            // 
            this.cbTerrainChangeEnabled.AutoSize = true;
            this.cbTerrainChangeEnabled.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbTerrainChangeEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTerrainChangeEnabled.Location = new System.Drawing.Point(5, 27);
            this.cbTerrainChangeEnabled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTerrainChangeEnabled.Name = "cbTerrainChangeEnabled";
            this.cbTerrainChangeEnabled.Size = new System.Drawing.Size(603, 24);
            this.cbTerrainChangeEnabled.TabIndex = 10;
            this.cbTerrainChangeEnabled.Text = "Enabled";
            this.cbTerrainChangeEnabled.UseVisualStyleBackColor = true;
            // 
            // gbReincarnationCount
            // 
            this.gbReincarnationCount.Controls.Add(this.numReincarnationCount);
            this.gbReincarnationCount.Controls.Add(this.cbReincarnationCount);
            this.gbReincarnationCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbReincarnationCount.Location = new System.Drawing.Point(0, 240);
            this.gbReincarnationCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbReincarnationCount.Name = "gbReincarnationCount";
            this.gbReincarnationCount.Padding = new System.Windows.Forms.Padding(5, 10, 3, 10);
            this.gbReincarnationCount.Size = new System.Drawing.Size(611, 80);
            this.gbReincarnationCount.TabIndex = 19;
            this.gbReincarnationCount.TabStop = false;
            this.gbReincarnationCount.Text = "Change Reincarnation Count";
            // 
            // numReincarnationCount
            // 
            this.numReincarnationCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.numReincarnationCount.Location = new System.Drawing.Point(5, 51);
            this.numReincarnationCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numReincarnationCount.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.numReincarnationCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numReincarnationCount.Name = "numReincarnationCount";
            this.numReincarnationCount.Size = new System.Drawing.Size(603, 24);
            this.numReincarnationCount.TabIndex = 11;
            this.numReincarnationCount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // cbReincarnationCount
            // 
            this.cbReincarnationCount.AutoSize = true;
            this.cbReincarnationCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbReincarnationCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbReincarnationCount.Location = new System.Drawing.Point(5, 27);
            this.cbReincarnationCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbReincarnationCount.Name = "cbReincarnationCount";
            this.cbReincarnationCount.Size = new System.Drawing.Size(603, 24);
            this.cbReincarnationCount.TabIndex = 10;
            this.cbReincarnationCount.Text = "Enabled";
            this.cbReincarnationCount.UseVisualStyleBackColor = true;
            // 
            // gbChangeLpCap
            // 
            this.gbChangeLpCap.Controls.Add(this.numLPCap);
            this.gbChangeLpCap.Controls.Add(this.cbLPCap);
            this.gbChangeLpCap.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbChangeLpCap.Location = new System.Drawing.Point(0, 160);
            this.gbChangeLpCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbChangeLpCap.Name = "gbChangeLpCap";
            this.gbChangeLpCap.Padding = new System.Windows.Forms.Padding(5, 10, 3, 10);
            this.gbChangeLpCap.Size = new System.Drawing.Size(611, 80);
            this.gbChangeLpCap.TabIndex = 18;
            this.gbChangeLpCap.TabStop = false;
            this.gbChangeLpCap.Text = "Change LP Cap";
            // 
            // numLPCap
            // 
            this.numLPCap.Dock = System.Windows.Forms.DockStyle.Top;
            this.numLPCap.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numLPCap.Location = new System.Drawing.Point(5, 51);
            this.numLPCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numLPCap.Maximum = new decimal(new int[] {
            65000,
            0,
            0,
            0});
            this.numLPCap.Name = "numLPCap";
            this.numLPCap.Size = new System.Drawing.Size(603, 24);
            this.numLPCap.TabIndex = 11;
            this.numLPCap.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // cbLPCap
            // 
            this.cbLPCap.AutoSize = true;
            this.cbLPCap.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbLPCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLPCap.Location = new System.Drawing.Point(5, 27);
            this.cbLPCap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLPCap.Name = "cbLPCap";
            this.cbLPCap.Size = new System.Drawing.Size(603, 24);
            this.cbLPCap.TabIndex = 10;
            this.cbLPCap.Text = "Enabled";
            this.cbLPCap.UseVisualStyleBackColor = true;
            // 
            // gbForceNewGameSide
            // 
            this.gbForceNewGameSide.Controls.Add(this.cboForceNewGameSide);
            this.gbForceNewGameSide.Controls.Add(this.cbForceNewGameSide);
            this.gbForceNewGameSide.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbForceNewGameSide.Location = new System.Drawing.Point(0, 80);
            this.gbForceNewGameSide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbForceNewGameSide.Name = "gbForceNewGameSide";
            this.gbForceNewGameSide.Padding = new System.Windows.Forms.Padding(5, 10, 3, 10);
            this.gbForceNewGameSide.Size = new System.Drawing.Size(611, 80);
            this.gbForceNewGameSide.TabIndex = 17;
            this.gbForceNewGameSide.TabStop = false;
            this.gbForceNewGameSide.Text = "Force New Game Side";
            // 
            // cboForceNewGameSide
            // 
            this.cboForceNewGameSide.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboForceNewGameSide.FormattingEnabled = true;
            this.cboForceNewGameSide.Items.AddRange(new object[] {
            "Red",
            "White"});
            this.cboForceNewGameSide.Location = new System.Drawing.Point(5, 51);
            this.cboForceNewGameSide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboForceNewGameSide.Name = "cboForceNewGameSide";
            this.cboForceNewGameSide.Size = new System.Drawing.Size(603, 26);
            this.cboForceNewGameSide.TabIndex = 11;
            this.cboForceNewGameSide.Text = "Red";
            // 
            // cbForceNewGameSide
            // 
            this.cbForceNewGameSide.AutoSize = true;
            this.cbForceNewGameSide.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbForceNewGameSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbForceNewGameSide.Location = new System.Drawing.Point(5, 27);
            this.cbForceNewGameSide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbForceNewGameSide.Name = "cbForceNewGameSide";
            this.cbForceNewGameSide.Size = new System.Drawing.Size(603, 24);
            this.cbForceNewGameSide.TabIndex = 10;
            this.cbForceNewGameSide.Text = "Enabled";
            this.cbForceNewGameSide.UseVisualStyleBackColor = true;
            // 
            // gpSideToGoFirst
            // 
            this.gpSideToGoFirst.Controls.Add(this.cboSideFirst);
            this.gpSideToGoFirst.Controls.Add(this.cbSideFirst);
            this.gpSideToGoFirst.Dock = System.Windows.Forms.DockStyle.Top;
            this.gpSideToGoFirst.Location = new System.Drawing.Point(0, 0);
            this.gpSideToGoFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpSideToGoFirst.Name = "gpSideToGoFirst";
            this.gpSideToGoFirst.Padding = new System.Windows.Forms.Padding(5, 10, 3, 10);
            this.gpSideToGoFirst.Size = new System.Drawing.Size(611, 80);
            this.gpSideToGoFirst.TabIndex = 16;
            this.gpSideToGoFirst.TabStop = false;
            this.gpSideToGoFirst.Text = "Side To Go First";
            // 
            // cboSideFirst
            // 
            this.cboSideFirst.Dock = System.Windows.Forms.DockStyle.Top;
            this.cboSideFirst.FormattingEnabled = true;
            this.cboSideFirst.Items.AddRange(new object[] {
            "Red",
            "White"});
            this.cboSideFirst.Location = new System.Drawing.Point(5, 51);
            this.cboSideFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboSideFirst.Name = "cboSideFirst";
            this.cboSideFirst.Size = new System.Drawing.Size(603, 26);
            this.cboSideFirst.TabIndex = 11;
            this.cboSideFirst.Text = "Red";
            // 
            // cbSideFirst
            // 
            this.cbSideFirst.AutoSize = true;
            this.cbSideFirst.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbSideFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSideFirst.Location = new System.Drawing.Point(5, 27);
            this.cbSideFirst.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbSideFirst.Name = "cbSideFirst";
            this.cbSideFirst.Size = new System.Drawing.Size(603, 24);
            this.cbSideFirst.TabIndex = 10;
            this.cbSideFirst.Text = "Enabled";
            this.cbSideFirst.UseVisualStyleBackColor = true;
            // 
            // tbBatzpupSlotRewards
            // 
            this.tbBatzpupSlotRewards.Controls.Add(this.dgvSlotRewards);
            this.tbBatzpupSlotRewards.Location = new System.Drawing.Point(4, 27);
            this.tbBatzpupSlotRewards.Name = "tbBatzpupSlotRewards";
            this.tbBatzpupSlotRewards.Padding = new System.Windows.Forms.Padding(3);
            this.tbBatzpupSlotRewards.Size = new System.Drawing.Size(1142, 583);
            this.tbBatzpupSlotRewards.TabIndex = 1;
            this.tbBatzpupSlotRewards.Text = "Slot Rewards";
            this.tbBatzpupSlotRewards.UseVisualStyleBackColor = true;
            // 
            // dgvSlotRewards
            // 
            this.dgvSlotRewards.AllowUserToAddRows = false;
            this.dgvSlotRewards.AllowUserToDeleteRows = false;
            this.dgvSlotRewards.AllowUserToOrderColumns = true;
            this.dgvSlotRewards.AllowUserToResizeColumns = false;
            this.dgvSlotRewards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSlotRewards.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSlotRewards.ColumnHeadersHeight = 29;
            this.dgvSlotRewards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSlotRewards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SlotRewardNumber,
            this.ThreeInARow,
            this.SlotReward});
            this.dgvSlotRewards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSlotRewards.Location = new System.Drawing.Point(3, 3);
            this.dgvSlotRewards.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSlotRewards.MultiSelect = false;
            this.dgvSlotRewards.Name = "dgvSlotRewards";
            this.dgvSlotRewards.RowHeadersVisible = false;
            this.dgvSlotRewards.RowHeadersWidth = 51;
            this.dgvSlotRewards.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSlotRewards.RowTemplate.Height = 24;
            this.dgvSlotRewards.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSlotRewards.Size = new System.Drawing.Size(1136, 577);
            this.dgvSlotRewards.TabIndex = 1;
            // 
            // SlotRewardNumber
            // 
            this.SlotRewardNumber.FillWeight = 99.91187F;
            this.SlotRewardNumber.HeaderText = "Index";
            this.SlotRewardNumber.MinimumWidth = 6;
            this.SlotRewardNumber.Name = "SlotRewardNumber";
            this.SlotRewardNumber.ReadOnly = true;
            // 
            // ThreeInARow
            // 
            this.ThreeInARow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThreeInARow.FillWeight = 100.1759F;
            this.ThreeInARow.HeaderText = "Three In A Row";
            this.ThreeInARow.Items.AddRange(new object[] {
            "Blue-Eyes White Dragon",
            "Seiyaryu",
            "Blue-Eyes Ultimate Dragon",
            "Kaiser Dragon",
            "Blackland Fire Dragon",
            "Koumori Dragon",
            "Curse of Dragon",
            "Red-Eyes B. Dragon",
            "Darkfire Dragon",
            "B. Skull Dragon",
            "Tri-Horned Dragon",
            "Serpent Night Dragon",
            "Mikazukinoyaiba",
            "Yamadron",
            "Meteor B. Dragon",
            "Tyhone #2",
            "Ryu-Ran",
            "Manga Ryu-Ran",
            "Crawling Dragon",
            "Meteor Dragon",
            "B. Dragon Jungle King",
            "Baby Dragon",
            "Winged Dragon, Guardian of the Fortress #1",
            "Gaia the Dragon Champion",
            "Thousand Dragon",
            "Yamatano Dragon Scroll",
            "Petit Dragon",
            "One-Eyed Shield Dragon",
            "Wicked Dragon with the Ersatz Head",
            "Parrot Dragon",
            "Harpie\'s Pet Dragon",
            "Sky Dragon",
            "Lesser Dragon",
            "Fairy Dragon",
            "Twin-Headed Behemoth",
            "Mystical Elf",
            "Time Wizard",
            "Rogue Doll",
            "White Magical Hat",
            "LaMoon",
            "Lucky Trinket",
            "Genin",
            "Fairy\'s Gift",
            "Magician of Faith",
            "Ancient Elf",
            "Maha Vailo",
            "Musician King",
            "Eldeen",
            "Lady of Faith",
            "Ill Witch",
            "Maiden of the Moonlight",
            "The Stern Mystic",
            "Neo the Magic Swordsman",
            "The Unhappy Maiden",
            "Right Leg of the Forbidden One",
            "Left Leg of the Forbidden One",
            "Right Arm of the Forbidden One",
            "Left Arm of the Forbidden One",
            "Exodia the Forbidden One",
            "Saggi the Dark Clown",
            "Dark Magician",
            "Illusionist Faceless Mage",
            "Curtain of the Dark Ones",
            "Kamionwizard",
            "Nemuriko",
            "Necrolancer the Timelord",
            "The Bewitching Phantom Thief",
            "Phantom Dewan",
            "Akakieisu",
            "Masked Sorcerer",
            "Fairywitch",
            "Ancient Sorcerer",
            "Sectarian of Secrets",
            "Mystic Lamp",
            "Boo Koo",
            "Skull Knight",
            "Cosmo Queen",
            "Mask of Shine & Dark",
            "Magician of Black Chaos",
            "Dark Elf",
            "Witch of the Black Forest",
            "Witch\'s Apprentice",
            "Sorcerer of the Doomed",
            "Lord of D.",
            "Invitation to a Dark Sleep",
            "Hannibal Necromancer",
            "The Illusory Gentleman",
            "Dark Magician Girl",
            "Flame Manipulator",
            "Dryad",
            "Tao the Chanter",
            "Spirit of the Mountain",
            "Gemini Elf",
            "Leo Wizard",
            "Rock Spirit",
            "Injection Fairy Lily",
            "Spirit of the Winds",
            "Djinn the Watcher of the Wind",
            "Hurricail",
            "Kazejin",
            "Aqua Madoor",
            "Shadow Specter",
            "Skull Servant",
            "Zombie Warrior",
            "The Snake Hair",
            "Armored Zombie",
            "Dragon Zombie",
            "Clown Zombie",
            "Pumpking the King of Ghosts",
            "Graveyard and the Hand of Invitation",
            "The 13th Grave",
            "Fiend\'s Hand",
            "Blue-Eyed Silver Zombie",
            "Temple of Skulls",
            "Dokuroizo the Grim Reaper",
            "Fire Reaper",
            "Mech Mole Zombie",
            "Phantom Ghost",
            "Flame Ghost",
            "Wood Remains",
            "Dark Assailant",
            "Yaranzo",
            "Three-Legged Zombies",
            "Shadow Ghoul",
            "Magical Ghost",
            "Corroding Shark",
            "Skelgon",
            "Bone Mouse",
            "Dokurorider",
            "The Wandering Doomed",
            "Great Mammoth of Goldfine",
            "Ghoul with an Appetite",
            "Patrician of Darkness",
            "Moon Envoy",
            "Giltia the D. Knight",
            "Skull Guardian",
            "Luminous Soldier",
            "Kageningen",
            "Masked Clown",
            "Fiend Sword",
            "Skull Stalker",
            "Vishwar Randi",
            "Unknown Warrior of Fiend",
            "Black Luster Soldier",
            "Wall Shadow",
            "Gate Guardian",
            "Swordstalker",
            "Hungry Burger",
            "Garma Sword",
            "Greenkappa",
            "Succubus Knight",
            "Flame Swordsman",
            "Tactical Warrior",
            "Swamp Battleguard",
            "Judge Man",
            "Gaia The Fierce Knight",
            "Celtic Guardian",
            "Karbonala Warrior",
            "Kojikocy",
            "Axe Raider",
            "Zanki",
            "Battle Warrior",
            "Hero of the East",
            "Supporter in the Shadows",
            "Dream Clown",
            "Ansatsu",
            "Dragon Statue",
            "Monster Egg",
            "Rhaimundos of the Red Sword",
            "Hard Armor",
            "M-Warrior #1",
            "M-Warrior #2",
            "The Judgement Hand",
            "Mysterious Puppeteer",
            "Armaill",
            "Eyearmor",
            "Doron",
            "Kagemusha of the Blue Flame",
            "Trap Master",
            "Wood Clown",
            "Beautiful Headhuntress",
            "Wodan the Resident of the Forest",
            "Guardian of the Labyrinth",
            "Dimensional Warrior",
            "Protector of the Throne",
            "Masaki the Legendary Swordsman",
            "Sonic Maid",
            "Kanan the Swordmistress",
            "Stuffed Animal",
            "Millennium Shield",
            "Monster Tamer",
            "Swordsman from a Foreign Land",
            "Beautiful Beast Trainer",
            "Armed Ninja",
            "D. Human",
            "Performance of Sword",
            "Mushroom Man #2",
            "Lava Battleguard",
            "Oscillo Hero",
            "Empress Judge",
            "Warrior of Tradition",
            "Queen\'s Double",
            "Invader of the Throne",
            "Hibikime",
            "Princess of Tsurugi",
            "Dragoness the Wicked Knight",
            "Hyo",
            "The Little Swordsman of Aile",
            "Garoozis",
            "Hitotsu-Me Giant",
            "Battle Steer",
            "Battle Ox",
            "Beaver Warrior",
            "Mountain Warrior",
            "Tiger Axe",
            "Rabid Horseman",
            "Solitude",
            "One Who Hunts Souls",
            "Ogre of the Black Shadow",
            "Rude Kaiser",
            "Sengenjin",
            "Nekogal #2",
            "Panther Warrior",
            "Wolf Axwielder",
            "Gate Deeg",
            "Dark Rabbit",
            "Firewing Pegasus",
            "Little Chimera",
            "The Wicked Worm Beast",
            "Griffore",
            "Torike",
            "Wolf",
            "Silver Fang",
            "Mystic Horseman",
            "Dark Gray",
            "Sleeping Lion",
            "Larvas",
            "Dig Beak",
            "Lisark",
            "Synchar",
            "Fusionist",
            "Frenzied Panda",
            "Air Marmot of Nefariousness",
            "Meotoko",
            "Master & Expert",
            "Nekogal #1",
            "Prevent Rat",
            "Mystical Sheep #2",
            "Super War-Lion",
            "Leogun",
            "Tatsunootoshigo",
            "Burglar",
            "Garvas",
            "Flower Wolf",
            "Wilmee",
            "Milus Radiant",
            "Togex",
            "Hane-Hane",
            "Ancient One of the Deep Forest",
            "Mon Larvas",
            "Pale Beast",
            "Obese Marmot of Nefariousness",
            "Great Bill",
            "Armored Rat",
            "Mystical Sheep #1",
            "Gazelle the King of Mythical Beasts",
            "King Tiger Wanghu",
            "Chimera the Flying Mythical Beast",
            "Fiend Reflection #2",
            "Crimson Sunbird",
            "Niwatori",
            "Tyhone",
            "Harpie Lady",
            "Harpie Lady Sisters",
            "Spirit of the Books",
            "Faith Bird",
            "Droll Bird",
            "Mavelus",
            "Kurama",
            "Wing Eagle",
            "Punished Eagle",
            "Skull Red Bird",
            "Queen Bird",
            "Peacock",
            "Skullbird",
            "Monstrous Bird",
            "Winged Dragon, Guardian of the Fortress #2",
            "Crow Goblin",
            "Takuhee",
            "Fiend Reflection #1",
            "Blue-Winged Crown",
            "Birdface",
            "Ryu-Kishin",
            "Feral Imp",
            "Summoned Skull",
            "Horn Imp",
            "Sangan",
            "Kuriboh",
            "Castle of Dark Illusions",
            "Reaper of the Cards",
            "King of Yamimakai",
            "Barox",
            "Dark Chimera",
            "Metal Guardian",
            "Crass Clown",
            "Mask of Darkness",
            "Job-Change Mirror",
            "That Which Feeds on Life",
            "Trial of Nightmare",
            "Witty Phantom",
            "Mystery Hand",
            "The Shadow Who Controls the Dark",
            "Lord of the Lamp",
            "Tainted Wisdom",
            "Lord of Zemia",
            "Dark King of the Abyss",
            "Big Eye",
            "Dark Prisoner",
            "Ancient Brain",
            "Claw Reacher",
            "Terra the Terrible",
            "Mabarrel",
            "Midnight Fiend",
            "Madjinn Gunn",
            "Dark Titan of Terror",
            "The Drdek",
            "Candle of Fate",
            "Meda Bat",
            "Embryonic Beast",
            "Wicked Mirror",
            "Versago the Destroyer",
            "Megirus Light",
            "Gorgon Egg",
            "King Fog",
            "Mystic Clown",
            "Dark Artist",
            "Bio Plant",
            "Zera The Mant",
            "Fiend\'s Mirror",
            "Ryu-Kishin Powered",
            "La Jinn the Mystical Genie of the Lamp",
            "Bickuribox",
            "Zoa",
            "Ushi Oni",
            "Monster Eye",
            "Soul Hunter",
            "Needle Ball",
            "Morinphen",
            "Dragon Seeker",
            "Fungi of the Musk",
            "The Bistro Butcher",
            "Neck Hunter",
            "Chakra",
            "Psycho-Puppet",
            "Invader from Another Dimension",
            "Wretched Ghost of the Attic",
            "Key Mace #2",
            "Hiro\'s Shadow Scout",
            "Whiptail Crow",
            "Man-Eating Treasure Chest",
            "Baron of the Fiend Sword",
            "Wall of Illusion",
            "Toon Summoned Skull",
            "Three-Headed Geedo",
            "Berfomet",
            "Kryuel",
            "Dark Shade",
            "Air Eater",
            "Gyakutenno Megami",
            "Goddess with the Third Eye",
            "Orion the Battle King",
            "Weather Control",
            "Mystical Capture Chain",
            "Spirit of the Harp",
            "Key Mace",
            "Happy Lover",
            "Petit Angel",
            "Hourglass of Life",
            "Lunar Queen Elzaim",
            "Wing Egg Elf",
            "Ray & Temperature",
            "Ocubeam",
            "Goddess of Whim",
            "Hoshiningen",
            "Skelengel",
            "Dark Witch",
            "Binding Chain",
            "Muse-A",
            "Tenderness",
            "Shining Friendship",
            "Hourglass of Courage",
            "Winged Egg of New Life",
            "Airknight Parshath",
            "Doma The Angel of Silence",
            "Dancing Elf",
            "Spiked Snail",
            "Big Insect",
            "Basic Insect",
            "Hercules Beetle",
            "Gokibore",
            "Giant Flea",
            "Larvae Moth",
            "Great Moth",
            "Perfectly Ultimate Great Moth",
            "Nightmare Scorpion",
            "Winged Cleaver",
            "Kumootoko",
            "Petit Moth",
            "Jirai Gumo",
            "Dungeon Worm",
            "Leghul",
            "Ganigumo",
            "Alinsection",
            "Cockroach Knight",
            "Kuwagata α",
            "Korogashi",
            "Kattapillar",
            "Man-Eater Bug",
            "Gale Dogra",
            "Kwagar Hercules",
            "Minar",
            "Kamakiriman",
            "Javelin Beetle",
            "Needle Worm",
            "Giant Scorpion of the Tundra",
            "Hunter Spider",
            "Acid Crawler",
            "Larva of Moth",
            "Pupa of Moth",
            "Arsenal Bug",
            "Killer Needle",
            "Insect Soldiers of the Sky",
            "Bladefly",
            "Sword Arm of Dragon",
            "Two-Headed King Rex",
            "Mammoth Graveyard",
            "Megazowler",
            "Uraby",
            "Crawling Dragon #2",
            "Tomozaurus",
            "Two-Mouth Darkruler",
            "Pragtical",
            "Anthrosaurus",
            "Trakadon",
            "Little D",
            "Bracchio-raidus",
            "Armored Lizard",
            "Serpent Marauder",
            "Yormungarde",
            "Drooling Lizard",
            "Beaked Snake",
            "Ancient Lizard Warrior",
            "Krokodilus",
            "Grappler",
            "Toon Alligator",
            "Emperor of the Land and Sea",
            "Sinister Serpent",
            "Mechaleon",
            "Serpentine Princess",
            "Great White",
            "Rare Fish",
            "Root Water",
            "Enchanting Mermaid",
            "White Dolphin",
            "Deepsea Shark",
            "Bottom Dweller",
            "7 Colored Fish",
            "Rainbow Marine Mermaid",
            "Crazy Fish",
            "Misairuzame",
            "Tongyo",
            "Wow Warrior",
            "Fortress Whale",
            "Man-eating Black Shark",
            "Marine Beast",
            "Amazon of the Seas",
            "Kairyu-Shin",
            "Takriminos",
            "Aqua Dragon",
            "Sea King Dragon",
            "Spike Seadra",
            "Guardian of the Throne Room",
            "Ancient Tool",
            "Gatekeeper",
            "Cyber Soldier of Darkworld",
            "Megasonic Eye",
            "Labyrinth Tank",
            "Pendulum Machine",
            "Metalzoa",
            "Saber Slasher",
            "Yaiba Robo",
            "Cyber Soldier",
            "Mechanicalchaser",
            "Blocker",
            "Spike Clubber",
            "Cyber-Stein",
            "Cyber Commander",
            "Jinzo #7",
            "Cannon Soldier",
            "Brave Scizzar",
            "Dharma Cannon",
            "Red-Eyes Black Metal Dragon",
            "Barrel Dragon",
            "Mechanical Snail",
            "Disk Magician",
            "Slot Machine",
            "Blast Sphere",
            "Space Megatron",
            "Launcher Spider",
            "Blast Juggler",
            "Robotic Knight",
            "Ground Attacker Bugroth",
            "Holograh",
            "Steel Scorpion",
            "Machine King",
            "Giant Mech-Soldier",
            "Mechanical Spider",
            "Giga-tech Wolf",
            "Shovel Crusher",
            "Golgoil",
            "Dice Armadillo",
            "Cyber Saurus",
            "Steel Ogre Grotto #1",
            "Patrol Robo",
            "Royal Guard",
            "Machine Attacker",
            "Steel Ogre Grotto #2",
            "Gear Golem the Moving Fortress",
            "Kinetic Soldier",
            "Metal Dragon",
            "Bat",
            "Metal Fish",
            "Mech Bass",
            "Oscillo Hero #2",
            "Sanga of the Thunder",
            "Thunder Dragon",
            "The Immortal of Thunder",
            "Electric Snake",
            "Twin-Headed Thunder Dragon",
            "Thunder Nyan Nyan",
            "Tripwire Beast",
            "Electric Lizard",
            "LaLa Li-oon",
            "Kaminarikozou",
            "Kaminari Attack",
            "Mega Thunderball",
            "Bolt Escargot",
            "Bolt Penguin",
            "Fire Kraken",
            "Boulder Tortoise",
            "Fiend Kraken",
            "Jellyfish",
            "Catapult Turtle",
            "Octoberser",
            "Toad Master",
            "Akihiron",
            "The Melting Red Shadow",
            "Monsturtle",
            "Turtle Tiger",
            "Arma Knight",
            "Penguin Knight",
            "Dorover",
            "Twin Long Rods #1",
            "Roaring Ocean Snake",
            "Hitodenchak",
            "Water Element",
            "Water Omotics",
            "Beastking of the Swamps",
            "The Furious Sea King",
            "Wetha",
            "Change Slime",
            "Psychic Kappa",
            "Flying Penguin",
            "Suijin",
            "Zone Eater",
            "Ooguchi",
            "Water Magician",
            "Ice Water",
            "Waterdragon Fairy",
            "Water Girl",
            "Turu-Purun",
            "Guardian of the Sea",
            "Aqua Snake",
            "Giant Red Seasnake",
            "30,000-Year White Turtle",
            "Kappa Avenger",
            "Kanikabuto",
            "Zarigun",
            "Sea Kamen",
            "Ameba",
            "Yado Karu",
            "Turtle Raccoon",
            "Turtle Bird",
            "Star Boy",
            "Frog The Jam",
            "Behegon",
            "Crab Turtle",
            "Weather Report",
            "Giant Turtle Who Feeds on Flames",
            "Violent Rain",
            "Penguin Soldier",
            "Liquid Beast",
            "Twin Long Rods #2",
            "Armored Starfish",
            "High Tide Gyojin",
            "Fairy of the Fountain",
            "Night Lizard",
            "Amphibious Bugroth",
            "Gruesome Goo",
            "Hyosube",
            "Red Archery Girl",
            "Toon Mermaid",
            "Maiden of The Aqua",
            "Dragon Piper",
            "Wings of Wicked Flame",
            "Charubin the Fire Knight",
            "Fire Eye",
            "Hinotama Soul",
            "Fireyarou",
            "Vermillion Sparrow",
            "Flame Cerebrus",
            "Jigen Bakudan",
            "Molten Behemoth",
            "Flame Snake",
            "Prisman",
            "Rock Ogre Grotto #1",
            "Giant Soldier of Stone",
            "Ancient Jar",
            "Haniwa",
            "Dissolverock",
            "Stone Armadiller",
            "Rock Ogre Grotto #2",
            "Stone D.",
            "Millennium Golem",
            "Destroyer Golem",
            "Barrel Rock",
            "Minomushi Warrior",
            "Stone Ghost",
            "The Statue of Easter Island",
            "Muka Muka",
            "Sand Stone",
            "Mystical Sand",
            "Pot the Trick",
            "Morphing Jar",
            "The Thing That Hides in the Mud",
            "Stone Ogre Grotto",
            "Stone Statue of the Aztecs",
            "Dark Plant",
            "Rose Spectre of Dunn",
            "Mushroom Man",
            "Man-Eating Plant",
            "Firegrass",
            "Man Eater",
            "Arlownay",
            "Yashinoki",
            "Ancient Tree of Enlightenment",
            "Green Phantom King",
            "Rainbow Flower",
            "Barrel Lily",
            "Laughing Flower",
            "Bean Soldier",
            "Griggle",
            "Darkworld Thorns",
            "Abyss Flower",
            "Living Vase",
            "Snakeyashi",
            "Trent",
            "Queen of Autumn Leaves",
            "Woodland Sprite",
            "Tentacle Plant",
            "Fairy King Truesdale",
            "Summoned Lord Exodia",
            "Jowls of Dark Demise",
            "Souleater",
            "Slate Warrior",
            "Shapesnatch",
            "Carat Idol",
            "Electromagnetic Bagworm",
            "Timeater",
            "Mucus Yolk",
            "Servant of Catabolism",
            "Rigras Leever",
            "Moisture Creature",
            "Dragon Capture Jar",
            "Time Seal",
            "Monster Reborn",
            "Copycat",
            "Mimicat",
            "Graverobber",
            "Forest",
            "Wasteland",
            "Mountain",
            "Sogen",
            "Umi",
            "Yami",
            "Toon World",
            "Burning Land",
            "Labyrinth Wall",
            "Magical Labyrinth",
            "Dark Hole",
            "Raigeki",
            "Heavy Storm",
            "Harpie\'s Feather Duster",
            "Mooyan Curry",
            "Red Medicine",
            "Goblin\'s Secret Remedy",
            "Soul of the Pure",
            "Dian Keto the Cure Master",
            "Gift of The Mystical Elf",
            "Sparks",
            "Hinotama",
            "Final Flame",
            "Ookazi",
            "Tremendous Fire",
            "Just Desserts",
            "Swords of Revealing Light",
            "Dark-Piercing Light",
            "Darkness Approaches",
            "The Eye of Truth",
            "The Inexperienced Spy",
            "Warrior Elimination",
            "Eternal Rest",
            "Stain Storm",
            "Eradicating Aerosol",
            "Breath of Light",
            "Eternal Draught",
            "Fissure",
            "Last Day of Witch",
            "Exile of the Wicked",
            "Dust Tornado",
            "Cold Wave",
            "Fairy Meteor Crush",
            "Change of Heart",
            "Brain Control",
            "Magical Neutralizing Force Field",
            "Winged Trumpeter",
            "Shield & Sword",
            "Yellow Luster Shield",
            "Limiter Removal",
            "Rain of Mercy",
            "Windstorm of Etaqua",
            "Sebek\'s Blessing",
            "Aqua Chorus",
            "Stop Defense",
            "Monster Recovery",
            "Call Of The Haunted",
            "Shift",
            "Solomon\'s Lawbook",
            "Magic Drain",
            "Dimensionhole",
            "Earthshaker",
            "Creature Swap",
            "Legendary Sword",
            "Sword of Dark Destruction",
            "Dark Energy",
            "Axe of Despair",
            "Laser Cannon Armor",
            "Insect Armor with Laser Cannon",
            "Elf\'s Light",
            "Beast Fangs",
            "Steel Shell",
            "Vile Germs",
            "Black Pendant",
            "Silver Bow and Arrow",
            "Horn of Light",
            "Horn of the Unicorn",
            "Dragon Treasure",
            "Electro-Whip",
            "Cyber Shield",
            "Mystical Moon",
            "Malevolent Nuzzler",
            "Book of Secret Arts",
            "Violet Crystal",
            "Invigoration",
            "Machine Conversion Factory",
            "Raise Body Heat",
            "Follow Wind",
            "Power of Kaishin",
            "Kunai with Chain",
            "Salamandra",
            "Megamorph",
            "Bright Castle",
            "Fiend Castle",
            "Hightide",
            "Spring of Rebirth",
            "Gust Fan",
            "Burning Spear",
            "7 Completed",
            "Nails of Bane",
            "Riryoku",
            "Multiply",
            "Sword of Dragon\'s Soul",
            "Enchanted Javelin",
            "Anti-Magic Fragrance",
            "Crush Card",
            "Paralyzing Potion",
            "Cursebreaker",
            "Elegant Egotist",
            "Cocoon of Evolution",
            "Metalmorph",
            "Insect Imitation",
            "Spellbinding Circle",
            "Shadow Spell",
            "Mesmeric Control",
            "Tears of the Mermaid",
            "Infinite Dismissal",
            "Gravity Bind",
            "House of Adhesive Tape",
            "Eatgaboon",
            "Bear Trap",
            "Invisible Wire",
            "Acid Trap Hole",
            "Widespread Ruin",
            "Type Zero Magic Crusher",
            "Goblin Fan",
            "Bad Reaction to Simochi",
            "Reverse Trap",
            "Block Attack",
            "Shadow of Eyes",
            "Gorgon\'s Eye",
            "Fake Trap",
            "Anti Raigeki",
            "Call of the Grave",
            "Magic Jammer",
            "White Hole",
            "Royal Decree",
            "Seal of the Ancients",
            "Mirror Force",
            "Negate Attack",
            "Mirror Wall",
            "Curse of Millennium Shield",
            "Yamadron Ritual",
            "Gate Guardian Ritual",
            "Black Luster Ritual",
            "Zera Ritual",
            "War-Lion Ritual",
            "Beastly Mirror Ritual",
            "Ultimate Dragon",
            "Commencement Dance",
            "Hamburger Recipe",
            "Revival of Sennen Genjin",
            "Novox\'s Prayer",
            "Curse of Tri-Horned Dragon",
            "Revived Serpent Night Dragon",
            "Turtle Oath",
            "Contruct of Mask",
            "Resurrection of Chakra",
            "Puppet Ritual",
            "Javelin Beetle Pact",
            "Garma Sword Oath",
            "Cosmo Queen\'s Prayer",
            "Revival of Dokurorider",
            "Fortress Whale\'s Oath",
            "Dark Magic Ritual"});
            this.ThreeInARow.MinimumWidth = 15;
            this.ThreeInARow.Name = "ThreeInARow";
            this.ThreeInARow.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SlotReward
            // 
            this.SlotReward.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SlotReward.FillWeight = 99.91214F;
            this.SlotReward.HeaderText = "Reward";
            this.SlotReward.Items.AddRange(new object[] {
            "Blue-Eyes White Dragon",
            "Seiyaryu",
            "Blue-Eyes Ultimate Dragon",
            "Kaiser Dragon",
            "Blackland Fire Dragon",
            "Koumori Dragon",
            "Curse of Dragon",
            "Red-Eyes B. Dragon",
            "Darkfire Dragon",
            "B. Skull Dragon",
            "Tri-Horned Dragon",
            "Serpent Night Dragon",
            "Mikazukinoyaiba",
            "Yamadron",
            "Meteor B. Dragon",
            "Tyhone #2",
            "Ryu-Ran",
            "Manga Ryu-Ran",
            "Crawling Dragon",
            "Meteor Dragon",
            "B. Dragon Jungle King",
            "Baby Dragon",
            "Winged Dragon, Guardian of the Fortress #1",
            "Gaia the Dragon Champion",
            "Thousand Dragon",
            "Yamatano Dragon Scroll",
            "Petit Dragon",
            "One-Eyed Shield Dragon",
            "Wicked Dragon with the Ersatz Head",
            "Parrot Dragon",
            "Harpie\'s Pet Dragon",
            "Sky Dragon",
            "Lesser Dragon",
            "Fairy Dragon",
            "Twin-Headed Behemoth",
            "Mystical Elf",
            "Time Wizard",
            "Rogue Doll",
            "White Magical Hat",
            "LaMoon",
            "Lucky Trinket",
            "Genin",
            "Fairy\'s Gift",
            "Magician of Faith",
            "Ancient Elf",
            "Maha Vailo",
            "Musician King",
            "Eldeen",
            "Lady of Faith",
            "Ill Witch",
            "Maiden of the Moonlight",
            "The Stern Mystic",
            "Neo the Magic Swordsman",
            "The Unhappy Maiden",
            "Right Leg of the Forbidden One",
            "Left Leg of the Forbidden One",
            "Right Arm of the Forbidden One",
            "Left Arm of the Forbidden One",
            "Exodia the Forbidden One",
            "Saggi the Dark Clown",
            "Dark Magician",
            "Illusionist Faceless Mage",
            "Curtain of the Dark Ones",
            "Kamionwizard",
            "Nemuriko",
            "Necrolancer the Timelord",
            "The Bewitching Phantom Thief",
            "Phantom Dewan",
            "Akakieisu",
            "Masked Sorcerer",
            "Fairywitch",
            "Ancient Sorcerer",
            "Sectarian of Secrets",
            "Mystic Lamp",
            "Boo Koo",
            "Skull Knight",
            "Cosmo Queen",
            "Mask of Shine & Dark",
            "Magician of Black Chaos",
            "Dark Elf",
            "Witch of the Black Forest",
            "Witch\'s Apprentice",
            "Sorcerer of the Doomed",
            "Lord of D.",
            "Invitation to a Dark Sleep",
            "Hannibal Necromancer",
            "The Illusory Gentleman",
            "Dark Magician Girl",
            "Flame Manipulator",
            "Dryad",
            "Tao the Chanter",
            "Spirit of the Mountain",
            "Gemini Elf",
            "Leo Wizard",
            "Rock Spirit",
            "Injection Fairy Lily",
            "Spirit of the Winds",
            "Djinn the Watcher of the Wind",
            "Hurricail",
            "Kazejin",
            "Aqua Madoor",
            "Shadow Specter",
            "Skull Servant",
            "Zombie Warrior",
            "The Snake Hair",
            "Armored Zombie",
            "Dragon Zombie",
            "Clown Zombie",
            "Pumpking the King of Ghosts",
            "Graveyard and the Hand of Invitation",
            "The 13th Grave",
            "Fiend\'s Hand",
            "Blue-Eyed Silver Zombie",
            "Temple of Skulls",
            "Dokuroizo the Grim Reaper",
            "Fire Reaper",
            "Mech Mole Zombie",
            "Phantom Ghost",
            "Flame Ghost",
            "Wood Remains",
            "Dark Assailant",
            "Yaranzo",
            "Three-Legged Zombies",
            "Shadow Ghoul",
            "Magical Ghost",
            "Corroding Shark",
            "Skelgon",
            "Bone Mouse",
            "Dokurorider",
            "The Wandering Doomed",
            "Great Mammoth of Goldfine",
            "Ghoul with an Appetite",
            "Patrician of Darkness",
            "Moon Envoy",
            "Giltia the D. Knight",
            "Skull Guardian",
            "Luminous Soldier",
            "Kageningen",
            "Masked Clown",
            "Fiend Sword",
            "Skull Stalker",
            "Vishwar Randi",
            "Unknown Warrior of Fiend",
            "Black Luster Soldier",
            "Wall Shadow",
            "Gate Guardian",
            "Swordstalker",
            "Hungry Burger",
            "Garma Sword",
            "Greenkappa",
            "Succubus Knight",
            "Flame Swordsman",
            "Tactical Warrior",
            "Swamp Battleguard",
            "Judge Man",
            "Gaia The Fierce Knight",
            "Celtic Guardian",
            "Karbonala Warrior",
            "Kojikocy",
            "Axe Raider",
            "Zanki",
            "Battle Warrior",
            "Hero of the East",
            "Supporter in the Shadows",
            "Dream Clown",
            "Ansatsu",
            "Dragon Statue",
            "Monster Egg",
            "Rhaimundos of the Red Sword",
            "Hard Armor",
            "M-Warrior #1",
            "M-Warrior #2",
            "The Judgement Hand",
            "Mysterious Puppeteer",
            "Armaill",
            "Eyearmor",
            "Doron",
            "Kagemusha of the Blue Flame",
            "Trap Master",
            "Wood Clown",
            "Beautiful Headhuntress",
            "Wodan the Resident of the Forest",
            "Guardian of the Labyrinth",
            "Dimensional Warrior",
            "Protector of the Throne",
            "Masaki the Legendary Swordsman",
            "Sonic Maid",
            "Kanan the Swordmistress",
            "Stuffed Animal",
            "Millennium Shield",
            "Monster Tamer",
            "Swordsman from a Foreign Land",
            "Beautiful Beast Trainer",
            "Armed Ninja",
            "D. Human",
            "Performance of Sword",
            "Mushroom Man #2",
            "Lava Battleguard",
            "Oscillo Hero",
            "Empress Judge",
            "Warrior of Tradition",
            "Queen\'s Double",
            "Invader of the Throne",
            "Hibikime",
            "Princess of Tsurugi",
            "Dragoness the Wicked Knight",
            "Hyo",
            "The Little Swordsman of Aile",
            "Garoozis",
            "Hitotsu-Me Giant",
            "Battle Steer",
            "Battle Ox",
            "Beaver Warrior",
            "Mountain Warrior",
            "Tiger Axe",
            "Rabid Horseman",
            "Solitude",
            "One Who Hunts Souls",
            "Ogre of the Black Shadow",
            "Rude Kaiser",
            "Sengenjin",
            "Nekogal #2",
            "Panther Warrior",
            "Wolf Axwielder",
            "Gate Deeg",
            "Dark Rabbit",
            "Firewing Pegasus",
            "Little Chimera",
            "The Wicked Worm Beast",
            "Griffore",
            "Torike",
            "Wolf",
            "Silver Fang",
            "Mystic Horseman",
            "Dark Gray",
            "Sleeping Lion",
            "Larvas",
            "Dig Beak",
            "Lisark",
            "Synchar",
            "Fusionist",
            "Frenzied Panda",
            "Air Marmot of Nefariousness",
            "Meotoko",
            "Master & Expert",
            "Nekogal #1",
            "Prevent Rat",
            "Mystical Sheep #2",
            "Super War-Lion",
            "Leogun",
            "Tatsunootoshigo",
            "Burglar",
            "Garvas",
            "Flower Wolf",
            "Wilmee",
            "Milus Radiant",
            "Togex",
            "Hane-Hane",
            "Ancient One of the Deep Forest",
            "Mon Larvas",
            "Pale Beast",
            "Obese Marmot of Nefariousness",
            "Great Bill",
            "Armored Rat",
            "Mystical Sheep #1",
            "Gazelle the King of Mythical Beasts",
            "King Tiger Wanghu",
            "Chimera the Flying Mythical Beast",
            "Fiend Reflection #2",
            "Crimson Sunbird",
            "Niwatori",
            "Tyhone",
            "Harpie Lady",
            "Harpie Lady Sisters",
            "Spirit of the Books",
            "Faith Bird",
            "Droll Bird",
            "Mavelus",
            "Kurama",
            "Wing Eagle",
            "Punished Eagle",
            "Skull Red Bird",
            "Queen Bird",
            "Peacock",
            "Skullbird",
            "Monstrous Bird",
            "Winged Dragon, Guardian of the Fortress #2",
            "Crow Goblin",
            "Takuhee",
            "Fiend Reflection #1",
            "Blue-Winged Crown",
            "Birdface",
            "Ryu-Kishin",
            "Feral Imp",
            "Summoned Skull",
            "Horn Imp",
            "Sangan",
            "Kuriboh",
            "Castle of Dark Illusions",
            "Reaper of the Cards",
            "King of Yamimakai",
            "Barox",
            "Dark Chimera",
            "Metal Guardian",
            "Crass Clown",
            "Mask of Darkness",
            "Job-Change Mirror",
            "That Which Feeds on Life",
            "Trial of Nightmare",
            "Witty Phantom",
            "Mystery Hand",
            "The Shadow Who Controls the Dark",
            "Lord of the Lamp",
            "Tainted Wisdom",
            "Lord of Zemia",
            "Dark King of the Abyss",
            "Big Eye",
            "Dark Prisoner",
            "Ancient Brain",
            "Claw Reacher",
            "Terra the Terrible",
            "Mabarrel",
            "Midnight Fiend",
            "Madjinn Gunn",
            "Dark Titan of Terror",
            "The Drdek",
            "Candle of Fate",
            "Meda Bat",
            "Embryonic Beast",
            "Wicked Mirror",
            "Versago the Destroyer",
            "Megirus Light",
            "Gorgon Egg",
            "King Fog",
            "Mystic Clown",
            "Dark Artist",
            "Bio Plant",
            "Zera The Mant",
            "Fiend\'s Mirror",
            "Ryu-Kishin Powered",
            "La Jinn the Mystical Genie of the Lamp",
            "Bickuribox",
            "Zoa",
            "Ushi Oni",
            "Monster Eye",
            "Soul Hunter",
            "Needle Ball",
            "Morinphen",
            "Dragon Seeker",
            "Fungi of the Musk",
            "The Bistro Butcher",
            "Neck Hunter",
            "Chakra",
            "Psycho-Puppet",
            "Invader from Another Dimension",
            "Wretched Ghost of the Attic",
            "Key Mace #2",
            "Hiro\'s Shadow Scout",
            "Whiptail Crow",
            "Man-Eating Treasure Chest",
            "Baron of the Fiend Sword",
            "Wall of Illusion",
            "Toon Summoned Skull",
            "Three-Headed Geedo",
            "Berfomet",
            "Kryuel",
            "Dark Shade",
            "Air Eater",
            "Gyakutenno Megami",
            "Goddess with the Third Eye",
            "Orion the Battle King",
            "Weather Control",
            "Mystical Capture Chain",
            "Spirit of the Harp",
            "Key Mace",
            "Happy Lover",
            "Petit Angel",
            "Hourglass of Life",
            "Lunar Queen Elzaim",
            "Wing Egg Elf",
            "Ray & Temperature",
            "Ocubeam",
            "Goddess of Whim",
            "Hoshiningen",
            "Skelengel",
            "Dark Witch",
            "Binding Chain",
            "Muse-A",
            "Tenderness",
            "Shining Friendship",
            "Hourglass of Courage",
            "Winged Egg of New Life",
            "Airknight Parshath",
            "Doma The Angel of Silence",
            "Dancing Elf",
            "Spiked Snail",
            "Big Insect",
            "Basic Insect",
            "Hercules Beetle",
            "Gokibore",
            "Giant Flea",
            "Larvae Moth",
            "Great Moth",
            "Perfectly Ultimate Great Moth",
            "Nightmare Scorpion",
            "Winged Cleaver",
            "Kumootoko",
            "Petit Moth",
            "Jirai Gumo",
            "Dungeon Worm",
            "Leghul",
            "Ganigumo",
            "Alinsection",
            "Cockroach Knight",
            "Kuwagata α",
            "Korogashi",
            "Kattapillar",
            "Man-Eater Bug",
            "Gale Dogra",
            "Kwagar Hercules",
            "Minar",
            "Kamakiriman",
            "Javelin Beetle",
            "Needle Worm",
            "Giant Scorpion of the Tundra",
            "Hunter Spider",
            "Acid Crawler",
            "Larva of Moth",
            "Pupa of Moth",
            "Arsenal Bug",
            "Killer Needle",
            "Insect Soldiers of the Sky",
            "Bladefly",
            "Sword Arm of Dragon",
            "Two-Headed King Rex",
            "Mammoth Graveyard",
            "Megazowler",
            "Uraby",
            "Crawling Dragon #2",
            "Tomozaurus",
            "Two-Mouth Darkruler",
            "Pragtical",
            "Anthrosaurus",
            "Trakadon",
            "Little D",
            "Bracchio-raidus",
            "Armored Lizard",
            "Serpent Marauder",
            "Yormungarde",
            "Drooling Lizard",
            "Beaked Snake",
            "Ancient Lizard Warrior",
            "Krokodilus",
            "Grappler",
            "Toon Alligator",
            "Emperor of the Land and Sea",
            "Sinister Serpent",
            "Mechaleon",
            "Serpentine Princess",
            "Great White",
            "Rare Fish",
            "Root Water",
            "Enchanting Mermaid",
            "White Dolphin",
            "Deepsea Shark",
            "Bottom Dweller",
            "7 Colored Fish",
            "Rainbow Marine Mermaid",
            "Crazy Fish",
            "Misairuzame",
            "Tongyo",
            "Wow Warrior",
            "Fortress Whale",
            "Man-eating Black Shark",
            "Marine Beast",
            "Amazon of the Seas",
            "Kairyu-Shin",
            "Takriminos",
            "Aqua Dragon",
            "Sea King Dragon",
            "Spike Seadra",
            "Guardian of the Throne Room",
            "Ancient Tool",
            "Gatekeeper",
            "Cyber Soldier of Darkworld",
            "Megasonic Eye",
            "Labyrinth Tank",
            "Pendulum Machine",
            "Metalzoa",
            "Saber Slasher",
            "Yaiba Robo",
            "Cyber Soldier",
            "Mechanicalchaser",
            "Blocker",
            "Spike Clubber",
            "Cyber-Stein",
            "Cyber Commander",
            "Jinzo #7",
            "Cannon Soldier",
            "Brave Scizzar",
            "Dharma Cannon",
            "Red-Eyes Black Metal Dragon",
            "Barrel Dragon",
            "Mechanical Snail",
            "Disk Magician",
            "Slot Machine",
            "Blast Sphere",
            "Space Megatron",
            "Launcher Spider",
            "Blast Juggler",
            "Robotic Knight",
            "Ground Attacker Bugroth",
            "Holograh",
            "Steel Scorpion",
            "Machine King",
            "Giant Mech-Soldier",
            "Mechanical Spider",
            "Giga-tech Wolf",
            "Shovel Crusher",
            "Golgoil",
            "Dice Armadillo",
            "Cyber Saurus",
            "Steel Ogre Grotto #1",
            "Patrol Robo",
            "Royal Guard",
            "Machine Attacker",
            "Steel Ogre Grotto #2",
            "Gear Golem the Moving Fortress",
            "Kinetic Soldier",
            "Metal Dragon",
            "Bat",
            "Metal Fish",
            "Mech Bass",
            "Oscillo Hero #2",
            "Sanga of the Thunder",
            "Thunder Dragon",
            "The Immortal of Thunder",
            "Electric Snake",
            "Twin-Headed Thunder Dragon",
            "Thunder Nyan Nyan",
            "Tripwire Beast",
            "Electric Lizard",
            "LaLa Li-oon",
            "Kaminarikozou",
            "Kaminari Attack",
            "Mega Thunderball",
            "Bolt Escargot",
            "Bolt Penguin",
            "Fire Kraken",
            "Boulder Tortoise",
            "Fiend Kraken",
            "Jellyfish",
            "Catapult Turtle",
            "Octoberser",
            "Toad Master",
            "Akihiron",
            "The Melting Red Shadow",
            "Monsturtle",
            "Turtle Tiger",
            "Arma Knight",
            "Penguin Knight",
            "Dorover",
            "Twin Long Rods #1",
            "Roaring Ocean Snake",
            "Hitodenchak",
            "Water Element",
            "Water Omotics",
            "Beastking of the Swamps",
            "The Furious Sea King",
            "Wetha",
            "Change Slime",
            "Psychic Kappa",
            "Flying Penguin",
            "Suijin",
            "Zone Eater",
            "Ooguchi",
            "Water Magician",
            "Ice Water",
            "Waterdragon Fairy",
            "Water Girl",
            "Turu-Purun",
            "Guardian of the Sea",
            "Aqua Snake",
            "Giant Red Seasnake",
            "30,000-Year White Turtle",
            "Kappa Avenger",
            "Kanikabuto",
            "Zarigun",
            "Sea Kamen",
            "Ameba",
            "Yado Karu",
            "Turtle Raccoon",
            "Turtle Bird",
            "Star Boy",
            "Frog The Jam",
            "Behegon",
            "Crab Turtle",
            "Weather Report",
            "Giant Turtle Who Feeds on Flames",
            "Violent Rain",
            "Penguin Soldier",
            "Liquid Beast",
            "Twin Long Rods #2",
            "Armored Starfish",
            "High Tide Gyojin",
            "Fairy of the Fountain",
            "Night Lizard",
            "Amphibious Bugroth",
            "Gruesome Goo",
            "Hyosube",
            "Red Archery Girl",
            "Toon Mermaid",
            "Maiden of The Aqua",
            "Dragon Piper",
            "Wings of Wicked Flame",
            "Charubin the Fire Knight",
            "Fire Eye",
            "Hinotama Soul",
            "Fireyarou",
            "Vermillion Sparrow",
            "Flame Cerebrus",
            "Jigen Bakudan",
            "Molten Behemoth",
            "Flame Snake",
            "Prisman",
            "Rock Ogre Grotto #1",
            "Giant Soldier of Stone",
            "Ancient Jar",
            "Haniwa",
            "Dissolverock",
            "Stone Armadiller",
            "Rock Ogre Grotto #2",
            "Stone D.",
            "Millennium Golem",
            "Destroyer Golem",
            "Barrel Rock",
            "Minomushi Warrior",
            "Stone Ghost",
            "The Statue of Easter Island",
            "Muka Muka",
            "Sand Stone",
            "Mystical Sand",
            "Pot the Trick",
            "Morphing Jar",
            "The Thing That Hides in the Mud",
            "Stone Ogre Grotto",
            "Stone Statue of the Aztecs",
            "Dark Plant",
            "Rose Spectre of Dunn",
            "Mushroom Man",
            "Man-Eating Plant",
            "Firegrass",
            "Man Eater",
            "Arlownay",
            "Yashinoki",
            "Ancient Tree of Enlightenment",
            "Green Phantom King",
            "Rainbow Flower",
            "Barrel Lily",
            "Laughing Flower",
            "Bean Soldier",
            "Griggle",
            "Darkworld Thorns",
            "Abyss Flower",
            "Living Vase",
            "Snakeyashi",
            "Trent",
            "Queen of Autumn Leaves",
            "Woodland Sprite",
            "Tentacle Plant",
            "Fairy King Truesdale",
            "Summoned Lord Exodia",
            "Jowls of Dark Demise",
            "Souleater",
            "Slate Warrior",
            "Shapesnatch",
            "Carat Idol",
            "Electromagnetic Bagworm",
            "Timeater",
            "Mucus Yolk",
            "Servant of Catabolism",
            "Rigras Leever",
            "Moisture Creature",
            "Dragon Capture Jar",
            "Time Seal",
            "Monster Reborn",
            "Copycat",
            "Mimicat",
            "Graverobber",
            "Forest",
            "Wasteland",
            "Mountain",
            "Sogen",
            "Umi",
            "Yami",
            "Toon World",
            "Burning Land",
            "Labyrinth Wall",
            "Magical Labyrinth",
            "Dark Hole",
            "Raigeki",
            "Heavy Storm",
            "Harpie\'s Feather Duster",
            "Mooyan Curry",
            "Red Medicine",
            "Goblin\'s Secret Remedy",
            "Soul of the Pure",
            "Dian Keto the Cure Master",
            "Gift of The Mystical Elf",
            "Sparks",
            "Hinotama",
            "Final Flame",
            "Ookazi",
            "Tremendous Fire",
            "Just Desserts",
            "Swords of Revealing Light",
            "Dark-Piercing Light",
            "Darkness Approaches",
            "The Eye of Truth",
            "The Inexperienced Spy",
            "Warrior Elimination",
            "Eternal Rest",
            "Stain Storm",
            "Eradicating Aerosol",
            "Breath of Light",
            "Eternal Draught",
            "Fissure",
            "Last Day of Witch",
            "Exile of the Wicked",
            "Dust Tornado",
            "Cold Wave",
            "Fairy Meteor Crush",
            "Change of Heart",
            "Brain Control",
            "Magical Neutralizing Force Field",
            "Winged Trumpeter",
            "Shield & Sword",
            "Yellow Luster Shield",
            "Limiter Removal",
            "Rain of Mercy",
            "Windstorm of Etaqua",
            "Sebek\'s Blessing",
            "Aqua Chorus",
            "Stop Defense",
            "Monster Recovery",
            "Call Of The Haunted",
            "Shift",
            "Solomon\'s Lawbook",
            "Magic Drain",
            "Dimensionhole",
            "Earthshaker",
            "Creature Swap",
            "Legendary Sword",
            "Sword of Dark Destruction",
            "Dark Energy",
            "Axe of Despair",
            "Laser Cannon Armor",
            "Insect Armor with Laser Cannon",
            "Elf\'s Light",
            "Beast Fangs",
            "Steel Shell",
            "Vile Germs",
            "Black Pendant",
            "Silver Bow and Arrow",
            "Horn of Light",
            "Horn of the Unicorn",
            "Dragon Treasure",
            "Electro-Whip",
            "Cyber Shield",
            "Mystical Moon",
            "Malevolent Nuzzler",
            "Book of Secret Arts",
            "Violet Crystal",
            "Invigoration",
            "Machine Conversion Factory",
            "Raise Body Heat",
            "Follow Wind",
            "Power of Kaishin",
            "Kunai with Chain",
            "Salamandra",
            "Megamorph",
            "Bright Castle",
            "Fiend Castle",
            "Hightide",
            "Spring of Rebirth",
            "Gust Fan",
            "Burning Spear",
            "7 Completed",
            "Nails of Bane",
            "Riryoku",
            "Multiply",
            "Sword of Dragon\'s Soul",
            "Enchanted Javelin",
            "Anti-Magic Fragrance",
            "Crush Card",
            "Paralyzing Potion",
            "Cursebreaker",
            "Elegant Egotist",
            "Cocoon of Evolution",
            "Metalmorph",
            "Insect Imitation",
            "Spellbinding Circle",
            "Shadow Spell",
            "Mesmeric Control",
            "Tears of the Mermaid",
            "Infinite Dismissal",
            "Gravity Bind",
            "House of Adhesive Tape",
            "Eatgaboon",
            "Bear Trap",
            "Invisible Wire",
            "Acid Trap Hole",
            "Widespread Ruin",
            "Type Zero Magic Crusher",
            "Goblin Fan",
            "Bad Reaction to Simochi",
            "Reverse Trap",
            "Block Attack",
            "Shadow of Eyes",
            "Gorgon\'s Eye",
            "Fake Trap",
            "Anti Raigeki",
            "Call of the Grave",
            "Magic Jammer",
            "White Hole",
            "Royal Decree",
            "Seal of the Ancients",
            "Mirror Force",
            "Negate Attack",
            "Mirror Wall",
            "Curse of Millennium Shield",
            "Yamadron Ritual",
            "Gate Guardian Ritual",
            "Black Luster Ritual",
            "Zera Ritual",
            "War-Lion Ritual",
            "Beastly Mirror Ritual",
            "Ultimate Dragon",
            "Commencement Dance",
            "Hamburger Recipe",
            "Revival of Sennen Genjin",
            "Novox\'s Prayer",
            "Curse of Tri-Horned Dragon",
            "Revived Serpent Night Dragon",
            "Turtle Oath",
            "Contruct of Mask",
            "Resurrection of Chakra",
            "Puppet Ritual",
            "Javelin Beetle Pact",
            "Garma Sword Oath",
            "Cosmo Queen\'s Prayer",
            "Revival of Dokurorider",
            "Fortress Whale\'s Oath",
            "Dark Magic Ritual"});
            this.SlotReward.MinimumWidth = 15;
            this.SlotReward.Name = "SlotReward";
            this.SlotReward.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.scMusicMain);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1142, 583);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Music Editor";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // scMusicMain
            // 
            this.scMusicMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.scMusicMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMusicMain.Location = new System.Drawing.Point(3, 3);
            this.scMusicMain.Name = "scMusicMain";
            // 
            // scMusicMain.Panel1
            // 
            this.scMusicMain.Panel1.Controls.Add(this.lbMusicDuelists);
            // 
            // scMusicMain.Panel2
            // 
            this.scMusicMain.Panel2.Controls.Add(this.scBatzpupMusic2);
            this.scMusicMain.Size = new System.Drawing.Size(1136, 577);
            this.scMusicMain.SplitterDistance = 378;
            this.scMusicMain.TabIndex = 0;
            // 
            // lbMusicDuelists
            // 
            this.lbMusicDuelists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMusicDuelists.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMusicDuelists.FormattingEnabled = true;
            this.lbMusicDuelists.ItemHeight = 18;
            this.lbMusicDuelists.Items.AddRange(new object[] {
            "Tutorial",
            "Seto",
            "Weevil",
            "Rex",
            "Keith",
            "Ishtar",
            "Necromancer",
            "Darkness-ruler",
            "Labyrinth-ruler",
            "Pegasus",
            "Richard",
            "Tea",
            "Tristan",
            "Mai",
            "Mako",
            "Joey",
            "Shadi",
            "Jasper",
            "Bakura",
            "Yugi",
            "MFL Skull Knight",
            "MFL Chakra"});
            this.lbMusicDuelists.Location = new System.Drawing.Point(0, 0);
            this.lbMusicDuelists.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbMusicDuelists.Name = "lbMusicDuelists";
            this.lbMusicDuelists.Size = new System.Drawing.Size(378, 577);
            this.lbMusicDuelists.TabIndex = 1;
            this.lbMusicDuelists.SelectedIndexChanged += new System.EventHandler(this.lbMusicDuelists_SelectedIndexChanged);
            // 
            // scBatzpupMusic2
            // 
            this.scBatzpupMusic2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBatzpupMusic2.Location = new System.Drawing.Point(0, 0);
            this.scBatzpupMusic2.Name = "scBatzpupMusic2";
            // 
            // scBatzpupMusic2.Panel1
            // 
            this.scBatzpupMusic2.Panel1.Controls.Add(this.lbMusicTrack);
            // 
            // scBatzpupMusic2.Panel2
            // 
            this.scBatzpupMusic2.Panel2.Controls.Add(this.scBatzpupMusicPlayer);
            this.scBatzpupMusic2.Size = new System.Drawing.Size(754, 577);
            this.scBatzpupMusic2.SplitterDistance = 333;
            this.scBatzpupMusic2.TabIndex = 0;
            // 
            // lbMusicTrack
            // 
            this.lbMusicTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMusicTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMusicTrack.FormattingEnabled = true;
            this.lbMusicTrack.ItemHeight = 18;
            this.lbMusicTrack.Items.AddRange(new object[] {
            "01OpeningCutscene",
            "02MainMenu",
            "03CustomDuel",
            "04MapMusic",
            "05DeckCreation",
            "06N/A",
            "07TutorialDuel",
            "08BattleMusicRed",
            "09BattleMusicWhite",
            "10Seto",
            "11Yugi",
            "12MFLWhite",
            "13NormalBattle",
            "14MeadowBattle",
            "15MountainBattle",
            "16SeaBattle",
            "17ForestBattle",
            "18WastelandBattle",
            "19CrushBattle",
            "20DarkBattle",
            "21ToonBattle",
            "22LabBattle",
            "23Victory",
            "24NewGame",
            "25SimonSummoning",
            "26SetosArrival",
            "27TalkWithYugi",
            "28YugiArrivesAtDover",
            "29PegasusBetrayal",
            "30DefeatRichardCutscene",
            "31SetoSummoningRitual1",
            "32SetoSummongRitual2",
            "33SummonMFLS",
            "34FindSetosBook",
            "35MakoTheme",
            "36SummonMFLC",
            "37SetoHandsYouBadge",
            "38EndGameYorkist",
            "39N/A",
            "40CustomDuel",
            "41Trade",
            "42Defeat",
            "43Exodia",
            "44MFLRed"});
            this.lbMusicTrack.Location = new System.Drawing.Point(0, 0);
            this.lbMusicTrack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbMusicTrack.Name = "lbMusicTrack";
            this.lbMusicTrack.Size = new System.Drawing.Size(333, 577);
            this.lbMusicTrack.TabIndex = 2;
            this.lbMusicTrack.SelectedIndexChanged += new System.EventHandler(this.lbMusicTrack_SelectedIndexChanged);
            // 
            // scBatzpupMusicPlayer
            // 
            this.scBatzpupMusicPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBatzpupMusicPlayer.Location = new System.Drawing.Point(0, 0);
            this.scBatzpupMusicPlayer.Name = "scBatzpupMusicPlayer";
            this.scBatzpupMusicPlayer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scBatzpupMusicPlayer.Panel1
            // 
            this.scBatzpupMusicPlayer.Panel1.Controls.Add(this.scBatzpupMusicButtons);
            // 
            // scBatzpupMusicPlayer.Panel2
            // 
            this.scBatzpupMusicPlayer.Panel2.BackColor = System.Drawing.Color.White;
            this.scBatzpupMusicPlayer.Panel2.Controls.Add(this.lblCurrentMusic);
            this.scBatzpupMusicPlayer.Panel2.Controls.Add(this.lblCurrentlyPlayingTitle);
            this.scBatzpupMusicPlayer.Panel2.Controls.Add(this.lblVolume);
            this.scBatzpupMusicPlayer.Panel2.Controls.Add(this.tbMusicVolume);
            this.scBatzpupMusicPlayer.Size = new System.Drawing.Size(417, 577);
            this.scBatzpupMusicPlayer.SplitterDistance = 259;
            this.scBatzpupMusicPlayer.TabIndex = 0;
            // 
            // scBatzpupMusicButtons
            // 
            this.scBatzpupMusicButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBatzpupMusicButtons.Location = new System.Drawing.Point(0, 0);
            this.scBatzpupMusicButtons.Name = "scBatzpupMusicButtons";
            this.scBatzpupMusicButtons.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scBatzpupMusicButtons.Panel1
            // 
            this.scBatzpupMusicButtons.Panel1.Controls.Add(this.btnExtractMusic);
            // 
            // scBatzpupMusicButtons.Panel2
            // 
            this.scBatzpupMusicButtons.Panel2.Controls.Add(this.btnToggleMusic);
            this.scBatzpupMusicButtons.Size = new System.Drawing.Size(417, 259);
            this.scBatzpupMusicButtons.SplitterDistance = 129;
            this.scBatzpupMusicButtons.TabIndex = 0;
            // 
            // btnExtractMusic
            // 
            this.btnExtractMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExtractMusic.Location = new System.Drawing.Point(0, 0);
            this.btnExtractMusic.Margin = new System.Windows.Forms.Padding(4);
            this.btnExtractMusic.Name = "btnExtractMusic";
            this.btnExtractMusic.Size = new System.Drawing.Size(417, 129);
            this.btnExtractMusic.TabIndex = 1;
            this.btnExtractMusic.Text = "Extract Music From ISO";
            this.btnExtractMusic.UseVisualStyleBackColor = true;
            this.btnExtractMusic.Click += new System.EventHandler(this.btnExtractMusic_Click);
            // 
            // btnToggleMusic
            // 
            this.btnToggleMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnToggleMusic.Location = new System.Drawing.Point(0, 0);
            this.btnToggleMusic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnToggleMusic.Name = "btnToggleMusic";
            this.btnToggleMusic.Size = new System.Drawing.Size(417, 126);
            this.btnToggleMusic.TabIndex = 2;
            this.btnToggleMusic.Text = "Play";
            this.btnToggleMusic.UseVisualStyleBackColor = true;
            this.btnToggleMusic.Click += new System.EventHandler(this.btnToggleMusic_Click);
            // 
            // lblCurrentMusic
            // 
            this.lblCurrentMusic.AutoSize = true;
            this.lblCurrentMusic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCurrentMusic.Location = new System.Drawing.Point(0, 36);
            this.lblCurrentMusic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentMusic.Name = "lblCurrentMusic";
            this.lblCurrentMusic.Size = new System.Drawing.Size(0, 18);
            this.lblCurrentMusic.TabIndex = 5;
            this.lblCurrentMusic.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCurrentlyPlayingTitle
            // 
            this.lblCurrentlyPlayingTitle.AutoSize = true;
            this.lblCurrentlyPlayingTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCurrentlyPlayingTitle.Location = new System.Drawing.Point(0, 0);
            this.lblCurrentlyPlayingTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentlyPlayingTitle.Name = "lblCurrentlyPlayingTitle";
            this.lblCurrentlyPlayingTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 18);
            this.lblCurrentlyPlayingTitle.Size = new System.Drawing.Size(118, 36);
            this.lblCurrentlyPlayingTitle.TabIndex = 4;
            this.lblCurrentlyPlayingTitle.Text = "CurrentlyPlaying:";
            this.lblCurrentlyPlayingTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(178, 213);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(58, 18);
            this.lblVolume.TabIndex = 3;
            this.lblVolume.Text = "Volume";
            // 
            // tbMusicVolume
            // 
            this.tbMusicVolume.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbMusicVolume.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbMusicVolume.Location = new System.Drawing.Point(0, 258);
            this.tbMusicVolume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbMusicVolume.Name = "tbMusicVolume";
            this.tbMusicVolume.Size = new System.Drawing.Size(417, 56);
            this.tbMusicVolume.TabIndex = 2;
            this.tbMusicVolume.Value = 5;
            this.tbMusicVolume.ValueChanged += new System.EventHandler(this.tbMusicVolume_ValueChanged);
            // 
            // mapEditorTab
            // 
            this.mapEditorTab.Controls.Add(this.mapEditorSaveSplitContainer);
            this.mapEditorTab.Location = new System.Drawing.Point(4, 27);
            this.mapEditorTab.Name = "mapEditorTab";
            this.mapEditorTab.Size = new System.Drawing.Size(1156, 677);
            this.mapEditorTab.TabIndex = 9;
            this.mapEditorTab.Text = "Map Editor";
            this.mapEditorTab.UseVisualStyleBackColor = true;
            // 
            // mapEditorSaveSplitContainer
            // 
            this.mapEditorSaveSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapEditorSaveSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mapEditorSaveSplitContainer.Name = "mapEditorSaveSplitContainer";
            this.mapEditorSaveSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // mapEditorSaveSplitContainer.Panel1
            // 
            this.mapEditorSaveSplitContainer.Panel1.Controls.Add(this.mapEditorSaveButton);
            // 
            // mapEditorSaveSplitContainer.Panel2
            // 
            this.mapEditorSaveSplitContainer.Panel2.Controls.Add(this.scBatzpupEditMap);
            this.mapEditorSaveSplitContainer.Size = new System.Drawing.Size(1156, 677);
            this.mapEditorSaveSplitContainer.SplitterDistance = 25;
            this.mapEditorSaveSplitContainer.TabIndex = 0;
            // 
            // mapEditorSaveButton
            // 
            this.mapEditorSaveButton.Location = new System.Drawing.Point(1078, 3);
            this.mapEditorSaveButton.Name = "mapEditorSaveButton";
            this.mapEditorSaveButton.Size = new System.Drawing.Size(75, 23);
            this.mapEditorSaveButton.TabIndex = 0;
            this.mapEditorSaveButton.Text = "Save";
            this.mapEditorSaveButton.UseVisualStyleBackColor = true;
            this.mapEditorSaveButton.Click += new System.EventHandler(this.mapEditorSaveButton_Click);
            // 
            // scBatzpupEditMap
            // 
            this.scBatzpupEditMap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.scBatzpupEditMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBatzpupEditMap.Location = new System.Drawing.Point(0, 0);
            this.scBatzpupEditMap.Name = "scBatzpupEditMap";
            // 
            // scBatzpupEditMap.Panel1
            // 
            this.scBatzpupEditMap.Panel1.Controls.Add(this.scBatzpupEditDuelMapSelect);
            // 
            // scBatzpupEditMap.Panel2
            // 
            this.scBatzpupEditMap.Panel2.Controls.Add(this.scBatzpupEditMapTiles);
            this.scBatzpupEditMap.Size = new System.Drawing.Size(1156, 648);
            this.scBatzpupEditMap.SplitterDistance = 198;
            this.scBatzpupEditMap.TabIndex = 0;
            // 
            // scBatzpupEditDuelMapSelect
            // 
            this.scBatzpupEditDuelMapSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBatzpupEditDuelMapSelect.Location = new System.Drawing.Point(0, 0);
            this.scBatzpupEditDuelMapSelect.Name = "scBatzpupEditDuelMapSelect";
            this.scBatzpupEditDuelMapSelect.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scBatzpupEditDuelMapSelect.Panel1
            // 
            this.scBatzpupEditDuelMapSelect.Panel1.Controls.Add(this.lblMapToSelect);
            // 
            // scBatzpupEditDuelMapSelect.Panel2
            // 
            this.scBatzpupEditDuelMapSelect.Panel2.Controls.Add(this.lbDuelistMaps);
            this.scBatzpupEditDuelMapSelect.Size = new System.Drawing.Size(198, 648);
            this.scBatzpupEditDuelMapSelect.SplitterDistance = 37;
            this.scBatzpupEditDuelMapSelect.TabIndex = 0;
            // 
            // lblMapToSelect
            // 
            this.lblMapToSelect.AutoSize = true;
            this.lblMapToSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMapToSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMapToSelect.Location = new System.Drawing.Point(0, 0);
            this.lblMapToSelect.Name = "lblMapToSelect";
            this.lblMapToSelect.Size = new System.Drawing.Size(170, 29);
            this.lblMapToSelect.TabIndex = 1;
            this.lblMapToSelect.Text = "Map To Select";
            // 
            // lbDuelistMaps
            // 
            this.lbDuelistMaps.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDuelistMaps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDuelistMaps.FormattingEnabled = true;
            this.lbDuelistMaps.ItemHeight = 18;
            this.lbDuelistMaps.Items.AddRange(new object[] {
            "Tutorial",
            "Seto",
            "Weevil",
            "Rex",
            "Keith",
            "Ishtar",
            "Necromancer",
            "Darkness-ruler",
            "Labyrinth-ruler",
            "Pegasus",
            "Richard",
            "Tea",
            "Tristan",
            "Mai",
            "Mako",
            "Joey",
            "Shadi",
            "Jasper",
            "Bakura",
            "Yugi",
            "Skull Knight",
            "Chakra",
            "Default Map 00",
            "Default Map 01",
            "Default Map 02",
            "Default Map 03",
            "Default Map 04",
            "Default Map 05",
            "Default Map 06",
            "Default Map 07",
            "Default Map 08",
            "Default Map 09",
            "Default Map 10",
            "Default Map 11",
            "Default Map 12",
            "Default Map 13",
            "Default Map 14",
            "Default Map 15",
            "Default Map 16",
            "Default Map 17",
            "Default Map 18",
            "Default Map 19",
            "Default Map 20",
            "Default Map 21",
            "Default Map 22",
            "Default Map 23"});
            this.lbDuelistMaps.Location = new System.Drawing.Point(0, 0);
            this.lbDuelistMaps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lbDuelistMaps.Name = "lbDuelistMaps";
            this.lbDuelistMaps.Size = new System.Drawing.Size(198, 607);
            this.lbDuelistMaps.TabIndex = 2;
            this.lbDuelistMaps.SelectedIndexChanged += new System.EventHandler(this.lbDuelistMaps_SelectedIndexChanged);
            // 
            // scBatzpupEditMapTiles
            // 
            this.scBatzpupEditMapTiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBatzpupEditMapTiles.Location = new System.Drawing.Point(0, 0);
            this.scBatzpupEditMapTiles.Name = "scBatzpupEditMapTiles";
            // 
            // scBatzpupEditMapTiles.Panel1
            // 
            this.scBatzpupEditMapTiles.Panel1.Controls.Add(this.scBatzpupEditMapThanks);
            // 
            // scBatzpupEditMapTiles.Panel2
            // 
            this.scBatzpupEditMapTiles.Panel2.Controls.Add(this.label10);
            this.scBatzpupEditMapTiles.Panel2.Controls.Add(this.lblWhiteSide);
            this.scBatzpupEditMapTiles.Panel2.Controls.Add(this.lblMap);
            this.scBatzpupEditMapTiles.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.EditMap_Paint);
            this.scBatzpupEditMapTiles.Panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.splitContainer4_Panel2_MouseDown);
            this.scBatzpupEditMapTiles.Panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MapEditor_MouseMove);
            this.scBatzpupEditMapTiles.Panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MapEditor_MouseUp);
            this.scBatzpupEditMapTiles.Size = new System.Drawing.Size(954, 648);
            this.scBatzpupEditMapTiles.SplitterDistance = 373;
            this.scBatzpupEditMapTiles.TabIndex = 0;
            // 
            // scBatzpupEditMapThanks
            // 
            this.scBatzpupEditMapThanks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBatzpupEditMapThanks.Location = new System.Drawing.Point(0, 0);
            this.scBatzpupEditMapThanks.Name = "scBatzpupEditMapThanks";
            this.scBatzpupEditMapThanks.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scBatzpupEditMapThanks.Panel1
            // 
            this.scBatzpupEditMapThanks.Panel1.Controls.Add(this.llblDotrMap);
            this.scBatzpupEditMapThanks.Panel1.Controls.Add(this.lblDotrMap);
            // 
            // scBatzpupEditMapThanks.Panel2
            // 
            this.scBatzpupEditMapThanks.Panel2.Controls.Add(this.scBatzpupEditMapPallete);
            this.scBatzpupEditMapThanks.Size = new System.Drawing.Size(373, 648);
            this.scBatzpupEditMapThanks.SplitterDistance = 64;
            this.scBatzpupEditMapThanks.TabIndex = 0;
            // 
            // llblDotrMap
            // 
            this.llblDotrMap.AutoSize = true;
            this.llblDotrMap.Dock = System.Windows.Forms.DockStyle.Top;
            this.llblDotrMap.Location = new System.Drawing.Point(0, 28);
            this.llblDotrMap.Name = "llblDotrMap";
            this.llblDotrMap.Size = new System.Drawing.Size(113, 18);
            this.llblDotrMap.TabIndex = 2;
            this.llblDotrMap.TabStop = true;
            this.llblDotrMap.Text = "rjoken/Thotsicle";
            // 
            // lblDotrMap
            // 
            this.lblDotrMap.AutoSize = true;
            this.lblDotrMap.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDotrMap.Location = new System.Drawing.Point(0, 0);
            this.lblDotrMap.Name = "lblDotrMap";
            this.lblDotrMap.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lblDotrMap.Size = new System.Drawing.Size(226, 28);
            this.lblDotrMap.TabIndex = 1;
            this.lblDotrMap.Text = "Ported Version of DOTR Map by:";
            // 
            // scBatzpupEditMapPallete
            // 
            this.scBatzpupEditMapPallete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBatzpupEditMapPallete.Location = new System.Drawing.Point(0, 0);
            this.scBatzpupEditMapPallete.Name = "scBatzpupEditMapPallete";
            // 
            // scBatzpupEditMapPallete.Panel1
            // 
            this.scBatzpupEditMapPallete.Panel1.Controls.Add(this.pbSelectedTile);
            this.scBatzpupEditMapPallete.Panel1.Controls.Add(this.lblCurrentTile);
            this.scBatzpupEditMapPallete.Panel1.Controls.Add(this.btnLoadDefaultMaps);
            // 
            // scBatzpupEditMapPallete.Panel2
            // 
            this.scBatzpupEditMapPallete.Panel2.Controls.Add(this.tbPallete);
            this.scBatzpupEditMapPallete.Size = new System.Drawing.Size(373, 580);
            this.scBatzpupEditMapPallete.SplitterDistance = 152;
            this.scBatzpupEditMapPallete.TabIndex = 0;
            // 
            // pbSelectedTile
            // 
            this.pbSelectedTile.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbSelectedTile.Image = ((System.Drawing.Image)(resources.GetObject("pbSelectedTile.Image")));
            this.pbSelectedTile.Location = new System.Drawing.Point(0, 112);
            this.pbSelectedTile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbSelectedTile.Name = "pbSelectedTile";
            this.pbSelectedTile.Size = new System.Drawing.Size(152, 90);
            this.pbSelectedTile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSelectedTile.TabIndex = 6;
            this.pbSelectedTile.TabStop = false;
            // 
            // lblCurrentTile
            // 
            this.lblCurrentTile.AutoEllipsis = true;
            this.lblCurrentTile.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCurrentTile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentTile.Location = new System.Drawing.Point(0, 63);
            this.lblCurrentTile.Name = "lblCurrentTile";
            this.lblCurrentTile.Size = new System.Drawing.Size(152, 49);
            this.lblCurrentTile.TabIndex = 5;
            this.lblCurrentTile.Text = "Currently Selected Tile";
            // 
            // btnLoadDefaultMaps
            // 
            this.btnLoadDefaultMaps.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoadDefaultMaps.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoadDefaultMaps.Location = new System.Drawing.Point(0, 0);
            this.btnLoadDefaultMaps.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadDefaultMaps.Name = "btnLoadDefaultMaps";
            this.btnLoadDefaultMaps.Size = new System.Drawing.Size(152, 63);
            this.btnLoadDefaultMaps.TabIndex = 4;
            this.btnLoadDefaultMaps.Text = "Load Default Maps";
            this.btnLoadDefaultMaps.UseVisualStyleBackColor = false;
            this.btnLoadDefaultMaps.Click += new System.EventHandler(this.btnLoadDefaultMaps_Click);
            // 
            // tbPallete
            // 
            this.tbPallete.ColumnCount = 2;
            this.tbPallete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbPallete.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbPallete.Controls.Add(this.pbCrush, 1, 4);
            this.tbPallete.Controls.Add(this.pbLab, 0, 4);
            this.tbPallete.Controls.Add(this.pbNormal, 1, 3);
            this.tbPallete.Controls.Add(this.pbToon, 0, 3);
            this.tbPallete.Controls.Add(this.pbDark, 1, 2);
            this.tbPallete.Controls.Add(this.pbSea, 0, 2);
            this.tbPallete.Controls.Add(this.pbMeadow, 1, 1);
            this.tbPallete.Controls.Add(this.pbMountain, 0, 1);
            this.tbPallete.Controls.Add(this.pbWasteland, 1, 0);
            this.tbPallete.Controls.Add(this.pbForest, 0, 0);
            this.tbPallete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbPallete.Location = new System.Drawing.Point(0, 0);
            this.tbPallete.Name = "tbPallete";
            this.tbPallete.RowCount = 5;
            this.tbPallete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbPallete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbPallete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbPallete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbPallete.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbPallete.Size = new System.Drawing.Size(217, 580);
            this.tbPallete.TabIndex = 0;
            // 
            // pbCrush
            // 
            this.pbCrush.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCrush.Image = ((System.Drawing.Image)(resources.GetObject("pbCrush.Image")));
            this.pbCrush.Location = new System.Drawing.Point(111, 466);
            this.pbCrush.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbCrush.MaximumSize = new System.Drawing.Size(90, 90);
            this.pbCrush.Name = "pbCrush";
            this.pbCrush.Size = new System.Drawing.Size(90, 90);
            this.pbCrush.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCrush.TabIndex = 10;
            this.pbCrush.TabStop = false;
            this.pbCrush.Click += new System.EventHandler(this.pbCrush_Click);
            // 
            // pbLab
            // 
            this.pbLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLab.Image = ((System.Drawing.Image)(resources.GetObject("pbLab.Image")));
            this.pbLab.Location = new System.Drawing.Point(3, 466);
            this.pbLab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLab.MaximumSize = new System.Drawing.Size(90, 90);
            this.pbLab.Name = "pbLab";
            this.pbLab.Size = new System.Drawing.Size(90, 90);
            this.pbLab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLab.TabIndex = 9;
            this.pbLab.TabStop = false;
            this.pbLab.Click += new System.EventHandler(this.pbLab_Click);
            // 
            // pbNormal
            // 
            this.pbNormal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbNormal.Image = ((System.Drawing.Image)(resources.GetObject("pbNormal.Image")));
            this.pbNormal.Location = new System.Drawing.Point(111, 350);
            this.pbNormal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbNormal.MaximumSize = new System.Drawing.Size(90, 90);
            this.pbNormal.Name = "pbNormal";
            this.pbNormal.Size = new System.Drawing.Size(90, 90);
            this.pbNormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNormal.TabIndex = 8;
            this.pbNormal.TabStop = false;
            this.pbNormal.Click += new System.EventHandler(this.pbNormal_Click);
            // 
            // pbToon
            // 
            this.pbToon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbToon.Image = ((System.Drawing.Image)(resources.GetObject("pbToon.Image")));
            this.pbToon.Location = new System.Drawing.Point(3, 350);
            this.pbToon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbToon.MaximumSize = new System.Drawing.Size(90, 90);
            this.pbToon.Name = "pbToon";
            this.pbToon.Size = new System.Drawing.Size(90, 90);
            this.pbToon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbToon.TabIndex = 7;
            this.pbToon.TabStop = false;
            this.pbToon.Click += new System.EventHandler(this.pbToon_Click);
            // 
            // pbDark
            // 
            this.pbDark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbDark.Image = ((System.Drawing.Image)(resources.GetObject("pbDark.Image")));
            this.pbDark.Location = new System.Drawing.Point(111, 234);
            this.pbDark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbDark.MaximumSize = new System.Drawing.Size(90, 90);
            this.pbDark.Name = "pbDark";
            this.pbDark.Size = new System.Drawing.Size(90, 90);
            this.pbDark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDark.TabIndex = 6;
            this.pbDark.TabStop = false;
            this.pbDark.Click += new System.EventHandler(this.pbDark_Click);
            // 
            // pbSea
            // 
            this.pbSea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSea.Image = ((System.Drawing.Image)(resources.GetObject("pbSea.Image")));
            this.pbSea.Location = new System.Drawing.Point(3, 234);
            this.pbSea.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbSea.MaximumSize = new System.Drawing.Size(90, 90);
            this.pbSea.Name = "pbSea";
            this.pbSea.Size = new System.Drawing.Size(90, 90);
            this.pbSea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSea.TabIndex = 5;
            this.pbSea.TabStop = false;
            this.pbSea.Click += new System.EventHandler(this.pbSea_Click);
            // 
            // pbMeadow
            // 
            this.pbMeadow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMeadow.Image = ((System.Drawing.Image)(resources.GetObject("pbMeadow.Image")));
            this.pbMeadow.Location = new System.Drawing.Point(111, 118);
            this.pbMeadow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMeadow.MaximumSize = new System.Drawing.Size(90, 90);
            this.pbMeadow.Name = "pbMeadow";
            this.pbMeadow.Size = new System.Drawing.Size(90, 90);
            this.pbMeadow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMeadow.TabIndex = 4;
            this.pbMeadow.TabStop = false;
            this.pbMeadow.Click += new System.EventHandler(this.pbMeadow_Click);
            // 
            // pbMountain
            // 
            this.pbMountain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbMountain.Image = ((System.Drawing.Image)(resources.GetObject("pbMountain.Image")));
            this.pbMountain.Location = new System.Drawing.Point(3, 118);
            this.pbMountain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbMountain.MaximumSize = new System.Drawing.Size(90, 90);
            this.pbMountain.Name = "pbMountain";
            this.pbMountain.Size = new System.Drawing.Size(90, 90);
            this.pbMountain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMountain.TabIndex = 3;
            this.pbMountain.TabStop = false;
            this.pbMountain.Click += new System.EventHandler(this.pbMountain_Click);
            // 
            // pbWasteland
            // 
            this.pbWasteland.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbWasteland.Image = ((System.Drawing.Image)(resources.GetObject("pbWasteland.Image")));
            this.pbWasteland.Location = new System.Drawing.Point(111, 2);
            this.pbWasteland.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbWasteland.MaximumSize = new System.Drawing.Size(90, 90);
            this.pbWasteland.Name = "pbWasteland";
            this.pbWasteland.Size = new System.Drawing.Size(90, 90);
            this.pbWasteland.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWasteland.TabIndex = 2;
            this.pbWasteland.TabStop = false;
            // 
            // pbForest
            // 
            this.pbForest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbForest.Image = ((System.Drawing.Image)(resources.GetObject("pbForest.Image")));
            this.pbForest.Location = new System.Drawing.Point(3, 2);
            this.pbForest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbForest.MaximumSize = new System.Drawing.Size(90, 90);
            this.pbForest.Name = "pbForest";
            this.pbForest.Size = new System.Drawing.Size(90, 90);
            this.pbForest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbForest.TabIndex = 1;
            this.pbForest.TabStop = false;
            this.pbForest.Click += new System.EventHandler(this.pbForest_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(219, 538);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 25);
            this.label10.TabIndex = 3;
            this.label10.Text = "Red Side";
            // 
            // lblWhiteSide
            // 
            this.lblWhiteSide.AutoSize = true;
            this.lblWhiteSide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhiteSide.Location = new System.Drawing.Point(219, 23);
            this.lblWhiteSide.Name = "lblWhiteSide";
            this.lblWhiteSide.Size = new System.Drawing.Size(108, 25);
            this.lblWhiteSide.TabIndex = 2;
            this.lblWhiteSide.Text = "White Side";
            // 
            // lblMap
            // 
            this.lblMap.AutoSize = true;
            this.lblMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMap.Location = new System.Drawing.Point(28, 12);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(89, 38);
            this.lblMap.TabIndex = 1;
            this.lblMap.Text = "Map:";
            // 
            // cardConstantsContextStrip
            // 
            this.cardConstantsContextStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cardConstantsContextStrip.Name = "cardConstantsContextStrip";
            this.cardConstantsContextStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // cardDeckLeaderAbilitiesContextStrip
            // 
            this.cardDeckLeaderAbilitiesContextStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cardDeckLeaderAbilitiesContextStrip.Name = "cardDeckLeaderAbilitiesContextStrip";
            this.cardDeckLeaderAbilitiesContextStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // RefreshEditor
            // 
            this.RefreshEditor.Tick += new System.EventHandler(this.RefreshEditor_Tick);
            // 
            // gbLeaderLPRecovery
            // 
            this.gbLeaderLPRecovery.Controls.Add(this.numLpRecoveryValue);
            this.gbLeaderLPRecovery.Controls.Add(this.cbChangeLpRecovery);
            this.gbLeaderLPRecovery.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbLeaderLPRecovery.Location = new System.Drawing.Point(0, 400);
            this.gbLeaderLPRecovery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbLeaderLPRecovery.Name = "gbLeaderLPRecovery";
            this.gbLeaderLPRecovery.Padding = new System.Windows.Forms.Padding(5, 10, 3, 10);
            this.gbLeaderLPRecovery.Size = new System.Drawing.Size(611, 80);
            this.gbLeaderLPRecovery.TabIndex = 21;
            this.gbLeaderLPRecovery.TabStop = false;
            this.gbLeaderLPRecovery.Text = "Change Deck Leader Recovery Amount";
            // 
            // numLpRecoveryValue
            // 
            this.numLpRecoveryValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.numLpRecoveryValue.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numLpRecoveryValue.Location = new System.Drawing.Point(5, 51);
            this.numLpRecoveryValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numLpRecoveryValue.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numLpRecoveryValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLpRecoveryValue.Name = "numLpRecoveryValue";
            this.numLpRecoveryValue.Size = new System.Drawing.Size(603, 24);
            this.numLpRecoveryValue.TabIndex = 11;
            this.numLpRecoveryValue.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // cbChangeLpRecovery
            // 
            this.cbChangeLpRecovery.AutoSize = true;
            this.cbChangeLpRecovery.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbChangeLpRecovery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChangeLpRecovery.Location = new System.Drawing.Point(5, 27);
            this.cbChangeLpRecovery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbChangeLpRecovery.Name = "cbChangeLpRecovery";
            this.cbChangeLpRecovery.Size = new System.Drawing.Size(603, 24);
            this.cbChangeLpRecovery.TabIndex = 10;
            this.cbChangeLpRecovery.Text = "Enabled";
            this.cbChangeLpRecovery.UseVisualStyleBackColor = true;
            // 
            // cbCrushCardChange
            // 
            this.cbCrushCardChange.AutoSize = true;
            this.cbCrushCardChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbCrushCardChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCrushCardChange.Location = new System.Drawing.Point(0, 480);
            this.cbCrushCardChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCrushCardChange.Name = "cbCrushCardChange";
            this.cbCrushCardChange.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.cbCrushCardChange.Size = new System.Drawing.Size(521, 40);
            this.cbCrushCardChange.TabIndex = 23;
            this.cbCrushCardChange.Text = "Restore Crush Cards Glory";
            this.cbCrushCardChange.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 733);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1180, 603);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DOTR Modding Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.hiddenCardsTab.ResumeLayout(false);
            this.hiddenCardsSplitContainer.Panel1.ResumeLayout(false);
            this.hiddenCardsSplitContainer.Panel2.ResumeLayout(false);
            this.hiddenCardsSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hiddenCardsSplitContainer)).EndInit();
            this.hiddenCardsSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treasureCardColumnNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.treasureCardRowNumericUpDown)).EndInit();
            this.enemyAiTab.ResumeLayout(false);
            this.enemyAiTabSplitContainer.Panel1.ResumeLayout(false);
            this.enemyAiTabSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.enemyAiTabSplitContainer)).EndInit();
            this.enemyAiTabSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.enemyAiDataGridView)).EndInit();
            this.fusionsTab.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fusionsDataGridView)).EndInit();
            this.cardPropertiesTab.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cardConstantsDataGridView)).EndInit();
            this.leaderRankTresholdsTab.ResumeLayout(false);
            this.leaderRankTresholdsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rankThresholdsDataGridView)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.deckEditorTab.ResumeLayout(false);
            this.deckEditorTabSplitContainer.Panel1.ResumeLayout(false);
            this.deckEditorTabSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deckEditorTabSplitContainer)).EndInit();
            this.deckEditorTabSplitContainer.ResumeLayout(false);
            this.cardTrunkSplitContainer.Panel1.ResumeLayout(false);
            this.cardTrunkSplitContainer.Panel1.PerformLayout();
            this.cardTrunkSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cardTrunkSplitContainer)).EndInit();
            this.cardTrunkSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trunkDataGridView)).EndInit();
            this.trunkContextMenuStrip.ResumeLayout(false);
            this.deckEditorSplitContainer.Panel1.ResumeLayout(false);
            this.deckEditorSplitContainer.Panel1.PerformLayout();
            this.deckEditorSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deckEditorSplitContainer)).EndInit();
            this.deckEditorSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deckEditorDataGridView)).EndInit();
            this.deckEditContextMenuStrip.ResumeLayout(false);
            this.deckLeaderAbilitiesTab.ResumeLayout(false);
            this.cardDeckLeaderAbilitiesSplitContainer.Panel1.ResumeLayout(false);
            this.cardDeckLeaderAbilitiesSplitContainer.Panel1.PerformLayout();
            this.cardDeckLeaderAbilitiesSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cardDeckLeaderAbilitiesSplitContainer)).EndInit();
            this.cardDeckLeaderAbilitiesSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cardDeckLeaderAbilitiesDatagridview)).EndInit();
            this.equipCompabilityTab.ResumeLayout(false);
            this.equipCompabilitySplitContainer.Panel1.ResumeLayout(false);
            this.equipCompabilitySplitContainer.Panel1.PerformLayout();
            this.equipCompabilitySplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.equipCompabilitySplitContainer)).EndInit();
            this.equipCompabilitySplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.equipCompatibilityDataGridView)).EndInit();
            this.monsterCardEquipCompatibilitiesContextMenuStrip.ResumeLayout(false);
            this.batzpupModsTab.ResumeLayout(false);
            this.scBatzpupSave.Panel1.ResumeLayout(false);
            this.scBatzpupSave.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scBatzpupSave)).EndInit();
            this.scBatzpupSave.ResumeLayout(false);
            this.tbBatzpup.ResumeLayout(false);
            this.batzpupTbMain.ResumeLayout(false);
            this.scBatzpupMain.Panel1.ResumeLayout(false);
            this.scBatzpupMain.Panel1.PerformLayout();
            this.scBatzpupMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scBatzpupMain)).EndInit();
            this.scBatzpupMain.ResumeLayout(false);
            this.gbChangeTerrainValues.ResumeLayout(false);
            this.gbChangeTerrainValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numChangeTerrainValue)).EndInit();
            this.gbReincarnationCount.ResumeLayout(false);
            this.gbReincarnationCount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numReincarnationCount)).EndInit();
            this.gbChangeLpCap.ResumeLayout(false);
            this.gbChangeLpCap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLPCap)).EndInit();
            this.gbForceNewGameSide.ResumeLayout(false);
            this.gbForceNewGameSide.PerformLayout();
            this.gpSideToGoFirst.ResumeLayout(false);
            this.gpSideToGoFirst.PerformLayout();
            this.tbBatzpupSlotRewards.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlotRewards)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.scMusicMain.Panel1.ResumeLayout(false);
            this.scMusicMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMusicMain)).EndInit();
            this.scMusicMain.ResumeLayout(false);
            this.scBatzpupMusic2.Panel1.ResumeLayout(false);
            this.scBatzpupMusic2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scBatzpupMusic2)).EndInit();
            this.scBatzpupMusic2.ResumeLayout(false);
            this.scBatzpupMusicPlayer.Panel1.ResumeLayout(false);
            this.scBatzpupMusicPlayer.Panel2.ResumeLayout(false);
            this.scBatzpupMusicPlayer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBatzpupMusicPlayer)).EndInit();
            this.scBatzpupMusicPlayer.ResumeLayout(false);
            this.scBatzpupMusicButtons.Panel1.ResumeLayout(false);
            this.scBatzpupMusicButtons.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scBatzpupMusicButtons)).EndInit();
            this.scBatzpupMusicButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbMusicVolume)).EndInit();
            this.mapEditorTab.ResumeLayout(false);
            this.mapEditorSaveSplitContainer.Panel1.ResumeLayout(false);
            this.mapEditorSaveSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapEditorSaveSplitContainer)).EndInit();
            this.mapEditorSaveSplitContainer.ResumeLayout(false);
            this.scBatzpupEditMap.Panel1.ResumeLayout(false);
            this.scBatzpupEditMap.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scBatzpupEditMap)).EndInit();
            this.scBatzpupEditMap.ResumeLayout(false);
            this.scBatzpupEditDuelMapSelect.Panel1.ResumeLayout(false);
            this.scBatzpupEditDuelMapSelect.Panel1.PerformLayout();
            this.scBatzpupEditDuelMapSelect.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scBatzpupEditDuelMapSelect)).EndInit();
            this.scBatzpupEditDuelMapSelect.ResumeLayout(false);
            this.scBatzpupEditMapTiles.Panel1.ResumeLayout(false);
            this.scBatzpupEditMapTiles.Panel2.ResumeLayout(false);
            this.scBatzpupEditMapTiles.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBatzpupEditMapTiles)).EndInit();
            this.scBatzpupEditMapTiles.ResumeLayout(false);
            this.scBatzpupEditMapThanks.Panel1.ResumeLayout(false);
            this.scBatzpupEditMapThanks.Panel1.PerformLayout();
            this.scBatzpupEditMapThanks.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scBatzpupEditMapThanks)).EndInit();
            this.scBatzpupEditMapThanks.ResumeLayout(false);
            this.scBatzpupEditMapPallete.Panel1.ResumeLayout(false);
            this.scBatzpupEditMapPallete.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scBatzpupEditMapPallete)).EndInit();
            this.scBatzpupEditMapPallete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbSelectedTile)).EndInit();
            this.tbPallete.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCrush)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbToon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMeadow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMountain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWasteland)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForest)).EndInit();
            this.gbLeaderLPRecovery.ResumeLayout(false);
            this.gbLeaderLPRecovery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLpRecoveryValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private TabPage hiddenCardsTab;
    private SplitContainer hiddenCardsSplitContainer;
    private TabPage enemyAiTab;
    private SplitContainer enemyAiTabSplitContainer;
    private Button enemyAiSaveButton;
    private DataGridView enemyAiDataGridView;
    private DataGridViewTextBoxColumn EnemyIndex;
    private DataGridViewTextBoxColumn EnemyNameColumn;
    private DataGridViewComboBoxColumn EnemyAiColumn;
    private TabPage fusionsTab;
    private SplitContainer splitContainer2;
    private Label fusionTableTipLabel;
    private Button fusionSaveButton;
    private DataGridView fusionsDataGridView;
    private TabPage cardPropertiesTab;
    private SplitContainer splitContainer1;
    private Button cardConstantsSaveButton;
    private Button cardConstantFilterClearButton;
    private Label label1;
    private Button cardConstantsFilterButton;
    private TextBox cardConstantsFilterTextbox;
    private DataGridView cardConstantsDataGridView;
    private TabPage leaderRankTresholdsTab;
    private TextBox textBox2;
    private TextBox textBox1;
    private TextBox newRankThresholdsTextbox;
    private TextBox originalRankThresholdsTextbox;
    private Button rankThresholdsSaveButton;
    private DataGridView rankThresholdsDataGridView;
    private TabControl mainTabControl;
    private ListBox treasureCardsListbox;
    private Button treasureCardSaveButton;
    private ComboBox treasureCardCardComboBox;
    private NumericUpDown treasureCardColumnNumericUpDown;
    private NumericUpDown treasureCardRowNumericUpDown;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label6;
    private Label label5;
    private Label label7;
    private ContextMenuStrip cardConstantsContextStrip;
    private Label label8;
    private DataGridViewTextBoxColumn CardConstantId;
    private DataGridViewTextBoxColumn CardConstantName;
    private DataGridViewTextBoxColumn CardConstantAttack;
    private DataGridViewTextBoxColumn CardConstantDefense;
    private DataGridViewTextBoxColumn CardConstantsType;
    private DataGridViewTextBoxColumn CardConstantsAttribute;
    private DataGridViewTextBoxColumn CardConstantsLevel;
    private DataGridViewTextBoxColumn CardConstantDeckCost;
    private DataGridViewCheckBoxColumn CardConstantSlots;
    private DataGridViewCheckBoxColumn CardConstantIsSlotRare;
    private DataGridViewCheckBoxColumn CardConstantReincarnation;
    private DataGridViewCheckBoxColumn CardConstantPasswordWorks;
    private TabPage deckLeaderAbilitiesTab;
    private SplitContainer cardDeckLeaderAbilitiesSplitContainer;
    private DataGridView cardDeckLeaderAbilitiesDatagridview;
    private ContextMenuStrip cardDeckLeaderAbilitiesContextStrip;
    private TabPage equipCompabilityTab;
    private SplitContainer equipCompabilitySplitContainer;
    private DataGridView equipCompatibilityDataGridView;
    private DataGridViewTextBoxColumn EquipCompatabilityCardIndexColumn;
    private DataGridViewTextBoxColumn EquipCompatabilityCardNameColumn;
    private DataGridViewTextBoxColumn CompatibleEquipCountColumn;
    private DataGridViewTextBoxColumn EquipCompatabilityEquipCardsColumn;
    private ContextMenuStrip monsterCardEquipCompatibilitiesContextMenuStrip;
    private ToolStripMenuItem editMonsterEquipMenuItem;
    private Button equipCompatibilitySaveButton;
    private Label cardEquipNoteLabel1;
    private Button deckLeaderAbilitiesSaveButton;
    private DataGridViewTextBoxColumn cardDeckLeaderAbilitiesIndexColumn;
    private DataGridViewTextBoxColumn cardDeckLeaderAbilitiesNameColumn;
    private DataGridViewTextBoxColumn cardDeckLeaderAbilitiesEnabledAbilitiesColumn;
    private DataGridViewTextBoxColumn Bytes;
    private Label deckLeaderAbilityTabTipsLabel;
    private DataGridViewTextBoxColumn FusionsDataGridViewIndex;
    private DataGridViewTextBoxColumn LowerCardMaterialCardNumber;
    private DataGridViewComboBoxColumn FusionsDataGridViewLowerCard;
    private DataGridViewTextBoxColumn HigherCardMaterialCardNumber;
    private DataGridViewComboBoxColumn FusionsDataGridViewUpperCard;
    private DataGridViewTextBoxColumn ResultingFusionId;
    private DataGridViewComboBoxColumn FusionsDataGridViewFusionCard;
    private TabPage deckEditorTab;
    private SplitContainer deckEditorTabSplitContainer;
    private DataGridView trunkDataGridView;
    private SplitContainer deckEditorSplitContainer;
    private Label deckLabel;
    private ComboBox deckDropdown;
    private Button deckEditSaveButton;
    private DataGridView deckEditorDataGridView;
    private DataGridViewTextBoxColumn indexColumn;
    private DataGridViewTextBoxColumn deckTableNameColumn;
    private DataGridViewTextBoxColumn deckEditAttackColumn;
    private DataGridViewTextBoxColumn deckEditDefenseColumn;
    private DataGridViewTextBoxColumn deckEditLevelColumn;
    private DataGridViewTextBoxColumn deckEditAttributeColumn;
    private DataGridViewTextBoxColumn deckEditTypeColumn;
    private DataGridViewTextBoxColumn deckEditDeckCostColumn;
    private DataGridViewTextBoxColumn Index;
    private DataGridViewTextBoxColumn nameColumn;
    private DataGridViewTextBoxColumn cardTrunkAttackColumn;
    private DataGridViewTextBoxColumn cardTrunkDefenseColumn;
    private DataGridViewTextBoxColumn cardTrunkLevelColumn;
    private DataGridViewTextBoxColumn cardTrunkAttributeColumn;
    private DataGridViewTextBoxColumn cardTrunkTypeColumn;
    private DataGridViewTextBoxColumn cardTrunkDeckCostColumn;
    private SplitContainer cardTrunkSplitContainer;
    private Button trunkClearFilterButton;
    private Button trunkApplyFilterButton;
    private Label trunkNameFilterLabel;
    private TextBox trunkFilterTextBox;
    private Label cardTrunkLabel;
    private Label decksLabel;
    private Label deckCardCountLabel;
    private ContextMenuStrip deckEditContextMenuStrip;
    private ToolStripMenuItem deckEditRemoveSelectedMenuItem;
    private ComboBox deckEditDeckLeaderRankComboBox;
    private ContextMenuStrip trunkContextMenuStrip;
    private ToolStripMenuItem makeDeckLeaderToolStripMenuItem;
    private ToolStripMenuItem addSelectedCardsToDeckToolStripMenuItem;
    private Label deckEditDeckCostLabel;
    private Label trunkTipLabel;
    private Label deckEditTipLabel;
    private ToolStripMenuItem additionalResourcesToolStripMenuItem1;
    private ToolStripMenuItem dOTRMapEditorToolStripMenuItem1;
    private ToolStripMenuItem viewSourceOnGithubToolStripMenuItem1;
    private ToolStripMenuItem aboutToolStripMenuItem2;
    private ToolStripMenuItem coolStuffToolStripMenuItem;
    private ToolStripMenuItem clovisYoutubeChannelToolStripMenuItem;
    private ToolStripMenuItem dOTRReduxModToolStripMenuItem;
    private ToolStripMenuItem rOMMapDocumentationToolStripMenuItem;
    private TabPage batzpupModsTab;
        private SplitContainer scBatzpupSave;
        private Button BatzpupSaveButton;
        private SplitContainer scBatzpupEditMap;
        private SplitContainer scBatzpupEditMapTiles;
        private SplitContainer scBatzpupEditDuelMapSelect;
        private Label lblMapToSelect;
        private ListBox lbDuelistMaps;
        private SplitContainer scBatzpupEditMapPallete;
        private PictureBox pbSelectedTile;
        private Label lblCurrentTile;
        private Button btnLoadDefaultMaps;
        private TableLayoutPanel tbPallete;
        private PictureBox pbCrush;
        private PictureBox pbLab;
        private PictureBox pbNormal;
        private PictureBox pbToon;
        private PictureBox pbDark;
        private PictureBox pbSea;
        private PictureBox pbMeadow;
        private PictureBox pbMountain;
        private PictureBox pbWasteland;
        private PictureBox pbForest;
        private SplitContainer scBatzpupEditMapThanks;
        private LinkLabel llblDotrMap;
        private Label lblDotrMap;
        private Label label10;
        private Label lblWhiteSide;
        private Label lblMap;
        private Timer RefreshEditor;
    private TabPage mapEditorTab;
    private SplitContainer mapEditorSaveSplitContainer;
    private Button mapEditorSaveButton;
    private Button button1;
    private TabControl tbBatzpup;
    private TabPage batzpupTbMain;
    private SplitContainer scBatzpupMain;
    private CheckBox cbNoDCRequirementPostGame;
    private CheckBox cbKeepReincarnatedCard;
    private CheckBox cbAddAddtionalSlotRewards;
    private CheckBox cbAllowAllCustomDuels;
    private CheckBox cbUseCustomMusic;
    private CheckBox cbRemoveRNGFromSlots;
    private CheckBox cbRemoveNegetiveXP;
    private CheckBox cbExpandedZoom;
    private CheckBox cbEmulatorCameraFix;
    private CheckBox cbAllFusions;
    private CheckBox cbFastIntro;
    private CheckBox cbAIInputFix;
    private GroupBox gbChangeTerrainValues;
    private NumericUpDown numChangeTerrainValue;
    private CheckBox cbTerrainChangeEnabled;
    private GroupBox gbReincarnationCount;
    private NumericUpDown numReincarnationCount;
    private CheckBox cbReincarnationCount;
    private GroupBox gbChangeLpCap;
    private NumericUpDown numLPCap;
    private CheckBox cbLPCap;
    private GroupBox gbForceNewGameSide;
    private ComboBox cboForceNewGameSide;
    private CheckBox cbForceNewGameSide;
    private GroupBox gpSideToGoFirst;
    private ComboBox cboSideFirst;
    private CheckBox cbSideFirst;
    private TabPage tbBatzpupSlotRewards;
    private DataGridView dgvSlotRewards;
    private DataGridViewTextBoxColumn SlotRewardNumber;
    private DataGridViewComboBoxColumn ThreeInARow;
    private DataGridViewComboBoxColumn SlotReward;
    private TabPage tabPage4;
    private SplitContainer scMusicMain;
    private ListBox lbMusicDuelists;
    private SplitContainer scBatzpupMusic2;
    private ListBox lbMusicTrack;
    private SplitContainer scBatzpupMusicPlayer;
    private SplitContainer scBatzpupMusicButtons;
    private Button btnExtractMusic;
    private Button btnToggleMusic;
    private Label lblCurrentMusic;
    private Label lblCurrentlyPlayingTitle;
    private Label lblVolume;
    private TrackBar tbMusicVolume;
        private GroupBox gbLeaderLPRecovery;
        private NumericUpDown numLpRecoveryValue;
        private CheckBox cbChangeLpRecovery;
        private CheckBox cbCrushCardChange;
    }
}
