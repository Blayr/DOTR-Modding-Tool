using System;
using System.Collections.Generic;
using System.Linq;

public class CardDeckLeaderAbilities
{
	public List<CardDeckLeaderAbility> List = new List<CardDeckLeaderAbility> { };

	public CardDeckLeaderAbilities(byte[][][] byteArray)
	{
		for (int i = 0; i < DataAccess.CardLeaderAbilityCount; i++)
		{
			List.Add(new CardDeckLeaderAbility(i, byteArray[i]));
		}
	}

	public byte[] Bytes
  {
		get
    {
			return this.List.SelectMany((a) => a.Bytes).ToArray();
		}
  }
}

public class CardDeckLeaderAbility
{
	public byte[][] OriginalByteSequence { get; }
	public int Index { get; }
	public string Name { get; }

	public DeckLeaderAbility[] deckLeaderAbilityList = new DeckLeaderAbility[DataAccess.CardLeaderAbilityTypeCount];

	public CardDeckLeaderAbility(int cardIndex, byte[][] bytes)
  {
		this.OriginalByteSequence = bytes;
		this.Index = cardIndex;
		this.Name = Cards.GetNameByIndex((ushort)this.Index);
		DeckLeaderAbilityFactory deckLeaderAbilityCardFactory = new DeckLeaderAbilityFactory();

		for (int i = 0; i < deckLeaderAbilityList.Length; i++)
    {
			this.deckLeaderAbilityList[i] = deckLeaderAbilityCardFactory.GetDeckLeaderAbility(i, bytes[i]);
    }
  }

	public List<DeckLeaderAbility> EnabledAbilityList()
  {
		return this.deckLeaderAbilityList.Where(e => e.Enabled && !e.IsUnusedAbility).ToList();
  }

	public string EnabledAbilitiesString
  {
		get
		{
			List<DeckLeaderAbility> enabledAbilityList = this.EnabledAbilityList();
			List<string> enabledAbiltiesInfo = new List<string>();

			this.EnabledAbilityList().ForEach(a => enabledAbiltiesInfo.Add(a.AbilityDetails()));

			return String.Join(", ", enabledAbiltiesInfo.ToArray());
		}
	}

	public byte[] Bytes
  {
		get
    {
			return this.deckLeaderAbilityList.SelectMany((a) => a.Bytes).ToArray();
		}
  }
}
