using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApps.Program002
{
    public partial class FormPrincipal : Form
    {
        private Form? childForm;
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (childForm == null || childForm.IsDisposed)
            {
                childForm = new FormNuevoCliente();
                childForm.MdiParent = this;
                childForm.Text = "Creación de cliente";
                childForm.Show();
            }
            else
            {
                // Traer el formulario al frente si ya está abierto
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (childForm == null || childForm.IsDisposed)
            {
                childForm = new FormConsultaClientes();
                childForm.MdiParent = this;
                childForm.Text = "Consulta de clientes";
                childForm.Show();
            }
            else
            {
                // Traer el formulario al frente si ya está abierto
                childForm.BringToFront();
                childForm.WindowState = FormWindowState.Normal;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
