using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class OddEven : Form
    {
        public OddEven()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(number.Text);
            if (num % 2 == 0)
            {
                result.Text = "Even";
            }
            else
            {
                result.Text = "Odd";
            }
        }
    }
}
