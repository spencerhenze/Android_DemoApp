using System;
using System.IO;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLite;
using FormsMenu.Droid;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

[assembly: Dependency(typeof(SQLite_Android))]

namespace FormsMenu.Droid
{
    class SQLite_Android : SQLInterface
    {
        public SQLiteConnection GetConnection()
        {
            var fileName = "ContactsDB.db3";
            var documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, fileName);
            var connection = new SQLiteConnection(path);

            return connection;
        }

    }
}