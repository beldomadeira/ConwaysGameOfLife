namespace Program;
using Library;
class Program
{
    static void Main(string[] args)
    {
        string url = @"./board.txt";
        bool[,] startboard = BoardGenerator.Board(url);

        Game game = new Game(startboard.GetLength(0), startboard.GetLength(1));
        game.gameBoard = startboard;

        Printer.ConsolePrinter(game);




    }
}
