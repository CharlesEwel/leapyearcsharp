using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LeapYear.Objects
{
  public class QueenAttack
  {
    public bool CanAttack(int QueenX, int QueenY, int TargetX, int TargetY)
    {
      if(QueenX == TargetX || QueenY == TargetY || (QueenX-TargetX) == (QueenY-TargetY) || (QueenX-TargetX) == (TargetY-QueenY))
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
