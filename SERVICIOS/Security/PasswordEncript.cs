using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS.Security
{
    public class PasswordEncript
    {
        public static string EncriptarContraseña(string password, string username) //Encripts the password.
        {
            string saltedPassword = String.Concat(password, GenerarSalt(username));

            var sha256 = SHA256.Create();
            var sb = new StringBuilder();

            var stream = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));

            for (int i = 0; i < stream.Length; i++)
            {
                sb = sb.AppendFormat("{0:x2}", stream[i]);
            }

            return sb.ToString();
        }

        private static string GenerarSalt(string username) //Establishes the structure of the encription using a user prop as reference => 'Email'.
        {
            byte[] saltBytes = Encoding.ASCII.GetBytes(username);
            string saltString;
            long xored = 0x00;

            foreach (byte bite in saltBytes)
            {
                xored = xored ^ bite;
            }

            Random random = new Random(Convert.ToInt32(xored));

            saltString = random.Next().ToString();
            saltString += random.Next().ToString();
            saltString += random.Next().ToString();
            saltString += random.Next().ToString();

            return saltString;
        }


    }
}
