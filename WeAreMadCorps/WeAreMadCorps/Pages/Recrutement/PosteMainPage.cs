using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeAreMadCorps.Pages.Recrutement
{
    public static class PosteMainPage 
    {
        public static Page GetMainPage()
        {
            return new NavigationPage(new FindAPostePage())
            {
                BarTextColor = Color.White,
                BarBackgroundColor = Color.FromHex("#F2995D"),
            };

        }

    }
}
