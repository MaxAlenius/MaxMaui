using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace MaxMaui
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int count = 0;
        private async void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            CounterLabel.Text = $"Current count: {count}";
            await DisplayAlert("Internet", Connectivity.NetworkAccess.ToString(), "Ok");
        }
    }
}
