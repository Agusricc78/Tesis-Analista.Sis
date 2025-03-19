using AutoMapper;
using BE.Entity;
using BLL.Negocio;
using Interfaces;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
using SERVICIOS.Lenguages;
using SERVICIOS;
using SERVICIOS.Permisos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;
using Org.BouncyCastle.Asn1.BC;
using DALL.Mappers;

namespace ProductosOSC
{
    public partial class Permisos : Form,IObserver
    {
        ManagerPermisos mp = new ManagerPermisos();
        private JsonManager _languageManager;
        BLL_Perfil perfil = new BLL_Perfil();
        PreCargarPermisos permisos = new PreCargarPermisos();
        BLL_Usuario user = new BLL_Usuario();
        BLL_BitacoraEvento even = new BLL_BitacoraEvento();
        public Permisos()
        {
            
            InitializeComponent();
            ListarPerfiles();
            CbxPerf();
            ObervableLanguage.Instancia.Agregar(this);
            UpdateLanguage();
        }

      
        private List<SERVICIOS.Permisos.Component> listaPermisosRol = new List<SERVICIOS.Permisos.Component>();
        private static void AgregarNodosHijo(TreeNode node, PermisoCompuesto permisoCompuesto)
        {
            foreach (SERVICIOS.Permisos.Component permisoHijo in permisoCompuesto.ListarPermisos())
            {
                if (permisoHijo is PermisoCompuesto)
                {
                    PermisoCompuesto permisoCompuestoHijo = (PermisoCompuesto)permisoHijo;

                    TreeNode nodoHijo = new TreeNode(permisoCompuestoHijo.Codigo);
                    nodoHijo.Tag = permisoCompuestoHijo.ID;

                    AgregarNodosHijo(nodoHijo, permisoCompuestoHijo);

                    node.Nodes.Add(nodoHijo);
                }
                else if (permisoHijo is PermisoSimple)
                {
                    PermisoSimple permisoSimpleHijo = (PermisoSimple)permisoHijo;

                    TreeNode nodoHijo = new TreeNode(permisoSimpleHijo.Codigo);
                    nodoHijo.Tag = permisoSimpleHijo.ID;

                    node.Nodes.Add(nodoHijo);
                }
            }
        }
        int permisoSeleccionadoSistema;
        int permisoSeleccionadoUsuario;



