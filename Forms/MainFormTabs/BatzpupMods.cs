namespace DOTR_Modding_Tool
{
  using System;
  using System.Windows.Forms;

  public partial class MainForm : Form
  {
    private GameplayPatches.AllowAllNonMonsterFusions allFusionsPatcher = null;

    private void loadBatzpupMods()
    {
      this.allFusionsPatcher = new GameplayPatches.AllowAllNonMonsterFusions(this.dataAccess);
      this.enableAllCardTypeFusionsCheckBox.Checked = this.allFusionsPatcher.isPatchApplied();
    }

    private void allowNonMonsterFusionsSaveButton_Click(object sender, EventArgs e)
    {
      this.allFusionsPatcher.applyPatch();
      this.enableAllCardTypeFusionsCheckBox.Checked = this.allFusionsPatcher.isPatchApplied();
    }
  }
}
