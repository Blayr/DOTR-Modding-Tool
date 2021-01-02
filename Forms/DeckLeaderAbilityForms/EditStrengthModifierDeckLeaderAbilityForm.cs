using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DOTR_MODDING_TOOL.Forms.DeckLeaderAbilityForms
{
  public partial class EditStrengthModifierDeckLeaderAbilityForm : DOTR_MODDING_TOOL.Forms.DeckLeaderAbilityForms.EditRankRequirementDeckLeaderAbilityForm
  {
    public EditStrengthModifierDeckLeaderAbilityForm()
    {
      InitializeComponent();
    }

    public EditStrengthModifierDeckLeaderAbilityForm(DeckLeaderAbility deckLeaderAbility) : base(deckLeaderAbility)
    {
      InitializeComponent();
      setupForm();
    }

    private void setupForm()
    {
      this.strengthModifierNumericUpDown.Value = ((StrengthModifierDeckLeaderAbility)this.DeckLeaderAbility).StrengthModifierAmount;

      this.toggleStrengthModifierFieldsVisibility(this.DeckLeaderAbility.Enabled);
    }

    protected override void enabledCheckbox_CheckedChanged(object sender, EventArgs e)
    {
      base.enabledCheckbox_CheckedChanged(sender, e);
      this.toggleStrengthModifierFieldsVisibility(this.enabledCheckbox.Checked);
    }

    private void toggleStrengthModifierFieldsVisibility(bool enabled)
    {
      if (this.strengthModifierLabel != null)
      {
        this.strengthModifierLabel.Visible = enabled;
        this.strengthModifierNumericUpDown.Visible = enabled;
      }
    }

    protected override void applyChangesToAbility()
    {
      StrengthModifierDeckLeaderAbility ability = (StrengthModifierDeckLeaderAbility)this.DeckLeaderAbility;
      ability.UnlockRank = new DeckLeaderRank(((DeckLeaderRank)this.rankDropdown.SelectedItem).Index);
      ability.StrengthModifierAmount = (int)strengthModifierNumericUpDown.Value;
      ability.Enabled = this.enabledCheckbox.Checked;
      this.DeckLeaderAbility = ability;
    }
  }
}
