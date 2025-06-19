using System.Numerics;

namespace SimpleGames.Client.Models
{
    public class TicTacToeGameState
    {
        public void PlayGame()
        {
            // create a new board a two new players
            TicTacToeBoard board = new TicTacToeBoard();
            TicTacToePlayer playerX = new TicTacToePlayer("X");
            TicTacToePlayer playerO = new TicTacToePlayer("0");

            // display greeting message
            Greeting();


            while (board.boardState == "open")
            {

                playerX.MakeMove(board);
                if (board.boardState != "open") break;


                playerO.MakeMove(board);
                if (board.boardState != "open") break;

            }

            board.ResetBoard();
            EndGame();

        }


        public void Greeting()
        {
            Console.WriteLine("Tic Tac Toe.");
            Console.WriteLine("Let's do this, Player X wil go first!");
        }


        public void EndGame()
        {
            Console.WriteLine("Game Over! Thanks for playing.");
        }
    }
}