        void ListarFamilias()
        {
            try
            {
                dgvfamilia.DataSource = mp.ListarFamilias();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ListarPerfiles()
        {
            dgvperfiles.DataSource = perfil.ListarPerfiles();
            
        }

        void CbxFamilias()
        {
            cbxFamilias.DataSource = mp.ListarFamilias();
            cbxFamilias.DisplayMember = "Nombre";
            cbxFamilias.ValueMember = "Id_PermisoCompuesto";
        }


        void CbxPerf()
        {
            cbxper.DataSource = perfil.ListarPerfiles();
            cbxper.DisplayMember = "Nombre";
            cbxper.ValueMember = "Id_Rol";
        }

        private void Permisos_Load(object sender, EventArgs e)
        {
            rbtnCrearPerfil.Checked = true;
            DT_PermisosAsignar.Columns.Add("ID", typeof(int));
            DT_PermisosAsignar.Columns.Add("CODIGO", typeof(string));
            DT_PermisosAsignar.Columns.Add("DESCRIPCION", typeof(string));
            DT_PermisosAsignar.Columns.Add("ID_PADRE", typeof(int));

            TreeviewPerfil.Nodes.Clear();

            foreach (SERVICIOS.Permisos.Component permiso in permisos.components)
            {
                TreeNode nodo = new TreeNode(permiso.Codigo);
                nodo.Tag = permiso.ID;
                if (permiso is PermisoCompuesto)
                {
                    AgregarNodosHijo(nodo, (PermisoCompuesto)permiso);
                }
                TreeviewPerfil.Nodes.Add(nodo);
            }

            TreeviewPerfil.ExpandAll();

            ListarFamilias();
            CbxFamilias();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                MenuPrincipal mp = new MenuPrincipal();
                mp.Show();
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
           
        }
        private void tvAsignar_AfterSelect(object sender, TreeViewEventArgs e)
        {
            permisoSeleccionadoUsuario = (int)tvAsignar.SelectedNode.Tag;
            MessageBox.Show(permisoSeleccionadoUsuario.ToString());
        }

        private void TreeviewPerfil_AfterSelect(object sender, TreeViewEventArgs e)
        {
            permisoSeleccionadoSistema = (int)TreeviewPerfil.SelectedNode.Tag;
            //MessageBox.Show(permisoSeleccionadoSistema.ToString());

        }


        DataTable miDT = new DataTable();
        DataTable DT_PermisosAsignar = new DataTable();
        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            miDT = permisos.getDtPermisos();
            llenarPadres(permisoSeleccionadoSistema);
            llenarDT(permisoSeleccionadoSistema);


            DataRow[] mNivel0 = miDT.Select("ID = ID_PADRE");
            //DataRow[] mNivel0 = miDT.Select("ID = " + permisoSeleccionadoSistema);

            TreeNode NodoRaiz = new TreeNode(mNivel0[0]["CODIGO"].ToString());
            tvAsignar.Nodes.Clear();
            llenarTreeviewDesdeDT(DT_PermisosAsignar, mNivel0[0], NodoRaiz);
            tvAsignar.Nodes.Add(NodoRaiz);
            tvAsignar.ExpandAll();
        }

        private void llenarPadres(int id)
        {
            DataRow[] DR = miDT.Select("ID = " + id);

            // Verificar si se encontraron filas
            if (DR.Length == 0)
            {
                return; // No se encontraron filas con el ID especificado
            }

            // Verificar si la fila ya existe en DT_PermisosAsignar
            bool rowExists = false;
            foreach (DataRow row in DT_PermisosAsignar.Rows)
            {
                if (row.Field<int>("ID") == id)
                {
                    rowExists = true;
                    break; // No es necesario seguir buscando una vez que se encuentra la fila
                }
            }

            // Si la fila no existe, agregarla
            if (!rowExists)
            {
                DataRow newRow = DT_PermisosAsignar.NewRow();
                newRow["ID"] = DR[0]["ID"];
                newRow["CODIGO"] = DR[0]["CODIGO"];
                newRow["DESCRIPCION"] = DR[0]["DESCRIPCION"];
                newRow["ID_PADRE"] = DR[0]["ID_PADRE"];

                DT_PermisosAsignar.Rows.Add(newRow);

                // Si el ID y el ID_PADRE no son iguales, llamar recursivamente
                int? idPadre = DR[0].Field<int?>("ID_PADRE");
                if (idPadre.HasValue && id != idPadre.Value)
                {
                    llenarPadres(idPadre.Value);
                }
            }



        }

        private void llenarDT(int ID)
        {

            //crear funcion de traer padre
            if (ID != 0)
            {
                DataRow[] DR = miDT.Select("ID_PADRE = " + ID);

                if (DR.Length == 0) //leaf
                {

                }
                else
                {
                    foreach (DataRow row in DR)
                    {
                        if (!comprobarExists((int)row["ID"]) && (int)row["ID"] != 1)
                        {
                            DataRow newRow = DT_PermisosAsignar.NewRow();
                            newRow["ID"] = row["ID"];
                            newRow["CODIGO"] = row["CODIGO"];
                            newRow["DESCRIPCION"] = row["DESCRIPCION"];
                            newRow["ID_PADRE"] = row["ID_PADRE"];

                            DT_PermisosAsignar.Rows.Add(newRow);
                            if ((int)row["ID"] != 1)
                            {
                                llenarDT((int)row["ID"]);
                            }
                            else
                            {
                                llenarDT(0);
                            }
                        }
                        else
                        {
                            if ((int)row["ID"] != 1)
                            {
                                llenarDT((int)row["ID"]);
                            }
                        }
                    }
                }
            }
        }

        private bool comprobarExists(int id)
        {
            foreach (DataRow row in DT_PermisosAsignar.Rows)
            {
                if ((int)row["ID"] == id)
                {
                    return true;
                }

            }
            return false;
        }

        private void llenarTreeviewDesdeDT(DataTable tabla, DataRow pDrHijo, TreeNode nodo)
        {
            //AGRERGAR TAG ID DEL PERMISO ASI PUEDO BORRAR DEL DATATABLE LUEGO

            DataRow[] drHijos = tabla.Select("ID_PADRE = " + pDrHijo["ID"]);
            if (drHijos.Length == 0)  // Es leaf
            {
                //
            }
            else // Es composite
            {

                foreach (DataRow dr in drHijos)
                {

                    if (dr["ID"].ToString() == "1")
                    {
                        nodo.Tag = (int)dr["ID"];
                    }
                    else
                    {
                        TreeNode newNode = new TreeNode(dr["CODIGO"].ToString());
                        newNode.Tag = (int)dr["ID"];
                        nodo.Nodes.Add(newNode);
                        //nodo.Tag = (int)dr["ID"];
                        llenarTreeviewDesdeDT(tabla, dr, newNode);
                    }
                }
            }
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPerfil.Text != "" || txtDescripcion.Text != "")
                {

                }
                else
                {
                    MessageBox.Show("Campos vacios");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (permisoSeleccionadoUsuario != 0)
            {
                int id = permisoSeleccionadoUsuario;
                permisoSeleccionadoUsuario = 0;
                removePermiso(id);
                DataRow[] mNivel0 = miDT.Select("ID = ID_PADRE");
                //DataRow[] mNivel0 = miDT.Select("ID = " + permisoSeleccionadoSistema);

                TreeNode NodoRaiz = new TreeNode(mNivel0[0]["CODIGO"].ToString());
                tvAsignar.Nodes.Clear();
                llenarTreeviewDesdeDT(DT_PermisosAsignar, mNivel0[0], NodoRaiz);
                tvAsignar.Nodes.Add(NodoRaiz);
                tvAsignar.ExpandAll();
            }
            else
            {

            }
        }

        private void removePermiso(int id)
        {
            DataRow[] Rows = DT_PermisosAsignar.Select("ID_PADRE = " + id + " OR ID = " + id);

            if (Rows.Length == 0)
            {
                DT_PermisosAsignar.Rows.Remove(Rows[0]);

            }
            else
            {
                foreach (DataRow row in Rows)
                {
                    DT_PermisosAsignar.Rows.Remove(row);
                }
            }

        }

        private void TreeviewPerfil_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            permisoSeleccionadoSistema = (int)TreeviewPerfil.SelectedNode.Tag;
            //MessageBox.Show(permisoSeleccionadoSistema.ToString());
        }

