using System;
using DOTR_MODDING_TOOL.Properties;

public class Cards
{
  public const ushort TotalCardCount = 854;
  public static string[] cardNameList;
  public const int EquipCardStartIndex = 752;
  public const int EquipCardEndIndex = 800;
  public const int EquipCardCount = EquipCardEndIndex - EquipCardStartIndex;
  public const int MonsterCardStartIndex = 0;
  public const int MonsterCardEndIndex = 682;

  static Cards()
  {
    Cards.cardNameList = Resources.CardList.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.None);
  }

  public static string GetNameByIndex(ushort index)
  {
    if (index >= cardNameList.Length)
    {
      return "???";
    }

    return cardNameList[index];
  }
}
