using FreshMvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreMadCorps.Pages.LesEquipes
{
    public class TeamModel : FreshBasePageModel
    {
        private TeamViewModel _selectedItem;

        public ObservableCollection<TeamViewModel> Teams { get; set; }

        public TeamViewModel SelectedItem
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

        public TeamModel()
        {
            Teams = new ObservableCollection<TeamViewModel>();
            Teams.Add(new TeamViewModel { Name = "MadCorps.OW", Jeu = "Overwatch", Plateforme = "PC", Description = "  ", ImagePath = "http://i.imgur.com/z4rs6Vb.png" });
            Teams.Add(new TeamViewModel { Name = "MadCorps.Ladies",Jeu="CS:GO",Plateforme="PC", Description = "  ",ImagePath= "http://i.imgur.com/h33SO9S.png" });
            Teams.Add(new TeamViewModel { Name = "MadCorps.Hearthstone", Jeu = "Hearthstone", Plateforme = "PC", Description = "  ",ImagePath= "http://i.imgur.com/yMwnjAH.png"});
            Teams.Add(new TeamViewModel { Name = "MadCorps eSport", Jeu = "HOTS", Plateforme = "PC", Description = "  ",ImagePath= "http://i.imgur.com/sP4H0Z7.png" });
            Teams.Add(new TeamViewModel { Name = "MadCorps Green", Jeu = "LoL", Plateforme = "PC", Description = "  ",ImagePath= "http://i.imgur.com/Xksm6pH.png"});
            Teams.Add(new TeamViewModel { Name = "MadCorps White", Jeu = "LoL", Plateforme = "PC", Description = "  ",ImagePath= "http://i.imgur.com/XnovTQc.jpg"});
            }

    }
}
