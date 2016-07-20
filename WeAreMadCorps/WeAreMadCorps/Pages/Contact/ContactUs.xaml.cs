using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WeAreMadCorps.Pages.Contact
{
    public partial class ContactUs : ContentPage
    {
        public ContactUs()
        {
            InitializeComponent();
        }

        void OnEnvoyerClicked(object sender,EventArgs e)
        {

            //On envoi un mail avec tous les champs du formulaire.
            DisplayAlert("Succès", "Le message a été envoyé avec succès", "OK");
        }


    }
}
