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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            settings1.Visible = false;
            info1.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            settings1.Visible = false;
            info1.Visible = false;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            settings1.Visible = false;
            info1.Visible = true;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            settings1.Visible = true;
            info1.Visible = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dashboard1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            login1.Visible = true;
        }
    }
}
