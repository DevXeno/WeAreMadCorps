using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WeAreMadCorps.Cards
{
    public class ConfigIconView : ContentView
    {
        public ConfigIconView()
        {

            BackgroundColor = StyleKit.CardFooterBackgroundColor;

        
                
             Image image =  new Image()
            {
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                HeightRequest = 10,
                WidthRequest = 10,
                Source = StyleKit.Icons.Cog
            };

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.SetBinding(TapGestureRecognizer.CommandProperty, "TapCommand");
            image.GestureRecognizers.Add(tapGestureRecognizer);

            this.Content = image;





        }
        public event EventHandler<Image> OnTap;

        private void Btn_Clicked(object sender, EventArgs e)
        {
           // Modification de la carte avec animation
        }
    }
}
