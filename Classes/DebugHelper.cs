using System;
using System.Collections;

public static class DebugHelper
{
	static DebugHelper()
	{
	}

	public static void PrintBitArray(BitArray bitArray, int groupSize)
	{
		string outputString = "";

		for (int i = 0; i < bitArray.Length; i++)
    {
			if (i % groupSize == 0)
      {
				outputString += " ";
      }

			outputString += bitArray[i] ? "1" : "0";
    }

		System.Diagnostics.Debug.WriteLine(outputString);
  }

	public static void PrintByteArray(byte[] byteArray)
  {
		System.Diagnostics.Debug.Print(BitConverter.ToString(byteArray));
  }

  public static void Print2DByteArray(byte[][] byteArray)
  {
    for (int i = 0; i < byteArray.Length; i++)
    {
      DebugHelper.PrintByteArray(byteArray[i]);
    }
  }

	public static void PrintEnemyAi(byte[] bytes)
  {
    for (int i = 0; i < bytes.Length; i += DataAccess.EnemyAiByteLength)
    {
      byte[] tempByteArray = new byte[DataAccess.EnemyAiByteLength];

      for (int j = 0; j < tempByteArray.Length; j++)
      {
        tempByteArray[j] = bytes[i + j];
      }

      DebugHelper.PrintByteArray(tempByteArray);
    }
  }
}
