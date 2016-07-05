using Xunit;
using System.Collections.Generic;
namespace LeapYear.Objects
{
  public class CoinTest
  {
    [Fact]
    public void ListCoins_ReturnsList_CorrectOnes()
    {
      Coin newCoin = new Coin();
      List<int> output = new List<int> {1,1,1,1};
      Assert.Equal(output, newCoin.ListCoins(41));
    }
  }
}
