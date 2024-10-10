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
    public partial class Form4 : Form
    {
        double x;

        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // محاولة تحويل النص المدخل إلى عدد
            if (double.TryParse(textBox1.Text, out x))
            {
                // قانون مجموع الأعداد من 1 إلى x
                double sum = x * (x + 1) / 2;
                label1.Text = sum.ToString(); // عرض النتيجة في label1
            }
            else
            {
                MessageBox.Show("يرجى إدخال رقم صحيح.");
                textBox1.Focus(); // التركيز على TextBox لإعادة الإدخال
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // محاولة تحويل النص المدخل إلى عدد
            if (double.TryParse(textBox1.Text, out x) && x >= 0)
            {
                double f = 1;
                // حساب العامل (Factorial)
                for (int i = 1; i <= x; i++)
                {
                    f *= i;
                }
                label2.Text = f.ToString(); // عرض النتيجة في label2
            }
            else
            {
                MessageBox.Show("يرجى إدخال رقم صحيح أكبر من أو يساوي 0.");
                textBox1.Focus(); // التركيز على TextBox لإعادة الإدخال
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // محاولة تحويل النص المدخل إلى عدد
            if (double.TryParse(textBox1.Text, out x))
            {
                double s = Math.Sqrt(x); // حساب الجذر التربيعي
                label3.Text = s.ToString(); // عرض النتيجة في label3
            }
            else
            {
                MessageBox.Show("يرجى إدخال رقم صحيح.");
                textBox1.Focus(); // التركيز على TextBox لإعادة الإدخال
            }
        }
    }
}
