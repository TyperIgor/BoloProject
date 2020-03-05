using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoBoloSemanal.CakeDates;
using ProjetoBoloSemanal.CakeOrder;


namespace ProjetoBoloSemanal
{
    public abstract class BoloImplementations
    {
        StreamReader _ReadPath = new StreamReader(@"C:\Users\igor.lima\Documents\bolosemanal.txt");

        public StreamReader ReadFile { get { return _ReadPath; } }

        List<string> _namesList = new List<string>();

        public List<string> ListNames { get { return _namesList; } }
    }

    public class CakeProcessor : BoloImplementations
    {
        public void ReadStreamReaderFileToList()
        {
            while (!ReadFile.EndOfStream)
            {
                string Ler;

                Ler = ReadFile.ReadLine();

                ListNames.Add(Ler);
            }
        }
    }

    public class PrintFile : CakeProcessor
    {
        public void PrintBolo()
        {
            ReadStreamReaderFileToList();

            OrderString.BubbleSort(ListNames);
                                     
            var n = 0;
            foreach (var date in Dates.GetDates())
            {
                if (n == ListNames.Count)
                    n = 0;

                Console.WriteLine("Nomes: {0}  Bolo: {1} ", ListNames[n], date);
                n++;
            }

            Console.ReadKey();
        }
    }

   
    
}
