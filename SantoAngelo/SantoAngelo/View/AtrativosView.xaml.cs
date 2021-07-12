using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SantoAngelo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AtrativosView : ContentPage
    {
        public AtrativosView()
        {
            InitializeComponent();
        }

        private void openCatedralView(object sender, EventArgs e)
        {            
            Navigation.PushAsync(new View.Tabbed.CatedralTabbed.CatedralTabbedMain());            
        }
    }
}