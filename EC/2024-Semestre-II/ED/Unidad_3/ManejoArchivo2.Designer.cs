namespace Unidad_3
{
    partial class ManejoArchivo2
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnSaveImagePath = new System.Windows.Forms.Button();
            this.btnLoadImagePath = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(260, 180);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(12, 198);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(260, 20);
            this.txtImagePath.TabIndex = 1;
            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(12, 224);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(75, 23);
            this.btnLoadImage.TabIndex = 2;
            this.btnLoadImage.Text = "Cargar Imagen";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);
            // 
            // btnSaveImagePath
            // 
            this.btnSaveImagePath.Location = new System.Drawing.Point(104, 224);
            this.btnSaveImagePath.Name = "btnSaveImagePath";
            this.btnSaveImagePath.Size = new System.Drawing.Size(75, 23);
            this.btnSaveImagePath.TabIndex = 3;
            this.btnSaveImagePath.Text = "Guardar Ruta";
            this.btnSaveImagePath.UseVisualStyleBackColor = true;
            this.btnSaveImagePath.Click += new System.EventHandler(this.btnSaveImagePath_Click);
            // 
            // btnLoadImagePath
            // 
            this.btnLoadImagePath.Location = new System.Drawing.Point(197, 224);
            this.btnLoadImagePath.Name = "btnLoadImagePath";
            this.btnLoadImagePath.Size = new System.Drawing.Size(75, 23);
            this.btnLoadImagePath.TabIndex = 4;
            this.btnLoadImagePath.Text = "Cargar Ruta";
            this.btnLoadImagePath.UseVisualStyleBackColor = true;
            this.btnLoadImagePath.Click += new System.EventHandler(this.btnLoadImagePath_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnLoadImagePath);
            this.Controls.Add(this.btnSaveImagePath);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.pictureBox);
            this.Name = "MainForm";
            this.Text = "Cargador de Imágenes";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Button btnLoadImage;
        private System.Windows.Forms.Button btnSaveImagePath;
        private System.Windows.Forms.Button btnLoadImagePath;
    }
}
