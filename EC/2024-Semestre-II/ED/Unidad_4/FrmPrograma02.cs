using System;
using System.Windows.Forms;

namespace Unidad_4
{
    public partial class FrmPrograma02 : Form
    {
        public FrmPrograma02()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string item = textBoxItem.Text;
            if (!string.IsNullOrWhiteSpace(item))
            {
                listBoxItems.Items.Add(item);
                textBoxItem.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, ingrese un ítem.", "Error");
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            dataGridViewItems.Rows.Clear();
            foreach (var item in listBoxItems.Items)
            {
                dataGridViewItems.Rows.Add(item.ToString());
            }
        }
    }
}
