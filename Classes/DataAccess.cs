using System.IO;

public class DataAccess
{
  public const int DeckLeaderRankThresholdsByteOffset = 0x2A0952;
  public const int DeckLeaderRankThresholdByteLength = 24;
  public const int CardConstantsByteOffset = 0x28F180;
  public const int FusionListByteOffset = 0x26E930;
  public const int FusionListByteLength = 26540 * 4;
  public const int CardConstantByteLength = 20;
  public const int CardConstantCount = Cards.TotalCardCount;
  public const int EnemyAiByteOffset = 0x28AFB0;
  public const int EnemyAiByteLength = 4;
  public const int EnemyAiCount = 32;
  public const int TreasureCardByteOffset = 0x2A09D0;
  public const int TreasureCardByteSize = 4;
  public const int TreasureCardCount = 22;
  public const int CardLeaderAbilitiesOffset = 0x293438;
  public const int CardLeaderAbilityCount = 683;
  public const int CardLeaderAbilityTypeCount = 20;
  public const int CardLeaderAbilityByteSize = 2;
  public const int MonsterEquipCardCompatabilityOffset = 0x26D680;
  public const int MonsterEquipCardCompabilityCardCount = 687;
  public const int MonsterEquipCardCompabilityByteSize = 7;
  public const int DeckByteOffset = 0x2A0A70;
  public const int DeckCount = 51;
  public const int DeckCardCount = 41;
  public const int DeckCardByteCount = 2;

  private static readonly object FileStreamLock = new object();
	private static FileStream fileStream;

	public DataAccess()
	{
	}

  public void SaveDeck(int deckIndex, byte[] bytes)
  {
    int deckBytesLocation = (DeckByteOffset) + deckIndex * DeckCardCount * DeckCardByteCount;

    lock (FileStreamLock)
    {
      fileStream.Seek(deckBytesLocation, SeekOrigin.Begin);
      fileStream.Write(bytes, 0, bytes.Length);
    }
  }

  public byte[][][] LoadDecks()
  {
    byte[][][] allDeckBytes = new byte[DeckCount][][];
    byte[] buffer = new byte[DeckCount * DeckCardCount * DeckCardByteCount];

    lock (FileStreamLock)
    {
      fileStream.Seek(DeckByteOffset, SeekOrigin.Begin);
      fileStream.Read(buffer, 0, buffer.Length);
    }

    for (int deckIndex = 0; deckIndex < DeckCount; deckIndex++)
    {
      allDeckBytes[deckIndex] = new byte[DeckCardCount][];

      for (int cardIndex = 0; cardIndex < DeckCardCount; cardIndex++)
      {
        int cardByteStartLocation = (deckIndex * (DeckCardCount * DeckCardByteCount)) + (cardIndex * DeckCardByteCount);
        allDeckBytes[deckIndex][cardIndex] = new byte[] { buffer[cardByteStartLocation], buffer[cardByteStartLocation + 1] };
      }
    }

    return allDeckBytes;
  }

  public byte[][] LoadMonsterEquipCardCompability()
  {
    byte[][] monsterEquipCardCompabilityBytes= new byte[MonsterEquipCardCompabilityCardCount][];

    lock (FileStreamLock)
    {
      for (int cardIndex = 0; cardIndex < MonsterEquipCardCompabilityCardCount; cardIndex++)
      {
        byte[] buffer = new byte[MonsterEquipCardCompabilityByteSize];
        int offset = MonsterEquipCardCompatabilityOffset + (cardIndex * MonsterEquipCardCompabilityByteSize);
        fileStream.Seek(offset, SeekOrigin.Begin);
        fileStream.Read(buffer, 0, buffer.Length);
        monsterEquipCardCompabilityBytes[cardIndex] = buffer;
      }
    }

    return monsterEquipCardCompabilityBytes;
  }

  public void SetMonsterEquipCardCompatibility(byte[] byteData)
  {
    lock (FileStreamLock)
    {
      fileStream.Seek(DataAccess.MonsterEquipCardCompatabilityOffset, SeekOrigin.Begin);
      fileStream.Write(byteData, 0, byteData.Length);
    }
  }

  public void SaveCardDeckLeaderAbilities(byte[] byteData)
  {
    lock (FileStreamLock)
    {
      fileStream.Seek(DataAccess.CardLeaderAbilitiesOffset, SeekOrigin.Begin);
      fileStream.Write(byteData, 0, byteData.Length);
    }
  }

