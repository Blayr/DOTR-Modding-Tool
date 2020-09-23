using System;
using System.Runtime.InteropServices;

public class CardKind
{
	public static CardKindMap[] Kinds = {
		new CardKindMap(0, "Dragon"),
		new CardKindMap(1, "Spellcaster"),
		new CardKindMap(2, "Zombie"),
		new CardKindMap(3, "Warrior"),
		new CardKindMap(4, "Beast-Warrior"),
		new CardKindMap(5, "Beast"),
		new CardKindMap(6, "Winged-Beast"),
		new CardKindMap(7, "Fiend"),
		new CardKindMap(8, "Fairy"),
		new CardKindMap(9, "Insect"),
		new CardKindMap(10, "Dinosaur"),
		new CardKindMap(11, "Reptile"),
		new CardKindMap(12, "Fish"),
		new CardKindMap(13, "Sea Serpent"),
		new CardKindMap(14, "Machine"),
		new CardKindMap(15, "Thunder"),
		new CardKindMap(16, "Aqua"),
		new CardKindMap(17, "Pyro"),
		new CardKindMap(18, "Rock"),
		new CardKindMap(19, "Plant"),
		new CardKindMap(20, "Immortal"),
		new CardKindMap(32, "Magic"),
		new CardKindMap(64, "Power Up"),
		new CardKindMap(96, "Trap (Limited Range)"),
		new CardKindMap(128, "Trap (Full Range)"),
		new CardKindMap(160, "Ritual")
	};

	public CardKind(byte cardKindId)
	{
		this.cardKindId = cardKindId;
		this.cardKindName = Array.Find(CardKind.Kinds, kind => kind.ID == this.cardKindId).Name;
	}

	public bool isMonster()
  {
		return this.cardKindId < 32;
  }

	public byte ID
  {
    get
    {
			return this.cardKindId;
    }
  }

	public string Name
  {
    get
    {
			return this.cardKindName;
    }
  }

	private byte cardKindId;
	private string cardKindName;
}

public class CardKindMap
{
	public CardKindMap(byte id, string name)
  {
		this.ID = id;
		this.Name = name;
  }

	public byte ID;
	public string Name;
}
