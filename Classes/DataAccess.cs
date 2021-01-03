using System.IO;

public class DataAccess
{
  public const int DeckLeaderRankThresholdsByteOffset = 2754898;
  public const int DeckLeaderRankThresholdByteLength = 24;
  public const int CardConstantsByteOffset = 2683264;
  public const int FusionListByteOffset = 2550064;
  public const int FusionListByteLength = 26540 * 4;
  public const int CardConstantByteLength = 20;
  public const int CardConstantCount = Cards.TotalCardCount;
  public const int EnemyAiByteOffset = 2666416;
  public const int EnemyAiByteLength = 4;
  public const int EnemyAiCount = 32;
  public const int TreasureCardByteOffset = 2755024;
  public const int TreasureCardByteSize = 4;
  public const int TreasureCardCount = 22;
  public const int CardLeaderAbilitiesOffset = 0x293438;
  public const int CardLeaderAbilityCount = 683;
  public const int CardLeaderAbilityTypeCount = 20;
  public const int CardLeaderAbilityByteSize = 2;
  public const int MonsterEquipCardCompatabilityOffset = 0x26D680;
  public const int MonsterEquipCardCompabilityCardCount = 687;
  public const int MonsterEquipCardCompabilityByteSize = 7;

  private static readonly object FileStreamLock = new object();
	private static FileStream fileStream;

	public DataAccess()
	{
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

