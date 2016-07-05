using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;
using System.IO;

namespace LeapYear.Objects
{
  public class Allergy
  {
    public List<string> ListAllergies(double allergyScore)
    {
      List<string> allAllergies = new List<string>{"eggs", "peanuts", "shellfish", "strawberries", "tomatoes", "chocolate", "pollen", "cats"};
      List<string> actualAllergies = new List<string>{};
      for(int i=0; i<allAllergies.Count; i++)
      {
        double threshold = Math.Pow(2, allAllergies.Count-(1+i));
        if(allergyScore>=threshold)
        {
          actualAllergies.Add(allAllergies[allAllergies.Count-(1+i)]);
          allergyScore-=threshold;
        }
      }
      return actualAllergies;
    }
  }
}
