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
    public partial class Form3 : Form
    {
        double x, y, z;
        string[] op = { "+", "-", "*", "/" };
        public Form3()
        {
            InitializeComponent();
            listBox1.Items.AddRange(op);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("ادخل تعداد في الصناديق!!");
                return;
            }
            try
            {
                x = Convert.ToDouble(textBox1.Text);
            }
            catch (Exception)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("ادخل العدد الاول!!");
                    textBox3.Clear();
                    textBox1.Focus();
                    return;

                }
                else
                {
                    MessageBox.Show("العدد الاول غير صحيح!!");
                    textBox1.Clear();
                    textBox1.Focus();
                    return;
                }
            }
            try
            {
                y = Convert.ToDouble(textBox2.Text);

            }
            catch (Exception)
            {

                if (textBox2.Text == "")
                {
                    MessageBox.Show("ادخل اعداد في الصندوق الثاني");
                    textBox3.Clear();
                    textBox2.Focus();
                    return;
                }
                else
                {
                    MessageBox.Show("العدد الثاني غير صحيح!!");
                    textBox2.Clear();
                    textBox2.Focus();
                    return;
                }
            }
            bool q = true;
            switch (listBox1.SelectedIndex)
            {
                case 0: z = x + y; break;
                case 1: z = x - y; break;
                case 2: z = x * y; break;
                case 3:
                    {
                        if (y != 0)
                        {
                            z = x / y;
                        }
                        else
                        {
                            MessageBox.Show("لا يمكنك القسمة على الصفر!");
                            q = false;
                            textBox3.Text = "";
                            textBox2.Focus();
                            return;
                        }
                        break;
                    }
                default:
                    MessageBox.Show("ادخل العمليه!");
                    listBox1.Focus();
                    break;

            }

            if (q)
            {
                textBox3.Text = z.ToString();
            }
            else
            {
                textBox3.Clear();
                textBox2.Focus();
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            listBox1.ClearSelected();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(op);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4=new Form4();
            form4.ShowDialog();
        }
    }
}
