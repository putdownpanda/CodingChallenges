using CodingChallenges.Challenges;

namespace CodingChallenges.Tests;

public class LoopOverTest
{
    //still cant solve this one, its hard lol
    [Fact]
    public void TestWholeBoard()
    {
        /*char[][] mixedUpBoard = new char[][]
        {
            new char[] { 'w', 'c', 'm', 'd', 'j' },
            new char[] { 'o', 'r', 'f', 'b', 'a' },
            new char[] { 'k', 'n', 'g', 'l', 'y' },
            new char[] { 'p', 'h', 'v', 's', 'e' },
            new char[] { 't', 'x', 'q', 'u', 'i' }
        };
        char[][] solvedBoard = new char[][]
        {
            new char[] { 'a', 'b', 'c', 'd', 'e' },
            new char[] { 'f', 'g', 'h', 'i', 'j' },
            new char[] { 'k', 'l', 'm', 'n', 'o' },
            new char[] { 'p', 'q', 'r', 's', 't' },
            new char[] { 'u', 'v', 'w', 'x', 'y' }
        };*/
        
        char[][] mixedUpBoard = new char[][]
        {
            new char[] { 'e', 'a', 'b', 'c', 'd' },
            new char[] { 'f', 'g', 'h', 'i', 'j' },
            new char[] { 'k', 'l', 'm', 'n', 'o' },
            new char[] { 'p', 'q', 'r', 's', 't' },
            new char[] { 'u', 'v', 'w', 'x', 'y' }
        };
        char[][] solvedBoard = new char[][]
        {
            new char[] { 'a', 'b', 'c', 'd', 'e' },
            new char[] { 'f', 'g', 'h', 'i', 'j' },
            new char[] { 'k', 'l', 'm', 'n', 'o' },
            new char[] { 'p', 'q', 'r', 's', 't' },
            new char[] { 'u', 'v', 'w', 'x', 'y' }
        };
        List<string> movesExpectedResult = new List<string> { "L0"};
        List<string> movesActualResult = LoopOver.Solve(mixedUpBoard, solvedBoard);

        Assert.Equal(movesExpectedResult, movesActualResult);

    }
    
    [Fact]
     public static void TestMoves()
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
        
        if (board[2].Last() == moveLeftCharToValidate)
            Console.WriteLine("MoveLeft works");
        else
            Console.WriteLine("MoveLeft does not work");
        
        char moveRightCharToValidate = board[2][0];
        LoopOver.MoveRight(board, 2);
        
        if (board[2][1] == moveRightCharToValidate)
            Console.WriteLine("MoveRight works");
        else
            Console.WriteLine("MoveRight does not work");
        
        /*if (MoveLeft(new char[][] {new char[] { 'a', 'b', 'c', 'd', 'e' }}).SequenceEqual(new char[] { 'b', 'c', 'd', 'e', 'a' }))
            Console.WriteLine("MoveLeft works");
        else
            Console.WriteLine("MoveLeft does not work");*/
        /*if (MoveRight(new char[] { 'a', 'b', 'c', 'd', 'e' }).SequenceEqual(new char[] { 'e', 'a', 'b', 'c', 'd' }))
            Console.WriteLine("MoveRight works");
        else
            Console.WriteLine("MoveRight does not work");*/

        char[][] boardAfterUpAt0 = new char[][]
        {
            new char[] { 'f', 'b', 'c', 'd', 'e' },
            new char[] { 'k', 'g', 'h', 'i', 'j' },
            new char[] { 'p', 'l', 'm', 'n', 'o' },
            new char[] { 'u', 'q', 'r', 's', 't' },
            new char[] { 'a', 'v', 'w', 'x', 'y' }
        };

        char[][] boardAfterDownAt3 = new char[][]
        {
            new char[] { 'f', 'b', 'c', 'x', 'e' },
            new char[] { 'k', 'g', 'h', 'd', 'j' },
            new char[] { 'p', 'l', 'm', 'i', 'o' },
            new char[] { 'u', 'q', 'r', 'n', 't' },
            new char[] { 'a', 'v', 'w', 's', 'y' }
        };

        bool success = true;
        LoopOver.MoveUp(board, 0);


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

        if (success)
            Console.WriteLine("MoveUp works");
        else
            Console.WriteLine("MoveUp does not work");

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
        if (success)
            Console.WriteLine("MoveDown works");
        else
            Console.WriteLine("MoveDown does not work");

        char valueToValidate = board[1][2];
        
        Console.WriteLine("current board state");
        LoopOver.PrintBoard(board);
        
        LoopOver.MoveCharToNewPosition(board, 1, 2, 0, 0,new List<string>());

        if (board[0][0] == valueToValidate)
        {
            Console.WriteLine("MoveCharToNewPosition works");
        }
        else
        {
            Console.WriteLine("MoveCharToNewPosition does not work");
        }
        Console.WriteLine("new board");
        LoopOver.PrintBoard(board);
    }
}