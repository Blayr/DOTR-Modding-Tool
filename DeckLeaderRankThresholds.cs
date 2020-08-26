using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

public class DeckLeaderRankThresholds
{
	public static int SLUS_RANK_BYTE_OFFSET = 2754898;

	private byte[] byteData = new byte[24];
	public List<ushort> thresholds = new List<ushort> ( new ushort[12]);
	public string[] rankNames = {
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
	public string[] rankImages = {
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

	public byte[] ByteData
  {
		get { return byteData; }
		set {
			byteData = value;
			setThresholdsWithBytes(byteData);
		}
	}

	public ushort this[int i]
	{
		get => thresholds[i];
		set => thresholds[i] = value;
	}

	public DeckLeaderRankThresholds(){} 

	public DeckLeaderRankThresholds(byte[] byteData)
	{
		this.ByteData = byteData;
	}

	public DeckLeaderRankThresholds(ushort[] _thresholds)
  {
		Buffer.BlockCopy(_thresholds, 0, ByteData, 0, ByteData.Length);
	}

	private void setThresholdsWithBytes(byte[] bytes)
  {
		for (int thresholdsIndex = 0; thresholdsIndex < thresholds.Count; thresholdsIndex++)
		{
			int bytesIndex = thresholdsIndex * 2;
			byte[] thresholdBytes = new byte[] { this.byteData[bytesIndex], this.byteData[bytesIndex + 1] };
			this[thresholdsIndex] = BitConverter.ToUInt16(thresholdBytes, 0);
		}
	}

	public void forceUpdateThresholds()
  {
		setThresholdsWithBytes(this.byteData);
  }

	public DeckLeaderRankThresholdRow[] tableData()
	{
		DeckLeaderRankThresholdRow[] rows = new DeckLeaderRankThresholdRow[12];

		for (int i = 0; i < thresholds.Count; i++)
		{
			rows[i] = new DeckLeaderRankThresholdRow(rankImages[i], rankNames[i], thresholds[i]);
		}

		return rows;
	}
}
public class DeckLeaderRankThresholdRow
{
	public Image Image { get; set; }
	public string Rank { get; set; }
	public ushort Threshold { get; set; }

	public DeckLeaderRankThresholdRow(string imagePath, string rankName, ushort threshold)
	{
		this.Rank = rankName;
		this.Threshold = threshold;

		string workingDirectory = Environment.CurrentDirectory;
		string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

		string path = Path.Combine(projectDirectory, imagePath);
		Image ogImage = Image.FromFile(path);
		Image = (Image)(new Bitmap(ogImage, new Size(30, 30)));
	}
}
