using System;

public class RankRequirementDeckLeaderAbility : DeckLeaderAbility
{
	protected DeckLeaderRank unlockRank;
	protected RankRequirementByteLocation rankRequirementHalfByteLocation;
	public DeckLeaderRank UnlockRank
	{
		get
		{
			return unlockRank;
		}

		set
		{
			this.unlockRank = value;

			if (this.rankRequirementHalfByteLocation == RankRequirementByteLocation.LOWER_BYTE)
			{
				this.Bytes[0] = Convert.ToByte(value.Index);
			}
			else
			{
				this.Bytes[1] = Convert.ToByte(value.Index);
			}
		}
	}
	public override bool Enabled
  {
		get
    {
			return this.enabled;
    }
		
		set
    {
			this.enabled = value;

			if (value == false)
      {
				this.Bytes = BitConverter.GetBytes(DisabledBytesValue);
      }
    }
  }
	public RankRequirementDeckLeaderAbility(int index, byte[] bytes) : base(index, bytes)
	{
		if (DeckLeaderAbility.RankRequirementLowerByteAbilityList.Contains((DeckLeaderAbilityType)index))
    {
			this.rankRequirementHalfByteLocation = RankRequirementByteLocation.LOWER_BYTE;
		} else if (DeckLeaderAbility.RankRequirementUpperByteAbilityList.Contains((DeckLeaderAbilityType)index))
    {
			this.rankRequirementHalfByteLocation = RankRequirementByteLocation.UPPER_BYTE;
    }

		if (!this.Enabled)
    {
			return;
    }

		if (this.rankRequirementHalfByteLocation == RankRequirementByteLocation.LOWER_BYTE)
		{
			this.unlockRank = new DeckLeaderRank(this.Bytes[0]);
		}

		if (this.rankRequirementHalfByteLocation == RankRequirementByteLocation.UPPER_BYTE)
		{
			this.unlockRank = new DeckLeaderRank(this.Bytes[1]);
		}
	}

	public override string ToString()
	{
		if (this.UnlockRank != null)
		{
			return $"{this.Name} - {this.UnlockRank.Name}";
		}

		return this.Name;
	}
}

public enum RankRequirementByteLocation : ushort
{
	UPPER_BYTE = 1,
	LOWER_BYTE = 2
}
