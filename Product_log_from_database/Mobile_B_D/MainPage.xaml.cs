using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using SQLite;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mobile_B_D
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            ShowItems();
        }
        private void ShowItems()
        {
            itemsCollection.ItemsSource = App.Db.GetItems();
        }
        private async void AddItemButton(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Additem());
        }
    }
}
