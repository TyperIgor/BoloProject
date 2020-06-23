using Google.Sheet.Application.Core.Processors.CredentialUser;
using Google.Sheet.Application.Core.Processors.ManipulateSheet;
using Bolo.Integration.Core.Processors.FileRead;

namespace Google.Sheet.Application.Initializer
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
