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
    public partial class Form2 : Form
    {
        public Form1 oldForm;
        public int min2;
        public int max2;
        public int socantim;
        public int text2;
        public string text3;
        public string socantim1;
        public string result = "Bạn chưa đoán được số cần tìm";
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            min2 = oldForm.min;
            max2 = oldForm.max;
            socantim = random.Next(min2, max2 + 1);
            socantim1 = socantim.ToString();
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            text2 = Int32.Parse(text3);
            if (text2 == socantim)
            {
                MessageBox.Show("Bạn đã trả lời đúng");
                timer1.Stop();
                Form3 otherForm = new Form3();
                otherForm.oldForm2 = this;
                otherForm.Show();
                result = "Bạn đã đoán được số cần tìm";
            }
            else
            {
                MessageBox.Show("Bạn đã trả lời sai");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 10;
            }
            else
            {
                button2.Enabled = false;
                Form3 otherForm = new Form3();
                otherForm.oldForm2 = this;
                otherForm.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            text3 = textBox1.Text;
        }
    }
}
