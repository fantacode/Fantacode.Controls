using System;
using Xamarin.Forms;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Support.V4.Content;
using Xamarin.Forms.Platform.Android.AppCompat;
using Android.Widget;
using Fantacode.Controls;
using Fantacode.Controls.Droid;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]
namespace Fantacode.Controls.Droid
{
    public class CustomPickerRenderer : PickerRenderer
    {
        CustomPicker element;

        public CustomPickerRenderer(Context context) : base(context)
        {

        }


        protected override void OnElementChanged(Xamarin.Forms.Platform.Android.ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            element = (CustomPicker)this.Element;

            Control.Gravity = Android.Views.GravityFlags.Bottom | Android.Views.GravityFlags.Left;

            if (Control != null && this.Element != null)
            {
                if(!string.IsNullOrWhiteSpace(element.Arrow))
                Control.Background = AddPickerStyles(element.Arrow);
            else
                    Control.Background = null;
            }

            Control.SetPadding(0, 0, 0, 0);
        }

        public LayerDrawable AddPickerStyles(string imagePath)
        {
            //var line = Context.GetDrawable(Resource.Drawable.pickerLine);
            Drawable[] layers = { GetDrawable(imagePath) };
            LayerDrawable layerDrawable = new LayerDrawable(layers);
            layerDrawable.SetLayerInset(0, 0, 0, 0, 0);

            return layerDrawable;
        }

        private BitmapDrawable GetDrawable(string imagePath)
        {
            int resID = Resources.GetIdentifier(imagePath,"drawable", this.Context.PackageName);
            var drawable = ContextCompat.GetDrawable(this.Context,resID);
            var bitmap = ((BitmapDrawable)drawable).Bitmap;

            var result = new BitmapDrawable(Resources, bitmap);
            result.Gravity = Android.Views.GravityFlags.Right;

            return result;
        }
    }
}
