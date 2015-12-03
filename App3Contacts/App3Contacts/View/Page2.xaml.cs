using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3Contacts
{
    public partial class Page2 : ContentPage
    {
        private ContactListViewModel _contactListViewModel;

        public Page2()
        {
            _contactListViewModel = new ContactListViewModel();
            InitializeComponent();
            BindingContext = _contactListViewModel;

        }

        private void ContactList_OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = (Contact) e.Item;
            if (e != null)
            {
                DisplayAlert("Your choice", String.Format("You have chosen {0} {1}", contact.FirstName, contact.LastName), "OK");
            }
        }
    }
}
