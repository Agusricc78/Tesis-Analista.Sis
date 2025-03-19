using BE.Entity;
using BLL.Negocio;
using Interfaces;
using Newtonsoft.Json.Linq;
using SERVICIOS;
using SERVICIOS.Lenguages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosOSC
{
    public partial class CambiarContraseña : Form,IObserver
    {
        ObervableLanguage ob;
        BLL_Usuario user = new BLL_Usuario();
        private JsonManager _languageManager;

        public CambiarContraseña()
        {
            InitializeComponent();
            ObervableLanguage.Instancia.Agregar(this);
            UpdateLanguage();
        }

        public void UpdateLanguage()
        {
            try
            {
                var Idioma = JObject.Parse(File.ReadAllText(@"C:\Users\agusr\source\repos\ProductosOSC\SERVICIOS\Lenguages\" + ObervableLanguage.Instancia.Idioma + ".json"));

                if (this.Name == "CambiarContraseña")
                {
                    this.Text = Idioma["Cambiar Contraseña"]["Text"].ToString();
                    Dni.Text = Idioma["Cambiar Contraseña"]["Dni"].ToString();
                    btncambiarclave.Text = Idioma["Cambiar Contraseña"]["btncambiarclave"].ToString();
                    btnlogin.Text = Idioma["Cambiar Contraseña"]["btnlogin"].ToString();
                    btnsalir.Text = Idioma["Cambiar Contraseña"]["btnsalir"].ToString();
                    lblcontraseña.Text = Idioma["Cambiar Contraseña"]["lblcontraseña"].ToString();
                    lblconfirmar.Text = Idioma["Cambiar Contraseña"]["lblconfirmar"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();

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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.Nombre = txtnombre.Text;
            us.Contraseña = txtcontra.Text;
            us.Dni = int.Parse(txtdni.Text);
            try
            {
                user.CambiarClave(us.Dni, us.Nombre, us.Contraseña);
                if (SessionManager.getProfile().idioma == "es-Ar")
                {
                    MessageBox.Show("Sesión cerrada.");
                }
                if (SessionManager.getProfile().idioma == "es-US")
                {
                    MessageBox.Show("Session closed");
                }
                MessageBox.Show("La contraseña se ha cambiado correctamente");
                
                this.Hide();
                Login lg = new Login();
                lg.Show();
                
                
            }
            catch(Exception ex ) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CambiarContraseña_Load(object sender, EventArgs e)
        {

        }

       
    }
}
