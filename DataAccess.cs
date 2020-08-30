﻿using System.IO;

public class DataAccess
{
  public static readonly int SLUSDeckLeaderRankThresholdsByteOffset = 2754898;
  public static readonly int DeckLeaderRankThresholdByteLength = 24;
  public static readonly int SLUSCardConstantsByteOffset = 2683264;
  public static readonly int CardConstantByteLength = 20;
  public static readonly int CardConstantCount = 857;

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
        fileStream.Seek(DataAccess.SLUSDeckLeaderRankThresholdsByteOffset + cardIndexOffset, SeekOrigin.Begin);
        fileStream.Read(buffer, 0, buffer.Length);
        cardConstantsBytes[cardIndex] = buffer;
      }
    }

    return cardConstantsBytes;
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
}
