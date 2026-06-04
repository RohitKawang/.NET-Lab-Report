using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WFAlab
{
    public partial class QN3 : Form
    {
        public QN3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int start, end;

            if (int.TryParse(textBox1.Text, out start) && int.TryParse(textBox2.Text, out end))
            {
                textBox3.Clear();

                if (start <= end)
                {
                    for (int i = start; i <= end; i++)
                    {
                        textBox3.AppendText(i + Environment.NewLine);
                    }
                }
                else
                {
                    for (int i = start; i >= end; i--)
                    {
                        textBox3.AppendText(i + Environment.NewLine);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter valid integers in both text boxes.");
            }
        }
    }
}
