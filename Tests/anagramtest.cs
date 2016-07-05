// using Xunit;
// using System.Collections.Generic;
// namespace LeapYear.Objects
// {
//   public class AnagramTest
//   {
//     // [Fact]
//     // public void IsAnagram_NotAnagram_False()
//     // {
//     //    Anagram newAnagram = new Anagram();
//     //    Assert.Equal(false, newAnagram.IsAnagram("cat","dog"));
//     // }
//     // [Fact]
//     // public void IsAnagram_SameLength_True()
//     // {
//     //
//     //    Anagram newAnagram = new Anagram();
//     //    Assert.Equal(true, newAnagram.IsAnagram("beard",{}"bread"));
//     // }
//     // [Fact]
//     // public void IsAnagram_CaseAndSpaceInsensitive_True()
//     // {
//     //    Anagram newAnagram = new Anagram();
//     //    Assert.Equal(true, newAnagram.IsAnagram("Dormitory","dirty room"));
//     // }
//     [Fact]
//     public void IsAnagram_ListTest_OnlyAnagrams()
//     {
//       Anagram newAnagram = new Anagram();
//       List<string> input = new List<string> {"bread","brade","bard"};
//       List<string> output = new List<string> {"bread","brade"};
//       Assert.Equal(output, newAnagram.IsAnagram("beard", input));
//     }
//   }
// }
