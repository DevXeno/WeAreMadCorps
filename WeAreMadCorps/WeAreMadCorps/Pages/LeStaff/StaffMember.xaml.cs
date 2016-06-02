using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WeAreMadCorps.Pages.LeStaff
{
    public partial class Staff : ContentPage
    {
        public Staff()
        {
            InitializeComponent();

            Title = "Staff";
            Icon = "restrooms.png";
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Title = "Les Membres du Staff";
        }
    }
}
