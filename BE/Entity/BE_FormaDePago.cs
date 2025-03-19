using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Entity
{
    public class BE_FormaDePago
    {

		private int id_pago;

		public int Id_Pago
		{
			get { return id_pago; }
			set { id_pago = value; }
		}

		private string formadepago;

		public string FormaDePago
		{
			get { return formadepago; }
			set { formadepago = value; }
		}




	}
}
