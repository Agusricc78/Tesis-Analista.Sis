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
    public partial class Productos : Form,IObserver
    {

        private JsonManager _languageManager;
        BLL_Producto blpro =  new BLL_Producto();
        public Productos()
        {
            InitializeComponent();
            ObervableLanguage.Instancia.Agregar(this);
            UpdateLanguage();
        }

        private void CargarProductos()
        {
            dgvpro.DataSource = blpro.ListarProductos();
        }


        private void MostrarxCategoria()
        {



        }



        private void guna2Button2_Click(object sender, EventArgs e)
        {
           BE_Producto pr = new BE_Producto();

            try
            {
                pr.Tamaño = int.Parse(txttamanio.Text);
                pr.Categoria = cbxtipo.Text;
                pr.Modelo = txtmodelo.Text;
                pr.Precio = int.Parse(txtprecio.Text);
                pr.Marca = txtmarca.Text;
                pr.Stock = int.Parse(txtstock.Text);

                blpro.AgregarProducto(pr);

                MessageBox.Show("El producto se ha agregado correctamente");

                txtmarca.Text = "";
                txtmodelo.Text = "";
                txtprecio.Text = "";
                txttamanio.Text = "";
                cbxtipo.Text = "";
                CargarProductos();
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void Productos_Load(object sender, EventArgs e)
        {
                        

        }

        private void dgvpro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                CargarProductos();

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxEliminarPro.DataSource = blpro.ListarProductosXId();

        }

        public void UpdateLanguage()
        {
            try
            {
                var Idioma = JObject.Parse(File.ReadAllText(@"C:\Users\agusr\source\repos\ProductosOSC\SERVICIOS\Lenguages\" + ObervableLanguage.Instancia.Idioma + ".json"));

               
                    lblproductos.Text = Idioma["Productos"]["lblproductos"].ToString();
                    lblagregar.Text = Idioma["Productos"]["lblagregar"].ToString();
                    lblMarca.Text = Idioma["Productos"]["lblmarca"].ToString();
                    lbltamaño.Text = Idioma["Productos"]["lbltamaño"].ToString();
                    lblmodelo.Text =Idioma["Productos"]["lblmodelo"].ToString();
                    lbltipo.Text = Idioma["Productos"]["lbltipo"].ToString();
                    lblprecio.Text = Idioma["Productos"]["lblprecio"].ToString();
                    lblstock.Text = Idioma["Productos"]["lblstock"].ToString();
                    btnagregarproducto.Text = Idioma["Productos"]["btnagregarproducto"].ToString();
                    btnactualizarlista.Text = Idioma["Productos"]["btnactualizarlista"].ToString();
                    btnmenu.Text = Idioma["Productos"]["btnmenu"].ToString();
                    lbllistadeproductos.Text = Idioma["Productos"]["lbllistadeproductos"].ToString();
                    this.Text = Idioma["Productos"]["Text"].ToString();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Productos_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
