using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using SQLite;

using Xamarin.Forms;

namespace FormsMenu
{
    public class ContactListPage : ContentPage
    {

        public App app = Application.Current as App;

        ListView displayContacts = null;
        
        public ContactListPage()
        {
            Title = "Contact List";
            // Before: Sort the listview that was instantiated when the app was loaded. Important to do this before wiring it to the itemsource
            // Now sorting is done in SQL and refreshed every time this page comes to the top of the stack.

            //Check to see if there are any records in the DB. If there are, move on, If not (or count ==0), make these entries
            if (app.ContactsMasterDB.Count() == 0)
            {
                app.ContactsMasterDB.AddContact("Joe", "Smith", "Work");
                app.ContactsMasterDB.AddContact("James", "Jones", "Actor");
                app.ContactsMasterDB.AddContact("Stephen", "Curry", "Team");
                app.ContactsMasterDB.AddContact("Meghan", "Henze", "Wife");
            }

            displayContacts = new ListView
            {

                ItemsSource = app.ContactsMasterDB.GetContacts(),


                ItemTemplate = new DataTemplate(() =>
                {
                    TextCell contactInstance = new TextCell();
                    contactInstance.SetBinding(TextCell.TextProperty, "FullName");
                    contactInstance.SetBinding(TextCell.DetailProperty, "ContactType");

                    return contactInstance;
                })
            };


            Label headingLabel = new Label
            {
                Text = "Contact List",
                HorizontalOptions = LayoutOptions.StartAndExpand,
                FontSize = 30,
                //VerticalOptions = LayoutOptions.StartAndExpand,
                FontAttributes = FontAttributes.Italic | FontAttributes.Bold
            };

            // Make the "Add Contact" button
            Button addContactButton = new Button
            {
                Text = "Add Contact",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.End,
                BorderWidth = 1,
                BorderRadius = 22,
                BackgroundColor = Color.Accent,
                TextColor = Color.Black
            };

            //This stacklayout has the heading and the "Add Contact" button
            StackLayout topStack = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                Padding = 10,
                Children =
                {
                    headingLabel,
                    addContactButton
                }
            };

            // What to do when "Add Contact" button is clicked => push a new "AddContactPage" on top of the stack.
            addContactButton.Clicked += async (object sender, EventArgs e) =>
            {
                await this.Navigation.PushAsync(new AddContactPage());

            };

            //when an item is selected, display a new EditContactPage and pass in the selected Contact object.
            displayContacts.ItemSelected += async (sender, e) =>
            {
                if (((ListView)sender).SelectedItem == null)
                    return;
                await this.Navigation.PushAsync(new EditContactPage(e.SelectedItem as Contact));
                displayContacts.SelectedItem = null;
            };

            //Main StackLayout

            Content = new StackLayout
            {
                Children = {
                    topStack,
                    displayContacts
                }
            };
        }// End Constructor

        protected override void OnAppearing()
        {
            displayContacts.ItemsSource = app.ContactsMasterDB.GetContacts();
        }
    }
}


