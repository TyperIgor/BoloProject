using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBolo.CakeOrder
{
    public class StringOrder
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
}
