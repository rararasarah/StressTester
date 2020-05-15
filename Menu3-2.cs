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
    public partial class Menu3_2 : Form
    {
        public static int _totalPoin2;
        public Menu3_2()
        {
            InitializeComponent();
        }

        private void cb11_CheckedChanged(object sender, EventArgs e)
        {
            if (cb11.Checked)
            {
                _totalPoin2++;
            }
        }

        private void cb12_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cb12.Checked)
            {
                _totalPoin2++;
            }
        }

        private void cb13_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cb13.Checked)
            {
                _totalPoin2++;
            }
        }
      
        private void cb14_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cb14.Checked)
            {
                _totalPoin2++;
            }
        }

        private void cb21_CheckedChanged(object sender, EventArgs e)
        {
            if (cb21.Checked)
            {
                _totalPoin2++;
            }
        }

        private void cb22_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cb22.Checked)
            {
                _totalPoin2++;
            }
        }

        private void cb23_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cb23.Checked)
            {
                _totalPoin2++;
            }
        }

        private void cb24_CheckedChanged(object sender, EventArgs e)
        {
            if (cb24.Checked)
            {
                _totalPoin2++;
            }
        }
        private void cb25_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cb25.Checked)
            {
                _totalPoin2++;
            }
        }
        private void cb31_CheckedChanged_1(object sender, EventArgs e)
        {
            if (cb31.Checked)
            {
                _totalPoin2++;
            }
        }
        private void cb32_CheckedChanged(object sender, EventArgs e)
        {
            if (cb32.Checked)
            {
                _totalPoin2++;
            }
        }

        private void cb33_CheckedChanged(object sender, EventArgs e)
        {
            if (cb33.Checked)
            {
                _totalPoin2++;
            }
        }

        private void cb34_CheckedChanged(object sender, EventArgs e)
        {
            if (cb34.Checked)
            {
                _totalPoin2++;
            }
        }

        private void cb35_CheckedChanged(object sender, EventArgs e)
        {
            if (cb35.Checked)
            {
                _totalPoin2++;
            }
        }

        private void cb41_CheckedChanged(object sender, EventArgs e)
        {
            if (cb41.Checked)
            {
                _totalPoin2++;
            }
        }

        private void cb42_CheckedChanged(object sender, EventArgs e)
        {
            if (cb42.Checked)
            {
                _totalPoin2++;
            }
        }

        private void cb43_CheckedChanged(object sender, EventArgs e)
        {
            if (cb43.Checked)
            {
                _totalPoin2++;
            }
        }

        private void cb44_CheckedChanged(object sender, EventArgs e)
        {
            if (cb44.Checked)
            {
                _totalPoin2++;
            }
        }

        private void cb45_CheckedChanged(object sender, EventArgs e)
        {
            if (cb45.Checked)
            {
                _totalPoin2++;
            }
        }

        private void btnNextSoal_Click(object sender, EventArgs e)
        {
            Menu3_3 menu33 = new Menu3_3();
            this.Hide();
            DialogResult result = menu33.ShowDialog();

        }

        private void btnBack1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblQuest2_Click(object sender, EventArgs e)
        {

        }
    }
}
