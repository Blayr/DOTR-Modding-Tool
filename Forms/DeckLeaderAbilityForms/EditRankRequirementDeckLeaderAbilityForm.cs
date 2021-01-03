using DOTR_MODDING_TOOL.Classes;
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
      validRanks.RemoveAt((int)DeckLeaderRankType.NCO);
      this.rankDropdown.DataSource = validRanks;
      this.rankDropdown.DisplayMember = "Name";
      this.rankDropdown.ValueMember = "Index";
      this.rankDropdown.DropDownStyle = ComboBoxStyle.DropDownList;

      this.enabledCheckbox.Checked = this.DeckLeaderAbility.Enabled;
      this.toggleDropdownVisibility(this.DeckLeaderAbility.Enabled);

      RankRequirementDeckLeaderAbility rankRequirementDeckLeaderAbility = (RankRequirementDeckLeaderAbility)this.DeckLeaderAbility;
      DeckLeaderRank unlockRank = rankRequirementDeckLeaderAbility.UnlockRank != null ? rankRequirementDeckLeaderAbility.UnlockRank : new DeckLeaderRank((int)DeckLeaderRankType.SECOND_LT);

      this.rankDropdown.SelectedValue = unlockRank.Index;
    }

    private void toggleDropdownVisibility(bool abilityEnabled)
    {
      this.rankLabel.Visible = abilityEnabled;
      this.rankDropdown.Visible = abilityEnabled;
    }

    protected override void applyChangesToAbility()
    {
      // Mark as enabled first here, as some classes have slightly different implementations of enabled.
      this.DeckLeaderAbility.Enabled = this.enabledCheckbox.Checked;
      RankRequirementDeckLeaderAbility ability = (RankRequirementDeckLeaderAbility)this.DeckLeaderAbility;

      if (this.enabledCheckbox.Checked)
      {
        ability.UnlockRank = new DeckLeaderRank(((DeckLeaderRank)this.rankDropdown.SelectedItem).Index);
      }

      this.DeckLeaderAbility = ability;
    }

    protected virtual void enabledCheckbox_CheckedChanged(object sender, EventArgs e)
    {
      this.toggleDropdownVisibility(this.enabledCheckbox.Checked);
    }
  }
}
