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

namespace SantoAngelo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PrincipalView : ContentPage
    {
        public PrincipalView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            //base.OnAppearing();
            PrincipalViewModel principal = new PrincipalViewModel();
            principal.GetWeather();

        }
    }
}