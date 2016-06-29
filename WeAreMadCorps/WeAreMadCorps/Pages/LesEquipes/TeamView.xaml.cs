using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WeAreMadCorps.Pages.LesEquipes
{
    public partial class TeamView : ContentPage
    {
        public TeamView()
        {
            InitializeComponent();
            TeamModel smModel = new TeamModel();

            LVMain.ItemsSource = smModel.Teams;

        }
    }
}
