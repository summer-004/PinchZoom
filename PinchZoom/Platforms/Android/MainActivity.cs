using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace PinchZoom
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        public override bool DispatchTouchEvent(MotionEvent? e)
        {
            if (e?.PointerCount == 1)
            {
                //MainPage._drawingView.InputTransparent = false;
            }
            else
            {
                //MainPage._drawingView.InputTransparent = true;
            }

            return base.DispatchTouchEvent(e);

            //return e?.PointerCount == 1 && base.DispatchTouchEvent(e);
        }

    }
}
