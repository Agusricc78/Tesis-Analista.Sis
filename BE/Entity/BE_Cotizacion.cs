using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Entity
{
    public class BE_Cotizacion
    {
        private int id_Cotizacion;

        public int Id_Cotizacion
        {
            get { return id_Cotizacion; }
            set { id_Cotizacion = value; }
        }

        private int cant_prod;

        public int Cant_Prod
        {
            get { return cant_prod; }
            set { cant_prod = value; }
        }

        private int id_prov;

        public int Id_Prov
        {
            get { return id_prov; }
            set { id_prov = value; }
        }


        private DateTime fecha_aprov;

        public DateTime Fecha_Aprov
        {
            get { return fecha_aprov; }
            set { fecha_aprov = value; }
        }

        private DateTime fecha_soli;

        public DateTime Fecha_Soli
        {
            get { return fecha_soli; }
            set { fecha_soli = value; }
        }


        private int total;

        public int Total
        {
            get { return total; }
            set { total = value; }
        }

        private string forma_pago;

        public string Forma_Pago
        {
            get { return forma_pago; }
            set { forma_pago = value; }
        }

        private bool estado;

        public bool Estado
        {
            get { return estado; }
            set { estado = value; }
        }


        public List<BE_Producto> ListaProducto { get; set; }



    }
}
