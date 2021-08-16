using SantoAngelo.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SantoAngelo.ViewModel
{
    public class AtrativosViewModel : BaseViewModel
    {
        public Command OpenCatedralView { get; set; }
        public Command OpenMuseuMunicipalView { get; set; }
        public Command OpenMemorialPrestesView { get; set; }
        public Command OpenMuseuCinemaView { get; set; }
        public INavigation Navigation { get; set; }

        public AtrativosViewModel()
        {
            //OpenCatedralView = new Command(() => ShowCatedralView());
        }

        public AtrativosViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            OpenCatedralView = new Command(async() => await ShowCatedralView());
            OpenMuseuMunicipalView = new Command(async() => await ShowMuseuMunicipalView());
            OpenMemorialPrestesView = new Command(async () => await ShowMemorialPrestesView());
            OpenMuseuCinemaView = new Command(async () => await ShowMuseuCinemaView());
        }

        private async Task ShowMuseuCinemaView()
        {
            await Navigation.PushAsync(new View.Tabbed.MuseuCinemaTabbed.MuseuCinemaTabbedMain());
        }

        private async Task ShowCatedralView()
        {            
            await Navigation.PushAsync(new View.Tabbed.CatedralTabbed.CatedralTabbedMain());
        }

        private async Task ShowMuseuMunicipalView()
        {
            await Navigation.PushAsync(new View.Tabbed.MuseuMunicipalTabbed.MuseuMunicipalTabbedMain());
        }

        private async Task ShowMemorialPrestesView()
        {
            await Navigation.PushAsync(new View.Tabbed.MemorialPrestesTabbed.MemorialPrestesTabbedMain());
        }
    }
}
