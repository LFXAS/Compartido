using System;
using System.Windows.Forms;

namespace Unidad_4
{
    public partial class FrmPrograma01 : Form
    {
        public FrmPrograma01()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string gender = radioButtonMale.Checked ? "Masculino" : "Femenino";
            string country = comboBoxCountry.SelectedItem.ToString();

            MessageBox.Show($"Nombre: {name}\nGénero: {gender}\nPaís: {country}", "Información");
        }
    }
}
