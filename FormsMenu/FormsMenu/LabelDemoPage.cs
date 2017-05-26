using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class LabelDemoPage : ContentPage
    {
        Label header = new Label
        {
            Text = "Label Demo Page",
            HorizontalOptions = LayoutOptions.Center,
            FontSize = 40,
            FontAttributes = FontAttributes.Bold | FontAttributes.Italic,

        };

        Label sampleText = new Label
        {
            Text = "Xamarin.Forms is a cross-platform natively backed UI toolkit abstraction that allows developers to easily create user interfaces that can be shared across Android, iOS and Windows Phone",
            VerticalOptions = LayoutOptions.CenterAndExpand,
            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
        };

        public LabelDemoPage()
        {

            Content = new StackLayout
            {
                Children = {
                    header,
                    sampleText,
                }
            };
        }
    }
}
