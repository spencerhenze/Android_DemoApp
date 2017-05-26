using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using SQLite;

using Xamarin.Forms;

namespace FormsMenu
{
	public class AddContactPage : ContentPage
	{
        //Make EntryCell objects at the class level to be accessible to click events later.
        private EntryCell firstName = new EntryCell()
        {
            Label = "First Name",
            Placeholder = "Type here."
        };
        private EntryCell lastName = new EntryCell()
        {
            Label = "Last Name",
            Placeholder = "Type here."
        };
        private EntryCell contactType = new EntryCell()
        {
            Label = "Contact Type",
            Placeholder = "Type here."
        };

        public App app = Application.Current as App;

        public AddContactPage ()
		{
           
            Button saveButton = new Button
            {
                Text = "Save Contact",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.StartAndExpand,
                BorderWidth = 1,
                BorderRadius = 22,
                BackgroundColor = Color.Accent,
                TextColor = Color.Black
            };
            //When the saveButton is clicked, run the "saveButtonClicked" method below the constructor
            saveButton.Clicked += saveButtonClicked;


            //Make the "Return" button
            Button returnButton = new Button
            {
                Text = "Return",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.EndAndExpand,
                BorderWidth = 1,
                BorderRadius = 22,
                BackgroundColor = Color.Accent,
                TextColor = Color.Black
            };
            // When the button is clicked, pop the page off the stack
            returnButton.Clicked += async (object sender, EventArgs e) =>
            {
                await this.Navigation.PopAsync();
            };


            TableView entryTable = new TableView
            {
                HeightRequest = 300,
                VerticalOptions = LayoutOptions.Start,
                Intent = TableIntent.Form,
                Root = new TableRoot
                {
                    new TableSection ("Add a New Contact")
                    {
                        //Add the EntryCell objects created above to the TableSecion
                        firstName,
                        lastName,
                        contactType
                    }
                }
            };


            //This stacklayout displays the buttons in a row
            StackLayout buttonRow = new StackLayout
            {
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.Start,
                Padding = 50,
                Children =
                {
                    saveButton,
                    returnButton
                }
            };

			Content = new StackLayout {
                VerticalOptions = LayoutOptions.Start,
				Children = {
                    entryTable,
                    buttonRow
				}
			};
		}// End of Constructor

        //When save button is clicked, take the text from the EntryCell objects and store it as a new contact
        void saveButtonClicked(object sender, EventArgs args)
        {
            //in the edit contact page, the save button will assign the text fields to their respective properties, sort the list, set the item source, then pop the page.
            Contact newContact = new Contact(firstName.Text, lastName.Text, contactType.Text);
            app.ContactsMasterDB.AddContact(newContact.FirstName, newContact.LastName, newContact.ContactType);

            //Don't need to sort here. Added an overridden OnAppearing() method in the ContactsList page
            //Clear the text fields
            firstName.Text = "";
            lastName.Text = "";
            contactType.Text = "";
        }

}
}
