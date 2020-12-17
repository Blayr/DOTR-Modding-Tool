using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOTR_MODDING_TOOL.Forms.DeckLeaderAbilityForms
{
  public partial class EditDeckLeaderAbilityForm : Form
  {
    public DeckLeaderAbility DeckLeaderAbility;

    public EditDeckLeaderAbilityForm()
    {
      InitializeComponent();
    }

    public EditDeckLeaderAbilityForm(DeckLeaderAbility deckLeaderAbility)
    {
      this.DeckLeaderAbility = deckLeaderAbility;
      InitializeComponent();
      this.abilityNameLabel.Text = this.DeckLeaderAbility.Name;
    }

    protected void applyChangesToAbility()
    {
      // This should be overriden by child class.
    }

    protected void cancelButton_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.Cancel;
    }

    protected void applyButton_Click(object sender, EventArgs e)
    {
      try
      {
        this.applyChangesToAbility();
        this.DialogResult = DialogResult.OK;
      } catch (Exception exception)
      {
        MessageBox.Show(exception.Message);
      }
    }
  }
}
