using Project.BoloSemanal.Domain.Entities;

namespace Project.BoloSemanal.Core.Processors.FileRead
{
    public class Path : FileAtributes
    {
        public void ReadFileNamesTolist()
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
