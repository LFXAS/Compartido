using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApps.Program001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Configuración inicial del DataGridView
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Edad", "Edad");
            dataGridView1.Columns.Add("Activo", "Activo");

            // Configurar columna de botones
            DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            btnColumn.HeaderText = "Acción";
            btnColumn.Text = "Eliminar";
            btnColumn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btnColumn);

            // Llenar ComboBox
            cmbColorFavorito.Items.AddRange(new string[] { "Rojo", "Azul", "Verde", "Amarillo" });

            // Estado inicial
            UpdateStatus("Listo");
        }

        #region Validaciones
        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider.SetError(txtNombre, "El nombre es requerido");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtNombre, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!IsValidEmail(txtEmail.Text))
            {
                errorProvider.SetError(txtEmail, "Email inválido");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEmail, "");
            }
        }

        private void txtEdad_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtEdad.Text, out int edad) || edad < 1 || edad > 150)
            {
                errorProvider.SetError(txtEdad, "Edad inválida (1-150)");
                e.Cancel = true;
            }
            else
            {
                errorProvider.SetError(txtEdad, "");
            }
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Botones y Eventos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                // Agregar datos al DataGridView
                dataGridView1.Rows.Add(
                    txtNombre.Text,
                    txtEdad.Text,
                    chkActivo.Checked
                );

                MessageBox.Show("Datos guardados correctamente", "Éxito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarFormulario();
                UpdateStatus("Datos guardados: " + DateTime.Now.ToString());
            }
            else
            {
                MessageBox.Show("Corrija los errores antes de guardar", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarLista_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtElementoLista.Text))
            {
                lstElementos.Items.Add(txtElementoLista.Text);
                txtElementoLista.Clear();
            }
        }

        private void btnRemoverLista_Click(object sender, EventArgs e)
        {
            if (lstElementos.SelectedIndex != -1)
            {
                lstElementos.Items.RemoveAt(lstElementos.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Seleccione un elemento para eliminar", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.RowIndex != -1) // Columna de botones
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }
        #endregion

        #region Menús
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Lógica para manejar archivo abierto
                UpdateStatus("Archivo abierto: " + openFileDialog1.FileName);
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicación de ejemplo de controles Windows Forms\nVersión 1.0",
                "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Métodos auxiliares
        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtEmail.Clear();
            txtEdad.Clear();
            dtpFechaNacimiento.Value = DateTime.Now;
            cmbColorFavorito.SelectedIndex = -1;
            chkActivo.Checked = false;
            rdbMasculino.Checked = true;
            lstElementos.Items.Clear();
            foreach (Control ctrl in this.gbxPreferencias.Controls)
            {
                if (ctrl is CheckBox)
                  ((CheckBox)ctrl).Checked = false;
            }
        }

        private void UpdateStatus(string message)
        {
            tslStatus.Text = message;
        }
        #endregion
    }
}
