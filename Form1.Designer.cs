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
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.openISOMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.leaderRankTresholdsTabControl = new System.Windows.Forms.TabPage();
      this.textBox2 = new System.Windows.Forms.TextBox();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.newRankThresholdsTextbox = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.rankThresholdsDataGridView = new System.Windows.Forms.DataGridView();
      this.originalRankThresholdsTextbox = new System.Windows.Forms.TextBox();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.menuStrip1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.leaderRankTresholdsTabControl.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.rankThresholdsDataGridView)).BeginInit();
      this.SuspendLayout();
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openISOMenuItem});
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
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(850, 426);
      this.tabPage1.TabIndex = 1;
      this.tabPage1.Text = "tabPage1";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(858, 477);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.Text = "DOTR Modding Tool";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.tabControl1.ResumeLayout(false);
      this.leaderRankTresholdsTabControl.ResumeLayout(false);
      this.leaderRankTresholdsTabControl.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.rankThresholdsDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private TextBox newRankThresholdsTextbox;
    private TextBox textBox2;
    private TextBox textBox1;
  }
}
