using BE.Entity;
using BLL.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductosOSC
{
    public partial class Solicitaar_Cot : Form
    {
        BLL_Producto prod = new BLL_Producto();
        BLL_Cotizacion cotizacion = new BLL_Cotizacion();

        public Solicitaar_Cot()
        {
            InitializeComponent();
            ListarCot();
        }

        private void Solicitaar_Cot_Load(object sender, EventArgs e)
        {
            cbxProducto.DataSource = prod.ListarProductos();
            cbxProducto.DisplayMember = "Cod_Prod";
            cbxProducto.ValueMember = "Id_Producto";
            
        }

       
        private void ListarCot()
        {
            cbxId_Cot.DataSource = cotizacion.ListarCotizaciones();
            cbxId_Cot.DisplayMember = "Id_Cotizacion";
            cbxId_Cot.ValueMember = "Id_Cotizacion";
        }



        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                Productos pr = new Productos();
                pr.Show();
                this.Hide();

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            try
            {
                FrmGestionProveedor prov = new FrmGestionProveedor();
                prov.Show();
                this.Hide();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ListarProductos()
        {
            dgvCot.DataSource = cotizacion.ListarProductosCotizaciones((int)cbxId_Cot.SelectedValue);
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                cotizacion.InsertarRelacion((int)cbxProducto.SelectedValue, (int)cbxId_Cot.SelectedValue, int.Parse(txtCant.Text));
                MessageBox.Show("Se ha agregado el producto al carrito");

                ListarProductos();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            try
            {
                cotizacion.InsertarCotizacion("En Proceso",false,false,false);

                MessageBox.Show("Cotizacion creada correctamente");
                ListarCot();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
            this.Hide();
            
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            try
            {
                cotizacion.ModificarCot((int)cbxId_Cot.SelectedValue, DateTime.Now, (string)cbxpago.SelectedItem, true);
                MessageBox.Show("Se ha enviado la cotizacion con exito");
                ListarCot();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxId_Cot_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
