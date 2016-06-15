using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WeAreMadCorps.Pages.LeStaff
{
    public partial class StaffMemberListView : ContentPage
    {
        public StaffMemberListView()
        {
            InitializeComponent();

            StaffMemberModel smModel = new StaffMemberModel();
            
            LVMain.ItemsSource = smModel.staffMembers;
        }
    }
}
