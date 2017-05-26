using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace FormsMenu
{
    [Table("ContactsDB")]

    public class Contact
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        private string _firstName, _lastName, _type;

        public Contact() { }

        public Contact(string firstName, string lastName, string contactType)
        {
            _firstName = firstName;
            _lastName = lastName;
            _type = contactType;
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public string ContactType
        {
            get { return _type; }
            set { _type = value; }
        }

        public string FullName
        {
            get { return String.Format("{0} {1}", _firstName, _lastName); }
        }
    }
}
