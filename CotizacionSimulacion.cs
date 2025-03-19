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
    public partial class CotizacionSimulacion : Form
    {
        public CotizacionSimulacion()
        {
            InitializeComponent();
        }

        private void dgvCot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CotizacionSimulacion_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MenuPrincipal mp = new MenuPrincipal();
            mp.Show();
            this.Hide();

        }
    }
}
