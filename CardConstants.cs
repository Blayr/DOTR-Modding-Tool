using System;
using System.Collections;
using System.Collections.Generic;

public class CardConstants
{
	public List<CardConstant> Constants = new List<CardConstant> { };

	public CardConstants(byte[][] bytes)
	{
		for (ushort i = 0; i < Cards.TotalCardCount; i++)
    {
			Constants.Add(new CardConstant(i, bytes[i]));
    }
	}
}

public class CardConstant
{
	ushort cardIndex;
	string name;
	byte[] bytes;
	byte kind;
	CardKind cardKind;
	byte kindOfs;
	byte lvAttr;
	byte level;
	byte attribute;
	byte deckCost;
	ushort effectId;
	ushort xaxId;
	BitArray apWithFlags;
	ushort attack;
	bool hasAlternateArt;
	bool isSlotRare;
	bool appearsInSlotReels;
	BitArray dpWithFlags;
	ushort defense;
	bool hasImage;
	bool passwordWorks;
	bool appearsInReincarnation;
	byte[] passwordArray;

	public CardConstant(ushort cardIndex, byte[] bytes)
  {
		this.cardIndex = cardIndex;
		this.name = Cards.GetNameByIndex(cardIndex);
		this.bytes = bytes;
		this.kind = bytes[0];
		this.cardKind = new CardKind(this.kind);
		this.kindOfs = bytes[1];
		this.lvAttr = bytes[2];
		this.level = CardConstant.GetLevel(bytes);
		this.attribute = CardConstant.GetAttribute(bytes);
		this.deckCost = bytes[3];
		this.effectId = BitConverter.ToUInt16(new byte[] { bytes[4], bytes[5] }, 0);
		this.xaxId = BitConverter.ToUInt16(new byte[] { bytes[6], bytes[7] }, 0);

		this.apWithFlags = new BitArray(new byte[] { bytes[8], bytes[9] });
		this.attack = CardConstant.GetAttackOrDefense(new byte[] { bytes[8], bytes[9] });
		this.hasImage = apWithFlags[apWithFlags.Length - 3];
		this.passwordWorks = apWithFlags[apWithFlags.Length - 2];
		this.appearsInReincarnation = apWithFlags[apWithFlags.Length - 1];

		this.dpWithFlags = new BitArray(new byte[] { bytes[10], bytes[11] });
		this.defense = CardConstant.GetAttackOrDefense(new byte[] { bytes[10], bytes[11] });
		this.appearsInSlotReels = dpWithFlags[dpWithFlags.Length - 3];
		this.isSlotRare = dpWithFlags[dpWithFlags.Length - 2];
		this.hasAlternateArt = dpWithFlags[dpWithFlags.Length - 1];
		this.passwordArray = new byte[] { bytes[12], bytes[13], bytes[14], bytes[15], bytes[16], bytes[17], bytes[18], bytes[19] };
	}

	public static ushort GetAttackOrDefense(byte[] bytes)
  {
		BitArray bitArray = new BitArray(bytes);
		bitArray[bitArray.Length - 1] = false;
		bitArray[bitArray.Length - 2] = false;
		bitArray[bitArray.Length - 3] = false;
		byte[] newBytes = new byte[2];
		bitArray.CopyTo(newBytes, 0);
		return BitConverter.ToUInt16(newBytes, 0);
	}

	public static byte GetLevel(byte[] bytes)
  {
		BitArray tempBitArray = new BitArray(new byte[] { bytes[2] });
		BitArray halfByteBitArray = new BitArray(4);
		halfByteBitArray[0] = tempBitArray[4];
		halfByteBitArray[1] = tempBitArray[5];
		halfByteBitArray[2] = tempBitArray[6];
		halfByteBitArray[3] = tempBitArray[7];

		byte[] level = new byte[1];
		halfByteBitArray.CopyTo(level, 0);

		return level[0];
  }

