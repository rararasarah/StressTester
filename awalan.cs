using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StresTester
{
    public partial class awalan : Form
    {
        public static string _namaUser;
        private static string gender;

        public awalan()
        {
            InitializeComponent();
        }

        private void tbNama_TextChanged(object sender, EventArgs e)
        {
            _namaUser = tbNama.Text;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
                TambahData();
                //this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        User user;
        private void TambahData()
        {
            try
            {
                if (tbNama.Text != "" && gender != "" && tbUmur.Text != "")
                {
                    using (var db = new DaftarUser())
                    {
                        user = new User
                        {
                            Nama = tbNama.Text,
                            Jenis_Kelamin = gender,
                            Umur = tbUmur.Text,
                        };
                        db.Users.Add(user);
                        db.SaveChanges();
                    }
                    MessageBox.Show("Hai " + _namaUser + "! Selamat Datang!");
                    mainMenu formMenu = new mainMenu();
                    var result = formMenu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nama, Jenis Kelamin, dan Umur Anda harus diisi !");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Format Nama dan Umur harus benar!");
            }
        }

        private void lblTitle1_Click(object sender, EventArgs e)
        {

        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                gender = "Laki-Laki";
            }
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            if (rb2.Checked)
            {
                gender = "Perempuan";
            }
        }
    }
}
