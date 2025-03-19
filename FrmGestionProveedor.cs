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
    public partial class FrmGestionProveedor : Form
    {
        BLL_Proveedor  proveedor = new BLL_Proveedor();
        
        public FrmGestionProveedor()
        {
            InitializeComponent();
            ListarProvedores();
            CbxProveedor();
        }

        private void FrmGestionProveedor_Load(object sender, EventArgs e)
        {




        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            BE_Proveedor prov = new BE_Proveedor();
            try
            {
                prov.Apellido = txtapell.Text;
                prov.Nombre = txtnombre.Text;
                prov.Cuil = int.Parse(txtcuil.Text);
                prov.Direccion = txtdire.Text;
                prov.Telefono = int.Parse(txttel.Text);
                prov.DNI = int.Parse(txtdni.Text);

                proveedor.AgregarProveedor(prov.Nombre,prov.Apellido,prov.Direccion,prov.Telefono,prov.Cuil,prov.DNI);

                MessageBox.Show("Proveedor agregado correctamente");


                txtapell.Clear();
                txtnombre.Clear();
                txttel.Clear();
                txtdni.Clear();
                txtcuil.Clear();
                txtdire.Clear();
                



                ListarProvedores();
                CbxProveedor();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void CbxProveedor()
        {
            cbxdni.DataSource = proveedor.ListarProveedores();
            cbxdni.DisplayMember = "DNI";
            cbxdni.ValueMember = "DNI";
        }



        private void ListarProvedores()
        {
            dataGridView1.DataSource = proveedor.ListarProveedores();

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            try
            {
                proveedor.EliminarProv((int)cbxdni.SelectedValue);

                MessageBox.Show("Proveedor eliminado correctamente");

                CbxProveedor();
                ListarProvedores();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
