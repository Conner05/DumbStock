using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using DumbStock.RR.Models;
using DumbStock.RR.Views;
using Firebase.Database;
using Xamarin.Forms;

namespace DumbStock.RR
{
    public class StrategiesViewModel : BaseViewModel
    {
        public ObservableCollection<FirebaseObject<Strategy>> Strategies { get; set; }
        public Command LoadStrategiesCommand { get; set; }

        public StrategiesViewModel()
        {
            Title = "Browse";
            Strategies = new ObservableCollection<FirebaseObject<Strategy>>();
            LoadStrategiesCommand = new Command(async () => await ExecuteLoadStrategiesCommand());

            MessagingCenter.Subscribe<NewStrategyPage, Strategy>(this, "AddStrategy", async (obj, strategy) =>
            {
                var _strategy = strategy as Strategy;
                await DataStore.AddAsync(_strategy);
            });
        }

        async Task ExecuteLoadStrategiesCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Strategies = await DataStore.ListSubscribe();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
