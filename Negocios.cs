using BE.Entity;
using Interfaces;
using BLL;
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
using BLL.Negocio;

namespace ProductosOSC
{
    public partial class Negocios : Form,IObserver
    {
        private JsonManager _languageManager;
        BLL_Negocio neg = new BLL_Negocio();
        public Negocios()
        {
            InitializeComponent();
            ObervableLanguage.Instancia.Agregar(this);
            UpdateLanguage();
            ListarNegocios();
        }

        public void UpdateLanguage()
        {
            try
            {
                var Idioma = JObject.Parse(File.ReadAllText(@"C:\Users\agusr\source\repos\ProductosOSC\SERVICIOS\Lenguages\" + ObervableLanguage.Instancia.Idioma + ".json"));

                if (this.Name == "Negocios")
                {
                    btncrear.Text = Idioma["Negocios"]["btncrear"].ToString();
                    lblcuit.Text = Idioma["Negocios"]["lblcuit"].ToString();
                    lbldire.Text = Idioma["Negocios"]["lbldire"].ToString();
                    lblnegocio.Text = Idioma["Negocios"]["lblnegocio"].ToString();
                    lblnombre.Text = Idioma["Negocios"]["lblnombre"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Negocios_Load(object sender, EventArgs e)
        {

        }

        public void ListarNegocios()
        {
            try
            {
                 dgvNegocios.DataSource =  neg.Listar();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btncrear_Click(object sender, EventArgs e)
        {
            try
            {
                BE_Negocio negocio = new BE_Negocio();
                negocio.Direccion = txtdire.Text;
                negocio.Nombre = txtnombre.Text;
                negocio.CUIT = Convert.ToInt32(txtcuit.Text);
                neg.GuardarDato(negocio);
                MessageBox.Show("Negocio creado exitosamente");
                ListarNegocios();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
        }
    }
}
