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
    public partial class mainMenu : Form
    {
        public static string Text1 = "Stres adalah stimulus atau situasi yang menimbulkan distres ";
        public mainMenu()
        {
            InitializeComponent();
        }

        private void btnMenu1_Click(object sender, EventArgs e)
        {
            Menu1 form1 = new Menu1();
            DialogResult result = form1.ShowDialog();
        }

        private void btnMenu2_Click(object sender, EventArgs e)
        {
            Menu2 form2 = new Menu2();
            DialogResult result = form2.ShowDialog();
        }

        private void btnMenu3_Click(object sender, EventArgs e)
        {
            Menu3 form3 = new Menu3();
            DialogResult result = form3.ShowDialog();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
