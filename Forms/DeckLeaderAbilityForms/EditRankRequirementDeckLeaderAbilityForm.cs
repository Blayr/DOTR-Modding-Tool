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

    }
  }
}
