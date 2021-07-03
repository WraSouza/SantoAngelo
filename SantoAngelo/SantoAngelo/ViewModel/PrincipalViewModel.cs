using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using static SantoAngelo.Model.Weather;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace SantoAngelo.ViewModel
{
    public class PrincipalViewModel : BaseViewModel
    {
        private string _temp;        

        public string temp
        {
            get { return _temp; }
            set { _temp = value; OnPropertyChanged(); }
        }

        public async void GetWeather()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync("https://api.hgbrasil.com/weather?woeid=455990");

                if (response.IsSuccessStatusCode)
                {
                    var dataFromSite = await response.Content.ReadAsStringAsync();
                    Root weatherData = JsonConvert.DeserializeObject<Root>(dataFromSite);
                    temp = weatherData.results.temp.ToString();
                    //_temp = temp;
                    
                }
            }

            
        }

    }
}
