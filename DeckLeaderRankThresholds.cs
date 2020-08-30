using DOTR_Deck_Leader_Thresholds;
using DOTR_MODDING_TOOL.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms.PropertyGridInternal;

public class DeckLeaderRankThresholds
{
  private byte totalRanks = 12;
  public List<DeckLeaderRankThreshold> Thresholds = new List<DeckLeaderRankThreshold> { };

  public DeckLeaderRankThresholds(byte[] byteData)
  {
    this.SetThresholdsWithBytes(byteData);
  }

  public void SetThresholdsWithBytes(byte[] bytes)
  {
    for (byte thresholdsIndex = 0; thresholdsIndex < totalRanks; thresholdsIndex++)
    {
      int bytesIndex = thresholdsIndex * 2;
      // Insert the bytes here in reverse order, as the word size is 4, and the PS2 processor architecture is little-endian
      byte[] thresholdBytes = new byte[] { bytes[bytesIndex], bytes[bytesIndex + 1] };
      this.Thresholds.Add(new DeckLeaderRankThreshold(thresholdsIndex, thresholdBytes));
    }
  }

  public byte[] Bytes
  {
    get
    {
      return this.Thresholds.SelectMany(x => x.Bytes).ToArray();
    }
  }
}

public class DeckLeaderRankThreshold {
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
  public DeckLeaderRankThreshold(byte rankIndex, byte[] byteData)
  {
    this.Bytes = byteData;
    this.rankIndex = rankIndex;
    this.rankName = RankNames[this.rankIndex];
    this.SetRankImage();
  }

  public void SetThresholdWithBytes(byte[] byteData)
  {
    this.threshold = BitConverter.ToUInt16(new byte[] { byteData[0], byteData[1] }, 0);
  }

  public void SetRankImage()
  {
    this.rankImage = new Bitmap(RankImages[this.rankIndex], new Size(30, 30));
  }

  private byte rankIndex;
  private byte[] bytes;
  private ushort threshold;
  private string rankName;
  private Image rankImage;

  public byte[] Bytes
  {
    get
    {
      return this.bytes;
    }

    set
    {
      this.bytes = value;
      this.SetThresholdWithBytes(this.bytes);
    }
  }

  public ushort Threshold
  {
    get
    {
      return this.threshold;
    }

    set
    {
      this.threshold = value;
      this.bytes = BitConverter.GetBytes(this.threshold);
    }
  }

  public string RankName
  {
    get
    {
      return this.rankName;
    }
  }

  public Image RankImage
  {
    get
    {
      return this.rankImage;
    }
  }
}