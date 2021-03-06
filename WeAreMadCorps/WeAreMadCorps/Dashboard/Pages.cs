﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeAreMadCorps.Pages.Contact;
using WeAreMadCorps.Ressources;
using Xamarin.Forms;

namespace WeAreMadCorps.Dashboard
{
    public class Page1 : ContentPage
    {
        public Page1()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = labels.QUISOMMESNOUS ,
                                HorizontalTextAlignment= TextAlignment.Center,
                                VerticalTextAlignment = TextAlignment.Center}
                    
                }
            };
        }
    }
    public class Page2 : ContentPage
    {
        public Page2()
        {
            AbsoluteLayout peakLayout = new AbsoluteLayout
            {
                HeightRequest = 250,
                BackgroundColor = Color.Black
            };

            var title = new Label
            {
                Text = "South Mountain",
                FontSize = 30,
                FontFamily = "AvenirNext-DemiBold",
                TextColor = Color.White
            };

            var where = new Label
            {
                Text = "Phoenix, AZ 85044",
                TextColor = Color.FromHex("#ddd"),
                FontFamily = "AvenirNextCondensed-Medium"
            };

            var image = new Image()
            {
                Source = ImageSource.FromFile("southmountain.jpg"),
                Aspect = Aspect.AspectFill,
            };

            var overlay = new BoxView()
            {
                Color = Color.Black.MultiplyAlpha(.7f)
            };

            var pin = new Image()
            {
                Source = ImageSource.FromFile("pin.png"),
                HeightRequest = 25,
                WidthRequest = 25
            };

            var description = new Frame()
            {
                Padding = new Thickness(10, 5),
                HasShadow = false,
                BackgroundColor = Color.Transparent,
                Content = new Label()
                {
                    FontSize = 14,
                    TextColor = Color.FromHex("#ddd"),
                    Text = "With close to 17,000 acres, South Mountain Park is the world's largest city park. It's one of the Phoenix icons like \"Camelback Mountain\" and \"Superstition Mountain\". From a distance, South Mountain looks like one big dead mountain, but those that hike it realize that it features some gorgeous scenery and great horizon views in all directions. South Mountain features some of the most popular urban hiking and biking trails in the city and also very enjoyable horseback riding. The mountain is 11 miles across and is home to more than 150 animal species and two mountain ranges including \"Ma Ha Range\" and \"Guadalupe Range\"."
                }
            };

            AbsoluteLayout.SetLayoutFlags(overlay, AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(overlay, new Rectangle(0, 1, 1, 0.3));

            AbsoluteLayout.SetLayoutFlags(image, AbsoluteLayoutFlags.All);
            AbsoluteLayout.SetLayoutBounds(image, new Rectangle(0f, 0f, 1f, 1f));

            AbsoluteLayout.SetLayoutFlags(title, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(title,
                new Rectangle(0.1, 0.85, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize)
            );

            AbsoluteLayout.SetLayoutFlags(where, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(where,
                new Rectangle(0.1, 0.95, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize)
            );

            AbsoluteLayout.SetLayoutFlags(pin, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(pin,
                new Rectangle(0.95, 0.9, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize)
            );

            peakLayout.Children.Add(image);
            peakLayout.Children.Add(overlay);
            peakLayout.Children.Add(title);
            peakLayout.Children.Add(where);
            peakLayout.Children.Add(pin);

            Content = new StackLayout()
            {
                BackgroundColor = Color.FromHex("#333"),
                Children = {
                            peakLayout,
                            description
                         }
            };
        }
    }
    public class Page3 : ContentPage
    {
        public Page3()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Page 3" }
                }
            };
        }
    }
    public class Page4 : ContentPage
    {
        public Page4()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Page 4" }
                }
            };
        }
    }
    public class Page5 : ContentPage
    {
        public Page5()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Page 5" }
                }
            };
        }
    }
    public class Page6 : ContentPage
    {
        public Page6()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Page 6" }
                }
            };
        }
    }
    public class WebTvPage : ContentPage
    {
        public WebTvPage()
        {
            
            Device.OpenUri(new Uri("http://twitch.tv/madcorps_tv"));
            SendBackButtonPressed();
        }
    }
    public class SiteWebPage : ContentPage
    {
        public SiteWebPage()
        {
            Device.OpenUri(new Uri("http://madcorps.com"));
            SendBackButtonPressed();
        }
    }
    public class ForumPage : ContentPage
    {
        public ForumPage()
        {
            Device.OpenUri(new Uri("http://madcorps.com/forum/"));
           
        }
    }
    public class Page10 : ContentPage
    {
        public Page10()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Page 10" }
                }
            };
        }
    }
    public class ContactezNous : ContentPage
    {
        public ContactezNous()
        {
             Device.OpenUri(new Uri("mailto:" + "contact@madcorps.com"));
           // ContactUs
        }
    }
    public class Page12 : ContentPage
    {
        public Page12()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Page 12" }
                }
            };
        }
    }
}
