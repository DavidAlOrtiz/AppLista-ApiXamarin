using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalleDeEquipo : ContentPage
    {
        public DetalleDeEquipo(string nombre, string urlImagen, string liga, int camponeato)
        {
            InitializeComponent();
            textEquipo.Text = nombre;
            lblLiga.Text = liga;
            lblCampeonatos.Text = camponeato.ToString();
            imgEquipo.Source = new Uri(urlImagen);
        }

        public async void btnFormulario_cliclk(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Formulario());
        }
    }
}