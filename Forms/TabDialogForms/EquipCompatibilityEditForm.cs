using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

public class EquipCompatibilityEditForm : Form
{
  private List<MonsterCardEquipCompability> selectedMonsterCardEquipCompatibilities;
  private MonsterCardEquipCompatibilities allMonsterCardEquipCompatibilities;
  private ListBox selectedCardList;
  private Label numberOfCardsSelectedLabel;
  private bool[] enabledFlagsInCommon;
  private Button EquipCompatibilityEditFormApplyButton;
  private Button EquipCompatibilityEditFormCancelButton;
  private RichTextBox richTextBox1;
  private Object[][] checkBoxFlagList;

  public EquipCompatibilityEditForm(List<MonsterCardEquipCompability> selectedMonsterCardEquipCompatibilities, ref MonsterCardEquipCompatibilities allMonsterCardEquipCompatibilities)
  {
    this.allMonsterCardEquipCompatibilities = allMonsterCardEquipCompatibilities;
    this.selectedMonsterCardEquipCompatibilities = selectedMonsterCardEquipCompatibilities;
    // checkBoxFlagList 2nd dimension is 2 in size, index 0 is Checkbox, index 1 is boolean to track if checkbox was clicked at least once
    this.checkBoxFlagList = new Object[allMonsterCardEquipCompatibilities.List[0].CardEquipCompabilityFlags.Count][];

    this.InitializeComponent();
    this.setFlagsInCommon();
    this.SetupFormFields();
    this.SetupCheckboxes();
  }

  private void SetupFormFields()
  {
    this.numberOfCardsSelectedLabel.Text = this.selectedMonsterCardEquipCompatibilities.Count.ToString() + " cards selected.";
    this.selectedMonsterCardEquipCompatibilities.ForEach((cdla) => this.selectedCardList.Items.Add(cdla.Name));
  }

  private void setFlagsInCommon() {
    this.enabledFlagsInCommon = new bool[this.allMonsterCardEquipCompatibilities.List[0].CardEquipCompabilityFlags.Count];

    for (int f = 0; f < this.enabledFlagsInCommon.Length; f++)
    {
      bool currentFlagIsTrue = true;

      for (int c = 0; c < this.selectedMonsterCardEquipCompatibilities.Count; c++)
      {
        bool currentCardFlagValue = this.selectedMonsterCardEquipCompatibilities[c].CardEquipCompabilityFlags[f].Enabled;

        if (!currentCardFlagValue)
        {
          currentFlagIsTrue = false;
          break;
        }
      }

      enabledFlagsInCommon[f] = currentFlagIsTrue;
    }
  }

  private void SetupCheckboxes()
  {
    MonsterCardEquipCompability equipCompability = this.selectedMonsterCardEquipCompatibilities[0];

    int startX = 240;
    int startY = 40;
    int rowSpacing = 20;
    int columnSpacing = 200;
    int rowsPerColumn = 20;

    for (int i = 0; i < equipCompability.CardEquipCompabilityFlags.Count; i++)
    {
      CardEquipCompabilityFlag flag = equipCompability.CardEquipCompabilityFlags[i];
      CheckBox flagCheckbox = new CheckBox();

      int rowNumber = i % rowsPerColumn;
      int columnNumber = i / rowsPerColumn;

      int x = startX + (columnNumber * columnSpacing);
      int y = startY + (rowNumber * rowSpacing);

      flagCheckbox.Location = new System.Drawing.Point(x, y);
      flagCheckbox.Name = i.ToString();
      flagCheckbox.AutoSize = true;
      flagCheckbox.Text = flag.Name;

      // Insect Imitation and MetalMorph
      if (flag.Index == 47 || flag.Index == 48)
      {
        flagCheckbox.Text += " (Non functional)***";
      }

      flagCheckbox.UseVisualStyleBackColor = true;
      flagCheckbox.Checked = this.enabledFlagsInCommon[i];
      flagCheckbox.Click += this.onCheckboxClick;
      
      if (enabledFlagsInCommon[i])
      {
        flagCheckbox.BackColor = Color.LightGreen;
      }

      this.Controls.Add(flagCheckbox);
      this.checkBoxFlagList[i] = new Object[] { flagCheckbox, false };
    }
  }

  private void onCheckboxClick(object sender, System.EventArgs e)
  {
    CheckBox checkbox = (CheckBox) sender;
    checkbox.BackColor = Color.Yellow;
    int index = int.Parse(checkbox.Name);
    this.checkBoxFlagList[index][1] = true;
  }

  private void EquipCompatibilityEditFormCancelButton_Click(object sender, EventArgs e)
  {
    this.Close();
  }

