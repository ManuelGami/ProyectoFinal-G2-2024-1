using System.Windows.Forms;

namespace PantallaExpediente
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnReservar_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Cita reservada");
        }
    }
}
