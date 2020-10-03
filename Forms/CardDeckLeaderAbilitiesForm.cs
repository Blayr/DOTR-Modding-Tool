namespace DOTR_Modding_Tool
{
  using Equin.ApplicationFramework;
  using System.Collections.Generic;
  using System.Runtime.CompilerServices;
  using System.Windows.Forms;

  public partial class MainForm : Form
  {
    private CardDeckLeaderAbilities cardDeckLeaderAbilities;
    private BindingListView<CardDeckLeaderAbility> cardDeckLeaderAbilitiesBinding;
    private void LoadCardDeckLeaderAbilitesData()
    {
      byte[][][] byteArray = this.dataAccess.LoadCardDeckLeaderAbilities();
      // DebugHelper.Print2DByteArray(byteArray);
      this.cardDeckLeaderAbilities = new CardDeckLeaderAbilities(byteArray);
      this.cardDeckLeaderAbilitiesBinding = new BindingListView<CardDeckLeaderAbility>(this.cardDeckLeaderAbilities.List);
      this.cardDeckLeaderAbilitiesDatagridview.DataSource = this.cardDeckLeaderAbilitiesBinding;
    }
  }
}