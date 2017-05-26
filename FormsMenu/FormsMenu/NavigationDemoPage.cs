using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class NavigationDemoPage : ContentPage
    {
        public NavigationDemoPage()
        {

            Label header = new Label
            {
                Text = "NavigationPage",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 40,
                FontAttributes = FontAttributes.Bold | FontAttributes.Italic,
            };

            Button labelDemoPageButton = new Button
            {
                Text = "Label Demo Page",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button)),
                BorderWidth = 1,
                BackgroundColor = Color.Gray,
                TextColor = Color.White,
            };
            labelDemoPageButton.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new LabelDemoPage());
            };

            Button scrollViewButton = new Button
            {
                Text = "ScrollView Demo Page",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button)),
                BorderWidth = 1,
                BackgroundColor = Color.Gray,
                TextColor = Color.White,
            };
            scrollViewButton.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ScrollViewDemoPage());
            };


            Button stackLayoutButton = new Button
            {
                Text = "StackLayout Demo Page",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Button)),
                BorderWidth = 1,
                BackgroundColor = Color.Gray,
                TextColor = Color.White,
            };
            stackLayoutButton.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new StackLayoutDemoPage());
            };


            StackLayout buttonStack = new StackLayout
            {
                Spacing = 0,
                Orientation = StackOrientation.Horizontal,

                Children =
                {
                    labelDemoPageButton,
                    scrollViewButton,
                    stackLayoutButton
                }
            };


            Content = new StackLayout
            {
                Children = {
                    header,
                    buttonStack
                }
            };


        } // End of Constructor



    }
}
