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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btTampil_Click(object sender, EventArgs e)
        {
            if(rbLaki.Checked == true)
            {
                MessageBox.Show("           Selamat Datang! \n\nNama: " + txtNama.Text + "\nNPM: " + 
                    txtNPM.Text + "\nJenis Kelamin: " + rbLaki.Text + "\nTempat Lahir: " + txtTempatLahir.Text + "\nTanggal Lahir: " + dtpTanggalLahir.Text + "\nProgram Studi: " + 
                    cbPS.SelectedItem.ToString() + "\nMinat Bakat:" + cekMinatBakat());
            }
            
            else
            {
                MessageBox.Show("           Selamat Datang! \n\nNama: " + txtNama.Text + "\nNPM: " + 
                    txtNPM.Text + "\nJenis Kelamin: " + rbPr.Text + "\nTempat Lahir: " + txtTempatLahir.Text + "\nTanggal Lahir: " + dtpTanggalLahir.Text + "\nProgram Studi: " + 
                    cbPS.SelectedItem.ToString() + "\nMinat Bakat:" + cekMinatBakat());
            }
            
        }

        private string cekMinatBakat()
        {
            string tampung = "";

            if (checkBox1.Checked == true)
            {
                tampung = tampung + "\n- " + checkBox1.Text;
            }

            if (checkBox2.Checked == true)
            {
                tampung = tampung + "\n- " + checkBox2.Text;
            }

            if (checkBox3.Checked == true)
            {
                tampung = tampung + "\n- " + checkBox3.Text;
            }

            if (checkBox4.Checked == true)
            {
                tampung = tampung + "\n- " + checkBox4.Text;
            }

            if (checkBox5.Checked == true)
            {
                tampung = tampung + "\n- " + checkBox5.Text;
            }

            if (checkBox6.Checked == true)
            {
                tampung = tampung + "\n- " + checkBox6.Text;
            }

            return tampung;
        }

        private void btKeluar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            int baris = 0;
            dgvMahasiswa.Rows.Add();
            baris = dgvMahasiswa.Rows.Count - 2;

            string jk;
            if (rbLaki.Checked == true)
            {
                jk = rbLaki.Text;
            }
            else
            {
                jk = rbPr.Text;
            }

            dgvMahasiswa[0, baris].Value = dgvMahasiswa.Rows.Count - 1;
            dgvMahasiswa[1, baris].Value = txtNama.Text;
            dgvMahasiswa[2, baris].Value = txtNPM.Text;
            dgvMahasiswa[3, baris].Value = jk;
            dgvMahasiswa[4, baris].Value = txtTempatLahir.Text;
            dgvMahasiswa[5, baris].Value = dtpTanggalLahir.Text;
            dgvMahasiswa[6, baris].Value = cbPS.SelectedItem.ToString();
        }
    }
}
