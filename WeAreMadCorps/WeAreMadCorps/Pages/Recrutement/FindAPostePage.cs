using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeAreMadCorps.Pages.Recrutement
{
    class FindAPostePage : ContentPage
    {
        public static Color BrandColor = Color.FromHex("#F2995D");

        public FindAPostePage()
        {
            Title = "Choose a Job";
            var searchBar = new SearchBar
            {
                Placeholder = "Search by Name ",
                BackgroundColor = Color.White,
                CancelButtonColor = BrandColor,
            };

            var vetlist = new ListView
            {
                HasUnevenRows = true,
                ItemTemplate = new DataTemplate(typeof(PosteCell)),
                ItemsSource = PosteData.GetData(),
                SeparatorColor = Color.FromHex("#ddd"),
            };

            var layout = new StackLayout
            {
                Children = {
                    searchBar,
                    vetlist
                }
            };

            Content = layout;

        }
    }
}
