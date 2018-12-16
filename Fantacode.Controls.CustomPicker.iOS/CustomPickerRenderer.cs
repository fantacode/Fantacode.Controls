using System;
using Xamarin.Forms;
using CoreAnimation;
using CoreGraphics;
using UIKit;
using Xamarin.Forms.Platform.iOS;
using Fantacode.Controls;
using Fantacode.Controls.iOS;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]
namespace Fantacode.Controls.iOS
{
    public class CustomPickerRenderer : PickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            var element = (CustomPicker)this.Element;

            Control.BorderStyle = UITextBorderStyle.None;
            Control.BackgroundColor = null;

            if (element == null)
                return;
                
            e.NewElement.SizeChanged += (obj, args) =>
            {
                var picker = obj as Picker;
                if (picker == null)
                    return;

                if (this.Control != null && this.Element != null && !string.IsNullOrEmpty(element.Arrow))
                {
                    if (!string.IsNullOrWhiteSpace(element.Arrow))
                    {
                        var image = UIImage.FromBundle(element.Arrow);
                        Control.RightViewMode = UITextFieldViewMode.Always;
                        Control.RightView = new UIImageView(image);
                    }
                    //Control.MaskView = new UIImageView(downarrow);
                    // Create borders (bottom only)
                    //CALayer border = new CALayer();
                    //float width = 1.0f;
                    //border.BorderColor = new CoreGraphics.CGColor(red: 0.89f, green: 0.89f, blue: 0.89f, alpha: 1.0f);  // gray border color
                    //border.Frame = new CGRect(x: 0, y: picker.Height - width, width: picker.Width, height: 1.0f);
                    //border.BorderWidth = width;

                    //Control.Layer.AddSublayer(border);
                    Control.TextAlignment = UITextAlignment.Left;
                    Control.Layer.MasksToBounds = true;
                    Control.BorderStyle = UITextBorderStyle.None;
                    Control.BackgroundColor = null; // white
                }
            };
        }
    }
}
