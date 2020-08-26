using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security;
using System.Windows.Forms;

namespace DOTR_Deck_Leader_Thresholds
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
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
      this.RankThresholdsDataGridView = new System.Windows.Forms.DataGridView();
      this.rankThresholdsTextbox = new System.Windows.Forms.TextBox();
      this.RankImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
      this.RankNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.RankThresholdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.button1 = new System.Windows.Forms.Button();
      this.menuStrip1.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.leaderRankTresholdsTabControl.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.RankThresholdsDataGridView)).BeginInit();
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
      this.openISOMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
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
      this.leaderRankTresholdsTabControl.Controls.Add(this.button1);
      this.leaderRankTresholdsTabControl.Controls.Add(this.RankThresholdsDataGridView);
      this.leaderRankTresholdsTabControl.Controls.Add(this.rankThresholdsTextbox);
      this.leaderRankTresholdsTabControl.Location = new System.Drawing.Point(4, 22);
      this.leaderRankTresholdsTabControl.Name = "leaderRankTresholdsTabControl";
      this.leaderRankTresholdsTabControl.Padding = new System.Windows.Forms.Padding(3);
      this.leaderRankTresholdsTabControl.Size = new System.Drawing.Size(850, 426);
      this.leaderRankTresholdsTabControl.TabIndex = 0;
      this.leaderRankTresholdsTabControl.Text = "Rank Thresholds";
      this.leaderRankTresholdsTabControl.UseVisualStyleBackColor = true;
      this.leaderRankTresholdsTabControl.Click += new System.EventHandler(this.leaderRankTresholdsTabControl_Click);
      // 
      // RankThresholdsDataGridView
      // 
      this.RankThresholdsDataGridView.AllowUserToAddRows = false;
      this.RankThresholdsDataGridView.AllowUserToDeleteRows = false;
      this.RankThresholdsDataGridView.AllowUserToResizeColumns = false;
      this.RankThresholdsDataGridView.AllowUserToResizeRows = false;
      this.RankThresholdsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.RankThresholdsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RankImageColumn,
            this.RankNameColumn,
            this.RankThresholdColumn});
      this.RankThresholdsDataGridView.Location = new System.Drawing.Point(-4, 0);
      this.RankThresholdsDataGridView.MultiSelect = false;
      this.RankThresholdsDataGridView.Name = "RankThresholdsDataGridView";
      this.RankThresholdsDataGridView.RowHeadersVisible = false;
      this.RankThresholdsDataGridView.RowTemplate.Height = 30;
      this.RankThresholdsDataGridView.Size = new System.Drawing.Size(315, 426);
      this.RankThresholdsDataGridView.TabIndex = 17;
      // 
      // rankThresholdsTextbox
      // 
      this.rankThresholdsTextbox.BackColor = System.Drawing.SystemColors.Window;
      this.rankThresholdsTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.rankThresholdsTextbox.Location = new System.Drawing.Point(329, 39);
      this.rankThresholdsTextbox.Name = "rankThresholdsTextbox";
      this.rankThresholdsTextbox.ReadOnly = true;
      this.rankThresholdsTextbox.Size = new System.Drawing.Size(493, 13);
      this.rankThresholdsTextbox.TabIndex = 0;
      // 
      // RankImageColumn
      // 
      this.RankImageColumn.DataPropertyName = "Image";
      this.RankImageColumn.Frozen = true;
      this.RankImageColumn.HeaderText = "";
      this.RankImageColumn.Name = "RankImageColumn";
      this.RankImageColumn.ReadOnly = true;
      // 
      // RankNameColumn
      // 
      this.RankNameColumn.DataPropertyName = "Rank";
      this.RankNameColumn.Frozen = true;
      this.RankNameColumn.HeaderText = "Rank";
      this.RankNameColumn.Name = "RankNameColumn";
      this.RankNameColumn.ReadOnly = true;
      // 
      // RankThresholdColumn
      // 
      this.RankThresholdColumn.DataPropertyName = "Threshold";
      this.RankThresholdColumn.HeaderText = "Threshold";
      this.RankThresholdColumn.Name = "RankThresholdColumn";
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
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(394, 84);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 18;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
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
      ((System.ComponentModel.ISupportInitialize)(this.RankThresholdsDataGridView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem openISOMenuItem;
    private TabControl tabControl1;
    private TabPage leaderRankTresholdsTabControl;
    private TextBox rankThresholdsTextbox;
    private DataGridView RankThresholdsDataGridView;
    private DataGridViewImageColumn RankImageColumn;
    private DataGridViewTextBoxColumn RankNameColumn;
    private DataGridViewTextBoxColumn RankThresholdColumn;
    private TabPage tabPage1;
    private Button button1;
  }
}
