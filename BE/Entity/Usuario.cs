using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Entity
{
    public class Usuario 
    {

		



		private int id_usuario;

		public int Id_Usuario
		{
			get { return id_usuario; }
			set { id_usuario = value; }
		}



		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string contraseña;

		public string Contraseña
		{
			get { return contraseña; }
			set { contraseña = value; }
		}

		private bool estado;

		public bool Estado
		{
			get { return estado; }
			set { estado = value; }
		}

		private string mail;

		public string Mail
		{
			get { return mail; }
			set { mail = value; }
		}

		private int dni;

		public int Dni
		{
			get { return dni; }
			set { dni = value; }
		}

		private  bool bloqueo;

		public bool Bloqueo
		{
			get { return bloqueo; }
			set { bloqueo = value; }
		}

		private string apellido;

		public string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
		}

		private string username;

		public string UserName
		{
			get { return username; }
			set { username = value; }
		}

		private int id_perfil;

		public int Id_Perfil
		{
			get { return id_perfil; }
			set { id_perfil = value; }
		}

        public BE_Perfil PerfilCompleto { get; set; }


        public string idioma { get; set; }



    }
}
