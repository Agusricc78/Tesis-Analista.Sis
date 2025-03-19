using BE.Entity;
using BLL.Negocio;
using iTextSharp.text.pdf;
using iTextSharp.text;
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
using Font = iTextSharp.text.Font;

namespace ProductosOSC
{
    public partial class BitacoraEventos : Form
    {
        BLL_BitacoraEvento even = new BLL_BitacoraEvento();

        public BitacoraEventos()
        {
            InitializeComponent();
            MostrarEventos();
            txtlogin.Text = SessionManager.getProfile().UserName;
        }

        private void BitacoraEventos_Load(object sender, EventArgs e)
        {
            
        }
      

        private void MostrarEventos()
        {
            guna2DataGridView1.DataSource = even.ListarEventos();
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = even.ListarEventos();

            txtlogin.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtmodulo.Clear();
            txtevento.Clear();
            txtcriticidad.Clear();
            dtpicker1.Text = DateTime.Now.ToString();
            dtpickerFin.Text = DateTime.Now.ToString();
        }

        private List<BE_Evento> originalDataSource;

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            string filtroLogin = txtlogin.Text.Trim();
            string filtroNombre = txtnombre.Text.Trim();
            string filtroApellido = txtapellido.Text.Trim();
            string filtroEvento = txtevento.Text.Trim();
            string filtroModulo = txtmodulo.Text.Trim();
            string filtroCriticidad = txtcriticidad.Text.Trim();
            

            DateTime filtroFechaInicio = dtpicker1.Value.Date;
            DateTime filtroFechaFin = dtpickerFin.Value.Date;

            if (chkbRangoFechas.Checked && filtroFechaInicio > filtroFechaFin)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha de fin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpicker1.Text = DateTime.Now.ToString();
                dtpickerFin.Text = DateTime.Now.ToString();
                return;
            }

            if (originalDataSource == null)
            {
                originalDataSource = ((DataTable)guna2DataGridView1.DataSource).AsEnumerable().Select(row => new BE_Evento
                {
                    Id_Evento = row.Field<int>("Id_Evento"),
                    Usuario = row.Field<string>("UserName"),
                    Fecha = row.Field<DateTime>("Fecha"),
                    Hora = row.Field<TimeSpan>("Hora"),
                    Modulo = row.Field<string>("Modulo"),
                    Evento = row.Field<string>("Evento"),
                    Criticidad = row.Field<int>("Criticidad"),
                    Nombre = row.Field<string>("Nombre"),
                    Apellido = row.Field<string>("Apellido")
                }).ToList();
            }

            var EventosFiltrados = originalDataSource.Where(u =>
                (string.IsNullOrEmpty(filtroLogin) || u.Usuario.Contains(filtroLogin)) &&
                (string.IsNullOrEmpty(filtroNombre) || u.Nombre.Contains(filtroNombre)) &&
                (string.IsNullOrEmpty(filtroApellido) || u.Apellido.Contains(filtroApellido)) &&
                (string.IsNullOrEmpty(filtroEvento) || u.Evento.Contains(filtroEvento)) &&
                (string.IsNullOrEmpty(filtroModulo) || u.Modulo.Contains(filtroModulo)) &&
                (string.IsNullOrEmpty(filtroCriticidad) || u.Criticidad == int.Parse(filtroCriticidad)) &&
                (!chkbRangoFechas.Checked || (u.Fecha.Date >= filtroFechaInicio && u.Fecha.Date <= filtroFechaFin))
            ).ToList();

