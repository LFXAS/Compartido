using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unidad_4.CS;

namespace Unidad_4.UI
{
    public partial class FrmEmpleado : Form
    {
        public FrmEmpleado()
        {
            InitializeComponent();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {            
            try
            {
                Empleado empleado = new Empleado();
                                
                empleado.NumeroIdentidad=textBoxNumeroIdentidad.Text;
                empleado.Apellidos=textBoxApellidos.Text;
                empleado.Nombres=textBoxNombres.Text;
                empleado.Direccion=textBoxDireccion.Text;
                empleado.Telefono=textBoxTelefono.Text;
                empleado.Email=textBoxEmail.Text;
                empleado.Fecha=DateTime.Parse(dateTimePickerFechaNacimiento.Text);
                
                if(radioButtonFemenino.Checked)
                {
                    empleado.Genero = radioButtonFemenino.Text;
                }
                else
                {
                    empleado.Genero = radioButtonMasculino.Text;
                }                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
