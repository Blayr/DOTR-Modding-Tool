    using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class CardConstantsMultiEditForm : Form
{
  private Label numberOfCardsSelectedLabel;
  private ListBox selectedCardList;
  private Button applyButton;
  private Button cancelButton;
  private List<CardConstant> selectedCardConstants;
  private NumericUpDown deckCostNumericUpDown;
  private CheckBox slotsCheckbox;
  private CheckBox slotRaresCheckbox;
  private CheckBox reincarnationCheckbox;
  private CheckBox passwordWorksCheckbox;
  private Label label1;
  private Label label2;
  private CardConstants cardConstants;
  private Color touchedColor = Color.Lime;
  private bool deckCostTouched = false;
  private bool slotsTouched = false;
  private bool slotsRareTouched = false;
  private bool reincarnationTouched = false;
  private bool levelTouched = false;
  
    private NumericUpDown levelNumericUpDown;
    private Label label3;
    private bool passwordWorksTouched = false;

  public CardConstantsMultiEditForm(List<CardConstant> selectedCardConstants, ref CardConstants allCardConstants)
	{
    this.selectedCardConstants = selectedCardConstants;
    this.cardConstants = allCardConstants;
    this.InitializeComponent();
    this.numberOfCardsSelectedLabel.Text = this.selectedCardConstants.Count.ToString() + " cards selected.";
    this.selectedCardConstants.ForEach((cc) => this.selectedCardList.Items.Add(cc.Name));
  }

  private void InitializeComponent()
  {
      this.numberOfCardsSelectedLabel = new System.Windows.Forms.Label();
      this.selectedCardList = new System.Windows.Forms.ListBox();
      this.applyButton = new System.Windows.Forms.Button();
      this.cancelButton = new System.Windows.Forms.Button();
      this.deckCostNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.slotsCheckbox = new System.Windows.Forms.CheckBox();
      this.slotRaresCheckbox = new System.Windows.Forms.CheckBox();
      this.reincarnationCheckbox = new System.Windows.Forms.CheckBox();
      this.passwordWorksCheckbox = new System.Windows.Forms.CheckBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.levelNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label3 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.deckCostNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.levelNumericUpDown)).BeginInit();
      this.SuspendLayout();
      // 
      // numberOfCardsSelectedLabel
      // 
      this.numberOfCardsSelectedLabel.AutoSize = true;
      this.numberOfCardsSelectedLabel.Location = new System.Drawing.Point(12, 9);
      this.numberOfCardsSelectedLabel.Name = "numberOfCardsSelectedLabel";
      this.numberOfCardsSelectedLabel.Size = new System.Drawing.Size(115, 13);
      this.numberOfCardsSelectedLabel.TabIndex = 0;
      this.numberOfCardsSelectedLabel.Text = "(Card count goes here)";
      // 
      // selectedCardList
      // 
      this.selectedCardList.FormattingEnabled = true;
      this.selectedCardList.Location = new System.Drawing.Point(12, 28);
      this.selectedCardList.Name = "selectedCardList";
      this.selectedCardList.SelectionMode = System.Windows.Forms.SelectionMode.None;
      this.selectedCardList.Size = new System.Drawing.Size(183, 329);
      this.selectedCardList.TabIndex = 2;
      // 
      // applyButton
      // 
      this.applyButton.Location = new System.Drawing.Point(485, 318);
      this.applyButton.Name = "applyButton";
      this.applyButton.Size = new System.Drawing.Size(75, 23);
      this.applyButton.TabIndex = 3;
      this.applyButton.Text = "Apply";
      this.applyButton.UseVisualStyleBackColor = true;
      this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
      // 
      // cancelButton
      // 
      this.cancelButton.Location = new System.Drawing.Point(404, 318);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(75, 23);
      this.cancelButton.TabIndex = 4;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
      // 
      // deckCostNumericUpDown
      // 
      this.deckCostNumericUpDown.BackColor = System.Drawing.SystemColors.Control;
      this.deckCostNumericUpDown.Location = new System.Drawing.Point(276, 43);
      this.deckCostNumericUpDown.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
      this.deckCostNumericUpDown.Name = "deckCostNumericUpDown";
      this.deckCostNumericUpDown.Size = new System.Drawing.Size(57, 20);
      this.deckCostNumericUpDown.TabIndex = 5;
      this.deckCostNumericUpDown.ValueChanged += new System.EventHandler(this.deckCostNumericUpDown_ValueChanged);
      // 
      // slotsCheckbox
      // 
      this.slotsCheckbox.AutoSize = true;
      this.slotsCheckbox.BackColor = System.Drawing.SystemColors.Control;
      this.slotsCheckbox.Location = new System.Drawing.Point(441, 64);
      this.slotsCheckbox.Name = "slotsCheckbox";
      this.slotsCheckbox.Size = new System.Drawing.Size(49, 17);
      this.slotsCheckbox.TabIndex = 6;
      this.slotsCheckbox.Text = "Slots";
      this.slotsCheckbox.UseVisualStyleBackColor = false;
      this.slotsCheckbox.CheckedChanged += new System.EventHandler(this.slotsCheckbox_CheckedChanged);
      // 
      // slotRaresCheckbox
      // 
      this.slotRaresCheckbox.AutoSize = true;
      this.slotRaresCheckbox.Location = new System.Drawing.Point(441, 88);
      this.slotRaresCheckbox.Name = "slotRaresCheckbox";
      this.slotRaresCheckbox.Size = new System.Drawing.Size(75, 17);
      this.slotRaresCheckbox.TabIndex = 7;
      this.slotRaresCheckbox.Text = "Slots Rare";
      this.slotRaresCheckbox.UseVisualStyleBackColor = true;
      this.slotRaresCheckbox.CheckedChanged += new System.EventHandler(this.slotRaresCheckbox_CheckedChanged);
      // 
      // reincarnationCheckbox
      // 
      this.reincarnationCheckbox.AutoSize = true;
      this.reincarnationCheckbox.Location = new System.Drawing.Point(441, 112);
      this.reincarnationCheckbox.Name = "reincarnationCheckbox";
      this.reincarnationCheckbox.Size = new System.Drawing.Size(92, 17);
      this.reincarnationCheckbox.TabIndex = 8;
      this.reincarnationCheckbox.Text = "Reincarnation";
      this.reincarnationCheckbox.UseVisualStyleBackColor = true;
      this.reincarnationCheckbox.CheckedChanged += new System.EventHandler(this.reincarnationCheckbox_CheckedChanged);
      // 
      // passwordWorksCheckbox
      // 
      this.passwordWorksCheckbox.AutoSize = true;
      this.passwordWorksCheckbox.Location = new System.Drawing.Point(441, 136);
      this.passwordWorksCheckbox.Name = "passwordWorksCheckbox";
      this.passwordWorksCheckbox.Size = new System.Drawing.Size(106, 17);
      this.passwordWorksCheckbox.TabIndex = 9;
      this.passwordWorksCheckbox.Text = "Password Works";
      this.passwordWorksCheckbox.UseVisualStyleBackColor = true;
      this.passwordWorksCheckbox.CheckedChanged += new System.EventHandler(this.passwordWorksCheckbox_CheckedChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(438, 45);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(82, 13);
      this.label1.TabIndex = 10;
      this.label1.Text = "Card Attainment";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(213, 45);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(57, 13);
      this.label2.TabIndex = 11;
      this.label2.Text = "Deck Cost";
      // 
      // levelNumericUpDown
      // 
      this.levelNumericUpDown.Location = new System.Drawing.Point(276, 88);
      this.levelNumericUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
      this.levelNumericUpDown.Name = "levelNumericUpDown";
      this.levelNumericUpDown.Size = new System.Drawing.Size(57, 20);
      this.levelNumericUpDown.TabIndex = 12;
      this.levelNumericUpDown.ValueChanged += new System.EventHandler(this.rankNumericUpDown_ValueChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(216, 88);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(33, 13);
      this.label3.TabIndex = 14;
      this.label3.Text = "Level";
      // 
      // CardConstantsMultiEditForm
      // 
      this.ClientSize = new System.Drawing.Size(582, 369);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.levelNumericUpDown);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.passwordWorksCheckbox);
      this.Controls.Add(this.reincarnationCheckbox);
      this.Controls.Add(this.slotRaresCheckbox);
      this.Controls.Add(this.slotsCheckbox);
      this.Controls.Add(this.deckCostNumericUpDown);
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.applyButton);
      this.Controls.Add(this.selectedCardList);
      this.Controls.Add(this.numberOfCardsSelectedLabel);
      this.Name = "CardConstantsMultiEditForm";
      ((System.ComponentModel.ISupportInitialize)(this.deckCostNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.levelNumericUpDown)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

  }

  private void cancelButton_Click(object sender, EventArgs e)
  {
    this.Close();
  }

  private void applyButton_Click(object sender, EventArgs e)
  {
    for (int i = 0; i < this.selectedCardConstants.Count; i++)
    {
      int cardIndex = this.selectedCardConstants[i].Index;
      CardConstant cardConstant = this.cardConstants.Constants[cardIndex];
      this.applyCardChanges(ref cardConstant);
    }

    this.Close();
  }

  private void applyCardChanges(ref CardConstant cardConstant)
  {
    if (this.deckCostTouched)
    {
      cardConstant.DeckCost = (byte)this.deckCostNumericUpDown.Value;
    }

    if (this.slotsTouched)
    {
      cardConstant.AppearsInSlotReels = this.slotsCheckbox.Checked;
    }

    if (this.slotsRareTouched)
    {
      cardConstant.IsSlotRare = this.slotRaresCheckbox.Checked;
    }

    if (this.reincarnationTouched)
    {
      cardConstant.AppearsInReincarnation = this.reincarnationCheckbox.Checked;
    }

    if (this.passwordWorksTouched)
    {
      cardConstant.PasswordWorks = this.passwordWorksCheckbox.Checked;
    }

    if (this.levelTouched)
    {
      cardConstant.Level = this.levelNumericUpDown.Value;
    }
  }

  private void slotsCheckbox_CheckedChanged(object sender, EventArgs e)
  {
    this.slotsTouched = true;
    this.slotsCheckbox.BackColor = this.touchedColor;
  }

  private void slotRaresCheckbox_CheckedChanged(object sender, EventArgs e)
  {
    this.slotsRareTouched = true;
    this.slotRaresCheckbox.BackColor = this.touchedColor;
  }

  private void reincarnationCheckbox_CheckedChanged(object sender, EventArgs e)
  {
    this.reincarnationTouched = true;
    this.reincarnationCheckbox.BackColor = this.touchedColor;
  }

  private void passwordWorksCheckbox_CheckedChanged(object sender, EventArgs e)
  {
    this.passwordWorksTouched= true;
    this.passwordWorksCheckbox.BackColor = this.touchedColor;
  }

  private void deckCostNumericUpDown_ValueChanged(object sender, EventArgs e)
  {
    this.deckCostTouched = true;
    this.deckCostNumericUpDown.BackColor = this.touchedColor;
  }

  private void rankNumericUpDown_ValueChanged(object sender, EventArgs e)
  {
    this.levelTouched = true;
    this.levelNumericUpDown.BackColor = this.touchedColor;
  }
}
