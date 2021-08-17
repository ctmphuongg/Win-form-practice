using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11CT_18
{
    public partial class Form1 : Form
    {
        public string text1;
        public int min;
        public int max;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            text1 = textBox1.Text;
            Form3 otherForm2 = new Form3();
            otherForm2.oldForm1 = this;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            min = Int32.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            max = Int32.Parse(textBox3.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 otherForm = new Form2();
            otherForm.oldForm = this;
            otherForm.Show();
        }
    }
}
