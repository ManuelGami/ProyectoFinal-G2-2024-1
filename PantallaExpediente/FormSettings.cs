using System;
using BiblioExpedientes;
using System.Windows.Forms;

namespace PantallaExpediente
{
    public partial class FormSettings : Form
    {
        private Paciente paciente;
        public FormSettings(Paciente paciente)
        {
            InitializeComponent();
            this.paciente = paciente;
            cargarInfo();
            BloquearDatos();

        }

        private void cargarInfo()
        {
            txtbAltura.Text = paciente.Altura.ToString();
            txtbPeso.Text = paciente.Peso.ToString();
            txtbTemperatura.Text = paciente.Temperatura.ToString();
            txtbFrecRespiratoria.Text = paciente.FrecuenciaRespiratoria.ToString();
            txtbFrecCardiaca.Text = paciente.FrecuenciaCardiaca.ToString();
            txtbPresionArterial.Text = paciente.PresionArterial;

            txtbNombre.Text = paciente.Nombre;
            txtbSexo.Text = paciente.Sexo;
            txtbDia.Text = paciente.DiaNacimiento.ToString();
            txtbMes.Text = paciente.MesNacimiento.ToString();
            txtbAño.Text = paciente.AñoNacimiento.ToString();
            txtbEdad.Text = paciente.Edad.ToString();
            txtbTelefono.Text = paciente.Telefono;
            txtbEmail.Text = paciente.Email;
            txtbCalle.Text = paciente.Calle;
            txtbDelegacion.Text = paciente.Delegacion;
            txtbCP.Text = paciente.Cp;

            if (paciente.Polen)
            {
                rdbPolenSi.Checked = true;
            }else if (!paciente.Polen) 
            {
                rdbPolenNo.Checked = true;
            }
            if (paciente.Acaros)
            {
                rdbAcarosSi.Checked = true;
            }
            else if (!paciente.Acaros)
            {
                rdbAcarosNo.Checked = true;
            }
            if (paciente.Latex)
            {
                rdbLatexSi.Checked = true;
            }
            else if (!paciente.Latex)
            {
                rdbLatexNo.Checked = true;
            }
            if (paciente.Medicamento)
            {
                txtbMedicamento.Text = paciente.NombreMedicamento;
                rdbMedicamentoSi.Checked = true;
            }
            else if (!paciente.Medicamento)
            {
                rdbMedicamentoNo.Checked = true;
            }
            if (paciente.Alimento)
            {
                txtbAlimento.Text = paciente.NombreAlimento;
                rdbAlimentoSi.Checked = true;
            }
            else if (!paciente.Alimento)
            {
                rdbAlimentoNo.Checked = true;
            }

            lbAntecedentesHeredofamiliares.Text = paciente.concatenarAntecedenetesHeredofamiliares();

            lbEnfermedadesPrevias.Text = paciente.concatenarEnfermedadesPrevias();
            lbHospitalizacionesPrevias.Text = paciente.concatenarHospitalizacionesPrevias();
            lbTransfusiones.Text = paciente.concatenarTransfusiones();
            lbCirugias.Text = paciente.concatenarCirugias();
            lbFracturas.Text = paciente.concatenarFracturas();
        }

        private void btnActualizar_Click(object sender, System.EventArgs e)
        {
            paciente.Altura = float.Parse(txtbAltura.Text);
            paciente.Peso = float.Parse(txtbPeso.Text);
            paciente.Temperatura = float.Parse(txtbTemperatura.Text);
            paciente.FrecuenciaRespiratoria = float.Parse(txtbFrecRespiratoria.Text);
            paciente.FrecuenciaCardiaca = float.Parse(txtbFrecCardiaca.Text);
            paciente.PresionArterial = txtbPresionArterial.Text;

            paciente.Nombre = txtbNombre.Text;
            paciente.Sexo = txtbSexo.Text;
            paciente.DiaNacimiento = byte.Parse(txtbDia.Text);
            paciente.MesNacimiento = byte.Parse(txtbMes.Text);
            paciente.AñoNacimiento = int.Parse(txtbAño.Text);
            paciente.Edad = byte.Parse(txtbEdad.Text);
            paciente.Telefono = txtbTelefono.Text;
            paciente.Email = txtbEmail.Text;
            paciente.Calle = txtbCalle.Text;
            paciente.Delegacion = txtbDelegacion.Text;
            paciente.Cp= txtbCP.Text;

            if (rdbPolenSi.Checked)
            {
                paciente.Polen = true;
            }
            else if (rdbPolenNo.Checked)
            {
                paciente.Polen = false;
            }
            if (rdbAcarosSi.Checked)
            {
                paciente.Acaros = true;
            }
            else if (rdbAcarosNo.Checked)
            {
                paciente.Acaros = false;
            }
            if (rdbLatexSi.Checked)
            {
                paciente.Latex = true;
            }
            else if (rdbLatexNo.Checked)
            {
                paciente.Latex = false;
            }
            if (rdbMedicamentoSi.Checked)
            {
                paciente.Medicamento = true;
                paciente.NombreMedicamento = txtbMedicamento.Text;
            }
            else if (rdbMedicamentoNo.Checked)
            {
                paciente.Medicamento = false;
            }
            if (rdbAlimentoSi.Checked)
            {
                paciente.Alimento = true;
                paciente.NombreAlimento = txtbAlimento.Text;
            }
            else if (rdbAlimentoNo.Checked)
            {
                paciente.Alimento = false;
            }


        }

