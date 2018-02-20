using System;
using System.Net.Http;
using System.Threading.Tasks;
using Firebase.Auth;
using Firebase.Database;

namespace DumbStock.RR.forms.Services
{
    public class AuthService
    {
        HttpClient client;
        public static FirebaseClient firebase;
        const string BACKEND_URL = "https://homeful-d9f3c.firebaseio.com/";

        public static async Task<FirebaseClient> Create()
        {
            var authService = new AuthService();
            firebase = await authService.Initialize();
            return firebase;
        }

        private AuthService()
        {
            client = new HttpClient
            {
                BaseAddress = new Uri($"{BACKEND_URL}/")
            };
        }

        private async Task<FirebaseClient> Initialize()
        {
            var authProvider = new FirebaseAuthProvider(new FirebaseConfig("AIzaSyD8cbGyYVO2WzGIOTnN9VYWRa0aJKP9KDs"));
            //var facebookAccessToken = "dvnu1F1OjLSA4pYDJN-tq4EJ";

            var auth = await authProvider.SignInAnonymouslyAsync();

            var fb = new FirebaseClient(BACKEND_URL,
              new FirebaseOptions
              {
                  AuthTokenAsyncFactory = () => Task.FromResult(auth.FirebaseToken)
              });

            return fb;
        }
    }
}
