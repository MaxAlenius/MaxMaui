using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiWork.Helpers
{
    public static class ThemeSettings
    {
        // 0 = default, 1 = light, 2 = dark
        const int theme = 0;

        public static int Theme {
            get => Preferences.Get(nameof(Theme), theme);
            set => Preferences.Set(nameof(Theme), value);
        }

        public static void SetTheme()
        {
            switch (ThemeSettings.Theme)
            {
                //default
                case 0:
                    App.Current.UserAppTheme = OSAppTheme.Unspecified;
                    break;
                //light
                case 1:
                    App.Current.UserAppTheme = OSAppTheme.Light;
                    break;
                //dark
                case 2:
                    App.Current.UserAppTheme = OSAppTheme.Dark;
                    break;
            }

            //IDeviceEnvironment service = DependencyService.Get<IDeviceEnvironment>();
            //service.SetStatusBarColor(Color.Black, false);

            //var e = DependencyService.Get<IDeviceEnvironment>();
            //if (e != null)
            //{
            //    System.Diagnostics.Debug.WriteLine("Not null");
            //}
            //else
            //{
            //    System.Diagnostics.Debug.WriteLine("Null");
            //}


            //if (App.Current.RequestedTheme == OSAppTheme.Dark)
            //{
            //    e?.SetStatusBarColor(Color.Black, false);
            //}
            //else
            //{
            //    e?.SetStatusBarColor(Color.White, true);
            //}


        }
    }
}
