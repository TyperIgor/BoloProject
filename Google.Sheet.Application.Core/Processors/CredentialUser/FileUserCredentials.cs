using Google.Apis.Auth.OAuth2;
using Google.Apis.Sheets.v4;
using System.IO;

namespace Google.Sheet.Application.Core.Processors.CredentialUser
{
     public class FileUserCredentials
     {
        private static readonly FileStream _userFile = new FileStream("GoogleProject.json", FileMode.Open, FileAccess.Read);

        private static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };

        private static readonly string ApplicationName = "Test Bolo integration";

        public static FileStream FileUser { get { return _userFile; } }

        protected static SheetsService service;

        private static GoogleCredential credential;

        public void ValidateUser()
        {
            credential = GoogleCredential.FromStream(FileUser).CreateScoped(Scopes);

            service = new SheetsService(new Apis.Services.BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }
    }
}
