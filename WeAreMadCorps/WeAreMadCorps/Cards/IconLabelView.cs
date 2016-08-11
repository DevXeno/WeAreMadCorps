﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeAreMadCorps.Cards
{
    public class IconLabelView : ContentView
    {
        public IconLabelView(FileImageSource source, string text)
        {
            BackgroundColor = StyleKit.CardFooterBackgroundColor;

            var label = new Label()
            {
                Text = text,
                FontSize = 9,
                FontAttributes = FontAttributes.Bold,
                TextColor = StyleKit.LightTextColor
            };

            var stack = new StackLayout()
            {
                Padding = new Thickness(5),
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.StartAndExpand,
                VerticalOptions = LayoutOptions.Center,
                Children = {
                    new Image () {
                        Source = source,
                        HeightRequest = 10,
                        WidthRequest = 10
                    },
                    label
                }
            };

            Content = stack;
        }
    }
}
