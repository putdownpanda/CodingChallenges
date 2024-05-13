using CodingChallenges.Challenges;
using Xunit;

namespace CodingChallenges.Tests;

public class GreedIsGoodTests
{
    [Theory]
    [InlineData(new int[] { 2, 3, 4, 6, 2 })]
    [InlineData(new int[] { 4, 4, 3, 2, 2 })]
    [InlineData(new int[] { 6, 4, 3, 2, 6 })]
    public void ShouldNotScore(int[] testArray)
    {
        Assert.Equal(0, GreedIsGood.ScoreDiceRolls(testArray));
    }
    
    [Theory]
    [InlineData(new int[] { 2, 2, 4, 6, 2 },200)]
    [InlineData(new int[] { 4, 4, 3, 2, 4 },400)]
    [InlineData(new int[] { 1, 4, 1, 2, 1 },1000)]
    public void ShouldScoreBecause3s(int[] testArray,int expectedScore)
    {
        Assert.Equal(expectedScore, GreedIsGood.ScoreDiceRolls(testArray));
    }
    
    [Theory]
    [InlineData(new int[] { 2, 2, 1, 6, 2 },300)]
    [InlineData(new int[] { 4, 4, 5, 2, 4 },450)]
    [InlineData(new int[] { 1, 1, 1, 1, 1 },1200)]
    public void ShouldScoreMix(int[] testArray,int expectedScore)
    {
        Assert.Equal(expectedScore, GreedIsGood.ScoreDiceRolls(testArray));
    }
}