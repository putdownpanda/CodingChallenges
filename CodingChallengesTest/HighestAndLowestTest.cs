using CodingChallenges.Challenges;

namespace CodingChallenges.Tests;

public class HighestAndLowestTest
{
    [Fact]
    public void HighestAndLowestReturned()
    {
        Assert.Equal("42 -9",HighestAndLowest.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4") );
    }
}