using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace captcha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] list1 = new string[] {"a" ,"b","c","d","e","f","g"};

            string[] list2 = new string[] { "+", "/", "-", "_","!" };

            Random rg = new Random();
            int s1 = rg.Next(0, list1.Length);
            int s2 = rg.Next(0, list2.Length);
            int s3 = rg.Next(0, 10);

            label1.Text = list1[s1] + list2[s2] + s3;



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 cfg = new Form2();
            cfg.Show();
            this.Hide();
            
        }
    }
}
