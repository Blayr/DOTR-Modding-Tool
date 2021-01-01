using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  public class FlagDeckLeaderAbility : DeckLeaderAbility
  {
    public static readonly ushort EnabledBytesValue = 0xFF01;

    public FlagDeckLeaderAbility(int index, byte[] bytes) : base(index, bytes)
    {

    }

    public override bool Enabled
    {
      get
      {
        return this.enabled;
      }

      set
      {
        if (value == true)
        {
          this.Bytes = BitConverter.GetBytes(EnabledBytesValue);
        } else
        {
          this.Bytes = BitConverter.GetBytes(DisabledBytesValue);
        }

        this.enabled = value;
      }
    }
}
