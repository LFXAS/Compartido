namespace WinFormsApps.Program001
{
    partial class FormCliente
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            checkBox_Activo = new CheckBox();
            textBox_Monto = new TextBox();
            textBox_Edad = new TextBox();
            textBox_Email = new TextBox();
            textBox_Apellidos = new TextBox();
            textBox_Nombres = new TextBox();
            textBox_Identificacion = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dateTimePicker_Fecha = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button_Cancelar = new Button();
            button_Guardar = new Button();
            errorProvider = new ErrorProvider(components);
            groupBox2 = new GroupBox();
            dataGridView_Clientes = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox_Activo);
            groupBox1.Controls.Add(textBox_Monto);
            groupBox1.Controls.Add(textBox_Edad);
            groupBox1.Controls.Add(textBox_Email);
            groupBox1.Controls.Add(textBox_Apellidos);
            groupBox1.Controls.Add(textBox_Nombres);
            groupBox1.Controls.Add(textBox_Identificacion);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(dateTimePicker_Fecha);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(174, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(393, 239);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información";
            // 
            // checkBox_Activo
            // 
            checkBox_Activo.AutoSize = true;
            checkBox_Activo.Location = new Point(288, 204);
            checkBox_Activo.Name = "checkBox_Activo";
            checkBox_Activo.Size = new Size(60, 19);
            checkBox_Activo.TabIndex = 7;
            checkBox_Activo.Text = "Activo";
            checkBox_Activo.UseVisualStyleBackColor = true;
            // 
            // textBox_Monto
            // 
            textBox_Monto.Location = new Point(179, 204);
            textBox_Monto.Name = "textBox_Monto";
            textBox_Monto.Size = new Size(89, 23);
            textBox_Monto.TabIndex = 6;
            textBox_Monto.Validating += textBox_Monto_Validating;
            // 
            // textBox_Edad
            // 
            textBox_Edad.Location = new Point(179, 146);
            textBox_Edad.Name = "textBox_Edad";
            textBox_Edad.Size = new Size(89, 23);
            textBox_Edad.TabIndex = 4;
            textBox_Edad.Validating += textBox_Edad_Validating;
            // 
            // textBox_Email
            // 
            textBox_Email.Location = new Point(179, 116);
            textBox_Email.Name = "textBox_Email";
            textBox_Email.Size = new Size(192, 23);
            textBox_Email.TabIndex = 3;
            textBox_Email.Validating += textBox_Email_Validating;
            // 
            // textBox_Apellidos
            // 
            textBox_Apellidos.Location = new Point(179, 87);
            textBox_Apellidos.Name = "textBox_Apellidos";
            textBox_Apellidos.Size = new Size(192, 23);
            textBox_Apellidos.TabIndex = 2;
            // 
            // textBox_Nombres
            // 
            textBox_Nombres.Location = new Point(179, 58);
            textBox_Nombres.Name = "textBox_Nombres";
            textBox_Nombres.Size = new Size(192, 23);
            textBox_Nombres.TabIndex = 1;
            // 
            // textBox_Identificacion
            // 
            textBox_Identificacion.Location = new Point(179, 28);
            textBox_Identificacion.Name = "textBox_Identificacion";
            textBox_Identificacion.Size = new Size(192, 23);
            textBox_Identificacion.TabIndex = 0;
            textBox_Identificacion.Validating += textBox_Identificacion_Validating;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 204);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 6;
            label7.Text = "Monto crédito:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 31);
            label6.Name = "label6";
            label6.Size = new Size(145, 15);
            label6.TabIndex = 5;
            label6.Text = "Número de identificación:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 175);
            label5.Name = "label5";
            label5.Size = new Size(120, 15);
            label5.TabIndex = 4;
            label5.Text = "Fecha de nacimiento:";
            // 
            // dateTimePicker_Fecha
            // 
            dateTimePicker_Fecha.Format = DateTimePickerFormat.Short;
            dateTimePicker_Fecha.Location = new Point(179, 175);
            dateTimePicker_Fecha.Name = "dateTimePicker_Fecha";
            dateTimePicker_Fecha.Size = new Size(145, 23);
            dateTimePicker_Fecha.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 146);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 2;
            label4.Text = "Edad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 116);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 87);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 1;
            label2.Text = "Apellidos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 58);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombres:";
            // 
            // button_Cancelar
            // 
            button_Cancelar.Location = new Point(638, 482);
            button_Cancelar.Name = "button_Cancelar";
            button_Cancelar.Size = new Size(108, 29);
            button_Cancelar.TabIndex = 9;
            button_Cancelar.Text = "Cancelar";
            button_Cancelar.UseVisualStyleBackColor = true;
            button_Cancelar.Click += button_Cancelar_Click;
            // 
            // button_Guardar
            // 
            button_Guardar.Location = new Point(524, 482);
            button_Guardar.Name = "button_Guardar";
            button_Guardar.Size = new Size(108, 29);
            button_Guardar.TabIndex = 8;
            button_Guardar.Text = "Guardar";
            button_Guardar.UseVisualStyleBackColor = true;
            button_Guardar.Click += button_Guardar_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView_Clientes);
            groupBox2.Location = new Point(12, 254);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(734, 222);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lista de clientes";
            // 
            // dataGridView_Clientes
            // 
            dataGridView_Clientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Clientes.Location = new Point(15, 22);
            dataGridView_Clientes.Name = "dataGridView_Clientes";
            dataGridView_Clientes.Size = new Size(697, 194);
            dataGridView_Clientes.TabIndex = 10;
            dataGridView_Clientes.CellClick += dataGridView_Clientes_CellClick;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 524);
            Controls.Add(groupBox2);
            Controls.Add(button_Guardar);
            Controls.Add(button_Cancelar);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            Name = "FormCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cliente";
            Load += FormCliente_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Clientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox_Monto;
        private TextBox textBox_Edad;
        private TextBox textBox_Email;
        private TextBox textBox_Apellidos;
        private TextBox textBox_Nombres;
        private TextBox textBox_Identificacion;
        private Label label7;
        private Label label6;
        private Label label5;
        private DateTimePicker dateTimePicker_Fecha;
        private Label label4;
        private Label label3;
        private Button button_Cancelar;
        private Button button_Guardar;
        private ErrorProvider errorProvider;
        private GroupBox groupBox2;
        private DataGridView dataGridView_Clientes;
        private CheckBox checkBox_Activo;
    }
}