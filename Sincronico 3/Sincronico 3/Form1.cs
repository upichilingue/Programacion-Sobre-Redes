namespace Sincronico_3
{
    public partial class Form1 : Form
    {
        private string apiURL;
        private HttpClient httpClient;

        public Form1()
        {
            InitializeComponent();
            apiURL = "https://localhost:7003";
            httpClient = new HttpClient();
        }

        private async void btn_iniciar_Click(object sender, EventArgs e)
        {

            //Thread.Sleep(5000);
            //MessageBox.Show("Ya pasaron los 5 segundos");
            gift.Visible = true;
            //await Task.Delay(5000);
            await Esperar();
            var nombre = txtnom.Text;
            var saludo = await ObtenerSaludo(nombre);
            MessageBox.Show(saludo);
            gift.Visible = false;

        }

        private async Task Esperar()
        {
            await Task.Delay(5000);
        }

        private async Task<string> ObtenerSaludo(string nombre)
        {

            using (var respuesta = await httpClient.GetAsync($"{apiURL}/saludos/{nombre}"))
            {

                var saludo = await respuesta.Content.ReadAsStringAsync();
                return saludo;

            }


        }

    }
}