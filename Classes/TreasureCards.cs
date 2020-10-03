using System;
using System.Collections;
using System.Collections.Generic;
using CustomExtensions;

public class TreasureCards
{
	public List<TreasureCard> List = new List<TreasureCard> { };

	public TreasureCards(byte[] bytes)
	{
		for (int i = 0, bi = 0; i < DataAccess.TreasureCardCount; i++, bi += DataAccess.TreasureCardByteSize)
    {
			TreasureCard treasureCard = new TreasureCard(new byte[] { bytes[bi], bytes[bi + 1], bytes[bi + 2], bytes[bi + 3] });
			this.List.Add(treasureCard);
    }
	}
}

public class TreasureCard
{
	byte[] bytes;
	byte duelIndex;
	public BitArray gridLocationBitArray;
	string enemyName;
	ushort cardIndex;
	string cardName;

	public byte Row { get; set; }
	public byte Column { get; set; }

	public ushort CardIndex {
		get
		{
			return this.cardIndex;
		}

		set
		{
			this.cardIndex = value;
			this.cardName = Cards.GetNameByIndex(this.cardIndex);
		}
	}
	public string CardName { 
		get
    {
			return this.cardName;
    }
	}

	public byte EnemyIndex {
		get
    {
			return this.duelIndex;
    }

		set
		{
			this.duelIndex = value;
			this.enemyName = Enemy.GetEnemyNameByIndex(this.duelIndex);
		}
	}
	public string EnemyName {
		get
    {
			return this.enemyName;
    }
	}

	public TreasureCard(byte[] bytes)
	{
		this.bytes = bytes;
		this.duelIndex = bytes[0];
		this.gridLocationBitArray = new BitArray(new byte[] { bytes[1] });
		this.CardIndex =  BitConverter.ToUInt16(new byte[] { bytes[2], bytes[3] }, 0);
		this.EnemyIndex = this.duelIndex;

		this.Row = gridLocationBitArray.toByte(4, 4);
		this.Column = gridLocationBitArray.toByte(0, 4);
	}

	public byte[] Bytes
	{
		get
		{
			byte[] bytes = new byte[4];

			BitArray gridLocationBitArray = new BitArray(8);
			BitArray rowBits = new BitArray(BitConverter.GetBytes(this.Row));
			BitArray columnBits = new BitArray(BitConverter.GetBytes(this.Column));

			gridLocationBitArray[0] = columnBits[0];
			gridLocationBitArray[1] = columnBits[1];
			gridLocationBitArray[2] = columnBits[2];
			gridLocationBitArray[3] = columnBits[3];
			gridLocationBitArray[4] = rowBits[0];
			gridLocationBitArray[5] = rowBits[1];
			gridLocationBitArray[6] = rowBits[2];
			gridLocationBitArray[7] = rowBits[3];

			byte[] tempByteArray = new byte[1];
			gridLocationBitArray.CopyTo(tempByteArray, 0);
			byte gridLocation = tempByteArray[0];

			bytes[0] = this.duelIndex;
			bytes[1] = gridLocation;
			BitConverter.GetBytes(this.cardIndex).CopyTo(bytes, 2);

			return bytes;
		}
	}
}
