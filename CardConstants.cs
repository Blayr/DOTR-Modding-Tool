using DOTR_MODDING_TOOL.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Security.Policy;
using System.Text;

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

	public CardConstant(ushort cardIndex, byte[] bytes)
  {
		this.cardIndex = cardIndex;
		this.name = Cards.GetNameByIndex(cardIndex);
		this.bytes = bytes;
		this.kind = bytes[0];
		this.cardKind = new CardKind(this.kind);
		this.kindOfs = bytes[1];
		this.lvAttr = bytes[2];
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
  }

	public bool AppearsInSlotReels
  {
    get
    {
			return this.appearsInSlotReels;
    }
  }

	public bool AppearsInReincarnation
  {
    get
    {
			return this.appearsInReincarnation;
    }
  }

	public bool PasswordWorks
  {
    get
    {
			return this.passwordWorks;
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