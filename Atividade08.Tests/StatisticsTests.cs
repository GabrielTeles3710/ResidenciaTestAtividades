using Atividade08;
using Xunit.Sdk;

namespace Atividade08.Tests;

public class StatisticsTests
{
    [Fact]
    public void Statistics_Should_Return_Correct_average(){
        List<int> numbers = new List<int>();
        for (var i = 1; i <= 5; i++)
        {
            numbers.Add(i);
        }
        var statistic = new Statistics();
        var result = statistic.CalculateAverage(numbers);
        Assert.Equal(3, result);
    }
}
