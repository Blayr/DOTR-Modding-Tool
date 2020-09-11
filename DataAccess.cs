using System.IO;

public class DataAccess
{
  public static readonly int SLUSDeckLeaderRankThresholdsByteOffset = 2754898;
  public static readonly int DeckLeaderRankThresholdByteLength = 24;
  public static readonly int SLUSCardConstantsByteOffset = 2683264;
  public static readonly int SLUSFusionListByteOffset = 2550064;
  public static readonly int FusionListByteLength = 26540 * 4;
  public static readonly int CardConstantByteLength = 20;
  public static readonly int CardConstantCount = Cards.TotalCardCount;

  private static readonly object FileStreamLock = new object();
	private static FileStream fileStream;

	public DataAccess()
	{
	}

  public void OpenIso(string filePath)
  {
    if (fileStream != null)
    {
      fileStream.Dispose();
    }

    fileStream = new FileStream(filePath, FileMode.Open);
  }

  public byte[][] LoadCardConstantData()
  {
    byte[][] cardConstantsBytes = new byte[CardConstantCount][];

    lock (FileStreamLock)
    {
      for (int cardIndex = 0; cardIndex < CardConstantCount; cardIndex++)
      {
        byte[] buffer = new byte[CardConstantByteLength];
        int cardIndexOffset = CardConstantByteLength * cardIndex;
        fileStream.Seek(DataAccess.SLUSCardConstantsByteOffset + cardIndexOffset, SeekOrigin.Begin);
        fileStream.Read(buffer, 0, buffer.Length);
        cardConstantsBytes[cardIndex] = buffer;
      }
    }

    return cardConstantsBytes;
  }

  public byte[][] SetCardConstantData(byte[] byteData)
  {
    lock (FileStreamLock)
    {
      fileStream.Seek(DataAccess.SLUSCardConstantsByteOffset, SeekOrigin.Begin);
      fileStream.Write(byteData, 0, byteData.Length);
    }

    return this.LoadCardConstantData();
  }

  public byte[] LoadLeaderTresholdData()
  {
    byte[] buffer = new byte[24];

    lock (FileStreamLock)
    {
      fileStream.Seek(DataAccess.SLUSDeckLeaderRankThresholdsByteOffset, SeekOrigin.Begin);
      fileStream.Read(buffer, 0, buffer.Length);
    }

    return buffer;
  }

  public byte[] SetDeckLeaderTresholds(byte[] byteData)
  {
    lock (FileStreamLock)
    {
      fileStream.Seek(DataAccess.SLUSDeckLeaderRankThresholdsByteOffset, SeekOrigin.Begin);
      fileStream.Write(byteData, 0, DataAccess.DeckLeaderRankThresholdByteLength);
    }

    return this.LoadLeaderTresholdData();
  }

  public byte[] LoadFusionData()
  {
    byte[] buffer = new byte[DataAccess.FusionListByteLength];

    lock (FileStreamLock)
    {
      fileStream.Seek(DataAccess.SLUSFusionListByteOffset, SeekOrigin.Begin);
      fileStream.Read(buffer, 0, buffer.Length);
    }

    return buffer;
  }
}

