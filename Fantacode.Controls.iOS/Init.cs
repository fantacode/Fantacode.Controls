using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace Fantacode.Controls.iOS
{
    public class Controls
    {
        public static void Initialize()
        {
            CustomDatePickerRenderer.Initialize();
            CustomTimePickerRenderer.Initialize();
            CustomEntryRenderer.Initialize();
            CustomPickerRenderer.Initialize();
        }
    }
}