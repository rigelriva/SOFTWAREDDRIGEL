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
    public partial class login : UserControl
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = txtUser.Text;
            pass = txtPass.Text;
            if (user == "admin" && pass == "admin")
            {
                MessageBox.Show("successful");
                Form1 frm1 = new Form1();
                this.Hide();
            }
            else if (user == "admin" || pass == "admin")
            {
                MessageBox.Show("error");
            }
        }
    }
}
