using System;
using System.Linq;

namespace MementoDesignPatternExample
{
    public class TicTacToeGame : IOriginator
    {
        private char[][] GameBoard { get; set; }

        public TicTacToeGame()
        {
            GenerateEmptyGameBoard3x3();
        }

        public void SetNought(int x, int y)
        {
            GameBoard[x][y] = 'O';
        }

        public void SetCross(int x, int y)
        {
            GameBoard[x][y] = 'X';
        }

        public Save CreateMemento()
        {
            Save save = new Save();
            save.GameBoard = GameBoard.Select(x => new char[] { x[0], x[1], x[2] }).ToArray();

            return save;
        }

        public void SetMemento(Save save)
        {
            GameBoard = save.GameBoard.ToArray();
        }

        public void ShowBoard()
        {
            Console.WriteLine("┌─┬─┬─┐");
            Console.WriteLine("│{0}│{1}│{2}│", GameBoard[0][0], GameBoard[0][1], GameBoard[0][2]);
            Console.WriteLine("├─┼─┼─┤");
            Console.WriteLine("│{0}│{1}│{2}│", GameBoard[1][0], GameBoard[1][1], GameBoard[1][2]);
            Console.WriteLine("├─┼─┼─┤");
            Console.WriteLine("│{0}│{1}│{2}│", GameBoard[2][0], GameBoard[2][1], GameBoard[2][2]);
            Console.WriteLine("└─┴─┴─┘");
        }

        private void GenerateEmptyGameBoard3x3()
        {
            GameBoard = new char[3][];

            for (int i = 0; i < 3; i++)
            {
                GameBoard[i] = new char[3];
                for(int j = 0; j < 3; j++)
                {
                    GameBoard[i][j] = ' ';
                }
            }
        }
    }
}