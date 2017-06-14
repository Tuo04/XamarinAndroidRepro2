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

            //MobileCenter.SetLogUrl("https://in-staging-south-centralus.staging.avalanch.es");

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            MobileCenter.Start("a3edca7d-629d-402a-af32-88c32ddcc24b",
                   typeof(Analytics), typeof(Crashes));
        }
    }
}

