using BE.Entity;
using BLL.Negocio;
using SERVICIOS;
using SERVICIOS.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProductosOSC
{
    public partial class Login : Form
    {
        BLL_Usuario bll_usu = new BLL_Usuario();
        SessionManager sm = new SessionManager();
        BLL_BitacoraEvento even = new BLL_BitacoraEvento();
        public Login()
        {
            InitializeComponent();
            txtcontra.UseSystemPasswordChar = true;
            
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

      


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private int intentosFallidos = 0;
        private const int intentosMax = 3;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            
            try
            {
                us.UserName = txtusername.Text;
                us.Contraseña = txtcontra.Text;
                    var usr = bll_usu.autenticar(txtusername.Text, PasswordEncript.EncriptarContraseña(txtcontra.Text, txtusername.Text));
                
                    if (usr.Rows.Count > 0)
                    {
                    bool usuarioBloqueado = bll_usu.VerificarEstadoBloqueo(txtusername.Text);

                    if (usuarioBloqueado)
                    {
                        MessageBox.Show("Su cuenta está bloqueada. Por favor, contacte al administrador.");
                        return;
                    }
                        Usuario usuarioSesion = new Usuario();
                        sm.Login(us.UserName);
                        
                    
                even.InsertarEvento(SessionManager.getProfile().Nombre, DateTime.Now, DateTime.Now.TimeOfDay, "Login", "frmLogin", 1, SessionManager.getProfile().Apellido, SessionManager.getProfile().UserName);  
                        DataRow Usuario = usr.Rows[0];

                        MessageBox.Show("Bienvenido   " + Usuario["Nombre"].ToString());
                        this.Hide();
                    usuarioSesion = SessionManager.getProfile();
                    string IdiomaUsuario = usuarioSesion.idioma;
                    ObervableLanguage.Instancia.Idioma = IdiomaUsuario ?? "es-AR"; // Usa "es-ES" si el idioma es nulo
                    MenuPrincipal mp = new MenuPrincipal();
                        mp.Nombre_Usuario = txtusername.Text;
                        mp.Show();
                    }
                    else
                    {
                    intentosFallidos++;

                    
                    if (intentosFallidos >= intentosMax)
                    {
                        Usuario  usuario = new Usuario();
                        usuario.Nombre = txtusername.Text;
                        usuario.Bloqueo = true;
                      
                       
                       bll_usu.Bloquear(usuario.Nombre);
                        
                            MessageBox.Show("Se ha bloqueado su cuenta debido a múltiples intentos fallidos de inicio de sesión.");
                        
                       
                    }
                    MessageBox.Show("Usuario o contraseña incorrecto");
                    }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FormRegistrar formRegistrar = new FormRegistrar();
                formRegistrar.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                CambiarContraseña cr = new CambiarContraseña();
                cr.Show();
            }
            catch(Exception ex ) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
