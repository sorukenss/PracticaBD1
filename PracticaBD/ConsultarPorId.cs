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
    public partial class ConsultarPorId : Form
    {
        public ConsultarPorId()
        {
            InitializeComponent();
        }

        private void VolverBoton_Click(object sender, EventArgs e)
        {
            Principal volver = new Principal();
            volver.Show();
            this.Hide();
        }

        private void idregistradatext_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Buscartext_Click(object sender, EventArgs e)
        {
            Persona persona;
            PersonaService personaservice = new PersonaService();
            persona = personaservice.ConsultarPersona(idregistradatext.Text);
            if (persona == null)
            {
                persona = new Persona();


            }
            MessageBox.Show(persona.Nombre);
            /*dtMostrar.Rows.Clear();
            int n = dtMostrar.Rows.Add();*/
            int n = 0;
            dtMostrar.Rows[n].Cells[0].Value = persona.Identificacion;
            dtMostrar.Rows[n].Cells[1].Value = persona.Nombre;
            dtMostrar.Rows[n].Cells[2].Value = persona.Sexo;
            dtMostrar.Rows[n].Cells[3].Value = persona.Email;
        }
    }
}
