using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using LitFinder.Models;
using LitFinder.Views;
using LitFinder.ViewModels;
using Xamarin.Forms.Maps;

namespace LitFinder.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
    {
        Geocoder geoCoder;

        public MainPage()
        {
            InitializeComponent();

            BindingContext = this.BindingContext;
            geoCoder = new Geocoder();
        }
        protected override void OnAppearing()
        {
            Settings.DisableBack = false;
        }

        protected override void OnDisappearing()
        {
        }

        async void Search_Clicked(object sender, EventArgs e)
        {
            bool locationFound = false;
            double latitude = 0.0;
            double longitude = 0.0;
            var address = addressText.Text;
            if(!String.IsNullOrEmpty(address))
            {
                var approximateLocations = await geoCoder.GetPositionsForAddressAsync(address);
                foreach (var position in approximateLocations)
                {
                    System.Diagnostics.Debug.WriteLine("Position: " + position.Latitude + ", " + position.Longitude);
                    latitude = position.Latitude;
                    longitude = position.Longitude;
                    //geocodedOutputLabel.Text += position.Latitude + ", " + position.Longitude + "\n";
                    locationFound = true;
                }
            }
            if(locationFound)
            {
                try
                {
                    await Navigation.PushAsync(new ResultPage(true, address, latitude, longitude));
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("MainPage ResultPage() Navigation Exception: " + ex);
                }
            }
            else
            {
                await DisplayAlert("Alert", "Address could not be found.", "OK");
            }
        }

        void LoadingDisplay(bool show)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                btnSearch.IsVisible = !show;
                loadingIndicator.IsVisible = show;
                loadingIndicator.IsRunning = show;
            });
        }
    }
}