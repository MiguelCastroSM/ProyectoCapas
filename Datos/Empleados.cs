using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Empleados
    {
        private int id;
        private int dni;
        private string nombre;
        private string apellido;
        private string direccion;
        private string mail;
        private string puesto;
        private string legajo;
        private string telefono;
        private string cuil;

        public int Id { get => id; set => id = value; }
        public int Dni { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public string Legajo { get => legajo; set => legajo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Cuil { get => cuil; set => cuil = value; }
    }
}
