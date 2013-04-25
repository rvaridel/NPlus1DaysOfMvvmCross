using Android.App;
using Android.OS;
using Cirrious.MvvmCross.Droid.Views;

namespace MultiPage.Droid.Views
{
    [Activity(Label = "View for SecondViewModel")]
    public class SecondView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.SecondView);
        }
    }
}