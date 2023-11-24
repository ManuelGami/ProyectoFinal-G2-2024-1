using BiblioExpedientes;
using System.Windows.Forms;

namespace PantallaExpediente
{
    public partial class FormPerfil : Form
    {
        private Paciente paciente;
        public FormPerfil(Paciente paciente)
        {
            InitializeComponent();
            this.paciente = paciente;
            cargarSignosVitales(); 
            cargarInformacionPersonal();
            cargarAlergias();
            cargarAntecedentes();
            lbAntecedentesHeredofamiliares.Text = paciente.concatenarAntecedenetesHeredofamiliares();
        }

        private void cargarSignosVitales()
        {
            lbAltura.Text = paciente.Altura.ToString();
            lbPeso.Text = paciente.Peso.ToString();
            lbIMC.Text = paciente.calculoIMC().ToString();
            lbTemperatura.Text = paciente.Temperatura.ToString();
            lbFrecRespiratoria.Text = paciente.FrecuenciaRespiratoria.ToString();
            lbFrecCardiaca.Text = paciente.FrecuenciaCardiaca.ToString();
            lbPresionArterial.Text = paciente.PresionArterial;
        }
        private void cargarInformacionPersonal()
        {
            lbNombre.Text = paciente.Nombre;
            lbSexo.Text = paciente.Sexo;
            lbNacimiento.Text = paciente.concatenarFecha();
            lbEdad.Text = paciente.Edad.ToString() + " años";
            lbTelefono.Text = paciente.Telefono;
            lbEmail.Text = paciente.Email;
            lbCalle.Text = paciente.Calle;
            lbDelegacion.Text = paciente.Delegacion;
            lbCp.Text = paciente.Cp;
            
        }
        private void cargarAlergias()
        {
            lbPolen.Text = (paciente.Polen) ? "SI" : "NO";
            lbAcaros.Text = (paciente.Acaros) ? "SI" : "NO";
            lbLatex.Text = (paciente.Latex) ? "SI" : "NO";
            lbMedicamento.Text = paciente.NombreMedicamento;
            lbAlimento.Text = paciente.NombreAlimento;
        }

        private void cargarAntecedentes()
        {
            lbEnfermedadesPrevias.Text = paciente.concatenarEnfermedadesPrevias();
            lbHospitalizacionesPrevias.Text = paciente.concatenarHospitalizacionesPrevias();
            lbTransfusiones.Text = paciente.concatenarTransfusiones();
            lbCirugias.Text = paciente.concatenarCirugias();
            lbFracturas.Text = paciente.concatenarFracturas();
        }
    }
}
