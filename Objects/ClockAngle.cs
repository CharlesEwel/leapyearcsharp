using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;

namespace LeapYear.Objects
{
  public class ClockAngle
  {
    public double CalculateAngle (double hour, double minute)
    {
      if(((30* (hour+(minute/60)))-(6*minute)) == 180)
      {
        return 180;
      }
      else
      {
        return Math.Abs(((30* (hour+(minute/60)))-(6*minute)))%180;
      }
    }
  }
}
