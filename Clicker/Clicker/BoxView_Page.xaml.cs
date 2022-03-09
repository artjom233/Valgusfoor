using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Clicker
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BoxView_Page : ContentPage
    {
        BoxView box;

        public BoxView_Page()
        {
        
        
            int r = 0, g = 50, b = 20;
            box = new BoxView
            {
                Color = Color.FromRgb(r, g, b),
                CornerRadius = 30,
                WidthRequest = 200,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += Tap_Tapped;
            box.GestureRecognizers.Add(tap);
            StackLayout st = new StackLayout { Children = { box } };
            Content = st;

        
        }
        Color clr;
        

      
        private void Tap_Tapped(object sender, EventArgs e)
        {
            clr = Color.Red;

            box.Color = Color.Red;          
             
            }

        }
    }
