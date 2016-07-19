using Google.Apis.Auth.OAuth2;
using Google.Apis.Plus.v1;
using Google.Apis.Services;
using Google.Apis.Util.Store;

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace YoutubeApisDemo
{
    public class GoogleAccountApis
    {
        private PlusService pService = Auth();

        private static PlusService Auth()
        {
            try
            {
                UserCredential creds;
                using (var stream = new FileStream("google_plus.json", FileMode.Open, FileAccess.Read))
                {
                    creds = GoogleWebAuthorizationBroker.AuthorizeAsync(
                            GoogleClientSecrets.Load(stream).Secrets, new[] { PlusService.Scope.UserinfoProfile }, "user", CancellationToken.None, new FileDataStore("GooglePlusSignedIn")).Result;
                }

                var service = new PlusService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = creds,
                    ApplicationName = "GooglePlusSigned",
                });
                return service;
            }
            catch (AggregateException ex)
            {
                foreach(var e in ex.InnerExceptions)
                {
                    throw new Exception(e.Message);
                }
                return null;
            }
        }

        public static void GetAccountInfo(GoogleAccount account)
        {
            try
            {
                //var accountRequest = pService.
            }
            catch (AggregateException ex)
            {
                foreach (var e in ex.InnerExceptions)
                {
                    throw new Exception(e.Message);
                }
            }
        }
        
    }
}
