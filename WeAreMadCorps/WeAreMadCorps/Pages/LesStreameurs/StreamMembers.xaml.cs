using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFImageLoading;
using Xamarin.Forms;

namespace WeAreMadCorps.Pages.LesStreameurs
{
    public partial class StreamMembers : ContentPage
    {
        private ListView mListView;
     

        public StreamMembers()
        {
            InitializeComponent();

            StreamMemberModel smModel = new StreamMemberModel();

            LVMain.ItemsSource = smModel.streamMembers;
        }

    }
}
