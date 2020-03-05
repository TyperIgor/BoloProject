using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBoloSemanal
{
    public class BoloImplementations
    {
        StreamReader _ReadPath = new StreamReader(@"C:\Users\igor.lima\Documents\bolosemanal.txt");

        public StreamReader ReadFile { get { return _ReadPath; } }

        List<string> _namesList = new List<string>();

        public List<string> ListNames { get { return _namesList; } }
    }

    public class ReadFileBolo : BoloImplementations
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

    public class PrintFile : ReadFileBolo
    {
        public void PrintBolo()
        {
            ReadStreamReaderFileToList();

            CreateOrdenation.BubbleSort(ListNames);
                                     
            var n = 0;
            foreach (var date in CreateDate.GetDates())
            {
                if (n == ListNames.Count)
                    n = 0;

                Console.WriteLine("Nomes: {0}  Bolo: {1} ", ListNames[n], date);
                n++;
            }

            Console.ReadKey();
        }
    }

    public class CreateOrdenation
    {
        public static List<string> BubbleSort(List<string> vetor)
        {
            string aux;

            for (int i = 0; i < vetor.Count; i++)
            {
                for (int j = i + 1; j < vetor.Count; j++)
                {
                    if (vetor[j].CompareTo(vetor[i]) < 0)
                    {
                        aux = vetor[i];
                        vetor[i] = vetor[j];
                        vetor[j] = aux;
                    }
                }
            }

            return vetor;
        }
    }

    public class CreateDate
    {
        public static List<string> GetDates()
        {
            var lista = new List<string>();

            DateTime dateInicial = new DateTime(2020, 2, 20);
            DateTime dateFinal = new DateTime(2020, 8, 20);

            while (dateInicial <= dateFinal)
            {
                if (dateInicial.DayOfWeek == DayOfWeek.Thursday)
                    lista.Add(dateInicial.ToString("dd/MM"));
                dateInicial = dateInicial.AddDays(7);
            }

            return lista;
        }

    }
    
}
