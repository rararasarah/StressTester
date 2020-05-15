using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StresTester
{
    public partial class Menu3 : Form
    {
        public static int _totalPoin;
        public Menu3()
        {
            InitializeComponent();
        }

        private void cb11_CheckedChanged(object sender, EventArgs e)
        {
            _totalPoin = 0;

            if(cb11.Checked)
            {
                _totalPoin++;
            }
        }

        private void cb12_CheckedChanged(object sender, EventArgs e)
        {
            if(cb12.Checked)
            {
                _totalPoin++;
            }
        }

        private void cb13_CheckedChanged(object sender, EventArgs e)
        {
            if (cb13.Checked)
            {
                _totalPoin++;
            }
        }

        private void cb14_CheckedChanged(object sender, EventArgs e)
        {
            if (cb14.Checked)
            {
                _totalPoin++;
            }
        }

        private void cb21_CheckedChanged(object sender, EventArgs e)
        {
            if (cb21.Checked)
            {
                _totalPoin++;
            }
        }

        private void cb22_CheckedChanged(object sender, EventArgs e)
        {
            if (cb22.Checked)
            {
                _totalPoin++;
            }
        }

        private void cb23_CheckedChanged(object sender, EventArgs e)
        {
            if (cb23.Checked)
            {
                _totalPoin++;
            }
        }

        private void cb24_CheckedChanged(object sender, EventArgs e)
        {
            if (cb24.Checked)
            {
                _totalPoin++;
            }
        }

        private void cb25_CheckedChanged(object sender, EventArgs e)
        {
            if (cb25.Checked)
            {
                _totalPoin++;
            }
        }

        private void cb26_CheckedChanged(object sender, EventArgs e)
        {
            if (cb26.Checked)
            {
                _totalPoin++;
            }
        }

        private void cb31_CheckedChanged(object sender, EventArgs e)
        {
            if (cb31.Checked)
            {
                _totalPoin++;
            }
        }

        private void cb32_CheckedChanged(object sender, EventArgs e)
        {
            if (cb32.Checked)
            {
                _totalPoin++;
            }
        }

        private void cb33_CheckedChanged(object sender, EventArgs e)
        {
            if (cb33.Checked)
            {
                _totalPoin++;
            }
        }

        private void cb34_CheckedChanged(object sender, EventArgs e)
        {
            if (cb34.Checked)
            {
                _totalPoin++;
            }
        }

        private void cb35_CheckedChanged(object sender, EventArgs e)
        {
            if (cb35.Checked)
            {
                _totalPoin++;
            }
        }

        private void cb41_CheckedChanged(object sender, EventArgs e)
        {
            if (cb41.Checked)
            {
                _totalPoin++;
            }
        }

        private void cb42_CheckedChanged(object sender, EventArgs e)
        {
            if (cb42.Checked)
            {
                _totalPoin++;
            }
        }

        private void cb43_CheckedChanged(object sender, EventArgs e)
        {
            if (cb43.Checked)
            {
                _totalPoin++;
            }
        }

        private void cb44_CheckedChanged(object sender, EventArgs e)
        {
            if (cb44.Checked)
            {
                _totalPoin++;
            }
        }

        private void cb45_CheckedChanged(object sender, EventArgs e)
        {
            if (cb45.Checked)
            {
                _totalPoin++;
            }
        }
        private void btnNextSoal_Click(object sender, EventArgs e)
        {
            Menu3_2 menu32 = new Menu3_2();
            this.Hide();
            DialogResult result = menu32.ShowDialog();
        }

        public static int TotalPoin1()
        {
            int totalPoin1 = _totalPoin;
            return totalPoin1;
        }

        private void btnBacktoMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lblQuest4_Click(object sender, EventArgs e)
        {

        }

        private void Menu3_Load(object sender, EventArgs e)
        {

        }
    }
}
