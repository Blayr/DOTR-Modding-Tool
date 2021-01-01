using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DOTR_MODDING_TOOL.Forms.DeckLeaderAbilityForms
{
  public partial class EditRankRequirementDeckLeaderAbilityForm : DOTR_MODDING_TOOL.Forms.DeckLeaderAbilityForms.EditDeckLeaderAbilityForm
  {
    public EditRankRequirementDeckLeaderAbilityForm()
    {
      InitializeComponent();
    }

    public EditRankRequirementDeckLeaderAbilityForm(DeckLeaderAbility deckLeaderAbility) : base(deckLeaderAbility)
    {
      InitializeComponent();
      setupForm();
    }

    private void setupForm()
    {
      List<DeckLeaderRank> validRanks = DeckLeaderRank.RankList();
      validRanks.RemoveAt(0); // Remove NCO
      this.rankDropdown.DataSource = validRanks;
      this.rankDropdown.DisplayMember = "Name";
      this.rankDropdown.ValueMember = "Index";
      this.rankDropdown.DropDownStyle = ComboBoxStyle.DropDownList;

      this.enabledCheckbox.Checked = this.DeckLeaderAbility.Enabled;
      this.toggleDropdownVisibility(this.DeckLeaderAbility.Enabled);
    }

    private void toggleDropdownVisibility(bool abilityEnabled)
    {
      this.rankLabel.Visible = abilityEnabled;
      this.rankDropdown.Visible = abilityEnabled;
    }

    protected override void applyChangesToAbility()
    {
      RankRequirementDeckLeaderAbility ability = (RankRequirementDeckLeaderAbility)this.DeckLeaderAbility;
      ability.UnlockRank = new DeckLeaderRank(((DeckLeaderRank)this.rankDropdown.SelectedItem).Index);
      ability.Enabled = this.enabledCheckbox.Checked;
      this.DeckLeaderAbility = ability;
    }

    private void enabledCheckbox_CheckedChanged(object sender, EventArgs e)
    {
      this.toggleDropdownVisibility(this.enabledCheckbox.Checked);
    }
  }
}
