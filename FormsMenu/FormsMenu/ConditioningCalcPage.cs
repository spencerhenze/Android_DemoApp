using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class ConditioningCalcPage : ContentPage
    {
        //Remember to declare objects outside of the constructor. 
        Label topLabel = new Label
        {
            Text = "Enter Gymnast's Scores",
            HorizontalOptions = LayoutOptions.Center,
            FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
            FontAttributes = FontAttributes.Bold,
        };


        //Begin declaring EntryCells
        public static Label pressHSLabel = new Label
        {
            Text = "Press Handstand: ",
            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
            HorizontalOptions = LayoutOptions.StartAndExpand
        };

        public static EntryCell pressHSEntryCell = new EntryCell
        {
            Label = "Press Handstand: ",
            Keyboard = Keyboard.Numeric,
            Text = ""
        };

        public static EntryCell legLiftsEntryCell = new EntryCell
        {
            Label = "Leg Lifts: ",
            Keyboard = Keyboard.Numeric,
            Text = ""
        };

        public static EntryCell castHSEntryCell = new EntryCell
        {
            Label = "Cast Handstand: ",
            Keyboard = Keyboard.Numeric,
            Text = ""
        };

        public static EntryCell blockJumpsEntryCell = new EntryCell
        {
            Label = "Block Jumps: ",
            Keyboard = Keyboard.Numeric,
            Text = ""
        };

        public static EntryCell archUpsEntryCell = new EntryCell
        {
            Label = "Arch-Ups (5 lb): ",
            Keyboard = Keyboard.Numeric,
            Text = ""
        };

        public static EntryCell splitsTotalEntryCell = new EntryCell
        {
            Label = "Splits Total: ",
            Keyboard = Keyboard.Numeric,
            Text = ""
        };

        public static EntryCell hsHoldEntryCell = new EntryCell
        {
            Label = "Handstand Hold: ",
            Keyboard = Keyboard.Numeric,
            Text = ""
        };

        public static EntryCell horizLegLiftsEntryCell = new EntryCell
        {
            Label = "Horizontal Leg Lifts: ",
            Keyboard = Keyboard.Numeric,
            Text = ""
        };

        public static EntryCell ropeEntryCell = new EntryCell
        {
            Label = "Rope: ",
            Keyboard = Keyboard.Numeric,
            Text = ""
        };

        public static EntryCell leversEntryCell = new EntryCell
        {
            Label = "Levers: ",
            Keyboard = Keyboard.Numeric,
            Text = ""
        };

        public static EntryCell lungeJumpsEntryCell = new EntryCell
        {
            Label = "Lunge Jumps: ",
            Keyboard = Keyboard.Numeric,
            Text = ""
        };

        public static Button calculateButton = new Button
        {
            Text = "Calculate",
            HorizontalOptions = LayoutOptions.EndAndExpand,
            Margin = new Thickness(0, 0, 20, 0)

        };

        public static Button clearButton = new Button
        {
            Text = "Clear",
            HorizontalOptions = LayoutOptions.StartAndExpand,
            Margin = new Thickness(20, 0, 0, 0)

        };


        //Entry table can be added to a stacklayout. Put entry cells into it.
        TableView entryTable = new TableView
        {
            HeightRequest = 1200,
            VerticalOptions = LayoutOptions.Start,
            Intent = TableIntent.Form,
            Root = new TableRoot
            {
                new TableSection
                {
                    pressHSEntryCell,
                    hsHoldEntryCell,
                    legLiftsEntryCell,
                    horizLegLiftsEntryCell,
                    castHSEntryCell,
                    ropeEntryCell,
                    blockJumpsEntryCell,
                    leversEntryCell,
                    archUpsEntryCell,
                    lungeJumpsEntryCell,
                    splitsTotalEntryCell
                }
            }
        };


        StackLayout horizStack = new StackLayout
        {
            Orientation = StackOrientation.Horizontal,

            Children =
            {
                clearButton,
                calculateButton,
                
            }
        };

      
        Slider slider = new Slider
        {
            Maximum = 100,
            Minimum = 1,

            Value = 50,
            Margin = new Thickness(20),

            VerticalOptions = LayoutOptions.End,
        };


        Label sliderLabel = new Label
        {
            Text = "System Setting: 50%",
            FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
            HorizontalOptions = LayoutOptions.Center,
            TextColor = Color.Black,
        };


        public ConditioningCalcPage()
        {
            
            Title = "Conditioning Calculator";

            slider.ValueChanged += SliderMoved;
            clearButton.Clicked += ClearButtonClicked;
            calculateButton.Clicked += CalculateButtonClicked;

            Content = new StackLayout
            {
                Padding = new Thickness(20),
                Children =
                {
                    topLabel,
                    entryTable,
                    horizStack,
                    //slider,
                    //sliderLabel
                }
            };
        }// end of constructor

        //Methods Here
        void SliderMoved(object sender, EventArgs e)
        {
            int newValue = Convert.ToInt32(slider.Value);
            sliderLabel.Text = "System Setting: " + newValue.ToString();
        }

        void ClearButtonClicked(object sender, EventArgs e)
        {
            pressHSEntryCell.Text = "";
            hsHoldEntryCell.Text = "";
            legLiftsEntryCell.Text = "";
            horizLegLiftsEntryCell.Text = "";
            castHSEntryCell.Text = "";
            ropeEntryCell.Text = "";
            blockJumpsEntryCell.Text = "";
            leversEntryCell.Text = "";
            archUpsEntryCell.Text = "";
            lungeJumpsEntryCell.Text = "";
            splitsTotalEntryCell.Text = "";
        }

        void CalculateButtonClicked(object sender, EventArgs e)
        {
            double finalScore = 100.00;
            //Enter math here
            DisplayAlert("Overall Score", "The gymnast's overall score is: " + finalScore + "%", "OK");
        }

    }
}
