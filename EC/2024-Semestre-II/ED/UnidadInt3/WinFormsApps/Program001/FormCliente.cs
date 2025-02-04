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

namespace WinFormsApps.Program001
{
    public partial class FormCliente : Form
    {
        public FormCliente()
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
                // Agregar datos al DataGridView
                dataGridView_Clientes.Rows.Add(
                    textBox_Identificacion.Text,
                    textBox_Nombres.Text,
                    textBox_Apellidos.Text,
                    textBox_Email.Text,
                    textBox_Edad.Text,
                    dateTimePicker_Fecha.Text,
                    textBox_Monto.Text,
                    checkBox_Activo.Checked
                );

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

        private void FormCliente_Load(object sender, EventArgs e)
        {
            // Configurar DataGridView para evitar filas vacías
            dataGridView_Clientes.AllowUserToAddRows = false; // <- Esto es importante
            dataGridView_Clientes.ReadOnly = true;

            // Configurar el DataGridView para seleccionar la fila completa al hacer clic en una celda
            dataGridView_Clientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Deshabilitar la selección de múltiples filas (opcional)
            dataGridView_Clientes.MultiSelect = false;

            // Deshabilitar la selección de celdas individuales (opcional)
            dataGridView_Clientes.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Configuración inicial del DataGridView
            dataGridView_Clientes.Columns.Add("Identificación", "Identificación");
            dataGridView_Clientes.Columns.Add("Nombres", "Nombres");
            dataGridView_Clientes.Columns.Add("Apellidos", "Apellidos");
            dataGridView_Clientes.Columns.Add("Email", "Email");
            dataGridView_Clientes.Columns.Add("Edad", "Edad");
            dataGridView_Clientes.Columns.Add("Fecha", "Fecha de nacimiento");
            dataGridView_Clientes.Columns.Add("Monto", "Monto");
            dataGridView_Clientes.Columns.Add("Activo", "Activo");

            // Configurar columna de botones
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Acción";
            btnColumn.Text = "Eliminar";
            btnColumn.UseColumnTextForButtonValue = true;
            dataGridView_Clientes.Columns.Add(btnColumn);

            // Configura las filas alternas para que se vean con un fondo diferente
            dataGridView_Clientes.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            // Cambiar el color de la fila seleccionada
            dataGridView_Clientes.DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridView_Clientes.DefaultCellStyle.SelectionForeColor = Color.White;

            // Ajustar el estilo de la fuente en las celdas
            dataGridView_Clientes.DefaultCellStyle.Font = new Font("Segoe UI", 9);

            // Cambiar el modo de ajuste de las columnas
            dataGridView_Clientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8 && e.RowIndex != -1) // Columna de botones
            {
                dataGridView_Clientes.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
