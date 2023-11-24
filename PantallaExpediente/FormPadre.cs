using System;
using System.Collections;
using System.Windows.Forms;
using BiblioExpedientes;

namespace PantallaExpediente
{
    public partial class FormPadre : Form
    {
        private Form formIniciarSesion;
        private ArrayList pacientes;
        private Paciente paciente;
        public FormPadre(Form formIniciarSesion, Usuario usuario)
        {
            InitializeComponent();
            this.formIniciarSesion = formIniciarSesion;
            openChildForm(new FormHome());
            pacientes = new ArrayList();
            cargarPacientes();
            verificarUsuario(usuario);
        }

        private Form activeForm = null;
        
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelchildForm.Controls.Add(childForm);
            panelchildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            openChildForm(new FormHome());
        }
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            if (paciente != null)
            {
                openChildForm(new FormPerfil(paciente));

            }
            else
                MessageBox.Show("No hay informacion registrada");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            openChildForm(new FormSettings(paciente));
        }

        private void cargarPacientes()
        {
            Paciente Maria = new Paciente("María González Sánchez", 71.3f, 1.75f, 36.2f, 19, 65, "120/80");
            Maria.User = "Maria";
            Maria.Sexo = "Femenino";
            Maria.DiaNacimiento = 25;
            Maria.MesNacimiento = 08;
            Maria.AñoNacimiento = 2000;
            Maria.Edad = 23;
            Maria.Telefono = "55968148";
            Maria.Email = "maria@gmail.com";
            Maria.Calle = "Rosedal";
            Maria.Delegacion = "Coyoacan";
            Maria.Cp = "06471";
            Maria.Polen = false;
            Maria.Acaros = false;
            Maria.Latex = false;
            Maria.Medicamento = false;
            Maria.NombreMedicamento = null;
            Maria.Alimento = true;
            Maria.NombreAlimento = "fresa";
            Maria.EnfermedadesPrevias.Push("Enfermedad1");
            Maria.EnfermedadesPrevias.Push("Enfermedad2");
            Maria.HospitalizacionesPrevias.Push("NO");
            Maria.Transfusiones.Push("NO");
            Maria.Cirugias.Push("NO");
            Maria.Fracturas.Push("Muñeca");
            Maria.AntecedentesHeredofamiliares.Push("Diabetes");
            Maria.AntecedentesHeredofamiliares.Push("Miopia");

            Paciente Carlos = new Paciente("Carlos Rodríguez Martínez", 55.4f, 1.59f, 36.1f, 18, 72, "119/82");
            Carlos.User = "Carlos";
            Carlos.Sexo = "Masculino";
            Carlos.DiaNacimiento = 22;
            Carlos.MesNacimiento = 07;
            Carlos.AñoNacimiento = 2003;
            Carlos.Edad = 20;
            Carlos.Telefono = "5561620735";
            Carlos.Email = "luisfdopapu@gmail.com";
            Carlos.Calle = "Arbolito";
            Carlos.Delegacion = "Coyoacan";
            Carlos.Cp = "06471";
            Carlos.Polen = false;
            Carlos.Acaros = false;
            Carlos.Latex = false;
            Carlos.Medicamento = false;
            Carlos.NombreMedicamento = null;
            Carlos.Alimento = false;
            Carlos.NombreAlimento = null;
            Carlos.EnfermedadesPrevias.Push("Enfermedad1");
            Carlos.EnfermedadesPrevias.Push("Enfermedad2");
            Carlos.HospitalizacionesPrevias.Push("NO");
            Carlos.Transfusiones.Push("NO");
            Carlos.Cirugias.Push("NO");
            Carlos.Fracturas.Push("Muñeca");
            Carlos.AntecedentesHeredofamiliares.Push("Diabetes");
            Carlos.AntecedentesHeredofamiliares.Push("Miopia");

            Paciente Laura = new Paciente("Laura Pérez López", 60, 1.59f, 36, 17, 62, "120/81");
            Laura.User = "Laura";
            Laura.Sexo = "Femenino";
            Laura.DiaNacimiento = 22;
            Laura.MesNacimiento = 07;
            Laura.AñoNacimiento = 2003;
            Laura.Edad = 20;
            Laura.Telefono = "5561620735";
            Laura.Email = "luisfdopapu@gmail.com";
            Laura.Calle = "Arbolito";
            Laura.Delegacion = "Coyoacan";
            Laura.Cp = "06471";
            Laura.Polen = false;
            Laura.Acaros = false;
            Laura.Latex = false;
            Laura.Medicamento = false;
            Laura.NombreMedicamento = null;
            Laura.Alimento = false;
            Laura.NombreAlimento = null;
            Laura.EnfermedadesPrevias.Push("Enfermedad1");
            Laura.EnfermedadesPrevias.Push("Enfermedad2");
            Laura.HospitalizacionesPrevias.Push("NO");
            Laura.Transfusiones.Push("NO");
            Laura.Cirugias.Push("NO");
            Laura.Fracturas.Push("Muñeca");
            Laura.AntecedentesHeredofamiliares.Push("Diabetes");
            Laura.AntecedentesHeredofamiliares.Push("Miopia");

            Paciente Luis = new Paciente("Luis Fernando Paredes Rivera", 60, 1.63f, 36, 17, 62, "120/80");
            Luis.User = "Luis";
            Luis.Sexo = "Masculino";
            Luis.DiaNacimiento = 22;
            Luis.MesNacimiento = 07;
            Luis.AñoNacimiento = 2003;
            Luis.Edad = 20;
            Luis.Telefono = "5561620735";
            Luis.Email = "luisfdopapu@gmail.com";
            Luis.Calle = "Arbolito";
            Luis.Delegacion = "Coyoacan";
            Luis.Cp = "06471";
            Luis.Polen = false;
            Luis.Acaros = false;
            Luis.Latex = false;
            Luis.Medicamento = false;
            Luis.NombreMedicamento = null;
            Luis.Alimento = false;
            Luis.NombreAlimento = null;
            Luis.EnfermedadesPrevias.Push("Enfermedad1");
            Luis.EnfermedadesPrevias.Push("Enfermedad2");
            Luis.EnfermedadesPrevias.Push("Enfermedad3");
            Luis.EnfermedadesPrevias.Push("Enfermedad4");
            Luis.EnfermedadesPrevias.Push("Enfermedad5");
            Luis.EnfermedadesPrevias.Push("Enfermedad6");
            Luis.HospitalizacionesPrevias.Push("NO");
            Luis.Transfusiones.Push("NO");
            Luis.Cirugias.Push("NO");
            Luis.Fracturas.Push("Muñeca");
            Luis.AntecedentesHeredofamiliares.Push("Diabetes");
            Luis.AntecedentesHeredofamiliares.Push("Miopia");



            Paciente Alejandro = new Paciente("Alejandro García Hernández", 60, 1.84f, 36, 17, 62, "123/85");
            Alejandro.User = "Alejandro";
            Alejandro.Sexo = "Masculino";
            Alejandro.DiaNacimiento = 22;
            Alejandro.MesNacimiento = 07;
            Alejandro.AñoNacimiento = 2003;
            Alejandro.Edad = 20;
            Alejandro.Telefono = "5561620735";
            Alejandro.Email = "luisfdopapu@gmail.com";
            Alejandro.Calle = "Arbolito";
            Alejandro.Delegacion = "Coyoacan";
            Alejandro.Cp = "06471";
            Alejandro.Polen = false;
            Alejandro.Acaros = false;
            Alejandro.Latex = false;
            Alejandro.Medicamento = false;
            Alejandro.NombreMedicamento = null;
            Alejandro.Alimento = false;
            Alejandro.NombreAlimento = null;
            Alejandro.EnfermedadesPrevias.Push("Enfermedad1");
            Alejandro.EnfermedadesPrevias.Push("Enfermedad2");
            Alejandro.HospitalizacionesPrevias.Push("NO");
            Alejandro.Transfusiones.Push("NO");
            Alejandro.Cirugias.Push("NO");
            Alejandro.Fracturas.Push("Muñeca");
            Alejandro.AntecedentesHeredofamiliares.Push("Diabetes");
            Alejandro.AntecedentesHeredofamiliares.Push("Miopia");

            pacientes.Add(Maria);
            pacientes.Add(Carlos);
            pacientes.Add(Laura);
            pacientes.Add(Luis);
            pacientes.Add(Alejandro);
        }

        private void FormPadre_FormClosing(object sender, FormClosingEventArgs e)
        {
            formIniciarSesion.Close();
        }
        private void verificarUsuario(Usuario usuario)
        {
            for (int i = 0; i < pacientes.Count; i++)
            {
                Paciente varPaciente = (Paciente)pacientes[i];
                if (varPaciente.User == usuario.User)
                {
                    paciente = varPaciente;
                    lbNombre.Text = paciente.Nombre;
                    break;
                }
                else if (i == pacientes.Count - 1)
                {
                    paciente = (Paciente)usuario;
                    
                }
                    
            }
        }

        private void ptbCerrarSesion_Click(object sender, EventArgs e)
        {
            Hide();
            
            formIniciarSesion.Show();
        }
    }
}
