using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(textid.Text);
            string name = txtname.Text;
            string address = txtaddress.Text;
            string faculty = textfaculty.Text;

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\rohit\source\repos\WinFormsApp1\WinFormsApp1\Database1.mdf;Integrated Security=True;Connect Timeout = 30");

            string query = "insert into STUDENTlab(Id, name,address,faculty) values(@Id, @name, @address, @faculty)";

            SqlCommand cmd = new SqlCommand(query, con);



            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@address", address);
            cmd.Parameters.AddWithValue("@faculty", faculty);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
