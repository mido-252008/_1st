using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace _1st.Views.Forms
{
    public partial class frmEmployee : DevExpress.XtraEditors.XtraForm
    {
        public frmEmployee()
        {
            InitializeComponent();
            _1st.Views.Appearance.Appearance.HeaderFooterColor(HeaderPanel, FooterPanel, btnClose);
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}