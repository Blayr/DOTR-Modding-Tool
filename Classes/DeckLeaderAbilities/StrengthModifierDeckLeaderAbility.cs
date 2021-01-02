using System;

public class StrengthModifierDeckLeaderAbility : RankRequirementDeckLeaderAbility
{
	private int strengthModifierAmount;
	private byte convertIntToStrengthModifierByte(int amount)
  {
		return (byte)(amount / 100);
  }
	
	private int convertStrengthModifierByteToInt(byte modifierByte)
  {
		if (modifierByte == byte.MaxValue)
    {
			return 0;
    }

		return modifierByte * 100;
  }

	public int StrengthModifierAmount
  {
		get
    {
			return this.strengthModifierAmount;
    }

		set
    {
			byte strengthModifierByte = convertIntToStrengthModifierByte(value);

			if (strengthModifierByte > 5)
      {
				strengthModifierByte = 5;
      }

			// Strength modifier byte is stored in the opposite byte of the rank requirement
			// if rank stored in upper byte ([1]), then strength modifier is stored in the lower byte ([0]), and vice versa.
			if (this.rankRequirementHalfByteLocation == RankRequirementByteLocation.UPPER_BYTE)
      {
				this.Bytes[0] = strengthModifierByte;
      } else
      {
				this.Bytes[1] = strengthModifierByte;
      }

			this.strengthModifierAmount = value;
    }
  }
	public StrengthModifierDeckLeaderAbility(int index, byte[] bytes) : base(index, bytes)
	{
		byte strengthModifierByte = this.rankRequirementHalfByteLocation == RankRequirementByteLocation.UPPER_BYTE ? this.Bytes[0] : this.Bytes[1];
		this.strengthModifierAmount = this.convertStrengthModifierByteToInt(strengthModifierByte);
	}

	public override string ToString()
	{
		string text = this.Name;

		if (this.UnlockRank != null)
		{
			text = $"{this.Name} - {this.StrengthModifierAmount} - {this.UnlockRank.Name}";
		}

		return text;
	}
}
