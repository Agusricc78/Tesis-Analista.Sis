using BE.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS.Permisos
{
    public class PreCargarPermisos
    {
        public readonly List<Component> components = new List<Component>();

        //Modulo ; 'A' ; numero del permiso ( si es 00 es nodo)
        private readonly PermisoCompuesto pcRaiz = new PermisoCompuesto(1, "Permiso raiz", "Permiso raiz", 1);

        private readonly PermisoSimple pcGestionSocios = new PermisoSimple(32, "Permiso Administrador", "Permite administrador todos los usuarios", 1);
        private readonly PermisoSimple psGestionSocio01 = new PermisoSimple(34, "Gestion-Perfil", "Permite gestionar los permisos de los perfiles", 1);
        private readonly PermisoSimple psGestionSocio02 = new PermisoSimple(33, "Gestion de Compra", "Permite realizar compras", 1);
        private readonly PermisoSimple psGestionCliente = new PermisoSimple(35, "Gestion de productos", "Permite agregar,eliminar y ver todos los productos", 1);
        private readonly PermisoSimple psGestionUsuario = new PermisoSimple(45, "Despacho", "Modulo gestion de usuarios", 1);
       
        private readonly PermisoSimple pcPerfilUsuario = new PermisoSimple(46, "Reportes", "Permite realizar reportes", 1);
        private readonly PermisoSimple psGestionUsuario01 = new PermisoSimple(47, "Ayuda", "Permite contactarse con los representantes de ProductosOSC", 1);
        private readonly PermisoSimple psGestionNegocio = new PermisoSimple(53, "Negocio", "Modulo gestion de Negocios", 1);
        private readonly PermisoSimple psGestionRegistro = new PermisoSimple(49, "Registro", "Modulo gestion de Registro de Usuarios", 1);




        public PreCargarPermisos()
        {
            #region Agregacion de hojas a compuestos
            
            pcRaiz.AgregarPermiso(pcGestionSocios);
            pcRaiz.AgregarPermiso(psGestionSocio01);
            pcRaiz.AgregarPermiso(psGestionSocio02);
            pcRaiz.AgregarPermiso(psGestionRegistro);
            pcRaiz.AgregarPermiso(psGestionNegocio);

            
            pcRaiz.AgregarPermiso(psGestionUsuario01);
            pcRaiz.AgregarPermiso(psGestionCliente);
            pcRaiz.AgregarPermiso(pcPerfilUsuario);
            pcRaiz.AgregarPermiso(psGestionUsuario);


            
           
            #endregion

            #region Configuracion raiz
            
            
            #endregion
            components.Add(pcRaiz);

            dtPermisos.Columns.Add("ID", typeof(int));
            dtPermisos.Columns.Add("CODIGO", typeof(string));
            dtPermisos.Columns.Add("DESCRIPCION", typeof(string));
            dtPermisos.Columns.Add("ID_PADRE", typeof(int));

            llenarPermisosDT(pcRaiz);
        }

        public Component getPermiso() => this.pcRaiz;

        public DataTable getDtPermisos() { return this.dtPermisos; }


        DataTable dtPermisos = new DataTable();

        public void llenarPermisosDT(Component componente)
        {
            AgregarPermisoATable(dtPermisos, componente);

            foreach (var item in componente.ListarPermisos())
            {

                if (item is PermisoCompuesto)
                {
                    AgregarPermisoATable(dtPermisos, item);
                    foreach (var subItem in item.ListarPermisos())
                    {
                        //AgregarPermisoATable(dtPermisos, subItem);    
                        llenarPermisosDT(subItem);
                    }
                }
                else
                {
                    AgregarPermisoATable(dtPermisos, item);
                }
            }

        }

        public void AgregarPermisoATable(DataTable dataTable, Component permiso)
        {
            // Supongamos que tienes columnas "NombrePermiso" y "Tipo" en tu DataTable
            DataRow newRow = dataTable.NewRow();
            newRow["ID"] = permiso.ID;
            newRow["CODIGO"] = permiso.Codigo;
            newRow["DESCRIPCION"] = permiso.Descripcion;
            newRow["ID_PADRE"] = permiso.ID_Padre;
            dataTable.Rows.Add(newRow);
        }



        public void guardarPermisos(DataTable table, BE_Perfil perfil)
        {

        }


    }
}
