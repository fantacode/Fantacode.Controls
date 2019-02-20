using System;
using Android.Content;
using Fantacode.Controls;
using Fantacode.Controls.Droid;
using Java.Lang;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace Fantacode.Controls.Droid
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Background = null;
                var layoutParams = new MarginLayoutParams(Control.LayoutParameters);
                layoutParams.SetMargins(0, 0, 0, 0);
                LayoutParameters = layoutParams;
                Control.LayoutParameters = layoutParams;
                Control.SetPadding(0, 0, 0, 0);
                SetPadding(0, 0, 0, 0);
            }
        }

        public override bool PerformLongClick()
        {
            try
            {
                return base.PerformLongClick();
            }
            catch(NullPointerException e)
            {
                return true;
            }
            catch(System.Exception e)
            {
                return true;
            }
        }

        public override bool PerformLongClick(float x, float y)
        {
            try
            {
                return base.PerformLongClick(x, y);
            }
            catch(NullPointerException e)
            {
                return true;
            }
            catch(System.Exception e)
            {
                return true;
            }
        }
    }
}
