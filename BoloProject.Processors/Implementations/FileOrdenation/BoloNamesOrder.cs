using System;
using System.Collections.Generic;
using System.Text;

namespace BoloProject.Processors.Ordernation
{
    public class BoloNamesOrder
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
