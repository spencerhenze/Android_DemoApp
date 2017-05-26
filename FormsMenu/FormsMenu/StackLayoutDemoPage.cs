using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class StackLayoutDemoPage : ContentPage
    {

        Label header = new Label
        {
            Text = "StackLayout",
            HorizontalOptions = LayoutOptions.Center,
            FontSize = 40,
            FontAttributes = FontAttributes.Bold,
        };

        Label label1 = new Label
        {
            Text = "StackLayout",
            HorizontalOptions = LayoutOptions.Start,
        };

        Label label2 = new Label
        {
            Text = "stacks its children",
            HorizontalOptions = LayoutOptions.Center,
        };

        Label label3 = new Label
        {
            Text = "vertically",
            HorizontalOptions = LayoutOptions.End,
        };

        Label label4 = new Label
        {
            Text = "by default",
            HorizontalOptions = LayoutOptions.Center,
        };

        Label label5 = new Label
        {
            Text = "but horizontal placement",
            HorizontalOptions = LayoutOptions.Start,
        };

        Label label6 = new Label
        {
            Text = "can be controlled with",
            HorizontalOptions = LayoutOptions.Center,
        };

        Label label7 = new Label
        {
            Text = "the Horizontal Options property.",
            HorizontalOptions = LayoutOptions.End,
        };

        Label label8 = new Label
        {
            Text = "An Expand option allows one or more children to occupy the area within the renaming space of the StackLayout after it's been sized to the height of its parent.",
            HorizontalOptions = LayoutOptions.End,
            VerticalOptions = LayoutOptions.CenterAndExpand
        };


        //Label labelSt2l1 = new Label
        //{
        //    Text = "Stacking",
        //};

        //Label labelSt2l2 = new Label
        //{
        //    Text = "can also be",
        //    HorizontalOptions = LayoutOptions.CenterAndExpand
        //};

        //Label labelSt2l3 = new Label
        //{
        //    Text = "horizontal",
        //};

        StackLayout stack2 = new StackLayout
        {
            Spacing = 0,
            Orientation = StackOrientation.Horizontal,
            Children ={
                new Label
                {
                    Text = "Stacking"
                },
                new Label
                {
                    Text = "can also be",
                    HorizontalOptions = LayoutOptions.CenterAndExpand
                },
                new Label
                {
                    Text = "horizontal."
                }

            },
        };






        public StackLayoutDemoPage()
        {
            Title = "StackLayout Demo";
            Content = new StackLayout
            {
                Children = {
                    header,
                    label1,
                    label2,
                    label3,
                    label4,
                    label5,
                    label6,
                    label7,
                    label8,
                    stack2

                }
            };
        }
    }
}
