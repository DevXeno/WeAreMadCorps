using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeAreMadCorps.Pages.Partenaires
{
    class PartenairesCarousel : CarouselPage
    {
        public PartenairesCarousel()
        {
            var partenaireCyberPC  = new PartenairesMainContent("CyberPC", "http://cyberpc.fr/fr/", "cyberpc.png", "CyberPC est un site de vente de matériel informatique créé par Mr Deveaux Servais le 15 octobre 2012. Cette entreprise propose de nombreux services comme le dépannage informatique à domicile pour particuliers et professionnels, l’entretien du parc informatique et multimédia (tv, box, PC, mac, internet, mobile) ainsi que l’installation, la configuration et la maintenance de vos produits. Leur équipe est composée de professionnels passionnés et à l’écoute de vos moindre besoins et de nombreux professionnels leur font déjà confiance: IUT de Bordeaux, Union St Jean, Gilles Dapsance Moving, Agence Immobiliére Malahar etc.");
            var partenaireTeamSpeak = new PartenairesMainContent("TeamSpeak","www.teamspeak.com", "TeamSpeak.png", "TeamSpeak est le logiciel qu’il faut pour discuter en ligne avec plusieurs personnes en même temps. Il est parfait pour ceux qui jouent en ligne et qui ont besoin de transmettre des informations. La communication par la voix donne un avantage indéniable en compétition, permettant au joueur de garder ses mains et son attention pour l’action dans le jeu, et non la communication écrite.");
            var partenairePhoneAlchemist = new PartenairesMainContent("PhoneAlchemist", "https://www.phonealchemist.com/fr/", "phonealchemist.png", "PhoneAlchemist.com : Un site deux services \nLa carte Alchemist: Une boutique ou vous pouvez payer avec votre forfait téléphonique.Plus de 2000 jeux, cartes et bons d’achats au Catalogue.Pas besoin de carte bleu ni de compte Paypal.\nLa carte Alchemist + : Un service qui vous permet de créer vos propres pages de micropaiement en quelques clics.C’est rapide, facile et ne nécessite de compétences particulières.Vous Pouvez recevoir des dons qui seront prélevés sur la facture téléphonique du donateur, pas besoin de carte bleu ou de compte Paypal.Vous êtes Twitcher ou youtuber à succès, Grâce à PhoneAlchemist.com vous pouvez ouvrir votre propre page et recevoir des dons.Vous avez une transaction a faire sur CS Go, ouvrez une page PhoneAlchemist pour pouvoir vous faire payer.");

            Children.Add(partenaireCyberPC);
            Children.Add(partenaireTeamSpeak);
            Children.Add(partenairePhoneAlchemist);
        }

    }
}
