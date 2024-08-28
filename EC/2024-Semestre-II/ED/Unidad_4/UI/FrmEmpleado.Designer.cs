namespace Unidad_4.UI
{
    partial class FrmEmpleado
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
            this.groupBoxDatosGenerales = new System.Windows.Forms.GroupBox();
            this.labelNumeroIdentidad = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelNombres = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelFechaNacimiento = new System.Windows.Forms.Label();
            this.labelGenero = new System.Windows.Forms.Label();
            this.textBoxNumeroIdentidad = new System.Windows.Forms.TextBox();
            this.textBoxApellidos = new System.Windows.Forms.TextBox();
            this.textBoxNombres = new System.Windows.Forms.TextBox();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.dateTimePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.radioButtonMasculino = new System.Windows.Forms.RadioButton();
            this.radioButtonFemenino = new System.Windows.Forms.RadioButton();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBoxDatosGenerales.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDatosGenerales
            // 
            this.groupBoxDatosGenerales.Controls.Add(this.radioButtonFemenino);
            this.groupBoxDatosGenerales.Controls.Add(this.radioButtonMasculino);
            this.groupBoxDatosGenerales.Controls.Add(this.dateTimePickerFechaNacimiento);
            this.groupBoxDatosGenerales.Controls.Add(this.textBoxEmail);
            this.groupBoxDatosGenerales.Controls.Add(this.textBoxTelefono);
            this.groupBoxDatosGenerales.Controls.Add(this.textBoxDireccion);
            this.groupBoxDatosGenerales.Controls.Add(this.textBoxNombres);
            this.groupBoxDatosGenerales.Controls.Add(this.textBoxApellidos);
            this.groupBoxDatosGenerales.Controls.Add(this.textBoxNumeroIdentidad);
            this.groupBoxDatosGenerales.Controls.Add(this.labelGenero);
            this.groupBoxDatosGenerales.Controls.Add(this.labelFechaNacimiento);
            this.groupBoxDatosGenerales.Controls.Add(this.labelEmail);
            this.groupBoxDatosGenerales.Controls.Add(this.labelApellidos);
            this.groupBoxDatosGenerales.Controls.Add(this.labelNombres);
            this.groupBoxDatosGenerales.Controls.Add(this.labelDireccion);
            this.groupBoxDatosGenerales.Controls.Add(this.labelTelefono);
            this.groupBoxDatosGenerales.Controls.Add(this.labelNumeroIdentidad);
            this.groupBoxDatosGenerales.Location = new System.Drawing.Point(14, 17);
            this.groupBoxDatosGenerales.Name = "groupBoxDatosGenerales";
            this.groupBoxDatosGenerales.Size = new System.Drawing.Size(300, 292);
            this.groupBoxDatosGenerales.TabIndex = 0;
            this.groupBoxDatosGenerales.TabStop = false;
            this.groupBoxDatosGenerales.Text = "Datos generales";
            // 
            // labelNumeroIdentidad
            // 
            this.labelNumeroIdentidad.AutoSize = true;
            this.labelNumeroIdentidad.Location = new System.Drawing.Point(14, 33);
            this.labelNumeroIdentidad.Name = "labelNumeroIdentidad";
            this.labelNumeroIdentidad.Size = new System.Drawing.Size(108, 13);
            this.labelNumeroIdentidad.TabIndex = 0;
            this.labelNumeroIdentidad.Text = "Número de identidad:";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(14, 150);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(52, 13);
            this.labelTelefono.TabIndex = 1;
            this.labelTelefono.Text = "Teléfono:";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Location = new System.Drawing.Point(14, 119);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(55, 13);
            this.labelDireccion.TabIndex = 2;
            this.labelDireccion.Text = "Dirección:";
            // 
            // labelNombres
            // 
            this.labelNombres.AutoSize = true;
            this.labelNombres.Location = new System.Drawing.Point(14, 88);
            this.labelNombres.Name = "labelNombres";
            this.labelNombres.Size = new System.Drawing.Size(52, 13);
            this.labelNombres.TabIndex = 3;
            this.labelNombres.Text = "Nombres:";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Location = new System.Drawing.Point(14, 60);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(52, 13);
            this.labelApellidos.TabIndex = 4;
            this.labelApellidos.Text = "Apellidos:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(17, 179);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email:";
            // 
            // labelFechaNacimiento
            // 
            this.labelFechaNacimiento.AutoSize = true;
            this.labelFechaNacimiento.Location = new System.Drawing.Point(17, 211);
            this.labelFechaNacimiento.Name = "labelFechaNacimiento";
            this.labelFechaNacimiento.Size = new System.Drawing.Size(109, 13);
            this.labelFechaNacimiento.TabIndex = 6;
            this.labelFechaNacimiento.Text = "Fecha de nacimiento:";
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(17, 243);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(45, 13);
            this.labelGenero.TabIndex = 7;
            this.labelGenero.Text = "Genero:";
            // 
            // textBoxNumeroIdentidad
            // 
            this.textBoxNumeroIdentidad.Location = new System.Drawing.Point(146, 30);
            this.textBoxNumeroIdentidad.Name = "textBoxNumeroIdentidad";
            this.textBoxNumeroIdentidad.Size = new System.Drawing.Size(138, 20);
            this.textBoxNumeroIdentidad.TabIndex = 1;
            // 
            // textBoxApellidos
            // 
            this.textBoxApellidos.Location = new System.Drawing.Point(146, 57);
            this.textBoxApellidos.Name = "textBoxApellidos";
            this.textBoxApellidos.Size = new System.Drawing.Size(138, 20);
            this.textBoxApellidos.TabIndex = 2;
            // 
            // textBoxNombres
            // 
            this.textBoxNombres.Location = new System.Drawing.Point(146, 85);
            this.textBoxNombres.Name = "textBoxNombres";
            this.textBoxNombres.Size = new System.Drawing.Size(138, 20);
            this.textBoxNombres.TabIndex = 3;
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(146, 116);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(138, 20);
            this.textBoxDireccion.TabIndex = 4;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(146, 147);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(138, 20);
            this.textBoxTelefono.TabIndex = 5;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(146, 176);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(138, 20);
            this.textBoxEmail.TabIndex = 6;
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(147, 208);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(137, 20);
            this.dateTimePickerFechaNacimiento.TabIndex = 7;
            // 
            // radioButtonMasculino
            // 
            this.radioButtonMasculino.AutoSize = true;
            this.radioButtonMasculino.Location = new System.Drawing.Point(146, 239);
            this.radioButtonMasculino.Name = "radioButtonMasculino";
            this.radioButtonMasculino.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMasculino.TabIndex = 8;
            this.radioButtonMasculino.TabStop = true;
            this.radioButtonMasculino.Text = "Masculino";
            this.radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemenino
            // 
            this.radioButtonFemenino.AutoSize = true;
            this.radioButtonFemenino.Location = new System.Drawing.Point(145, 262);
            this.radioButtonFemenino.Name = "radioButtonFemenino";
            this.radioButtonFemenino.Size = new System.Drawing.Size(71, 17);
            this.radioButtonFemenino.TabIndex = 9;
            this.radioButtonFemenino.TabStop = true;
            this.radioButtonFemenino.Text = "Femenino";
            this.radioButtonFemenino.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(103, 315);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(104, 32);
            this.buttonGuardar.TabIndex = 10;
            this.buttonGuardar.Text = "&Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(213, 315);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(104, 32);
            this.buttonCancelar.TabIndex = 11;
            this.buttonCancelar.Text = "&Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 358);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.groupBoxDatosGenerales);
            this.MaximizeBox = false;
            this.Name = "FrmEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo empleado";
            this.groupBoxDatosGenerales.ResumeLayout(false);
            this.groupBoxDatosGenerales.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDatosGenerales;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelNombres;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelNumeroIdentidad;
        private System.Windows.Forms.TextBox textBoxNumeroIdentidad;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.Label labelFechaNacimiento;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.RadioButton radioButtonFemenino;
        private System.Windows.Forms.RadioButton radioButtonMasculino;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNacimiento;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.TextBox textBoxNombres;
        private System.Windows.Forms.TextBox textBoxApellidos;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
    }
}