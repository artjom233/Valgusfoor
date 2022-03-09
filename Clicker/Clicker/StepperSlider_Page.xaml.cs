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
    public partial class StepperSlider_Page : ContentPage
    {
        Label lbl;
        BoxView rgb_box;
        Slider sld, redSlider, greenSlider, blueSlider;
        Stepper stp;
        public StepperSlider_Page()
        {
            lbl = new Label
            {
                Text = "tut",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            rgb_box = new BoxView
            {
             
                CornerRadius = 10,
                WidthRequest = 200,
                HeightRequest = 250,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            sld = new Slider
            {
                Minimum = 0,
                Maximum = 100,
                Value = 40,
                MinimumTrackColor = Color.White,
                MaximumTrackColor = Color.Black,
                ThumbColor = Color.Purple,

            };
            sld.ValueChanged += Sld_ValueChanged;

            redSlider = new Slider
            {
                Minimum = 0,
                Maximum = 255,
                Value = 40,
                MinimumTrackColor = Color.White,
                MaximumTrackColor = Color.Black,
                ThumbColor = Color.Red,
            };
            redSlider.ValueChanged += Sld_ValueChanged;
          
            greenSlider = new Slider
            {
                Minimum = 0,
                Maximum = 255,
                Value = 40,
                MinimumTrackColor = Color.White,
                MaximumTrackColor = Color.Black,
                ThumbColor = Color.Green,
            };
            greenSlider.ValueChanged += Sld_ValueChanged;
            
            blueSlider = new Slider
            {
                Minimum = 0,
                Maximum = 255,
                Value = 40,
                MinimumTrackColor = Color.White,
                MaximumTrackColor = Color.Black,
                ThumbColor = Color.Blue,
            };
            blueSlider.ValueChanged += Sld_ValueChanged;

            stp = new Stepper
            {
                Minimum = 0,
                Maximum = 255,
                Value = 40,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.EndAndExpand
            };
            stp.ValueChanged += Sld_ValueChanged;
            StackLayout st = new StackLayout
            {
                Children = { sld, rgb_box, lbl, stp, redSlider,greenSlider, blueSlider }
            };
            Content = st;
        }

        private void Sld_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            rgb_box.BackgroundColor = Color.FromRgb((int)redSlider.Value, (int)greenSlider.Value, (int)blueSlider.Value);
        }
    }
}