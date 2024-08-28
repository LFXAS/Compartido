using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Unidad_3
{
    public partial class ManejoArchivo4 : Form
    {
        public ManejoArchivo4()
        {
            InitializeComponent();
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            AddNote();
        }

        private void btnSaveNotes_Click(object sender, EventArgs e)
        {
            SaveNotes();
        }

        private void btnLoadNotes_Click(object sender, EventArgs e)
        {
            LoadNotes();
        }

        private void AddNote()
        {
            if (!string.IsNullOrWhiteSpace(txtTitle.Text) && !string.IsNullOrWhiteSpace(txtContent.Text))
            {
                listBoxNotes.Items.Add($"{txtTitle.Text}: {txtContent.Text}");
                txtTitle.Clear();
                txtContent.Clear();
            }
            else
            {
                MessageBox.Show("Por favor ingresa un título y contenido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SaveNotes()
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                        {
                            foreach (var item in listBoxNotes.Items)
                            {
                                writer.WriteLine(item.ToString());
                            }
                        }
                        MessageBox.Show("Notas guardadas correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al guardar las notas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadNotes()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        listBoxNotes.Items.Clear();
                        using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                listBoxNotes.Items.Add(line);
                            }
                        }
                        MessageBox.Show("Notas cargadas correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar las notas: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
