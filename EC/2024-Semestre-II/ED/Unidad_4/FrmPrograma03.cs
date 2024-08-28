using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Unidad_4
{
    public partial class FrmPrograma03: Form
    {
        public FrmPrograma03()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void addToolStripButton_Click(object sender, EventArgs e)
        {
            string nodeName = "Nodo " + (treeView.Nodes.Count + 1).ToString();
            treeView.Nodes.Add(nodeName);
        }

        private void removeToolStripButton_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                treeView.Nodes.Remove(treeView.SelectedNode);
            }
            else
            {
                MessageBox.Show("Seleccione un nodo para eliminar.", "Información");
            }
        }
    }
}
