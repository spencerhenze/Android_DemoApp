using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class ContentDemoPage : ContentPage
    {
        Label header = new Label
        {
            Text = "ContentPage",
            HorizontalOptions = LayoutOptions.Center,
            FontSize = 40,
            FontAttributes = FontAttributes.Bold,
        };

        StackLayout stack = new StackLayout
        {
            Children ={
                new Label
                {
                    Text = "ContentPage is the simplest type of page.",
                    FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label))
                },
                new Label
                {
                    Text = "The content of a ContentPage is generally a layout of some sort that can then be a parent to multiple children.",
                    FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label))
                },
                new Label
                {
                    Text = "This ContentPage contains a StackLayout, which in turn contains four Label views (including the large one at top).",
                    FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                }
            }
        };



        public ContentDemoPage()
        {
            Content = new StackLayout
            {
                Children = {
                    stack,
                }
            };
        }
    }
}
