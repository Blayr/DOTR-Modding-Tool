using DOTR_MODDING_TOOL.Forms.DeckLeaderAbilityForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

public class CardDeckLeaderAbilityMultiEditForm : Form
{
  private List<CardDeckLeaderAbility> selectedCardDeckLeaderAbilityList;
  private CardDeckLeaderAbilities allCardDeckLeaderAbilities;
  private ListBox selectedCardList;
  private Label numberOfCardsSelectedLabel;
  private Object[][] deckLeaderAbilities;

  public CardDeckLeaderAbilityMultiEditForm(List<CardDeckLeaderAbility> selectedCardDeckLeaderAbilityList, ref CardDeckLeaderAbilities allCardDeckLeaderAbilities)
	{
    this.allCardDeckLeaderAbilities = allCardDeckLeaderAbilities;
    this.selectedCardDeckLeaderAbilityList = selectedCardDeckLeaderAbilityList;

    this.InitializeComponent();
    this.populateDeckLeaderAbilities();
    this.SetupFormFields();
  }

  private void SetupFormFields()
  {
    this.numberOfCardsSelectedLabel.Text = this.selectedCardDeckLeaderAbilityList.Count.ToString() + " cards selected.";
    this.selectedCardDeckLeaderAbilityList.ForEach((cdla) => this.selectedCardList.Items.Add(cdla.Name));

    // DeckLeaderAbility test = this.selectedCardDeckLeaderAbilityList[0].deckLeaderAbilityList[1];
    // System.Diagnostics.Debug.Print(test.Name);
    // DebugHelper.PrintByteArray(test.Bytes);

    this.createAbilityInputs();
  }

  private void createAbilityInputs()
  {
    int startX = 300;
    int startY= 40;
    int rowSpacing = 40;

    for (int i = 0; i < this.deckLeaderAbilities.Length; i++)
    {
      int xpos = startX;
      int ypos = startY + (i * rowSpacing);
      this.createAbilityLabelAndButton(i, (DeckLeaderAbility)this.deckLeaderAbilities[i][0], xpos, ypos);
    }
  }

  private void createAbilityLabelAndButton(int abilityIndex, DeckLeaderAbility ability, int xstartpos, int ypos)
  {
    int labelLength = 200;
    int labelButtonSpacing = 40;
    int labelStart = xstartpos;
    int labelEnd = labelStart + labelLength;
    int buttonStart = labelEnd + labelButtonSpacing;

    Label abilityLabel = new Label();
    abilityLabel.Location = new System.Drawing.Point(labelStart, ypos);
    abilityLabel.Name = $"abilityLabel{abilityIndex}";
    abilityLabel.Size = new System.Drawing.Size(200, 23);
    abilityLabel.Text = ability.ToString();
    
    Button abilityEditButton = new Button();
    abilityEditButton.Name = abilityIndex.ToString();
    abilityEditButton.Text = "Edit";
    abilityEditButton.Location = new System.Drawing.Point(buttonStart, ypos);
    abilityEditButton.Click += this.handleEditButtonClick;

    this.Controls.Add(abilityLabel);
    this.Controls.Add(abilityEditButton);
  }

  private void handleEditButtonClick(object sender, EventArgs e)
  {
    Button abilityEditButton = (Button)sender;
    int abilityIndex = Int32.Parse(abilityEditButton.Name);
    DeckLeaderAbility ability = (DeckLeaderAbility)this.deckLeaderAbilities[abilityIndex][0];
    EditDeckLeaderAbilityForm editForm;

    if (ability.GetType() == typeof(FlagDeckLeaderAbility))
    {
      editForm = new EditFlagDeckLeaderAbilityForm(ability);
    }
    else if (ability.GetType() == typeof(RankRequirementDeckLeaderAbility))
    {
      editForm = new EditRankRequirementDeckLeaderAbilityForm(ability);
    }
    else
    {
      editForm = new EditRankRequirementDeckLeaderAbilityForm(ability);
    }

    DialogResult dialogResult = editForm.ShowDialog();
  }

  private void populateDeckLeaderAbilities()
  {
    this.deckLeaderAbilities = new Object[17][];

    for (int i = 0; i < deckLeaderAbilities.Length; i++)
    {
      DeckLeaderAbility firstCardDeckLeaderAbility = this.selectedCardDeckLeaderAbilityList[0].deckLeaderAbilityList[i];
      bool allCardsHaveSameAbilityValue = true;

      for (int scai = 0; scai < selectedCardDeckLeaderAbilityList.Count; scai++)
      {
        DeckLeaderAbility selectedCardAbility = this.selectedCardDeckLeaderAbilityList[scai].deckLeaderAbilityList[i];

        if (selectedCardAbility.Bytes != firstCardDeckLeaderAbility.Bytes)
        {
          allCardsHaveSameAbilityValue = false;
          break;
        }
      }

      if (allCardsHaveSameAbilityValue)
      {
        this.deckLeaderAbilities[i] = new Object[] { firstCardDeckLeaderAbility, false };
      } else
      {
        Object[] args = new Object[] { firstCardDeckLeaderAbility.Index, firstCardDeckLeaderAbility.Bytes };
        DeckLeaderAbility ability = (DeckLeaderAbility)Activator.CreateInstance(firstCardDeckLeaderAbility.GetType(), args);
        ability.Enabled = false;
        this.deckLeaderAbilities[i] = new Object[] { ability, false };
      }
    }
  }

  private void renderAbilityControls(int index, DeckLeaderAbility deckLeaderAbility)
  {

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
      this.ClientSize = new System.Drawing.Size(992, 725);
      this.Controls.Add(this.selectedCardList);
      this.Controls.Add(this.numberOfCardsSelectedLabel);
      this.Name = "CardDeckLeaderAbilityMultiEditForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.ResumeLayout(false);
      this.PerformLayout();

  }
}
