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
    public partial class fGelirGider : Form
    {
        public fGelirGider()
        {
            InitializeComponent();
        }

        private void btn_gelirTuruEkle_Click(object sender, EventArgs e)
        {
            fGelirTuruEkle fGelirTuruEkle = new fGelirTuruEkle();
            fGelirTuruEkle.ShowDialog();
        }

        private void btn_giderTuruEkle_Click(object sender, EventArgs e)
        {
            fGiderTuruEkle fGiderTuruEkle = new fGiderTuruEkle();
            fGiderTuruEkle.ShowDialog();
        }
    }
}
