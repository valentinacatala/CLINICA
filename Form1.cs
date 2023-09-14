using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLINICA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Especialidades oEspecialidades = new Especialidades();
            oEspecialidades.Especialidad= Convert.ToInt32(txtEspecialidades.Text);
            oEspecialidades.Nombre = txtNombre.Text;

            oEspecialidades.Grabar();

            txtEspecialidades.Text = "";
            txtNombre.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Especialidades oEspecialidades = new Especialidades();
            oEspecialidades.Especialidad = Convert.ToInt32(txtEspecialidades.Text);
            oEspecialidades.Eliminar();

            txtEspecialidades.Text = "";
        }
    }
}
