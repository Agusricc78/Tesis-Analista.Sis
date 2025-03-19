using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProductosOSC.Validaciones
{
    public class ValidacionesRegex
    {
        public static bool ValidarContraseñas(string Password)
        {
            string regexPattern = @"^(?=.*[a-z])(?=.*[A-Z]).{6,}$";
            return Regex.IsMatch(Password, regexPattern);
        }

        public static bool ValidarNombre(string nombre)
        {
            string regexPattern = @"^[a-zA-Z\s]+$";
            return Regex.IsMatch(nombre, regexPattern);
        }

        public static bool ValidarCadenaNoVacia(string cadena)
        {
            // Expresión regular para verificar que la cadena no esté vacía
            string regexPattern = @"^.*\S.*$";
            return Regex.IsMatch(cadena, regexPattern);
        }

        public static bool ValidarNumeroNoVacio(string numero)
        {
            // Expresión regular para verificar que el número no esté vacío
            string regexPattern = @"^\d+$";
            return Regex.IsMatch(numero, regexPattern);
        }



    }
}
