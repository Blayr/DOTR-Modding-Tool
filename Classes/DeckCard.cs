using System;

public class DeckCard
{
  private CardConstant cardConstant;
  private DeckLeaderRank rank;
  public string CardName
  {
    get
    {
      return CardConstant.Name;
    }
  }
  public byte[] Bytes;

  public DeckCard(byte[] cardBytes)
  {
    Bytes = cardBytes;
    ushort value = BitConverter.ToUInt16(cardBytes, 0);
    rank = new DeckLeaderRank(value >> 12);
    ushort cardNumber = (ushort)(((cardBytes[1] & 0x0F) << 8) + cardBytes[0]);
    CardConstant = CardConstant.List[cardNumber];
  }

  public DeckCard(CardConstant cardConstant, DeckLeaderRank deckLeaderRank)
  {
    CardConstant = cardConstant;
    Rank = deckLeaderRank;

    Bytes = calculateBytes(CardConstant, Rank);
  }

  public DeckLeaderRank Rank
  {
    get
    {
      return rank;
    }

    set
    {
      rank = value;
      calculateBytes(CardConstant, Rank);
    }
  }

  public CardConstant CardConstant
  {
    get
    {
      return cardConstant;
    }

    set
    {
      cardConstant = value;
      calculateBytes(CardConstant, Rank);
    }
  }

  public override string ToString()
  {
    return CardConstant.Name;
  }

  private static byte[] calculateBytes(CardConstant cardConstant, DeckLeaderRank Rank)
  {
    ushort newValue = (ushort)((cardConstant.Index & 0xFFF) | (((ushort)Rank.Index & 0xF) << 12));
    return BitConverter.GetBytes(newValue);
  }
}
