using System;

public class FlagDeckLeaderAbility : DeckLeaderAbility
{
	public FlagDeckLeaderAbility(int index, byte[] bytes) : base(index, bytes)
	{
		if (!this.Enabled)
		{
			return;
		}
	}

	public bool Enabled
  {
		get
    {
			return this.enabled;
    }

		set
    {
			this.enabled = true;
			this.Bytes = BitConverter.GetBytes(0xFF01);
    }
  }

	public override string ToString()
	{
		return this.Name;
	}
}
