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
      this.loadForm();
    }

    protected virtual void applyChangesToAbility()
    {
      // This should be overriden by child class.
    }

    protected virtual void loadForm()
    {
      // this should be overridden by a child class.
      this.Text = $"Deck leader ability editor - {this.DeckLeaderAbility.Name}";
      this.abilityNameLabel.Text = this.DeckLeaderAbility.Name;
      this.abilityDescriptionTextbox.Text = this.DeckLeaderAbility.Description;
      this.bytesTextbox.Text = BitConverter.ToString(this.DeckLeaderAbility.Bytes);
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
