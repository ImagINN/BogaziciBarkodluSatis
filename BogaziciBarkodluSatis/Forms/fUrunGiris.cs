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
    public partial class fUrunGiris : Form
    {
        public fUrunGiris()
        {
            InitializeComponent();
        }

        private void btn_urunGrubuEkle_Click(object sender, EventArgs e)
        {
            fUrunGrubuEkle formUrunGrubuEkle = new fUrunGrubuEkle();
            formUrunGrubuEkle.ShowDialog();
        }

        private void btn_bedenEkle_Click(object sender, EventArgs e)
        {
            fBedenEkle fBedenEkle = new fBedenEkle();
            fBedenEkle.ShowDialog();
        }
    }
}
