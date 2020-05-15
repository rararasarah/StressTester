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
    public partial class Analisis : Form
    {
        public Analisis()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu3_4 menu34 = new Menu3_4();
            DialogResult results = menu34.ShowDialog();

        }

        private void btnBackmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu mainmenu = new mainMenu();
            DialogResult results = mainmenu.ShowDialog();
        }

        private void lblFaktor_Click(object sender, EventArgs e)
        {

        }
    }
}
