using System;
using DOTR_MODDING_TOOL.Properties;

public class Cards
{
  public static readonly ushort TotalCardCount = 854;
  public static string[] cardNameList;
  public static int EquipCardStartIndex = 752;
  public static int EquipCardEndIndex = 800;
  public static int MonsterCardStartIndex = 0;
  public static int MonsterCardEndIndex = 682;

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
