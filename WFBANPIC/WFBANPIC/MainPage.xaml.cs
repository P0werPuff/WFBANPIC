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
    public partial class Home : ContentPage
    {
        string[] BTN_names = new string[3]
        {
            "Bo1", "Bo3", "Bo5"
        };
        public Home()
        {
            InitializeComponent();

            for (int tick = 0; tick < 3; tick++)
            {
                Button btn = new Button
                {
                    Text = BTN_names[tick],
                    WidthRequest = 150,
                    HeightRequest = 50,
                    Margin = 10,
                    BackgroundColor = Color.FromRgb(0, 149, 248),
                    FontSize = 20,
                };
                btn.Clicked += Btn_Clicked;
                stack.Children.Add(btn);
            }
        }

       

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            Button BTN_temp = (Button)sender;
            switch (BTN_temp.Text)
            {
                case "Bo1":
                    await Navigation.PushAsync(new Bo1());
                    break;
                case "Bo3":
                    await Navigation.PushAsync(new Bo3());
                    break;
                case "Bo5":
                    await Navigation.PushAsync(new Bo5());
                    break;

            }
        }
    }
}