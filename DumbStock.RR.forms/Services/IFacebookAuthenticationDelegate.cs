using System;
using DumbStock.RR.forms.Models;

namespace DumbStock.RR.forms.Services
{
    public interface IFacebookAuthenticationDelegate
    {
        void OnAuthenticationCompleted(FacebookOAuthToken token);
        void OnAuthenticationFailed(string message, Exception exception);
        void OnAuthenticationCanceled();
    }
}
