using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PimFinanca
{
    public partial class frmDashboard : Form
    {

        public frmDashboard()
        {
            InitializeComponent();

        }
        private bool allowVisible;




        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

            this.WindowState = FormWindowState.Maximized;
            pictureBox14.Visible = true;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            pictureBox13.Visible = true;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmCadastro Cadastro = new frmCadastro();
            Cadastro.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmLogin Login = new frmLogin();
            Login.Show();
        }


        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        public static void ThreadProc()
        {
            Application.Run(new frmDashboard());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread th;
            this.Close();
            th = new Thread(opennewform);
            th.SetApartmentState(ApartmentState.MTA);
            th.Start();

        }
        private void opennewform(object obj)
        {
            Application.Run(new frmDashboard());
            var m = new frmDashboard();
            m.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
         
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
