using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectBolo.CakeProcessors.CakeFileExecute;
using ProjectBolo.CakeDomain;
using ProjectBolo.CakeOrder;
using ProjectBolo.CakeDates;

namespace ProjectBolo.CakeProcessors.CakeFileExecute
{
    public class CakeFileProcessorExecute : CakeFile
    {
        public void PrintCakeFile()
        {
            ReadNamesFilesToList();

            StringOrder.BubbleSort(namesList);

            var n = 0;
            foreach (var data in Dates.GetDates())
            {
                if (n == namesList.Count)
                    n = 0;

                Console.WriteLine("Nomes: {0}  Bolo: {1} ", namesList[n], data);
                n++;
            }

            Console.ReadKey();
        }
    }
}
