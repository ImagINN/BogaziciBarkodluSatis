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
    public partial class fBaslangic : Form
    {
        public fBaslangic()
        {
            InitializeComponent();
        }

        private void btn_satisForm_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fSatis f = new fSatis();
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void btn_stokForm_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fStok f = new fStok();
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void btn_urunGirisForm_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fUrunGiris f = new fUrunGiris();
            f.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void btn_cikisForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_yoneticiForm_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fBaslangic f = new fBaslangic();
            f.Close();
            fLogin fLogin = new fLogin();
            fLogin.Show();
            this.Hide();
            Cursor.Current = Cursors.Default;
        }

        private void btn_ayarlarForm_Click(object sender, EventArgs e)
        {
            fAyarlar fAyarlar = new fAyarlar();
            fAyarlar.Show();
        }

        private void btn_aboneForm_Click(object sender, EventArgs e)
        {
            fAbone fAbone = new fAbone();   
            fAbone.Show();
        }
    }
}
