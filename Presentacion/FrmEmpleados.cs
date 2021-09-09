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
    public partial class FrmEmpleados : Form
    {
        int id;
        string e;
        Controladora controladora = new Controladora();
        public FrmEmpleados(int id=0,string e=null)
        {
            InitializeComponent();
            this.id = id;
            this.e = e;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (id>=1)
            {
                controladora.Insert(txtApellido.Text, txtName.Text, txtMail.Text, txtCuil.Text, txtDni.Text, txtDireccion.Text, txtPuesto.Text, txtTel.Text, txtLegajo.Text, id);
            }
            else
            {
                controladora.Insert(txtApellido.Text, txtName.Text, txtMail.Text, txtCuil.Text, txtDni.Text, txtDireccion.Text, txtPuesto.Text, txtTel.Text,txtLegajo.Text,id);
            }
            this.Close();
        }

        private void FrmEmpleados_Load(object sender, EventArgs e)
        {
            if(id>=1)
            {
                String[] empleado = controladora.Buscar(this.id);
                txtID.Text = empleado[0];
                txtDni.Text = empleado[1];
                txtDireccion.Text = empleado[2];
                txtCuil.Text = empleado[3];
                txtName.Text = empleado[4];
                txtApellido.Text = empleado[5];
                txtTel.Text = empleado[6];
                txtPuesto.Text = empleado[7];
                txtMail.Text = empleado[8];
                txtLegajo.Text = empleado[9];

            }
        }
    }
}
