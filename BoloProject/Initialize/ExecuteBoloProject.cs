using System;
using System.Collections.Generic;
using System.Text;
using BoloProject.Processors.Ordernation;
using BoloProject.Processors.Dates;
using BoloProject.Processors.Implementations.FileRead;

namespace BoloProject.Initialize
{
    public class ExecuteBoloProject : BoloFileRead
    {
        public void PrintBolo()
        {
            ReadFileNamesToList();

            BoloNamesOrder.BubbleSort(NamesList);

            var listIndex = 0;
            foreach (var data in BoloDates.GetDatas())
            {
                if (listIndex == NamesList.Count)
                    listIndex = 0;

                Console.WriteLine("Nomes: {0}   Bolo: {1}", NamesList[listIndex], data);
                listIndex++;
            }

        }

    }
}
