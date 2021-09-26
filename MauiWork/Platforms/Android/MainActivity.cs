using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Widget;
using MauiWork.Droid;
using MauiWork.Helpers;
using MauiWork.Services;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using System.Drawing;


namespace MauiWork.Droid
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize)]
    public class MainActivity : MauiAppCompatActivity
    {



		protected override void OnResume()
		{
			base.OnResume();

			Microsoft.Maui.Essentials.Platform.OnResume(this);
		}

		protected override void OnNewIntent(Android.Content.Intent intent)
		{
			base.OnNewIntent(intent);

			Microsoft.Maui.Essentials.Platform.OnNewIntent(intent);
		}

    }
}