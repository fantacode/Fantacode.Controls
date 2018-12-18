using System;
using Xamarin.Forms;

namespace Fantacode.Controls
{
    public class CustomPicker : Picker
    {
        public CustomPicker()
        {

        }

        public static readonly BindableProperty ArrowProperty =
            BindableProperty.Create(nameof(Arrow), typeof(string), typeof(CustomPicker), "");

        public string Arrow
        {
            get { return (string)GetValue(ArrowProperty); }
            set { SetValue(ArrowProperty, value); }
        }
    }
}
