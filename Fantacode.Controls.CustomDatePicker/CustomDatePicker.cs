using System;
using Xamarin.Forms;

namespace Fantacode.Controls
{
    public class CustomDatePicker : DatePicker
    {
        public CustomDatePicker()
        {
        }

        public static readonly BindableProperty ImageProperty =
             BindableProperty.Create(nameof(Image), typeof(string), typeof(CustomDatePicker), "");

        public string Image
        {
            get { return (string)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }
    }
}
