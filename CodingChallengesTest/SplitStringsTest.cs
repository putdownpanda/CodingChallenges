using CodingChallenges.Challenges;

namespace CodingChallenges.Tests;

public class SplitStringsTest
{
    [Theory]
    [InlineData("abc", new string[] { "ab", "c_" })]
    [InlineData("abcdef", new string[] { "ab", "cd", "ef" })]
    public void HighestAndLowestReturned(string testString, string[] expectedArray)
    {
        Assert.Equal(expectedArray, SplitStrings.SplitTheStrings(testString));
    }
}