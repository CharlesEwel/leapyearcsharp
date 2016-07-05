using Xunit;
using System.Collections.Generic;
namespace LeapYear.Objects
{
  public class AnagramTest
  {
    [Fact]
    public void ListAllergies_ReturnsList_CorrectOnes()
    {
      Allergy newAllergy = new Allergy();
      List<string> output = new List<string> {"strawberries", "eggs"};
      Assert.Equal(output, newAllergy.ListAllergies(9));
    }
  }
}
