using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ProjectBolo.CakeDomain
{
    public class CakeEntities
    {
        StreamReader _readPath = new StreamReader(@"C:\Users\igor.lima\Documents\bolosemanal.txt");

        List<string> _nomesDoBolo = new List<string>();

        public List<string> namesList { get { return _nomesDoBolo; } }

        public StreamReader ReadFile { get { return _readPath; } }
    }
}
