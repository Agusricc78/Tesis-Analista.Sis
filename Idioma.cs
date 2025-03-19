using BLL.Negocio;
using DALL.Mappers;
using Interfaces;
using Newtonsoft.Json.Linq;
using ServiceStack;
using SERVICIOS;
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
    public partial class Idioma : Form,IObserver
    {
        BLL_Usuario user = new BLL_Usuario();
        BLL_Idiomas idio = new BLL_Idiomas();

        string idiomaSeleccionado;
        private string _rutaArchivoJson;

        public Idioma()
        {
            InitializeComponent();
            ObervableLanguage.Instancia.Agregar(this);
            UpdateLanguage();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
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

                if (this.Name == "Idioma")
                {
                    this.Text = Idioma["Idioma"]["Text"].ToString();
                    lblIdioma.Text = Idioma["Idioma"]["lblIdioma"].ToString();
                    btnaplicar.Text = Idioma["Idioma"]["btnaplicar"].ToString();
                    btnmenu.Text = Idioma["Idioma"]["btnmenu"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
       

        private void CargarIdiomas()
        {
            cboxIdioma.DataSource = idio.Idiomas();
            cboxIdioma.DisplayMember = "Nombre";
            cboxIdioma.ValueMember = "Id_Idioma";
        }

        private void Idioma_Load(object sender, EventArgs e)
        {
            
        }

        private void cboxIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void materialbutton1_Click(object sender, EventArgs e)
        {
            try
            {
                ObervableLanguage.Instancia.Idioma = idiomaSeleccionado;
                user.ActualizarIdioma(idiomaSeleccionado);
                UpdateLanguage();
                MessageBox.Show("Idioma cambiado correctamente");
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

      




       

        private void cboxIdioma_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string idioma = cboxIdioma.SelectedItem.ToString();

                // Asignar la ruta del archivo JSON según el idioma seleccionado
                switch (idioma)
                {
                    case "Español":
                        idiomaSeleccionado = "es-AR";
                        _rutaArchivoJson = @"C:\Users\agusr\source\repos\ProductosOSC\SERVICIOS\Lenguages\es-AR.json";
                        break;
                    case "Ingles":
                        idiomaSeleccionado = "es-US";
                        _rutaArchivoJson = @"C:\Users\agusr\source\repos\ProductosOSC\SERVICIOS\Lenguages\es-US.json"; // Asumiendo que tienes un archivo para inglés
                        break;
                    default:
                        idiomaSeleccionado = "es-AR";
                        _rutaArchivoJson = @"C:\Users\agusr\source\repos\ProductosOSC\SERVICIOS\Lenguages\es-AR.json";
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}
