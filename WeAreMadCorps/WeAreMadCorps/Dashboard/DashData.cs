using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeAreMadCorps.Pages.Contact;
using WeAreMadCorps.Pages.LesEquipes;
using WeAreMadCorps.Pages.LesStreameurs;
using WeAreMadCorps.Pages.LeStaff;
using WeAreMadCorps.Pages.Partenaires;
using WeAreMadCorps.Pages.Recrutement;

namespace WeAreMadCorps.Dashboard
{
    public  class DashData
    {
        public static List<DashSquare> GetDashData()
        {
            return new List<DashSquare>() {
                new DashSquare () {
                    BackgroundImage = "fashionbg.png",
                    IconImage = "appbar.group.png",
                    Text = "Qui Sommes-Nous ?",
                    Column = 0,
                    Row = 0,
                    NavigateType = typeof(Page1)
                },
                new DashSquare () {
                    BackgroundImage = "childrenbg.png",
                    IconImage = "children.png",
                    Text = "Nos Partenaires",
                    Column = 1,
                    Row = 0,
                    NavigateType = typeof(PartenairesCarousel)
                },
                new DashSquare () {
                    BackgroundImage = "shoesbg.png",
                    IconImage = "shoes.png",
                    Text = "Nos Tournois",
                    Column = 2,
                    Row = 0,
                    NavigateType = typeof(Page3)
                },
                new DashSquare () {
                    BackgroundImage = "luggagebg.png",
                    IconImage = "luggage.png",
                    Text = "Le Staff",
                    Column = 0,
                    Row = 1,
                    NavigateType = typeof(StaffMembers)
                },
                new DashSquare () {
                    BackgroundImage = "accessoriesbg.png",
                    IconImage = "accessories.png",
                    Text = "Les Streameurs",
                    Column = 1,
                    Row = 1,
                    NavigateType = typeof(StreamMembers)
                },
                new DashSquare () {
                    BackgroundImage = "housewaresbg.png",
                    IconImage = "housewares.png",
                    Text = "Les Equipes",
                    Column = 2,
                    Row = 1,
                    NavigateType = typeof(TeamView)
                },
                new DashSquare () {
                    BackgroundImage = "giftsbg.png",
                    IconImage = "gifts.png",
                    Text = "La WebTV",
                    Column = 0,
                    Row = 2,
                    NavigateType = typeof(WebTvPage)
                },
                new DashSquare () {
                    BackgroundImage = "foodbg.png",
                    IconImage = "food.png",
                    Text = "Le Site",
                    Column = 1,
                    Row = 2,
                    NavigateType = typeof(SiteWebPage)
                },
                new DashSquare () {
                    BackgroundImage = "restroomsbg.png",
                    IconImage = "restrooms.png",
                    Text = "Le Forum",
                    Column = 2,
                    Row = 2,
                    NavigateType = typeof(ForumPage)
                },
                new DashSquare () {
                    BackgroundImage = "vendingbg.png",
                    IconImage = "vending.png",
                    Text = "Recrutement",
                    Column = 0,
                    Row = 3,
                    NavigateType = typeof(FindAPostePage)
                },
                new DashSquare () {
                    BackgroundImage = "servicesbg.png",
                    IconImage = "services.png",
                    Text = "Contactez-nous",
                    Column = 1,
                    Row = 3,
                    NavigateType = typeof(ContactUs)
                },
                new DashSquare () { BackgroundImage = "hoursbg.png",
                    IconImage = "hours.png",
                    Text = "On verra ce qu'on y met",
                    Column = 2,
                    Row = 3,
                    NavigateType = typeof(Page12)
                }
            };
        }
    }
}

