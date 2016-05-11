using System;

using Xamarin.Forms;
using System.Linq;
using System.Collections.Generic;
using WeAreMadCorps.Widgets;

namespace WeAreMadCorps.Dashboard
{
    public class MallDashPage : ContentPage
    {
        public MallDashPage()
        {
            Title = "Dashboard";

            var dashboard = new Grid()
            {
                ColumnSpacing = 0,
                RowSpacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            foreach (var x in Enumerable.Range(0, 4).ToList())
            {
                dashboard.RowDefinitions.Add(
                    new RowDefinition
                    {
                        Height = new GridLength(1, GridUnitType.Star)
                    });
            }

            foreach (var x in Enumerable.Range(0, 3).ToList())
            {
                dashboard.ColumnDefinitions.Add(new ColumnDefinition
                {
                    Width = new GridLength(1, GridUnitType.Star)
                });
            }



            var squares = DashData.GetDashData();

            foreach (DashSquare x in squares)
            {
                var widget = new DashWidgetView(x);
                widget.Tapped += (object sender, WidgetTappedEventArgs e) =>
                {
                    var page = Activator.CreateInstance(e.Page) as Page;
                    Navigation.PushAsync(page);
                };
                dashboard.Children.Add(widget, x.Column, x.Row);
            }


            Content = dashboard;
        }
    }
}