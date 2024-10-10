namespace HOME_WORK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button2.Enabled = button1.Enabled =
                button3.Enabled = button4.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // ≈⁄œ«œ«  ›Ê—„ ⁄‰œ «· Õ„Ì·
            textBox3.ReadOnly = true; //  ⁄ÌÌ‰ „—»⁄ «·‰’ «·‰« Ã ﬂ‹ ··ﬁ—«¡… ›ﬁÿ
            this.Text = "Calculator"; //  ⁄œÌ· ⁄‰Ê«‰ «·›Ê—„
            textBox3.ForeColor = Color.RoyalBlue; //  ⁄œÌ· ·Ê‰ «·‰’ œ«Œ· „—»⁄ «·‰’

            // —»ÿ «·√Õœ«À ·„—»⁄Ì «·‰’
            textBox1.TextChanged += textBox1_TextChanged;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox1.KeyPress += textBox1_KeyPress;
            textBox2.KeyPress += textBox2_KeyPress;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // «·”„«Õ ›ﬁÿ »«·√—ﬁ«„ Ê»⁄÷ «·—„Ê“ „À· «·‰ﬁÿ… Ê«·⁄·«„… «·”«·»…
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != 8) && (e.KeyChar != '-') && (e.KeyChar != '.'))
            {
                e.Handled = true;  // ≈·€«¡ «·ÕœÀ ≈–« ﬂ«‰ «·≈œŒ«· €Ì— „”„ÊÕ
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  „  „—Ì— ‰›” „⁄«·Ã… «·≈œŒ«· ·„—»⁄ «·‰’ «·√Ê·
            textBox2_KeyPress(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text)).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // «·‰’  €Ì— Â‰«° ”‰ﬁÊ„ »«· Õﬁﬁ „‰ ﬂ·« „—»⁄Ì «·‰’

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            // ⁄„·Ì… «·ﬁ”„… „⁄ «· Õﬁﬁ „‰ ⁄œ„ «·ﬁ”„… ⁄·Ï «·’›—
            if (textBox2.Text != "0")
            {
                textBox3.Text = (Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Cannot divide by zero!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // ⁄„·Ì… «·ÿ—Õ
            textBox3.Text = (Convert.ToDouble(textBox1.Text)
                - Convert.ToDouble(textBox2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToDouble(textBox1.Text)
                * Convert.ToDouble(textBox2.Text)).ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = (Convert.ToDouble(textBox1.Text)
                +Convert.ToDouble(textBox2.Text)).ToString();
        }
       
    }
}
