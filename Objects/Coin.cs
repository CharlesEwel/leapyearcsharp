using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;
using System.IO;

namespace LeapYear.Objects
{
  public class Coin
  {
    public List<int> ListCoins(int cents)
    {
      Dictionary <string, int> CoinValues = new Dictionary<string, int>()
      {
        {"quarter", 25},
        {"dime", 10},
        {"nickel", 5},
        {"penny", 1}
      };
      List<int> outputList = new List<int> {};
      int numberOfQuarters = cents/25;
      outputList.Add(numberOfQuarters);
      cents=cents%25;
      int numberOfDimes = cents/10;
      outputList.Add(numberOfDimes);
      cents=cents%10;
      int numberOfNickels = cents/5;
      outputList.Add(numberOfNickels);
      cents=cents%5;
      int numberOfPennies = cents;
      outputList.Add(numberOfPennies);
      return outputList;
    }
  }
}
