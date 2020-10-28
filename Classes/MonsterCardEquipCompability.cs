using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Windows.Forms;

public class MonsterCardEquipCompatibilities {
	public MonsterCardEquipCompatibilities(byte[][] byteArray)
  {
		for (int cardIndex = Cards.MonsterCardStartIndex; cardIndex <= Cards.MonsterCardEndIndex; cardIndex++)
    {
			this.List.Add(new MonsterCardEquipCompability(cardIndex, byteArray[cardIndex]));
    }
  }

	public List<MonsterCardEquipCompability> List = new List<MonsterCardEquipCompability> { };
}

public class MonsterCardEquipCompability
{
	public MonsterCardEquipCompability(int cardIndex, byte[] byteArray)
	{
		this.bytes = byteArray;
		BitArray bitArray = new BitArray(this.bytes);
		this.Index = cardIndex;
		this.Name = Cards.GetNameByIndex((ushort)cardIndex);
		int equipFlagCount = Cards.EquipCardEndIndex - Cards.EquipCardStartIndex;

		for (int i = 0; i < equipFlagCount; i++)
    {
			this.CardEquipCompabilityFlags.Add(new CardEquipCompabilityFlag(i, bitArray[i]));
    }
	}

	public override string ToString()
  {
		return this.Name;
  }

	public int Index { get; }
	public string Name { get; }

	public string CompatibleEquipNames
	{
		get
		{
			List<CardEquipCompabilityFlag> compatibleEquipList = this.CardEquipCompabilityFlags.Where(ce => ce.Enabled == true).ToList();
			string[] compatibleEquipNameArray = compatibleEquipList.Select(ce => ce.Name).ToArray();
			return string.Join(", ", compatibleEquipNameArray);
		}
	}

	private byte[] bytes;

	public byte[] Bytes
  {
		get
    {
			return this.bytes;
    }
  }

	public List<CardEquipCompabilityFlag> CardEquipCompabilityFlags = new List<CardEquipCompabilityFlag> { };
}

public class CardEquipCompabilityFlag {
	public CardEquipCompabilityFlag(int flagIndex, bool flagValue)
  {
		this.Index = flagIndex;
		this.Name = Cards.GetNameByIndex((ushort)(Cards.EquipCardStartIndex + flagIndex));
		this.Enabled = flagValue;
	}

	public override string ToString()
  {
		return $"#{this.Name}: #{this.Enabled}";
  }

	public int Index { get; }
	public string Name { get; }
	public bool Enabled { get; set; }
}
