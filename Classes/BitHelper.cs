using System;
using System.Linq;

public class BitHelper
{
  public static byte[] HexStringToByteArray(string hex)
  {
    return Enumerable.Range(0, hex.Length)
                     .Where(x => x % 2 == 0)
                     .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                     .ToArray();
  }
}
