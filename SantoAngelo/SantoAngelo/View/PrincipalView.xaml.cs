using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SantoAngelo.ViewModel;
using SantoAngelo.Model;
using static SantoAngelo.Model.Weather;
using SantoAngelo.Services;

namespace SantoAngelo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrincipalView : ContentPage
    {
        Root dados = new Root();
        public PrincipalView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            //base.OnAppearing();
            //PrincipalViewModel principal = new PrincipalViewModel();
            //principal.GetWeather();

            dados = DownloadWeatherData.GetTempData();
            lblTemperatura.Text = dados.results.temp.ToString() + "°C";

        }
    }
}