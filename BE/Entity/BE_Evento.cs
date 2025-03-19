using Org.BouncyCastle.Asn1.Cms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Entity
{
	public class BE_Evento
	{
		private int id_evento;

		public int Id_Evento
		{
			get { return id_evento; }
			set { id_evento = value; }
		}

		private int criticidad;

		public int Criticidad
		{
			get { return criticidad; }
			set { criticidad = value; }
		}

		private string modulo;

		public string Modulo
		{
			get { return modulo; }
			set { modulo = value; }
		}

		private string evento;

		public string Evento
		{
			get { return evento; }
			set { evento = value; }
		}

		private string usuario;

		public string Usuario
		{
			get { return usuario; }
			set { usuario = value; }
		}

		private DateTime fecha ;

		public DateTime Fecha 
		{
			get { return fecha; }
			set { fecha = value; }
		}

		private TimeSpan hora;

		public TimeSpan Hora
		{
			get { return hora; }
			set { hora = value; }
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




	}
}
