using System.Collections.Generic;

namespace MementoDesignPatternExample
{
    public class SaveFolder : ICaretaker
    {
        public List<Save> MementoList { get; set; }

        public SaveFolder()
        {
            MementoList = new List<Save>();
        }
    }
}