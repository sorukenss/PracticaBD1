using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaBD
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            Form1 guardar = new Form1();
            guardar.Show();
            this.Hide();
        }

        private void btbuscar_Click(object sender, EventArgs e)
        {
            ConsultarPorId consultar = new ConsultarPorId();
            consultar.Show();
            this.Hide();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            Eliminarpersona eliminar = new Eliminarpersona();
            eliminar.Show();
            this.Hide();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
