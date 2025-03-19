using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Entity
{
	public class BE_Cliente
	{

		private int id_cliente;

		public int Id_Cliente
		{
			get { return id_cliente; }
			set { id_cliente = value; }
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

		private int dni;

		public int DNI
		{
			get { return dni; }
			set { dni = value; }
		}


		private int telefono;

		public int Telefono
		{
			get { return telefono; }
			set { telefono = value; }
		}

	




	}
}
