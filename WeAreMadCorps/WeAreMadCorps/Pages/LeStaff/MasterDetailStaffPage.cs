using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeAreMadCorps.Pages.LeStaff
{
    public class MasterDetailStaffPage : MasterDetailPage
    {
        public MasterDetailStaffPage()
        {
            var master = new Staff();
            Master = master;

            // The root page of your application
            var navContainer = new FreshNavigationContainer(FreshPageModelResolver.ResolvePageModel<StaffMemberModel>());
            navContainer.BarTextColor = Color.FromHex("#3c3947");
            Detail = null;;
        }
    }
}
