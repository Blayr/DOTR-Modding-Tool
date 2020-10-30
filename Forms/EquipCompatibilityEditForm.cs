using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

public class EquipCompatibilityEditForm : Form
{
  private List<MonsterCardEquipCompability> selectedMonsterCardEquipCompatibilities;
  private MonsterCardEquipCompatibilities allMonsterCardEquipCompatibilities;
  private ListBox selectedCardList;
  private Label numberOfCardsSelectedLabel;
  private Object[][] checkBoxFlagList = new Object[DataAccess.CardLeaderAbilityCount][];

  public EquipCompatibilityEditForm(List<MonsterCardEquipCompability> selectedMonsterCardEquipCompatibilities, ref MonsterCardEquipCompatibilities allMonsterCardEquipCompatibilities)
  {
    this.allMonsterCardEquipCompatibilities = allMonsterCardEquipCompatibilities;
    this.selectedMonsterCardEquipCompatibilities = selectedMonsterCardEquipCompatibilities;

    this.InitializeComponent();
    // this.PopulateFields();
    this.SetupFormFields();
    this.SetupCheckboxes();
  }

  private void SetupFormFields()
  {
    this.numberOfCardsSelectedLabel.Text = this.selectedMonsterCardEquipCompatibilities.Count.ToString() + " cards selected.";
    this.selectedMonsterCardEquipCompatibilities.ForEach((cdla) => this.selectedCardList.Items.Add(cdla.Name));
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
      flagCheckbox.Checked = flag.Enabled;
      flagCheckbox.Click += this.onCheckboxClick;

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
