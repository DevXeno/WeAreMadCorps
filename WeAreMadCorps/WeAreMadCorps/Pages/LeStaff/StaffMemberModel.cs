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
            staffMembers.Add(new StaffMember { Name = "Sarkander", Description = " Président / CEO ", ImagePath = "foodbg.png" });
            staffMembers.Add(new StaffMember { Name = "Anyanyah", Description = " Vice-Président / DG ", ImagePath = "Habanero.png" });
            staffMembers.Add(new StaffMember { Name = "Cellen", Description = " Directeur du pôle évènementiel ", ImagePath = "housewaresbg.png" });
            staffMembers.Add(new StaffMember { Name = "Kiffman", Description = " Directeur Media ", ImagePath = "servicesbg.png" });
        }
    }
}
