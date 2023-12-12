using SOFTWAREDDRIGEL.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SOFTWAREDDRIGEL
{
    public partial class DASHBOARD : UserControl
    {
        public DASHBOARD()
        {
            InitializeComponent();
        }

        private void DASHBOARD_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void activity1_Click(object sender, EventArgs e)
        {
            multiplE_CHOICE1.Visible = true;
            button3.Visible = true;
            button3.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            multiplE_CHOICE1.Visible = false;
            clozE_PASSAGE1.Visible = false;
            button3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clozE_PASSAGE1.Visible = true;
            button3.Visible = true;
            button3.BringToFront();
        }

        private void login1_Load(object sender, EventArgs e)
        {

        }
    }
}
