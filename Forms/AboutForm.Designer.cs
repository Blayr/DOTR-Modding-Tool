namespace DOTR_MODDING_TOOL.Forms
{
  partial class AboutForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
      this.toolNameLabel = new System.Windows.Forms.Label();
      this.versionNumberLabel = new System.Windows.Forms.Label();
      this.authorLabel = new System.Windows.Forms.Label();
      this.authorLinkLabel = new System.Windows.Forms.LinkLabel();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.SuspendLayout();
      // 
      // toolNameLabel
      // 
      this.toolNameLabel.AutoSize = true;
      this.toolNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.toolNameLabel.Location = new System.Drawing.Point(12, 9);
      this.toolNameLabel.Name = "toolNameLabel";
      this.toolNameLabel.Size = new System.Drawing.Size(184, 37);
      this.toolNameLabel.TabIndex = 0;
      this.toolNameLabel.Text = "Tool Name";
      // 
      // versionNumberLabel
      // 
      this.versionNumberLabel.AutoSize = true;
      this.versionNumberLabel.Location = new System.Drawing.Point(16, 46);
      this.versionNumberLabel.Name = "versionNumberLabel";
      this.versionNumberLabel.Size = new System.Drawing.Size(82, 13);
      this.versionNumberLabel.TabIndex = 1;
      this.versionNumberLabel.Text = "Version Number";
      // 
      // authorLabel
      // 
      this.authorLabel.AutoSize = true;
      this.authorLabel.Location = new System.Drawing.Point(16, 68);
      this.authorLabel.Name = "authorLabel";
      this.authorLabel.Size = new System.Drawing.Size(41, 13);
      this.authorLabel.TabIndex = 2;
      this.authorLabel.Text = "Author:";
      // 
      // authorLinkLabel
      // 
      this.authorLinkLabel.AutoSize = true;
      this.authorLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
      this.authorLinkLabel.Location = new System.Drawing.Point(54, 68);
      this.authorLinkLabel.Name = "authorLinkLabel";
      this.authorLinkLabel.Size = new System.Drawing.Size(30, 13);
      this.authorLinkLabel.TabIndex = 3;
      this.authorLinkLabel.TabStop = true;
      this.authorLinkLabel.Text = "Blayr";
      this.authorLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.authorLinkLabel_LinkClicked);
      // 
      // richTextBox1
      // 
      this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
      this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.richTextBox1.Location = new System.Drawing.Point(19, 101);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.ReadOnly = true;
      this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
      this.richTextBox1.Size = new System.Drawing.Size(332, 82);
      this.richTextBox1.TabIndex = 5;
      this.richTextBox1.Text = "Special thanks to:\n\nGenericMadScientist - Rom Mapping\nClovis -  DOTR content crea" +
    "tor | Redux Mod Author\nThotsicle - Author of DOTR Map Editor | Redux Mod Co-Auth" +
    "or";
      // 
      // AboutForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(388, 203);
      this.Controls.Add(this.richTextBox1);
      this.Controls.Add(this.authorLinkLabel);
      this.Controls.Add(this.authorLabel);
      this.Controls.Add(this.versionNumberLabel);
      this.Controls.Add(this.toolNameLabel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "AboutForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "About";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label toolNameLabel;
    private System.Windows.Forms.Label versionNumberLabel;
    private System.Windows.Forms.Label authorLabel;
    private System.Windows.Forms.LinkLabel authorLinkLabel;
    private System.Windows.Forms.RichTextBox richTextBox1;
  }
}