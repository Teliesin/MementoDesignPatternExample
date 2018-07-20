using System.Linq;

namespace MementoDesignPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame game = new TicTacToeGame();
            SaveFolder saveFolder = new SaveFolder();

            game.SetCross(0, 2);
            game.SetNought(1, 1);
            game.SetCross(2, 2);

            game.ShowBoard();

            var save = game.CreateMemento();
            saveFolder.MementoList.Add(save);

            game.SetNought(1, 2);
            game.SetCross(1, 0);
            game.SetNought(0, 1);
            game.SetCross(2, 1);
            game.SetNought(2, 0);
            game.SetCross(0, 0);

            game.ShowBoard();

            save = saveFolder.MementoList.First();
            game.SetMemento(save);

            game.ShowBoard();

            game.SetNought(1, 2);
            game.SetCross(0, 1);
            game.SetNought(1, 0);

            game.ShowBoard();
        }
    }
}