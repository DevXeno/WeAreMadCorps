using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace WeAreMadCorps.MasterDetail
{
    public partial class MainMasterPage : ContentPage
    {

        public ListView ListView { get { return listView; } }

        ListView listView;

        public MainMasterPage()
        {
            Title = "menu"; // The Title property must be set.
            BackgroundColor = Color.FromHex("333333");

            listView = new MenuListView();

            var menuLabel = new ContentView
            {
                Padding = new Thickness(10, 36, 0, 5),
                Content = new Label
                {
                    TextColor = Color.FromHex("3B8500"),
                    Text = "MENU",
                }
            };

            var layout = new StackLayout
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            layout.Children.Add(menuLabel);
            layout.Children.Add(ListView);

            Content = layout;
        }
    }
}
