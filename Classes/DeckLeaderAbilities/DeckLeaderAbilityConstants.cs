public class DeckLeaderAbilityInfo
{
  public readonly static string[][] NameAndDescriptions;

  static DeckLeaderAbilityInfo()
  {
		NameAndDescriptions = new string[20][];

		for (int i = 0; i < NameAndDescriptions.Length; i++)
    {
			NameAndDescriptions[i] = new string[] { "???", "?????????" };
    }

		NameAndDescriptions[(int)DeckLeaderAbilityType.HiddenCard] = new string[] {
			"Hidden Card",
			"Gains the ability to find hidden cards found on the campaign map. At lower ranks," +
			"only finds card if directly on top of them. At higher ranks, the range is increased by 1 in each direction."
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.ExtraSlots] = new string[] {
			"Extra Slots",
			"Enables multiple angles to win 3-in-a-row in card slots."
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.DestinyDraw] = new string[] {
			"Destiny Draw",
			"Gives chance to draw a special card when LP are 500 or lower (Once per duel)."
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.IncreasedMovement] = new string[] {
			"Increased movement",
			"Deck leader can move 2 squares at a time instead of 1."
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.LPRecovery] = new string[] {
			"LP Recovery",
			"Restore 50 lifepoints at the start of every turn."
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.DirectDamageHalved] = new string[] {
			"Direct damage halved",
			"Only take half damage from direct attacks."
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.TerrainChange] = new string[] {
			"Terrain change",
			"When the deck leader moves onto a tile, the terrain is transformed to the specified type."
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.LevelCostReduction] = new string[] {
			"Level cost reduction",
			"Summoning cost for same type friendlies is reduced (1-2, depending on rank)"
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.ExtendedSupportRange] = new string[] {
			"Extended support range",
			"Extends the range of other deck leader abilities such as increased strength for same type friendlies."
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.FriendlyIncreasedStrength] = new string[] {
			"Improved strength for same type friendlies",
			"Improves the attack points for same type friendlies (100-500 points depending on card level)."
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.FriendlyImprovedResistance] = new string[] {
			"Improved resistance for same type friendlies",
			"Any of your creatures of the same type and within your Deck Leader's range will be immune to enemy traps, spells and creature abilities."
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.FriendlyMovementBoost] = new string[] {
			"Movement boost for same type friendlies",
			"Boosts movement for same type friendlies by 1 (does not stack with other movement bonuses)."
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.FlipCard] = new string[] {
			"Open opponent's card",
			"Flips up enemy cards within the deck leader's support range."
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.WeakenSpecificEnemyType] = new string[] {
			"Weaken specific enemy type",
			"Weakens monsters of the specific enemy type by 100-500 depending on level."
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.SpellbindSpecificEnemyType] = new string[] {
			"Spellbind specific enemy type",
			"Spellbind specific enemy type for 1(?) turn."
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.DestroySpecificEnemyType] = new string[] {
			"Destroy specific enemy type",
			"Destroy specific enemy type."
		};
	}
}
