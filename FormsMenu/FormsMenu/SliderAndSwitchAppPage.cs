using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    //Changes made as of 1/29 @ 3:44pm
    //Moved all object declarations out of the constructor and to the class level
    //Created Switch Action method "OnSwitchToggled()" and linked it to the switch toggled event in the constructor.

    public class SliderAndSwitchAppPage : ContentPage
    {
        //Declare the objects at the class level so that they can be referenced by methods outside of the constructor.
        StackLayout stackLayout = new StackLayout();

        Label headingLabel = new Label
        {
            Text = "Frame Demo Page",
            HorizontalOptions = LayoutOptions.Center,
            FontSize = 40,
            TextColor = Color.White,
            FontAttributes = FontAttributes.Italic
        };

        static Label frameLabel = new Label
        {

            Text = "My frame demo!",
            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            TextColor = Color.Black
        };

        Frame frame = new Frame
        {
            WidthRequest = 200,
            HeightRequest = 200,
            Content = frameLabel,

            BackgroundColor = Color.White,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.CenterAndExpand
        };

        Button button = new Button
        {
            Text = "CLICK ME!",
            Font = Font.SystemFontOfSize(NamedSize.Large),
            BorderWidth = 1,
            BackgroundColor = Color.Gray,
            TextColor = Color.White,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.CenterAndExpand
        };

        Label switchLabel = new Label
        {
            Text = "Switch Colors",
            HorizontalOptions = LayoutOptions.Center,
            TextColor = Color.White,
            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
        };

        Switch mySwitch = new Switch
        {
            HorizontalOptions = LayoutOptions.Center,
            Margin = new Thickness(0, 10, 0, 0)
        };

        Label sliderLabel = new Label
        {
            Text = "Frame Dimension: 200",
            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
            TextColor = Color.White,
            HorizontalOptions = LayoutOptions.Center,
            VerticalOptions = LayoutOptions.End
        };

        Slider slider = new Slider
        {
            Maximum = 300,
            Minimum = 10,

            Value = 200,
            Margin = new Thickness(20),
            VerticalOptions = LayoutOptions.End
        };

        public SliderAndSwitchAppPage() //Constructor
        {
            Title = "Slider & Switch";
            //Control Actions and methods they call
            button.Clicked += OnButtonClicked;
            mySwitch.Toggled += OnSwitchToggled;
            slider.ValueChanged += SliderMoved;

            //Add the objects to the stackLayout as children
            stackLayout.Children.Add(headingLabel);
            stackLayout.Children.Add(frame);
            stackLayout.Children.Add(button);
            stackLayout.Children.Add(switchLabel);
            stackLayout.Children.Add(mySwitch);
            stackLayout.Children.Add(sliderLabel);
            stackLayout.Children.Add(slider);

            //Set the stackLayout options
            stackLayout.VerticalOptions = LayoutOptions.FillAndExpand;
            stackLayout.BackgroundColor = Color.Blue;
            Content = stackLayout;
        }//end of constructor

        //Start declaring methods that contain the changes to be made when controls are used.

        private void MySwitch_Toggled(object sender, ToggledEventArgs e)
        {
            throw new NotImplementedException();
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            if (stackLayout.BackgroundColor == Color.Blue)
            {
                stackLayout.BackgroundColor = Color.Green;
            }
            else if (stackLayout.BackgroundColor == Color.Green)
            {
                stackLayout.BackgroundColor = Color.Blue;
            }
        }

        void OnSwitchToggled(object sender, EventArgs args)
        {
            if (frame.BackgroundColor == Color.White)
            {
                frame.BackgroundColor = Color.Gray;
                frameLabel.TextColor = Color.White;
            }
            else if (frame.BackgroundColor == Color.Gray)
            {
                frame.BackgroundColor = Color.White;
                frameLabel.TextColor = Color.Black;
            }
        } // end of OnSwitchToggled()

        void SliderMoved(object sender, EventArgs args)
        {
            int sliderValue = Convert.ToInt32(slider.Value);
            sliderLabel.Text = "Frame Dimension: " + Convert.ToString(sliderValue);
            frame.WidthRequest = sliderValue;
            frame.HeightRequest = sliderValue;
        }// end of SliderMoved
    }
}
