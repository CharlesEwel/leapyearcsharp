// using Xunit;
// namespace LeapYear.Objects
// {
//   public class ClockAngleTest
//   {
//     [Fact]
//     public void CalculateAngle_ForSmallHour_CorrectTime()
//     {
//        ClockAngle newClockAngle = new ClockAngle();
//        Assert.Equal(90, newClockAngle.CalculateAngle(3,0));
//     }
//     [Fact]
//     public void CalculateAngle_ForLargeHour_CorrectTime()
//     {
//        ClockAngle newClockAngle = new ClockAngle();
//        Assert.Equal(90, newClockAngle.CalculateAngle(9,0));
//     }
//     [Fact]
//     public void CalculateAngle_ForExactly180_180()
//     {
//        ClockAngle newClockAngle = new ClockAngle();
//        Assert.Equal(180, newClockAngle.CalculateAngle(6,0));
//     }
//     // [Fact]
//     // public void CalculateAngle_WithMinuteHand_CorrectTime()
//     // {
//     //    ClockAngle newClockAngle = new ClockAngle();
//     //    Assert.Equal(90, newClockAngle.CalculateAngle(6,15));
//     // }
//     [Fact]
//     public void CalculateAngle_WithHourHandCorrection_CorrectTime()
//     {
//        ClockAngle newClockAngle = new ClockAngle();
//        Assert.Equal(15, newClockAngle.CalculateAngle(6,30));
//     }
//   }
// }
