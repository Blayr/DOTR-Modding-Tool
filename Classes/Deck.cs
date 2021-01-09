using System;
using System.Collections.Generic;

public class Deck
{
  public int Index { get; }
  public DeckCard DeckLeader { get; set; }
  public List<DeckCard> CardList { get; set; }

  public Deck()
  {
    CardList = new List<DeckCard> { };
  }

  public Deck(int index, byte[][] bytes)
  {
    Index = index;
    DeckLeader = new DeckCard(bytes[0]);
    CardList = new List<DeckCard> { };

    for (int cardIndex = 1; cardIndex <= 40; cardIndex++)
    {
      DeckCard deckCard = new DeckCard(bytes[cardIndex]);
      CardList.Add(deckCard);
    }
  }

  public override string ToString()
  {
    return DeckLeader.CardConstant.Name;
  }

  public static List<Deck> LoadDeckListFromBytes(byte[][][] bytes)
  {
    List<Deck> deckList = new List<Deck> { };

    for (int deckIndex = 0; deckIndex < bytes.Length; deckIndex++)
    {
      Deck deck = new Deck(deckIndex, bytes[deckIndex]);
      deckList.Add(deck);
    }

    return deckList;
  }

  public void Save(DataAccess dataAccess)
  {
    if (DeckLeader == null)
    {
      throw new InvalidOperationException("Deck must have a deck leader.");
    }

    if (CardList.Count != 40)
    {
      throw new InvalidOperationException("Deck must have 40 cards.");
    }

    dataAccess.SaveDeck(Index, Bytes);
  }

  public byte[] Bytes
  {
    get
    {
      byte[] byteArray = new byte[DataAccess.DeckCardCount * DataAccess.DeckCardByteCount];
      DeckLeader.Bytes.CopyTo(byteArray, 0);

      for (int cardIndex = 0; cardIndex < CardList.Count; cardIndex++)
      {
        byte[] deckCardBytes = CardList[cardIndex].Bytes;
        deckCardBytes.CopyTo(byteArray, (1 + cardIndex) * DataAccess.DeckCardByteCount);
      }

      return byteArray;
    }
  }
}