using AppAp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Formulario : ContentPage
    {
        private readonly HttpClient _httpClient = new HttpClient();
        public Formulario()
        {
            InitializeComponent();
            Datos();
        }
        async public void  Datos()
        {
            string response = await _httpClient.GetStringAsync("https://apiappe.somee.com/app/usuario/getEstados");
            List<Estados> estados = JsonConvert.DeserializeObject<List<Estados>>(response);
            Estado.ItemsSource = estados;
            base.OnAppearing();

        }

        async private void municipioP_Selected(object sender, EventArgs e)
        {
            var selectEstado = (Estados) Estado.SelectedItem;
            if (selectEstado != null)
            {
                string response = await _httpClient.GetStringAsync("https://apiappe.somee.com/app/Municipios/get");
                List<Municipios> municipios = JsonConvert.DeserializeObject<List<Municipios>>(response);
                List<Municipios> municipiosF = new List<Municipios>();
                foreach (Municipios municipio in municipios)
                {
                    if(selectEstado.IdEstado == municipio.estadoM.IdEstado)
                    {
                        municipiosF.Add(municipio);
                    }
                   
                }


                Municipios.ItemsSource = municipiosF;
                lblEstados.Text = selectEstado.NombreEstado;
            }
        }

        async private void muColonia_Selected(object sender, EventArgs e)
        {
            var selectMunicipio = (Municipios)Municipios.SelectedItem;
            if (selectMunicipio != null)
            {
                string response = await _httpClient.GetStringAsync("https://apiappe.somee.com/app/colonia/get");
                List<Colonia> colonias = JsonConvert.DeserializeObject<List<Colonia>>(response);
                List<Colonia> coloniaF = new List<Colonia>();
                foreach (Colonia colonia in colonias)
                {
                    if (selectMunicipio.IdMunicipio == colonia.MunicipiosVmV.IdMunicipio)
                    {
                        coloniaF.Add(colonia);
                    }

                }


                Colonia.ItemsSource = coloniaF;
                lblColonia.Text = selectMunicipio.Nombre;
            }
        }

        public async void btnFormulario_cliclk(object sender, EventArgs e)
        {
            var selectEstado = (Estados)Estado.SelectedItem;
            Persona persona = new Persona()
            {
                Nombre = txt_nombre.Text,
                APaterno = txt_apaterno.Text,
                AMaterno = txt_amaterno.Text,
                Telefono = txt_telefono.Text,
                Direcion = txt_direccion.Text,
                IdEstado = selectEstado.IdEstado
            };
            Uri uri = new Uri("https://apiappe.somee.com/app/usuario/add");
            try
            {
                var datos = JsonConvert.SerializeObject(persona);
                StringContent content = new StringContent(datos, Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync(uri, content);
                if(response.StatusCode == HttpStatusCode.OK)
                {
                    await DisplayAlert("Info", "Datos Ingresados correctamente", "Ok");
                    await Navigation.PushAsync(new Lista());

                }
                else
                {
                    await DisplayAlert("Info", "Ocurrio un erro", "Ok");
                }

            }
            catch (Exception ex)
            {

            }
        }
    }
}