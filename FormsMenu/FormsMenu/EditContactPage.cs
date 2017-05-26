 using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace FormsMenu
{
    public class EditContactPage : ContentPage
    {
        public App app = Application.Current as App;

        //Make EntryCell objects at the class level to be accessible to click events later.
        private EntryCell firstName = new EntryCell()
        {
            Label = "First Name",
            Text = ""
            
        };
        private EntryCell lastName = new EntryCell()
        {
            Label = "Last Name",
            Text = ""
        };
        private EntryCell contactType = new EntryCell()
        {
            Label = "Contact Type",
            Text = ""
        };


        public EditContactPage(Contact thisContact)
        {
            //Since we passed in the contact object, display the current values of its properties
            firstName.Text = thisContact.FirstName;
            lastName.Text = thisContact.LastName;
            contactType.Text = thisContact.ContactType;

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
            //When save button is clicked, take the text from the EntryCell objects and store it as a new contact
            saveButton.Clicked += async (object sender, EventArgs e) =>
            {
                //Overwrite the values of the current object's properties with those in the text fields.
                thisContact.FirstName = firstName.Text;
                thisContact.LastName = lastName.Text;
                thisContact.ContactType = contactType.Text;

                app.ContactsMasterDB.UpdateContact(thisContact.ID, thisContact.FirstName, thisContact.LastName, thisContact.ContactType);
                //[with SQLite, no need to] sort the list. Done in OnAppearing method.
                //app.masterContactList = app.masterContactList.OrderBy(Contact =>
                //    Contact.LastName).ToList();
                //app.displayContacts.ItemsSource = app.masterContactList;

                //pop the page off
                await this.Navigation.PopAsync();
            };

            Button deleteButton = new Button
            {
                Text = "Delete Contact",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.StartAndExpand,
                BorderWidth = 1,
                BorderRadius = 22,
                BackgroundColor = Color.Accent,
                TextColor = Color.Black
            };
            deleteButton.Clicked += async (object sender, EventArgs e) =>
            {
                //delete the Contact object referenced by its ID property.
                app.ContactsMasterDB.DeleteContact(thisContact.ID);

                //[with SQLite, no need to] sort the list
                //app.masterContactList = app.masterContactList.OrderBy(Contact =>
                //    Contact.LastName).ToList();
                //Refresh the list
                //app.displayContacts.ItemsSource = app.ContactsMasterDB; (this is now handled by the OnAppearing method in the ContactsList Page)
                
                ////pop the page off
                await this.Navigation.PopAsync();
            };

            //Make the "Return" button
            Button cancelButton = new Button
            {
                Text = "Cancel",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Button)),
                HorizontalOptions = LayoutOptions.EndAndExpand,
                BorderWidth = 1,
                BorderRadius = 22,
                BackgroundColor = Color.Accent,
                TextColor = Color.Black
            };
            // When the button is clicked, pop the page off the stack
            cancelButton.Clicked += async (object sender, EventArgs e) =>
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
                    new TableSection ("Edit/Delete a Contact")
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
                //HorizontalOptions = LayoutOptions.CenterAndExpand,
                Padding = 50,
                Children =
                {
                    saveButton,
                    deleteButton,
                    cancelButton
                }
            };

            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Start,
                Children = {
                    entryTable,
                    buttonRow
                }
            };



        }// End of Constructor       
    }
}
