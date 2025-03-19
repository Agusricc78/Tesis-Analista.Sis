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
    public partial class ConfirmacionLogout : Form,IObserver
    {
        private JsonManager _languageManager;
        public ConfirmacionLogout()
        {
            InitializeComponent();
            ObervableLanguage.Instancia.Agregar(this);
            UpdateLanguage();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                SessionManager.Logout();
                MessageBox.Show("Sesión cerrada.");
                Application.Exit();
                this.Hide();

            }
            catch (Exception ex)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConfirmacionLogout_Load(object sender, EventArgs e)
        {

        }

        public void UpdateLanguage()
        {
            try
            {
                var Idioma = JObject.Parse(File.ReadAllText(@"C:\Users\agusr\source\repos\ProductosOSC\SERVICIOS\Lenguages\" + ObervableLanguage.Instancia.Idioma + ".json"));

                if (this.Name == "ConfirmacionLogout")
                {
                    btnsi.Text = Idioma["ConfirmacionLogout"]["btnsi"].ToString();
                    btnno.Text = Idioma["ConfirmacionLogout"]["btnno"].ToString();
                    lbldeseasalir.Text = Idioma["ConfirmacionLogout"]["lbldeseasalir"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ConfirmacionLogout_FormClosed(object sender, FormClosedEventArgs e)
        {
         
        }
    }
}
