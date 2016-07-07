using FFImageLoading.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeAreMadCorps.Dashboard;
using Xamarin.Forms;

namespace WeAreMadCorps.Widgets
{
    public class DashWidgetView : ContentView
    {
        public event EventHandler<WidgetTappedEventArgs> Tapped;

        public DashWidgetView(DashSquare square)
        {

            RelativeLayout layout = new RelativeLayout();

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += (s, e) => {
                EventHandler<WidgetTappedEventArgs> handler = Tapped;

                if (handler != null)
                {
                    handler(this, new WidgetTappedEventArgs(square.NavigateType));
                }
            };

            layout.GestureRecognizers.Add(tapGestureRecognizer);

            var backgroundImage = new Image()
            {
                Source = new FileImageSource() { File = square.BackgroundImage },
                Aspect = Aspect.AspectFill
            };

            layout.Children.Add(backgroundImage,
                Constraint.Constant(0),
                Constraint.Constant(0),
                Constraint.RelativeToParent((parent) => {
                    return parent.Width;
                }),
                Constraint.RelativeToParent((parent) => {
                    return parent.Height;
                }));

            var iconImage = new CachedImage() { Source = new FileImageSource() { File = square.IconImage } };

            layout.Children.Add(
                iconImage,
                Constraint.RelativeToParent((parent) => {
                    return ((parent.Width / 2) - (iconImage.Width / 2));
                }),
                Constraint.RelativeToParent((parent) => {
                    return parent.Height * .25;
                }),
                Constraint.RelativeToParent((parent) => {
                    return parent.Width * .45;
                }),
                Constraint.RelativeToParent((parent) => {
                    return parent.Width * .45;
                })
            );

            iconImage.SizeChanged += (sender, e) => {
                layout.ForceLayout();
            };

            var dashlabel = new Label()
            {
                Text = square.Text,
                HorizontalTextAlignment = TextAlignment.Center,
                TextColor = Color.White,
                FontFamily = Device.OnPlatform("AvenirNextCondensed-Bold", "sans-serif-condensed", null)
            };

            layout.Children.Add(dashlabel,
                Constraint.Constant(0),
                Constraint.RelativeToParent((parent) => {
                    return parent.Height - 30;
                }),
                Constraint.RelativeToParent((parent) => {
                    return parent.Width;
                }),
                Constraint.RelativeToParent((parent) => {
                    return parent.Height;
                }));

            Content = layout;
        }


    }
}
