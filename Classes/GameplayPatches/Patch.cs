using System;

namespace GameplayPatches {
  public class Patch
  {
    public void ApplyOrRemove(bool apply)
    {
      if (apply)
      {
        Apply();
      }
      else
      {
        Remove();
      }
    }

    public virtual bool IsApplied()
    {
      throw new NotImplementedException();
    }

    public virtual void Apply()
    {
      throw new NotImplementedException();
    }

    public virtual void Remove()
    {
      throw new NotImplementedException();
    }
  }
}
