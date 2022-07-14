using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _1st.Views.Forms;

namespace _1st.Views.Forms
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            colorPickEdit1.Color = _1st.Properties.Settings.Default.HeaderFooterColor;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCustomerCard frm = new frmCustomerCard();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmSupplierCard frm = new frmSupplierCard();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmUnitsGroup frm = new frmUnitsGroup();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmWareHouses frm = new frmWareHouses();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmExpensesGroup frm = new frmExpensesGroup();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmExpenses frm = new frmExpenses();
            frm.ShowDialog();
        }

        private void colorPickEdit1_ColorChanged(object sender, EventArgs e)
        {
            _1st.Properties.Settings.Default.HeaderFooterColor = colorPickEdit1.Color;
        }
    }
}
