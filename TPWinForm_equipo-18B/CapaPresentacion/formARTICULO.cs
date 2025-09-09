using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dominio
{
    public partial class formARTICULO : Form
    {
        public formARTICULO()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formARTICULO_Load(object sender, EventArgs e)
        {
            ArticuloDatos negocio = new ArticuloDatos();
            dgvARTICULOS.DataSource = negocio.listar();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