	public static byte GetAttribute(byte[] bytes)
	{
		BitArray tempBitArray = new BitArray(new byte[] { bytes[2] });
		BitArray halfByteBitArray = new BitArray(4);
		halfByteBitArray[0] = tempBitArray[0];
		halfByteBitArray[1] = tempBitArray[1];
		halfByteBitArray[2] = tempBitArray[2];
		halfByteBitArray[3] = tempBitArray[3];

		byte[] attribute = new byte[1];
		halfByteBitArray.CopyTo(attribute, 0);

		return attribute[0];
	}

	private byte[] calculateByteSequence()
	{
		byte[] newByteArray = new byte[20];
		newByteArray[0] = this.kind;
		newByteArray[1] = this.kindOfs;
		newByteArray[2] = this.lvAttr;
		newByteArray[3] = this.deckCost;
		newByteArray[4] = BitConverter.GetBytes(this.effectId)[0];
		newByteArray[5] = BitConverter.GetBytes(this.effectId)[1];
		newByteArray[6] = BitConverter.GetBytes(this.xaxId)[0];
		newByteArray[7] = BitConverter.GetBytes(this.xaxId)[1];
		byte[] apWithFlagsByteArray = new byte[2];
		this.apWithFlags.CopyTo(apWithFlagsByteArray, 0);
		newByteArray[8] = apWithFlagsByteArray[0];
		newByteArray[9] = apWithFlagsByteArray[1];
		byte[] dpWithFlagsByteArray = new byte[2];
		this.dpWithFlags.CopyTo(dpWithFlagsByteArray, 0);
		newByteArray[10] = dpWithFlagsByteArray[0];
		newByteArray[11] = dpWithFlagsByteArray[1];
		this.passwordArray.CopyTo(newByteArray, 12);

		return newByteArray;
	}

	public byte[] Bytes
  {
    get
    {
			return this.calculateByteSequence();
    }
  }

	public ushort Index
  {
    get
    {
			return this.cardIndex;
    }
  }

	public string Name
  {
		get
    {
			return this.name;
    }
  }

	public ushort DeckCost
  {
		get
    {
			return this.deckCost;
    }
  }

	public string KindName
  {
    get
    {
			return this.cardKind.Name;
    }
  }

	public ushort EffectId
  {
    get
    {
			return this.effectId;
    }
  }

	public byte Level
  {
    get
    {
			return this.level;
    }
  }

	public byte Attribute
  {
    get
    {
			return this.attribute;
    }
  }

	public ushort Attack
  {
    get
    {
			return this.attack;
    }
  }

	public ushort Defense
  {
    get
    {
			return this.defense;
    }
  }

	public bool IsSlotRare
  {
    get
    {
			return this.isSlotRare;
    }

    set
    {
			this.isSlotRare = value;
			this.dpWithFlags[dpWithFlags.Length - 2] = this.isSlotRare;
		}
  }

	public bool AppearsInSlotReels
  {
    get
    {
			return this.appearsInSlotReels;
    }

    set
    {
			this.appearsInSlotReels = value;
			this.dpWithFlags[this.dpWithFlags.Length - 3] = this.appearsInSlotReels;
    }
  }

	public bool AppearsInReincarnation
  {
    get
    {
			return this.appearsInReincarnation;
    }

    set
    {
			this.appearsInReincarnation = value;
			this.apWithFlags[this.apWithFlags.Length - 1] = this.appearsInReincarnation;
    }
  }

	public bool PasswordWorks
  {
    get
    {
			return this.passwordWorks;
    }

    set
    {
			this.passwordWorks = value;
			this.apWithFlags[apWithFlags.Length - 2] = this.passwordWorks;
    }
  }

	public bool HasImage
  {
    get
    {
			return this.hasImage;
    }
  }

	public bool HasAlternateArt
  {
    get
    {
			return this.hasAlternateArt;
    }
  }
}