namespace DOTR_MODDING_TOOL.Forms.DeckLeaderAbilityForms
{
  partial class EditDeckLeaderAbilityForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDeckLeaderAbilityForm));
      this.cancelButton = new System.Windows.Forms.Button();
      this.applyButton = new System.Windows.Forms.Button();
      this.abilityNameLabel = new System.Windows.Forms.Label();
      this.abilityDescriptionTextbox = new System.Windows.Forms.RichTextBox();
      this.bytesLabel = new System.Windows.Forms.Label();
      this.bytesTextbox = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // cancelButton
      // 
      this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.cancelButton.Location = new System.Drawing.Point(632, 415);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(75, 23);
      this.cancelButton.TabIndex = 0;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
      // 
      // applyButton
      // 
      this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.applyButton.Location = new System.Drawing.Point(713, 415);
      this.applyButton.Name = "applyButton";
      this.applyButton.Size = new System.Drawing.Size(75, 23);
      this.applyButton.TabIndex = 1;
      this.applyButton.Text = "Apply";
      this.applyButton.UseVisualStyleBackColor = true;
      this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
      // 
      // abilityNameLabel
      // 
      this.abilityNameLabel.AutoSize = true;
      this.abilityNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.abilityNameLabel.Location = new System.Drawing.Point(12, 9);
      this.abilityNameLabel.Name = "abilityNameLabel";
      this.abilityNameLabel.Size = new System.Drawing.Size(54, 20);
      this.abilityNameLabel.TabIndex = 10;
      this.abilityNameLabel.Text = "Ability:";
      // 
      // abilityDescriptionTextbox
      // 
      this.abilityDescriptionTextbox.BackColor = System.Drawing.SystemColors.Control;
      this.abilityDescriptionTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.abilityDescriptionTextbox.Location = new System.Drawing.Point(12, 32);
      this.abilityDescriptionTextbox.Name = "abilityDescriptionTextbox";
      this.abilityDescriptionTextbox.Size = new System.Drawing.Size(250, 89);
      this.abilityDescriptionTextbox.TabIndex = 13;
      this.abilityDescriptionTextbox.Text = "Description";
      // 
      // bytesLabel
      // 
      this.bytesLabel.AutoSize = true;
      this.bytesLabel.Location = new System.Drawing.Point(13, 124);
      this.bytesLabel.Name = "bytesLabel";
      this.bytesLabel.Size = new System.Drawing.Size(39, 13);
      this.bytesLabel.TabIndex = 15;
      this.bytesLabel.Text = "Bytes: ";
      // 
      // bytesTextbox
      // 
      this.bytesTextbox.BackColor = System.Drawing.SystemColors.Control;
      this.bytesTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.bytesTextbox.Location = new System.Drawing.Point(58, 124);
      this.bytesTextbox.Name = "bytesTextbox";
      this.bytesTextbox.Size = new System.Drawing.Size(101, 13);
      this.bytesTextbox.TabIndex = 16;
      // 
      // EditDeckLeaderAbilityForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.bytesTextbox);
      this.Controls.Add(this.bytesLabel);
      this.Controls.Add(this.abilityDescriptionTextbox);
      this.Controls.Add(this.abilityNameLabel);
      this.Controls.Add(this.applyButton);
      this.Controls.Add(this.cancelButton);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "EditDeckLeaderAbilityForm";
      this.Text = "Deck leader ability editor";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    protected System.Windows.Forms.Button cancelButton;
    protected System.Windows.Forms.Button applyButton;
    protected System.Windows.Forms.Label abilityNameLabel;
    protected System.Windows.Forms.RichTextBox abilityDescriptionTextbox;
    protected System.Windows.Forms.Label bytesLabel;
    protected System.Windows.Forms.TextBox bytesTextbox;
  }
}