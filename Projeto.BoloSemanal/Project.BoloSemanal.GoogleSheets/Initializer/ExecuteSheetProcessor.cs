using Project.BoloSemanal.Core.Processors.FileRead;
using Project.BoloSemanal.GoogleSheets.Core.CredentialUser;
using Project.BoloSemanal.GoogleSheets.Core.SheetsCommands;
 

namespace Project.BoloSemanal.GoogleSheets.Initializer
{
    public class ExecuteSheetProcessor
    {
        public FileUserCredentials userCredentials = new FileUserCredentials();
        public ManipulateSheets Sheets = new ManipulateSheets();
        public Path path = new Path();

        FileUserCredentials _userCredentials;
        ManipulateSheets _manipulateSheets;
        Path _path;

        public ExecuteSheetProcessor()
        {
            _userCredentials = userCredentials;
            _manipulateSheets = Sheets;
            _path = path;
        }

        public void Start()
        {
            _userCredentials.ValidateUser();
            _manipulateSheets.InsertValues(_path);
        }
    }
}
