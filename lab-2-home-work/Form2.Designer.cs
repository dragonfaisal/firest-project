namespace lab_2_home_work
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            rmblue = new Button();
            label2 = new Label();
            label4 = new Label();
            Brownform = new Label();
            rmgreen = new Button();
            rmred = new Button();
            rmcolor = new Button();
            label5 = new Label();
            label6 = new Label();
            vrtype = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlDarkDark;
            label1.ForeColor = Color.FromArgb(255, 255, 192);
            label1.Location = new Point(234, 46);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 0;
            label1.Text = "اختر لون الصفحة";
            // 
            // rmblue
            // 
            rmblue.Location = new Point(12, 202);
            rmblue.Name = "rmblue";
            rmblue.Size = new Size(75, 23);
            rmblue.TabIndex = 1;
            rmblue.Text = "Blue";
            rmblue.UseVisualStyleBackColor = true;
            rmblue.Click += rmblue_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 46);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 2;
            label2.Text = "<<";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 46);
            label4.Name = "label4";
            label4.Size = new Size(23, 15);
            label4.TabIndex = 4;
            label4.Text = "<<";
            // 
            // Brownform
            // 
            Brownform.AutoSize = true;
            Brownform.BackColor = Color.FromArgb(64, 64, 0);
            Brownform.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Brownform.ForeColor = Color.Olive;
            Brownform.Location = new Point(22, 35);
            Brownform.Name = "Brownform";
            Brownform.Size = new Size(45, 30);
            Brownform.TabIndex = 5;
            Brownform.Text = "بني";
            Brownform.Click += Brownform_Click;
            // 
            // rmgreen
            // 
            rmgreen.Location = new Point(46, 231);
            rmgreen.Name = "rmgreen";
            rmgreen.Size = new Size(75, 23);
            rmgreen.TabIndex = 6;
            rmgreen.Text = "Green";
            rmgreen.UseVisualStyleBackColor = true;
            rmgreen.Click += rmgreen_Click;
            // 
            // rmred
            // 
            rmred.Location = new Point(247, 202);
            rmred.Name = "rmred";
            rmred.Size = new Size(75, 23);
            rmred.TabIndex = 7;
            rmred.Text = "Red";
            rmred.UseVisualStyleBackColor = true;
            rmred.Click += rmred_Click;
            // 
            // rmcolor
            // 
            rmcolor.Location = new Point(216, 231);
            rmcolor.Name = "rmcolor";
            rmcolor.Size = new Size(75, 23);
            rmcolor.TabIndex = 8;
            rmcolor.Text = "Color";
            rmcolor.UseVisualStyleBackColor = true;
            rmcolor.Click += rmcolor_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Navy;
            label5.BorderStyle = BorderStyle.Fixed3D;
            label5.Enabled = false;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Teal;
            label5.Location = new Point(180, 364);
            label5.Name = "label5";
            label5.Size = new Size(153, 27);
            label5.TabIndex = 9;
            label5.Text = "نوع الأداة المختارة";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(113, 372);
            label6.Name = "label6";
            label6.Size = new Size(23, 15);
            label6.TabIndex = 10;
            label6.Text = "<<";
            // 
            // vrtype
            // 
            vrtype.AutoSize = true;
            vrtype.BackColor = Color.Fuchsia;
            vrtype.BorderStyle = BorderStyle.Fixed3D;
            vrtype.Enabled = false;
            vrtype.FlatStyle = FlatStyle.Flat;
            vrtype.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            vrtype.ForeColor = Color.Teal;
            vrtype.Location = new Point(12, 372);
            vrtype.Name = "vrtype";
            vrtype.Size = new Size(56, 27);
            vrtype.TabIndex = 11;
            vrtype.Text = "Type";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Yellow;
            button1.Location = new Point(118, 46);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "Yllow";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Chocolate;
            button2.Location = new Point(90, 306);
            button2.Name = "button2";
            button2.Size = new Size(124, 23);
            button2.TabIndex = 13;
            button2.Text = "NEXT-FORM>>";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 440);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(vrtype);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(rmcolor);
            Controls.Add(rmred);
            Controls.Add(rmgreen);
            Controls.Add(Brownform);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(rmblue);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button rmblue;
        private Label label2;
        private Label label4;
        private Label Brownform;
        private Button rmgreen;
        private Button rmred;
        private Button rmcolor;
        private Label label5;
        private Label label6;
        private Label vrtype;
        private Button button1;
        private Button button2;
    }
}