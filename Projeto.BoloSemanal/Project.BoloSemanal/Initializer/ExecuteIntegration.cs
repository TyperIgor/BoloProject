using Project.BoloSemanal.Core.Excel;
using Project.BoloSemanal.Core.Ordenation;
using Project.BoloSemanal.Core.Processors.FileRead;

namespace Project.BoloSemanal.Initializer
{
    public class ExecuteIntegration
    {
        Path path = new Path();
        OperateExcel excel = new OperateExcel();

        Path _path;
        OperateExcel _excel;
        public ExecuteIntegration()
        {
            _excel = excel;
            _path = path;
        }

        public void Start()
        {
            _path.ReadFileNamesTolist();
            BubbleOrder.BubbleSort(_path.NamesList);
            _excel.ExecuteExcel(_path);
        }
    }
}
