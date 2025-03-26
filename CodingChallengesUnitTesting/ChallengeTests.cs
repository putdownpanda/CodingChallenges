using CodingChallenges.Challenges;

namespace CodingChallengesUnitTesting;

public class ChallengeTests
{
    [Fact]
    public void TestMoveTheZeroes()
    {
        Assert.Equal(new int[] {1, 2, 1, 1, 3, 1, 0, 0, 0, 0}, MoveZeroes.MoveTheZeroes(new int[] {1, 2, 0, 1, 0, 1, 0, 3, 0, 1}));
    }
    
    [Fact]
    public void TestIsValidWalk()
    {
        Assert.True( TakeATenMinuteWalk.IsValidWalk(new []{"n","s","n","s","n","s","n","s","n","s"}));
    }
    
    [Fact]
    public void TestHighAndLow()
    {
        Assert.Equal("42 -9", HighestAndLowest.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
    }
    
    [Theory]
    [InlineData(new string[] { "ab", "c_" }, "abc")]
    [InlineData( new string[] { "ab", "cd", "ef" },"abcdef")]
    public void TestSplitTheStrings(string[] expectedResult, string str)
    {
        Assert.Equal(expectedResult, SplitStrings.SplitTheStrings(str));
    }
    
    /*[Fact]
    public void TestLoopOver()
    {
        //first ensure the unit tests are working
        TestMoveLeft();
        TestMoveRight();
        TestMoveUp();
        TestMoveDown();
        TestMoveToNewPosition();
        
        //Then run the integration test
        char[][] mixedUpBoard = new char[][]
        {
            new char[] { 'e', 'a', 'b', 'c', 'y' },
            new char[] { 'f', 'g', 'h', 'i', 'd' },
            new char[] { 'k', 'l', 'm', 'n', 'j' },
            new char[] { 'p', 'q', 'r', 's', 'o' },
            new char[] { 'u', 'v', 'w', 'x', 't' }
        };
        char[][] solvedBoard = new char[][]
        {
            new char[] { 'a', 'b', 'c', 'd', 'e' },
            new char[] { 'f', 'g', 'h', 'i', 'j' },
            new char[] { 'k', 'l', 'm', 'n', 'o' },
            new char[] { 'p', 'q', 'r', 's', 't' },
            new char[] { 'u', 'v', 'w', 'x', 'y' }
        };
        Assert.Equal(new List<string> { "L0" }, LoopOver.Solve(mixedUpBoard, solvedBoard));
    }*/
    
    [Fact]
    public void TestMoveLeft()
    {
        char[][] board = new char[][]
        {
            new char[] { 'a', 'b', 'c', 'd', 'e' },
            new char[] { 'f', 'g', 'h', 'i', 'j' },
            new char[] { 'k', 'l', 'm', 'n', 'o' },
            new char[] { 'p', 'q', 'r', 's', 't' },
            new char[] { 'u', 'v', 'w', 'x', 'y' }
        };
        
        char moveLeftCharToValidate = board[2][0];
        LoopOver.MoveLeft(board, 2);
        
        Assert.Equal(board[2].Last(),moveLeftCharToValidate);
    }
    
    [Fact]
    public void TestMoveRight()
    {
        char[][] board = new char[][]
        {
            new char[] { 'a', 'b', 'c', 'd', 'e' },
            new char[] { 'f', 'g', 'h', 'i', 'j' },
            new char[] { 'k', 'l', 'm', 'n', 'o' },
            new char[] { 'p', 'q', 'r', 's', 't' },
            new char[] { 'u', 'v', 'w', 'x', 'y' }
        };
        
        char moveRightCharToValidate = board[2][0];
        LoopOver.MoveRight(board, 2);
        
        Assert.Equal(board[2][1],moveRightCharToValidate);
    }

    [Fact]
    public void TestMoveUp()
    {
        char[][] board = new char[][]
        {
            new char[] { 'a', 'b', 'c', 'd', 'e' },
            new char[] { 'f', 'g', 'h', 'i', 'j' },
            new char[] { 'k', 'l', 'm', 'n', 'o' },
            new char[] { 'p', 'q', 'r', 's', 't' },
            new char[] { 'u', 'v', 'w', 'x', 'y' }
        };
        char[][] boardAfterUpAt0 = new char[][]
        {
            new char[] { 'f', 'b', 'c', 'd', 'e' },
            new char[] { 'k', 'g', 'h', 'i', 'j' },
            new char[] { 'p', 'l', 'm', 'n', 'o' },
            new char[] { 'u', 'q', 'r', 's', 't' },
            new char[] { 'a', 'v', 'w', 'x', 'y' }
        };
        LoopOver.MoveUp(board, 0);
        
        bool success = true;

        for (int i = 0; i < board.Length; i++)
        {
            if (board[i].SequenceEqual(boardAfterUpAt0[i]))
            {
                success = true;
            }
            else
            {
                success = false;
                break;
            }
        }
        Assert.True(success);
    }

    [Fact]
    public void TestMoveDown()
    {
        char[][] board = new char[][]
        {
            new char[] { 'a', 'b', 'c', 'd', 'e' },
            new char[] { 'f', 'g', 'h', 'i', 'j' },
            new char[] { 'k', 'l', 'm', 'n', 'o' },
            new char[] { 'p', 'q', 'r', 's', 't' },
            new char[] { 'u', 'v', 'w', 'x', 'y' }
        };
        char[][] boardAfterDownAt3 = new char[][]
        {
            new char[] { 'a', 'b', 'c', 'x', 'e' },
            new char[] { 'f', 'g', 'h', 'd', 'j' },
            new char[] { 'k', 'l', 'm', 'i', 'o' },
            new char[] { 'p', 'q', 'r', 'n', 't' },
            new char[] { 'u', 'v', 'w', 's', 'y' }
        };
        
        bool success = true;
        LoopOver.MoveDown(board, 3);
        success = true;
        
        for (int i = 0; i < board.Length; i++)
        {
            if (board[i].SequenceEqual(boardAfterDownAt3[i]))
            {
                success = true;
            }
            else
            {
                success = false;
                break;
            }
        }
        Assert.True(success);
    }

    [Fact]
    public void TestMoveToNewPosition()
    {
        char[][] board = new char[][]
        {
            new char[] { 'a', 'b', 'c', 'd', 'e' },
            new char[] { 'f', 'g', 'h', 'i', 'j' },
            new char[] { 'k', 'l', 'm', 'n', 'o' },
            new char[] { 'p', 'q', 'r', 's', 't' },
            new char[] { 'u', 'v', 'w', 'x', 'y' }
        };
        
        char valueToValidate = board[1][2];
        
        LoopOver.MoveCharToNewPosition(board, 1, 2, 0, 0,new List<string>());

        Assert.Equal(valueToValidate,board[0][0]);
    }
    [Fact]
    public void TestGetHEXFromRGB()
    {
        RGBToHEXConversion convert = new RGBToHEXConversion();
        /*Assert.Equal("#FF0000", convert.GetHEXFromRGB(255, 0, 0));
        Assert.Equal("#00FF00", convert.GetHEXFromRGB(0, 255, 0));
        Assert.Equal("#0000FF", convert.GetHEXFromRGB(0, 0, 255));
        Assert.Equal("#000000", convert.GetHEXFromRGB(0, 0, 0));
        Assert.Equal("#FFFFFF", convert.GetHEXFromRGB(255, 255, 255));
        Assert.Equal("#FF0000", convert.GetHEXFromRGB(255, 0, -1));*/
        Assert.Equal("#9400D3", convert.GetHEXFromRGB(148, 0, 211));
    }
}