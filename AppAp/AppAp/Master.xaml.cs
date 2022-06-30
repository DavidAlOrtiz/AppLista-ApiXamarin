using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppAp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();
        }

        private async void btnAcercade_Click(object sender, EventArgs e)
        {
            App.masterDet.IsPresented = false;
            await Navigation.PushAsync(new Detail());

        }

        private async void btnLista_Click(object sender, EventArgs e)
        {
            App.masterDet.IsPresented = false;
            await App.masterDet.Detail.Navigation.PushAsync(new Lista());

        }


    }
}