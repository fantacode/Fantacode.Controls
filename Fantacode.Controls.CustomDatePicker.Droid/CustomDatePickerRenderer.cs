using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Support.V4.Content;
using Fantacode.Controls;
using Fantacode.Controls.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomDatePicker), typeof(CustomDatePickerRenderer))]
namespace Fantacode.Controls.Droid
{
    public class CustomDatePickerRenderer : DatePickerRenderer
    {
        CustomDatePicker element;

        public CustomDatePickerRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);

            element = (CustomDatePicker)this.Element;

            Control.Gravity = Android.Views.GravityFlags.Bottom | Android.Views.GravityFlags.Center;

            if (Control != null && this.Element != null)
            {
                if (!string.IsNullOrWhiteSpace(element.Image))
                    Control.Background = AddPickerStyles(element.Image);
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
            int resID = Resources.GetIdentifier(imagePath, "drawable", this.Context.PackageName);
            var drawable = ContextCompat.GetDrawable(this.Context, resID);
            var bitmap = ((BitmapDrawable)drawable).Bitmap;

            var result = new BitmapDrawable(Resources, bitmap);
            result.Gravity = Android.Views.GravityFlags.Right;
            return result;
        }
    }
}
