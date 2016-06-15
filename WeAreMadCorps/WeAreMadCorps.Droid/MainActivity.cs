using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using ImageCircle.Forms.Plugin.Droid;
using FFImageLoading.Forms.Droid;

namespace WeAreMadCorps.Droid
{
    [Activity(Label = "WeAreMadCorps", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
          
            global::Xamarin.Forms.Forms.Init(this, bundle);
            CachedImageRenderer.Init();
            ImageCircleRenderer.Init();
            LoadApplication(new App());
            
        }
    }
}

