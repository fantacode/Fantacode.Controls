using System.ComponentModel;
using CoreAnimation;
using CoreGraphics;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using System;
using Foundation;
using ObjCRuntime;
using System.Collections.Generic;
using Fantacode.Controls;
using Fantacode.Controls.iOS;

[assembly: ExportRenderer(typeof(CustomDatePicker), typeof(CustomDatePickerRenderer))]
namespace Fantacode.Controls.iOS
{
    public class CustomDatePickerRenderer : DatePickerRenderer
    {
    
        public override bool CanPerform(Selector action, NSObject withSender)
        {
            NSOperationQueue.MainQueue.AddOperation(() =>
            {
                UIMenuController.SharedMenuController.SetMenuVisible(false, false);
            });
            return base.CanPerform(action, withSender);
        }

        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);
            
            var element = (CustomDatePicker)this.Element;
            if (element == null)
                return;

            e.NewElement.SizeChanged += (obj, args) =>
            {
                var picker = obj as DatePicker;
                if (picker == null)
                    return;

                if (this.Control != null && this.Element != null)
                {
                    if (!string.IsNullOrWhiteSpace(element.Image))
                    {
                        var image = UIImage.FromBundle(element.Image);
                        Control.RightViewMode = UITextFieldViewMode.Always;
                        Control.RightView = new UIImageView(image);
                    }
                    // Create borders (bottom only)
                    //CALayer border = new CALayer();
                    //float width = 1.0f;
                    //border.BorderColor = new CoreGraphics.CGColor(red: 0.89f, green: 0.89f, blue: 0.89f, alpha: 1.0f);  // gray border color
                    //border.Frame = new CGRect(x: 0, y: picker.Height - width, width: picker.Width, height: 0.0f);
                    //border.BorderWidth = width;
                    //Control.Layer.AddSublayer(border);
                    Control.TextAlignment = UITextAlignment.Center;
                    Control.Layer.MasksToBounds = true;
                    Control.BorderStyle = UITextBorderStyle.None;
                    Control.BackgroundColor = null; // white
                }
            };
        }
    }
}
