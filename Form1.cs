using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTVN
{
    public partial class Form1 : Form
    {
        public int score = 0;
        public void AddScore(int point)
        {
            this.score += point;
            this.label2.Text = this.score.ToString();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 otherForm = new Form2();
            otherForm.Show();
            otherForm.oldForm = this;
            button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 otherForm3 = new Form3();
            otherForm3.Show();
            otherForm3.oldForm = this;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 otherForm4 = new Form4();
            otherForm4.Show();
            otherForm4.Oldform = this;
            button3.Enabled = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Form4 otherForm4 = new Form4();
            otherForm4.Show();
            otherForm4.Oldform = this;
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form9 otherForm9 = new Form9();
            otherForm9.Show();
            otherForm9.oldForm = this;
            otherForm9.score1 = score;
        }
    }
}
