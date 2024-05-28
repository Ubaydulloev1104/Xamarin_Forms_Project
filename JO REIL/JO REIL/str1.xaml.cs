using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JO_REIL
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class str1 : ContentPage
    {
        public str1()
        {
            InitializeComponent();
        }

        private async void Button1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new g1str1());

        }
        private async void Button2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new g2str1());

        }

        private async void Button3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new g3str1());
        }

        private async void Button4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new g4str1());
        }

        private async void Button5_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new g5str1());
        }

        private async void Button6_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new g6str1());
        }

        private async void Button7_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new g7str1());
        }

        private async void Button8_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());

        }

        private void Button8_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}