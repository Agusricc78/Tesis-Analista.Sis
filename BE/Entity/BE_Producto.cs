using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Entity
{
    public class BE_Producto
    {
		private string marca;

		public string Marca
		{
			get { return marca; }
			set { marca = value; }
		}

		private string modelo;

		public string Modelo
		{
			get { return modelo; }
			set { modelo = value; }
		}

		private int tamaño;

		public int Tamaño
		{
			get { return tamaño; }
			set { tamaño = value; }
		}

		private string categoria;

		public string Categoria
		{
			get { return categoria; }
			set { categoria = value; }
		}

		private int precio;

		public int Precio
		{
			get { return precio; }
			set { precio = value; }
		}

		private int stock;

		public int Stock
		{
			get { return stock; }
			set { stock = value; }
		}


	}
}
