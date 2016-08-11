using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeAreMadCorps.Cards;
using WeAreMadCorps.Dashboard;
using WeAreMadCorps.Pages.LesEquipes;
using WeAreMadCorps.Pages.LesStreameurs;
using WeAreMadCorps.Pages.LeStaff;
using WeAreMadCorps.Pages.Partenaires;
using Xamarin.Forms;

namespace WeAreMadCorps.MasterDetail
{
    public class MenuListData : List<MenuItem>
    {
        public MenuListData()
        {
            this.Add(new MenuItem()
            {
                Title = "Qui sommes-nous ?",
                IconSource = "contracts.png",
                TargetType = typeof(Page1)
            });

          
            this.Add(new MenuItem()
            {
                Title = "Nos Partenaires",
                IconSource = "Lead.png",
                TargetType = typeof(PartenairesCarousel)
            });

            this.Add(new MenuItem()
            {
                Title = "Le Staff",
                IconSource = "Accounts.png",
                TargetType = typeof(StaffMembers)
            });

            this.Add(new MenuItem()
            {
                Title = "Les Streameurs",
                IconSource = "Opportunity.png",
                TargetType = typeof(StreamMembers)
            });

            this.Add(new MenuItem()
            {
                Title = "Nos Partenaires",
                IconSource = "Lead.png",
                TargetType = typeof(PartenairesCarousel)

            });

            this.Add(new MenuItem()
            {
                Title = "Nos Partenaires",
                IconSource = "Lead.png",
                TargetType = typeof(PartenairesCarousel)
            });

            this.Add(new MenuItem()
            {
                Title = "Nos Partenaires",
                IconSource = "Lead.png",
                TargetType = typeof(PartenairesCarousel)
            });

            this.Add(new MenuItem()
            {
                Title = "Demo Card ListView",
                IconSource = "contracts.png",
                TargetType = typeof(CardContentPage)
            });
        }
    }
    
}
