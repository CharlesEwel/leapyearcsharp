using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LeapYear.Objects
{
  public class LeetSpeakTranslator
  {
    public string Translate(string plainEnglish)
    {
      // eventually your code will go here
      char[] plainEnglishLetters = plainEnglish.ToCharArray();
      List<string> leetArray = new List<string> {};
      bool IsFirstLetter = true;
      foreach (char letter in plainEnglishLetters)
      {
        if(letter.ToString().ToLower() == "e")
        {
           leetArray.Add("3");
        }
        else if (letter.ToString().ToLower() == "o")
        {
          leetArray.Add("0");
        }
        else if (letter.ToString() == "I")
        {
          leetArray.Add("1");
        }
        else if (letter.ToString().ToLower() == "s" && !IsFirstLetter)
        {
          leetArray.Add("z");
        }
        else
        {
          leetArray.Add(letter.ToString());
        }
        if(letter.ToString() == " ")
        {
          IsFirstLetter=true;
        }
        else if (Regex.IsMatch(letter.ToString().ToLower(),@"[a-z]"))
        {
          IsFirstLetter=false;
        }
      }
      string leetString = string.Join("", leetArray);
      return leetString;
    }
  }
}
