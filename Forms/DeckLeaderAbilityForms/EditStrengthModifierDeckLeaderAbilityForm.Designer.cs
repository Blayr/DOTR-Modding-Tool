namespace DOTR_MODDING_TOOL.Forms.DeckLeaderAbilityForms
{
  partial class EditStrengthModifierDeckLeaderAbilityForm
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
      this.strengthModifierNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.strengthModifierLabel = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.strengthModifierNumericUpDown)).BeginInit();
      this.SuspendLayout();
      // 
      // cancelButton
      // 
      this.cancelButton.Location = new System.Drawing.Point(319, 288);
      // 
      // applyButton
      // 
      this.applyButton.Location = new System.Drawing.Point(400, 288);
      // 
      // bytesLabel
      // 
      this.bytesLabel.Location = new System.Drawing.Point(349, 9);
      // 
      // bytesTextbox
      // 
      this.bytesTextbox.Location = new System.Drawing.Point(394, 9);
      this.bytesTextbox.Size = new System.Drawing.Size(43, 13);
      // 
      // strengthModifierNumericUpDown
      // 
      this.strengthModifierNumericUpDown.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
      this.strengthModifierNumericUpDown.Location = new System.Drawing.Point(330, 186);
      this.strengthModifierNumericUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
      this.strengthModifierNumericUpDown.Name = "strengthModifierNumericUpDown";
      this.strengthModifierNumericUpDown.Size = new System.Drawing.Size(87, 20);
      this.strengthModifierNumericUpDown.TabIndex = 17;
      // 
      // strengthModifierLabel
      // 
      this.strengthModifierLabel.AutoSize = true;
      this.strengthModifierLabel.Location = new System.Drawing.Point(327, 170);
      this.strengthModifierLabel.Name = "strengthModifierLabel";
      this.strengthModifierLabel.Size = new System.Drawing.Size(44, 13);
      this.strengthModifierLabel.TabIndex = 18;
      this.strengthModifierLabel.Text = "Modifier";
      // 
      // EditStrengthModifierDeckLeaderAbilityForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.ClientSize = new System.Drawing.Size(487, 323);
      this.Controls.Add(this.strengthModifierLabel);
      this.Controls.Add(this.strengthModifierNumericUpDown);
      this.Name = "EditStrengthModifierDeckLeaderAbilityForm";
      this.Controls.SetChildIndex(this.enabledCheckbox, 0);
      this.Controls.SetChildIndex(this.abilityDescriptionTextbox, 0);
      this.Controls.SetChildIndex(this.bytesLabel, 0);
      this.Controls.SetChildIndex(this.bytesTextbox, 0);
      this.Controls.SetChildIndex(this.abilityNameLabel, 0);
      this.Controls.SetChildIndex(this.cancelButton, 0);
      this.Controls.SetChildIndex(this.applyButton, 0);
      this.Controls.SetChildIndex(this.strengthModifierNumericUpDown, 0);
      this.Controls.SetChildIndex(this.strengthModifierLabel, 0);
      ((System.ComponentModel.ISupportInitialize)(this.strengthModifierNumericUpDown)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.NumericUpDown strengthModifierNumericUpDown;
    private System.Windows.Forms.Label strengthModifierLabel;
  }
}
