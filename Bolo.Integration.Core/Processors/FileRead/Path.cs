using Bolo.Integration.Domain.Entities;

namespace Bolo.Integration.Core.Processors.FileRead
{
    public class Path : FileAtributes
    {
        public void ReadFileNamesToList()
        {
            while (!ReadFile.EndOfStream)
            {
                string readNames;

                readNames = ReadFile.ReadLine();

                NamesList.Add(readNames);
            }
        }
    }
}
