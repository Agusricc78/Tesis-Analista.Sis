using BE.Entity;
using BLL.Negocio;
using Microsoft.Win32;
using Newtonsoft.Json;
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
using System.Xml.Serialization;

namespace ProductosOSC
{
    public partial class Serializacion : Form
    {
        BLL_Cliente cl = new BLL_Cliente();
        BLL_BitacoraEvento even = new BLL_BitacoraEvento();
        public Serializacion()
        {
            InitializeComponent();
            MostrarClientes();
        }

        private void Serializacion_Load(object sender, EventArgs e)
        {

        }

        private void MostrarClientes()
        {
            cl.ListarClientes();
            dgvSerializado.DataSource = cl.ListarClientes();

        }

        private void SerializarClientes(string formato, string path)
        {
            try
            {
                List<BE_Cliente> clientes = new List<BE_Cliente>();

                foreach (DataGridViewRow row in dgvSerializado.Rows)
                {
                    BE_Cliente cliente = new BE_Cliente
                    {
                        Id_Cliente = int.Parse(row.Cells["Id_Cliente"].Value.ToString()),
                        Nombre = row.Cells["Nombre"].Value.ToString(),
                        Apellido = row.Cells["Apellido"].Value.ToString(),
                        DNI = int.Parse(row.Cells["DNI"].Value.ToString()),
                        Telefono = int.Parse(row.Cells["Telefono"].Value.ToString())
                    };
                    clientes.Add(cliente);
                }

                if (formato == "XML")
                {
                    using (FileStream fs = new FileStream(path, FileMode.Create))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<BE_Cliente>));
                        serializer.Serialize(fs, clientes);
                    }
                }
                else if (formato == "JSON")
                {
                    string jsonString = JsonConvert.SerializeObject(clientes, Newtonsoft.Json.Formatting.Indented);
                    File.WriteAllText(path, jsonString);
                }

                MessageBox.Show($"Clientes serializados en formato {formato} con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al serializar los clientes: " + ex.Message);
            }
        }

        private void DeserializarClientes(string formato, string path)
        {
            try
            {
                List<BE_Cliente> clientes = null;

                if (formato == "XML")
                {
                    using (FileStream fs = new FileStream(path, FileMode.Open))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<BE_Cliente>));
                        clientes = (List<BE_Cliente>)serializer.Deserialize(fs);
                    }
                }
                else if (formato == "JSON")
                {
                    string jsonString = File.ReadAllText(path);
                    clientes = JsonConvert.DeserializeObject<List<BE_Cliente>>(jsonString);
                }

                DataTable dtClientes = new DataTable();
                dtClientes.Columns.Add("Id_Cliente");
                dtClientes.Columns.Add("Nombre");
                dtClientes.Columns.Add("Apellido");
                dtClientes.Columns.Add("DNI", typeof(int));
                dtClientes.Columns.Add("Telefono", typeof(int));

                foreach (BE_Cliente cliente in clientes)
                {
                    DataRow row = dtClientes.NewRow();
                    row["Id_Cliente"] = cliente.Id_Cliente;
                    row["Nombre"] = cliente.Nombre;
                    row["Apellido"] = cliente.Apellido;
                    row["DNI"] = cliente.DNI;
                    row["Telefono"] = cliente.Telefono;
                    dtClientes.Rows.Add(row);
                }

                dgvDeserealizado.DataSource = dtClientes;

                MessageBox.Show("Clientes deserializados y cargados con éxito.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al deserializar los clientes: " + ex.Message);
            }
        }



        private void SerializarXML(BE_Cliente persona, string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(BE_Cliente));
                serializer.Serialize(fs, persona);
            }
        }

        private void SerializarJSON(BE_Cliente persona, string path)
        {
            string jsonString = JsonConvert.SerializeObject(persona, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(path, jsonString);
        }

        private BE_Cliente DeserializarXML(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(BE_Cliente));
                return (BE_Cliente)serializer.Deserialize(fs);
            }
        }

        private BE_Cliente DeserializarJSON(string path)
        {
            string jsonString = File.ReadAllText(path);
            return JsonConvert.DeserializeObject<BE_Cliente>(jsonString);
        }

        

       
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = $"{cbxTipoSerializacion.SelectedItem} Files|*.{cbxTipoSerializacion.SelectedItem.ToString().ToLower()}";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string formato = cbxTipoSerializacion.SelectedItem.ToString();
                    SerializarClientes(formato, saveFileDialog1.FileName);

                }
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = $"{cbxTipoSerializacion.SelectedItem} Files|*.{cbxTipoSerializacion.SelectedItem.ToString().ToLower()}";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string formato = cbxTipoSerializacion.SelectedItem.ToString();
                    DeserializarClientes(formato, openFileDialog1.FileName);
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
                this.Hide();
                MenuPrincipal mp = new MenuPrincipal();
                mp.Show();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            BE_Cliente cliente = new BE_Cliente();

            try
            {
                cliente.Nombre = TxtNombre.Text;
                cliente.Apellido = txtApellido.Text;
                cliente.Telefono = int.Parse(txttel.Text);
                cliente.DNI = int.Parse(txtdni.Text);

                cl.AgregarCliente(cliente);
                MostrarClientes();
                MessageBox.Show("Se ha creado el cliente con exito");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvSerializado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
