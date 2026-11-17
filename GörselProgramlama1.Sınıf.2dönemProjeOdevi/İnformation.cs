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
    public partial class İnformation : Form
    {
        public İnformation()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            GirisSec geri1 = new GirisSec();
            geri1.Show();
            this.Hide();
        }

        private void İnformation_Load(object sender, EventArgs e)
        {

        }
    }
}
