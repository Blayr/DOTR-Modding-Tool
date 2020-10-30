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
  private Object[][] checkBoxFlagList = new Object[DataAccess.MonsterEquipCardCompabilityCardCount][];
  // checkBoxFlagList 2nd dimension is 2 in size, index 0 is Checkbox, index 1 is boolean to track if checkbox was clicked at least once

  public EquipCompatibilityEditForm(List<MonsterCardEquipCompability> selectedMonsterCardEquipCompatibilities, ref MonsterCardEquipCompatibilities allMonsterCardEquipCompatibilities)
  {
    this.allMonsterCardEquipCompatibilities = allMonsterCardEquipCompatibilities;
    this.selectedMonsterCardEquipCompatibilities = selectedMonsterCardEquipCompatibilities;

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
      flagCheckbox.Text = $"{flag.Name}";
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

  private void InitializeComponent()
  {
      this.selectedCardList = new System.Windows.Forms.ListBox();
      this.numberOfCardsSelectedLabel = new System.Windows.Forms.Label();
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
      // EquipCompatibilityEditForm
      // 
      this.ClientSize = new System.Drawing.Size(863, 471);
      this.Controls.Add(this.selectedCardList);
      this.Controls.Add(this.numberOfCardsSelectedLabel);
      this.Name = "EquipCompatibilityEditForm";
      this.ResumeLayout(false);
      this.PerformLayout();

  }
}
