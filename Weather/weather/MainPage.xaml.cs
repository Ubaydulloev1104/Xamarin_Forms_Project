using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;


namespace weather
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        const string API = "fa41dd0ea68b8059fe89518f83de9ca0";

        public class Weather
        {
            public int id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }

        public class Main
        {
            public double temp { get; set; }
            public double feels_like { get; set; }
            public int humidity { get; set; }
        }

        public class Wind
        {
            public double speed { get; set; }
        }

        public class RootObject
        {
            public List<Weather> weather { get; set; }
            public string @base { get; set; }
            public Main main { get; set; }
            public Wind wind { get; set; }
            public int timezone { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public int cod { get; set; }
        }


        private async void GetWeather_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userInput.Text))
            {
                await DisplayAlert("Error", "Enter the name of the city", "Ok");
                return;
            }
            string city = userInput.Text.Trim();
            if (city.Length < 2)
            {
                await DisplayAlert("Error", " City used to be bigger", "Ok");
                return;
            }
            HttpClient client = new HttpClient();
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={API}&units=metric";
            string response = await client.GetStringAsync(url);
            RootObject rootObject = JsonConvert.DeserializeObject<RootObject>(response);
            result_country_Label.Text = "Country ; " + rootObject.name;
            result_weather_Label.Text = "Weather now ; " + rootObject.weather[0].description;
            result_temp_Label.Text = "Temperature ; " + rootObject.main.temp+ "°C/°F";
            result_tempfeels_like_Label.Text = "Feels_like ; " + rootObject.main.feels_like+ "°C/°F";
            result_wind_Label.Text = "Wind speed ; " + rootObject.wind.speed + " km/h";
            result_description_Label.Text = "Humidity ; "+rootObject.main.humidity+ "%";
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new About_us());
        }
    }
}
