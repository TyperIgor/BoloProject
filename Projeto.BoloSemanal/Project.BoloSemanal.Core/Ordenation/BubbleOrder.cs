using System.Collections.Generic;

namespace Project.BoloSemanal.Core.Ordenation
{
    public class BubbleOrder
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
