using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2_home_work
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Brownform_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Brown;
            rmcolor.Text = "label2";
        }

        private void rmblue_Click(object sender, EventArgs e)
        {

            rmcolor.BackColor = Color.Blue;
            //MessageBox.Show("textbox1");
            vrtype.Text = "textbox1";
        }

        private void rmred_Click(object sender, EventArgs e)
        {
            // تغيير لون الخلفية إلى الأحمر عند الضغط على زر btnred
            rmcolor.BackColor = Color.Red;
            vrtype.Text = "textbox1"; // تغيير نص labtypecolor
        }

        private void rmgreen_Click(object sender, EventArgs e)
        {
            // تغيير لون الخلفية إلى الأخضر عند الضغط على زر btngreen
            rmcolor.BackColor = Color.Green;
            rmcolor.Text = "textbox2"; // تغيير نص labtypecolor
        }

        private void rmcolor_Click(object sender, EventArgs e)
        {

            // تغيير نص labtypecolor عند الضغط على زر btncolor
            vrtype.Text = "button1";
        }

        private void Yllowcolor_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            vrtype.Text = "label1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
            vrtype.Text = "label2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
            
        }
    }
}
