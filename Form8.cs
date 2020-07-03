using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form8 : Form
    {
        //public static string SetValueForText3 = "";
        public Form8()
        {
            InitializeComponent();
        }

        private void changeYourPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SetValueForText3 = label3.Text;
            Form5 f5 = new Form5();
            this.Hide();
            f5.Show();

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            this.Hide();
            f6.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            this.Hide();
            f7.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
           // label4.Text = Form1.SetValueForText3;
            label3.Text = Form1.SetValueForText2;
            label1.Text = Form1.SetValueForText1;
        }
    }
}
