using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Clicker
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            Button Box_btn = new Button
            {
                Text = "Clicker",
                BackgroundColor = Color.Gray
            };
            Button Datat_btn = new Button
            {
                Text = "DataTime",
                BackgroundColor = Color.Gray
            };
            Button Stop_btn = new Button
            {
                Text = "Svetofor",
                BackgroundColor = Color.Gray
            };
            Button Step_btn = new Button
            {
                Text = "Clicker",
                BackgroundColor = Color.Gray
            };
            StackLayout st = new StackLayout
            {
                Children = { Box_btn, Datat_btn, Step_btn, Stop_btn }
            };
            st.BackgroundColor = Color.Indigo;
            Content = st;
            Box_btn.Clicked += Box_btn_Clicked;
            st.BackgroundColor = Color.White;
            Content = st;

            Stop_btn.Clicked += Stop_btn_Clicked;
            st.BackgroundColor = Color.White;
            Content = st;

            st.BackgroundColor = Color.White;
              Content = st;
            Step_btn.Clicked += Step_btn_Clicked;
           
            st.BackgroundColor = Color.Indigo;
            Content = st;
            Datat_btn.Clicked += Datat_btn_Clicked; ;
        }

        private async void Stop_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StopGO());
        }

        private async void Step_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StepperSlider_Page());
        }

        private async void Datat_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DataTime_Page());
        }

        private async void Box_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BoxView_Page());
        }
    }
}
