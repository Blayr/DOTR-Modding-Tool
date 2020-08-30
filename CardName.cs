using System;
using System.Runtime.Versioning;
using DOTR_MODDING_TOOL.Properties;

public class CardName
{
  public static string[] cardNameList;

  static CardName()
  {
    CardName.cardNameList = Resources.CardList.ToString().Split(new[] { Environment.NewLine }, StringSplitOptions.None);
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
