using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using LitFinder.Models;
using LitFinder.ViewModels;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace LitFinder.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();

            BindingContext = this.BindingContext;
        }

        protected override void OnAppearing()
        {
            Settings.DisableBack = true;
            MessagingCenter.Subscribe<LoginViewModel, string>(this, "Alert", (obj, arg) =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    LoadingDisplay(false);
                    System.Diagnostics.Debug.WriteLine("MessagingCenter in LoginPage Hit");
                    DisplayAlert("Alert", arg, "OK");
                });
            });

            MessagingCenter.Subscribe<LoginViewModel, string>(this, "LoginComplete", (obj, arg) =>
            {
                Device.BeginInvokeOnMainThread(() =>
                {
                    try
                    {
                        Navigation.PushAsync(new MainPage());
                    }
                    catch (Exception e)
                    {
                        System.Diagnostics.Debug.WriteLine("LoginPage MainPage() Navigation Exception: " + e);
                    }
                    LoadingDisplay(false);
                });
            });
        }

        protected override void OnDisappearing()
        {
            MessagingCenter.Unsubscribe<LoginViewModel, string>(this, "Alert");
            MessagingCenter.Unsubscribe<LoginViewModel, string>(this, "LoginComplete");
        }

        void Login_Clicked(object sender, EventArgs e)
        {
            LoadingDisplay(true);
        }

        void LoadingDisplay(bool show)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                btnLogin.IsVisible = !show;
                loadingIndicator.IsVisible = show;
                loadingIndicator.IsRunning = show;
            });
        }
    }
}