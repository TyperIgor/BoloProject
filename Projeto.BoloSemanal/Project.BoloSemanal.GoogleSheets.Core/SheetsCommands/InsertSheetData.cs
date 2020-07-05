using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Project.BoloSemanal.GoogleSheets.Core.CredentialUser;
using Project.BoloSemanal.Core.Dates;
using Project.BoloSemanal.Core.Processors.FileRead;
using System.Collections.Generic;


namespace Project.BoloSemanal.GoogleSheets.Core.SheetsCommands
{
    public class ManipulateSheets : FileUserCredentials
    {
        static readonly string UserId = "1XxBl1WTExwoN--rbbqQ7InFNsWnqWUF5InoH6eEp7wk";

        static readonly string sheets = "Página1";

        private Path _path;

        public ManipulateSheets()
        {
            _path = new Path();
        }

        public void InsertValues()
        {
            var ListNames = _path.NamesList;
            List<object> Nomes = new List<object>(ListNames);

            var inputData = FindDates.GetDatas();
            var valueRange = new ValueRange();

            var range = $"{sheets}!E:E";
            valueRange.MajorDimension = "COLUMNS";

            valueRange.Values = new List<IList<object>> { inputData };

            var appendRequest = service.Spreadsheets.Values.Append(valueRange, UserId, range);
            appendRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;

            appendRequest.Execute();
        }
    }
}
