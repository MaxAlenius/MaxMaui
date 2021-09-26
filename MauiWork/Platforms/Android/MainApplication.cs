using Android.App;
using Android.OS;
using Android.Runtime;
using MauiWork.Helpers;
using MauiWork.Services;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using System;
using System.Drawing;
using static MauiWork.MainApplication;

[assembly: Dependency(typeof(Toaster))]


namespace MauiWork
{
    [Application]
    public class MainApplication : MauiApplication
    {
        public MainApplication(IntPtr handle, JniHandleOwnership ownership)
            : base(handle, ownership)
        {
            DependencyService.Register<IToast, Toaster>();
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        public class Toaster : IToast
        {
            public string MakeToast()
            {
                if (Build.VERSION.SdkInt < BuildVersionCodes.Lollipop)
                    return "hej";

                var activity = Platform.CurrentActivity;
                System.Diagnostics.Debug.WriteLine($"{activity.Title}");

                //var window = activity.Window;
                //window.AddFlags(Android.Views.WindowManagerFlags.DrawsSystemBarBackgrounds);
                //window.ClearFlags(Android.Views.WindowManagerFlags.TranslucentStatus);
                //window.SetStatusBarColor(new Android.Graphics.Color(100,100,244));

                //if (Build.VERSION.SdkInt >= BuildVersionCodes.M)
                //{
                //    var flag = (Android.Views.StatusBarVisibility)Android.Views.SystemUiFlags.LightStatusBar;
                //    window.DecorView.SystemUiVisibility = false ? flag : 0;
                //}
                return "klar";
            }
        }

        //public class DeviceEnvironment : IDeviceEnvironment
        //{
        //    public void SetStatusBarColor(Color color, bool darkStatusColorTint)
        //    {
        //        if (Build.VERSION.SdkInt < BuildVersionCodes.Lollipop)
        //            return;

        //        var activity = Platform.CurrentActivity;
        //        var window = activity.Window;
        //        window.AddFlags(Android.Views.WindowManagerFlags.DrawsSystemBarBackgrounds);
        //        window.ClearFlags(Android.Views.WindowManagerFlags.TranslucentStatus);
        //        var r = color.R;
        //        var g = color.G;
        //        var b = color.B;
        //        window.SetStatusBarColor(new Android.Graphics.Color(r, g, b));

        //        if (Build.VERSION.SdkInt >= BuildVersionCodes.M)
        //        {
        //            var flag = (Android.Views.StatusBarVisibility)Android.Views.SystemUiFlags.LightStatusBar;
        //            window.DecorView.SystemUiVisibility = darkStatusColorTint ? flag : 0;
        //        }
        //    }
        //}
    }
}