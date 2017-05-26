using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class FormsMenuPage : ContentPage
    {
        private App app = Application.Current as App;

        public FormsMenuPage()
        {

            Command<Type> pageCommand =
                new Command<Type>(async (Type pageType) =>
                {
                    Page page = (Page)Activator.CreateInstance(pageType);
                    await Navigation.PushAsync(page);

                });


            //Command<Type> pageCommandContacts =
            //    new Command<Type>(async (Type pageType) =>
            //    {
            //        Page page = (Page)Activator.CreateInstance(pageType, args: masterContactList);
            //        await Navigation.PushAsync(page);

            //    });


            BackgroundColor = Color.Black;


            Title = "Forms Menu";


            Content = new TableView
            {

                Intent = TableIntent.Menu,


                Root = new TableRoot
                {
                    new TableSection("My Own Stuff")
                    {
                        new TextCell
                        {
                            Text = "Conditioning Calculator",
                            Command = pageCommand,
                            CommandParameter = typeof(ConditioningCalcPage),
                        }

                    },


                    new TableSection("Class Project Apps")
                    {

                        new TextCell
                        {
                            Text = "Slider and Switch App",
                            Command = pageCommand,
                            CommandParameter = typeof(SliderAndSwitchAppPage),
                        },

                        new TextCell
                        {
                            Text = "StopWatch App",
                            Command = pageCommand,
                            CommandParameter = typeof(StopWatchAppPage),
                        },

                        new TextCell
                        {
                            Text = "Contact List",
                            Command = pageCommand,
                            CommandParameter = typeof(ContactListPage),
                            
                        },


                    },

                    new TableSection("Views for Presentation")
                    {
                        new TextCell
                        {
                            Text = "LabelDemo",
                            Command = pageCommand,
                            CommandParameter = typeof(InClassDemoPage),
                        },
                        new TextCell
                        {
                            Text = "BoxView Demo",
                            Command = pageCommand,
                            CommandParameter = typeof(BoxViewDemoPage), //Make this page
                        },
                    },
                    new TableSection("Views that Initiate Commands"),
                    new TableSection("Views for common data types"),
                    new TableSection("Views for Editing Text"),
                    new TableSection("Views to Indicate Activity"),
                    new TableSection("Views that Display Collections"),
                    new TableSection("Layouts with Single Content"),
                     new TableSection("Layouts with Single Content")
                    {
                        new TextCell
                        {
                            Text = "Frame Demo",
                            Command = pageCommand,
                            CommandParameter = typeof(FrameDemoPage) //make this page
                        },

                    },
                    new TableSection("Layouts with Multiple Children")
                    {
                        new TextCell
                        {
                            Text = "StackLayout Demo",
                            Command = pageCommand,
                            CommandParameter = typeof(StackLayoutDemoPage) //make this page
                        },

                    },

                    new TableSection("Pages")
                    {
                        new TextCell
                        {
                            Text = "ContentPage Demo",
                            Command = pageCommand,
                            CommandParameter = typeof(ContentDemoPage) //make this page
                        },
                        new TextCell
                        {
                            Text = "NavigationPage",
                            Command = pageCommand,
                            CommandParameter = typeof(NavigationDemoPage) //make this page
                        },
                        new TextCell
                        {
                            Text = "Tabbed Page",
                            Command = pageCommand,
                            CommandParameter = typeof(TabbedPageDemo) //make this page
                        },
                         new TextCell
                        {
                            Text = "Carousel Page",
                            Command = pageCommand,
                            CommandParameter = typeof(CarouselPageDemo) //make this page
                        },


                    },
                   
                }

            };
        }
    }
}
