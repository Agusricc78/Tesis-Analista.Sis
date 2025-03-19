using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Entity
{
    public class BE_Carrito
    {
		private int id_carrito;

		public int Id_Carrito
		{
			get { return id_carrito; }
			set { id_carrito = value; }
		}

		private string fechacierre;

		public string FechaCierre
		{
			get { return fechacierre; }
			set { fechacierre = value; }
		}

		private string estado;

		public string Estado
		{
			get { return estado; }
			set { estado = value; }
		}

		private int subtotal;

		public int Subtotal
		{
			get { return subtotal; }
			set { subtotal = value; }
		}

		private int impuestos;

		public int Impuestos
		{
			get { return impuestos; }
			set { impuestos = value; }
		}

		private int id_usuario;

		public int Id_Usuario
		{
			get { return id_usuario; }
			set { id_usuario = value; }
		}

		private int total;

		public int Total
		{
			get { return total; }
			set { total = value; }
		}


		private int id_cliente;

		public int Id_Cliente
		{
			get { return id_cliente; }
			set { id_cliente = value; }
		}

		public DataTable cliente { get; set; }





	}
}
