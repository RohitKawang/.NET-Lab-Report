using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WFAlab
{
    public partial class QN5 : Form
    {
        public QN5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double principal = Convert.ToDouble(textBox1.Text);
            double rate = Convert.ToDouble(textBox2.Text);
            double time = Convert.ToDouble(textBox3.Text);
            double simpleInterest = (principal * rate * time) / 100;
            textBox4.Text = "Rs. " + simpleInterest.ToString();
        }
    }
}
