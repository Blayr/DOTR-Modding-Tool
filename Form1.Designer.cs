namespace DOTR_Deck_Leader_Thresholds
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
    private TabControl tabControl1;
    private TabPage leaderRankTresholdsTabControl;
    private TextBox originalRankThresholdsTextbox;
    private DataGridView rankThresholdsDataGridView;
    private TabPage tabPage1;
    private Button button1;

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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.openISOMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveCardConstantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.leaderRankTresholdsTabControl = new System.Windows.Forms.TabPage();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.newRankThresholdsTextbox = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.rankThresholdsDataGridView = new System.Windows.Forms.DataGridView();
      this.originalRankThresholdsTextbox = new System.Windows.Forms.TextBox();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.cardConstantsDataGridView = new System.Windows.Forms.DataGridView();
      this.CardConstantId = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CardConstantName = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CardConstantDeckCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CardConstantAttack = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CardConstantDefense = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.CardConstantSlots = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.CardConstantIsSlotRare = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.CardConstantReincarnation = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.CardConstantPasswordWorks = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.menuStrip1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.leaderRankTresholdsTabControl.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.rankThresholdsDataGridView)).BeginInit();
      this.tabPage1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cardConstantsDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openISOMenuItem,
            this.saveToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(858, 24);
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
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveCardConstantsToolStripMenuItem});
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
      this.saveToolStripMenuItem.Text = "Save";
      this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
      // 
      // saveCardConstantsToolStripMenuItem
      // 
      this.saveCardConstantsToolStripMenuItem.Name = "saveCardConstantsToolStripMenuItem";
      this.saveCardConstantsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
      this.saveCardConstantsToolStripMenuItem.Text = "Save Card Constants";
      this.saveCardConstantsToolStripMenuItem.Click += new System.EventHandler(this.saveCardConstantsToolStripMenuItem_Click);
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl1.Controls.Add(this.leaderRankTresholdsTabControl);
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Location = new System.Drawing.Point(0, 27);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(858, 452);
      this.tabControl1.TabIndex = 3;
      // 
      // leaderRankTresholdsTabControl
      // 
      this.leaderRankTresholdsTabControl.Controls.Add(this.textBox2);
      this.leaderRankTresholdsTabControl.Controls.Add(this.textBox1);
      this.leaderRankTresholdsTabControl.Controls.Add(this.newRankThresholdsTextbox);
      this.leaderRankTresholdsTabControl.Controls.Add(this.button1);
      this.leaderRankTresholdsTabControl.Controls.Add(this.rankThresholdsDataGridView);
      this.leaderRankTresholdsTabControl.Controls.Add(this.originalRankThresholdsTextbox);
      this.leaderRankTresholdsTabControl.Location = new System.Drawing.Point(4, 22);
      this.leaderRankTresholdsTabControl.Name = "leaderRankTresholdsTabControl";
      this.leaderRankTresholdsTabControl.Padding = new System.Windows.Forms.Padding(3);
      this.leaderRankTresholdsTabControl.Size = new System.Drawing.Size(850, 426);
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
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(385, 114);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 18;
      this.button1.Text = "Save";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.Button1_Click);
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
      this.rankThresholdsDataGridView.RowTemplate.Height = 30;
      this.rankThresholdsDataGridView.Size = new System.Drawing.Size(315, 426);
      this.rankThresholdsDataGridView.TabIndex = 17;
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
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.cardConstantsDataGridView);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(850, 426);
      this.tabPage1.TabIndex = 1;
      this.tabPage1.Text = "Card Constants";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // cardConstantsDataGridView
      // 
      this.cardConstantsDataGridView.AllowUserToAddRows = false;
      this.cardConstantsDataGridView.AllowUserToDeleteRows = false;
      this.cardConstantsDataGridView.AllowUserToOrderColumns = true;
      this.cardConstantsDataGridView.AllowUserToResizeRows = false;
      this.cardConstantsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.cardConstantsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
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
            this.CardConstantDeckCost,
            this.CardConstantAttack,
            this.CardConstantDefense,
            this.CardConstantSlots,
            this.CardConstantIsSlotRare,
            this.CardConstantReincarnation,
            this.CardConstantPasswordWorks});
      this.cardConstantsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cardConstantsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
      this.cardConstantsDataGridView.Location = new System.Drawing.Point(3, 3);
      this.cardConstantsDataGridView.MultiSelect = false;
      this.cardConstantsDataGridView.Name = "cardConstantsDataGridView";
      this.cardConstantsDataGridView.RowHeadersVisible = false;
      this.cardConstantsDataGridView.Size = new System.Drawing.Size(844, 420);
      this.cardConstantsDataGridView.TabIndex = 0;
      // 
      // CardConstantId
      // 
      this.CardConstantId.DataPropertyName = "Index";
      this.CardConstantId.HeaderText = "ID";
      this.CardConstantId.Name = "CardConstantId";
      this.CardConstantId.ReadOnly = true;
      this.CardConstantId.Width = 34;
      // 
      // CardConstantName
      // 
      this.CardConstantName.DataPropertyName = "Name";
      this.CardConstantName.HeaderText = "Name";
      this.CardConstantName.Name = "CardConstantName";
      this.CardConstantName.ReadOnly = true;
      this.CardConstantName.Width = 160;
      // 
      // CardConstantDeckCost
      // 
      this.CardConstantDeckCost.DataPropertyName = "DeckCost";
      this.CardConstantDeckCost.HeaderText = "DC";
      this.CardConstantDeckCost.Name = "CardConstantDeckCost";
      this.CardConstantDeckCost.Width = 30;
      // 
      // CardConstantAttack
      // 
      this.CardConstantAttack.DataPropertyName = "Attack";
      this.CardConstantAttack.HeaderText = "Atk";
      this.CardConstantAttack.Name = "CardConstantAttack";
      this.CardConstantAttack.Width = 40;
      // 
      // CardConstantDefense
      // 
      this.CardConstantDefense.DataPropertyName = "Defense";
      this.CardConstantDefense.HeaderText = "Def";
      this.CardConstantDefense.Name = "CardConstantDefense";
      this.CardConstantDefense.Width = 40;
      // 
      // CardConstantSlots
      // 
      this.CardConstantSlots.DataPropertyName = "AppearsInSlotReels";
      this.CardConstantSlots.HeaderText = "Slots";
      this.CardConstantSlots.Name = "CardConstantSlots";
      this.CardConstantSlots.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.CardConstantSlots.Width = 40;
      // 
      // CardConstantIsSlotRare
      // 
      this.CardConstantIsSlotRare.DataPropertyName = "IsSlotRare";
      this.CardConstantIsSlotRare.HeaderText = "Slot Rare";
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
      this.CardConstantReincarnation.Name = "CardConstantReincarnation";
      this.CardConstantReincarnation.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.CardConstantReincarnation.TrueValue = "true";
      this.CardConstantReincarnation.Width = 46;
      // 
      // CardConstantPasswordWorks
      // 
      this.CardConstantPasswordWorks.DataPropertyName = "PasswordWorks";
      this.CardConstantPasswordWorks.HeaderText = "PWD Works";
      this.CardConstantPasswordWorks.Name = "CardConstantPasswordWorks";
      this.CardConstantPasswordWorks.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.CardConstantPasswordWorks.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.CardConstantPasswordWorks.Width = 46;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(858, 477);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.menuStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "DOTR Modding Tool";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.leaderRankTresholdsTabControl.ResumeLayout(false);
      this.leaderRankTresholdsTabControl.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.rankThresholdsDataGridView)).EndInit();
      this.tabPage1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.cardConstantsDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private TextBox newRankThresholdsTextbox;
    private TextBox textBox2;
    private TextBox textBox1;
    private DataGridView cardConstantsDataGridView;
    private ToolStripMenuItem saveToolStripMenuItem;
    private ToolStripMenuItem saveCardConstantsToolStripMenuItem;
    private DataGridViewTextBoxColumn CardConstantId;
    private DataGridViewTextBoxColumn CardConstantName;
    private DataGridViewTextBoxColumn CardConstantDeckCost;
    private DataGridViewTextBoxColumn CardConstantAttack;
    private DataGridViewTextBoxColumn CardConstantDefense;
    private DataGridViewCheckBoxColumn CardConstantSlots;
    private DataGridViewCheckBoxColumn CardConstantIsSlotRare;
    private DataGridViewCheckBoxColumn CardConstantReincarnation;
    private DataGridViewCheckBoxColumn CardConstantPasswordWorks;
  }
}
