using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimFinanca
{
    public partial class frmRelatorios : Form
    {
        public frmRelatorios()
        {
            InitializeComponent();
        }

        private void frmRelatorios_Load(object sender, EventArgs e)
        {
          
        }

        private void bntRelatorio_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRelatorioCliente Rlcliente = new frmRelatorioCliente();
            Rlcliente.Show();
        }

        private void bntFechar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
