using BoloProject.Domain.Entities;

namespace BoloProject.Processors.Implementations.FileRead
{
    public class BoloFileRead : BoloEntity
    {
        public void ReadFileNamesToList()
        {
            while(!ReadFile.EndOfStream)
            {
                string ReadNames;

                ReadNames = ReadFile.ReadLine();

                Names.Add(ReadNames);
            }
        }
    }
}
