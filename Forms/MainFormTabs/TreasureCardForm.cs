namespace DOTR_Modding_Tool
{
  using System;
  using System.Windows.Forms;

  public partial class MainForm
  {
    private TreasureCards treasureCards;
    private TreasureCard selectedTreasureCard;

    private void LoadTreasureCardData()
    {
      byte[] treasureCardBytes = this.dataAccess.GetTreasureCardData();
      this.treasureCards = new TreasureCards(treasureCardBytes);
      this.setupTreasureCardForm();
      this.treasureCardsListbox.DataSource = this.treasureCards.List;
    }

    private void setupTreasureCardForm()
    {
      if (this.treasureCardCardComboBox.DataSource != null)
      {
        return;
      }

      this.treasureCardCardComboBox.DataSource = CardConstant.List;
      this.treasureCardCardComboBox.DropDownStyle = ComboBoxStyle.DropDown;
      this.treasureCardCardComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.treasureCardCardComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
    }

    private void treasureCardsListbox_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.selectedTreasureCard = this.treasureCards.List[this.treasureCardsListbox.SelectedIndex];
      this.treasureCardCardComboBox.SelectedValue = this.selectedTreasureCard.CardIndex;
      this.treasureCardRowNumericUpDown.Value = (int)this.selectedTreasureCard.Row;
      this.treasureCardColumnNumericUpDown.Value = (int)this.selectedTreasureCard.Column;
    }

    private void treasureCardSaveButton_Click(object sender, EventArgs e)
    {
      this.selectedTreasureCard.CardIndex = (ushort)this.treasureCardCardComboBox.SelectedValue;

      byte rowByte = BitConverter.GetBytes((int)this.treasureCardRowNumericUpDown.Value)[0];
      byte columnByte = BitConverter.GetBytes((int)this.treasureCardColumnNumericUpDown.Value)[0];

      this.selectedTreasureCard.Row = rowByte;
      this.selectedTreasureCard.Column = columnByte;

      this.dataAccess.SaveTreasureCard(this.treasureCardsListbox.SelectedIndex, selectedTreasureCard.Bytes);
      MessageBox.Show("Treasure card saved.", "Save successful");
    }
  }
}