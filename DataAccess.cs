using System.IO;
using System.Security;

public class DataAccess
{
  public static readonly int SLUSByteOffset = 2754898;
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

  public byte[] LoadLeaderTresholdData()
  {
    byte[] buffer = new byte[24];

    lock (FileStreamLock)
    {
      fileStream.Seek(DataAccess.SLUSByteOffset, SeekOrigin.Begin);
      fileStream.Read(buffer, 0, buffer.Length);
    }

    return buffer;
  }
}

