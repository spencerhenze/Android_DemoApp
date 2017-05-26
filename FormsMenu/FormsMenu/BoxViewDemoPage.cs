using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class BoxViewDemoPage : ContentPage
    {
        Label header = new Label
        {
            Text = "BoxView Demo Page",
            HorizontalOptions = LayoutOptions.Center,
            FontSize = 40,
            FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
        };

        BoxView boxView = new BoxView
        {
            Color = Color.Accent,
            WidthRequest = 150,
            HeightRequest = 150,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.CenterAndExpand
        };

        public BoxViewDemoPage()
        {
            Content = new StackLayout
            {
                Children = {
                    header,
                    boxView,
                }
            };
        }
    }
}
