using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

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
    string workingDirectory = Environment.CurrentDirectory;
    string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

    string path = Path.Combine(projectDirectory, this.RankImages[this.rankIndex]);
    Image originalImage = Image.FromFile(path);
    this.rankImage = (Image)(new Bitmap(originalImage, new Size(30, 30)));
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