﻿using System;

public class DeckLeaderAbility
{
	public static readonly uint DisabledBytesValue = 0xFFFF;
	public byte[] Bytes { get; }
	public int Index { get; }
	public DeckLeaderAbilityType DeckLeaderAbilityType { get; }
	public string Name { get; }
	public string Description { get; }
	public bool isEnabled { get; }

	public DeckLeaderAbility(int index, byte[] bytes)
	{
		this.Bytes = bytes;
		this.Index = index;
		this.DeckLeaderAbilityType = (DeckLeaderAbilityType)this.Index;
		this.Name = DeckLeaderAbilityInfo.NameAndDescriptions[index][0];
		this.Description = DeckLeaderAbilityInfo.NameAndDescriptions[index][1];
		ushort ushortBytesValue = BitConverter.ToUInt16(this.Bytes, 0);
		this.isEnabled = !(ushortBytesValue == DisabledBytesValue);
	}
}


// 001C9C38: u16 leaderAbilities[683][20]
// Stores the leader abilities.

// 001E0C80: bool SzDuel_GetUnitLeaderAbility3(Unit *unit, s32 abil,
//                                             s32 *param,
//                                             bool ignoreMenu)
// 	Checks a unit to see if it has the given ability. unit is the given unit, assumed to be that of
// 	a Leader, and abil is a Leader Ability. param is a pointer to an int, used to write additional
// 	information associated with the ability to be specified below. The function starts by
// writing 0 here if param is not NULL, and it stays 0 unless the specified ability has any
// associated information. ignoreMenu is whether to ignore the option in the duel settings in custom duel to disable Leader Abilities.

// 	In a reasonable world the ability data for a given ability would just be
// unit->leaderAbilities[abil]. It’s not quite that simple though, so the corresponding indices
// are given below alongside the information put into param, if any. The ability data is
// 0xFFFF if the Leader does not have the ability.

// Extra Slots: index 1, has extra slots if and only if the data is nonzero.
// Hidden Card: index 0, has hidden card if and only if the data is nonzero.
// ???: index 3, rank requirement is upper byte and extra information is lower byte.
// Destiny Draw: index 2, rank requirement for getting Destiny Draw is upper byte.
// Increased Movement: index 5, rank requirement is upper byte.
// LP Recovery: index 4, rank requirement is upper byte.
// Direct Damage Halved: index 7, rank requirement is upper byte.
// Terrain Change: index 6, rank requirement is lower byte. Extra information is the terrain
// 	the Leader changes the square to and is the upper byte.
// Level Cost Reduction for Summoning Same Type: index 9, rank requirement is lower
// byte. Extra information is the level reduction and is the upper byte.
// Extended Support Range: index 8, rank requirement is upper byte.
// Increased Strength for Same Type Friendlies: index 11, rank requirement is lower byte.
// 	Extra information is the boost divided by 100 and is the upper byte.
// Improved Resistance for Same Type Friendlies: index 10, rank requirement is upper byte.
// Movement Boost for Same Type Friendlies: index 13, rank requirement is upper byte.
// Open Opponent’s Card: index 12, rank requirement is upper byte.
// Weaken Specific Enemy Type: index 15, rank requirement is lower byte. Extra
// information is the decreased divided by 100 and is the upper byte.
// Spellbind Specific Enemy Type: index 14, rank requirement is upper byte.
// Destroy Specific Enemy Type: index 17, rank requirement is upper byte.