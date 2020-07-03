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
    //public int i = 2;
    public partial class Form7 : Form
    {
        int i = 2;
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HRVLV6S\\sqlexpress;Initial Catalog=DESKTOP-HRVLV6S;Integrated Security=True");
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            this.Hide();
            f8.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into Request(Req_ID,University_name) values (@Req_ID,@University_name)",con);
            cmd.Parameters.AddWithValue("@Req_ID", i);
            i++;
            cmd.Parameters.AddWithValue("@University_name", textBox1.Text.Trim());
            SqlDataReader dr = cmd.ExecuteReader();
            MessageBox.Show("Requested,You will be notified Soon", "Equestion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            con.Close();
        }
    }
}
