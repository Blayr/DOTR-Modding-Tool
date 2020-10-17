using System;

public class RankRequirementDeckLeaderAbility : DeckLeaderAbility
{
	public DeckLeaderRank UnlockRank { get; }

	public RankRequirementDeckLeaderAbility(int index, byte[] bytes) : base(index, bytes)
	{
		if (!this.IsEnabled)
    {
			return;
    }

		if (DeckLeaderAbility.RankRequirementLowerByteAbilityList.Contains((DeckLeaderAbilityType)this.Index))
		{
			this.UnlockRank = new DeckLeaderRank(this.Bytes[0]);
		}

		if (DeckLeaderAbility.RankRequirementUpperByteAbilityList.Contains((DeckLeaderAbilityType)this.Index))
		{
			this.UnlockRank = new DeckLeaderRank(this.Bytes[1]);
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
