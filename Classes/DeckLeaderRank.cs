using DOTR_MODDING_TOOL.Properties;
using System;
using System.Drawing;

public class DeckLeaderRank
{
  public int Index { get; }
  public string Name { get; }
  public Image Image { get; }
	public DeckLeaderRank(int index)
	{
    this.Index = index;
    this.Name = this.RankNames[this.Index];
    this.Image = this.RankImages[this.Index];
	}

   public string[] RankNames =
   {
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

    public Image[] RankImages =
    {
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
}
