using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Conection
    {
        public void Insert(Empleados empleado)
        {
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-0FCTNIM\\SQLEXPRESS;Initial Catalog=trescapas;Integrated Security=True");
            cnn.Open();
            const string query = "INSERT INTO  Empleados (nombre,apellido,dni,cuil,puesto,legajo,direccion,telefono,mail) VALUES (@nombre,@apellido,@dni,@cuil,@puesto,@legajo,@direccion,@telefono,@mail)";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@nombre", empleado.Nombre);
            cmd.Parameters.AddWithValue("@apellido", empleado.Apellido);
            cmd.Parameters.AddWithValue("@dni", empleado.Dni);
            cmd.Parameters.AddWithValue("@cuil", empleado.Cuil);
            cmd.Parameters.AddWithValue("@puesto", empleado.Puesto);
            cmd.Parameters.AddWithValue("@legajo", empleado.Legajo);
            cmd.Parameters.AddWithValue("@direccion", empleado.Direccion);
            cmd.Parameters.AddWithValue("@telefono", empleado.Telefono);
            cmd.Parameters.AddWithValue("@mail", empleado.Mail);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public Empleados Buscar(int id)
        {
            Empleados empleados = new Empleados();
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-0FCTNIM\\SQLEXPRESS;Initial Catalog=trescapas;Integrated Security=True");
            cnn.Open();//abre la conexion

            const string query = "SELECT * FROM Empleados WHERE id = @id";//Busco un empleado especifico con el mismo id.
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@id", id);
            SqlDataReader reader = cmd.ExecuteReader(); // lee los valores de la consulta

            while (reader.Read()) // mientras haya un valor lo lee
            {
                Empleados empleado = new Empleados 
                {
                    Id = Convert.ToInt32(reader["id"]),
                    Nombre = Convert.ToString(reader["nombre"]),
                    Apellido = Convert.ToString(reader["apellido"]),
                    Direccion = Convert.ToString(reader["direccion"]),
                    Mail = Convert.ToString(reader["mail"]),
                    Puesto = Convert.ToString(reader["puesto"]),
                    Legajo = Convert.ToString(reader["legajo"]),
                    Cuil = Convert.ToString(reader["cuil"]),
                    Telefono = Convert.ToString(reader["telefono"]),
                    Dni = Convert.ToInt32(reader["dni"])
                };
                empleados = empleado;
            }
            cnn.Close(); // cierra la conexion

            return empleados;// retorna la lista con los empleados obtenidos de la consulta 

        }
        public List<Empleados> GetAll()
        {
            List<Empleados> empleados = new List<Empleados>(); // lista qe almacena empleados
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-0FCTNIM\\SQLEXPRESS;Initial Catalog=trescapas;Integrated Security=True");
            cnn.Open();//abre la conexion

            const string query = "SELECT * FROM Empleados ORDER BY id ASC";
            SqlCommand cmd = new SqlCommand(query, cnn); // prepara la consulta
            SqlDataReader reader = cmd.ExecuteReader(); // lee los valores de la consulta

            while (reader.Read()) // mientras haya un valor lo lee
            {
                Empleados empleado = new Empleados //instancia la clase Emethods / e de entidad
                {
                    Id = Convert.ToInt32(reader["id"]), //guarda en al propiedad ID de EMethod , el id del primer registro hasta el ultimo 
                    Nombre = Convert.ToString(reader["nombre"]),
                    Apellido = Convert.ToString(reader["apellido"]),
                    Direccion = Convert.ToString(reader["direccion"]),
                    Mail = Convert.ToString(reader["mail"]),
                    Puesto = Convert.ToString(reader["puesto"]),
                    Legajo = Convert.ToString(reader["legajo"]),
                    Cuil = Convert.ToString(reader["cuil"]),
                    Telefono = Convert.ToString(reader["telefono"]),
                    Dni = Convert.ToInt32(reader["dni"])
                };
                empleados.Add(empleado); // agrega en la lista de empleados
            }
            cnn.Close(); // cierra la conexion

            return empleados;// retorna la lista con los empleados obtenidos de la consulta 
        }

        public void Update(Empleados empleado)
        {
            //  Conections cnn = new Conections();
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-0FCTNIM\\SQLEXPRESS;Initial Catalog=trescapas;Integrated Security=True");
            //SqlConnection cnn = new SqlConnection("Data source = 192.168.0.29; Initial Catalog = u1;User ID=u1;Password=u1" );
            cnn.Open();
            const string query = "UPDATE Empleados set nombre=@nombre,apellido=@apellido,direccion=@direccion,mail=@mail,puesto=@puesto,legajo=@legajo,cuil=@cuil,telefono=@telefono,dni=@dni where id=@id";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@nombre", empleado.Nombre);
            cmd.Parameters.AddWithValue("@apellido", empleado.Apellido);
            cmd.Parameters.AddWithValue("@direccion", empleado.Direccion);
            cmd.Parameters.AddWithValue("@mail", empleado.Mail);
            cmd.Parameters.AddWithValue("@puesto", empleado.Puesto);
            cmd.Parameters.AddWithValue("@legajo", empleado.Legajo);
            cmd.Parameters.AddWithValue("@cuil", empleado.Cuil);
            cmd.Parameters.AddWithValue("@telefono", empleado.Telefono);
            cmd.Parameters.AddWithValue("@dni", empleado.Dni);
            cmd.Parameters.AddWithValue("@id", empleado.Id);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public void Delete(Empleados empleado)
        {
            SqlConnection cnn = new SqlConnection("Data Source=DESKTOP-0FCTNIM\\SQLEXPRESS;Initial Catalog=trescapas;Integrated Security=True");
            cnn.Open();
            const string query = "DELETE FROM Empleados WHERE id=@id";
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.Parameters.AddWithValue("@id", empleado.Id);
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }

}

