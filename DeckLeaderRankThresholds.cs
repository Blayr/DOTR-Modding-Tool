using System;
using System.Collections.Generic;

public class DeckLeaderRankThresholds
{
  public static readonly int SLUSByteOffset = 2754898;
  public List<ushort> Thresholds = new List<ushort>(new ushort[12]);
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

  public string[] RankImages =
  {
    "images/deck_leader_ranks/1_2LT.png",
    "images/deck_leader_ranks/2_1LT.png",
    "images/deck_leader_ranks/3_CPT.png",
    "images/deck_leader_ranks/4_MAJ.png",
    "images/deck_leader_ranks/5_LTC.png",
    "images/deck_leader_ranks/6_COL.png",
    "images/deck_leader_ranks/7_BG.png",
    "images/deck_leader_ranks/8_RADM.png",
    "images/deck_leader_ranks/9_VADM.png",
    "images/deck_leader_ranks/10_ADM.png",
    "images/deck_leader_ranks/11_SADM.png",
    "images/deck_leader_ranks/12_SD.png"
  };

  private byte[] byteData = new byte[24];

  public DeckLeaderRankThresholds()
  {
  }

  public DeckLeaderRankThresholds(byte[] byteData)
  {
    this.ByteData = byteData;
  }

  public DeckLeaderRankThresholds(ushort[] thresholds) => Buffer.BlockCopy(thresholds, 0, this.ByteData, 0, this.ByteData.Length);

  public byte[] ByteData
  {
    get
    {
      return this.byteData;
    }

    set
    {
      this.byteData = value;
      this.SetThresholdsWithBytes(this.byteData);
    }
  }

  public DeckLeaderRankThresholdRow[] TableData
  {
    get
    {
      DeckLeaderRankThresholdRow[] rows = new DeckLeaderRankThresholdRow[12];

      for (int i = 0; i < this.Thresholds.Count; i++)
      {
        rows[i] = new DeckLeaderRankThresholdRow(this.RankImages[i], this.RankNames[i], this.Thresholds[i]);
      }

      return rows;
    }
  }

  public ushort this[int i]
  {
    get => this.Thresholds[i];
    set => this.Thresholds[i] = value;
  }

  public void ForceUpdateThresholds()
  {
    this.SetThresholdsWithBytes(this.byteData);
  }

  private void SetThresholdsWithBytes(byte[] bytes)
  {
    for (int thresholdsIndex = 0; thresholdsIndex < this.Thresholds.Count; thresholdsIndex++)
    {
      int bytesIndex = thresholdsIndex * 2;
      byte[] thresholdBytes = new byte[] { bytes[bytesIndex], bytes[bytesIndex + 1] };
      this[thresholdsIndex] = BitConverter.ToUInt16(thresholdBytes, 0);
    }
  }
}
