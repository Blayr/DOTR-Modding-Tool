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
    for (byte thresholdsIndex = 1, bytesIndex = 0; thresholdsIndex <= totalRanks; thresholdsIndex++, bytesIndex += rankByteSize)
    {
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
  public DeckLeaderRank Rank { get; }

  public DeckLeaderRankThreshold(byte rankIndex, byte[] byteData)
  {
    this.Bytes = byteData;
    this.Rank = new DeckLeaderRank(rankIndex);
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

  public ushort RankIndex {
    get {
      return (ushort)this.Rank.Index; 
    }
  }
  public string RankName{
    get {
      return this.Rank.Name;
    }
  }
  public Image RankImage
  {
    get
    {
      return new Bitmap(this.Rank.Image, new Size(30, 30));
    }
  }
}