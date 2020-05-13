using System.Collections.Generic;
using Google.Apis.Sheets.v4;
using Google.Apis.Sheets.v4.Data;
using Google.Sheet.Application.Core.Processors.CredentialUser;
using BoloProject.Processors.Dates;
using BoloProject.Processors.Implementations.ReadFile;

namespace Google.Sheet.Application.Core.Processors.ManipulateSheet
{
    public class ManipulateSheets : FileUserCredentials
    {
        static readonly string UserId = "1XxBl1WTExwoN--rbbqQ7InFNsWnqWUF5InoH6eEp7wk";

        static readonly string sheets = "Página1";

        public void InsertValues(Path path)
        {
            var ListNames = path.NamesList;
            List<object> Nomes = new List<object>(ListNames);

            var inputData = FindDates.GetDatas();
            var valueRange = new ValueRange();

            var range = $"{sheets}!C:C";
            valueRange.MajorDimension = "COLUMNS";

            valueRange.Values = new List<IList<object>> { inputData };

            var appendRequest = service.Spreadsheets.Values.Append(valueRange, UserId, range);
            appendRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;

            appendRequest.Execute();
        }
    }

}
