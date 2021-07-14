using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace SantoAngelo.View.Tabbed.MuseuMunicipalTabbed
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MuseuMuniciaplLocation : ContentPage
    {
        public MuseuMuniciaplLocation()
        {
            InitializeComponent();

            var mapa = new Map(MapSpan.FromCenterAndRadius(new Position(-28.30542, -54.26228), Distance.FromMeters(500)));
            mapa.MapType = MapType.Street;

            var catedralSantoAngelo = new Pin()
            {
                Position = new Position(-28.30542, -54.26228),
                Label = "Museu Municipal"
            };

            mapa.Pins.Add(catedralSantoAngelo);


            MapContainer.Children.Add(mapa);
        }
    }
}