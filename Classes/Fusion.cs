using System;
using System.Collections;
using System.Collections.Generic;

public class Fusions
{
	public Fusions(byte[] bytes)
	{
		for (int i = 0; i < bytes.Length; i += Fusion.ByteLength)
    {
			byte[] fusionByteArray = new byte[] { bytes[i], bytes[i + 1], bytes[i + 2], bytes[i + 3] };
			fusions.Add(new Fusion(i / Fusion.ByteLength, fusionByteArray));
    }
	}

	public byte[] Bytes
  {
    get
    {
			byte[] bytes = new byte[this.fusions.Count * Fusion.ByteLength];

			for (int i = 0; i < bytes.Length; i += Fusion.ByteLength)
      {
				byte[] fusionBytes = this.fusions[i / Fusion.ByteLength].Bytes;
				fusionBytes.CopyTo(bytes, i);
      }

			return bytes;
    }
  }

	public List<Fusion> fusions = new List<Fusion> { };
}

public class Fusion
{
	public static int ByteLength = 4;
	public Fusion(int index, byte[] fourBytes)
  {
		this.index = index;
		this.bitArray = new BitArray(fourBytes);
		this.upperCardIndex = this.getCardIdFromBitArray(this.bitArray, 0);
		this.lowerCardIndex = this.getCardIdFromBitArray(this.bitArray, 10);
		this.fusionResultIndex = this.getCardIdFromBitArray(this.bitArray, 20);

		this.lowerCardName = Cards.GetNameByIndex(this.lowerCardIndex);
		this.upperCardName = Cards.GetNameByIndex(this.upperCardIndex);
		this.fusionCardName = Cards.GetNameByIndex(this.fusionResultIndex);
	}

	public byte[] Bytes
  {
    get
    {
			byte[] bytes = new byte[4];
			this.bitArray.CopyTo(bytes, 0);
			return bytes;
    }
  }

	private void updateBitArray()
	{
		BitArray lowerBits = new BitArray(BitConverter.GetBytes(this.lowerCardIndex));
		BitArray upperBits = new BitArray(BitConverter.GetBytes(this.upperCardIndex));
		BitArray fusionResultBits = new BitArray(BitConverter.GetBytes(this.fusionResultIndex));

		for (int i = 0; i < 30; i++)
    {
			if (i < 10)
      {
				this.bitArray[i] = upperBits[i];
      } else if (i < 20)
      {
				this.bitArray[i] = lowerBits[i - 10];
      } else if (i < 30)
      {
				this.bitArray[i] = fusionResultBits[i - 20];
      }
    } 
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

	public int Index
  {
		get
    {
			return this.index;
    }
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

			if (this.fusionMaterialsNeedReOrdering())
      {
				this.orderFusionMaterials();
				return;
      }

			this.lowerCardName = Cards.GetNameByIndex(this.lowerCardIndex);
			this.updateBitArray();
		}
  }

	private bool fusionMaterialsNeedReOrdering()
  {
		return this.lowerCardIndex > this.upperCardIndex;
	}

	private void orderFusionMaterials()
  {
		if (this.fusionMaterialsNeedReOrdering())
    {
			ushort tempIndex = this.upperCardIndex;
			this.UpperCardIndex = this.lowerCardIndex;
			this.LowerCardIndex = tempIndex;
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

			if (this.fusionMaterialsNeedReOrdering())
			{
				this.orderFusionMaterials();
				return;
			}

			this.upperCardName = Cards.GetNameByIndex(this.upperCardIndex);
			this.updateBitArray();
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
			this.updateBitArray();
		}
	}

	public string FusionCardName
  {
    get
    {
			return this.fusionCardName;
    }
  }

	int index;
	BitArray bitArray;
	ushort lowerCardIndex;
	ushort upperCardIndex;
	ushort fusionResultIndex;

	string lowerCardName;
	string upperCardName;
	string fusionCardName;
}
