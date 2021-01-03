using DOTR_MODDING_TOOL.Forms.DeckLeaderAbilityForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

public class CardDeckLeaderAbilityMultiEditForm : Form
{
  private List<CardDeckLeaderAbility> selectedCardDeckLeaderAbilityList;
  private CardDeckLeaderAbilities allCardDeckLeaderAbilities;
  private ListBox selectedCardList;
  private Label numberOfCardsSelectedLabel;
  private Button applyButton;
  private Button cancelButton;
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
    this.createAbilityInputs();
  }

  private void createAbilityInputs()
  {
    int startX = 220;
    int startY= 30;
    int rowSpacing = 40;
    int numberOfRowsGenerated = 0;

    for (int i = 0; i < this.deckLeaderAbilities.Length; i++)
    {
      DeckLeaderAbility deckLeaderAbility = (DeckLeaderAbility)this.deckLeaderAbilities[i][0];

      if (deckLeaderAbility.IsUnusedAbility)
      {
        continue;
      }

      int xpos = startX;
      int ypos = startY + (numberOfRowsGenerated * rowSpacing);
      this.createAbilityLabelAndButton(i, deckLeaderAbility, xpos, ypos);
      numberOfRowsGenerated++;
    }
  }

  private void createAbilityLabelAndButton(int abilityIndex, DeckLeaderAbility ability, int xstartpos, int ypos)
  {
    int labelLength = 280;
    int labelButtonSpacing = 20;
    int labelStart = xstartpos;
    int labelEnd = labelStart + labelLength;
    int buttonStart = labelEnd + labelButtonSpacing;

    Label abilityLabel = new Label();
    abilityLabel.Location = new System.Drawing.Point(labelStart, ypos);
    abilityLabel.Name = $"abilityLabel{abilityIndex}";
    abilityLabel.Size = new System.Drawing.Size(labelLength, 23);
    abilityLabel.Padding = new Padding(4);
    abilityLabel.Text = ability.ToString();

    if (ability.Enabled)
    {
      abilityLabel.BackColor = Color.LightGreen;
    }
    
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
    Type abilityType = ability.GetType();

    if (abilityType == typeof(FlagDeckLeaderAbility))
    {
      editForm = new EditFlagDeckLeaderAbilityForm(ability);
    } else if (DeckLeaderAbility.RankRequirementNoAdditionalInformationList.Contains(ability.AbilityType))
    {
      editForm = new EditRankRequirementDeckLeaderAbilityForm(ability);
    } else if (abilityType == typeof(StrengthModifierDeckLeaderAbility))
    {
      editForm = new EditStrengthModifierDeckLeaderAbilityForm(ability);
    } else
    {
      editForm = new EditRankRequirementDeckLeaderAbilityForm(ability);
    }

    editForm.StartPosition = FormStartPosition.CenterParent;
    DialogResult dialogResult = editForm.ShowDialog();

    if (dialogResult.Equals(DialogResult.OK))
    {
      this.deckLeaderAbilities[abilityIndex][0] = editForm.DeckLeaderAbility;
      this.deckLeaderAbilities[abilityIndex][1] = true;
      this.Controls.Find($"abilityLabel{abilityIndex}", false)[0].BackColor = Color.Yellow;
    }
  }

  private void populateDeckLeaderAbilities()
  {
    DeckLeaderAbility[] deckLeaderAbilityList = this.selectedCardDeckLeaderAbilityList[0].deckLeaderAbilityList;
    this.deckLeaderAbilities = new Object[deckLeaderAbilityList.Length][];

    for (int i = 0; i < deckLeaderAbilityList.Length; i++)
    {
      DeckLeaderAbility firstCardDeckLeaderAbility = deckLeaderAbilityList[i].Clone();

      bool allCardsHaveSameAbilityValue = true;

      for (int scai = 0; scai < selectedCardDeckLeaderAbilityList.Count; scai++)
      {
        DeckLeaderAbility selectedCardAbility = this.selectedCardDeckLeaderAbilityList[scai].deckLeaderAbilityList[i];

        if (!selectedCardAbility.Bytes.SequenceEqual(firstCardDeckLeaderAbility.Bytes))
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
        firstCardDeckLeaderAbility.Enabled = false;
        this.deckLeaderAbilities[i] = new Object[] { firstCardDeckLeaderAbility, false };
      }
    }
  }

  private void applyAbilityChangesToCards()
  {
    for (int abilityIndex = 0; abilityIndex < this.deckLeaderAbilities.Length; abilityIndex++)
    {
      bool deckLeaderAbilityHasChanged = (bool)this.deckLeaderAbilities[abilityIndex][1];

      if (!deckLeaderAbilityHasChanged)
      {
        continue;
      }

      DeckLeaderAbility deckLeaderAbility = (DeckLeaderAbility)this.deckLeaderAbilities[abilityIndex][0];

      for (int cardIndex = 0; cardIndex < this.selectedCardDeckLeaderAbilityList.Count; cardIndex++)
      {
        CardDeckLeaderAbility cardDeckLeaderAbility = this.selectedCardDeckLeaderAbilityList[cardIndex];
        this.allCardDeckLeaderAbilities.List[cardDeckLeaderAbility.Index].deckLeaderAbilityList[abilityIndex] = deckLeaderAbility;
      }
    }
  }

  private void InitializeComponent()
  {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CardDeckLeaderAbilityMultiEditForm));
      this.selectedCardList = new System.Windows.Forms.ListBox();
      this.numberOfCardsSelectedLabel = new System.Windows.Forms.Label();
      this.applyButton = new System.Windows.Forms.Button();
      this.cancelButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // selectedCardList
      // 
      this.selectedCardList.FormattingEnabled = true;
      this.selectedCardList.Location = new System.Drawing.Point(12, 31);
      this.selectedCardList.Name = "selectedCardList";
      this.selectedCardList.SelectionMode = System.Windows.Forms.SelectionMode.None;
      this.selectedCardList.Size = new System.Drawing.Size(183, 615);
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
      // applyButton
      // 
      this.applyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.applyButton.Location = new System.Drawing.Point(520, 668);
      this.applyButton.Name = "applyButton";
      this.applyButton.Size = new System.Drawing.Size(75, 23);
      this.applyButton.TabIndex = 5;
      this.applyButton.Text = "Apply";
      this.applyButton.UseVisualStyleBackColor = true;
      this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
      // 
      // cancelButton
      // 
      this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.cancelButton.Location = new System.Drawing.Point(439, 668);
      this.cancelButton.Name = "cancelButton";
      this.cancelButton.Size = new System.Drawing.Size(75, 23);
      this.cancelButton.TabIndex = 6;
      this.cancelButton.Text = "Cancel";
      this.cancelButton.UseVisualStyleBackColor = true;
      this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
      // 
      // CardDeckLeaderAbilityMultiEditForm
      // 
      this.ClientSize = new System.Drawing.Size(607, 703);
      this.Controls.Add(this.cancelButton);
      this.Controls.Add(this.applyButton);
      this.Controls.Add(this.selectedCardList);
      this.Controls.Add(this.numberOfCardsSelectedLabel);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "CardDeckLeaderAbilityMultiEditForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Deck leader ability editor";
      this.ResumeLayout(false);
      this.PerformLayout();

  }

  private void cancelButton_Click(object sender, EventArgs e)
  {
    this.DialogResult = DialogResult.Cancel;
  }

  private void applyButton_Click(object sender, EventArgs e)
  {
    this.applyAbilityChangesToCards();
    this.DialogResult = DialogResult.OK;
  }
}
