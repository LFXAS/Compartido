using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad_4
{
    public partial class FrmPrograma00 : Form
    {
        public FrmPrograma00()
        {
            InitializeComponent();
        }

        private void button_unirMensajes_Click(object sender, EventArgs e)
        {
            try
            {
                textBox_mensajeCompleto.Text = textBox_MensajeParte1.Text + " " +textBox_mensajeParte2.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
