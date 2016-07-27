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
            DisplayAlert("Succès", "Le message a été envoyé avec succès", "OK");

            Device.OpenUri(new Uri("mailto:" + "contact@madcorps.com"));

         //   CrossMessaging.Current.EmailMessenger.SendSampleEmail(BuildSampleEmail(false).Build());





            ResetAllControl();
        }
      
        public EmailMessageBuilder BuildSampleEmail(bool sendAsHtml = false)
        {
            var builder = new EmailMessageBuilder()
                .To("to.contact@madcorps.com")
                .Cc("cc.")
                //.Bcc(new[] { "bcc1.plugins@xamarin.com", "bcc2.plugins@xamarin.com" })
                .Subject('[' + textBoxName.Text + ']' + " " + textBoxSujet.Text)
                .Body(textBoxMessage.Text);

#if __ANDROID__ || __IOS__

            if (sendAsHtml)
                builder.BodyAsHtml("Well hello there from <b>Xam.Messaging.Plugin</b>");
#endif
            if (!sendAsHtml)
                builder.Body("Well hello there from Xam.Messaging.Plugin");

            return builder;
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

