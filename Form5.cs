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
    public partial class Form5 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-HRVLV6S\\sqlexpress;Initial Catalog=DESKTOP-HRVLV6S;Integrated Security=True");
        public Form5()
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
            // textBox3.Text = Form1.SetValueForText2;
            if (textBox1.Text.Equals(Form1.SetValueForText2))
            {

                if (textBox2.Text.Equals(textBox3.Text))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Student set Password='" + textBox3.Text + "' where email='" + label4.Text + "'", con);
                    cmd.ExecuteReader();
                    MessageBox.Show("Password Updated", "Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Form1 f = new Form1();
                    this.Hide();
                    f.Show();

                }
                else
                {
                    MessageBox.Show("New Password Does not match", "Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Entered Wrong Password", "Password", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label4.Text = Form1.SetValueForText1;
        }
    }
}
