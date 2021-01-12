namespace DOTR_Modding_Tool
{
  using Equin.ApplicationFramework;
  using System;
  using System.Windows.Forms;

  public partial class MainForm : Form
  {
    private Enemies enemies;
    private BindingListView<Enemy> enemiesBinding;

    private void LoadEnemyAI()
    {
      this.enemyAiDataGridView.AutoGenerateColumns = false;
      byte[] bytes = this.dataAccess.LoadEnemyAIData();
      this.enemies = new Enemies(bytes);
      this.enemiesBinding = new BindingListView<Enemy>(this.enemies.List);
      this.enemyAiDataGridView.DataSource = this.enemiesBinding;
      MainForm.EnableDoubleBuffering(this.enemyAiDataGridView);

      this.EnemyAiColumn.DataPropertyName = "AiId";
      this.EnemyAiColumn.ValueMember = "AiId";
      this.EnemyAiColumn.DisplayMember = "AiName";

      if (this.EnemyAiColumn.Items.Count > 0)
      {
        return;
      }

      foreach (Ai ai in Ai.All)
      {
        this.EnemyAiColumn.Items.Add(new { AiId = ai.Id, AiName = ai.Name }); ;
      }
    }

    private void enemyAiSaveButton_Click(object sender, EventArgs e)
    {
      byte[] aiBytes = this.enemies.AiBytes;
      this.dataAccess.SaveEnemyAiData(aiBytes);
      this.LoadEnemyAI();
      MessageBox.Show("All enemy Ais saved.", "Save successful");
    }
  }
}