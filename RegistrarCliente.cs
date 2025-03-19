using BE.Entity;
using BLL.Negocio;
using SERVICIOS;
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
    public partial class RegistrarCliente : Form
    {
        BLL_Cliente bl_cl = new BLL_Cliente();
        BLL_BitacoraEvento even = new BLL_BitacoraEvento();
        public RegistrarCliente()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            BE_Cliente cliente = new BE_Cliente();  
            try
            {
                cliente.Nombre = TxtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.DNI = int.Parse(txtdni.Text);
                cliente.Telefono = int.Parse(txttel.Text);
                 
                bl_cl.AgregarCliente(cliente);

                MessageBox.Show("El cliente se ha registrado corectamente");
                even.InsertarEvento(SessionManager.getProfile().Nombre, DateTime.Now, DateTime.Now.TimeOfDay, "Registro de Cliente", "frmRegCliente", 2, SessionManager.getProfile().Apellido, SessionManager.getProfile().UserName);
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
                this.Hide();
                Carrito_Compras cr = new Carrito_Compras();
                cr.Show();
            
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
