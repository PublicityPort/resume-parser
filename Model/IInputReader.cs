using System.Collections.Generic;

namespace Model
{
    public interface IInputReader
    {
        IInputReader NextReader { get; set; }
        IList<string> ReadIntoList(string location);        
    }
}
