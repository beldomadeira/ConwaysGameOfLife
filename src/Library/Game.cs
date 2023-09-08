namespace Library;

public class Game
{

    public bool[,] gameBoard;

    public int Width { get; private set; }
    public int Height { get; private set; }

    public Game(int width, int height) {
        gameBoard = new bool[width, height];
        Width = width;
        Height = height;
    }

    public void NextGeneration() {
        bool[,] cloneboard = new bool[Width, Height];
        for (int x = 0; x < Width; x++) {
            for (int y = 0; y < Height; y++) {
                int aliveNeighbors = 0;
                for (int i = x - 1; i <= x + 1; i++) {
                    for (int j = y - 1; j <= y + 1; j++) {
                        if (i >= 0 && i < Width && j >= 0 && j < Height && gameBoard[i, j]) {
                            aliveNeighbors++;
                        }
                    }
                }
                if (gameBoard[x, y]) {
                    aliveNeighbors--;
                }
                if (gameBoard[x, y] && aliveNeighbors < 2) {
                    cloneboard[x, y] = false;
                } else if (gameBoard[x, y] && aliveNeighbors > 3) {
                    cloneboard[x, y] = false;
                } else if (!gameBoard[x, y] && aliveNeighbors == 3) {
                    cloneboard[x, y] = true;
                } else {
                    cloneboard[x, y] = gameBoard[x, y];
                }
            }
        }
        gameBoard = cloneboard;
    }







}
