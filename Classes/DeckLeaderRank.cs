using DOTR_MODDING_TOOL.Properties;
using System.Collections.Generic;
using System.Drawing;

public class DeckLeaderRank
{
  public int Index { get; }
  public string Name { get; }
  private Image image;
  public Image Image {
    get
    {
      if (this.image == null && this.Index != 0)
      {
        this.image = DeckLeaderRank.RankImages[this.Index];
      }

      return this.image;
    }
  }
	public DeckLeaderRank(int index)
	{
    this.Index = index;
    this.Name = DeckLeaderRank.RankNames[this.Index];
	}
  public override string ToString()
  {
    return this.Name;
  }
  public static string[] RankNames =
   {
      "NCO",
      "2LT",
      "1LT",
      "CPT",
      "MAJ",
      "LTC",
      "COL",
      "BG",
      "RADM",
      "VADM",
      "ADM",
      "SADM",
      "SD"
    };
  public static Image[] RankImages =
    {
      null,
      Resources.DeckRank_1_2LT,
      Resources.DeckRank_2_1LT,
      Resources.DeckRank_3_CPT,
      Resources.DeckRank_4_MAJ,
      Resources.DeckRank_5_LTC,
      Resources.DeckRank_6_COL,
      Resources.DeckRank_7_BG,
      Resources.DeckRank_8_RADM,
      Resources.DeckRank_9_VADM,
      Resources.DeckRank_10_ADM,
      Resources.DeckRank_11_SADM,
      Resources.DeckRank_12_SD
    };
  public static List<DeckLeaderRank> RankList()
  {
    List<DeckLeaderRank> rankList = new List<DeckLeaderRank> { };
    string[] rankNames = DeckLeaderRank.RankNames;

    for(int i = 0; i < rankNames.Length; i++)
    {
      rankList.Insert(i, new DeckLeaderRank(i)); 
    }

    return rankList;
  }
}
