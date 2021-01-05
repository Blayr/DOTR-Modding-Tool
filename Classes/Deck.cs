using System.Collections.Generic;

public class Deck
{
  public DeckCard DeckLeader { get; set; }
  public List<DeckCard> CardList { get; set; }

  public Deck()
  {
    CardList = new List<DeckCard> { };
  }

  public Deck(byte[][] bytes)
  {
    DeckLeader = new DeckCard(bytes[0]);
    CardList = new List<DeckCard> { };

    for (int cardIndex = 1; cardIndex <= 40; cardIndex++)
    {
      DeckCard deckCard = new DeckCard(bytes[cardIndex]);
      CardList.Add(deckCard);
    }
  }

  public void AddCard(DeckCard deckCard)
  {
    if (CardList.Count == 40)
    {
      return;
    }

    CardList.Add(deckCard);
  }

  public void RemoveCard(DeckCard deckCard)
  {
    // Stub
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
      Deck deck = new Deck(bytes[deckIndex]);
      deckList.Add(deck);
    }

    return deckList;
  }
}