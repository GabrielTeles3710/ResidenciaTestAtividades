using Atividade06;
using Xunit.Sdk;

namespace Atividade06.Tests
{
    public class PointTests
    {
        [Fact]
        public void DistanceTo_returns_correct_distance()
        {
            var point = new Point(1, 0);
            double result = point.DistanceTo(new Point(5,0));
            Assert.Equal(4, result);
        }
        [Fact]
        public void DistanceTo_returns_correct_distance_whith_negative()
        {
            var point = new Point(-1, 0);
            double result = point.DistanceTo(new Point(5,0));
            Assert.Equal(6, result);
        }
        [Fact]
        public void DistanceTo_returns_correct_distance_whith_no_exactly_result()
        {
            var point = new Point(1, 1);
            double result = Math.Round(point.DistanceTo(new Point(5,5)),5); //Result formated to 5 decimal places
            Assert.Equal(5.65685, result);
        }
    }
}