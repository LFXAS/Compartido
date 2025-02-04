namespace WinFormsApps.Program002
{
    partial class FormConsultaClientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            dataGridView_Clientes = new DataGridView();
            button_Cancelar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView_Clientes);
            groupBox1.Location = new Point(17, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(758, 376);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Listado de clientes";
            // 
            // dataGridView_Clientes
            // 
            dataGridView_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Clientes.Location = new Point(6, 22);
            dataGridView_Clientes.Name = "dataGridView_Clientes";
            dataGridView_Clientes.Size = new Size(746, 348);
            dataGridView_Clientes.TabIndex = 0;
            dataGridView_Clientes.CellClick += dataGridView_Clientes_CellClick;
            // 
            // button_Cancelar
            // 
            button_Cancelar.Location = new Point(681, 394);
            button_Cancelar.Name = "button_Cancelar";
            button_Cancelar.Size = new Size(94, 38);
            button_Cancelar.TabIndex = 1;
            button_Cancelar.Text = "Cancelar";
            button_Cancelar.UseVisualStyleBackColor = true;
            button_Cancelar.Click += button_Cancelar_Click;
            // 
            // FormConsultaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(796, 438);
            Controls.Add(button_Cancelar);
            Controls.Add(groupBox1);
            Name = "FormConsultaClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta de clientes";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView_Clientes;
        private Button button_Cancelar;
    }
}