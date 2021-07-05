using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SantoAngelo.Model;
using static SantoAngelo.Model.Weather;

namespace SantoAngelo.Services
{
    
    public class DownloadWeatherData
    {
        Root weatherData;

        //public async Task<Root> GetTempData()
        //{
        //    using (var client = new HttpClient())
        //    {
        //        HttpResponseMessage response = await client.GetAsync("https://api.hgbrasil.com/weather?woeid=455990");

        //        if (response.IsSuccessStatusCode)
        //        {
        //            var dataFromSite = await response.Content.ReadAsStringAsync();
        //            weatherData = JsonConvert.DeserializeObject<Root>(dataFromSite);
        //            //temp = weatherData.results.temp.ToString();
        //            //_temp = temp;
                   
        //        }
        //    }

        //    return weatherData;
        //}

        public static Root GetTempData()
        {
            string dataWeather = string.Format("https://api.hgbrasil.com/weather?woeid=455990");

            WebClient wc = new WebClient();

            string temp = wc.DownloadString(dataWeather);

            Root tempValue = JsonConvert.DeserializeObject<Root>(temp);

            return tempValue;
        }

    }
}
