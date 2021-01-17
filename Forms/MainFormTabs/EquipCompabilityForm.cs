namespace DOTR_Modding_Tool
{
  using Equin.ApplicationFramework;
  using System;
  using System.Collections.Generic;
  using System.Windows.Forms;

  public partial class MainForm : Form
  {
    private MonsterCardEquipCompatibilities equipCompatabilities;
    private BindingListView<MonsterCardEquipCompability> equipCompatabilitiesBinding;

    private void LoadCardEquipData()
    {
      byte[][] cardEquipBytes = this.dataAccess.LoadMonsterEquipCardCompability();
      this.equipCompatabilities = new MonsterCardEquipCompatibilities(cardEquipBytes);
      this.equipCompatabilitiesBinding = new BindingListView<MonsterCardEquipCompability>(this.equipCompatabilities.List);

      this.equipCompatibilityDataGridView.AutoGenerateColumns = false;
      this.equipCompatibilityDataGridView.DataSource = equipCompatabilitiesBinding;
      MainForm.EnableDoubleBuffering(this.equipCompatibilityDataGridView);
    }

    private void ShowMonsterCardEquipCompatibilityEditDialog(object sender, EventArgs e)
    {
      List<MonsterCardEquipCompability> selectedMonsterCardEquipCompatibilitys = new List<MonsterCardEquipCompability>();

      for (int i = this.equipCompatibilityDataGridView.SelectedRows.Count - 1; i >= 0; i--)
      {
        MonsterCardEquipCompability monsterCardEquipCompatibility = ((ObjectView<MonsterCardEquipCompability>)this.equipCompatibilityDataGridView.SelectedRows[i].DataBoundItem).Object;
        selectedMonsterCardEquipCompatibilitys.Add(this.equipCompatabilities.List[monsterCardEquipCompatibility.Index]);
      }

      EquipCompatibilityEditForm form = new EquipCompatibilityEditForm(selectedMonsterCardEquipCompatibilitys, ref this.equipCompatabilities);
      form.ShowDialog();
      this.equipCompatibilityDataGridView.Refresh();
    }

    private void equipCompatibilitySaveButton_Click(object sender, EventArgs e)
    {
      this.dataAccess.SetMonsterEquipCardCompatibility(this.equipCompatabilities.Bytes);
      this.LoadCardConstantsData();
      MessageBox.Show("All monster equip data saved.", "Save successful");
    }
  }
}