  public byte[][][] LoadCardDeckLeaderAbilities()
  {
    byte[][][] cardLeaderAbilitiesBytes = new byte[CardLeaderAbilityCount][][];

    lock (FileStreamLock)
    {
      for (int cardIndex = 0; cardIndex < CardLeaderAbilityCount; cardIndex++)
      {
        cardLeaderAbilitiesBytes[cardIndex] = new byte[CardLeaderAbilityTypeCount][];

        for (int abilityTypeIndex = 0; abilityTypeIndex < CardLeaderAbilityTypeCount; abilityTypeIndex++)
        {
          byte[] buffer = new byte[CardLeaderAbilityByteSize];
          int cardIndexOffset = (cardIndex * (CardLeaderAbilityTypeCount* CardLeaderAbilityByteSize)) + (abilityTypeIndex * CardLeaderAbilityByteSize);
          fileStream.Seek(DataAccess.CardLeaderAbilitiesOffset + cardIndexOffset, SeekOrigin.Begin);
          fileStream.Read(buffer, 0, buffer.Length);
          cardLeaderAbilitiesBytes[cardIndex][abilityTypeIndex] = buffer;
        }
      }
    }

    return cardLeaderAbilitiesBytes;
  }

  public void OpenIso(string filePath)
  {
    if (fileStream != null)
    {
      fileStream.Dispose();
    }

    fileStream = new FileStream(filePath, FileMode.Open);
  }

  public byte[][] LoadCardConstantData()
  {
    byte[][] cardConstantsBytes = new byte[CardConstantCount][];

    lock (FileStreamLock)
    {
      for (int cardIndex = 0; cardIndex < CardConstantCount; cardIndex++)
      {
        byte[] buffer = new byte[CardConstantByteLength];
        int cardIndexOffset = CardConstantByteLength * cardIndex;
        fileStream.Seek(DataAccess.CardConstantsByteOffset + cardIndexOffset, SeekOrigin.Begin);
        fileStream.Read(buffer, 0, buffer.Length);
        cardConstantsBytes[cardIndex] = buffer;
      }
    }

    return cardConstantsBytes;
  }

  public byte[][] SetCardConstantData(byte[] byteData)
  {
    lock (FileStreamLock)
    {
      fileStream.Seek(DataAccess.CardConstantsByteOffset, SeekOrigin.Begin);
      fileStream.Write(byteData, 0, byteData.Length);
    }

    return this.LoadCardConstantData();
  }

  public byte[] LoadLeaderTresholdData()
  {
    byte[] buffer = new byte[24];

    lock (FileStreamLock)
    {
      fileStream.Seek(DataAccess.DeckLeaderRankThresholdsByteOffset, SeekOrigin.Begin);
      fileStream.Read(buffer, 0, buffer.Length);
    }

    return buffer;
  }

  public byte[] SetDeckLeaderTresholds(byte[] byteData)
  {
    lock (FileStreamLock)
    {
      fileStream.Seek(DataAccess.DeckLeaderRankThresholdsByteOffset, SeekOrigin.Begin);
      fileStream.Write(byteData, 0, DataAccess.DeckLeaderRankThresholdByteLength);
    }

    return this.LoadLeaderTresholdData();
  }

  public byte[] LoadFusionData()
  {
    byte[] buffer = new byte[DataAccess.FusionListByteLength];

    lock (FileStreamLock)
    {
      fileStream.Seek(DataAccess.FusionListByteOffset, SeekOrigin.Begin);
      fileStream.Read(buffer, 0, buffer.Length);
    }

    return buffer;
  }

  public void SaveFusionData(byte[] byteData)
  {
    lock (FileStreamLock)
    {
      fileStream.Seek(DataAccess.FusionListByteOffset, SeekOrigin.Begin);
      fileStream.Write(byteData, 0, byteData.Length);
    }
  }

  public byte[] LoadEnemyAIData()
  {
    byte[] buffer = new byte[DataAccess.EnemyAiByteLength * DataAccess.EnemyAiCount];

    lock (FileStreamLock)
    {
      fileStream.Seek(DataAccess.EnemyAiByteOffset, SeekOrigin.Begin);
      fileStream.Read(buffer, 0, buffer.Length);
    }

    return buffer;
  }

  public void SaveEnemyAiData(byte[] byteData)
  {
    lock (FileStreamLock)
    {
      fileStream.Seek(DataAccess.EnemyAiByteOffset, SeekOrigin.Begin);
      fileStream.Write(byteData, 0, byteData.Length);
    }
  }

  public byte[] GetTreasureCardData()
  {
    byte[] buffer = new byte[DataAccess.TreasureCardByteSize * DataAccess.TreasureCardCount];

    lock (FileStreamLock)
    {
      fileStream.Seek(DataAccess.TreasureCardByteOffset, SeekOrigin.Begin);
      fileStream.Read(buffer, 0, buffer.Length);
    }

    return buffer;
  }

  public void SaveTreasureCard(int index, byte[] treasureCardBytes)
  {
    int writeOffset = DataAccess.TreasureCardByteOffset + (index * DataAccess.TreasureCardByteSize);

    lock (FileStreamLock)
    {
      fileStream.Seek(writeOffset, SeekOrigin.Begin);
      fileStream.Write(treasureCardBytes, 0, DataAccess.TreasureCardByteSize);
    }
  }
}