            guna2DataGridView1.DataSource = EventosFiltrados;




        }


        private void GenerarPDF(List<BE_Evento> eventos, string filePath)
        {
            Document document = new Document(PageSize.A4, 10, 10, 10, 10);
            PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));
            document.Open();

            Font titleFont = GetFont("Arial", 18, Convert.ToInt32(true), BaseColor.BLACK);
            Font headerFont = GetFont("Arial", 12, Convert.ToInt32(true), BaseColor.WHITE);
            Font cellFont = GetFont("Arial", 10, Convert.ToInt32(false), BaseColor.BLACK);


            Paragraph title = new Paragraph("Reporte de Eventos", titleFont);
            title.Alignment = Element.ALIGN_CENTER;
            document.Add(title);

            document.Add(new Paragraph("\n"));

            Paragraph date = new Paragraph($"Fecha del reporte: {DateTime.Now:dd/MM/yyyy}", cellFont);
            date.Alignment = Element.ALIGN_RIGHT;
            document.Add(date);

            document.Add(new Paragraph("\n"));


            PdfPTable table = new PdfPTable(8);
            table.WidthPercentage = 100;
            table.SpacingBefore = 10f;
            table.SpacingAfter = 10f;

            BaseColor headerBackgroundColor = new BaseColor(0, 150, 0);

            PdfPCell[] headers = new PdfPCell[]
            {
                new PdfPCell(new Phrase("Login", headerFont)),
                new PdfPCell(new Phrase("Nombre", headerFont)),
                new PdfPCell(new Phrase("Apellido", headerFont)),
                new PdfPCell(new Phrase("Fecha", headerFont)),
                new PdfPCell(new Phrase("Hora", headerFont)),
                new PdfPCell(new Phrase("Modulo", headerFont)),
                new PdfPCell(new Phrase("Evento", headerFont)),
                new PdfPCell(new Phrase("Criticidad", headerFont))
            };

            foreach (var header in headers)
            {
                header.BackgroundColor = headerBackgroundColor;
                header.HorizontalAlignment = Element.ALIGN_CENTER;
                header.Padding = 5;
                table.AddCell(header);
            }

            // Agregar los datos filtrados a la tabla
            foreach (var evento in eventos)
            {
                table.AddCell(new PdfPCell(new Phrase(evento.Usuario, cellFont)) { Padding = 5 });
                table.AddCell(new PdfPCell(new Phrase(evento.Nombre, cellFont)) { Padding = 5 });
                table.AddCell(new PdfPCell(new Phrase(evento.Apellido, cellFont)) { Padding = 5 });
                table.AddCell(new PdfPCell(new Phrase(evento.Fecha.ToString("dd/MM/yyyy"), cellFont)) { Padding = 5 });
                table.AddCell(new PdfPCell(new Phrase(evento.Hora.ToString(), cellFont)) { Padding = 5 });
                table.AddCell(new PdfPCell(new Phrase(evento.Modulo, cellFont)) { Padding = 5 });
                table.AddCell(new PdfPCell(new Phrase(evento.Evento, cellFont)) { Padding = 5 });
                table.AddCell(new PdfPCell(new Phrase(evento.Criticidad.ToString(), cellFont)) { Padding = 5 });
            }

            document.Add(table);

            Paragraph footer = new Paragraph("Generado por ProductoOSC", cellFont);
            footer.Alignment = Element.ALIGN_CENTER;
            document.Add(footer);

            document.Close();

            MessageBox.Show("PDF generado correctamente en " + filePath);
        }

        public static Font GetFont(string fontname, float size, int style, BaseColor color)
        {
            return FontFactory.GetFont(fontname, size, style, color);
        }

        private void chkbRangoFechas_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbRangoFechas.Checked)
            {
                dtpicker1.Visible = true;
                dtpickerFin.Visible = true;
                guna2HtmlLabel4.Visible = true;
                guna2HtmlLabel5.Visible = true;
            }
            else
            {
                dtpicker1.Visible = false;
                dtpickerFin.Visible = false;
                guna2HtmlLabel4.Visible = false;
                guna2HtmlLabel5.Visible = false;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "PDF Files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Guardar PDF";
                saveFileDialog.FileName = "ReporteEventos.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    var eventosFiltrados = (List<BE_Evento>)guna2DataGridView1.DataSource;

                    if (eventosFiltrados != null && eventosFiltrados.Count > 0)
                    {
                        GenerarPDF(eventosFiltrados, filePath);
                    }
                    else
                    {
                        MessageBox.Show("No hay datos para generar el PDF.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}
