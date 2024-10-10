namespace lab_2_home_work
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textnumber1 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox2opreation1 = new TextBox();
            label3 = new Label();
            textBox3number2 = new TextBox();
            label4 = new Label();
            textBox4opreation2 = new TextBox();
            label5 = new Label();
            textBox5number3 = new TextBox();
            label6 = new Label();
            textBox6result = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // textnumber1
            // 
            textnumber1.BorderStyle = BorderStyle.FixedSingle;
            textnumber1.Font = new Font("Segoe UI Emoji", 9F);
            textnumber1.Location = new Point(133, 57);
            textnumber1.Name = "textnumber1";
            textnumber1.Size = new Size(100, 23);
            textnumber1.TabIndex = 0;
            textnumber1.TextChanged += textnumber1_TextChanged;
            textnumber1.KeyPress += textnumber1_KeyPress;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Lime;
            button1.Location = new Point(5, 351);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "count";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(27, 60);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 2;
            label1.Text = "number-1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(27, 101);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 4;
            label2.Text = "opreation-1";
            // 
            // textBox2opreation1
            // 
            textBox2opreation1.BorderStyle = BorderStyle.FixedSingle;
            textBox2opreation1.Font = new Font("Segoe UI Emoji", 9F);
            textBox2opreation1.Location = new Point(133, 98);
            textBox2opreation1.Name = "textBox2opreation1";
            textBox2opreation1.Size = new Size(100, 23);
            textBox2opreation1.TabIndex = 3;
            textBox2opreation1.TextChanged += textBox2opreation1_TextChanged;
            textBox2opreation1.KeyPress += textBox2opreation1_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(27, 145);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 6;
            label3.Text = "number-2";
            // 
            // textBox3number2
            // 
            textBox3number2.BorderStyle = BorderStyle.FixedSingle;
            textBox3number2.Font = new Font("Segoe UI Emoji", 9F);
            textBox3number2.Location = new Point(133, 142);
            textBox3number2.Name = "textBox3number2";
            textBox3number2.Size = new Size(100, 23);
            textBox3number2.TabIndex = 5;
            textBox3number2.TextChanged += textBox3number2_TextChanged;
            textBox3number2.KeyPress += textBox3number2_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(27, 196);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 8;
            label4.Text = "opreation-2";
            // 
            // textBox4opreation2
            // 
            textBox4opreation2.BorderStyle = BorderStyle.FixedSingle;
            textBox4opreation2.Font = new Font("Segoe UI Emoji", 9F);
            textBox4opreation2.Location = new Point(133, 193);
            textBox4opreation2.Name = "textBox4opreation2";
            textBox4opreation2.Size = new Size(100, 23);
            textBox4opreation2.TabIndex = 7;
            textBox4opreation2.TextChanged += textBox4opreation2_TextChanged;
            textBox4opreation2.KeyPress += textBox4opreation2_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(27, 245);
            label5.Name = "label5";
            label5.Size = new Size(76, 20);
            label5.TabIndex = 10;
            label5.Text = "number-3";
            // 
            // textBox5number3
            // 
            textBox5number3.BorderStyle = BorderStyle.FixedSingle;
            textBox5number3.Font = new Font("Segoe UI Emoji", 9F);
            textBox5number3.Location = new Point(133, 242);
            textBox5number3.Name = "textBox5number3";
            textBox5number3.Size = new Size(100, 23);
            textBox5number3.TabIndex = 9;
            textBox5number3.KeyPress += textBox5number3_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(27, 290);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 12;
            label6.Text = "result";
            // 
            // textBox6result
            // 
            textBox6result.BorderStyle = BorderStyle.FixedSingle;
            textBox6result.Font = new Font("Segoe UI Emoji", 9F);
            textBox6result.Location = new Point(133, 287);
            textBox6result.Name = "textBox6result";
            textBox6result.Size = new Size(100, 23);
            textBox6result.TabIndex = 11;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Red;
            button2.Location = new Point(211, 351);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.System;
            button3.ForeColor = Color.Purple;
            button3.Location = new Point(107, 327);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 14;
            button3.Text = "واحهة";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.System;
            button4.ForeColor = Color.Purple;
            button4.Location = new Point(86, 366);
            button4.Name = "button4";
            button4.Size = new Size(119, 23);
            button4.TabIndex = 15;
            button4.Text = "NEXT_FORM>>";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 401);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(textBox6result);
            Controls.Add(label5);
            Controls.Add(textBox5number3);
            Controls.Add(label4);
            Controls.Add(textBox4opreation2);
            Controls.Add(label3);
            Controls.Add(textBox3number2);
            Controls.Add(label2);
            Controls.Add(textBox2opreation1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textnumber1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textnumber1;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox2opreation1;
        private Label label3;
        private TextBox textBox3number2;
        private Label label4;
        private TextBox textBox4opreation2;
        private Label label5;
        private TextBox textBox5number3;
        private Label label6;
        private TextBox textBox6result;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
