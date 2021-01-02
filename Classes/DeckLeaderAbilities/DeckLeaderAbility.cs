using System;
using System.Collections.Generic;
using System.Linq;

public class DeckLeaderAbility
{
	public static readonly ushort DisabledBytesValue = 0xFFFF;
	public readonly bool IsUnusedAbility;
	public byte[] Bytes { get; set; }
	public int Index { get; }
	public DeckLeaderAbilityType AbilityType { get; }
	public string Name { get; }
	public string Description { get; }
	protected bool enabled;
	public virtual bool Enabled
	{
		get
		{
			return this.enabled;
		}
		set
		{
			this.enabled = value;
		}
	}

	public DeckLeaderAbility(int index, byte[] bytes)
	{
		this.Bytes = bytes;
		this.Index = index;
		this.AbilityType = (DeckLeaderAbilityType)this.Index;
		this.Name = DeckLeaderAbilityInfo.NameAndDescriptions[index][0];
		this.Description = DeckLeaderAbilityInfo.NameAndDescriptions[index][1];
		this.IsUnusedAbility = !Enum.IsDefined(typeof(DeckLeaderAbilityType), index);
		ushort ushortBytesValue = BitConverter.ToUInt16(this.Bytes, 0);
		this.Enabled = !(ushortBytesValue == DisabledBytesValue);
	}

	public override string ToString()
  {
		return this.Name;
  }

	public string AbilityDetails()
	{
		return this.ToString();
	}

	public DeckLeaderAbility Clone()
  {
		DeckLeaderAbilityFactory deckLeaderAbilityFactory = new DeckLeaderAbilityFactory();
		DeckLeaderAbility clonedDeckLeaderAbility = deckLeaderAbilityFactory.GetDeckLeaderAbility(this.Index, this.Bytes);
		return clonedDeckLeaderAbility;
  }

	public static List<DeckLeaderAbilityType> YesNoAbilityList;
	public static List<DeckLeaderAbilityType> RankRequirementAbilityList;
	public static List<DeckLeaderAbilityType> RankRequirementUpperByteAbilityList;
	public static List<DeckLeaderAbilityType> RankRequirementLowerByteAbilityList;
	public static List<DeckLeaderAbilityType> RankRequirementNoAdditionalInformationList;
	public static List<DeckLeaderAbilityType> StrengthModifierAbilityList;

	static DeckLeaderAbility() {
	  DeckLeaderAbility.YesNoAbilityList = new List<DeckLeaderAbilityType> {
			DeckLeaderAbilityType.HiddenCard,
			DeckLeaderAbilityType.ExtraSlots
		};

		DeckLeaderAbility.RankRequirementLowerByteAbilityList = new List<DeckLeaderAbilityType> {
			DeckLeaderAbilityType.TerrainChange,
			DeckLeaderAbilityType.LevelCostReduction,
			DeckLeaderAbilityType.FriendlyIncreasedStrength,
			DeckLeaderAbilityType.WeakenSpecificEnemyType
		};

		DeckLeaderAbility.RankRequirementUpperByteAbilityList = new List<DeckLeaderAbilityType> {
			DeckLeaderAbilityType.DestinyDraw,
			DeckLeaderAbilityType.IncreasedMovement,
			DeckLeaderAbilityType.LPRecovery,
			DeckLeaderAbilityType.DirectDamageHalved,
			DeckLeaderAbilityType.ExtendedSupportRange,
			DeckLeaderAbilityType.FriendlyImprovedResistance,
			DeckLeaderAbilityType.FriendlyMovementBoost,
			DeckLeaderAbilityType.FlipCard,
			DeckLeaderAbilityType.SpellbindSpecificEnemyType,
			DeckLeaderAbilityType.DestroySpecificEnemyType
		};

		DeckLeaderAbility.RankRequirementNoAdditionalInformationList = new List<DeckLeaderAbilityType>
		{
			DeckLeaderAbilityType.DestinyDraw,
			DeckLeaderAbilityType.IncreasedMovement,
			DeckLeaderAbilityType.LPRecovery,
			DeckLeaderAbilityType.DirectDamageHalved,
			DeckLeaderAbilityType.ExtendedSupportRange,
			DeckLeaderAbilityType.FriendlyImprovedResistance,
			DeckLeaderAbilityType.FriendlyMovementBoost,
			DeckLeaderAbilityType.FlipCard,
			DeckLeaderAbilityType.SpellbindSpecificEnemyType,
			DeckLeaderAbilityType.DestroySpecificEnemyType
		};

		DeckLeaderAbility.StrengthModifierAbilityList = new List<DeckLeaderAbilityType> {
			DeckLeaderAbilityType.FriendlyIncreasedStrength,
			DeckLeaderAbilityType.WeakenSpecificEnemyType
		};

		DeckLeaderAbility.RankRequirementAbilityList = RankRequirementLowerByteAbilityList.Concat(RankRequirementUpperByteAbilityList).ToList();
	}
}
