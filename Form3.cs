using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HRVLV6S\\sqlexpress;Initial Catalog=DESKTOP-HRVLV6S;Integrated Security=True");
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert into Student(email,name,DOB,Password) values(@email,@name,@DOB,@Password)", con);
                cmd.Parameters.AddWithValue("@email", textBox1.Text.Trim());
                cmd.Parameters.AddWithValue("@name", textBox2.Text.Trim());
                cmd.Parameters.AddWithValue("@DOB", textBox4.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", textBox3.Text.Trim());
                SqlDataReader dr = cmd.ExecuteReader();
                MessageBox.Show("registration successful", "Equestion", MessageBoxButtons.OKCancel);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Equestion");
            }
            con.Close();
        }
    }
}
