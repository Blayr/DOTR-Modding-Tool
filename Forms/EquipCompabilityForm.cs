namespace DOTR_Modding_Tool
{
  using Equin.ApplicationFramework;
  using System;
  using System.ComponentModel;
  using System.Windows.Forms;

  public partial class MainForm : Form
  {
    private MonsterCardEquipCompatibilities equipCompatabilities;
    private BindingListView<MonsterCardEquipCompability> equipCompatabilitiesBinding;

    private void LoadCardEquipData()
    {
      byte[][] cardEquipBytes = this.dataAccess.LoadMonsterEquipCardCompability();
      this.equipCompatabilities = new MonsterCardEquipCompatibilities(cardEquipBytes);
      this.equipCompatabilitiesBinding= new BindingListView<MonsterCardEquipCompability>(this.equipCompatabilities.List);

      this.equipCompatibilityDataGridView.AutoGenerateColumns = false;
      this.equipCompatibilityDataGridView.DataSource = equipCompatabilitiesBinding;
    }
  }
}
