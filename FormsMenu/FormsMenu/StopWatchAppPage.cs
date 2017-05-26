using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Diagnostics;

using Xamarin.Forms;

namespace FormsMenu
{
    public class StopWatchAppPage : ContentPage
    {
        string timeFormat = "00:00:00.00";

        Stopwatch myStopWatch = new Stopwatch();


        public StopWatchAppPage()
        {
            Title = "StopWatch";

            Label headingLabel = new Label
            {
                Text = "StopWatch App",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.StartAndExpand,
                FontSize = 50,
                //TextColor = Color.Black,
                FontAttributes = FontAttributes.Italic | FontAttributes.Bold
            };

            Label timeLabel = new Label
            {
                Text = timeFormat,
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 55,
                TextColor = Color.Black,
            };

            Button startButton = new Button
            {
                Text = "Start",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                BorderWidth = 1,
                BorderRadius = 22,
                BackgroundColor = Color.Accent,
                TextColor = Color.Black
            };

            Button stopButton = new Button
            {
                Text = "Stop",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                BorderWidth = 1,
                BorderRadius = 22,
                BackgroundColor = Color.Accent,
                TextColor = Color.Black
            };

            Button resetButton = new Button
            {
                Text = "Reset",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                BorderWidth = 1,
                BorderRadius = 22,
                BackgroundColor = Color.Accent,
                TextColor = Color.Black
            };



            StackLayout buttonStack = new StackLayout
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.StartAndExpand,
                Orientation = StackOrientation.Horizontal,

                Children =
                {
                    startButton,
                    stopButton,
                    resetButton
                }

            };

            StackLayout innerFrameStack = new StackLayout
            {
                Children =
                {
                    timeLabel,
                    buttonStack
                }

            };

            Frame buttonFrame = new Frame
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.StartAndExpand,
                Margin = new Thickness(0, 30, 0, 30),
                Content = innerFrameStack,

                BackgroundColor = Color.FromRgb(200, 200, 200)
            };



            //This block makes new DateTime and TimeSpan instances to keep track of the elpased time with reference to the current time when the buttons are pressed
            Device.StartTimer(TimeSpan.FromMilliseconds(1),
                () =>
                {
                    DateTime dateTime = DateTime.Now;
                    TimeSpan ts = myStopWatch.Elapsed;
                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00.00}", ts.Hours, ts.Minutes, (ts.Seconds + ts.Milliseconds / 1000.0));
                    timeLabel.Text = elapsedTime;
                    return true;
                });

            //Now set up the button click actions to use the stuff above

            startButton.Clicked += (sender, e) =>
            {
                myStopWatch.Start();
            };

            stopButton.Clicked += (sender, e) =>
            {
                myStopWatch.Stop();
            };

            resetButton.Clicked += (sender, e) =>
            {
                myStopWatch.Reset();
            };


            Content = new StackLayout
            {
                Children = {
                    headingLabel,
                    buttonFrame,
                }
            };

            startButton.Clicked += (object sender, EventArgs e) =>
            {
                myStopWatch.Start();
            };

        }
    }
}
