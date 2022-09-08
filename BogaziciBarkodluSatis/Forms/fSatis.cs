using BogaziciBarkodluSatis.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BogaziciBarkodluSatis
{
    public partial class fSatis : Form
    {
        public fSatis()
        {
            InitializeComponent();
        }

        private void btn_nakitKart_Click(object sender, EventArgs e)
        {
            fNakitKart formNakitKart = new fNakitKart();
            formNakitKart.ShowDialog();
        }

        private void btn_nakit_Click(object sender, EventArgs e)
        {
            fNakit formNakit = new fNakit();
            formNakit.ShowDialog();
        }

        private void btn_aboneIslemi_Click(object sender, EventArgs e)
        {
            fAbone fAbone = new fAbone();
            fAbone.ShowDialog();
        }
    }
}
