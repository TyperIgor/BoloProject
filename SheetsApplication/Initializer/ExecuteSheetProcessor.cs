using BoloProject.Processors.Implementations.ReadFile;
using Google.Sheet.Application.Core.Processors.CredentialUser;
using Google.Sheet.Application.Core.Processors.ManipulateSheet;
using BoloProject.Processors.Ordernation;


namespace Google.Sheet.Application.Initializer
{
    public class ExecuteSheetProcessor
    {
        public FileUserCredentials userCredentials = new FileUserCredentials();
        public ManipulateSheets Sheets = new ManipulateSheets();
        public Path file = new Path();

        FileUserCredentials _userCredentials;
        Path _path;
        ManipulateSheets _manipulateSheets;

        public ExecuteSheetProcessor()
        {
            _path = file;
            _manipulateSheets = Sheets;
            _userCredentials = userCredentials;
        }

        public void Start()
        {
            _path.ReadFileNamesToList();
            BubleOrder.BubbleSort(_path.NamesList);
            _userCredentials.ValidateUser();
            _manipulateSheets.InsertValues(_path);
        }
    }
}
