using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace Logica
{
    public class Controladora
    {
        Conection cnn = new Conection();
        public void ActualizarGrid (DataGridView dgv)
        {
            
            dgv.DataSource = cnn.GetAll();
        }
    public void Insert(String txtApellido,String txtName,String txtMail,String txtCuil,String txtDni,String txtDireccion,String txtPuesto,String txtTel,String txtLegajo,int id)
        {

            Empleados emp = new Empleados();
            emp.Nombre = txtName;
            emp.Apellido = txtApellido;
            emp.Dni = Convert.ToInt32(txtDni);
            emp.Legajo = txtLegajo;
            emp.Mail = txtMail;
            emp.Cuil = txtCuil;
            emp.Puesto = txtPuesto;
            emp.Direccion = txtDireccion;
            emp.Telefono = txtTel;
            emp.Id = id;
            if (id==0)
            {
                cnn.Insert(emp);
            }
            else
            {
                cnn.Update(emp);
            }
            
        }
    
    public String[] Buscar (int id)
        {
     
            Empleados emp = cnn.Buscar(id);
            String[] empleado = { emp.Id.ToString(), emp.Dni.ToString(), emp.Direccion, emp.Cuil, emp.Nombre, emp.Apellido, emp.Telefono, emp.Puesto, emp.Mail, emp.Legajo };
            
            return empleado;
        }

    }
    
}
