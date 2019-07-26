using System;
using System.ComponentModel;
using Foundation;
using Fantacode.Controls;
using Fantacode.Controls.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace Fantacode.Controls.iOS
{
    public class CustomEntryRenderer : EntryRenderer
    {
        public CustomEntryRenderer()
        {

        }

        public static void Initialize()
        {

        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            var element = (CustomEntry)this.Element;

            if (element == null)
                return;

            Control.Layer.BorderWidth = 0;
            Control.BorderStyle = UITextBorderStyle.None;
        }
    }
}
