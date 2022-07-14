using System;
using System.Windows.Forms;

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

        private void button8_Click(object sender, EventArgs e)
        {
            frmItemsGroups frm = new frmItemsGroups();
            frm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmEmployee frm = new frmEmployee();
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            frmUsers frm = new frmUsers();
            frm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            frmItemDetails frm = new frmItemDetails();
            frm.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            frmCustomersGroups frm = new frmCustomersGroups();
            frm.ShowDialog();
        }
    }
}
