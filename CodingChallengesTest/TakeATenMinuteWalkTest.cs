using CodingChallenges.Challenges;

namespace CodingChallenges.Tests;

public class TakeATenMinuteWalkTest
{
    [Fact]
    public void TestWalk()
    {
        Assert.True(TakeATenMinuteWalk.IsValidWalk(new[] { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" }));
    }
}