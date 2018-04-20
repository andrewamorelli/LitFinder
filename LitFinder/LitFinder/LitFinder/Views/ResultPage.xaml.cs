using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using LitFinder.Models;
using Xamarin.Forms.Maps;

namespace LitFinder.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultPage : ContentPage
    {
        public ResultPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public ResultPage(bool isLit, string address, double latitude, double longitude)
        {
            InitializeComponent();
            var position = new Position(latitude, longitude);
            addressLabel.Text = "Location: " + address;
            isLitLabel.IsVisible = isLit;
            isNotLitLabel.IsVisible = !isLit;
            try
            {
                Map.MoveToRegion(MapSpan.FromCenterAndRadius(position, Distance.FromMiles(0.35)));
                var pin = new Pin
                {
                    Type = PinType.Place,
                    Position = position,
                    Label = "{Label}",
                    Address = "{Address}"
                };
                Map.Pins.Add(pin);
            }
            catch (Exception exc)
            {
                System.Diagnostics.Debug.WriteLine("Exception in Map.MoveToRegion() : " + exc);
            }

            BindingContext = this;
        }
    }
}