namespace Library;
using System;
using System.Text;
public class Printer
{
    public static void ConsolePrinter(Game board)
    {
        while (true)
        {
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y < board.Height; y++)
            {
                for (int x = 0; x < board.Width; x++)
                {
                    if (board.gameBoard[x, y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            Console.WriteLine(s.ToString());
            board.NextGeneration();
            Thread.Sleep(300);
        }
    }


}