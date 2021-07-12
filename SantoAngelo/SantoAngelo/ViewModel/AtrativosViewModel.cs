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

        public AtrativosViewModel()
        {
            OpenCatedralView = new Command(() => ShowCatedralView());
        }

        private void ShowCatedralView()
        {
            //App.Current.MainPage = new View.CatedralView();
            //new NavigationPage(new View.Tabbed.CatedralTabbed.CatedralTabbedMain());
            App.Current.MainPage = new View.Tabbed.CatedralTabbed.CatedralTabbedMain();
        }
    }
}
