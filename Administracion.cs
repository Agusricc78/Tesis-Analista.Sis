using BE.Entity;
using BLL.Negocio;
using Interfaces;
using iRely.Common;
using Newtonsoft.Json.Linq;
using Org.BouncyCastle.Asn1.Mozilla;
using SERVICIOS;
using SERVICIOS.Lenguages;
using SERVICIOS.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace ProductosOSC
{
    public partial class Administracion : Form,IObserver
    {
       
        BLL_Usuario user = new BLL_Usuario();
       
        private JsonManager _languageManager;

        DataTable rolesDataTable;
        public Administracion()
        {
            InitializeComponent();
            ObervableLanguage.Instancia.Agregar(this);
            UpdateLanguage();
            Limpiarcontroles();
           
        }

        public void UpdateLanguage()
        {
            try
            {
                var Idioma = JObject.Parse(File.ReadAllText(@"C:\Users\agusr\source\repos\ProductosOSC\SERVICIOS\Lenguages\" + ObervableLanguage.Instancia.Idioma + ".json"));

                if (this.Name == "Administracion")
                {
                    lblgestionuser.Text = Idioma["Administracion"]["lblgestionuser"].ToString();
                    lbltodosuser.Text = Idioma["Administracion"]["lbltodosuser"].ToString();
                    lblnombre.Text = Idioma["Administracion"]["lblnombre"].ToString();
                    lblapellido.Text = Idioma["Administracion"]["lblapellido"].ToString();
                    lbldni.Text = Idioma["Administracion"]["lbldni"].ToString();
                    lblcontra.Text = Idioma["Administracion"]["lblcontra"].ToString();
                    lbluser.Text = Idioma["Administracion"]["lbluser"].ToString();
                    lblmail.Text = Idioma["Administracion"]["lblmail"].ToString();
                    chxactivos.Text = Idioma["Administracion"]["chxactivos"].ToString();
                    chxencript.Text = Idioma["Administracion"]["chxencript"].ToString();
                    chxtodos.Text = Idioma["Administracion"]["chxtodos"].ToString();
                    btnañadir.Text = Idioma["Administracion"]["btnañadir"].ToString();
                    btnmodificar.Text = Idioma["Administracion"]["btnmodificar"].ToString();
                    btneliminar.Text = Idioma["Administracion"]["btneliminar"].ToString();
                    btnactivar.Text = Idioma["Administracion"]["btnactivar"].ToString();
                    btndesactivar.Text = Idioma["Administracion"]["btndesactivar"].ToString();
                    btndesbloquear.Text = Idioma["Administracion"]["btndesbloquear"].ToString();
                    btnbloquear.Text = Idioma["Administracion"]["btnbloquear"].ToString();
                    btnsalir.Text = Idioma["Administracion"]["btnsalir"].ToString();
                    btnmenu.Text = Idioma["Administracion"]["btnmenu"].ToString();
                    btnlogin.Text = Idioma["Administracion"]["btnlogin"].ToString();
                    lblmensaje.Text = Idioma["Administracion"]["lblmensaje"].ToString();
                    lblretro.Text = Idioma["Administracion"]["lblretro"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void mostrarusuarios()
        {
            guna2DataGridView1.DataSource = user.ListarUsr();
        }

        private void CargarUsuarios()
        {
            try
            {
                DataTable us = user.ListarUsr();

                // Añadir una nueva columna para almacenar los correos desencriptados
                us.Columns.Add("MailDesencriptado", typeof(string));

                foreach (DataRow row in us.Rows)
                {
                    string emailEncriptado = row["Mail"].ToString();
                    string emailDesencriptado;

                    try
                    {
                        emailDesencriptado = MailEncript.Decrypt(emailEncriptado);
                    }
                    catch (Exception ex)
                    {
                        emailDesencriptado = "Error al desencriptar"; // Puedes personalizar este mensaje
                        MessageBox.Show($"Error al desencriptar el correo: {ex.Message}");
                    }

                    row["MailDesencriptado"] = emailDesencriptado;
                }

                guna2DataGridView1.DataSource = us;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ConfigureDataGridView()
        {
            guna2DataGridView1.ReadOnly = true;


            guna2DataGridView1.Enabled = false;
            guna2DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Administracion_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.Dni = int.Parse(txtdni.Text);

            try
            {
                user.EliminarUsuario(us.Dni);
                CargarUsuarios();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {



            Usuario us = new Usuario();
            try
            {
                

                us.Nombre = txtnombre.Text;
                us.Contraseña = txtcontra.Text;
                us.Mail = MailEncript.Encrypt(txtmail.Text);
               
                us.Dni = int.Parse(txtdni.Text);
                us.Estado = true;
                us.Apellido = txtapellido.Text;
                us.UserName = txtUsername.Text;


                user.insertar(us);

                MessageBox.Show("Se ha registrado exitosamente");

                txtUsername.Text = "";
                txtapellido.Text = "";
                txtnombre.Text = "";
                txtcontra.Text = "";
                txtmail.Text = "";
                txtdni.Text = "";
               

                CargarUsuarios();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.Dni = int.Parse(txtdni.Text);
            try
            {
                user.Desactivar(us.Dni);
                CargarUsuarios();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            

            
        }


        private void Limpiarcontroles()
        {

            txtUsername.Text = "";
            txtapellido.Text = "";
            txtnombre.Text = "";
            txtcontra.Text = "";
            txtmail.Text = "";
            txtdni.Text = "";
         
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario(); 
            try
            {
                us.Dni = int.Parse(txtdni.Text);
                user.Activar(us.Dni);
                CargarUsuarios();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chxactivos.Checked)
            {
                guna2DataGridView1.DataSource = user.MostrarActivos();
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chxtodos.Checked)
            {
                CargarUsuarios();

            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.UserName = txtUsername.Text;
            try
            {
                user.Desbloquear(txtUsername.Text);
                CargarUsuarios();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Login lo = new Login();
                lo.Show();

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);    
            }
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                ConfirmacionLogout cl = new ConfirmacionLogout();
                cl.Show();
           
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button7_Click_1(object sender, EventArgs e)
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

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { 
            Usuario us = new Usuario();
            
            try
            {
                us.Nombre = txtnombre.Text;
                us.Apellido = txtapellido.Text;
                
                us.Dni = int.Parse(txtdni.Text);
                us.Mail =MailEncript.Encrypt(txtmail.Text);
                us.UserName = txtUsername.Text;

                user.ModificarUsuario(us.Dni, us.UserName, us.Nombre, us.Apellido,us.Mail);

                MessageBox.Show("Se ha modificado exitosamente");

                txtUsername.Text = "";
                txtapellido.Text = "";
                txtnombre.Text = "";
                txtcontra.Text = "";
                txtmail.Text = "";
                txtdni.Text = "";
               

                CargarUsuarios();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.UserName = txtUsername.Text;
            us.Bloqueo = true;
            try
            {

                user.Bloquear(us.UserName);
                CargarUsuarios();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];

                txtnombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
                txtapellido.Text = selectedRow.Cells["Apellido"].Value.ToString();
                txtUsername.Text = selectedRow.Cells["UserName"].Value.ToString();
                txtmail.Text = selectedRow.Cells["Mail"].Value.ToString();
                txtdni.Text = selectedRow.Cells["Dni"].Value.ToString();
                
               
                
            }
        }

        private void cbxrol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (chxencript.Checked)
            {
                mostrarusuarios();

            }
        }

        private void Administracion_onFormClosed(object sender, FormClosedEventArgs e)
        {
            
        }



    }
}
