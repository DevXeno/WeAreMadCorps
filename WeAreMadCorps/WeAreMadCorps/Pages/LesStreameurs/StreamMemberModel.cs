using System;
using Xamarin.Forms;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FreshMvvm;

namespace WeAreMadCorps.Pages.LesStreameurs
{
    public class StreamMemberModel : FreshBasePageModel
    {
        private StreamMember _selectedItem;

        public ObservableCollection<StreamMember> streamMembers { get; set; }

        public StreamMember SelectedItem
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

        public StreamMemberModel()
        {
            streamMembers = new ObservableCollection<StreamMember>();
            streamMembers.Add(new StreamMember { Name = "MissCorta", Description = "  ", ImagePath = "http://i1.wp.com/www.madcorps.com/wp-content/uploads/2016/04/missCorta.jpg" });
            streamMembers.Add(new StreamMember { Name = "ChickenFaill", Description = "", ImagePath = "http://i0.wp.com/www.madcorps.com/wp-content/uploads/2016/04/chicken.png" });
            streamMembers.Add(new StreamMember { Name = "RoXy", Description = " ",ImagePath = "http://i2.wp.com/www.madcorps.com/wp-content/uploads/2014/12/RoXy.png" });
            streamMembers.Add(new StreamMember { Name = "Galaxyan", Description = "", ImagePath = "http://i2.wp.com/www.madcorps.com/wp-content/uploads/2016/04/galaxyan_mini.jpg" });
            streamMembers.Add(new StreamMember { Name = "Zhiween", Description = " ", ImagePath = "http://i2.wp.com/www.madcorps.com/wp-content/uploads/2016/04/zhiween.jpg" });
            streamMembers.Add(new StreamMember { Name = "Haraskipik", Description = "  ", ImagePath = "http://i1.wp.com/www.madcorps.com/wp-content/uploads/2016/04/haraskipik.jpg" });
            streamMembers.Add(new StreamMember { Name = "Elkinoo", Description = " ", ImagePath = "http://i2.wp.com/www.madcorps.com/wp-content/uploads/2016/04/elkinoo.jpg" });
            streamMembers.Add(new StreamMember { Name = "Milleva", Description = "  ", ImagePath = "http://i1.wp.com/www.madcorps.com/wp-content/uploads/2016/04/Milleva.jpg" });
            streamMembers.Add(new StreamMember { Name = "Bruckler", Description = " ", ImagePath = "http://i0.wp.com/www.madcorps.com/wp-content/uploads/2016/04/bruckler.jpg" });
            streamMembers.Add(new StreamMember { Name = "DorsK", Description = "  ", ImagePath = "http://i2.wp.com/www.madcorps.com/wp-content/uploads/2016/04/dorsK.jpg" });
            streamMembers.Add(new StreamMember { Name = "Brainstorm", Description = " ", ImagePath = "http://i2.wp.com/www.madcorps.com/wp-content/uploads/2016/04/brainstorm.png" });
            streamMembers.Add(new StreamMember { Name = "Mayki", Description = "  ", ImagePath = "http://i2.wp.com/www.madcorps.com/wp-content/uploads/2016/04/mayki.png" });
            streamMembers.Add(new StreamMember { Name = "Globnot", Description = " ", ImagePath = "http://i1.wp.com/www.madcorps.com/wp-content/uploads/2016/04/globnot.jpg" });
            
        }



    }
}
