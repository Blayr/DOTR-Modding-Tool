using DOTR_MODDING_TOOL.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

public class DeckLeaderRankThresholds
{
  private readonly byte totalRanks = 12;
  private readonly byte rankByteSize = 2;
  public List<DeckLeaderRankThreshold> Thresholds = new List<DeckLeaderRankThreshold> { };

  public DeckLeaderRankThresholds(byte[] byteData)
  {
    this.SetThresholdsWithBytes(byteData);
  }

  public void SetThresholdsWithBytes(byte[] bytes)
  {
    for (byte thresholdsIndex = 0; thresholdsIndex < totalRanks; thresholdsIndex++)
    {
      int bytesIndex = thresholdsIndex * rankByteSize;
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
    this.RankIndex = rankIndex;
    this.RankName = RankNames[this.RankIndex];
    this.RankImage = new Bitmap(RankImages[this.RankIndex], new Size(30, 30));
  }

  public void SetThresholdWithBytes(byte[] byteData)
  {
    this.threshold = BitConverter.ToUInt16(new byte[] { byteData[0], byteData[1] }, 0);
  }

  private byte[] bytes;
  private ushort threshold;

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

  public ushort RankIndex { get; }
  public string RankName{ get; }
  public Image RankImage { get; }
}