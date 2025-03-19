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
    public partial class BackUpRestore : Form
    {
        BLL_Restore res = new BLL_Restore();
        BLL_BitacoraEvento even = new BLL_BitacoraEvento();
        public BackUpRestore()
        {
            InitializeComponent();
        }

        private void BackUpRestore_Load(object sender, EventArgs e)
        {

        }

        private void btnRealizarBackUp_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBackupPath.Text))
            {
                try
                {
                    res.RealizarBackup(txtBackupPath.Text);
                    even.InsertarEvento(SessionManager.getProfile().Nombre, DateTime.Now, DateTime.Now.TimeOfDay, "BackUp", "frmBackUpRestore", 3, SessionManager.getProfile().Apellido, SessionManager.getProfile().UserName);
                    MessageBox.Show("Backup realizado con éxito.");
                    txtBackupPath.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al realizar el backup: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una ubicación para el backup.");
            }
        }

        private void btnSeleccionarBackUp_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    txtBackupPath.Text = folderDialog.SelectedPath;
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "SQL Backup Files (*.bak)|*.bak";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtRestorePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnRealizarRestore_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRestorePath.Text))
            {
                try
                {
                    res.RealizarRestore(txtRestorePath.Text);
                    even.InsertarEvento(SessionManager.getProfile().Nombre, DateTime.Now, DateTime.Now.TimeOfDay, "Restauracion base de datos", "frmBackUpRestore", 4, SessionManager.getProfile().Apellido, SessionManager.getProfile().UserName);
                    MessageBox.Show("Restauración realizada con éxito.");
                    txtRestorePath.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al restaurar la base de datos: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un archivo de restore.");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
        }
    }
}
