namespace CodingChallenges.Challenges;

public class LoopOver
{
    /*Everybody likes sliding puzzles! For this kata, we're going to be looking at a special type of sliding puzzle called Loopover. With Loopover, it is more like a flat rubik's cube than a sliding puzzle. Instead of having one open spot for pieces to slide into, the entire grid is filled with pieces that wrap back around when a row or column is slid.
    Try it out: https://www.openprocessing.org/sketch/576328
    Note: computer scientists start counting at zero!
    Your task: return a List of moves that will transform the unsolved grid into the solved one. All values of the scrambled and unscrambled grids will be unique! Moves will be 2 character long Strings like the ones below.*/

    public static char[][] MoveCharToNewPosition(char[][] board, int currentRow, int currentColumn, int newRow, int newColumn,List<string> moves)
    {
        //up or down
        int rowMovement = newRow - currentRow;
        if (rowMovement == 0) { }
        else if (rowMovement < 0)
        {
            for (int i = 0; i > rowMovement; i--)
            {
                moves.Add($"U{currentColumn}");
                MoveUp(board,currentColumn);
                if(currentRow-- < 0)
                {
                    currentRow = board.Length - 1;
                }
            }
        }
        else
        {
            for (int i = 0; i < rowMovement; i--)
            {
                moves.Add($"D{currentColumn}");
                MoveDown(board,currentColumn);
                if(currentRow++ > board.Length)
                {
                    currentRow = 0;
                }
            }
        }
        
        //move the mixed up board to the location of the solved board
        int columnMovement = newColumn - currentColumn;
        //move left or right
        if (columnMovement == 0) { }
        else if (columnMovement < 0)
        {
            for (int i = newColumn; i < currentColumn; i++)
            {
                moves.Add($"L{currentRow}");
                MoveLeft(board,currentRow);
            }
        }
        else
        {
            for (int i = 0; i < columnMovement; i--)
            {
                moves.Add($"R{currentColumn}");
                MoveRight(board,currentRow);
            }
        }
        
        
        return board;
    }
    public static List<string> Solve(char[][] mixedUpBoard, char[][] solvedBoard)
    {
        List<string> moves = new List<string>();
        //Plan:
        //find the location of the first character in the solved board, in the mixed up board
        //move the mixed up board to the location of the solved board
        //repeat until the board is solved

        //find the location of the first character in the solved board, in the mixed up board
        /*int rowLength = solvedBoard[0].Length;
        int columnLength = solvedBoard.Length;
        
        int solvedRow = 0;
        int solvedColumn = 0;
        int currentCharacterRow = 0;
        int currentCharacterColumn = 0;
        
        for (int i = 0; i < solvedBoard.Length; i++)//iterate columns
        {
            for (int j = 0; j < solvedBoard[i].Length; j++)//iterate rows
            {
                if (solvedBoard[0][0] == mixedUpBoard[i][j])
                {
                    solvedRow = i;
                    solvedColumn = j;
                    break;
                }
            }
        }*/
        for (int i = 0; i < solvedBoard.Length; i++)//iterate columns
        {
            for (int j = 0; j < solvedBoard[i].Length; j++)//iterate rows
            {
                if (solvedBoard[i][j] == mixedUpBoard[i][j])
                {
                    continue;
                }
                else
                {
                    (int newRow,int newColumn) newCoordinates = FindCurrentPos();
                    (int,int) FindCurrentPos()
                    {
                        for (int k = 0; k < mixedUpBoard.Length; k++)
                        {
                            for (int x = 0; x < mixedUpBoard.Length; x++)
                            {
                                if(solvedBoard[i][j] == mixedUpBoard[k][x])
                                {
                                    return (k, x);
                                }
                            }
                        }
                        return (-1,-1);
                    }
                    MoveCharToNewPosition(mixedUpBoard,newCoordinates.newRow,newCoordinates.newColumn,i,j,moves);
                }
            }
        }

        return moves;
    }
//get a current view of the board
    public static void PrintBoard(char[][] board)
    {
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                Console.Write(board[i][j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public static Char[][] MoveUp(Char[][] board, int indexToMove)
    {
        char temp = board[0][indexToMove];
        for (int i = 0; i < board.Length - 1; i++)
        {
            board[i][indexToMove] = board[i + 1][indexToMove];
        }

        board.Last()[indexToMove] = temp;
        return board;
    }

    public static Char[][] MoveDown(Char[][] board, int indexToMove)
    {
        char temp = board.Last()[indexToMove];
        for (int i = board.Length - 1; i > 0; i--)
        {
            board[i][indexToMove] = board[i - 1][indexToMove];
        }

        board[0][indexToMove] = temp;
        return board;
    }

    public static Char[][] MoveLeft(Char[][] board, int indexToMove)
    {
        Char temp = board[indexToMove][0];
        for (int i = 0; i < board[indexToMove].Length - 1; i++)
        {
            board[indexToMove][i] = board[indexToMove][i + 1];
        }

        board[indexToMove][board[indexToMove].Length - 1] = temp;
        return board;
    }

    public static Char[][] MoveRight(Char[][] board, int indexToMove)
    {
        Char temp = board[indexToMove].Last();
        for (int i = board[indexToMove].Length - 1; i > 0; i--)
        {
            board[indexToMove][i] = board[indexToMove][i - 1];
        }

        board[indexToMove][0] = temp;

        return board;
    }
}