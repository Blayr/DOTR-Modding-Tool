namespace DOTR_MODDING_TOOL.Forms.DeckLeaderAbilityForms
{
  partial class EditRankRequirementDeckLeaderAbilityForm
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
      this.rankLabel = new System.Windows.Forms.Label();
      this.rankDropdown = new System.Windows.Forms.ComboBox();
      this.enabledCheckbox = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // cancelButton
      // 
      this.cancelButton.Location = new System.Drawing.Point(323, 291);
      // 
      // applyButton
      // 
      this.applyButton.Location = new System.Drawing.Point(404, 291);
      // 
      // abilityNameLabel
      // 
      this.abilityNameLabel.Location = new System.Drawing.Point(8, 9);
      // 
      // abilityDescriptionTextbox
      // 
      this.abilityDescriptionTextbox.Size = new System.Drawing.Size(250, 281);
      // 
      // bytesLabel
      // 
      this.bytesLabel.Location = new System.Drawing.Point(398, 9);
      // 
      // bytesTextbox
      // 
      this.bytesTextbox.Location = new System.Drawing.Point(441, 9);
      this.bytesTextbox.Size = new System.Drawing.Size(45, 13);
      // 
      // rankLabel
      // 
      this.rankLabel.AutoSize = true;
      this.rankLabel.Location = new System.Drawing.Point(327, 119);
      this.rankLabel.Name = "rankLabel";
      this.rankLabel.Size = new System.Drawing.Size(80, 13);
      this.rankLabel.TabIndex = 8;
      this.rankLabel.Text = "Rank unlocked";
      // 
      // rankDropdown
      // 
      this.rankDropdown.FormattingEnabled = true;
      this.rankDropdown.Location = new System.Drawing.Point(330, 135);
      this.rankDropdown.Name = "rankDropdown";
      this.rankDropdown.Size = new System.Drawing.Size(87, 21);
      this.rankDropdown.TabIndex = 7;
      // 
      // enabledCheckbox
      // 
      this.enabledCheckbox.AutoSize = true;
      this.enabledCheckbox.Location = new System.Drawing.Point(330, 85);
      this.enabledCheckbox.Name = "enabledCheckbox";
      this.enabledCheckbox.Size = new System.Drawing.Size(65, 17);
      this.enabledCheckbox.TabIndex = 6;
      this.enabledCheckbox.Text = "Enabled";
      this.enabledCheckbox.UseVisualStyleBackColor = true;
      this.enabledCheckbox.CheckedChanged += new System.EventHandler(this.enabledCheckbox_CheckedChanged);
      // 
      // EditRankRequirementDeckLeaderAbilityForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.ClientSize = new System.Drawing.Size(491, 326);
      this.Controls.Add(this.rankLabel);
      this.Controls.Add(this.rankDropdown);
      this.Controls.Add(this.enabledCheckbox);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "EditRankRequirementDeckLeaderAbilityForm";
      this.Controls.SetChildIndex(this.abilityDescriptionTextbox, 0);
      this.Controls.SetChildIndex(this.bytesLabel, 0);
      this.Controls.SetChildIndex(this.bytesTextbox, 0);
      this.Controls.SetChildIndex(this.abilityNameLabel, 0);
      this.Controls.SetChildIndex(this.cancelButton, 0);
      this.Controls.SetChildIndex(this.applyButton, 0);
      this.Controls.SetChildIndex(this.enabledCheckbox, 0);
      this.Controls.SetChildIndex(this.rankDropdown, 0);
      this.Controls.SetChildIndex(this.rankLabel, 0);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label rankLabel;
    protected System.Windows.Forms.CheckBox enabledCheckbox;
    protected System.Windows.Forms.ComboBox rankDropdown;
  }
}
