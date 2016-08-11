using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeAreMadCorps.Cards
{
    public class CardContentPage : ContentPage
    {
        //A faire : Recycler View + Card View : https://blog.xamarin.com/recyclerview-highly-optimized-collections-for-android-apps/


        public CardContentPage()
        {
            Title = "Activity";
            BackgroundColor = Color.White;
            var cards = new Card_Data_Demo();

            var cardstack = new StackLayout
            {
                Spacing = 15,
                Padding = new Thickness(10),
                VerticalOptions = LayoutOptions.StartAndExpand,
            };

            foreach (Card card in cards)
            {
                cardstack.Children.Add(new CardView(card));
            }

            var shadowcardstack = new StackLayout
            {
                Spacing = 5,
                Padding = new Thickness(5),
                VerticalOptions = LayoutOptions.StartAndExpand,
            };

            foreach (var card in cards)
            {
                shadowcardstack.Children.Add(new ShadowCardView(card));
            }
            
            Content =
                Content = new ScrollView()
                {
                    Content = new StackLayout()
                    {
                        Children = {
                            cardstack,
                            shadowcardstack
                        }
                    }

                };

        }
    }
}
