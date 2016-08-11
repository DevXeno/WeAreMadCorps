using Plugin.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeAreMadCorps.SampleMessaging;
using Xamarin.Forms;

namespace WeAreMadCorps.Pages.Contact
{
    public partial class ContactUs : ContentPage
    {
        public ContactUs()
        {
            InitializeComponent();
        }

        void OnEnvoyerClicked(object sender, EventArgs e)
        {

            //On envoi un mail avec tous les champs du formulaire.
            //DisplayAlert("Succès", "Le message a été envoyé avec succès", "OK");

            //Device.OpenUri(new Uri("mailto:" + "contact@madcorps.com"));

            //   CrossMessaging.Current.EmailMessenger.SendSampleEmail(BuildSampleEmail(false).Build());
            
            var emailMessenger = CrossMessaging.Current.EmailMessenger;
            if (emailMessenger.CanSendEmail)
            {
                // Send simple e-mail to single receiver without attachments, bcc, cc etc.
               // emailMessenger.SendEmail("xeno.esport@gmail.com", "test", "ceci est un test de Xeno");

                // Alternatively use EmailBuilder fluent interface to construct more complex e-mail with multiple recipients, bcc, attachments etc. 
                var email = new EmailMessageBuilder()
                  .To("xeno.esport@gmail.com")
                  .Subject('['+textBoxName.Text+']'+" Ceci est le titre")
                  .Body("la même \n\n\n\n "+ textBoxName .Text+ '\n'+ textBoxEmail.Text)
                  .Build();

                emailMessenger.SendEmail(email);
            }



            ResetAllControl();
        }
      
     
        private void ResetAllControl()
        {
            //   textBoxEmail.Text = string.Empty;
            // textBoxName.Text = string.Empty;
            textBoxMessage.Text = string.Empty;
            textBoxSujet.Text = string.Empty;
        }
    }
}

