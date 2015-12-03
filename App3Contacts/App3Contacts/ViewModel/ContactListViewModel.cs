using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App3Contacts
{
    public class ContactListViewModel
    {
        public List<Contact> Contacts { get; set; }

        public ContactListViewModel()
        {
            Contacts = new List<Contact>();
            Contacts = ContactGenerator.CreateContacts(); 

        }
    }
}
