using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sincronico3
{
    public partial class Form1 : Form
    {

        private string apiURL;
        private HttpClient httpclient;
        public Form1()
        {
            InitializeComponent();
            apiURL = "https://localhost:7202/";
            httpclient = new HttpClient();
        }

        private async void btn_iniciar_Click(object sender, EventArgs e)
        {
            // Thread.Sleep(5000);
            //MessageBox.Show("Ya pasaron los cinco segundos");
            loadingGIF.Visible = true;
            //await Task.Delay(5000);
            await Esperar();
            var nombre = txtInput.Text;
            try
            {
                var saludo = await ObtenerSaludo(nombre);
                MessageBox.Show(saludo);
            }
            catch(HttpRequestException ex)
            {
                MessageBox.Show(ex.Message);
            }
            loadingGIF.Visible = false;
        }

        private async Task Esperar()
        {

            await Task.Delay(5000);

        }

        private async Task<string> ObtenerSaludo(string nombre)
        {

            using (var respuesta = await httpclient.GetAsync($"{apiURL}/saludos2/{nombre}"))
            {
                respuesta.EnsureSuccessStatusCode();
                var saludo = await respuesta.Content.ReadAsStringAsync();
                return saludo;
            }

        }

    }
}
