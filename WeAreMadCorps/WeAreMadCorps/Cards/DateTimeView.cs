using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeAreMadCorps.Cards
{
    public class DateTimeView : ContentView
    {
        public DateTimeView(Card card)
        {
            var labelStyle = new Style(typeof(Label))
            {
                Setters = {
                    new Setter { Property = Label.TextColorProperty, Value = StyleKit.MediumGrey },
                    new Setter { Property = Label.VerticalOptionsProperty, Value = LayoutOptions.Center },
                    new Setter { Property = Label.FontSizeProperty, Value = 8 }
                }
            };
            var iconStyle = new Style(typeof(Image))
            {
                Setters = {
                    new Setter { Property = Label.HeightRequestProperty, Value = 10 },
                    new Setter { Property = Label.WidthRequestProperty, Value = 10 },
                    new Setter { Property = Label.VerticalOptionsProperty, Value = LayoutOptions.Center }
                }
            };

            var stack = new StackLayout()
            {
                VerticalOptions = LayoutOptions.Center,
                HeightRequest = 20,
                Padding = new Thickness(0),
                Orientation = StackOrientation.Horizontal,
                Children = {
                    new Image () {
                        Style = iconStyle,
                        Source = StyleKit.Icons.SmallCalendar,
                    },
                    new Label () {
                        Text = card.DueDate.ToString("d"),
                        Style = labelStyle,
                    },
                    new BoxView () { Color = Color.Transparent, WidthRequest = 20 },
                    new Image () {
                        Style = iconStyle,
                        Source = StyleKit.Icons.SmallClock,
                    },
                    new Label () {
                        Text = card.DirationInMinutes.ToString () + " Minutes",
                        Style = labelStyle,
                    }
                }
            };

            Content = stack;
        }
    }
}
