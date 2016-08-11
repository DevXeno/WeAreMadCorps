using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeAreMadCorps.Dashboard;
using Xamarin.Forms;

namespace WeAreMadCorps.MasterDetail
{
    public partial class MainMasterDetailPage : MasterDetailPage
    {
        //MainMasterPage masterPage;

        public MainMasterDetailPage()
        {
            var menuPage = new MainMasterPage();

            menuPage.ListView.ItemSelected += (sender, e) => NavigateTo(e.SelectedItem as MenuItem);

            Title = "MadCorps";

            this.Master = menuPage;
            this.Detail = new NavigationPage(new Page1());
        }

        void NavigateTo(MenuItem menu)
        {
            Page displayPage = (Page)Activator.CreateInstance(menu.TargetType);

            Detail = new NavigationPage(displayPage);

            IsPresented = false;
        }

    }
}
