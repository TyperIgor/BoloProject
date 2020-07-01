using Project.BoloSemanal.Core.Excel;
using Project.BoloSemanal.Core.Ordenation;
using Project.BoloSemanal.Core.Processors.FileRead;

namespace Project.BoloSemanal.Initializer
{
    public class ExecuteIntegration
    {
        Path _path;
        OperateExcel _excel;
        public ExecuteIntegration()
        {
            _excel = new OperateExcel();
            _path = new Path();
        }

        public void Start()
        {
            _path.ReadFileNamesTolist();
            BubbleOrder.BubbleSort(_path.NamesList);
            _excel.ExecuteExcel(_path);
        }
    }
}
