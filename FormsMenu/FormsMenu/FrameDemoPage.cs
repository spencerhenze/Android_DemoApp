using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class FrameDemoPage : ContentPage
    {
        public FrameDemoPage()
        {
            Label header = new Label
            {
                Text = "Frame Demo",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 40,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
            };

            Label frameLabel = new Label
            {
                Text = "This is my Frame Demo!",
                TextColor = Color.White,
                BackgroundColor = Color.Teal,
                HorizontalOptions = LayoutOptions.Center,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
            };

            Frame frame = new Frame
            {
                BackgroundColor = Color.Yellow,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Content = frameLabel,
            };


            Content = new StackLayout
            {
                Children = {
                    header,
                    frame,
                }
            };
        }
    }
}
