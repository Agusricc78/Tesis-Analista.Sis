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
    public partial class Exit : Form,IObserver
    {
        private JsonManager _languageManager;
        public Exit()
        {
            InitializeComponent();
            ObervableLanguage.Instancia.Agregar(this);
            UpdateLanguage();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (SessionManager.getProfile().idioma == "es-Ar")
                {
                    MessageBox.Show("Sesión cerrada.");
                }
                if (SessionManager.getProfile().idioma == "es-US")
                {
                    MessageBox.Show("Session closed");
                }
                this.Hide();
                SessionManager.Logout();
                Login lo = new Login();
                lo.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal mp = new MenuPrincipal(); 
            mp.Show();
        }

        private void Exit_Load(object sender, EventArgs e)
        {

        }

        public void UpdateLanguage()
        {
            try
            {
                var Idioma = JObject.Parse(File.ReadAllText(@"C:\Users\agusr\source\repos\ProductosOSC\SERVICIOS\Lenguages\" + ObervableLanguage.Instancia.Idioma + ".json"));

               
                    btnsi.Text = Idioma["Exit"]["btnsi"].ToString();
                    btnno.Text = Idioma["Exit"]["btnno"].ToString();
                    lbldesearsalir.Text = Idioma["Exit"]["lbldeseasalir"].ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Exit_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
