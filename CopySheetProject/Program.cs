using System;
using Google.Sheet.Application.Initializer;

namespace CopySheetProject
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteSheetProcessor x = new ExecuteSheetProcessor();

            x.Start();
        }
    }
}
