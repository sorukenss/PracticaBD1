using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace PracticaBD
{
    public partial class Form1 : Form
    {
        private PersonaService personaservice;
        IList<Persona> personas;

        public Form1()
        {
            InitializeComponent();
            personaservice = new PersonaService();
            Mostrar.DataSource=personaservice.ConsultarNormal();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            personaservice = new PersonaService();
            Persona persona = new Persona();
            persona.Nombre = Nombretext.Text;
            persona.Identificacion = Idtext.Text;
            persona.Sexo = Sexotext.Text;
            persona.Email = correotext.Text;
            MessageBox.Show(personaservice.GuardarPersona(persona));

               

        }

        public void Limpiar()
        {
            Nombretext.Text = " ";
            Idtext.Text = " ";
            Sexotext.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void refrescar_Click(object sender, EventArgs e)
        {
            personaservice = new PersonaService();
            Mostrar.DataSource = personaservice.ConsultarNormal();

        }

        private void BuscarCambiarVentana_Click(object sender, EventArgs e)
        {
            ConsultarPorId consultar = new ConsultarPorId();
            consultar.Show();
            this.Hide();
        }

        private void LimpiarBoton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            Eliminarpersona eliminar = new Eliminarpersona();
            eliminar.Show();
            this.Hide();
        }

        private void AtrasPrincipal_Click(object sender, EventArgs e)
        {
            Principal volver = new Principal();
            volver.Show();
            this.Hide();
        }

        private void btGenerarPdf_Click(object sender, EventArgs e)
        {
            if (CorreoEnviartex.Text.Equals(""))
            {
                MessageBox.Show("Ingresar el correo pliss");

            }
            else
            {
                GenerarPdf();
            }
           
        }

        private void CorreoEnviartex_TextChanged(object sender, EventArgs e)
        {
           
      
        }


        public void GenerarPdf()
        {
            personas = personaservice.ConsultarNormal();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Guardar Informe";
            saveFileDialog.InitialDirectory = "D:/Programacion lll/PracticasEstudios/PracticaBD";
            saveFileDialog.DefaultExt = "pdf";
            string filename = "";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                filename = saveFileDialog.FileName;
                if (filename != "" && personas.Count > 0)
                {
                    string mensaje = personaservice.GenerarPdf(personas, filename);

                    MessageBox.Show(mensaje, "Generar Pdf", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se especifico una ruta o No hay datos para generar el reporte", "Generar Pdf", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            personaservice.EnviarPdf(filename, CorreoEnviartex.Text);
        }
    }
}
    

