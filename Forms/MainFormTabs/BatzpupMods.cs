namespace DOTR_Modding_Tool
{
  using System;
  using System.Windows.Forms;

  public partial class MainForm : Form
  {
    private GameplayPatches.AllowAllNonMonsterFusionsPatcher allFusionsPatcher = null;

    private void loadBatzpupMods()
    {
      this.allFusionsPatcher = new GameplayPatches.AllowAllNonMonsterFusionsPatcher(this.dataAccess);
      this.enableAllCardTypeFusionsCheckBox.Checked = this.allFusionsPatcher.isPatchApplied();
    }

    private void allowNonMonsterFusionsSaveButton_Click(object sender, EventArgs e)
    {
      if (this.enableAllCardTypeFusionsCheckBox.Checked)
      {
        this.allFusionsPatcher.applyPatch();
      } else
      {
        this.allFusionsPatcher.undoPatch();
      }
      
      this.enableAllCardTypeFusionsCheckBox.Checked = this.allFusionsPatcher.isPatchApplied();
    }
  }
}