        private void btnBloquear_Click(object sender, System.EventArgs e)
        {
            panelDatosPersonales.Enabled = !panelDatosPersonales.Enabled;

            panelAlergias.Enabled = !panelAlergias.Enabled;

            panelSignosVitales.Enabled = !panelSignosVitales.Enabled;

            btnQuitarEnfermedad.Enabled = !btnQuitarEnfermedad.Enabled;
            txtbAntecedentesHeredofamiliares.Enabled = !txtbAntecedentesHeredofamiliares.Enabled;
            btnAgregar.Enabled = !btnAgregar.Enabled;

            panelAntecedentesPersonalesPatologicos.Enabled = !panelAntecedentesPersonalesPatologicos.Enabled;

        }
        private void BloquearDatos()
        {
            panelDatosPersonales.Enabled = false;

            panelAlergias.Enabled = false;

            panelSignosVitales.Enabled = false;

            btnQuitarEnfermedad.Enabled = false;
            txtbAntecedentesHeredofamiliares.Enabled = false;
            btnAgregar.Enabled = false;

            panelAntecedentesPersonalesPatologicos.Enabled = false;
        }

        private void rdbMedicamentoSi_CheckedChanged(object sender, System.EventArgs e)
        {
            txtbMedicamento.Enabled = true;
        }

        private void rdbMedicamentoNo_CheckedChanged(object sender, System.EventArgs e)
        {
            txtbMedicamento.Enabled = false;
        }

        private void rdbAlimentoSi_CheckedChanged(object sender, System.EventArgs e)
        {
            txtbAlimento.Enabled = true;
        }

        private void rdbAlimentoNo_CheckedChanged(object sender, System.EventArgs e)
        {
            txtbAlimento.Enabled = false;
        }

        private void btnQuitarEnfermedad_Click(object sender, System.EventArgs e)
        {
            try
            {
                paciente.AntecedentesHeredofamiliares.Pop();
                lbAntecedentesHeredofamiliares.Text = paciente.concatenarAntecedenetesHeredofamiliares();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtbAntecedentesHeredofamiliares.Text != "")
            {
                paciente.AntecedentesHeredofamiliares.Push(txtbAntecedentesHeredofamiliares.Text);
                lbAntecedentesHeredofamiliares.Text = paciente.concatenarAntecedenetesHeredofamiliares();
                txtbAntecedentesHeredofamiliares.Clear();
            }
        }

        private void btnQuitarEnfermedadPrevia_Click(object sender, EventArgs e)
        {
            try
            {
                paciente.EnfermedadesPrevias.Pop();
                lbEnfermedadesPrevias.Text = paciente.concatenarEnfermedadesPrevias();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void btnAgregarEnfermedadPrevia_Click(object sender, EventArgs e)
        {
            if (txtbEnfermedadPrevia.Text != "")
            {
                paciente.EnfermedadesPrevias.Push(txtbEnfermedadPrevia.Text);
                lbEnfermedadesPrevias.Text = paciente.concatenarEnfermedadesPrevias();
                txtbEnfermedadPrevia.Clear();
            }
        }

        private void btnQuitarHospitalizacion_Click(object sender, EventArgs e)
        {
            try
            {
                paciente.HospitalizacionesPrevias.Pop();
                lbHospitalizacionesPrevias.Text = paciente.concatenarHospitalizacionesPrevias();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnAgregarHospitalizacionPrevia_Click(object sender, EventArgs e)
        {
            if (txtbHospitalizacionPrevia.Text != "")
            {
                paciente.HospitalizacionesPrevias.Push(txtbHospitalizacionPrevia.Text);
                lbHospitalizacionesPrevias.Text = paciente.concatenarHospitalizacionesPrevias();
                txtbHospitalizacionPrevia.Clear();
            }
        }

        private void btnQuitarTransfusion_Click(object sender, EventArgs e)
        {
            try
            {
                paciente.Transfusiones.Pop();
                lbTransfusiones.Text = paciente.concatenarTransfusiones();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnAgregarTransfusion_Click(object sender, EventArgs e)
        {
            if (txtbTransfusion.Text != "")
            {
                paciente.Transfusiones.Push(txtbTransfusion.Text);
                lbTransfusiones.Text = paciente.concatenarTransfusiones();
                txtbTransfusion.Clear();
            }
        }

        private void btnQuitarCirugia_Click(object sender, EventArgs e)
        {
            try
            {
                paciente.Cirugias.Pop();
                lbCirugias.Text = paciente.concatenarCirugias();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnAgregarCirugia_Click(object sender, EventArgs e)
        {
            if (txtbCirugia.Text != "")
            {
                paciente.Cirugias.Push(txtbCirugia.Text);
                lbCirugias.Text = paciente.concatenarCirugias();
                txtbCirugia.Clear();
            }
        }

        private void btnQuitarFractura_Click(object sender, EventArgs e)
        {
            try
            {
                paciente.Fracturas.Pop();
                lbFracturas.Text = paciente.concatenarFracturas();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnAgregarFracuras_Click(object sender, EventArgs e)
        {
            if (txtbFractura.Text != "")
            {
                paciente.Fracturas.Push(txtbFractura.Text);
                lbFracturas.Text = paciente.concatenarFracturas();
                txtbFractura.Clear();
            }
        }
    }
}
