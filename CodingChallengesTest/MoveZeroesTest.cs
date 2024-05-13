namespace CodingChallenges.Tests;

public class MoveZeroesTest
{
    [Fact]
    public void MoveZeroesTest1()
    {
        Assert.Equal(new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}, CodingChallenges.Challenges.MoveZeroes.MoveTheZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}));
    }
}