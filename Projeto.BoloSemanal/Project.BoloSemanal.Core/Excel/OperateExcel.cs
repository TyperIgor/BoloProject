using Bytescout.Spreadsheet;
using Project.BoloSemanal.Core.Dates;
using Project.BoloSemanal.Core.Processors.FileRead;

namespace Project.BoloSemanal.Core.Excel
{
    public class OperateExcel
    {
        public void ExecuteExcel(Path path)
        {
            Spreadsheet spreadsheet = new Spreadsheet();
            Worksheet sheets = spreadsheet.Workbook.Worksheets.Add("Bolinho");

            var Datas = FindDates.GetDatas();
            var ListNames = path.NamesList;

            sheets.Cell(0, 0).Value = "Nomes:";
            sheets.Cell(0, 1).Value = "Datas:";

            sheets.Columns[0].Width = 200;
            sheets.Columns[1].Width = 150;

            var line = 0;
            var indexList = 0;

            foreach (var dates in Datas)
            {
                if (indexList == ListNames.Count)
                    indexList = 0;

                sheets.Cell(line + 1, 1).Value = dates;
                sheets.Cell(line + 1, 0).Value = ListNames[indexList];

                line++;
                indexList++;
            }

            spreadsheet.SaveAs("ProximoBolo.xlsx");
            spreadsheet.Close();
        }


    }
}
