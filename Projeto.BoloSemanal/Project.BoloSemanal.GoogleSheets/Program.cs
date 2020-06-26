using Project.BoloSemanal.GoogleSheets.Initializer;

namespace Project.BoloSemanal.GoogleSheets
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteSheetProcessor x = new ExecuteSheetProcessor();
            x.Start();
        }
    }
}
