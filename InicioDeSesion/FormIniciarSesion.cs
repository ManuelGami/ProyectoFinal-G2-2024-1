using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using BiblioExpedientes;
using PantallaExpediente;

namespace InicioDeSesion
{
    public partial class FormIniciarSesion : Form
    {
        private ArrayList usuarios;
        private byte bloquear, a;

        public FormIniciarSesion()
        {
            InitializeComponent();
            bloquear = 0;
            a = 1;
            usuarios = new ArrayList();
            CargarUsuarios();
        }
        private void CargarUsuarios()
        {
            usuarios.Add(new Paciente("Maria", "maria123","@"));
            usuarios.Add(new Paciente("Carlos", "carlos123","@"));
            usuarios.Add(new Paciente("Laura", "laura123","@"));
            usuarios.Add(new Paciente("Luis", "luis123", "@"));
            usuarios.Add(new Paciente("Alejandro", "alejandro123","@"));
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            int c = 0;
            foreach (object usuario in usuarios)
            {
                Usuario miUsuario = (Usuario)usuario;
                if (txtbUser.Text == miUsuario.User && txtbPassword.Text == miUsuario.Password)
                {
                    limpiarTxtbDisplay();
                    FormPadre formPadre = new FormPadre(this, miUsuario);
                    formPadre.Show();
                    a = 1;
                    Hide();
                    break;
                }
                else if (c == usuarios.Count - 1)
                {
                    limpiarTxtbDisplay();
                    MessageBox.Show("Nombre o contraseña incorrecto");
                    bloquear++;
                    if (bloquear == 3)
                    {
                        
                        BloquearCuenta(a);
                        a++;
                    }
                }
                c++;
            }
        }
        private void txtbUser_Enter(object sender, EventArgs e)
        {
            txtbUser.Top -= 5;
            if (txtbUser.Text == "Usuario")
                txtbUser.Clear();
            txtbUser.ForeColor = System.Drawing.Color.Black;
            
        }
        private void txtbPassword_Enter(object sender, EventArgs e)
        {
            txtbPassword.Top -= 5;
            if (txtbPassword.Text == "Contraseña")
                txtbPassword.Clear();
            txtbPassword.UseSystemPasswordChar = true;
            txtbPassword.ForeColor = System.Drawing.Color.Black;
        }
        private void txtbUser_Leave(object sender, EventArgs e)
        {
            txtbUser.Top += 5;
            if (txtbUser.Text == "")
            {
                txtbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
                txtbUser.Text = "Usuario";
            }
                
        }
        private void txtbPassword_Leave(object sender, EventArgs e)
        {
            txtbPassword.Top += 5;
            if (txtbPassword.Text == "")
            {
                txtbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
                txtbPassword.UseSystemPasswordChar = false;
                txtbPassword.Text = "Contraseña";
            }
        }
        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FormRegistrarse formRegistrarse = new FormRegistrarse();
            formRegistrarse.EnviarUsuario += AgregarUsuario;
            formRegistrarse.ShowDialog();
        }
        public void AgregarUsuario(Usuario paciente)
        {
            usuarios.Add(paciente);
        }
        private void limpiarTxtbDisplay()
        {
            txtbPassword.Clear();
            txtbUser.Clear();
            txtbUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            txtbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(133)))), ((int)(((byte)(133)))));
            txtbPassword.UseSystemPasswordChar = false;
            txtbUser.Text = "Usuario";
            txtbPassword.Text = "Contraseña";
        }

        private void FormIniciarSesion_Load(object sender, EventArgs e)
        {
            lbEresNuevo.Parent = ptbInicio;
            lbEresNuevo.BackColor = Color.Transparent;
            btnRegistrarse.Parent = ptbInicio;
            btnRegistrarse.BackColor = Color.Transparent;
        }

        private void BloquearCuenta(byte a)
        {
            txtbUser.Enabled = false;
            txtbPassword.Enabled = false;
            btnIniciar.Enabled = false;
            Timer temporizadorBloqueo = new Timer();
            temporizadorBloqueo.Interval = 5000 * a;
            temporizadorBloqueo.Tick += (sender, e) =>
            {
                txtbUser.Enabled = true;
                txtbPassword.Enabled = true;
                btnIniciar.Enabled = true;

                bloquear = 0;

                temporizadorBloqueo.Stop();
            };

            temporizadorBloqueo.Start();

            MessageBox.Show(string.Format("La cuenta está bloqueada. Inténtalo de nuevo después de {0} segundos.", a * 5));
            
        }
    }
}
