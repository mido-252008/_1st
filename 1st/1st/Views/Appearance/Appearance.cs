using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1st.Views.Appearance
{
    static class Appearance
    {
        public static void HeaderFooterColor(Panel panel1,Panel panel2,Button button)
        {
            panel1.BackColor = _1st.Properties.Settings.Default.HeaderFooterColor;
            panel2.BackColor = _1st.Properties.Settings.Default.HeaderFooterColor;
            button.BackColor= _1st.Properties.Settings.Default.HeaderFooterColor;
        }
    }
}
