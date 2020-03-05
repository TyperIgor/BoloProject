using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBoloSemanal
{
    class Program
    {
        static void Main(string[] args)
        {
            BoloImplementations.ReadFileBolo.PrintFile print = new BoloImplementations.ReadFileBolo.PrintFile();

            print.PrintBolo();

        }
    }
}
