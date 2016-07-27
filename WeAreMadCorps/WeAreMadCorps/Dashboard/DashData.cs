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
                    BackgroundImage = "quisommesnousbg.jpg",
                    IconImage = "",
                    Text = "Qui Sommes-Nous ?",
                    Column = 0,
                    Row = 0,
                    EphemeralPage = false,
                    NavigateType = typeof(Page1)
                },
                new DashSquare () {
                    BackgroundImage = "nospartenaires.jpg",
                    IconImage = "",
                    Text = "Nos Partenaires",
                    Column = 1,
                    Row = 0,
                    EphemeralPage = false,
                    NavigateType = typeof(PartenairesCarousel)
                },
                new DashSquare () {
                    BackgroundImage = "nostournois.jpg",
                    IconImage = "",
                    Text = "Nos Tournois",
                    Column = 2,
                    Row = 0,
                    EphemeralPage = false,
                    NavigateType = typeof(Page3)
                },
                new DashSquare () {
                    BackgroundImage = "lestaff.jpg",
                    IconImage = "",
                    Text = "Le Staff",
                    Column = 0,
                    Row = 1,
                    EphemeralPage = false,
                    NavigateType = typeof(StaffMembers)
                },
                new DashSquare () {
                    BackgroundImage = "accessoriesbg.png",
                    IconImage = "",
                    Text = "Les Streameurs",
                    Column = 1,
                    Row = 1,
                    EphemeralPage = false,
                    NavigateType = typeof(StreamMembers)
                },
                new DashSquare () {
                    BackgroundImage = "nosequipes.jpg",
                    IconImage = "",
                    Text = "Les Equipes",
                    Column = 2,
                    Row = 1,
                     EphemeralPage = false,
                    NavigateType = typeof(TeamView)
                },
                new DashSquare () {
                    BackgroundImage = "giftsbg.png",
                    IconImage = "",
                    Text = "La WebTV",
                    Column = 0,
                    Row = 2,
                     EphemeralPage = true,
                    NavigateType = typeof(WebTvPage)
                },
                new DashSquare () {
                    BackgroundImage = "siteweb.png",
                    IconImage = "",
                    Text = "Le Site",
                    Column = 1,
                    Row = 2,
                     EphemeralPage = true,
                    NavigateType = typeof(SiteWebPage)
                },
                new DashSquare () {
                    BackgroundImage = "restroomsbg.png",
                    IconImage = "",
                    Text = "Le Forum",
                    Column = 2,
                    Row = 2,
                     EphemeralPage = true,
                    NavigateType = typeof(ForumPage)
                },
                new DashSquare () {
                    BackgroundImage = "vendingbg.png",
                    IconImage = "",
                    Text = "Recrutement",
                    Column = 0,
                    Row = 3,
                    EphemeralPage = false,
                    NavigateType = typeof(FindAPostePage)
                },
                new DashSquare () {
                    BackgroundImage = "servicesbg.png",
                    IconImage = "",
                    Text = "Contactez-nous",
                    Column = 1,
                    Row = 3,
                     EphemeralPage = true,
                    NavigateType = typeof(ContactezNous)
                },
                new DashSquare () { BackgroundImage = "",
                    IconImage = "",
                    Text = "",
                    Column = 2,
                    Row = 3,
                    EphemeralPage = true,
                    NavigateType = typeof(Page12)
                }
            };
        }
    }
}

