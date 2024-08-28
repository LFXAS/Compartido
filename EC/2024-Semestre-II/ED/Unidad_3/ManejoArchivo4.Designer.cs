namespace Unidad_3
{
    partial class ManejoArchivo4
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

        private void InitializeComponent()
        {
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.btnSaveNotes = new System.Windows.Forms.Button();
            this.btnLoadNotes = new System.Windows.Forms.Button();
            this.listBoxNotes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(12, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(260, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(12, 38);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(260, 60);
            this.txtContent.TabIndex = 1;
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(12, 104);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(75, 23);
            this.btnAddNote.TabIndex = 2;
            this.btnAddNote.Text = "Agregar Nota";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // btnSaveNotes
            // 
            this.btnSaveNotes.Location = new System.Drawing.Point(104, 104);
            this.btnSaveNotes.Name = "btnSaveNotes";
            this.btnSaveNotes.Size = new System.Drawing.Size(75, 23);
            this.btnSaveNotes.TabIndex = 3;
            this.btnSaveNotes.Text = "Guardar Notas";
            this.btnSaveNotes.UseVisualStyleBackColor = true;
            this.btnSaveNotes.Click += new System.EventHandler(this.btnSaveNotes_Click);
            // 
            // btnLoadNotes
            // 
            this.btnLoadNotes.Location = new System.Drawing.Point(197, 104);
            this.btnLoadNotes.Name = "btnLoadNotes";
            this.btnLoadNotes.Size = new System.Drawing.Size(75, 23);
            this.btnLoadNotes.TabIndex = 4;
            this.btnLoadNotes.Text = "Cargar Notas";
            this.btnLoadNotes.UseVisualStyleBackColor = true;
            this.btnLoadNotes.Click += new System.EventHandler(this.btnLoadNotes_Click);
            // 
            // listBoxNotes
            // 
            this.listBoxNotes.FormattingEnabled = true;
            this.listBoxNotes.Location = new System.Drawing.Point(12, 133);
            this.listBoxNotes.Name = "listBoxNotes";
            this.listBoxNotes.Size = new System.Drawing.Size(260, 95);
            this.listBoxNotes.TabIndex = 5;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 240);
            this.Controls.Add(this.listBoxNotes);
            this.Controls.Add(this.btnLoadNotes);
            this.Controls.Add(this.btnSaveNotes);
            this.Controls.Add(this.btnAddNote);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtTitle);
            this.Name = "MainForm";
            this.Text = "Gestor de Notas";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.Button btnSaveNotes;
        private System.Windows.Forms.Button btnLoadNotes;
        private System.Windows.Forms.ListBox listBoxNotes;
    }
}
