using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectBolo.CakeDomain;

namespace ProjectBolo.CakeProcessors
{
    public class CakeFile : CakeEntities
    {
        public void ReadNamesFilesToList()
        {
            while (!ReadFile.EndOfStream)
            {
                string ReadNames;

                ReadNames = ReadFile.ReadLine();

                namesList.Add(ReadNames);
            }
            
        }
    }
}
