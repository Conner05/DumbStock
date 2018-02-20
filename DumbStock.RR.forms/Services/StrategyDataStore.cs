using System;
using DumbStock.RR.Models;

namespace DumbStock.RR.forms.Services
{
    public class StrategyDataStore : FirebaseDataStore<Strategy>
    {
        protected override string Path { get; set; }
    }
}
