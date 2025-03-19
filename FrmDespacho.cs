using BLL.Negocio;
using iTextSharp.text.pdf;
using iTextSharp.text;
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
using Interfaces;
using SERVICIOS;
using SERVICIOS.Lenguages;
using Newtonsoft.Json.Linq;
using BE.Entity;
using iTextSharp.tool.xml;
using iText.Kernel.Events;

namespace ProductosOSC
{
    public partial class FrmDespacho : Form,IObserver
    {
        BLL_Carrito_ cr = new BLL_Carrito_();
        private JsonManager _languageManager;
        BLL_Negocio neg = new BLL_Negocio();
        BLL_Carrito_ carri = new BLL_Carrito_();
        BLL_BitacoraEvento even = new BLL_BitacoraEvento();
        public FrmDespacho()
        {
            InitializeComponent();
            MostrarVentas();
            ObervableLanguage.Instancia.Agregar(this);
            UpdateLanguage();
        }

        private void MostrarVentas()
        {
            dgvVentas.DataSource = cr.MostrarCarritosFinalizados();

        }

      

        




        private void GenerarFactura(int idCarrito)
        {
            DataTable detallesCarrito = cr.GenerarFactura(idCarrito);
            
            if (detallesCarrito.Rows.Count > 0)
            {
                DataRow row = detallesCarrito.Rows[0];

                // Cargar el HTML base desde un archivo dentro del proyecto
                string htmlTemplate = File.ReadAllText("C:\\Users\\agusr\\source\\repos\\ProductosOSC\\ProductosOSC\\Factura.html");

                // Reemplazar los placeholders con los valores reales
                htmlTemplate = htmlTemplate.Replace("@nombrenegocio", "ProductosOSC")
                                           .Replace("@docnegocio", "23-45242-2342")
                                           .Replace("@direcnegocio", "San Martin 1231")
                                           .Replace("@tipodocumento", "Factura A")
                                           .Replace("@nombrecliente", $"{row["NombreCliente"]} {row["Apellido"]}")
                                           .Replace("@fecharegistro", row["FechaCierre"].ToString())
                                           .Replace("@Estado", row["EstadoCierre"].ToString())
                                           .Replace("@subtotal", row["Subtotal"].ToString())
                                           .Replace("@Impuestos", row["Impuestos"].ToString())
                                           .Replace("@total", row["Total"].ToString())
                                           .Replace("@DniCliente", row["DNICliente"].ToString())
                                           .Replace("@TelefonoCliente", row["TelefonoCliente"].ToString())
                                           .Replace("@usuarioregistro", row["NombreVendedor"].ToString());
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                    saveFileDialog.Title = "Guardar Factura";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (MemoryStream ms = new MemoryStream())
                        {
                            // Crear el documento PDF
                            Document document = new Document();
                            PdfWriter writer = PdfWriter.GetInstance(document, ms);
                            document.Open();

                            using (StringReader sr = new StringReader(htmlTemplate))
                            {
                                XMLWorkerHelper.GetInstance().ParseXHtml(writer, document, sr);
                            }

                            document.Close();

                            // Guardar el archivo PDF en la ruta seleccionada
                            File.WriteAllBytes(saveFileDialog.FileName, ms.ToArray());

                            MessageBox.Show($"Factura generada y guardada en: {saveFileDialog.FileName}");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No se encontraron detalles para el carrito especificado.");
            }
        }

        private void FrmDespacho_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                MenuPrincipal mp = new MenuPrincipal();
                mp.Show();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btnfactura_Click(object sender, EventArgs e)
        {
            if (dgvVentas.SelectedRows.Count > 0)
            {
                int idCarrito = Convert.ToInt32(dgvVentas.SelectedRows[0].Cells["Id"].Value);
                GenerarFactura(idCarrito);
                even.InsertarEvento(SessionManager.getProfile().UserName, DateTime.Now, DateTime.Now.TimeOfDay, "Generar Factura", "frmDespacho", 5, SessionManager.getProfile().Apellido, SessionManager.getProfile().UserName);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un carrito.");
            }
        }

        public void UpdateLanguage()
        {
            try
            {
                var Idioma = JObject.Parse(File.ReadAllText(@"C:\Users\agusr\source\repos\ProductosOSC\SERVICIOS\Lenguages\" + ObervableLanguage.Instancia.Idioma + ".json"));

                if (this.Name == "FrmDespacho")
                {
                    lblventasafacturar.Text = Idioma["FrmDespacho"]["lblventasafacturar"].ToString();
                    
                    btnfactura.Text = Idioma["FrmDespacho"]["btnfactura"].ToString();
                    btnsalir.Text = Idioma["FrmDespacho"]["btnsalir"].ToString();
                    btnmenu.Text = Idioma["FrmDespacho"]["btnmenu"].ToString();
                    this.Text = Idioma["FrmDespacho"]["Text"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmDespacho_FormClosed(object sender, FormClosedEventArgs e)
        {
        

        }

        private void dgvnegocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
