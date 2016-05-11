using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeAreMadCorps.Dashboard
{
    public class MallDashApp
    {
        public Page GetMainPage()
        {
            return new NavigationPage(new MallDashPage())
            {
                BarBackgroundColor = Color.Black,
                BarTextColor = Color.White
            };
        }
    }
}
