using DOTR_MODDING_TOOL.Properties;
using System;
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
	byte deckCost;
	ushort effectId;
	ushort xaxId;

	//// u8 kind;
	//// u8 kindOfs;
	//// u8 lvAttr;
	//// u8 deckCost;
	//// u16 effectId;
	//// u16 xaxId;
	//// u16 apWithFlags;
	//// u16 dpWithFlags;

	public CardConstant(ushort cardIndex, byte[] bytes)
  {
		this.cardIndex = cardIndex;
		this.bytes = bytes;
		this.kind = bytes[0];
		this.cardKind = new CardKind(this.kind);
		this.kindOfs = bytes[1];
		this.lvAttr = bytes[2];
		this.deckCost = bytes[3];
		this.effectId = BitConverter.ToUInt16(new byte[] { bytes[4], bytes[5] }, 0);
		this.xaxId = BitConverter.ToUInt16(new byte[] { bytes[4], bytes[5] }, 0);
		this.name = Cards.GetNameByIndex(cardIndex);
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

	public byte Kind
  {
    get
    {
			return this.kind;
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
}