using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WinFormsApps.Program002
{
    public partial class FormNuevoCliente : Form
    {
        public FormNuevoCliente()
        {
            InitializeComponent();
        }

        private void textBox_Identificacion_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox_Identificacion.Text))
            {
                errorProvider.SetError(textBox_Identificacion, "El número de identificación es requerido");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textBox_Identificacion, "");
            }
        }

        private void textBox_Email_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidEmail(textBox_Email.Text))
            {
                errorProvider.SetError(textBox_Email, "Email inválido");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textBox_Email, "");
            }
        }

        private static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        private void textBox_Edad_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(textBox_Edad.Text, out int edad) || edad < 1 || edad > 150)
            {
                errorProvider.SetError(textBox_Edad, "Edad inválida (1-150)");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textBox_Edad, "");
            }
        }

        private void textBox_Monto_Validating(object sender, CancelEventArgs e)
        {
            if (!double.TryParse(textBox_Monto.Text, out double monto) || monto < 1 || monto > 999)
            {
                errorProvider.SetError(textBox_Monto, "Monto inválido (1.0-999.0)");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(textBox_Monto, "");
            }
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                //  Crear objeto tipo cliente
                Cliente cliente = new Cliente();

                cliente.NumeroIdentidad=textBox_Identificacion.Text;
                cliente.Nombre=textBox_Nombres.Text;
                cliente.Apellido=textBox_Apellidos.Text;
                cliente.Email=textBox_Email.Text;
                cliente.Edad = int.Parse(textBox_Edad.Text);
                cliente.FechaNacimiento = dateTimePicker_Fecha.Value;
                cliente.Monto = double.Parse(textBox_Monto.Text);
                cliente.Estado=checkBox_Activo.Checked;

                Program.clientes.Add(cliente);
                
                MessageBox.Show("Datos guardados correctamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario(this);
            }
            else
            {
                MessageBox.Show("Corrija los errores antes de guardar", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is CheckBox)
                    ((CheckBox)ctrl).Checked = false;

                if (ctrl is TextBox)
                    ((TextBox)ctrl).Clear();

                if (ctrl is DateTimePicker)
                    ((DateTimePicker)ctrl).Value = DateTime.Now;

                // Llamada recursiva para limpiar controles dentro de contenedores
                if (ctrl.HasChildren)
                {
                    LimpiarFormulario(ctrl);
                }
            }
        }

    

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

       
    }
}
