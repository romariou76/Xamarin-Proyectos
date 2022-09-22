using ApiRest.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ApiRest
{
    public partial class MainPage : ContentPage
    {
        private string url = "https://jsonplaceholder.typicode.com/todos";
        HttpClient cliente = new HttpClient();
        public MainPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            string contenido = await cliente.GetStringAsync(url);
            IEnumerable<UsuarioModel> lista = JsonConvert.DeserializeObject<IEnumerable<UsuarioModel>>(contenido);
            ltusuario.ItemsSource=new ObservableCollection<UsuarioModel>(lista);
            base.OnAppearing();
        }
    }
}