        private void tvAsignar_AfterSelect_1(object sender, TreeViewEventArgs e)
        {
            permisoSeleccionadoUsuario = (int)tvAsignar.SelectedNode.Tag;
            MessageBox.Show(permisoSeleccionadoUsuario.ToString());
        }

        private void btnGuardarCambios_Click_1(object sender, EventArgs e)
        {
            if (DT_PermisosAsignar.Rows.Count > 0)
            {

                try
                {
                    if (rbtneditarper.Checked)
                    {
                        int familiaid = (int)cbxFamilias.SelectedValue;

                        perfil.GuardarFamilia(DT_PermisosAsignar, familiaid);
                        even.InsertarEvento(SessionManager.getProfile().Nombre, DateTime.Now, DateTime.Now.TimeOfDay, "Asignar Permisos", "frmPermisos", 4, SessionManager.getProfile().Apellido, SessionManager.getProfile().UserName);

                        MessageBox.Show("Se han asignado los permisos a la familia correctamente");


                    }
                    else
                    {
                        if (cbxper.Items != null)
                        {
                            int PerfilId = Convert.ToInt32(cbxper.SelectedValue);
                            int FamiliaId = Convert.ToInt32(cbxFamilias.SelectedValue);

                            bool exito = perfil.guardarPermisosPerfil(DT_PermisosAsignar, PerfilId, FamiliaId);

                            if (exito)
                            {
                                MessageBox.Show("Permisos asignados correctamente al perfil");
                            }
                            else
                            {
                                MessageBox.Show("Perfil Duplicado");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Campos Vacios");
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {

            }
        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                bool ExistePerfil = user.VerificarPerfilExiste(txtPerfil.Text);
                
                    if (ExistePerfil)
                    {
                        MessageBox.Show("Ya existe un perfil con ese nombre");
                    }
                    else
                    {
                        BE_Perfil miPerfil = new BE_Perfil();
                        miPerfil.Nombre = txtPerfil.Text;
                        miPerfil.Descripcion = txtDescripcion.Text;
                        perfil.AgregarPerfil(txtDescripcion.Text, txtPerfil.Text);
                        MessageBox.Show("Perfil creado correctamente");
                        CbxPerf();
                        ListarPerfiles();
                    even.InsertarEvento(SessionManager.getProfile().Nombre, DateTime.Now, DateTime.Now.TimeOfDay, "Creacion perfil", "frmPermisos", 5, SessionManager.getProfile().Apellido, SessionManager.getProfile().UserName);
                }
                
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateLanguage()
        {
            try
            {
                var Idioma = JObject.Parse(File.ReadAllText(@"C:\Users\agusr\source\repos\ProductosOSC\SERVICIOS\Lenguages\" + ObervableLanguage.Instancia.Idioma + ".json"));

               
                    lblperfiles.Text = Idioma["Permisos"]["lblperfiles"].ToString();
                    lblperfil.Text = Idioma["Permisos"]["lblperfil"].ToString();
                    lblperfilescreados.Text = Idioma["Permisos"]["lblperfilescreados"].ToString();
                    lblpermisosdelsistema.Text = Idioma["Permisos"]["lblpermisosdelsistema"].ToString();
                    lblpermisosperfil.Text = Idioma["Permisos"]["lblpermisosperfil"].ToString();
                    lbldescr.Text = Idioma["Permisos"]["lbldescr"].ToString();
                    rbtnCrearPerfil.Text = Idioma["Permisos"]["rbtncrearperfil"].ToString();
                    rbtneditarper.Text = Idioma["Permisos"]["rbtneditarperfil"].ToString();
                    btnAsignar.Text = Idioma["Permisos"]["btnAsignar"].ToString();
                    btnRemover.Text = Idioma["Permisos"]["btnRemover"].ToString();
                    btnmenu.Text = Idioma["Permisos"]["btnmenu"].ToString();
                    btnGuardarCambios.Text = Idioma["Permisos"]["btnGuardarCambios"].ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Permisos_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void btnRemover_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (permisoSeleccionadoUsuario != 0)
                {
                    int id = permisoSeleccionadoUsuario;
                    permisoSeleccionadoUsuario = 0;
                    removePermiso(id);
                    DataRow[] mNivel0 = miDT.Select("ID = ID_PADRE");
                    //DataRow[] mNivel0 = miDT.Select("ID = " + permisoSeleccionadoSistema);

                    TreeNode NodoRaiz = new TreeNode(mNivel0[0]["CODIGO"].ToString());
                    tvAsignar.Nodes.Clear();
                    llenarTreeviewDesdeDT(DT_PermisosAsignar, mNivel0[0], NodoRaiz);
                    tvAsignar.Nodes.Add(NodoRaiz);
                    tvAsignar.ExpandAll();
                }
                else
                {

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCrearFamilia_Click(object sender, EventArgs e)
        {
            if(rbtnCrearPerfil.Checked == true)
            {
                try
                {
                    bool ExistePerfil = user.VerificarPerfilExiste(txtPerfil.Text);

                    if (ExistePerfil)
                    {
                        MessageBox.Show("Ya existe un perfil con ese nombre");
                        txtPerfil.Clear();
                        txtDescripcion.Clear();
                    }
                    else
                    {
                        BE_Perfil miPerfil = new BE_Perfil();
                        miPerfil.Nombre = txtPerfil.Text;
                        miPerfil.Descripcion = txtDescripcion.Text;
                        perfil.AgregarPerfil(txtDescripcion.Text, txtPerfil.Text);
                        MessageBox.Show("Perfil creado correctamente");
                        CbxPerf();
                        ListarPerfiles();
                        txtPerfil.Clear();
                        txtDescripcion.Clear();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
           else if(rbtneditarper.Checked == true)
            {
                bool ExistsFamilia = mp.ExistsFamilia(txtPerfil.Text);
                if (ExistsFamilia)
                {
                    MessageBox.Show("La familia que intenta introducir ya existe");
                    txtPerfil.Clear();
                    txtDescripcion.Clear();
                }
                else
                {
                    mp.AgregarFamilia(txtDescripcion.Text,txtPerfil.Text);
                    ListarFamilias();
                    txtPerfil.Clear();
                    txtDescripcion.Clear();
                    ListarPerfiles();
                    CbxFamilias();
                    MessageBox.Show("La familia fue creada con exito");

                }


            }



        }

        private void dgvFamilias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(rbtnCrearPerfil.Checked)
            {
                try
                {
                    BE_Perfil per = new BE_Perfil();
                    per.ID = (int)cbxper.SelectedValue;
                    bool ExistsRelacion = perfil.ValidarPerfil(per.ID);
                    perfil.EliminarPerfil(per.ID);
                    MessageBox.Show("Perfil eliminado exitosamente");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else if (rbtneditarper.Checked)
            {
                try
                {
                    BE_Familia fam = new BE_Familia();
                    fam.Id_Familia = (int)cbxFamilias.SelectedValue;
                    bool ExistsRelacion = perfil.ValidarFamilia(fam.Id_Familia);
                    mp.EliminarFamilia(fam.Id_Familia);
                    MessageBox.Show("Familia eliminada exitosamente");
                    CbxFamilias();

                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblperfilescreados_Click(object sender, EventArgs e)
        {

        }

        private void btnAsignarFamilia_Click(object sender, EventArgs e)
        {
            bool exists = perfil.VerificarRelacionFamPer((int)cbxFamilias.SelectedValue, (int)cbxper.SelectedValue);
            try
            {
                if(exists)
                {
                    MessageBox.Show("La relacion que desea asignar ya existe");
                }
                else
                {
                    BE_Familia fam = new BE_Familia();
                    BE_Perfil per = new BE_Perfil();
                    per.ID = (int)cbxper.SelectedValue;
                    fam.Id_Familia = (int)cbxFamilias.SelectedValue;
                    perfil.InsertarRelacion(fam.Id_Familia, per.ID);
                    ListarPerfiles();
                    MessageBox.Show("Se ha asignado correctamente la familia al perfil seleccionado");
                }
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnQuitarFamilia_Click(object sender, EventArgs e)
        {
            bool exists = perfil.VerificarRelacionFamPer((int)cbxFamilias.SelectedValue, (int)cbxper.SelectedValue);
            try
            {
                if(exists)
                {
                    BE_Perfil per = new BE_Perfil();
                    per.ID = (int)cbxper.SelectedValue;
                    perfil.EliminarRelacionPerfilFamilia(per.ID);
                    MessageBox.Show("La relacion fue eliminada con exito");
                    ListarPerfiles();
                }
                else
                {
                    MessageBox.Show("La relacion que desea eliminar no existe");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button1_Click_3(object sender, EventArgs e)
        {
            try
            {
                MenuPrincipal mp = new MenuPrincipal();
                mp.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
