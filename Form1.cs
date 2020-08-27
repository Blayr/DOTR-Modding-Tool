namespace DOTR_Deck_Leader_Thresholds
{
  using System;
  using System.IO;
  using System.Security;
  using System.Windows.Forms;

  public partial class MainForm : Form
  {
    private static readonly object FileStreamLock = new object();
    private static FileStream fileStream;
    private DeckLeaderRankThresholds deckLeaderRankThresholds = new DeckLeaderRankThresholds();

    public MainForm()
    {
      this.InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Normal;
      openFileDialog1.FileName = "dotr.iso";
      openFileDialog1.Filter = "ISO files (*.iso)|*.iso";
      openFileDialog1.Title = "Open DOTR ISO file";
      // openSelectISODialog();
      this.OpenIso("C:\\Users\\Blair\\Desktop\\DOTR_NTSC_TEST.iso");
      this.LoadLeaderTresholdData();
      this.PopulateDataGridView();
    }

    private void FileToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.OpenSelectISODialog();
    }

    private void OpenSelectISODialog()
    {
      if (openFileDialog1.ShowDialog() != DialogResult.OK)
      {
        return;
      }

      rankThresholdsTextbox.Text = openFileDialog1.FileName;
      this.OpenIso(openFileDialog1.FileName);
      this.LoadLeaderTresholdData();
    }

    private void OpenIso(string filePath)
    {
      try
      {
        if (fileStream != null)
        {
          fileStream.Dispose();
        }

        fileStream = new FileStream(filePath, FileMode.Open);
      }
      catch (SecurityException ex)
      {
        MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
        $"Details:\n\n{ex.StackTrace}");
      }
    }

    private void LoadLeaderTresholdData()
    {
      lock (FileStreamLock)
      {
        fileStream.Seek(DeckLeaderRankThresholds.SLUSByteOffset, SeekOrigin.Begin);
        fileStream.Read(this.deckLeaderRankThresholds.ByteData, 0, this.deckLeaderRankThresholds.ByteData.Length);
      }

      this.deckLeaderRankThresholds.ForceUpdateThresholds();
      this.rankThresholdsTextbox.Text = "Byte data: " + BitConverter.ToString(this.deckLeaderRankThresholds.ByteData);
    }

    private void PopulateDataGridView()
    {
      rankThresholdsDataGridView.DataSource = this.deckLeaderRankThresholds.TableData;
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      for (int i = 0; i < this.deckLeaderRankThresholds.Thresholds.Count; i++)
      {
        DataGridViewRow row = rankThresholdsDataGridView.Rows[i];
        // deckLeaderRankThresholds[i] = row[2];
      }

      // test = test.ToList();
      // new DeckLeaderRankThresholds(test.Select(x => x.threshold))

      // fs.Seek(DeckLeaderRankThresholds.SLUS_RANK_BYTE_OFFSET, SeekOrigin.Begin);
      // fs.Write(deckLeaderRankThresholds.ByteData, 0, deckLeaderRankThresholds.ByteData.Length);
    }
  }
}
