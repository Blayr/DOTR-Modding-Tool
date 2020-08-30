using System;
using DOTR_MODDING_TOOL.Properties;

public class Cards
{
  public static readonly ushort TotalCardCount = 854;
  public static string[] cardNameList;

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
