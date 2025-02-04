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
    public partial class FormConsultaClientes : Form
    {
        public FormConsultaClientes()
        {
            InitializeComponent();
            CargarClientes();
        }

        private void CargarClientes()
        {
            FormateaDataGridView();
            // Agregar datos al DataGridView
            foreach (var cliente in Program.clientes)
            {
                dataGridView_Clientes.Rows.Add(cliente.NumeroIdentidad,
                cliente.Nombre,
                cliente.Apellido,
                cliente.Email,
                cliente.Edad,
                cliente.FechaNacimiento,
                cliente.Monto,
                cliente.Estado ? "Activo" : "Inactivo"
                );
            }

            /*dataGridView_Clientes.DataSource = Program.clientes.Select( c => new
            {
                c.NumeroIdentidad,
                c.Nombre,
                c.Apellido,
                c.Email,
                c.Edad,
                c.FechaNacimiento,
                c.Monto,
                Estado = c.Estado ? "Activo" : "Inactivo"  // Cambiar visualización del estado
            }).ToList();*/
        }

        private void FormateaDataGridView()
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

        private void dataGridView_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8 && e.RowIndex != -1) // Columna de botones
            {
                dataGridView_Clientes.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
