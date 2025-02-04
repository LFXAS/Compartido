namespace WinFormsApps.Program001
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            gbxPreferencias = new GroupBox();
            rdbFemenino = new RadioButton();
            rdbMasculino = new RadioButton();
            txtNombre = new TextBox();
            txtEmail = new TextBox();
            txtEdad = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            cmbColorFavorito = new ComboBox();
            chkActivo = new CheckBox();
            lstElementos = new ListBox();
            txtElementoLista = new TextBox();
            btnAgregarLista = new Button();
            btnRemoverLista = new Button();
            dataGridView1 = new DataGridView();
            errorProvider = new ErrorProvider(components);
            menuStrip1 = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            tslStatus = new ToolStripStatusLabel();
            openFileDialog1 = new OpenFileDialog();
            btnGuardar = new Button();
            gbxPreferencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 46);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 81);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 115);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Edad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 150);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 3;
            label4.Text = "Fecha Nacimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 185);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(85, 15);
            label5.TabIndex = 4;
            label5.Text = "Color Favorito:";
            // 
            // gbxPreferencias
            // 
            gbxPreferencias.Controls.Add(rdbFemenino);
            gbxPreferencias.Controls.Add(rdbMasculino);
            gbxPreferencias.Location = new Point(408, 46);
            gbxPreferencias.Margin = new Padding(4, 3, 4, 3);
            gbxPreferencias.Name = "gbxPreferencias";
            gbxPreferencias.Padding = new Padding(4, 3, 4, 3);
            gbxPreferencias.Size = new Size(233, 115);
            gbxPreferencias.TabIndex = 11;
            gbxPreferencias.TabStop = false;
            gbxPreferencias.Text = "Género";
            // 
            // rdbFemenino
            // 
            rdbFemenino.AutoSize = true;
            rdbFemenino.Location = new Point(19, 69);
            rdbFemenino.Margin = new Padding(4, 3, 4, 3);
            rdbFemenino.Name = "rdbFemenino";
            rdbFemenino.Size = new Size(78, 19);
            rdbFemenino.TabIndex = 1;
            rdbFemenino.Text = "Femenino";
            rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.Checked = true;
            rdbMasculino.Location = new Point(19, 35);
            rdbMasculino.Margin = new Padding(4, 3, 4, 3);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(80, 19);
            rdbMasculino.TabIndex = 0;
            rdbMasculino.TabStop = true;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(140, 43);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(233, 23);
            txtNombre.TabIndex = 5;
            txtNombre.Validating += txtNombre_Validating;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(140, 77);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(233, 23);
            txtEmail.TabIndex = 6;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(140, 112);
            txtEdad.Margin = new Padding(4, 3, 4, 3);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(116, 23);
            txtEdad.TabIndex = 7;
            txtEdad.Validating += txtEdad_Validating;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(140, 147);
            dtpFechaNacimiento.Margin = new Padding(4, 3, 4, 3);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(233, 23);
            dtpFechaNacimiento.TabIndex = 8;
            // 
            // cmbColorFavorito
            // 
            cmbColorFavorito.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbColorFavorito.FormattingEnabled = true;
            cmbColorFavorito.Location = new Point(140, 181);
            cmbColorFavorito.Margin = new Padding(4, 3, 4, 3);
            cmbColorFavorito.Name = "cmbColorFavorito";
            cmbColorFavorito.Size = new Size(140, 23);
            cmbColorFavorito.TabIndex = 9;
            // 
            // chkActivo
            // 
            chkActivo.AutoSize = true;
            chkActivo.Location = new Point(140, 219);
            chkActivo.Margin = new Padding(4, 3, 4, 3);
            chkActivo.Name = "chkActivo";
            chkActivo.Size = new Size(60, 19);
            chkActivo.TabIndex = 10;
            chkActivo.Text = "Activo";
            chkActivo.UseVisualStyleBackColor = true;
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.ItemHeight = 15;
            lstElementos.Location = new Point(408, 185);
            lstElementos.Margin = new Padding(4, 3, 4, 3);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(233, 109);
            lstElementos.TabIndex = 12;
            // 
            // txtElementoLista
            // 
            txtElementoLista.Location = new Point(408, 312);
            txtElementoLista.Margin = new Padding(4, 3, 4, 3);
            txtElementoLista.Name = "txtElementoLista";
            txtElementoLista.Size = new Size(139, 23);
            txtElementoLista.TabIndex = 13;
            // 
            // btnAgregarLista
            // 
            btnAgregarLista.Location = new Point(560, 309);
            btnAgregarLista.Margin = new Padding(4, 3, 4, 3);
            btnAgregarLista.Name = "btnAgregarLista";
            btnAgregarLista.Size = new Size(88, 27);
            btnAgregarLista.TabIndex = 14;
            btnAgregarLista.Text = "Agregar";
            btnAgregarLista.UseVisualStyleBackColor = true;
            btnAgregarLista.Click += btnAgregarLista_Click;
            // 
            // btnRemoverLista
            // 
            btnRemoverLista.Location = new Point(408, 346);
            btnRemoverLista.Margin = new Padding(4, 3, 4, 3);
            btnRemoverLista.Name = "btnRemoverLista";
            btnRemoverLista.Size = new Size(88, 27);
            btnRemoverLista.TabIndex = 15;
            btnRemoverLista.Text = "Remover";
            btnRemoverLista.UseVisualStyleBackColor = true;
            btnRemoverLista.Click += btnRemoverLista_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(18, 312);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(356, 173);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(681, 24);
            menuStrip1.TabIndex = 17;
            menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(100, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(100, 22);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(126, 22);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { tslStatus });
            statusStrip1.Location = new Point(0, 510);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(681, 22);
            statusStrip1.TabIndex = 18;
            statusStrip1.Text = "statusStrip1";
            // 
            // tslStatus
            // 
            tslStatus.Name = "tslStatus";
            tslStatus.Size = new Size(41, 17);
            tslStatus.Text = "Listo...";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(140, 254);
            btnGuardar.Margin = new Padding(4, 3, 4, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(117, 35);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(681, 532);
            Controls.Add(btnGuardar);
            Controls.Add(statusStrip1);
            Controls.Add(dataGridView1);
            Controls.Add(btnRemoverLista);
            Controls.Add(btnAgregarLista);
            Controls.Add(txtElementoLista);
            Controls.Add(lstElementos);
            Controls.Add(gbxPreferencias);
            Controls.Add(chkActivo);
            Controls.Add(cmbColorFavorito);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtEdad);
            Controls.Add(txtEmail);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Ejemplo de Controles Windows Forms";
            Load += Form1_Load;
            gbxPreferencias.ResumeLayout(false);
            gbxPreferencias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.GroupBox gbxPreferencias;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.ComboBox cmbColorFavorito;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.ListBox lstElementos;
        private System.Windows.Forms.TextBox txtElementoLista;
        private System.Windows.Forms.Button btnAgregarLista;
        private System.Windows.Forms.Button btnRemoverLista;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslStatus;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGuardar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}