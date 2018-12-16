using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Fantacode.Controls;
using Fantacode.Controls.iOS;

[assembly:ExportRenderer(typeof(CustomTimePicker), typeof(CustomTimePickerRenderer))]
namespace Fantacode.Controls.iOS
{
    public class CustomTimePickerRenderer : TimePickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<TimePicker> e)
        {
            base.OnElementChanged(e);
            var view = (TimePicker)Element;
            if (view != null)
            {
                var timePicker = (UIDatePicker)Control.InputView;
                timePicker.MinuteInterval = 30;
            }
        }
    }
}
