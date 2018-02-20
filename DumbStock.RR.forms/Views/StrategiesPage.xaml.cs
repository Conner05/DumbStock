using System;
using System.Collections.Generic;
using DumbStock.RR.Models;
using DumbStock.RR.ViewModels;
using Xamarin.Forms;

namespace DumbStock.RR
{
    public partial class StrategiesPage : ContentPage
    {
        StrategiesViewModel viewModel;

        public StrategiesPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new StrategiesViewModel();
        }

        async void OnStrategySelected(object sender, SelectedItemChangedEventArgs args)
        {
            var strategy = args.SelectedItem as Strategy;
            if (strategy == null)
                return;

            await Navigation.PushAsync(new StrategyDetailPage(new StrategyDetailViewModel(strategy)));

            // Manually deselect strategy
            StrategiesListView.SelectedItem = null;
        }

        async void AddStrategy_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewStrategyPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Strategies.Count == 0)
                viewModel.LoadStrategiesCommand.Execute(null);
        }
    }
}
