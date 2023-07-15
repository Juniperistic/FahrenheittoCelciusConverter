using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ch14ex6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label2_Click(object sender, EventArgs e)
        {
            double con, f;
            f = Convert.ToDouble(textBox1.Text);
            con = (((f - 32)) * 5 / 9);
            label2.Text = con.ToString();



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
