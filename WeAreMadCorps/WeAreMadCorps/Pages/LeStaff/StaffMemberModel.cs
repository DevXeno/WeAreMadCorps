using System;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FreshMvvm;

namespace WeAreMadCorps.Pages.LeStaff
{
    public class StaffMemberModel : FreshBasePageModel
    {
        private StaffMember _selectedItem;

        public ObservableCollection<StaffMember> staffMembers { get; set; }

        public StaffMember SelectedItem
        {
            get
            {
                return _selectedItem;
            }
            set
            {
                _selectedItem = value;

                if (_selectedItem == null)
                    return;

                SelectedItem = null;
            }
        }

        public StaffMemberModel()
        {
            staffMembers = new ObservableCollection<StaffMember>();
            staffMembers.Add(new StaffMember { Name = "Sarkander", Description = " Président / CEO ", ImagePath = "http://i2.wp.com/www.madcorps.com/wp-content/uploads/2014/12/sark1.png" });
            staffMembers.Add(new StaffMember { Name = "Anyanyah", Description = " Vice-Président / DG ", ImagePath = "http://i0.wp.com/www.madcorps.com/wp-content/uploads/2014/12/anyah1.png" });
            staffMembers.Add(new StaffMember { Name = "Cellen", Description = " Directeur du pôle évènementiel ", ImagePath = "http://i2.wp.com/www.madcorps.com/wp-content/uploads/2014/12/Cellen.png" });
            staffMembers.Add(new StaffMember { Name = "Kiffman", Description = " Directeur Media ", ImagePath = "http://i1.wp.com/www.madcorps.com/wp-content/uploads/2014/12/kiff1.png" });
            staffMembers.Add(new StaffMember { Name = "Ravenna", Description = " ", ImagePath = "http://i1.wp.com/www.madcorps.com/wp-content/uploads/2014/12/nadia-ravenna.png" });
            staffMembers.Add(new StaffMember { Name = "Pyhra", Description = "  ", ImagePath = "http://i2.wp.com/www.madcorps.com/wp-content/uploads/2014/12/pyhra.jpg" });
            staffMembers.Add(new StaffMember { Name = "Sudiste", Description = " ", ImagePath = "http://i0.wp.com/www.madcorps.com/wp-content/uploads/2014/12/sud1.png" });
            staffMembers.Add(new StaffMember { Name = "Waxo", Description = "  ", ImagePath = "http://i1.wp.com/www.madcorps.com/wp-content/uploads/2014/12/waxo.jpg" });
        }
    }
}
