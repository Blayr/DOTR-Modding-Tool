﻿public class DeckLeaderAbilityInfo
{
  public readonly static string[][] NameAndDescriptions;

  static DeckLeaderAbilityInfo()
  {
		NameAndDescriptions = new string[20][];

		for (int i = 0; i < NameAndDescriptions.Length; i++)
    {
			NameAndDescriptions[i] = new string[] { "???", "?????????", null };
    }

		NameAndDescriptions[(int)DeckLeaderAbilityType.HiddenCard] = new string[] {
			"Hidden Card",
			"Gains the ability to find hidden cards found on the campaign map. At lower ranks, " +
			"only finds card if directly on top of them. At higher ranks, the range is increased by 1 in each direction."
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.ExtraSlots] = new string[] {
			"Extra Slots",
			"Enables multiple angles to win 3-in-a-row in card slots."
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.DestinyDraw] = new string[] {
			"Destiny Draw",
			"Gives chance to draw a special card when LP are 1000 or lower (once per duel)."
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.IncreasedMovement] = new string[] {
			"Increased movement",
			"Deck leader can move 2 squares at a time instead of 1."
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.LPRecovery] = new string[] {
			"LP Recovery",
			"Restore 50 lifepoints at the end of every turn."
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.DirectDamageHalved] = new string[] {
			"Direct Damage Halved",
			"Only take half damage from direct attacks."
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.TerrainChange] = new string[] {
			"Terrain Change",
			@"When the deck leader moves onto a tile, the terrain is transformed to the specified type.
The logic for determining what the terrain is actually transformed into is hardcoded and can't be changed with this tool.

Spellcaster -> Dark
Fiend -> Dark
Insect -> Forest
Dinosaur -> Wasteland
Aqua -> Sea
Immortal -> Crush
All other types -> Dark"
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.LevelCostReduction] = new string[] {
			"Level Cost Reduction",
			@"Summoning cost for same type friendlies is reduced (1-2, depending on rank).

The logic is hardcoded and can't be changed with this tool.
Reduction depends on the leader’s kind and level as follows:

Immortal -> always 1
Beast-Warrior, Sea Serpent -> 2 if level is at least 6, else 1
Dragon, Winged Beast, Fish, Machine -> 2 if level is at least 7, else 1."
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.ExtendedSupportRange] = new string[] {
			"Extended Support Range",
			"Extends the range of other deck leader abilities such as increased strength for same type friendlies."
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.FriendlyIncreasedStrength] = new string[] {
			"Improved Strength For Same Type Friendlies",
			"Improves the attack points for same type friendlies (100-500 points depending on card level)."
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.FriendlyImprovedResistance] = new string[] {
			"Improved Resistance For Same Type Friendlies",
			"Any of your creatures of the same type and within your Deck Leader's range will be immune to enemy traps, spells and creature abilities."
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.FriendlyMovementBoost] = new string[] {
			"Movement Boost For Same Type friendlies",
			"Boosts movement for same type friendlies by 1 (does not stack with other movement bonuses)."
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.FlipCard] = new string[] {
			"Open Opponent's Card",
			"Flips up enemy cards within the deck leader's support range."
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.WeakenSpecificEnemyType] = new string[] {
			"Weaken Specific Enemy Type",
			@"Weakens monsters of the specific enemy type by 100-500 depending on level.

The logic regarding what type powers down what type is hardcoded.

Spellcaster powers down Fiend.
Zombie powers down Warrior.
Warrior powers down Dragon and Spellcaster.
Beast powers down Fish.
Winged-Beast powers down Insect and Fish.
Fiend powers down Spellcaster.
Insect powers down Sea Serpent.
Reptile powers down Beast and Winged-Beast.
Fish powers down Thunder.
Thunder powers down Zombie and Machine.
Aqua powers down Machine and Pyro.
Pyro powers down Beast-Warrior."
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.SpellbindSpecificEnemyType] = new string[] {
			"Spellbind Specific Enemy Type",
			@"Spellbind specific enemy type for 1(?) turn.

This logic is hardcoded, and can't be changed by this tool.

Fairy destroys Fiend.
Reptile destroys Insect.
Pyro destroys Zombie and Plant.
Rock destroys Dinosaur.
Plant destroys Rock."
		};

		NameAndDescriptions[(int)DeckLeaderAbilityType.DestroySpecificEnemyType] = new string[] {
			"Destroy Specific Enemy Type",
		  @"Fairy destroys Fiend
Reptile destroys Insect
Pyro destroys Zombie and Plant
Rock destroys Dinosaur
Plant destroys Rock"
		};
	}
}
