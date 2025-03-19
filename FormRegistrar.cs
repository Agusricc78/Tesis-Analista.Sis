using BE.Entity;
using BLL.Negocio;
using DALL.Mappers;
using ProductosOSC.Validaciones;
using SERVICIOS.Security;
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
    public partial class FormRegistrar : Form
    {
        BLL_Usuario user = new BLL_Usuario();
      
        public FormRegistrar()
        {
            InitializeComponent();
           
        }

       

       

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                MenuPrincipal mr = new MenuPrincipal();
                mr.Show();

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
                this.Close();
                Application.Exit();
            }
            catch(Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Configurardgv()
        {



        }


        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            try
            {
                us.Nombre = txtnombre.Text;
                us.Contraseña = txtcontra.Text;
                us.Mail = MailEncript.Encrypt(txtmail.Text);
                us.Dni = int.Parse(txtDNI.Text);
                us.Estado = true;
                us.UserName = txtusername.Text;
                us.Apellido = txtapellido.Text;
                us.Bloqueo = false;
                

                if (!user.ValidarUser(us.Nombre))
                {
                    user.insertar(us);
                    MessageBox.Show("Se ha registrado exitosamente");

                    // Limpiar los campos después de la inserción
                    txtnombre.Text = "";
                    txtcontra.Text = "";
                    txtmail.Text = "";
                    txtDNI.Text = "";
                    txtusername.Text = "";
                    txtapellido.Text = "";

                    this.Hide();
                    Login lg = new Login();
                    lg.Show();
                }
                else
                {
                    MessageBox.Show("El usuario ingresado ya existe");

                    txtnombre.Text = "";
                    txtcontra.Text = "";
                    txtmail.Text = "";
                    txtDNI.Text = "";
                    txtusername.Text = "";
                    txtapellido.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbxRol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormRegistrar_Load(object sender, EventArgs e)
        {

        }

        private void cbxroles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
