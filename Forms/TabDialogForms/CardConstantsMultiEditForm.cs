using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
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
  private Color touchedColor = Color.Lime;
  private bool deckCostTouched = false;
  private bool slotsTouched = false;
  private bool slotsRareTouched = false;
  private bool reincarnationTouched = false;
  private bool levelTouched = false;
  private bool passwordWorksTouched = false;
  private bool attackTouched = false;
  private bool defenseTouched = false;

  private NumericUpDown levelNumericUpDown;
  private NumericUpDown attackNumericUpDown;
  private NumericUpDown defenseNumericUpDown;
  private Label label4;
  private Label label5;
  private Label label3;

  public CardConstantsMultiEditForm(List<CardConstant> selectedCardConstants)
	{
    this.selectedCardConstants = selectedCardConstants;

    this.InitializeComponent();
    this.PopulateFields();
    this.SetupFormFields();
  }

  private void InitializeComponent()
  {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardConstantsMultiEditForm));
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
      this.attackNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.defenseNumericUpDown = new System.Windows.Forms.NumericUpDown();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.deckCostNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.levelNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.attackNumericUpDown)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.defenseNumericUpDown)).BeginInit();
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
      this.selectedCardList.Size = new System.Drawing.Size(183, 316);
      this.selectedCardList.TabIndex = 2;
      // 
      // applyButton
      // 
      this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.applyButton.Location = new System.Drawing.Point(394, 321);
      this.applyButton.Name = "applyButton";
      this.applyButton.Size = new System.Drawing.Size(75, 23);
      this.applyButton.TabIndex = 3;
      this.applyButton.Text = "Apply";
      this.applyButton.UseVisualStyleBackColor = true;
      this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
      // 
      // cancelButton
      // 
      this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.cancelButton.Location = new System.Drawing.Point(313, 321);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(75, 23);
      this.cancelButton.TabIndex = 4;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
      // 
      // deckCostNumericUpDown
      // 
      this.deckCostNumericUpDown.BackColor = System.Drawing.SystemColors.Window;
      this.deckCostNumericUpDown.Location = new System.Drawing.Point(278, 116);
      this.deckCostNumericUpDown.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
      this.deckCostNumericUpDown.Name = "deckCostNumericUpDown";
      this.deckCostNumericUpDown.Size = new System.Drawing.Size(57, 20);
      this.deckCostNumericUpDown.TabIndex = 5;
      // 
      // slotsCheckbox
      // 
      this.slotsCheckbox.AutoSize = true;
      this.slotsCheckbox.BackColor = System.Drawing.SystemColors.Control;
      this.slotsCheckbox.Location = new System.Drawing.Point(357, 49);
      this.slotsCheckbox.Name = "slotsCheckbox";
      this.slotsCheckbox.Size = new System.Drawing.Size(49, 17);
      this.slotsCheckbox.TabIndex = 6;
      this.slotsCheckbox.Text = "Slots";
      this.slotsCheckbox.UseVisualStyleBackColor = false;
      // 
      // slotRaresCheckbox
      // 
      this.slotRaresCheckbox.AutoSize = true;
      this.slotRaresCheckbox.Location = new System.Drawing.Point(357, 73);
      this.slotRaresCheckbox.Name = "slotRaresCheckbox";
      this.slotRaresCheckbox.Size = new System.Drawing.Size(75, 17);
      this.slotRaresCheckbox.TabIndex = 7;
      this.slotRaresCheckbox.Text = "Slots Rare";
      this.slotRaresCheckbox.UseVisualStyleBackColor = true;
      // 
      // reincarnationCheckbox
      // 
      this.reincarnationCheckbox.AutoSize = true;
      this.reincarnationCheckbox.Location = new System.Drawing.Point(357, 97);
      this.reincarnationCheckbox.Name = "reincarnationCheckbox";
      this.reincarnationCheckbox.Size = new System.Drawing.Size(92, 17);
      this.reincarnationCheckbox.TabIndex = 8;
      this.reincarnationCheckbox.Text = "Reincarnation";
      this.reincarnationCheckbox.UseVisualStyleBackColor = true;
      // 
      // passwordWorksCheckbox
      // 
      this.passwordWorksCheckbox.AutoSize = true;
      this.passwordWorksCheckbox.Location = new System.Drawing.Point(357, 121);
      this.passwordWorksCheckbox.Name = "passwordWorksCheckbox";
      this.passwordWorksCheckbox.Size = new System.Drawing.Size(106, 17);
      this.passwordWorksCheckbox.TabIndex = 9;
      this.passwordWorksCheckbox.Text = "Password Works";
      this.passwordWorksCheckbox.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(354, 30);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(82, 13);
      this.label1.TabIndex = 10;
      this.label1.Text = "Card Attainment";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(209, 118);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(57, 13);
      this.label2.TabIndex = 11;
      this.label2.Text = "Deck Cost";
      // 
      // levelNumericUpDown
      // 
      this.levelNumericUpDown.Location = new System.Drawing.Point(278, 87);
      this.levelNumericUpDown.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
      this.levelNumericUpDown.Name = "levelNumericUpDown";
      this.levelNumericUpDown.Size = new System.Drawing.Size(40, 20);
      this.levelNumericUpDown.TabIndex = 12;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(239, 89);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(33, 13);
      this.label3.TabIndex = 14;
      this.label3.Text = "Level";
      // 
      // attackNumericUpDown
      // 
      this.attackNumericUpDown.BackColor = System.Drawing.SystemColors.Window;
      this.attackNumericUpDown.Location = new System.Drawing.Point(278, 28);
      this.attackNumericUpDown.Maximum = new decimal(new int[] {
            8192,
            0,
            0,
            0});
      this.attackNumericUpDown.Name = "attackNumericUpDown";
      this.attackNumericUpDown.Size = new System.Drawing.Size(57, 20);
      this.attackNumericUpDown.TabIndex = 15;
      this.attackNumericUpDown.ValueChanged += new System.EventHandler(this.attackNumericUpDown_ValueChanged);
      // 
      // defenseNumericUpDown
      // 
      this.defenseNumericUpDown.BackColor = System.Drawing.SystemColors.Window;
      this.defenseNumericUpDown.Location = new System.Drawing.Point(278, 56);
      this.defenseNumericUpDown.Maximum = new decimal(new int[] {
            8192,
            0,
            0,
            0});
      this.defenseNumericUpDown.Name = "defenseNumericUpDown";
      this.defenseNumericUpDown.Size = new System.Drawing.Size(57, 20);
      this.defenseNumericUpDown.TabIndex = 16;
      this.defenseNumericUpDown.ValueChanged += new System.EventHandler(this.DefenseNumericUpDown_ValueChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(234, 32);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(38, 13);
      this.label4.TabIndex = 17;
      this.label4.Text = "Attack";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(220, 58);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(47, 13);
      this.label5.TabIndex = 18;
      this.label5.Text = "Defense";
      // 
      // CardConstantsMultiEditForm
      // 
      this.ClientSize = new System.Drawing.Size(481, 349);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.defenseNumericUpDown);
      this.Controls.Add(this.attackNumericUpDown);
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
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "CardConstantsMultiEditForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Card property editor";
      ((System.ComponentModel.ISupportInitialize)(this.deckCostNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.levelNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.attackNumericUpDown)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.defenseNumericUpDown)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

  }

  private void SetupFormFields()
  {
    this.numberOfCardsSelectedLabel.Text = this.selectedCardConstants.Count.ToString() + " cards selected.";
    this.selectedCardConstants.ForEach((cc) => this.selectedCardList.Items.Add(cc.Name));

    this.deckCostNumericUpDown.KeyDown += this.OnControlKeyPress;
    this.levelNumericUpDown.KeyDown += this.OnControlKeyPress;
    this.attackNumericUpDown.KeyDown += this.OnControlKeyPress;
    this.defenseNumericUpDown.KeyDown += this.OnControlKeyPress;
    this.deckCostNumericUpDown.ValueChanged += new System.EventHandler(this.deckCostNumericUpDown_ValueChanged);
    this.levelNumericUpDown.ValueChanged += new System.EventHandler(this.rankNumericUpDown_ValueChanged);
    this.passwordWorksCheckbox.CheckedChanged += new System.EventHandler(this.passwordWorksCheckbox_CheckedChanged);
    this.reincarnationCheckbox.CheckedChanged += new System.EventHandler(this.reincarnationCheckbox_CheckedChanged);
    this.slotRaresCheckbox.CheckedChanged += new System.EventHandler(this.slotRaresCheckbox_CheckedChanged);
    this.slotsCheckbox.CheckedChanged += new System.EventHandler(this.slotsCheckbox_CheckedChanged);
  }

  private void OnControlKeyPress(Object sender, EventArgs e)
  {
    Control field = (Control)sender;
    field.BackColor = this.touchedColor;
  }

  private void PopulateFields()
  {
    CardConstant firstCard = this.selectedCardConstants.First();

    bool attackChanged = false;
    bool defenseChanged = false;
    bool deckCostChanged = false;
    bool levelChanged = false;
    bool appearsInSlotReelsChanged = false;
    bool isSlotRareChanged = false;
    bool appearsInReincarnationChanged = false;
    bool passwordWorksChanged = false;

    foreach (CardConstant constant in this.selectedCardConstants)
    {
      if (!attackChanged && (constant.Attack != firstCard.Attack)) { attackChanged = true; }

      if (!defenseTouched && (constant.Defense != firstCard.Defense)) { defenseChanged = true; }

      if (!deckCostChanged && (constant.DeckCost != firstCard.DeckCost)) { deckCostChanged = true; }

      if (!levelChanged && (constant.Level != firstCard.Level)) { levelChanged = true; }

      if (!appearsInSlotReelsChanged && (constant.AppearsInSlotReels != firstCard.AppearsInSlotReels)) { appearsInSlotReelsChanged = true; }

      if (!isSlotRareChanged && (constant.IsSlotRare != firstCard.IsSlotRare)) { appearsInSlotReelsChanged = true; }

      if (!appearsInReincarnationChanged && (constant.AppearsInReincarnation != firstCard.AppearsInReincarnation)) { appearsInReincarnationChanged = true; }
      
      if (!passwordWorksChanged && (constant.PasswordWorks != firstCard.PasswordWorks)) { passwordWorksChanged = true; }
    }

    if (attackChanged)
    {
      this.attackNumericUpDown.Text = "";
    } else
    {
      this.attackNumericUpDown.Value = firstCard.Attack;
    }

    if (defenseChanged)
    {
      this.defenseNumericUpDown.Text = "";
    } else
    {
      this.defenseNumericUpDown.Value = firstCard.Defense;
    }

    if (deckCostChanged)
    {
      this.deckCostNumericUpDown.Text = "";
    } else
    {
      this.deckCostNumericUpDown.Value = firstCard.DeckCost;
    }

    if (levelChanged)
    {
      this.levelNumericUpDown.Text = "";
    } else
    {
      this.levelNumericUpDown.Value = firstCard.Level;
    }

    this.slotsCheckbox.Checked = appearsInSlotReelsChanged ? false : firstCard.AppearsInSlotReels;
    this.slotRaresCheckbox.Checked = isSlotRareChanged ? false : firstCard.IsSlotRare;
    this.reincarnationCheckbox.Checked = appearsInReincarnationChanged ? false : firstCard.AppearsInReincarnation;
    this.passwordWorksCheckbox.Checked = passwordWorksChanged ? false : firstCard.PasswordWorks;
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
      CardConstant cardConstant = CardConstant.List[cardIndex];
      this.applyCardChanges(ref cardConstant);
    }

    this.Close();
  }

  private void applyCardChanges(ref CardConstant cardConstant)
  {
    if (this.attackTouched)
    {
      cardConstant.Attack = (ushort)this.attackNumericUpDown.Value;
    }

    if (this.defenseTouched)
    {
      cardConstant.Defense = (ushort)this.defenseNumericUpDown.Value;
    }

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
      cardConstant.Level = (byte)this.levelNumericUpDown.Value;
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

  private void attackNumericUpDown_ValueChanged(object sender, EventArgs e)
  {
    this.attackTouched = true;
  }

  private void DefenseNumericUpDown_ValueChanged(object sender, EventArgs e)
  {
    this.defenseTouched = true;
  }
}
