using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Entity
{
    public class BE_InfoPersonal
    {
        public BE_InfoPersonal()
        {
            // Constructor vacío
        }

        public BE_InfoPersonal(string nombre, string apellido, string dni, string direccionHogar, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
        }

        public int ID { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string DNI { get; set; }

     



    }
}
