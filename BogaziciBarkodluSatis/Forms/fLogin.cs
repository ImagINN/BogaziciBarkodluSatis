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
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void cntrlButton1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            fLogin f = new fLogin();
            f.Close();
            fAdmin fAdmin = new fAdmin();   
            fAdmin.Show();
            this.Hide();
            Cursor.Current = Cursors.Default;
        }    
    }
}
