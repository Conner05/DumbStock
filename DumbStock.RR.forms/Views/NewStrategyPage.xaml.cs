using System;
using System.Collections.Generic;
using DumbStock.RR.Models;
using Xamarin.Forms;

namespace DumbStock.RR
{
    public partial class NewStrategyPage : ContentPage
    {
        public Strategy Strategy { get; set; }

        public NewStrategyPage()
        {
            InitializeComponent();

            Strategy = new Strategy();
            BindingContext = this;
        }
        private void Price_TextChanged(object sender, TextChangedEventArgs args)
        {
            var price = double.TryParse(args.NewTextValue, out double res) ? res : 0;
            Strategy.Price = price;
        }
        private void Shares_TextChanged(object sender, TextChangedEventArgs args)
        {
            var shares = int.TryParse(args.NewTextValue, out int res) ? res : 0;
            Strategy.NumShares = shares;
        }
        async void Save_Clicked(object sender, EventArgs e)
        {
            Strategy.Price = double.TryParse(Price, out var dblPrice) ? dblPrice : 0;
            Strategy.NumShares = int.TryParse(Shares, out var intShares) ? intShares : 0;
            MessagingCenter.Send(this, "AddStrategy", Strategy);
            await Navigation.PopToRootAsync();
        }
    }
}
