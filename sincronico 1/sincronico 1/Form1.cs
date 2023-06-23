using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sincronico_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void txt_iniciar_Click(object sender, EventArgs e)
        {

            //Thread.Sleep(5000);
            //MessageBox.Show("Ya pasaron los 5 segundos");

            gif.Enabled = true;
            await Task.Delay(5000);

        }

        private void txt_cancelar_Click(object sender, EventArgs e)
        {

            gif.Enabled = false;

        }
    }
}