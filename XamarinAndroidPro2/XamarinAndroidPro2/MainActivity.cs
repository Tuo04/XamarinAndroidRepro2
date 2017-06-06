using Android.App;
using Android.Widget;
using Android.OS;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace XamarinAndroidPro2
{
    [Activity(Label = "XamarinAndroidPro2", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            MobileCenter.Start("5e27edb7-974f-46bc-baa2-a16d62a33644",
                   typeof(Analytics), typeof(Crashes));
        }
    }
}

