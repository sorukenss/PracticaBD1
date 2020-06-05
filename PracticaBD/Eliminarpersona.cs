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
    public partial class Eliminarpersona : Form
    {
        public Eliminarpersona()
        {
            InitializeComponent();
        }

        private void AtrasEliminar_Click(object sender, EventArgs e)
        {
            Principal volver = new Principal();
            volver.Show();
            this.Hide();
        }

        private void txEliminar_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void btEliminarAction_Click(object sender, EventArgs e)
        {
            PersonaService personaservice = new PersonaService();
            MessageBox.Show(personaservice.EliminarPersona(txEliminar.Text));
        }
    }
}
