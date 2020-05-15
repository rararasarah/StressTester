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
    public partial class Menu3_4 : Form
    {
        public static int _totalPoin4;
        public Menu3_4()
        {
            InitializeComponent();
        }

        private void cb31_CheckedChanged(object sender, EventArgs e)
        {
            if (cb31.Checked)
            {
                _totalPoin4++;
            }
        }

        private void cb32_CheckedChanged(object sender, EventArgs e)
        {
            if (cb32.Checked)
            {
                _totalPoin4++;
            }
        }

        private void cb33_CheckedChanged(object sender, EventArgs e)
        {
            if (cb33.Checked)
            {
                _totalPoin4++;
            }
        }

        private void cb34_CheckedChanged(object sender, EventArgs e)
        {
            if (cb34.Checked)
            {
                _totalPoin4++;
            }
        }

        private void cb35_CheckedChanged(object sender, EventArgs e)
        {
            if (cb35.Checked)
            {
                _totalPoin4++;
            }
        }

        private void cb41_CheckedChanged(object sender, EventArgs e)
        {
            if (cb41.Checked)
            {
                _totalPoin4++;
            }
        }

        private void cb42_CheckedChanged(object sender, EventArgs e)
        {
            if (cb42.Checked)
            {
                _totalPoin4++;
            }
        }

        private void cb43_CheckedChanged(object sender, EventArgs e)
        {
            if (cb43.Checked)
            {
                _totalPoin4++;
            }
        }

        private void cb44_CheckedChanged(object sender, EventArgs e)
        {
            if (cb44.Checked)
            {
                _totalPoin4++;
            }
        }

        private void cb45_CheckedChanged(object sender, EventArgs e)
        {
            if (cb45.Checked)
            {
                _totalPoin4++;
            }
        }

        private void btnNextSoal_Click(object sender, EventArgs e)
        {
            int total = _totalPoin4 + Menu3_3._totalPoin3 + Menu3_2._totalPoin2 + Menu3._totalPoin;

            string message = "Total skor anda adalah  " +total+ "  \nLihat analisis?";
            var result = MessageBox.Show(message, "confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                this.Hide();
                Analisis analisis = new Analisis();
                DialogResult results = analisis.ShowDialog();
            }
        }

        private void btnBack3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
