using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DOTR_MODDING_TOOL.Forms.DeckLeaderAbilityForms
{
  public partial class EditFlagDeckLeaderAbilityForm : DOTR_MODDING_TOOL.Forms.DeckLeaderAbilityForms.EditDeckLeaderAbilityForm
  {
    public EditFlagDeckLeaderAbilityForm()
    {
      InitializeComponent();
    }

    public EditFlagDeckLeaderAbilityForm(DeckLeaderAbility deckLeaderAbility) : base(deckLeaderAbility)
    {

    }

    protected override void loadForm()
    {
      InitializeComponent();
      base.loadForm();
      this.flagCheckbox.Checked = this.DeckLeaderAbility.Enabled;
    }

    protected override void applyChangesToAbility()
    {
      this.DeckLeaderAbility.Enabled = this.flagCheckbox.Checked;
    }
  }
}
