using System;
using System.Collections;
using System.Collections.Generic;

public class Fusions
{
	public Fusions(byte[] bytes)
	{
		for (int i = 0; i < bytes.Length; i += 4)
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
		this.upperCardIndex = this.getCardIdFromBitArray(this.bitArray, 0);
		this.lowerCardIndex = this.getCardIdFromBitArray(this.bitArray, 10);
		this.fusionResultIndex = this.getCardIdFromBitArray(this.bitArray, 20);

		this.lowerCardName = Cards.GetNameByIndex(this.lowerCardIndex);
		this.upperCardName = Cards.GetNameByIndex(this.upperCardIndex);
		this.fusionCardName = Cards.GetNameByIndex(this.fusionResultIndex);
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

	public ushort LowerCardIndex
  {
    get
    {
			return this.lowerCardIndex;
    }

		set
    {
			this.lowerCardIndex = value;
			this.lowerCardName = Cards.GetNameByIndex(this.lowerCardIndex);
		}
  }

	public string LowerCardName
  {
    get
    {
			return this.lowerCardName;
    }
  }

	public ushort UpperCardIndex
	{
		get
		{
			return this.upperCardIndex;
		}

		set
		{
			this.upperCardIndex = value;
			this.upperCardName = Cards.GetNameByIndex(this.upperCardIndex);
		}
	}

	public string UpperCardName
  {
    get
    {
			return this.upperCardName;
    }
  }

	public ushort FusionCardIndex
	{
		get
		{
			return this.fusionResultIndex;
		}

		set
		{
			this.fusionResultIndex = value;
			this.fusionCardName = Cards.GetNameByIndex(this.fusionResultIndex);
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
	ushort lowerCardIndex;
	ushort upperCardIndex;
	ushort fusionResultIndex;

	string lowerCardName;
	string upperCardName;
	string fusionCardName;
}
