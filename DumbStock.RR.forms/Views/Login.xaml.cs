using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace DumbStock.RR.Views
{
    public partial class Login : ContentPage
    {
        bool authenticated = false;
        public Login()
        {
            InitializeComponent();
        }

        async void loginButton_Clicked(object sender, EventArgs e)
        {
            if (App.Authenticator != null)
                authenticated = await App.Authenticator.Authenticate();

            // Set syncItems to true to synchronize the data on startup when offline is enabled.
            //if (authenticated == true)
            //    await RefreshItems(true, syncItems: false);
        }
    }
}
