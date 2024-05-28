using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void botton_1_Clicked(object sender, EventArgs e)
        {
            if (!Checkbox_1.IsChecked)
            {
                Checkbox_1.Color = Color.Red;
                Label_error.Text = "Error: Вы робот ? Если нет поставьти галочку!!!";
                return;
            }
            else if (!radiobutton_1.IsChecked && !radiobutton_2.IsChecked)
            {
                Label_error.Text = "Error: Выберите пол !!!";
                radiobutton_1.BackgroundColor = Color.Red;
                radiobutton_2.BackgroundColor = Color.Red;
                return;
            }
            else if (string.IsNullOrEmpty(Textbox_1.Text))
            {
                Label_error.Text = "Error: Имя нету, Водите имя!!!";
                Textbox_1.BackgroundColor = Color.Red;
                return;
            }
            else
            {
                Label_error.Text = " ";
                string s = Textbox_1.Text.Trim();
                await DisplayAlert("😁😁😁", $"Привет {s} как у тебя ?", "Хорошо");
            }
          
       
        }
    }
}
