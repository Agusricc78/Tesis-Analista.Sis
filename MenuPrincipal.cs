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
    public partial class MenuPrincipal : Form,IObserver
    {
        VerificadorPermisos ver = new VerificadorPermisos();
        JsonManager idioma;
        private string nombre_Usuario;
        BLL_Usuario us = new BLL_Usuario();
        public string Nombre_Usuario
        {
            get { return nombre_Usuario; }
            set { nombre_Usuario = value; }
        }

      

        public MenuPrincipal()
        {
            InitializeComponent();
            lblUserName.Text = SessionManager.getProfile().UserName;
            ObervableLanguage.Instancia.Agregar(this);
            UpdateLanguage();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
        public void UpdateLanguage()
        {
            try
            {
                var Idioma = JObject.Parse(File.ReadAllText(@"C:\Users\agusr\source\repos\ProductosOSC\SERVICIOS\Lenguages\" + ObervableLanguage.Instancia.Idioma + ".json"));

               
                    // Actualizar los textos de los controles del formulario MenuPrincipal
                    Text = Idioma["MenuPrincipal"]["Text"].ToString();
                    btnpermiso.Text = Idioma["MenuPrincipal"]["btnpermiso"].ToString();
                    btnAdministracion.Text = Idioma["MenuPrincipal"]["btnAdministracion"].ToString();
                    btncarrito.Text = Idioma["MenuPrincipal"]["btncarrito"].ToString();
                    btnproducto.Text = Idioma["MenuPrincipal"]["btnproducto"].ToString();
                    btnfacturas.Text = Idioma["MenuPrincipal"]["btnfacturas"].ToString();
                    btnreportes.Text = Idioma["MenuPrincipal"]["btnreportes"].ToString();
                    btnayuda.Text = Idioma["MenuPrincipal"]["btnayuda"].ToString();
                    btnlogout.Text = Idioma["MenuPrincipal"]["btnlogout"].ToString();
                    btngestionperfiles.Text = Idioma["MenuPrincipal"]["btngestionperfiles"].ToString();
                    btnIdiomafrm.Text = Idioma["MenuPrincipal"]["btnidiomafrm"].ToString();
                    btnregistro.Text = Idioma["MenuPrincipal"]["btnregistro"].ToString();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

        }




        /*public bool verificar()
        {
            try {

                if(ver.TienePermiso(2) == true)
                {
                    MessageBox.Show("Tiene los permisos necesarios.");
                    return true;
                }
                else
                {
                    MessageBox.Show("No tiene los permisos necesarios, contactese con el administrador del sistema.");
                    return false;
                }

                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
          */

        private void guna2HScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
         
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificadorPermisos.TienePermiso(32))
                {
                    this.Hide();
                    Administracion admin = new Administracion();
                    admin.Show();
                }
                else 
                {
                    MessageBox.Show("No tiene los permisos necesarios para acceder a este formulario");
                }
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (VerificadorPermisos.TienePermiso(49))
                {
                    this.Hide();
                    FormRegistrar fr = new FormRegistrar();
                    fr.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            
         

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                
                this.Hide();
                Exit ex = new Exit();
                ex.Show();


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
                if (VerificadorPermisos.TienePermiso(35))
                {
                    this.Hide();
                    Productos pr = new Productos();
                    pr.Show();
                }
                  
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
                if(VerificadorPermisos.TienePermiso(33))
                {
                    this.Hide();
                    Carrito_Compras cr = new Carrito_Compras();
                    cr.Show();
                }
                else
                {
                    MessageBox.Show("No tiene los permisos necesarios para acceder a este modulo.");
                }


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
                if (VerificadorPermisos.TienePermiso(32))
                {
                    this.Close();
                    Permisos p = new Permisos();
                    p.Show();
                }
                else
                {
                    MessageBox.Show("El usuario no tiene los permisos necesarios para entrar a este modulo.");
                }
              
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
                if (VerificadorPermisos.TienePermiso(45))
                {
                    this.Hide();
                    FrmDespacho frm = new FrmDespacho();
                    frm.Show();
                }
              else
                {
                    MessageBox.Show("El usuario no tiene los permisos necesarios para entrar a este modulo.");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            try
            {

                 if (VerificadorPermisos.TienePermiso(34))
                  {
                      this.Hide();
                      GestionPerfil gf = new GestionPerfil();
                      gf.Show();
                  }
                  else
                  {
                      MessageBox.Show("El usuario no tiene los permisos necesarios para entrar a este modulo.");
                  }
                

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Idioma idioma = new Idioma();
                idioma.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       



        private void Idioma_Load(object sender, EventArgs e)
        {
            
            
        }

        private void cboxIdioma_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
        
      

       
        private void btnidioma_Click(object sender, EventArgs e)
        {
           
        }

        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuPrincipal_OnFormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            try
            {
                if (VerificadorPermisos.TienePermiso(53))
                {
                    this.Hide();
                    FrmDespacho des = new FrmDespacho();
                    des.Show();
                }
                else
                {
                    MessageBox.Show("No tiene los permisos necesarios para acceder");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button1_Click_3(object sender, EventArgs e)
        {
            try
            {
                BackUpRestore bp = new BackUpRestore();
                bp.Show();
                this.Hide();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Serializacion sr = new Serializacion();
                sr.Show();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                BitacoraEventos be = new BitacoraEventos();
                be.Show();
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                FrmGestionProveedor prov = new FrmGestionProveedor();
                prov.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button5_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                Solicitaar_Cot sol = new Solicitaar_Cot();
                sol.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
