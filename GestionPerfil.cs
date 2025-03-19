using AutoMapper;
using BE.Entity;
using BLL.Negocio;
using Interfaces;
using Newtonsoft.Json.Linq;
using SERVICIOS;
using SERVICIOS.Lenguages;
using SERVICIOS.Permisos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace ProductosOSC
{
    public partial class GestionPerfil : Form,IObserver
    {
        private JsonManager _languageManager;
 
        List<Usuario> usuarios = new List<Usuario>();
        List<Profile> profiles = new List<Profile>();
        BLL_Perfil perf = new BLL_Perfil();
        BLL_Usuario usuario = new BLL_Usuario();
        BLL_BitacoraEvento even = new BLL_BitacoraEvento();
        private void TraerPerfiles()
        {
           cboxPerfiles.DataSource = perf.ListarPerfiles();
            cboxPerfiles.DisplayMember = "Nombre";
            cboxPerfiles.ValueMember = "Id_Rol";
        }
        private void CargarUsuarios()
        {
            cboxUsuario.DataSource = usuario.ListarUsr();
            cboxUsuario.DisplayMember = "Nombre";
            cboxUsuario.ValueMember = "Id_Usuario";
        }

        public GestionPerfil()
        {
            InitializeComponent();
            TraerPerfiles();
            CargarUsuarios();
            ObervableLanguage.Instancia.Agregar(this);
            UpdateLanguage();
        }

        private void GestionPerfil_Load(object sender, EventArgs e)
        {
           
        }
       
        
        private DataTable TransformUserProfileNames(DataTable usersTable)
        {
            // Mapeo de IDs de perfil a nombres de perfil (puedes definir esto como un campo o método aparte)
            Dictionary<int, string> profileNames = new Dictionary<int, string>()
         {
       
         
        // Agrega más perfiles según tu estructura de datos
          };

            // Clonar el DataTable original para mantener la estructura
            DataTable transformedTable = usersTable.Clone();

            // Agregar columna de nombre de perfil al nuevo DataTable
            transformedTable.Columns.Add("NombrePerfil", typeof(string));

            // Recorrer cada fila del DataTable original
            foreach (DataRow row in usersTable.Rows)
            {
                int idPerfil = Convert.ToInt32(row["id_perfil"]);

                // Obtener el nombre del perfil correspondiente al ID
                if (profileNames.ContainsKey(idPerfil))
                {
                    string nombrePerfil = profileNames[idPerfil];

                    // Clonar la fila y agregar el nombre del perfil al nuevo DataTable
                    DataRow newRow = transformedTable.NewRow();
                    newRow.ItemArray = row.ItemArray; // Copiar datos de la fila original
                    newRow["NombrePerfil"] = nombrePerfil; // Agregar nombre del perfil
                    transformedTable.Rows.Add(newRow);
                }
            }

            return transformedTable;
        }

        private void cboxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAsignarPerfil_Click(object sender, EventArgs e)
        {
            try
            {
                bool existeCliente = usuario.VerificarPerfil((int)cboxPerfiles.SelectedValue,(int)cboxUsuario.SelectedValue);
                if (existeCliente)
                {
                    MessageBox.Show("El usuario ya tiene ese perfil asignado");
                    return;
                }
                else
                {
                    usuario.UpdateUserPerfil((int)cboxPerfiles.SelectedValue,(int)cboxUsuario.SelectedValue);
                    even.InsertarEvento(SessionManager.getProfile().Nombre, DateTime.Now, DateTime.Now.TimeOfDay, "Asignar Perfil User", "frmPerfil", 2, SessionManager.getProfile().Apellido, SessionManager.getProfile().UserName);
                    MessageBox.Show("Se ha asignado el perfil correctamente");
                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                MenuPrincipal mp = new MenuPrincipal();
                mp.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UpdateLanguage()
        {
            try
            {
                var Idioma = JObject.Parse(File.ReadAllText(@"C:\Users\agusr\source\repos\ProductosOSC\SERVICIOS\Lenguages\" + ObervableLanguage.Instancia.Idioma + ".json"));

                if (this.Name == "GestionPerfil")
                {
                    lblbuscaruser.Text = Idioma["GestionPerfil"]["lblbuscaruser"].ToString();
                    lblperfiles.Text = Idioma["GestionPerfil"]["lblperfiles"].ToString();
                    btnAsignarPerfil.Text = Idioma["GestionPerfil"]["btnasignarperfil"].ToString();
                    btnmenu.Text = Idioma["GestionPerfil"]["btnmenu"].ToString();
                    this.Text = Idioma["GestionPerfil"]["Text"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GestionPerfil_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
