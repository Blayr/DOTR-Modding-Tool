namespace DOTR_MODDING_TOOL.Forms.DeckLeaderAbilityForms
{
  partial class EditFlagDeckLeaderAbilityForm
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
      this.flagCheckbox = new System.Windows.Forms.CheckBox();
      this.SuspendLayout();
      // 
      // cancelButton
      // 
      this.cancelButton.Location = new System.Drawing.Point(318, 143);
      // 
      // applyButton
      // 
      this.applyButton.Location = new System.Drawing.Point(399, 143);
      // 
      // abilityNameLabel
      // 
      this.abilityNameLabel.Size = new System.Drawing.Size(50, 20);
      this.abilityNameLabel.Text = "Ability";
      // 
      // abilityDescriptionTextbox
      // 
      this.abilityDescriptionTextbox.Location = new System.Drawing.Point(16, 32);
      this.abilityDescriptionTextbox.ReadOnly = true;
      // 
      // bytesLabel
      // 
      this.bytesLabel.Location = new System.Drawing.Point(402, 12);
      // 
      // bytesTextbox
      // 
      this.bytesTextbox.Location = new System.Drawing.Point(447, 12);
      this.bytesTextbox.Size = new System.Drawing.Size(44, 13);
      // 
      // flagCheckbox
      // 
      this.flagCheckbox.AutoSize = true;
      this.flagCheckbox.Location = new System.Drawing.Point(335, 78);
      this.flagCheckbox.Name = "flagCheckbox";
      this.flagCheckbox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.flagCheckbox.Size = new System.Drawing.Size(65, 17);
      this.flagCheckbox.TabIndex = 11;
      this.flagCheckbox.Text = "Enabled";
      this.flagCheckbox.UseVisualStyleBackColor = true;
      // 
      // EditFlagDeckLeaderAbilityForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.ClientSize = new System.Drawing.Size(486, 178);
      this.Controls.Add(this.flagCheckbox);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Name = "EditFlagDeckLeaderAbilityForm";
      this.Controls.SetChildIndex(this.bytesLabel, 0);
      this.Controls.SetChildIndex(this.bytesTextbox, 0);
      this.Controls.SetChildIndex(this.cancelButton, 0);
      this.Controls.SetChildIndex(this.applyButton, 0);
      this.Controls.SetChildIndex(this.abilityNameLabel, 0);
      this.Controls.SetChildIndex(this.abilityDescriptionTextbox, 0);
      this.Controls.SetChildIndex(this.flagCheckbox, 0);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    protected System.Windows.Forms.CheckBox flagCheckbox;
  }
}
