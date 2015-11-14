using Android.Widget;
using App1.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(MyToast))]
namespace App1.Droid {
    class MyToast:IMyToast {
        public void Show(string message) {
            Toast.MakeText(Android.App.Application.Context, message, ToastLength.Short).Show();
        }
    }
}