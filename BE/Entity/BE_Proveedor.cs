using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Entity
{
    public class BE_Proveedor
    {
		private int id_proveedor;

		public int Id_Proveedor
		{
			get { return id_proveedor; }
			set { id_proveedor = value; }
		}

		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string apellido;

		public string Apellido
		{
			get { return apellido; }
			set { apellido = value; }
		}

		private string direccion;

		public string  Direccion
		{
			get { return direccion; }
			set { direccion = value; }
		}

		private int cuil;

		public int Cuil
		{
			get { return cuil; }
			set { cuil = value; }
		}

		private int telefono;

		public int Telefono
		{
			get { return telefono; }
			set { telefono = value; }
		}


		private int dni;

		public int DNI
		{
			get { return dni; }
			set { dni = value; }
		}




	}
}
