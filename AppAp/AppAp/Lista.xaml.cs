using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppAp.Entities;
using AppAp.Views;

namespace AppAp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Lista : ContentPage
    {
        public IList<Equipo> Equipos { get; private set; }
        public Lista()
        {
            InitializeComponent();
            Equipos = new List<Equipo>();
            Equipos.Add(new Equipo
            {
                Nombre = "Real Madrid CF",
                Liga = "Española",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/10/Escudo_real_madrid_1941b.png/278px-Escudo_real_madrid_1941b.png",
                Campeonatos = 14
            });
            Equipos.Add(new Equipo
            {
                Nombre = "Liverpool",
                Liga = "Inglesa",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d1/Liverpool_FC_crest%2C_Main_Stand.jpg/255px-Liverpool_FC_crest%2C_Main_Stand.jpg",
                Campeonatos = 6
            });
            Equipos.Add(new Equipo
            {
                Nombre = "Inter de Milán",
                Liga = "Italiana",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/05/FC_Internazionale_Milano_2021.svg/240px-FC_Internazionale_Milano_2021.svg.png",
                Campeonatos = 6
            });
            Equipos.Add(new Equipo
            {
                Nombre = "Milán",
                Liga = "Italiana",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/d/d0/Logo_of_AC_Milan.svg/188px-Logo_of_AC_Milan.svg.png",
                Campeonatos = 7
            });
            Equipos.Add(new Equipo
            {
                Nombre = "Borussia Dortmund",
                Liga = "Alemana",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/67/Borussia_Dortmund_logo.svg/240px-Borussia_Dortmund_logo.svg.png",
                Campeonatos = 3
            });
            Equipos.Add(new Equipo
            {
                Nombre = "Bayer",
                Liga = "Alemana",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/0/02/Bayern_M%C3%BCnchen_Logo_%281996-2002%29.svg/150px-Bayern_M%C3%BCnchen_Logo_%281996-2002%29.svg.png",
                Campeonatos = 6
            });
            Equipos.Add(new Equipo
            {
                Nombre = "Barcelona",
                Liga = "Española",
                ImagenUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/72/FCBarcelona_1910s_badge.png/270px-FCBarcelona_1910s_badge.png",
                Campeonatos = 5
            });
            BindingContext = this;
        }
        public async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Equipo selectedItem = e.CurrentSelection[0] as Equipo;
            await Navigation.PushAsync(new DetalleDeEquipo(selectedItem.Nombre, selectedItem.ImagenUrl,
                                selectedItem.Liga, selectedItem.Campeonatos));

        }
    }
}