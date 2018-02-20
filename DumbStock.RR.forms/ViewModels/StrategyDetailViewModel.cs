using System;
using DumbStock.RR.Models;

namespace DumbStock.RR.ViewModels
{
    public class StrategyDetailViewModel : BaseViewModel
    {
        public Strategy Strategy { get; set; }
        public StrategyDetailViewModel(Strategy strategy = null)
        {
            Title = strategy?.Ticker;
            Strategy = strategy;
        }
    }
}
