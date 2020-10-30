using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class CardDeckLeaderAbilityMultiEditForm : Form
{
  private List<CardDeckLeaderAbility> selectedCardDeckLeaderAbilityList;
  private CardDeckLeaderAbilities allCardDeckLeaderAbilities;
  private ListBox selectedCardList;
  private Label numberOfCardsSelectedLabel;

  public CardDeckLeaderAbilityMultiEditForm(List<CardDeckLeaderAbility> selectedCardDeckLeaderAbilityList, ref CardDeckLeaderAbilities allCardDeckLeaderAbilities)
	{
    this.allCardDeckLeaderAbilities = allCardDeckLeaderAbilities;
    this.selectedCardDeckLeaderAbilityList = selectedCardDeckLeaderAbilityList;

    this.InitializeComponent();
    // this.PopulateFields();
    this.SetupFormFields();
  }

  private void SetupFormFields()
  {
    this.numberOfCardsSelectedLabel.Text = this.selectedCardDeckLeaderAbilityList.Count.ToString() + " cards selected.";
    this.selectedCardDeckLeaderAbilityList.ForEach((cdla) => this.selectedCardList.Items.Add(cdla.Name));
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
      // CardDeckLeaderAbilityMultiEditForm
      // 
      this.ClientSize = new System.Drawing.Size(724, 444);
      this.Controls.Add(this.selectedCardList);
      this.Controls.Add(this.numberOfCardsSelectedLabel);
      this.Name = "CardDeckLeaderAbilityMultiEditForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.ResumeLayout(false);
      this.PerformLayout();

  }
}
