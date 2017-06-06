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

            MobileCenter.Start("2f2cdbfd-e99e-4680-84e3-61308200eceb",
                   typeof(Analytics), typeof(Crashes));
        }
    }
}

