using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BogaziciBarkodluSatis.Forms
{
    public partial class fAbone : Form
    {
        public fAbone()
        {
            InitializeComponent();
        }

        private void btn_aboneEkle_Click(object sender, EventArgs e)
        {
            fAboneEkle fAboneEkle = new fAboneEkle();
            fAboneEkle.Show();
        }
    }
}
