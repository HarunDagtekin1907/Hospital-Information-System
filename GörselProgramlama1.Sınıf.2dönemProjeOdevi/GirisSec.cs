using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GörselProgramlama1.Sınıf._2dönemProjeOdevi
{
    public partial class GirisSec : Form
    {
        public GirisSec()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            İnformation about = new İnformation();
            about.Show();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Form1 dct = new Form1();
            dct.Show();
            this.Hide();
        }

        private void GirisSec_Load(object sender, EventArgs e)
        {

        }
    }
}
