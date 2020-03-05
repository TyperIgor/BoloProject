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
        public class ReadFileBolo 
        {
            readonly StreamReader _ReadPath = new StreamReader(@"C:\Users\igor.lima\Documents\bolosemanal.txt");

            StreamReader ReadFile { get { return _ReadPath; } }

            List<string> namesList = new List<string>();

            public void ReadStreamReaderFileToList()
            {
                while (!ReadFile.EndOfStream)
                {
                    string Ler;

                    Ler = Console.ReadLine();

                    namesList.Add(Ler);
                }
            }

            public class PrintFile : ReadFileBolo
            {
                public void PrintBolo()
                {
                    ReadStreamReaderFileToList();

                    var n = 0;
                    foreach (var date in GetDates())
                    {
                        if (n == namesList.Count)
                            n = 0;

                        Console.WriteLine("Nomes: {0}  Bolo: {1} ", namesList[n], date);
                        n++;
                    }

                    Console.ReadKey();
                }
            }

            public class OrderFileBolo : ReadFileBolo
            {
                public void OrdenateListNames()
                {
                    ReadStreamReaderFileToList();
                    
                }
            }
            
            public class CreateOrdernation : OrderFileBolo
            {
                public List<string> BubbleSort(List<string> vetor)
                {
                    string aux;

                    for (int i = 0; i < namesList.Count; i++)
                    {
                        for (int j = i + 1; j < namesList.Count; j++)
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
        }
        
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
