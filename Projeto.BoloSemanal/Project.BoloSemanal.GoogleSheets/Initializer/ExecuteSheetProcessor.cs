using Project.BoloSemanal.Core.Processors.FileRead;
using Project.BoloSemanal.GoogleSheets.Core.CredentialUser;
using Project.BoloSemanal.GoogleSheets.Core.SheetsCommands;
 

namespace Project.BoloSemanal.GoogleSheets.Initializer
{
    public class ExecuteSheetProcessor
    {
        FileUserCredentials _userCredentials;
        ManipulateSheets _manipulateSheets;
        Path _path;

        public ExecuteSheetProcessor()
        {
            _userCredentials = new FileUserCredentials();
            _manipulateSheets = new ManipulateSheets();
            _path = new Path();
        }

        public void Start()
        {
            _userCredentials.ValidateUser();
            _manipulateSheets.InsertValues(_path);
        }
    }
}
