using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App3Contacts
{
    public partial class Page1 : ContentPage
    {
        public Contact _Contact { get; set; }

        public Page1()
        {
            _Contact = new Contact();
            _Contact.FirstName = "Lina";
            _Contact.LastName = "Wellerstrand";
            _Contact.Email = "lina.wellerstrand@gmail.com";
            InitializeComponent();
            BindingContext = _Contact;
        }
    }
}
