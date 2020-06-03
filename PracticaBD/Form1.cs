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
    }
}
