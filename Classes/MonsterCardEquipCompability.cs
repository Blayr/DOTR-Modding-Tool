using CustomExtensions;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

public class MonsterCardEquipCompatibilities {
	public MonsterCardEquipCompatibilities(byte[][] byteArray)
  {
		for (int cardIndex = Cards.MonsterCardStartIndex; cardIndex <= Cards.MonsterCardEndIndex; cardIndex++)
    {
			this.List.Add(new MonsterCardEquipCompability(cardIndex, byteArray[cardIndex]));
    }
  }

	public byte[] Bytes
  {
		get
    {
			return this.List.SelectMany(ce => ce.Bytes).ToArray();
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
		int flagCount = Cards.EquipCardCount;
		flagCount += 2; // Unused flag and Powered up on toon terrain

		for (int i = 0; i < flagCount; i++)
    {
			this.CardEquipCompabilityFlags.Add(new CardEquipCompabilityFlag(i, bitArray[i]));
    }
	}

	public override string ToString()
  {
		return this.Name;
  }

	private List<CardEquipCompabilityFlag> compatibleEquipList()
  {
		return this.CardEquipCompabilityFlags.Where(ce => ce.Enabled == true).ToList();
	}

	public int Index { get; }
	public string Name { get; }
	public int CompatibleEquipCount
  {
		get
    {
			return this.compatibleEquipList().Count();
		}
  }
	public string CompatibleEquipNames
	{
		get
		{
			
			string[] compatibleEquipNameArray = this.compatibleEquipList().Select(ce => ce.Name).ToArray();
			return string.Join(", ", compatibleEquipNameArray);
		}
	}

	private byte[] bytes;

	public byte[] Bytes
  {
		get
    {
			BitArray bitArray = new BitArray(this.bytes);

			for (int i = 0; i < this.CardEquipCompabilityFlags.Count; i++)
      {
				bitArray[i] = CardEquipCompabilityFlags[i].Enabled;
      }

			this.bytes = bitArray.ToByteArray();

			return this.bytes;
    }
  }

	public List<CardEquipCompabilityFlag> CardEquipCompabilityFlags = new List<CardEquipCompabilityFlag> { };
}

public class CardEquipCompabilityFlag {
	public CardEquipCompabilityFlag(int flagIndex, bool flagValue)
  {
		this.Index = flagIndex;

		if (flagIndex <= Cards.EquipCardCount)
    {
			this.Name = Cards.GetNameByIndex((ushort)(Cards.EquipCardStartIndex + flagIndex));
		} else if (flagIndex == 49)
    {
			this.Name = "(Powered up in Toon Terrain)";
		}

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
