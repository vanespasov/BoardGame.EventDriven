using BoardGame.Core.Models;

namespace BoardGame.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello Boarding Game !");

            System.Console.WriteLine("Instantiating the pointer holes...");
            OnePointerHole onePointerHole = new OnePointerHole(4);
            TwoPointerHole twoPointerHole = new TwoPointerHole(5);
            ThreePointerHole threePointerHole = new ThreePointerHole(8);
            FivePointerHole fivePointerHole = new FivePointerHole(10);
            
            System.Console.WriteLine("Instantiating the board");
            Board board = new Board(onePointerHole, twoPointerHole, threePointerHole, fivePointerHole);
            
            System.Console.WriteLine("Instantiating the game");
            Game game = new Game(board, 21);
            game.Init();
            
            System.Console.WriteLine("PLAY Game");
            game.Play();
        }
    }
}
