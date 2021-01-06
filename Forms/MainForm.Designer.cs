namespace DOTR_Modding_Tool
{
  using System.Windows.Forms;

  public partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.openISOMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewSourceOnGithubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
      this.deckEditorTabSplitContainer = new System.Windows.Forms.SplitContainer();
      this.cardTrunkSplitContainer = new System.Windows.Forms.SplitContainer();
      this.cardTrunkLabel = new System.Windows.Forms.Label();
      this.trunkFilterTextBox = new System.Windows.Forms.TextBox();
      this.trunkClearFilterButton = new System.Windows.Forms.Button();
      this.trunkApplyFilterButton = new System.Windows.Forms.Button();
      this.trunkNameFilterLabel = new System.Windows.Forms.Label();
      this.deckEditAllCardsDataGridView = new System.Windows.Forms.DataGridView();
      this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cardTrunkAttackColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cardTrunkDefenseColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cardTrunkLevelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cardTrunkAttributeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cardTrunkTypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cardTrunkDeckCostColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.deckEditorSplitContainer = new System.Windows.Forms.SplitContainer();
      this.decksLabel = new System.Windows.Forms.Label();
      this.deckLabel = new System.Windows.Forms.Label();
      this.comboBox1 = new System.Windows.Forms.ComboBox();
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
      this.cardConstantsContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.cardDeckLeaderAbilitiesContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
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
      ((System.ComponentModel.ISupportInitialize)(this.deckEditAllCardsDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.deckEditorSplitContainer)).BeginInit();
      this.deckEditorSplitContainer.Panel1.SuspendLayout();
      this.deckEditorSplitContainer.Panel2.SuspendLayout();
      this.deckEditorSplitContainer.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.deckEditorDataGridView)).BeginInit();
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
      this.SuspendLayout();
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openISOMenuItem,
            this.aboutToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
      this.menuStrip1.Size = new System.Drawing.Size(1125, 24);
      this.menuStrip1.TabIndex = 1;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // openISOMenuItem
      // 
      this.openISOMenuItem.Name = "openISOMenuItem";
      this.openISOMenuItem.Size = new System.Drawing.Size(69, 20);
      this.openISOMenuItem.Text = "Open ISO";
      this.openISOMenuItem.Click += new System.EventHandler(this.FileToolStripMenuItem_Click);
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewSourceOnGithubToolStripMenuItem});
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
      this.aboutToolStripMenuItem.Text = "About";
      // 
      // viewSourceOnGithubToolStripMenuItem
      // 
      this.viewSourceOnGithubToolStripMenuItem.Name = "viewSourceOnGithubToolStripMenuItem";
      this.viewSourceOnGithubToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
      this.viewSourceOnGithubToolStripMenuItem.Text = "View Source on Github";
      this.viewSourceOnGithubToolStripMenuItem.Click += new System.EventHandler(this.viewSourceOnGithubToolStripMenuItem_Click);
      // 
      // hiddenCardsTab
      // 
      this.hiddenCardsTab.Controls.Add(this.hiddenCardsSplitContainer);
      this.hiddenCardsTab.Location = new System.Drawing.Point(4, 22);
      this.hiddenCardsTab.Name = "hiddenCardsTab";
      this.hiddenCardsTab.Padding = new System.Windows.Forms.Padding(3);
      this.hiddenCardsTab.Size = new System.Drawing.Size(1117, 528);
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
      this.hiddenCardsSplitContainer.Size = new System.Drawing.Size(1111, 522);
      this.hiddenCardsSplitContainer.SplitterDistance = 232;
      this.hiddenCardsSplitContainer.TabIndex = 0;
      // 
      // treasureCardsListbox
      // 
      this.treasureCardsListbox.DisplayMember = "EnemyName";
      this.treasureCardsListbox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.treasureCardsListbox.FormattingEnabled = true;
      this.treasureCardsListbox.Location = new System.Drawing.Point(0, 0);
      this.treasureCardsListbox.Name = "treasureCardsListbox";
      this.treasureCardsListbox.Size = new System.Drawing.Size(232, 522);
      this.treasureCardsListbox.TabIndex = 0;
      this.treasureCardsListbox.SelectedIndexChanged += new System.EventHandler(this.treasureCardsListbox_SelectedIndexChanged);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(44, 132);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(276, 13);
      this.label7.TabIndex = 14;
      this.label7.Text = "Valid Row and Column numbers are 0-6 ( total of 7 each )";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(44, 176);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(311, 13);
      this.label6.TabIndex = 13;
      this.label6.Text = "Vs Red Rose - Row # and Column # start at 0 in the bottom right";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(44, 154);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(296, 13);
      this.label5.TabIndex = 12;
      this.label5.Text = "Vs White Rose - Row # and Column # start at 0 in the top left";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(44, 19);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(29, 13);
      this.label4.TabIndex = 11;
      this.label4.Text = "Card";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(125, 76);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(52, 13);
      this.label3.TabIndex = 9;
      this.label3.Text = "Column #";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(44, 76);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(39, 13);
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
      this.treasureCardColumnNumericUpDown.Size = new System.Drawing.Size(46, 20);
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
      this.treasureCardRowNumericUpDown.Size = new System.Drawing.Size(46, 20);
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
      this.treasureCardCardComboBox.Size = new System.Drawing.Size(166, 21);
      this.treasureCardCardComboBox.TabIndex = 0;
      this.treasureCardCardComboBox.ValueMember = "Index";
      // 
      // enemyAiTab
      // 
      this.enemyAiTab.Controls.Add(this.enemyAiTabSplitContainer);
      this.enemyAiTab.Location = new System.Drawing.Point(4, 22);
      this.enemyAiTab.Name = "enemyAiTab";
      this.enemyAiTab.Padding = new System.Windows.Forms.Padding(3);
      this.enemyAiTab.Size = new System.Drawing.Size(1117, 528);
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
      this.enemyAiTabSplitContainer.Size = new System.Drawing.Size(1111, 522);
      this.enemyAiTabSplitContainer.SplitterDistance = 25;
      this.enemyAiTabSplitContainer.TabIndex = 1;
      // 
      // enemyAiSaveButton
      // 
      this.enemyAiSaveButton.Dock = System.Windows.Forms.DockStyle.Right;
      this.enemyAiSaveButton.Location = new System.Drawing.Point(1036, 0);
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
      this.enemyAiDataGridView.Size = new System.Drawing.Size(1111, 493);
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
      this.fusionsTab.Location = new System.Drawing.Point(4, 22);
      this.fusionsTab.Name = "fusionsTab";
      this.fusionsTab.Padding = new System.Windows.Forms.Padding(3);
      this.fusionsTab.Size = new System.Drawing.Size(1117, 528);
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
      this.splitContainer2.Size = new System.Drawing.Size(1111, 522);
      this.splitContainer2.SplitterDistance = 25;
      this.splitContainer2.TabIndex = 1;
      // 
      // fusionTableTipLabel
      // 
      this.fusionTableTipLabel.AutoSize = true;
      this.fusionTableTipLabel.Location = new System.Drawing.Point(5, 6);
      this.fusionTableTipLabel.Name = "fusionTableTipLabel";
      this.fusionTableTipLabel.Size = new System.Drawing.Size(279, 13);
      this.fusionTableTipLabel.TabIndex = 1;
      this.fusionTableTipLabel.Text = "Tip: You can start typing immediately after selecting a cell.";
      // 
      // fusionSaveButton
      // 
      this.fusionSaveButton.Dock = System.Windows.Forms.DockStyle.Right;
      this.fusionSaveButton.Location = new System.Drawing.Point(1036, 0);
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
      this.fusionsDataGridView.Size = new System.Drawing.Size(1111, 493);
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
      this.cardPropertiesTab.Location = new System.Drawing.Point(4, 22);
      this.cardPropertiesTab.Name = "cardPropertiesTab";
      this.cardPropertiesTab.Padding = new System.Windows.Forms.Padding(3);
      this.cardPropertiesTab.Size = new System.Drawing.Size(1117, 528);
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
      this.splitContainer1.Size = new System.Drawing.Size(1111, 522);
      this.splitContainer1.SplitterDistance = 25;
      this.splitContainer1.TabIndex = 1;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(323, 7);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(281, 13);
      this.label8.TabIndex = 5;
      this.label8.Text = "Select multiple rows with shift or ctrl keys, right click to edit";
      // 
      // cardConstantsSaveButton
      // 
      this.cardConstantsSaveButton.Dock = System.Windows.Forms.DockStyle.Right;
      this.cardConstantsSaveButton.Location = new System.Drawing.Point(1036, 0);
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
      this.label1.Size = new System.Drawing.Size(32, 13);
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
      this.cardConstantsFilterTextbox.Size = new System.Drawing.Size(112, 20);
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
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.cardConstantsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
      this.cardConstantsDataGridView.Size = new System.Drawing.Size(1111, 493);
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
      this.leaderRankTresholdsTab.Location = new System.Drawing.Point(4, 22);
      this.leaderRankTresholdsTab.Name = "leaderRankTresholdsTab";
      this.leaderRankTresholdsTab.Padding = new System.Windows.Forms.Padding(3);
      this.leaderRankTresholdsTab.Size = new System.Drawing.Size(1117, 528);
      this.leaderRankTresholdsTab.TabIndex = 0;
      this.leaderRankTresholdsTab.Text = "Rank Thresholds";
      this.leaderRankTresholdsTab.UseVisualStyleBackColor = true;
      // 
      // textBox2
      // 
      this.textBox2.BackColor = System.Drawing.SystemColors.Window;
      this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox2.Location = new System.Drawing.Point(317, 25);
      this.textBox2.Name = "textBox2";
      this.textBox2.ReadOnly = true;
      this.textBox2.Size = new System.Drawing.Size(71, 13);
      this.textBox2.TabIndex = 22;
      this.textBox2.Text = "New Bytes:";
      // 
      // textBox1
      // 
      this.textBox1.BackColor = System.Drawing.SystemColors.Window;
      this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBox1.Location = new System.Drawing.Point(317, 6);
      this.textBox1.Name = "textBox1";
      this.textBox1.ReadOnly = true;
      this.textBox1.Size = new System.Drawing.Size(71, 13);
      this.textBox1.TabIndex = 21;
      this.textBox1.Text = "Orignal Bytes:";
      // 
      // newRankThresholdsTextbox
      // 
      this.newRankThresholdsTextbox.BackColor = System.Drawing.SystemColors.Window;
      this.newRankThresholdsTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.newRankThresholdsTextbox.Location = new System.Drawing.Point(438, 25);
      this.newRankThresholdsTextbox.Name = "newRankThresholdsTextbox";
      this.newRankThresholdsTextbox.ReadOnly = true;
      this.newRankThresholdsTextbox.Size = new System.Drawing.Size(493, 13);
      this.newRankThresholdsTextbox.TabIndex = 20;
      // 
      // originalRankThresholdsTextbox
      // 
      this.originalRankThresholdsTextbox.BackColor = System.Drawing.SystemColors.Window;
      this.originalRankThresholdsTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.originalRankThresholdsTextbox.Location = new System.Drawing.Point(438, 6);
      this.originalRankThresholdsTextbox.Name = "originalRankThresholdsTextbox";
      this.originalRankThresholdsTextbox.ReadOnly = true;
      this.originalRankThresholdsTextbox.Size = new System.Drawing.Size(493, 13);
      this.originalRankThresholdsTextbox.TabIndex = 0;
      // 
      // rankThresholdsSaveButton
      // 
      this.rankThresholdsSaveButton.Location = new System.Drawing.Point(385, 114);
      this.rankThresholdsSaveButton.Name = "rankThresholdsSaveButton";
      this.rankThresholdsSaveButton.Size = new System.Drawing.Size(75, 23);
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
      this.mainTabControl.Location = new System.Drawing.Point(0, 27);
      this.mainTabControl.Name = "mainTabControl";
      this.mainTabControl.SelectedIndex = 0;
      this.mainTabControl.Size = new System.Drawing.Size(1125, 554);
      this.mainTabControl.TabIndex = 3;
      // 
      // deckEditorTab
      // 
      this.deckEditorTab.Controls.Add(this.deckEditorTabSplitContainer);
      this.deckEditorTab.Location = new System.Drawing.Point(4, 22);
      this.deckEditorTab.Name = "deckEditorTab";
      this.deckEditorTab.Padding = new System.Windows.Forms.Padding(3);
      this.deckEditorTab.Size = new System.Drawing.Size(1117, 528);
      this.deckEditorTab.TabIndex = 7;
      this.deckEditorTab.Text = "Deck Editor";
      this.deckEditorTab.UseVisualStyleBackColor = true;
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
      this.deckEditorTabSplitContainer.Size = new System.Drawing.Size(1111, 522);
      this.deckEditorTabSplitContainer.SplitterDistance = 550;
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
      this.cardTrunkSplitContainer.Panel1.Controls.Add(this.cardTrunkLabel);
      this.cardTrunkSplitContainer.Panel1.Controls.Add(this.trunkFilterTextBox);
      this.cardTrunkSplitContainer.Panel1.Controls.Add(this.trunkClearFilterButton);
      this.cardTrunkSplitContainer.Panel1.Controls.Add(this.trunkApplyFilterButton);
      this.cardTrunkSplitContainer.Panel1.Controls.Add(this.trunkNameFilterLabel);
      // 
      // cardTrunkSplitContainer.Panel2
      // 
      this.cardTrunkSplitContainer.Panel2.Controls.Add(this.deckEditAllCardsDataGridView);
      this.cardTrunkSplitContainer.Size = new System.Drawing.Size(550, 522);
      this.cardTrunkSplitContainer.SplitterDistance = 60;
      this.cardTrunkSplitContainer.TabIndex = 1;
      // 
      // cardTrunkLabel
      // 
      this.cardTrunkLabel.AutoSize = true;
      this.cardTrunkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cardTrunkLabel.Location = new System.Drawing.Point(5, 6);
      this.cardTrunkLabel.Name = "cardTrunkLabel";
      this.cardTrunkLabel.Size = new System.Drawing.Size(54, 20);
      this.cardTrunkLabel.TabIndex = 5;
      this.cardTrunkLabel.Text = "Trunk";
      // 
      // trunkFilterTextBox
      // 
      this.trunkFilterTextBox.Location = new System.Drawing.Point(46, 34);
      this.trunkFilterTextBox.Name = "trunkFilterTextBox";
      this.trunkFilterTextBox.Size = new System.Drawing.Size(122, 20);
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
      this.trunkNameFilterLabel.Size = new System.Drawing.Size(32, 13);
      this.trunkNameFilterLabel.TabIndex = 1;
      this.trunkNameFilterLabel.Text = "Filter:";
      // 
      // deckEditAllCardsDataGridView
      // 
      this.deckEditAllCardsDataGridView.AllowUserToAddRows = false;
      this.deckEditAllCardsDataGridView.AllowUserToDeleteRows = false;
      this.deckEditAllCardsDataGridView.AllowUserToResizeRows = false;
      this.deckEditAllCardsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.deckEditAllCardsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.nameColumn,
            this.cardTrunkAttackColumn,
            this.cardTrunkDefenseColumn,
            this.cardTrunkLevelColumn,
            this.cardTrunkAttributeColumn,
            this.cardTrunkTypeColumn,
            this.cardTrunkDeckCostColumn});
      this.deckEditAllCardsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.deckEditAllCardsDataGridView.Location = new System.Drawing.Point(0, 0);
      this.deckEditAllCardsDataGridView.Name = "deckEditAllCardsDataGridView";
      this.deckEditAllCardsDataGridView.RowHeadersVisible = false;
      this.deckEditAllCardsDataGridView.Size = new System.Drawing.Size(550, 458);
      this.deckEditAllCardsDataGridView.TabIndex = 0;
      // 
      // Index
      // 
      this.Index.DataPropertyName = "Index";
      this.Index.HeaderText = "#";
      this.Index.Name = "Index";
      this.Index.ReadOnly = true;
      this.Index.Width = 32;
      // 
      // nameColumn
      // 
      this.nameColumn.DataPropertyName = "Name";
      this.nameColumn.HeaderText = "Name";
      this.nameColumn.Name = "nameColumn";
      this.nameColumn.ReadOnly = true;
      this.nameColumn.Width = 200;
      // 
      // cardTrunkAttackColumn
      // 
      this.cardTrunkAttackColumn.DataPropertyName = "Attack";
      this.cardTrunkAttackColumn.HeaderText = "Attack";
      this.cardTrunkAttackColumn.Name = "cardTrunkAttackColumn";
      this.cardTrunkAttackColumn.ReadOnly = true;
      this.cardTrunkAttackColumn.Width = 40;
      // 
      // cardTrunkDefenseColumn
      // 
      this.cardTrunkDefenseColumn.DataPropertyName = "Defense";
      this.cardTrunkDefenseColumn.HeaderText = "Defense";
      this.cardTrunkDefenseColumn.Name = "cardTrunkDefenseColumn";
      this.cardTrunkDefenseColumn.ReadOnly = true;
      this.cardTrunkDefenseColumn.Width = 40;
      // 
      // cardTrunkLevelColumn
      // 
      this.cardTrunkLevelColumn.DataPropertyName = "Level";
      this.cardTrunkLevelColumn.HeaderText = "Lvl";
      this.cardTrunkLevelColumn.Name = "cardTrunkLevelColumn";
      this.cardTrunkLevelColumn.ReadOnly = true;
      this.cardTrunkLevelColumn.Width = 30;
      // 
      // cardTrunkAttributeColumn
      // 
      this.cardTrunkAttributeColumn.DataPropertyName = "AttributeName";
      this.cardTrunkAttributeColumn.HeaderText = "Attribute";
      this.cardTrunkAttributeColumn.Name = "cardTrunkAttributeColumn";
      this.cardTrunkAttributeColumn.ReadOnly = true;
      this.cardTrunkAttributeColumn.Width = 50;
      // 
      // cardTrunkTypeColumn
      // 
      this.cardTrunkTypeColumn.DataPropertyName = "Type";
      this.cardTrunkTypeColumn.HeaderText = "Type";
      this.cardTrunkTypeColumn.Name = "cardTrunkTypeColumn";
      this.cardTrunkTypeColumn.ReadOnly = true;
      // 
      // cardTrunkDeckCostColumn
      // 
      this.cardTrunkDeckCostColumn.DataPropertyName = "DeckCost";
      this.cardTrunkDeckCostColumn.HeaderText = "DC";
      this.cardTrunkDeckCostColumn.Name = "cardTrunkDeckCostColumn";
      this.cardTrunkDeckCostColumn.ReadOnly = true;
      this.cardTrunkDeckCostColumn.Width = 30;
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
      this.deckEditorSplitContainer.Panel1.Controls.Add(this.decksLabel);
      this.deckEditorSplitContainer.Panel1.Controls.Add(this.deckLabel);
      this.deckEditorSplitContainer.Panel1.Controls.Add(this.comboBox1);
      this.deckEditorSplitContainer.Panel1.Controls.Add(this.deckEditSaveButton);
      this.deckEditorSplitContainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.deckEditorSplitContainer_Panel1_Paint);
      // 
      // deckEditorSplitContainer.Panel2
      // 
      this.deckEditorSplitContainer.Panel2.Controls.Add(this.deckEditorDataGridView);
      this.deckEditorSplitContainer.Size = new System.Drawing.Size(557, 522);
      this.deckEditorSplitContainer.SplitterDistance = 60;
      this.deckEditorSplitContainer.TabIndex = 0;
      // 
      // decksLabel
      // 
      this.decksLabel.AutoSize = true;
      this.decksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.decksLabel.Location = new System.Drawing.Point(3, 6);
      this.decksLabel.Name = "decksLabel";
      this.decksLabel.Size = new System.Drawing.Size(59, 20);
      this.decksLabel.TabIndex = 6;
      this.decksLabel.Text = "Decks";
      // 
      // deckLabel
      // 
      this.deckLabel.AutoSize = true;
      this.deckLabel.Location = new System.Drawing.Point(4, 37);
      this.deckLabel.Name = "deckLabel";
      this.deckLabel.Size = new System.Drawing.Size(36, 13);
      this.deckLabel.TabIndex = 2;
      this.deckLabel.Text = "Deck:";
      // 
      // comboBox1
      // 
      this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.comboBox1.FormattingEnabled = true;
      this.comboBox1.Location = new System.Drawing.Point(46, 33);
      this.comboBox1.Name = "comboBox1";
      this.comboBox1.Size = new System.Drawing.Size(147, 21);
      this.comboBox1.TabIndex = 1;
      this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // deckEditSaveButton
      // 
      this.deckEditSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.deckEditSaveButton.Location = new System.Drawing.Point(479, 31);
      this.deckEditSaveButton.Name = "deckEditSaveButton";
      this.deckEditSaveButton.Size = new System.Drawing.Size(75, 23);
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
      this.deckEditorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.deckEditorDataGridView.Location = new System.Drawing.Point(0, 0);
      this.deckEditorDataGridView.Name = "deckEditorDataGridView";
      this.deckEditorDataGridView.RowHeadersVisible = false;
      this.deckEditorDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.deckEditorDataGridView.Size = new System.Drawing.Size(557, 458);
      this.deckEditorDataGridView.TabIndex = 0;
      // 
      // indexColumn
      // 
      this.indexColumn.DataPropertyName = "Number";
      this.indexColumn.HeaderText = "#";
      this.indexColumn.Name = "indexColumn";
      this.indexColumn.ReadOnly = true;
      this.indexColumn.Width = 32;
      // 
      // deckTableNameColumn
      // 
      this.deckTableNameColumn.DataPropertyName = "Name";
      this.deckTableNameColumn.HeaderText = "Name";
      this.deckTableNameColumn.Name = "deckTableNameColumn";
      this.deckTableNameColumn.ReadOnly = true;
      this.deckTableNameColumn.Width = 200;
      // 
      // deckEditAttackColumn
      // 
      this.deckEditAttackColumn.DataPropertyName = "Attack";
      this.deckEditAttackColumn.HeaderText = "Attack";
      this.deckEditAttackColumn.Name = "deckEditAttackColumn";
      this.deckEditAttackColumn.ReadOnly = true;
      this.deckEditAttackColumn.Width = 40;
      // 
      // deckEditDefenseColumn
      // 
      this.deckEditDefenseColumn.DataPropertyName = "Defense";
      this.deckEditDefenseColumn.HeaderText = "Defense";
      this.deckEditDefenseColumn.Name = "deckEditDefenseColumn";
      this.deckEditDefenseColumn.ReadOnly = true;
      this.deckEditDefenseColumn.Width = 40;
      // 
      // deckEditLevelColumn
      // 
      this.deckEditLevelColumn.DataPropertyName = "Level";
      this.deckEditLevelColumn.HeaderText = "Lvl";
      this.deckEditLevelColumn.Name = "deckEditLevelColumn";
      this.deckEditLevelColumn.ReadOnly = true;
      this.deckEditLevelColumn.Width = 30;
      // 
      // deckEditAttributeColumn
      // 
      this.deckEditAttributeColumn.DataPropertyName = "Attribute";
      this.deckEditAttributeColumn.HeaderText = "Attribute";
      this.deckEditAttributeColumn.Name = "deckEditAttributeColumn";
      this.deckEditAttributeColumn.ReadOnly = true;
      this.deckEditAttributeColumn.Width = 50;
      // 
      // deckEditTypeColumn
      // 
      this.deckEditTypeColumn.DataPropertyName = "Type";
      this.deckEditTypeColumn.HeaderText = "Type";
      this.deckEditTypeColumn.Name = "deckEditTypeColumn";
      this.deckEditTypeColumn.ReadOnly = true;
      // 
      // deckEditDeckCostColumn
      // 
      this.deckEditDeckCostColumn.DataPropertyName = "DeckCost";
      this.deckEditDeckCostColumn.HeaderText = "DC";
      this.deckEditDeckCostColumn.Name = "deckEditDeckCostColumn";
      this.deckEditDeckCostColumn.ReadOnly = true;
      this.deckEditDeckCostColumn.Width = 30;
      // 
      // deckLeaderAbilitiesTab
      // 
      this.deckLeaderAbilitiesTab.Controls.Add(this.cardDeckLeaderAbilitiesSplitContainer);
      this.deckLeaderAbilitiesTab.Location = new System.Drawing.Point(4, 22);
      this.deckLeaderAbilitiesTab.Name = "deckLeaderAbilitiesTab";
      this.deckLeaderAbilitiesTab.Padding = new System.Windows.Forms.Padding(3);
      this.deckLeaderAbilitiesTab.Size = new System.Drawing.Size(1117, 528);
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
      this.cardDeckLeaderAbilitiesSplitContainer.Size = new System.Drawing.Size(1111, 522);
      this.cardDeckLeaderAbilitiesSplitContainer.SplitterDistance = 25;
      this.cardDeckLeaderAbilitiesSplitContainer.TabIndex = 0;
      // 
      // deckLeaderAbilityTabTipsLabel
      // 
      this.deckLeaderAbilityTabTipsLabel.AutoSize = true;
      this.deckLeaderAbilityTabTipsLabel.Location = new System.Drawing.Point(5, 8);
      this.deckLeaderAbilityTabTipsLabel.Name = "deckLeaderAbilityTabTipsLabel";
      this.deckLeaderAbilityTabTipsLabel.Size = new System.Drawing.Size(411, 13);
      this.deckLeaderAbilityTabTipsLabel.TabIndex = 2;
      this.deckLeaderAbilityTabTipsLabel.Text = "Select multiple records with shift or control keys, right click to edit deck lead" +
    "er abilities.";
      // 
      // deckLeaderAbilitiesSaveButton
      // 
      this.deckLeaderAbilitiesSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.deckLeaderAbilitiesSaveButton.Location = new System.Drawing.Point(1031, 3);
      this.deckLeaderAbilitiesSaveButton.Name = "deckLeaderAbilitiesSaveButton";
      this.deckLeaderAbilitiesSaveButton.Size = new System.Drawing.Size(75, 23);
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
      this.cardDeckLeaderAbilitiesDatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.cardDeckLeaderAbilitiesDatagridview.Size = new System.Drawing.Size(1111, 493);
      this.cardDeckLeaderAbilitiesDatagridview.TabIndex = 0;
      // 
      // cardDeckLeaderAbilitiesIndexColumn
      // 
      this.cardDeckLeaderAbilitiesIndexColumn.DataPropertyName = "Index";
      this.cardDeckLeaderAbilitiesIndexColumn.HeaderText = "Index";
      this.cardDeckLeaderAbilitiesIndexColumn.Name = "cardDeckLeaderAbilitiesIndexColumn";
      this.cardDeckLeaderAbilitiesIndexColumn.ReadOnly = true;
      this.cardDeckLeaderAbilitiesIndexColumn.Width = 30;
      // 
      // cardDeckLeaderAbilitiesNameColumn
      // 
      this.cardDeckLeaderAbilitiesNameColumn.DataPropertyName = "Name";
      this.cardDeckLeaderAbilitiesNameColumn.HeaderText = "Name";
      this.cardDeckLeaderAbilitiesNameColumn.Name = "cardDeckLeaderAbilitiesNameColumn";
      this.cardDeckLeaderAbilitiesNameColumn.ReadOnly = true;
      this.cardDeckLeaderAbilitiesNameColumn.Width = 140;
      // 
      // cardDeckLeaderAbilitiesEnabledAbilitiesColumn
      // 
      this.cardDeckLeaderAbilitiesEnabledAbilitiesColumn.DataPropertyName = "EnabledAbilitiesString";
      this.cardDeckLeaderAbilitiesEnabledAbilitiesColumn.HeaderText = "Enabled Abilities";
      this.cardDeckLeaderAbilitiesEnabledAbilitiesColumn.Name = "cardDeckLeaderAbilitiesEnabledAbilitiesColumn";
      this.cardDeckLeaderAbilitiesEnabledAbilitiesColumn.ReadOnly = true;
      this.cardDeckLeaderAbilitiesEnabledAbilitiesColumn.Width = 800;
      // 
      // Bytes
      // 
      this.Bytes.DataPropertyName = "Bytes";
      this.Bytes.HeaderText = "Bytes";
      this.Bytes.Name = "Bytes";
      this.Bytes.Visible = false;
      // 
      // equipCompabilityTab
      // 
      this.equipCompabilityTab.Controls.Add(this.equipCompabilitySplitContainer);
      this.equipCompabilityTab.Location = new System.Drawing.Point(4, 22);
      this.equipCompabilityTab.Name = "equipCompabilityTab";
      this.equipCompabilityTab.Padding = new System.Windows.Forms.Padding(3);
      this.equipCompabilityTab.Size = new System.Drawing.Size(1117, 528);
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
      this.equipCompabilitySplitContainer.Size = new System.Drawing.Size(1111, 522);
      this.equipCompabilitySplitContainer.SplitterDistance = 31;
      this.equipCompabilitySplitContainer.TabIndex = 0;
      // 
      // cardEquipNoteLabel1
      // 
      this.cardEquipNoteLabel1.AutoSize = true;
      this.cardEquipNoteLabel1.Location = new System.Drawing.Point(3, 10);
      this.cardEquipNoteLabel1.Name = "cardEquipNoteLabel1";
      this.cardEquipNoteLabel1.Size = new System.Drawing.Size(412, 13);
      this.cardEquipNoteLabel1.TabIndex = 1;
      this.cardEquipNoteLabel1.Text = "Select multiple records with shift or control keys, right click to edit equip com" +
    "patibilities.";
      // 
      // equipCompatibilitySaveButton
      // 
      this.equipCompatibilitySaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.equipCompatibilitySaveButton.Location = new System.Drawing.Point(1031, 5);
      this.equipCompatibilitySaveButton.Name = "equipCompatibilitySaveButton";
      this.equipCompatibilitySaveButton.Size = new System.Drawing.Size(75, 23);
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
      this.equipCompatibilityDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.equipCompatibilityDataGridView.Size = new System.Drawing.Size(1111, 487);
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
      this.monsterCardEquipCompatibilitiesContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMonsterEquipMenuItem});
      this.monsterCardEquipCompatibilitiesContextMenuStrip.Name = "monsterCardEquipCompatibilitiesContextMenuStrip";
      this.monsterCardEquipCompatibilitiesContextMenuStrip.Size = new System.Drawing.Size(173, 26);
      // 
      // editMonsterEquipMenuItem
      // 
      this.editMonsterEquipMenuItem.Name = "editMonsterEquipMenuItem";
      this.editMonsterEquipMenuItem.Size = new System.Drawing.Size(172, 22);
      this.editMonsterEquipMenuItem.Text = "Edit selected items";
      this.editMonsterEquipMenuItem.Click += new System.EventHandler(this.ShowMonsterCardEquipCompatibilityEditDialog);
      // 
      // cardConstantsContextStrip
      // 
      this.cardConstantsContextStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.cardConstantsContextStrip.Name = "cardConstantsContextStrip";
      this.cardConstantsContextStrip.Size = new System.Drawing.Size(61, 4);
      // 
      // cardDeckLeaderAbilitiesContextStrip
      // 
      this.cardDeckLeaderAbilitiesContextStrip.Name = "cardDeckLeaderAbilitiesContextStrip";
      this.cardDeckLeaderAbilitiesContextStrip.Size = new System.Drawing.Size(61, 4);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1125, 579);
      this.Controls.Add(this.mainTabControl);
      this.Controls.Add(this.menuStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
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
      ((System.ComponentModel.ISupportInitialize)(this.deckEditAllCardsDataGridView)).EndInit();
      this.deckEditorSplitContainer.Panel1.ResumeLayout(false);
      this.deckEditorSplitContainer.Panel1.PerformLayout();
      this.deckEditorSplitContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.deckEditorSplitContainer)).EndInit();
      this.deckEditorSplitContainer.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.deckEditorDataGridView)).EndInit();
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
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private ToolStripMenuItem aboutToolStripMenuItem;
    private ToolStripMenuItem viewSourceOnGithubToolStripMenuItem;
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
    private DataGridView deckEditAllCardsDataGridView;
    private SplitContainer deckEditorSplitContainer;
    private Label deckLabel;
    private ComboBox comboBox1;
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
  }
}
