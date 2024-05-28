using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace weather
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class About_us : ContentPage
    {
        public About_us()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushModalAsync(new MainPage());
        }
    }
}