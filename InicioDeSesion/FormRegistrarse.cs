using BiblioExpedientes;
using System;
using System.Windows.Forms;

namespace InicioDeSesion
{
    public partial class FormRegistrarse : Form
    {
        public delegate void DelegateUsuario(Usuario usuario);
        public event DelegateUsuario EnviarUsuario;
        public FormRegistrarse()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbEmail.Text == "" || txtbNombre.Text == "" || txtbPassword.Text == "" || txtbConfirmar.Text == "")
                {
                    throw new ApplicationException("Falta llenar campos");
                }
                if (txtbPassword.Text == txtbConfirmar.Text)
                {
                    EnviarUsuario(new Paciente(txtbNombre.Text, txtbPassword.Text, txtbEmail.Text));
                    txtbEmail.Clear();
                    txtbNombre.Clear();
                    txtbPassword.Clear();
                    txtbConfirmar.Clear();
                    MessageBox.Show("Registro exitoso");
                    Close();
                }
                else
                    MessageBox.Show("La contraseña no coincide");
            }
            catch (ApplicationException error)
            {
                MessageBox.Show(error.Message);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        #region Lineas
        private void txtbEmail_MouseEnter(object sender, EventArgs e)
        {
            lbLinea1.Location = new System.Drawing.Point(57, 117);
        }

        private void txtbEmail_MouseLeave(object sender, EventArgs e)
        {
            lbLinea1.Location = new System.Drawing.Point(57, 112);
        }

        private void txtbNombre_MouseEnter(object sender, EventArgs e)
        {
            lbLinea2.Location = new System.Drawing.Point(57, 245);
        }

        private void txtbNombre_MouseLeave(object sender, EventArgs e)
        {
            lbLinea2.Location = new System.Drawing.Point(57, 240);
        }

        private void txtbPassword_MouseEnter(object sender, EventArgs e)
        {
            lbLinea3.Location = new System.Drawing.Point(57, 385);
        }

        private void txtbPassword_MouseLeave(object sender, EventArgs e)
        {
            lbLinea3.Location = new System.Drawing.Point(57, 380);
        }

        private void txtbConfirmar_MouseEnter(object sender, EventArgs e)
        {
            lbLinea4.Location = new System.Drawing.Point(57, 517);
        }

        private void txtbConfirmar_MouseLeave(object sender, EventArgs e)
        {
            lbLinea4.Location = new System.Drawing.Point(57, 512);
        }
        #endregion
    }
}
