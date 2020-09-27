using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace CustomExtensions
{
	public static class BitArrayExtension
	{
		public static byte toByte(this BitArray input, int startIndex = 0, int bitLength = 8)
		{
			BitArray newBitArray = new BitArray(bitLength);
			
			for (int i = 0, bi = startIndex; i < bitLength; i++, bi++)
			{
				newBitArray[i] = input[bi]; 
			}

			byte[] result = new byte[1];
			newBitArray.CopyTo(result, 0);

			return result[0];
		}
	}

	public static class ByteExtension
  {
		public static byte[] splitByte(this byte inputByte)
    {
			BitArray tempBitArray = new BitArray(new byte[] { inputByte });
			byte[] splitBytes = new byte[2];

			splitBytes[0] = tempBitArray.toByte(0, 4);
			splitBytes[1] = tempBitArray.toByte(4, 4);

			return splitBytes;
		}
  }
}
