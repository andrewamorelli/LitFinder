using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;

using Xamarin.Forms;

using LitFinder.Models;
using LitFinder.Views;

namespace LitFinder.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand SearchCommand { get; private set; }
        bool busy = false;

        public MainViewModel()
        {
            Title = "Address Search";

            SearchCommand = new Command<string>(async (key) => {
                //MessagingCenter.Send(this, "LoginComplete", Settings.InfobarMessage);
            });
        }

        public bool Busy
        {
            get => busy;
            set
            {
                if (busy == value)
                    return;

                busy = value;
                OnPropertyChanged();
                OnPropertyChanged("NotBusy");
            }
        }

        public bool NotBusy
        {
            get
            {
                if (Busy)
                    return false;
                else
                    return true;
            }
            set => Busy = !value;
        }
    }
}