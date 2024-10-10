namespace lab_2_home_work
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textnumber1.Focus();
            textBox6result.ReadOnly = true;
            textBox2opreation1.Enabled = textBox3number2.Enabled = textBox4opreation2.Enabled
                = textBox5number3.Enabled = false;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textnumber1_TextChanged(object sender, EventArgs e)
        {

            if (textnumber1.Text != null && textnumber1.Text != "")
            {
                textBox2opreation1.Enabled = true;
            }
            else
            {
                textBox2opreation1.Enabled = false;
            }
        }

        private void textBox2opreation1_TextChanged(object sender, EventArgs e)
        {
            if (textBox2opreation1.Text != null && textBox2opreation1.Text != "")
            {
                textBox3number2.Enabled = true;
            }
            else
            {
                textBox3number2.Enabled = false;
            }
        }

        private void textBox4opreation2_TextChanged(object sender, EventArgs e)
        {
            if (textBox4opreation2.Text != null && textBox4opreation2.Text != "")
            {
                textBox5number3.Enabled = true;
            }
            else
            {
                textBox5number3.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double number1, number2, number3;
            string operation1 = textBox2opreation1.Text;
            string operation2 = textBox4opreation2.Text;
            string intermediateresult = "";
            string finalresult = "";



            if (double.TryParse(textnumber1.Text, out number1) && double.TryParse(textBox3number2.Text, out number2) && double.TryParse(textBox5number3.Text, out number3))
            {
                double result1 = preformoperation(number2, number3, operation2); //  ‰›Ì– «·⁄„·Ì… «·À«‰Ì… √Ê·«

                if (double.IsNaN(result1))
                {
                    MessageBox.Show("«·⁄„·Ì… «·Õ”«»ÌÂ «·À«‰Ì… €Ì— ’ÕÌÕ…!");
                    textBox4opreation2.Focus();
                    return;
                }

                double result2 = preformoperation(number1, result1, operation1); //  ‰›Ì– «·⁄„·Ì… «·√Ê·Ï

                if (double.IsNaN(result2))
                {
                    MessageBox.Show("«·⁄„·Ì… «·Õ”«»ÌÂ «·√Ê·Ï €Ì— ’ÕÌÕ…!");
                    textBox4opreation2.Focus();
                    return;
                }

                textBox6result.Text = result2.ToString();
            }
            else
            {
                MessageBox.Show("Ì—ÃÏ ≈œŒ«· √—ﬁ«„ ’ÕÌÕ…!");
            }
        }
        private double preformoperation(double num1, double num2, string operation)
        {
            switch (operation)
            {
                case "+":
                    return num1 + num2;
                case "-":
                    return num1 - num2;
                case "*":
                    return num1 * num2;
                case "/":
                    return num2 != 0 ? num1 / num2 : double.NaN;
                default:

                    return double.NaN;

            }
        }

        private void textnumber1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("«—ﬁ«„ ›ﬁÿ");
            }
        }

        private void textBox3number2_TextChanged(object sender, EventArgs e)
        {
            if (textBox3number2.Text != null && textBox3number2.Text != "")
                textBox4opreation2.Enabled = true;
            else
                textBox4opreation2.Enabled = false;
        }

        private void textBox3number2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("«—ﬁ«„ ›ﬁÿ");
            }
        }

        private void textBox5number3_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("«—ﬁ«„ ›ﬁÿ");
            }
        }

        private void textBox2opreation1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '+' && e.KeyChar != '*' && e.KeyChar != '/' && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("«·—Ã«¡ ≈œŒ«· ⁄·«„«  «·Ã„⁄ «Ê«·÷—» «Ê«·ﬁ”„… «Ê «·ÿ—Õ ›ﬁÿ");
            }
        }

        private void textBox4opreation2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '+' && e.KeyChar != '*' && e.KeyChar != '/' && e.KeyChar != 8)
            {
                e.Handled = true;
                MessageBox.Show("«·—Ã«¡ ≈œŒ«· ⁄·«„«  «·Ã„⁄ «Ê«·÷—» «Ê«·ﬁ”„… «Ê «·ÿ—Õ ›ﬁÿ");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // ≈‰‘«¡ ﬂ«∆‰ ⁄‘Ê«∆Ì · Ê·Ìœ √·Ê«‰ ⁄‘Ê«∆Ì…
            Random random = new Random();

            //  Ê·Ìœ ﬁÌ„ ⁄‘Ê«∆Ì… ··√·Ê«‰ «·√Õ„—° «·√Œ÷— Ê«·√“—ﬁ
            int red = random.Next(0, 256);
            int green = random.Next(0, 256);
            int blue = random.Next(0, 256);

            //  €ÌÌ— ·Ê‰ «·‹ Form ≈·Ï «··Ê‰ «·ÃœÌœ
            this.BackColor = Color.FromArgb(red, green, blue);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 newform = new Form2();
            newform.Show();
            this.Hide();    
        }
    }
}
