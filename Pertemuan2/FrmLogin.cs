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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "danny" && txtPassword.Text == "amikom")
            {
                this.Hide();
                FrmHome frm = new FrmHome();
                frm.Show();
            }
            else 
            {
                MessageBox.Show("Maaf Username/Password salah!");
                txtUsername.Text = "Username";
                txtPassword.Text = "Password";
                txtUsername.Focus();
            }
        }
    }
}
