using System;
using System.Collections.Generic;
using DumbStock.RR.Models;
using DumbStock.RR.ViewModels;
using Xamarin.Forms;

namespace DumbStock.RR
{
    public partial class StrategyDetailPage : ContentPage
    {
        StrategyDetailViewModel viewModel;

        // Note - The Xamarin.Forms Previewer requires a default, parameterless constructor to render a page.
        public StrategyDetailPage()
        {
            InitializeComponent();

            var strategy = new Strategy
            {
                Ticker = "TSTS"
            };

            viewModel = new StrategyDetailViewModel(strategy);
            BindingContext = viewModel;
        }

        public StrategyDetailPage(StrategyDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }
    }
}
