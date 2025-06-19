namespace SimpleGames.Client.Models
{
    public class TicTacToePlayer
    {
        private string playerMark { get; set; }
        public TicTacToePlayer(string mark)
        {
            playerMark = mark;

        }

        public void MakeMove(TicTacToeBoard gameBoard)
        {
            string prompt1 = $"PLayer {playerMark}: What open square do you want to play in? (1-9)";

            // display gameBoard here  
            gameBoard.DisplayBoard();

            // prompt player for input  
            Console.Write(prompt1);

            // get player input  
            string? squareNumber = Console.ReadLine();

            // check if input is null or blank input  
            if (string.IsNullOrWhiteSpace(squareNumber))
            {
                Console.WriteLine("Please enter a valid square number.");
                MakeMove(gameBoard);
                return;
            }

            // check if square is free  
            if (!gameBoard.IsSquareFree(squareNumber))
            {
                Console.WriteLine("The square is already occupied. Please choose another square.");
                MakeMove(gameBoard);
                return;
            }
            else
            {
                gameBoard.UpdateBoard(squareNumber, playerMark);
                gameBoard.CheckBoard();
                return;
            }
        }
    }
}
