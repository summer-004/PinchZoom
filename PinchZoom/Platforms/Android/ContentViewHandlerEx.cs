using Android.Content;
using Android.Views;
using Microsoft.Maui.Controls.Handlers.Compatibility;

namespace PinchZoom.Platforms.Android
{
    public class ContentViewHandlerEx : ViewRenderer
    {
        public ContentViewHandlerEx(Context context) : base(context)
        {
        }

        public override bool OnInterceptTouchEvent(MotionEvent? ev)
        {
            //return base.OnInterceptTouchEvent(ev);
            return MainPage.flag;
        }
        public override bool OnTouchEvent(MotionEvent? e)
        {
            //return base.OnTouchEvent(e);
            return MainPage.flag;
        }

    }
}
