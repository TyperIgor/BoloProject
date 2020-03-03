using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBoloSemanal
{
    public class ArquivoBolo
    {
        StreamReader _readPath = new StreamReader(@"C:\Users\igor.lima\Documents\bolosemanal.txt");

        public StreamReader ReadFile { get { return _readPath; } }

        public class LendoArquivo : ArquivoBolo
        {
            public void ReadStreamReaderFileToList()
            {
                List<string> NomesBolo = new List<string>();

                while (!ReadFile.EndOfStream)
                {
                    string Ler;

                    Ler = Console.ReadLine();

                    NomesBolo.Add(Ler);
                }

            }
        }

        public class CreateOrdernation
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

        public class CreateDataList
        {
            readonly List<string> ListaData = new List<string>();

            public List<string> GetDatesList()
            {
                DateTime dateInicial = new DateTime(2020, 2, 20);
                DateTime dateFinal = new DateTime(2020, 8, 20);

                while (dateInicial <= dateFinal)
                {
                    if (dateInicial.DayOfWeek == DayOfWeek.Thursday)
                        ListaData.Add(dateInicial.ToString("dd/MM"));
                    dateInicial = dateInicial.AddDays(7);
                }

                return ListaData;
            }
        }
    }

}
