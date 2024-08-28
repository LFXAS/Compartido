namespace Unidad_4
{
    partial class FrmPrograma00
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_Mesnaje = new System.Windows.Forms.GroupBox();
            this.label_mensajeCompleto = new System.Windows.Forms.Label();
            this.textBox_mensajeCompleto = new System.Windows.Forms.TextBox();
            this.textBox_mensajeParte2 = new System.Windows.Forms.TextBox();
            this.textBox_MensajeParte1 = new System.Windows.Forms.TextBox();
            this.label_mensajeParte2 = new System.Windows.Forms.Label();
            this.label_mensajeParte1 = new System.Windows.Forms.Label();
            this.button_unirMensajes = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.groupBox_Mesnaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Mesnaje
            // 
            this.groupBox_Mesnaje.Controls.Add(this.label_mensajeCompleto);
            this.groupBox_Mesnaje.Controls.Add(this.textBox_mensajeCompleto);
            this.groupBox_Mesnaje.Controls.Add(this.textBox_mensajeParte2);
            this.groupBox_Mesnaje.Controls.Add(this.textBox_MensajeParte1);
            this.groupBox_Mesnaje.Controls.Add(this.label_mensajeParte2);
            this.groupBox_Mesnaje.Controls.Add(this.label_mensajeParte1);
            this.groupBox_Mesnaje.Location = new System.Drawing.Point(15, 12);
            this.groupBox_Mesnaje.Name = "groupBox_Mesnaje";
            this.groupBox_Mesnaje.Size = new System.Drawing.Size(313, 137);
            this.groupBox_Mesnaje.TabIndex = 0;
            this.groupBox_Mesnaje.TabStop = false;
            this.groupBox_Mesnaje.Text = "Mensaje";
            // 
            // label_mensajeCompleto
            // 
            this.label_mensajeCompleto.AutoSize = true;
            this.label_mensajeCompleto.Location = new System.Drawing.Point(15, 94);
            this.label_mensajeCompleto.Name = "label_mensajeCompleto";
            this.label_mensajeCompleto.Size = new System.Drawing.Size(96, 13);
            this.label_mensajeCompleto.TabIndex = 5;
            this.label_mensajeCompleto.Text = "Mensaje completo:";
            // 
            // textBox_mensajeCompleto
            // 
            this.textBox_mensajeCompleto.BackColor = System.Drawing.Color.White;
            this.textBox_mensajeCompleto.Location = new System.Drawing.Point(113, 91);
            this.textBox_mensajeCompleto.Name = "textBox_mensajeCompleto";
            this.textBox_mensajeCompleto.ReadOnly = true;
            this.textBox_mensajeCompleto.Size = new System.Drawing.Size(180, 20);
            this.textBox_mensajeCompleto.TabIndex = 3;
            // 
            // textBox_mensajeParte2
            // 
            this.textBox_mensajeParte2.Location = new System.Drawing.Point(113, 60);
            this.textBox_mensajeParte2.Name = "textBox_mensajeParte2";
            this.textBox_mensajeParte2.Size = new System.Drawing.Size(180, 20);
            this.textBox_mensajeParte2.TabIndex = 2;
            // 
            // textBox_MensajeParte1
            // 
            this.textBox_MensajeParte1.Location = new System.Drawing.Point(113, 32);
            this.textBox_MensajeParte1.Name = "textBox_MensajeParte1";
            this.textBox_MensajeParte1.Size = new System.Drawing.Size(180, 20);
            this.textBox_MensajeParte1.TabIndex = 1;
            // 
            // label_mensajeParte2
            // 
            this.label_mensajeParte2.AutoSize = true;
            this.label_mensajeParte2.Location = new System.Drawing.Point(15, 63);
            this.label_mensajeParte2.Name = "label_mensajeParte2";
            this.label_mensajeParte2.Size = new System.Drawing.Size(83, 13);
            this.label_mensajeParte2.TabIndex = 1;
            this.label_mensajeParte2.Text = "Fin del mensaje:";
            // 
            // label_mensajeParte1
            // 
            this.label_mensajeParte1.AutoSize = true;
            this.label_mensajeParte1.Location = new System.Drawing.Point(15, 37);
            this.label_mensajeParte1.Name = "label_mensajeParte1";
            this.label_mensajeParte1.Size = new System.Drawing.Size(94, 13);
            this.label_mensajeParte1.TabIndex = 0;
            this.label_mensajeParte1.Text = "Inicio del mensaje:";
            // 
            // button_unirMensajes
            // 
            this.button_unirMensajes.Location = new System.Drawing.Point(62, 155);
            this.button_unirMensajes.Name = "button_unirMensajes";
            this.button_unirMensajes.Size = new System.Drawing.Size(105, 31);
            this.button_unirMensajes.TabIndex = 4;
            this.button_unirMensajes.Text = "Unir mensajes";
            this.button_unirMensajes.UseVisualStyleBackColor = true;
            this.button_unirMensajes.Click += new System.EventHandler(this.button_unirMensajes_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(173, 155);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(105, 31);
            this.button_cancelar.TabIndex = 5;
            this.button_cancelar.Text = "Cancelar";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // FrmPrograma00
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(339, 200);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_unirMensajes);
            this.Controls.Add(this.groupBox_Mesnaje);
            this.MaximizeBox = false;
            this.Name = "FrmPrograma00";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenida";
            this.groupBox_Mesnaje.ResumeLayout(false);
            this.groupBox_Mesnaje.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Mesnaje;
        private System.Windows.Forms.Label label_mensajeParte2;
        private System.Windows.Forms.Label label_mensajeParte1;
        private System.Windows.Forms.Label label_mensajeCompleto;
        private System.Windows.Forms.TextBox textBox_mensajeCompleto;
        private System.Windows.Forms.TextBox textBox_mensajeParte2;
        private System.Windows.Forms.TextBox textBox_MensajeParte1;
        private System.Windows.Forms.Button button_unirMensajes;
        private System.Windows.Forms.Button button_cancelar;
    }
}

