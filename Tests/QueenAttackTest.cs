using Xunit;
namespace LeapYear.Objects
{
  public class QueenAttackTest
  {
    [Fact]
    public void CantAttack_Anywhere_False()
    {
      QueenAttack newQueenAttack = new QueenAttack();
      Assert.Equal(false,newQueenAttack.CanAttack(1, 3, 2, 5));
    }
    [Fact]
    public void CanAttack_Horizontal_True()
    {
      QueenAttack newQueenAttack = new QueenAttack();
      Assert.Equal(true,newQueenAttack.CanAttack(4, 5, 4, 7));
    }
    [Fact]
    public void CanAttack_Vertical_True()
    {
      QueenAttack newQueenAttack = new QueenAttack();
      Assert.Equal(true,newQueenAttack.CanAttack(5, 4, 7, 4));
    }
    [Fact]
    public void CanAttack_Diagonal_True()
    {
      QueenAttack newQueenAttack = new QueenAttack();
      Assert.Equal(true,newQueenAttack.CanAttack(2, 4, 5, 1));
    }
  }
}
