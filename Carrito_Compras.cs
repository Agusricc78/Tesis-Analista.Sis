using BE.Entity;
using BLL.Negocio;
using Interfaces;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;
using SERVICIOS.Lenguages;
using SERVICIOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;

namespace ProductosOSC
{
    public partial class Carrito_Compras : Form, IObserver
    {
        private JsonManager _languageManager;
        BLL_Producto blpro = new BLL_Producto();
        BLL_Usuario us = new BLL_Usuario();
        BLL_Carrito_ carr = new BLL_Carrito_();
        BLL_Cliente bl_cliente = new BLL_Cliente();
        BLL_BitacoraEvento even = new BLL_BitacoraEvento();
        public Carrito_Compras()
        {
          
            InitializeComponent();
            cargardgv();
            CargarNombres();
            txtfecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            ObervableLanguage.Instancia.Agregar(this);
            UpdateLanguage();
            
        }

        private void CargarNombres()
        {
            cbxClientesNom.DataSource = bl_cliente.ListarClientes();
            cbxClientesNom.DisplayMember = "Nombre";
            cbxClientesNom.ValueMember = "Id_Cliente";
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      private void cargardgv()
        {
            dgvProductos.DataSource = blpro.ListarProductos();
            dgvProductos.Columns["Id_Producto"].Visible = false;
        }

     private void cargarcarrito()
        {
            cbxcarrito.DataSource = carr.ListarCarritos();
            cbxcarrito.DisplayMember = "Id";
            cbxcarrito.ValueMember = "Id";
        }
      
        private void Carrito_Compras_Load(object sender, EventArgs e)
        {
            cbxcategorias.DataSource = blpro.ListarProductos();
            cbxcategorias.DisplayMember = "Modelo";
            cbxcategorias.ValueMember = "Id_Producto";
        }

       
        private void TotalCarrito()
        {
            lblTotalCarrito.Text = carr.TotalCarrito(Convert.ToInt32(cbxcarrito.SelectedValue)).ToString();

        }



        private void CargarCarritos()
        {
            try
            {
                DataTable data = carr.ListarCarritos();
                if (data.Rows.Count > 0)
                {
                    DataRow row = data.Rows[0];
                    lblCarritoId.Text = row["Id"].ToString();
                    

                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void cbfragancia_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                
                dgvProductos.DataSource = blpro.Listarfragancias();
            }
              catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {

                carr.AgregarProducto(int.Parse(lblCarritoId.Text), (int)NumCantidad.Value,(int)cbxcategorias.SelectedValue);
                even.InsertarEvento(SessionManager.getProfile().Nombre, DateTime.Now, DateTime.Now.TimeOfDay, "Agregar producto carrito", "frmCarrito", 5, SessionManager.getProfile().Apellido, SessionManager.getProfile().UserName);
                MessageBox.Show("El producto se ha agregado al carrito correctamente");
                cargardgv();
                
                cargarcarrito();

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
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

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            try
            {

                this.Hide();
                RegistrarCliente rc = new RegistrarCliente();
                rc.Show();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2ComboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxcategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            BE_Carrito carrito = new BE_Carrito();
            
            try
            {
                carrito.FechaCierre = txtfecha.Text;
                carrito.Subtotal = 0;
                carrito.Impuestos = 0;
                carrito.Estado = cbxEstado.Text;
                carrito.Id_Usuario = SessionManager.getProfile().Id_Usuario;
                carrito.Total = 0;
                carrito.Id_Cliente = (int)cbxClientesNom.SelectedValue;

                carr.CrearCarrito(carrito.FechaCierre,carrito.Impuestos,carrito.Subtotal,carrito.Estado,carrito.Id_Usuario,carrito.Total,carrito.Id_Cliente);

                MessageBox.Show("Se ha creado el carrito con exito");

                CargarCarritos();
                even.InsertarEvento(SessionManager.getProfile().UserName, DateTime.Now, DateTime.Now.TimeOfDay, "Crear Carrito", "frmCarritoCompra", 5, SessionManager.getProfile().Apellido, SessionManager.getProfile().UserName);
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
                
        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void cbxIdCarrito_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            BE_Carrito car = new BE_Carrito();
            try
            {

                car.Id_Carrito = (int)cbxcarrito.SelectedValue;

               dgvcarrito.DataSource =  carr.ListarProductosCarrito(car.Id_Carrito);
                TotalCarrito();
                even.InsertarEvento(SessionManager.getProfile().Nombre, DateTime.Now, DateTime.Now.TimeOfDay, "Listar productos al carrito", "frmCarrito", 5, SessionManager.getProfile().Apellido, SessionManager.getProfile().UserName);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {

                carr.Cerrar((int)cbxcarrito.SelectedValue);
                MessageBox.Show("Tu carrito ha sido finalizado");
                CargarCarritos();

                this.Hide();
                FrmDespacho frm = new FrmDespacho();
                frm.Show();
                even.InsertarEvento(SessionManager.getProfile().Nombre, DateTime.Now, DateTime.Now.TimeOfDay, "Cerrar carrito", "frmCarrito", 5, SessionManager.getProfile().Apellido, SessionManager.getProfile().UserName);
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

                if (this.Name == "Carrito_Compras")
                {
                    this.Text = Idioma["Carrito_Compras"]["Text"].ToString();
                    lblcrearcarrito.Text = Idioma["Carrito_Compras"]["lblcrearcarrito"].ToString();
                    lblestado.Text = Idioma["Carrito_Compras"]["lblestado"].ToString();
                    lblfecha.Text = Idioma["Carrito_Compras"]["lblfecha"].ToString();
                    lblcliente.Text = Idioma["Carrito_Compras"]["lblcliente"].ToString();
                    lblpro.Text = Idioma["Carrito_Compras"]["lblpro"].ToString();
                    lblllenarcarito.Text = Idioma["Carrito_Compras"]["lblllenarcarrito"].ToString();
                    lblcantidad.Text = Idioma["Carrito_Compras"]["lblcantidad"].ToString();
                    lblidcarrito.Text = Idioma["Carrito_Compras"]["lblidcarrito"].ToString();
                    btnagregarproducto.Text = Idioma["Carrito_Compras"]["btnagregarproducto"].ToString();
                    lblmostrarcarrito.Text = Idioma["Carrito_Compras"]["lblmostrarcarrito"].ToString();
                    lblmostrarcarritoporid.Text = Idioma["Carrito_Compras"]["lblmostrarcarritoporid"].ToString();
                    lbltotcarrito.Text = Idioma["Carrito_Compras"]["lbltotcarrito"].ToString();
                    btnmostrarcarrito.Text = Idioma["Carrito_Compras"]["btnmostrarcarrito"].ToString();
                    btnfinalizarcarrito.Text = Idioma["Carrito_Compras"]["btnfinalizarcarrito"].ToString();
                    btnregistrarcliente.Text = Idioma["Carrito_Compras"]["btnregistrarcliente"].ToString();
                    btnmenu.Text = Idioma["Carrito_Compras"]["btnmenu"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Carrito_Compras_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
