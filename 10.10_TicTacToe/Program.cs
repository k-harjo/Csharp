using System;


public class TicTacToe
{
    private int[,] board;

    public TicTacToe()
    {
        board = new int[3, 3];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                board[i, j] = 0;
            }
        }
    }

    public void PlayGame()
    {
        int player = 1;
        int moves = 0;

        while (true)
        {
            DisplayBoard();

            Console.WriteLine($"Player {player}, enter your move (row,col):");
            string[] move = Console.ReadLine().Split(',');
            int row = int.Parse(move[0]);
            int col = int.Parse(move[1]);

            if (board[row, col] != 0)
            {
                Console.WriteLine("That square is already taken. Please choose another.");
                continue;
            }

            board[row, col] = player;
            moves++;

            if (CheckWin(player))
            {
                DisplayBoard();
                Console.WriteLine($"Player {player} wins!");
                return;
            }

            if (CheckDraw(moves))
            {
                DisplayBoard();
                Console.WriteLine("It's a draw!");
                return;
            }

            player = SwitchPlayer(player);
        }
    }

    private void DisplayBoard()
    {
        Console.WriteLine("  0 1 2");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(i + " ");
            for (int j = 0; j < 3; j++)
            {
                if (board[i, j] == 0)
                {
                    Console.Write("- ");
                }
                else if (board[i, j] == 1)
                {
                    Console.Write("X ");
                }
                else
                {
                    Console.Write("O ");
                }
            }
            Console.WriteLine();
        }
    }

    private bool CheckWin(int player)
    {
        // Check rows
        for (int i = 0; i < 3; i++)
        {
            if (board[i, 0] == player && board[i, 1] == player && board[i, 2] == player)
            {
                return true;
            }
        }

        // Check columns
        for (int j = 0; j < 3; j++)
        {
            if (board[0, j] == player && board[1, j] == player && board[2, j] == player)
            {
                return true;
            }
        }

        // Check diagonals
        if (board[0, 0] == player && board[1, 1] == player && board[2, 2] == player)
        {
            return true;
        }
        if (board[0, 2] == player && board[1, 1] == player && board[2, 0] == player)
        {
            return true;
        }

        return false;
    }

    private bool CheckDraw(int moves)
    {
        return moves == 9;
    }

    private int SwitchPlayer(int player)
    {
        return player == 1 ? 2 : 1;
    }

    public static void Main()
    {
        TicTacToe game = new TicTacToe();
        game.PlayGame();
    }
}

