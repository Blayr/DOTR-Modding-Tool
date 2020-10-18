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
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.splitContainer2 = new System.Windows.Forms.SplitContainer();
      this.fusionTableTipLabel = new System.Windows.Forms.Label();
      this.fusionSaveButton = new System.Windows.Forms.Button();
      this.fusionsDataGridView = new System.Windows.Forms.DataGridView();
      this.tabPage1 = new System.Windows.Forms.TabPage();
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
      this.leaderRankTresholdsTabControl = new System.Windows.Forms.TabPage();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.newRankThresholdsTextbox = new System.Windows.Forms.TextBox();
      this.originalRankThresholdsTextbox = new System.Windows.Forms.TextBox();
      this.rankThresholdsSaveButton = new System.Windows.Forms.Button();
      this.rankThresholdsDataGridView = new System.Windows.Forms.DataGridView();
      this.tabControl = new System.Windows.Forms.TabControl();
      this.deckLeaderAbilitiesTab = new System.Windows.Forms.TabPage();
      this.cardDeckLeaderAbilitiesSplitContainer = new System.Windows.Forms.SplitContainer();
      this.cardDeckLeaderAbilitiesDatagridview = new System.Windows.Forms.DataGridView();
      this.cardDeckLeaderAbilitiesIndexColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cardDeckLeaderAbilitiesNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cardDeckLeaderAbilitiesEnabledAbilitiesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.cardConstantsContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.cardDeckLeaderAbilitiesContextStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.FusionsDataGridViewIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.LowerCardMaterialCardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.FusionsDataGridViewLowerCard = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.HigherCardMaterialCardNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.FusionsDataGridViewUpperCard = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.ResultingFusionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.FusionsDataGridViewFusionCard = new System.Windows.Forms.DataGridViewComboBoxColumn();
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
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
      this.splitContainer2.Panel1.SuspendLayout();
      this.splitContainer2.Panel2.SuspendLayout();
      this.splitContainer2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.fusionsDataGridView)).BeginInit();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cardConstantsDataGridView)).BeginInit();
      this.leaderRankTresholdsTabControl.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.rankThresholdsDataGridView)).BeginInit();
      this.tabControl.SuspendLayout();
      this.deckLeaderAbilitiesTab.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cardDeckLeaderAbilitiesSplitContainer)).BeginInit();
      this.cardDeckLeaderAbilitiesSplitContainer.Panel2.SuspendLayout();
      this.cardDeckLeaderAbilitiesSplitContainer.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cardDeckLeaderAbilitiesDatagridview)).BeginInit();
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
      this.menuStrip1.Size = new System.Drawing.Size(938, 24);
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
      this.hiddenCardsTab.Size = new System.Drawing.Size(930, 496);
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
      this.hiddenCardsSplitContainer.Size = new System.Drawing.Size(924, 490);
      this.hiddenCardsSplitContainer.SplitterDistance = 193;
      this.hiddenCardsSplitContainer.TabIndex = 0;
      // 
      // treasureCardsListbox
      // 
      this.treasureCardsListbox.DisplayMember = "EnemyName";
      this.treasureCardsListbox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.treasureCardsListbox.FormattingEnabled = true;
      this.treasureCardsListbox.Location = new System.Drawing.Point(0, 0);
      this.treasureCardsListbox.Name = "treasureCardsListbox";
      this.treasureCardsListbox.Size = new System.Drawing.Size(193, 490);
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
      this.enemyAiTab.Size = new System.Drawing.Size(930, 496);
      this.enemyAiTab.TabIndex = 3;
      this.enemyAiTab.Text = "Enemy Ai";
      this.enemyAiTab.UseVisualStyleBackColor = true;
      // 
      // enemyAiTabSplitContainer
      // 
      this.enemyAiTabSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
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
      this.enemyAiTabSplitContainer.Size = new System.Drawing.Size(924, 490);
      this.enemyAiTabSplitContainer.SplitterDistance = 25;
      this.enemyAiTabSplitContainer.TabIndex = 1;
      // 
      // enemyAiSaveButton
      // 
      this.enemyAiSaveButton.Dock = System.Windows.Forms.DockStyle.Right;
      this.enemyAiSaveButton.Location = new System.Drawing.Point(849, 0);
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
      this.enemyAiDataGridView.Size = new System.Drawing.Size(924, 461);
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
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.splitContainer2);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(930, 496);
      this.tabPage2.TabIndex = 2;
      this.tabPage2.Text = "Fusions";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // splitContainer2
      // 
      this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
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
      this.splitContainer2.Size = new System.Drawing.Size(924, 490);
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
      this.fusionSaveButton.Location = new System.Drawing.Point(849, 0);
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
      this.fusionsDataGridView.Size = new System.Drawing.Size(924, 461);
      this.fusionsDataGridView.TabIndex = 0;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.splitContainer1);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(930, 496);
      this.tabPage1.TabIndex = 1;
      this.tabPage1.Text = "Card Properties";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
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
      this.splitContainer1.Size = new System.Drawing.Size(924, 490);
      this.splitContainer1.SplitterDistance = 25;
      this.splitContainer1.TabIndex = 1;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(323, 7);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(248, 13);
      this.label8.TabIndex = 5;
      this.label8.Text = "Tip: Select multiple rows with shift, right click to edit";
      // 
      // cardConstantsSaveButton
      // 
      this.cardConstantsSaveButton.Dock = System.Windows.Forms.DockStyle.Right;
      this.cardConstantsSaveButton.Location = new System.Drawing.Point(849, 0);
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
      this.cardConstantsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
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
      this.cardConstantsDataGridView.Size = new System.Drawing.Size(924, 461);
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
      // leaderRankTresholdsTabControl
      // 
      this.leaderRankTresholdsTabControl.Controls.Add(this.textBox2);
      this.leaderRankTresholdsTabControl.Controls.Add(this.textBox1);
      this.leaderRankTresholdsTabControl.Controls.Add(this.newRankThresholdsTextbox);
      this.leaderRankTresholdsTabControl.Controls.Add(this.originalRankThresholdsTextbox);
      this.leaderRankTresholdsTabControl.Controls.Add(this.rankThresholdsSaveButton);
      this.leaderRankTresholdsTabControl.Controls.Add(this.rankThresholdsDataGridView);
      this.leaderRankTresholdsTabControl.Location = new System.Drawing.Point(4, 22);
      this.leaderRankTresholdsTabControl.Name = "leaderRankTresholdsTabControl";
      this.leaderRankTresholdsTabControl.Padding = new System.Windows.Forms.Padding(3);
      this.leaderRankTresholdsTabControl.Size = new System.Drawing.Size(930, 496);
      this.leaderRankTresholdsTabControl.TabIndex = 0;
      this.leaderRankTresholdsTabControl.Text = "Rank Thresholds";
      this.leaderRankTresholdsTabControl.UseVisualStyleBackColor = true;
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
      // tabControl
      // 
      this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl.Controls.Add(this.leaderRankTresholdsTabControl);
      this.tabControl.Controls.Add(this.tabPage1);
      this.tabControl.Controls.Add(this.tabPage2);
      this.tabControl.Controls.Add(this.enemyAiTab);
      this.tabControl.Controls.Add(this.hiddenCardsTab);
      this.tabControl.Controls.Add(this.deckLeaderAbilitiesTab);
      this.tabControl.Location = new System.Drawing.Point(0, 27);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(938, 522);
      this.tabControl.TabIndex = 3;
      // 
      // deckLeaderAbilitiesTab
      // 
      this.deckLeaderAbilitiesTab.Controls.Add(this.cardDeckLeaderAbilitiesSplitContainer);
      this.deckLeaderAbilitiesTab.Location = new System.Drawing.Point(4, 22);
      this.deckLeaderAbilitiesTab.Name = "deckLeaderAbilitiesTab";
      this.deckLeaderAbilitiesTab.Padding = new System.Windows.Forms.Padding(3);
      this.deckLeaderAbilitiesTab.Size = new System.Drawing.Size(930, 496);
      this.deckLeaderAbilitiesTab.TabIndex = 5;
      this.deckLeaderAbilitiesTab.Text = "Deck Leader Abilities";
      this.deckLeaderAbilitiesTab.UseVisualStyleBackColor = true;
      // 
      // cardDeckLeaderAbilitiesSplitContainer
      // 
      this.cardDeckLeaderAbilitiesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cardDeckLeaderAbilitiesSplitContainer.Location = new System.Drawing.Point(3, 3);
      this.cardDeckLeaderAbilitiesSplitContainer.Name = "cardDeckLeaderAbilitiesSplitContainer";
      this.cardDeckLeaderAbilitiesSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // cardDeckLeaderAbilitiesSplitContainer.Panel2
      // 
      this.cardDeckLeaderAbilitiesSplitContainer.Panel2.Controls.Add(this.cardDeckLeaderAbilitiesDatagridview);
      this.cardDeckLeaderAbilitiesSplitContainer.Size = new System.Drawing.Size(924, 490);
      this.cardDeckLeaderAbilitiesSplitContainer.SplitterDistance = 27;
      this.cardDeckLeaderAbilitiesSplitContainer.TabIndex = 0;
      // 
      // cardDeckLeaderAbilitiesDatagridview
      // 
      this.cardDeckLeaderAbilitiesDatagridview.AllowUserToAddRows = false;
      this.cardDeckLeaderAbilitiesDatagridview.AllowUserToDeleteRows = false;
      this.cardDeckLeaderAbilitiesDatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.cardDeckLeaderAbilitiesDatagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cardDeckLeaderAbilitiesIndexColumn,
            this.cardDeckLeaderAbilitiesNameColumn,
            this.cardDeckLeaderAbilitiesEnabledAbilitiesColumn});
      this.cardDeckLeaderAbilitiesDatagridview.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cardDeckLeaderAbilitiesDatagridview.Location = new System.Drawing.Point(0, 0);
      this.cardDeckLeaderAbilitiesDatagridview.Name = "cardDeckLeaderAbilitiesDatagridview";
      this.cardDeckLeaderAbilitiesDatagridview.RowHeadersVisible = false;
      this.cardDeckLeaderAbilitiesDatagridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.cardDeckLeaderAbilitiesDatagridview.Size = new System.Drawing.Size(924, 459);
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
      this.FusionsDataGridViewFusionCard.HeaderText = "Resulting Fusion Name";
      this.FusionsDataGridViewFusionCard.MinimumWidth = 6;
      this.FusionsDataGridViewFusionCard.Name = "FusionsDataGridViewFusionCard";
      this.FusionsDataGridViewFusionCard.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.FusionsDataGridViewFusionCard.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
      this.FusionsDataGridViewFusionCard.Width = 200;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(938, 547);
      this.Controls.Add(this.tabControl);
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
      this.tabPage2.ResumeLayout(false);
      this.splitContainer2.Panel1.ResumeLayout(false);
      this.splitContainer2.Panel1.PerformLayout();
      this.splitContainer2.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
      this.splitContainer2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.fusionsDataGridView)).EndInit();
      this.tabPage1.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.cardConstantsDataGridView)).EndInit();
      this.leaderRankTresholdsTabControl.ResumeLayout(false);
      this.leaderRankTresholdsTabControl.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.rankThresholdsDataGridView)).EndInit();
      this.tabControl.ResumeLayout(false);
      this.deckLeaderAbilitiesTab.ResumeLayout(false);
      this.cardDeckLeaderAbilitiesSplitContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.cardDeckLeaderAbilitiesSplitContainer)).EndInit();
      this.cardDeckLeaderAbilitiesSplitContainer.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.cardDeckLeaderAbilitiesDatagridview)).EndInit();
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
    private TabPage tabPage2;
    private SplitContainer splitContainer2;
    private Label fusionTableTipLabel;
    private Button fusionSaveButton;
    private DataGridView fusionsDataGridView;
    private TabPage tabPage1;
    private SplitContainer splitContainer1;
    private Button cardConstantsSaveButton;
    private Button cardConstantFilterClearButton;
    private Label label1;
    private Button cardConstantsFilterButton;
    private TextBox cardConstantsFilterTextbox;
    private DataGridView cardConstantsDataGridView;
    private TabPage leaderRankTresholdsTabControl;
    private TextBox textBox2;
    private TextBox textBox1;
    private TextBox newRankThresholdsTextbox;
    private TextBox originalRankThresholdsTextbox;
    private Button rankThresholdsSaveButton;
    private DataGridView rankThresholdsDataGridView;
    private TabControl tabControl;
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
    private DataGridViewTextBoxColumn cardDeckLeaderAbilitiesIndexColumn;
    private DataGridViewTextBoxColumn cardDeckLeaderAbilitiesNameColumn;
    private DataGridViewTextBoxColumn cardDeckLeaderAbilitiesEnabledAbilitiesColumn;
    private ContextMenuStrip cardDeckLeaderAbilitiesContextStrip;
    private DataGridViewTextBoxColumn FusionsDataGridViewIndex;
    private DataGridViewTextBoxColumn LowerCardMaterialCardNumber;
    private DataGridViewComboBoxColumn FusionsDataGridViewLowerCard;
    private DataGridViewTextBoxColumn HigherCardMaterialCardNumber;
    private DataGridViewComboBoxColumn FusionsDataGridViewUpperCard;
    private DataGridViewTextBoxColumn ResultingFusionId;
    private DataGridViewComboBoxColumn FusionsDataGridViewFusionCard;
  }
}
