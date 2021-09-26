using MauiWork.Helpers;
using MauiWork.Services;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Microsoft.Maui.Essentials;
using System;
using Application = Microsoft.Maui.Controls.Application;

namespace MauiWork
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            ThemeSettings.SetTheme();

            MainPage = new AppShell();
        }

        protected override void OnResume()
        {
            base.OnResume();
            ThemeSettings.SetTheme();
            RequestedThemeChanged += App_RequestedThemeChanged;
        }

        protected override void OnSleep()
        {
            base.OnSleep();
            ThemeSettings.SetTheme();
            RequestedThemeChanged -= App_RequestedThemeChanged;
        }

        protected override void OnStart()
        {
            base.OnStart();
        }

        private void App_RequestedThemeChanged(object sender, AppThemeChangedEventArgs e)
        {
            MainThread.BeginInvokeOnMainThread(() =>
            {
                ThemeSettings.SetTheme();
            });
        }
    }
}
