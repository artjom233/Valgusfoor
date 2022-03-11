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
    public partial class StopGO : ContentPage
    {
        BoxView red, yellow, green;
        bool on_off = false;
        Grid grid;
        Button btn;
        public StopGO()

        {
            grid = new Grid
            {
                RowDefinitions =
                {
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition{Width=new GridLength(1,GridUnitType.Star)}
                }
            };

            int r = 0, g = 50, b = 20;
            red = new BoxView
            {
                Color = Color.Gray,
                CornerRadius = 30,
                WidthRequest = 200,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            yellow = new BoxView
            {
                Color = Color.Gray,
                CornerRadius = 30,
                WidthRequest = 200,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            green = new BoxView
            {
                Color = Color.Gray,
                CornerRadius = 30,
                WidthRequest = 200,
                HeightRequest = 150,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            btn = new Button
            {
                Text = "Sisse",
                TextColor = Color.AliceBlue,
                BackgroundColor = Color.Black,
                FontSize = 50
                
                

            };
            btn.Clicked += Btn_Clicked;
            grid.Children.Add(red, 0, 0);
            grid.Children.Add(yellow, 0, 1);
            grid.Children.Add(green, 0, 2);
            grid.Children.Add(btn, 0, 3);
            Content = grid;
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            
            if (on_off)
            {
                on_off = false;
                red.Color = Color.Gray;
                yellow.Color = Color.Gray;
                green.Color = Color.Gray;
                btn.Text = ("Sisse");
            }
            else
            {
                
                btn.Text = ("Valja");
                
                on_off = true;
                Show();
            }
        }
        
        private async void Show()
        {
            while (on_off)
            {
                btn.Text = ("Valja");
               
                for (int i = 0; i < 2; i++ )
                {
                    btn.Text = "STOP";
                    btn.TextColor = Color.Red;
                    btn.FontSize = 100;
                    red.Color = Color.Red;
                    await Task.Delay(500);
                    red.Color = Color.Gray;
                    await Task.Delay(500);
                }
                if (on_off == false)
                {
                    break;
                }
                red.Color = Color.Red;
                await Task.Delay(500);
                btn.Text = ("Valja");

                for (int i = 0; i < 2; i++)
                {
                    btn.Text = "WAIT";
                    btn.TextColor = Color.Yellow;
                    btn.FontSize = 80;
                    yellow.Color = Color.Yellow;
                    await Task.Delay(500);
                    yellow.Color = Color.Gray;
                    await Task.Delay(500);
                }
                if (on_off == false)
                {
                    break;
                }
                yellow.Color = Color.Yellow;
                await Task.Delay(500);
                btn.Text = ("Valja");

                for (int i = 0; i < 2; i++)
                {
                    btn.Text = "GO";
                    btn.TextColor = Color.Green;
                    btn.FontSize = 50;
                    green.Color = Color.Green;
                    await Task.Delay(500);
                    green.Color = Color.Gray;
                    await Task.Delay(500);
                }
                if (on_off == false)
                {
                    break;
                }
                green.Color = Color.Green;
                await Task.Delay(500);
                
            }
            btn.Text = ("Sisse");
            btn.TextColor = Color.White;
        }
    }
    }
