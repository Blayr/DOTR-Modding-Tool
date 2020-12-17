using System;

public class DeckLeaderAbilityFactory
{
	public DeckLeaderAbilityFactory()
	{
	}

	public DeckLeaderAbility GetDeckLeaderAbility(int index, byte[] bytes)
  {
		if (DeckLeaderAbility.YesNoAbilityList.Contains((DeckLeaderAbilityType)index))
    {
			return new FlagDeckLeaderAbility(index, bytes);
    }
		else if (DeckLeaderAbility.RankRequirementAbilityList.Contains((DeckLeaderAbilityType)index))
    {
			return new RankRequirementDeckLeaderAbility(index, bytes);
    }

		return new DeckLeaderAbility(index, bytes);
  }
}
