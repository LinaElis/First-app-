using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App3Contacts;

namespace App3Contacts
{
    public class ContactGenerator
    {
        private static List<string> FirstName = new List<string>() { "Anna", "Berit", "Cecilia", "Dorothea", "Eva", "Filippa" };
        private static List<string> LastName = new List<string>() { "Andersson", "Berg", "Colt", "Daysson", "Eriksson", "Fransson" };

        public static List<Contact> CreateContacts()
        {
            var random = new Random();
            List<Contact> contacts = new List<Contact>();
            for (int i = 0; i < 25; i++)
            {
                string first = FirstName[random.Next(FirstName.Count - 1)];
                string last = LastName[random.Next(LastName.Count - 1)];
                string email = first + "." + last + "@nackademin.se";
                Contact contact = new Contact() { FirstName = first, LastName = last, Email = email };
                contacts.Add(contact);
            }
            
            return contacts;
        }
    }
}