using System;
using System.Windows.Input;
using System.Collections.ObjectModel;

using Xamarin.Forms;

using LitFinder.Models;
using LitFinder.Views;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace LitFinder.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {

        public ICommand LoginCommand { get; private set; }
        List<string> configList = new List<string>();
        bool busy = false;
        

        public LoginViewModel()
        {
            Title = "Login";

            Username = Settings.DefaultUsername;
            
            LoginCommand = new Command<string>(async (key) => {
                MessagingCenter.Send(this, "LoginComplete", Settings.InfobarMessage);
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

        public string Username
        {
            get => Settings.Username;
            set
            {
                if (Settings.Username == value)
                    return;

                Settings.Username = value;
                OnPropertyChanged();
            }
        }

        public string DefaultUsername
        {
            get => Settings.DefaultUsername;
            set
            {
                if (Settings.DefaultUsername == value)
                    return;

                Settings.DefaultUsername = value;
                OnPropertyChanged();
            }
        }

        public string Configuration
        {
            get => Settings.ConfigName;
            set
            {
                if (Settings.ConfigName == value)
                    return;

                Settings.ConfigName = value;
                OnPropertyChanged();
            }
        }

        public string DefaultConfiguration
        {
            get => Settings.DefaultConfigName;
            set
            {
                if (Settings.DefaultConfigName == value)
                    return;

                Settings.DefaultConfigName = value;
                OnPropertyChanged();
            }
        }

        public string ServerConnectionString
        {
            get => Settings.ServerConnectionString;
            set
            {
                if (Settings.ServerConnectionString == value)
                    return;
                Settings.ServerConnectionString = value;
                OnPropertyChanged();
            }
        }

        public string ServerName
        {
            get => Settings.ServerName;
            set
            {
                if (Settings.ServerName == value)
                    return;
                Settings.ServerName = value;
                OnPropertyChanged();
            }
        }

        public List<string> ConfigList
        {
            get => configList; 
            set
            {
                if (configList == value)
                    return;

                configList = value;
                OnPropertyChanged();
            }
        }
    }
}