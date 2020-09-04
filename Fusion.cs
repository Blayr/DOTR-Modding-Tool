using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public class Fusions
{
	public Fusions(byte[] bytes)
	{
		for (int i = 0; i + 3 < bytes.Length; i++)
    {
			byte[] fusionByteArray = new byte[] { bytes[i], bytes[i + 1], bytes[i + 2], bytes[i + 3] };
			fusions.Add(new Fusion(fusionByteArray));
    }
	}

	public List<Fusion> fusions = new List<Fusion> { };
}

public class Fusion
{
	public Fusion(byte[] fourBytes)
  {
		this.bitArray = new BitArray(fourBytes);
		this.lowerCardId = this.getCardIdFromBitArray(this.bitArray, 0);
		this.upperCardId = this.getCardIdFromBitArray(this.bitArray, 10);
		this.fusionResultId = this.getCardIdFromBitArray(this.bitArray, 20);

		this.lowerCardName = Cards.GetNameByIndex(this.lowerCardId);
		this.upperCardName = Cards.GetNameByIndex(this.upperCardId);
		this.fusionCardName = Cards.GetNameByIndex(this.fusionResultId);
	}

	private ushort getCardIdFromBitArray(BitArray bitArray, int startIndex)
  {
		BitArray byteBitArray = new BitArray(10);

		for (int i = startIndex; i < (startIndex + byteBitArray.Length); i++)
    {
			byteBitArray[i - startIndex] = bitArray[i];
    }

		byte[] tempByteArray = new byte[2];
		byteBitArray.CopyTo(tempByteArray, 0);

		return BitConverter.ToUInt16(tempByteArray, 0);
  }

	public string LowerCardName
  {
    get
    {
			return this.lowerCardName;
    }
  }

	public string UpperCardName
  {
    get
    {
			return this.upperCardName;
    }
  }

	public string FusionCardName
  {
    get
    {
			return this.fusionCardName;
    }
  }

	BitArray bitArray;
	ushort lowerCardId;
	ushort upperCardId;
	ushort fusionResultId;

	string lowerCardName;
	string upperCardName;
	string fusionCardName;
}
