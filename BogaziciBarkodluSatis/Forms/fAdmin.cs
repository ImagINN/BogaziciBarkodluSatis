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
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }

        private void btn_raporlarForm_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fRapor fRapor = new fRapor();
            fRapor.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void btn_fiyatGuncelleForm_Click(object sender, EventArgs e)
        {
            fFiyatGuncelle fFiyatGuncelle = new fFiyatGuncelle();
            fFiyatGuncelle.ShowDialog();
        }

        private void btn_baslangıc_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fAdmin fAdmin = new fAdmin();
            fAdmin.Close();
            fBaslangic fBaslangic = new fBaslangic();
            fBaslangic.Show();
            this.Hide();
            Cursor.Current = Cursors.Default;
        }

        private void btn_gelirGiderForm_Click(object sender, EventArgs e)
        {
            fGelirGider fGelirGider = new fGelirGider();
            fGelirGider.ShowDialog();
        }
    }
}
