using System.IO;

public class DataAccess
{
  public static readonly int SLUSDeckLeaderRankThresholdsByteOffset = 2754898;
  public static readonly int DeckLeaderRankThresholdByteLength = 24;
  public static readonly int SLUSCardConstantsByteOffset = 2683264;
  public static readonly int SLUSFusionListByteOffset = 2550064;
  public static readonly int FusionListByteLength = 26540 * 4;
  public static readonly int CardConstantByteLength = 20;
  public static readonly int CardConstantCount = Cards.TotalCardCount;
  public static readonly int EnemyAIByteOffset = 2666416;
  public static readonly int EnemyAIByteLength = 4;
  public static readonly int EnemyAiCount = 32;
  public static readonly int TreasureCardByteOffset = 2755024;
  public static readonly int TreasureCardByteSize = 4;
  public static readonly int TreasureCardCount = 22;
  public static readonly int CardLeaderAbilitiesOffset = 0x293438;
  public static readonly int CardLeaderAbilityCount = 683;
  public static readonly int CardLeaderAbilityTypeCount = 20;
  public static readonly int CardLeaderAbilityByteSize = 2;
  public static readonly int MonsterEquipCardCompatabilityOffset = 0x26D680;
  public static readonly int MonsterEquipCardCompabilityCardCount = 687;
  public static readonly int MonsterEquipCardCompabilityByteSize = 7;

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
        fileStream.Seek(DataAccess.SLUSCardConstantsByteOffset + cardIndexOffset, SeekOrigin.Begin);
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
      fileStream.Seek(DataAccess.SLUSCardConstantsByteOffset, SeekOrigin.Begin);
      fileStream.Write(byteData, 0, byteData.Length);
    }

    return this.LoadCardConstantData();
  }

  public byte[] LoadLeaderTresholdData()
  {
    byte[] buffer = new byte[24];

    lock (FileStreamLock)
    {
      fileStream.Seek(DataAccess.SLUSDeckLeaderRankThresholdsByteOffset, SeekOrigin.Begin);
      fileStream.Read(buffer, 0, buffer.Length);
    }

    return buffer;
  }

  public byte[] SetDeckLeaderTresholds(byte[] byteData)
  {
    lock (FileStreamLock)
    {
      fileStream.Seek(DataAccess.SLUSDeckLeaderRankThresholdsByteOffset, SeekOrigin.Begin);
      fileStream.Write(byteData, 0, DataAccess.DeckLeaderRankThresholdByteLength);
    }

    return this.LoadLeaderTresholdData();
  }

  public byte[] LoadFusionData()
  {
    byte[] buffer = new byte[DataAccess.FusionListByteLength];

    lock (FileStreamLock)
    {
      fileStream.Seek(DataAccess.SLUSFusionListByteOffset, SeekOrigin.Begin);
      fileStream.Read(buffer, 0, buffer.Length);
    }

    return buffer;
  }

  public void SaveFusionData(byte[] byteData)
  {
    lock (FileStreamLock)
    {
      fileStream.Seek(DataAccess.SLUSFusionListByteOffset, SeekOrigin.Begin);
      fileStream.Write(byteData, 0, byteData.Length);
    }
  }

  public byte[] LoadEnemyAIData()
  {
    byte[] buffer = new byte[DataAccess.EnemyAIByteLength * DataAccess.EnemyAiCount];

    lock (FileStreamLock)
    {
      fileStream.Seek(DataAccess.EnemyAIByteOffset, SeekOrigin.Begin);
      fileStream.Read(buffer, 0, buffer.Length);
    }

    return buffer;
  }

  public void SaveEnemyAiData(byte[] byteData)
  {
    lock (FileStreamLock)
    {
      fileStream.Seek(DataAccess.EnemyAIByteOffset, SeekOrigin.Begin);
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