  private void EquipCompatibilityEditFormApplyButton_Click(object sender, EventArgs e)
  {
    for (int cbfi = 0; cbfi < checkBoxFlagList.Length; cbfi++)
    {
      Object[] checkBoxFlags = checkBoxFlagList[cbfi];
      bool flagWasTouched = (bool)checkBoxFlags[1];
      CheckBox checkbox = (CheckBox)checkBoxFlags[0];

      if (!flagWasTouched)
      {
        continue;
      }

      for (int mci = 0; mci < selectedMonsterCardEquipCompatibilities.Count; mci++)
      {
        MonsterCardEquipCompability selectedMonsterEquipCompatibility = selectedMonsterCardEquipCompatibilities[mci];
        MonsterCardEquipCompability monsterCardEquipCompatibilityReference = allMonsterCardEquipCompatibilities.List[selectedMonsterEquipCompatibility.Index];
        CardEquipCompabilityFlag cardEquipCompatibilityFlag = monsterCardEquipCompatibilityReference.CardEquipCompabilityFlags[cbfi];
        cardEquipCompatibilityFlag.Enabled = checkbox.Checked;
      }
    }

    this.Close();
  }

  private void InitializeComponent()
  {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquipCompatibilityEditForm));
      this.selectedCardList = new System.Windows.Forms.ListBox();
      this.numberOfCardsSelectedLabel = new System.Windows.Forms.Label();
      this.EquipCompatibilityEditFormApplyButton = new System.Windows.Forms.Button();
      this.EquipCompatibilityEditFormCancelButton = new System.Windows.Forms.Button();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.SuspendLayout();
      // 
      // selectedCardList
      // 
      this.selectedCardList.FormattingEnabled = true;
      this.selectedCardList.Location = new System.Drawing.Point(12, 31);
      this.selectedCardList.Name = "selectedCardList";
      this.selectedCardList.SelectionMode = System.Windows.Forms.SelectionMode.None;
      this.selectedCardList.Size = new System.Drawing.Size(183, 316);
      this.selectedCardList.TabIndex = 4;
      // 
      // numberOfCardsSelectedLabel
      // 
      this.numberOfCardsSelectedLabel.AutoSize = true;
      this.numberOfCardsSelectedLabel.Location = new System.Drawing.Point(12, 12);
      this.numberOfCardsSelectedLabel.Name = "numberOfCardsSelectedLabel";
      this.numberOfCardsSelectedLabel.Size = new System.Drawing.Size(115, 13);
      this.numberOfCardsSelectedLabel.TabIndex = 3;
      this.numberOfCardsSelectedLabel.Text = "(Card count goes here)";
      // 
      // EquipCompatibilityEditFormApplyButton
      // 
      this.EquipCompatibilityEditFormApplyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.EquipCompatibilityEditFormApplyButton.Location = new System.Drawing.Point(776, 436);
      this.EquipCompatibilityEditFormApplyButton.Name = "EquipCompatibilityEditFormApplyButton";
      this.EquipCompatibilityEditFormApplyButton.Size = new System.Drawing.Size(75, 23);
      this.EquipCompatibilityEditFormApplyButton.TabIndex = 5;
      this.EquipCompatibilityEditFormApplyButton.Text = "Apply";
      this.EquipCompatibilityEditFormApplyButton.UseVisualStyleBackColor = true;
      this.EquipCompatibilityEditFormApplyButton.Click += new System.EventHandler(this.EquipCompatibilityEditFormApplyButton_Click);
      // 
      // EquipCompatibilityEditFormCancelButton
      // 
      this.EquipCompatibilityEditFormCancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.EquipCompatibilityEditFormCancelButton.Location = new System.Drawing.Point(695, 436);
      this.EquipCompatibilityEditFormCancelButton.Name = "EquipCompatibilityEditFormCancelButton";
      this.EquipCompatibilityEditFormCancelButton.Size = new System.Drawing.Size(75, 23);
      this.EquipCompatibilityEditFormCancelButton.TabIndex = 6;
      this.EquipCompatibilityEditFormCancelButton.Text = "Cancel";
      this.EquipCompatibilityEditFormCancelButton.UseVisualStyleBackColor = true;
      this.EquipCompatibilityEditFormCancelButton.Click += new System.EventHandler(this.EquipCompatibilityEditFormCancelButton_Click);
      // 
      // richTextBox1
      // 
      this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
      this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.richTextBox1.Location = new System.Drawing.Point(642, 379);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.ReadOnly = true;
      this.richTextBox1.Size = new System.Drawing.Size(209, 39);
      this.richTextBox1.TabIndex = 8;
      this.richTextBox1.Text = "*** Metalmorph and Insect Imitation flags only affect what appears on the \"Power " +
    "Up\" section of a card.";
      // 
      // EquipCompatibilityEditForm
      // 
      this.ClientSize = new System.Drawing.Size(863, 471);
      this.Controls.Add(this.richTextBox1);
      this.Controls.Add(this.EquipCompatibilityEditFormCancelButton);
      this.Controls.Add(this.EquipCompatibilityEditFormApplyButton);
      this.Controls.Add(this.selectedCardList);
      this.Controls.Add(this.numberOfCardsSelectedLabel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "EquipCompatibilityEditForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Monster equip card compatibility editor";
      this.ResumeLayout(false);
      this.PerformLayout();

  }
}
