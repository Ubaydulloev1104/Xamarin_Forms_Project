﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JO_REIL
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class g1str1 : ContentPage
    {
        public g1str1()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new str1());

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new str1());
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new g2str1());
        }
    }
}