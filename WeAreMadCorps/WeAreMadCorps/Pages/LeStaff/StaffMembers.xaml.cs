using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFImageLoading;
using Xamarin.Forms;

namespace WeAreMadCorps.Pages.LeStaff
{
    public partial class StaffMembers : ContentPage
    {
        public StaffMembers()
        {
            InitializeComponent();

            StaffMemberModel smModel = new StaffMemberModel();

            LVMain.ItemsSource = smModel.staffMembers;
        }
    }
}
