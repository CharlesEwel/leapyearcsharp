using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;

namespace LeapYear.Objects
{
  public class Anagram
  {
    public List<string> IsAnagram(string compareWord, List<string> testWords)
    {
      string formattedCompareWord = Regex.Replace(compareWord.ToLower(), " ", "");
      char[] compareArray = formattedCompareWord.ToCharArray();
      Array.Sort(compareArray);

      List<string> Anagrams = new List<string> {};

      foreach(string testWord in testWords)
      {
        string formattedTestWord = Regex.Replace(testWord.ToLower(), " ", "");
        char[] testArray = formattedTestWord.ToCharArray();
        Array.Sort(testArray);

        if (testArray.Length == compareArray.Length)
        {
          bool identical = true;
          for(int i=0; i<testArray.Length; i++)
          {
            if(testArray[i]!=compareArray[i])
            {
              identical = false;
            }
          }
          if (identical)
          {
            Anagrams.Add(testWord);
          }
        }
      }
      return Anagrams;
    }
  }
}
