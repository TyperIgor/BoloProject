using System.IO;
using System.Collections.Generic;

namespace Project.BoloSemanal.Domain.Entities
{
    public abstract class FileAtributes
    {
        private StreamReader _fileNames = new StreamReader(@"C:\Users\igor.lima\Documents\bolosemanal.txt");

        private List<string> _names = new List<string>();

        public StreamReader ReadFile { get { return _fileNames; } }

        public List<string> NamesList { get { return _names; } }
    }
}
