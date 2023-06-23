namespace Sincronico_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {

        }

        private async void btn_iniciar_Click(object sender, EventArgs e)
        {

              
            //Thread.Sleep(5000);
            //MessageBox.Show("Ya pasaron los 5 segundos");
            gift.Visible = true;
            //await Task.Delay(5000);
            await Esperar();
            MessageBox.Show("pasaron los 5 segundos");
            gift.Visible = false;

        }

        private async Task Esperar()
        {
            await Task.Delay(5000);
        }

    }
}