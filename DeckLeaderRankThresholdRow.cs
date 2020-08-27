using System;
using System.Drawing;
using System.IO;

public class DeckLeaderRankThresholdRow
{
  public DeckLeaderRankThresholdRow(string imagePath, string rankName, ushort threshold)
  {
    this.Rank = rankName;
    this.Threshold = threshold;

    string workingDirectory = Environment.CurrentDirectory;
    string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

    string path = Path.Combine(projectDirectory, imagePath);
    Image originalImage = Image.FromFile(path);
    Image = (Image)(new Bitmap(originalImage, new Size(30, 30)));
  }

  public Image Image
  {
    get;
    set;
  }

  public string Rank
  {
    get;
    set;
  }

  public ushort Threshold
  {
    get;
    set;
  }
}
