using System;
using System.Drawing;
using System.IO;
using System.Security;
using System.Windows.Forms;
using System.Linq;

namespace DOTR_Deck_Leader_Thresholds
{
  public partial class MainForm : Form
  {

    private static readonly object fsLock = new object();
    private static FileStream fs;
    private DeckLeaderRankThresholds deckLeaderRankThresholds = new DeckLeaderRankThresholds();


    public MainForm()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      this.WindowState = FormWindowState.Normal;
      openFileDialog1.FileName = "dotr.iso";
      openFileDialog1.Filter = "ISO files (*.iso)|*.iso";
      openFileDialog1.Title = "Open DOTR ISO file";
      // openSelectISODialog();
      openIso("C:\\Users\\Blair\\Desktop\\DOTR_NTSC_TEST.iso");
      loadLeaderTresholdData();
      PopulateDataGridView();
    }

    private void fileToolStripMenuItem_Click(object sender, EventArgs e)
    {
      openSelectISODialog();
    }

    private void openSelectISODialog()
    {
      if (openFileDialog1.ShowDialog() != DialogResult.OK) { return; }

      rankThresholdsTextbox.Text = openFileDialog1.FileName;
      openIso(openFileDialog1.FileName);
      loadLeaderTresholdData();
    }

    private void openIso(string filePath)
    {
      try
      {
        if (fs != null) { fs.Dispose(); }

        fs = new FileStream(filePath, FileMode.Open);
      }
      catch (SecurityException ex)
      {
        MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
        $"Details:\n\n{ex.StackTrace}");
      }
    }

    private void loadLeaderTresholdData()
    {
      lock (fsLock)
      {
        fs.Seek(DeckLeaderRankThresholds.SLUS_RANK_BYTE_OFFSET, SeekOrigin.Begin);
        fs.Read(deckLeaderRankThresholds.ByteData, 0, deckLeaderRankThresholds.ByteData.Length);
      }

      deckLeaderRankThresholds.forceUpdateThresholds();
      rankThresholdsTextbox.Text = "Byte data: " + BitConverter.ToString(deckLeaderRankThresholds.ByteData);
    }

    private void PopulateDataGridView()
    {
      RankThresholdsDataGridView.DataSource = deckLeaderRankThresholds.tableData();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      

      for (int i = 0; i < deckLeaderRankThresholds.thresholds.Count; i++)
      {
        DataGridViewRow row = RankThresholdsDataGridView.Rows[i];
        // deckLeaderRankThresholds[i] = row[2];
      }

      //test = test.ToList();
      // new DeckLeaderRankThresholds(test.Select(x => x.threshold))

      //fs.Seek(DeckLeaderRankThresholds.SLUS_RANK_BYTE_OFFSET, SeekOrigin.Begin);
      //fs.Write(deckLeaderRankThresholds.ByteData, 0, deckLeaderRankThresholds.ByteData.Length);
    }

    private void leaderRankTresholdsTabControl_Click(object sender, EventArgs e)
    {

    }
  }
}
