using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOTR_MODDING_TOOL.Classes.DeckLeaderAbilities
{
  class FlagDeckLeaderAbility : DeckLeaderAbility
  {
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
          this.Bytes = BitConverter.GetBytes(DisabledBytesValue - 1);
        } else
        {
          // Anything other than the DisabledBytesValue will mark it as true
          this.Bytes = BitConverter.GetBytes(DisabledBytesValue);
        }

        this.enabled = value;
      }
    }

  }
}
