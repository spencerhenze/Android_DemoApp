using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;

using Xamarin.Forms;

namespace FormsMenu
{
    public class App : Application
    {
        //This is how to initiate the List if you are not using SQLite
        //public ListView displayContacts = null;

        //public List<Contact> masterContactList = new List<Contact>
        //{
        //    new Contact(1, "Spencer", "Henze", "Family"),
        //    new Contact(2, "Micahel", "Ciavarella", "Fam"),
        //    new Contact(3, "Dantheman", "Howell", "Fam")
        //};

        public ContactsDatabase ContactsMasterDB = new ContactsDatabase();

        public App()
        {
            // The root page of your application
            MainPage = new NavigationPage(new FormsMenuPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
     }
}

