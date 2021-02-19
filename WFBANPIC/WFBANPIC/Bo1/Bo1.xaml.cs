using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WFBANPIC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bo1 : ContentPage
    {
        public Bo1()
        {
            InitializeComponent();

            BackgroundColor = Color.White;
            Button bridges_btn = new Button
            {
                Text = "Мосты",
                BackgroundColor = Color.FromRgb(0, 149, 248),
                Margin = 5,
                Padding = 10
            };
            StackLayout st = new StackLayout();
            st.Children.Add(bridges_btn);
            Content = st;
            bridges_btn.Clicked += bridges_btn_Clicked;

            Button jalutan_btn = new Button
            {
                Text = "Переулки",
                BackgroundColor = Color.FromRgb(0, 149, 248),
                Margin = 5
            };
            st.Children.Add(jalutan_btn);
            Content = st;
            jalutan_btn.Clicked += jalutan_btn_Clicked;

            Button Lahenlounale_btn = new Button
            {
                Text = "Д17",
                BackgroundColor = Color.FromRgb(0, 149, 248),
                Margin = 5
            };
            st.Children.Add(Lahenlounale_btn);
            Content = st;
            Lahenlounale_btn.Clicked += Lahenlounale_btn_Clicked;

            Button Magan_btn = new Button
            {
                Text = "Пирамида",
                BackgroundColor = Color.FromRgb(0, 149, 248),
                Margin = 5
            };
            st.Children.Add(Magan_btn);
            Content = st;
            Magan_btn.Clicked += Magan_btn_Clicked;

            Button Soon_btn = new Button
            {
                Text = "Пункт Назначения",
                BackgroundColor = Color.FromRgb(0, 149, 248),
                Margin = 5
            };
            st.Children.Add(Soon_btn);
            Content = st;
            Soon_btn.Clicked += Soon_btn_Clicked;

            Button Soonputru_btn = new Button
            {
                Text = "Фабрика",
                BackgroundColor = Color.FromRgb(0, 149, 248),
                Margin = 5
            };
            st.Children.Add(Soonputru_btn);
            Content = st;
            Soonputru_btn.Clicked += Soonputru_btn_Clicked;

            Button Soonputru_btn = new Button
            {
                Text = "Окраина",
                BackgroundColor = Color.FromRgb(0, 149, 248),
                Margin = 5
            };
            st.Children.Add(Soonputru_btn);
            Content = st;
            Soonputru_btn.Clicked += Soonputru_btn_Clicked; //
        }

        private async void bridges_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ());
        }

        private async void Soon_btn_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void Magan_btn_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void Lahenlounale_btn_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void jalutan_btn_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private async void tblp_btn_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}