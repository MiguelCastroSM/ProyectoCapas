using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;


namespace Presentacion
{
    public partial class Menu : Form
    {
       Controladora controladora = new Controladora();
    
        public Menu()
        {
            InitializeComponent();
            controladora.ActualizarGrid(dataGridView1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmEmpleados frmempledos = new FrmEmpleados();
            frmempledos.ShowDialog();
            controladora.ActualizarGrid(dataGridView1);
            

        }

        private void btnMod_Click(object sender, EventArgs e)
        {
          
            FrmEmpleados frmempledos = new FrmEmpleados(Convert.ToInt32(dataGridView1.SelectedCells[0].Value));
            frmempledos.ShowDialog();
            controladora.ActualizarGrid(dataGridView1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FrmEmpleados frmempledos = new FrmEmpleados(Convert.ToInt32(dataGridView1.SelectedCells[0].Value),"eliminar");
            frmempledos.ShowDialog();
            controladora.ActualizarGrid(dataGridView1);
        }
    }
}
