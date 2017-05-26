using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;


namespace FormsMenu
{
    public class ContactsDatabase
    {
        private SQLiteConnection _connection;

        public ContactsDatabase()
        {
            _connection = DependencyService.Get<SQLInterface>().GetConnection(); //This interface might be wrong
            _connection.CreateTable<Contact>(); //I think this is supposed to reference the contact class
        }

        public IEnumerable<Contact> GetContacts()
        {
            return _connection.Query<Contact>("SELECT * FROM ContactsDB ORDER BY LastName");
        }

        public Contact GetContact (int id) 
        {
            return _connection.Table<Contact>().FirstOrDefault(t => t.ID == id);
        }

        public void DeleteContact(int id)
        {
            _connection.Delete<Contact>(id);
        }

        public void AddContact(string firstName, string lastName, string type)
        {
            var newContact = new Contact
            {
                FirstName = firstName,
                LastName = lastName,
                ContactType = type
            };

            _connection.Insert(newContact);
        }

        public void UpdateContact(int id, string firstName, string lastName, string type)
        {
            _connection.Execute("UPDATE ContactsDB SET FirstName = ?, LastName = ?, ContactType = ? WHERE ID = ? ", firstName, lastName, type, id);
        }

        public int Count()
        {
            return _connection.Table<Contact>().Count();
        }
    }
}
