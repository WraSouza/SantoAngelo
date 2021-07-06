using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace SantoAngelo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LocalizacaoView : ContentPage
    {
        public LocalizacaoView()
        {
            InitializeComponent();

            var mapa = new Map(MapSpan.FromCenterAndRadius(new Position(-28.3049427, -54.2650362), Distance.FromKilometers(250)));
            mapa.MapType = MapType.Street;

            var SantoAngelo = new Pin()
            {
                Position = new Position(-28.3189302, -54.2484038),
                Label = "Santo Ângelo"
            };

            mapa.Pins.Add(SantoAngelo);

            MapContainer.Children.Add(mapa);
        }
    }
}