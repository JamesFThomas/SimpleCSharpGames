using System.Numerics;

namespace SimpleGames.Client.Models
{
    public class ExpetiGameState
    {
        static int targetNumber { get; set; }
        static List<int> guesses = new List<int>();
        static bool stillGuessing = true;

        public ExpetiGameState() { }

        public void Start()
        {
            // update logic from CSharp players guide source code
        }

        public void Greeting()
        {
            // update logic from CSharp players guide source code
        }

        public void PickRandomNumber()
        {
            Random random = new Random();
            targetNumber = random.Next(10);

        }

        public bool IsValidGuess(int guess)
        {
            if (guesses.Contains(guess)) return false;

            return true;
        }

        public void TrackPlayerGuess(int guess)
        {
            guesses.Add(guess);
        }

        public void GameOver()
        {
            Console.WriteLine("\nThanks for playing");
        }

        public void CollectPlayerGuess()
        {
            // update logic from CSharp players guide source code
        }


    }
}
