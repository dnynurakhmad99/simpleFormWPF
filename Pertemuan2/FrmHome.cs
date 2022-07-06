using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pertemuan2
{
    public partial class FrmHome : Form
    {
        private int childFormNumber = 0;

        public FrmHome()
        {
            InitializeComponent();
        }

        private void mahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 mahasiswa = new Form1();
            mahasiswa.MdiParent = this;
            mahasiswa.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLogin lgn = new FrmLogin();
            lgn.MdiParent = this;
            lgn.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
