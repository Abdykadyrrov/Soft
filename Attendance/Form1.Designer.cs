namespace Attendance
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
            listBox1 = new ListBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "Abdykadyrov Nurislam", "", "Shabdanov Bakhiyar", "", "Bekmuratov Sultan", "", "Karimov Azizbek" });
            listBox1.Location = new Point(34, 54);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(162, 324);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 25);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 7;
            label1.Text = "Students:";
            // 
            // button1
            // 
            button1.Location = new Point(279, 385);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 25);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 11;
            label2.Text = "Attendance";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(616, 314);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 12;
            label3.Text = "Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(570, 357);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 13;
            label4.Text = "Present:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(576, 399);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 14;
            label5.Text = "Absent:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(668, 362);
            label6.Name = "label6";
            label6.Size = new Size(17, 20);
            label6.TabIndex = 15;
            label6.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(668, 399);
            label7.Name = "label7";
            label7.Size = new Size(17, 20);
            label7.TabIndex = 16;
            label7.Text = "0";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(226, 54);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(79, 24);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "Present";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(333, 54);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(77, 24);
            checkBox2.TabIndex = 18;
            checkBox2.Text = "Absent";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(226, 93);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(79, 24);
            checkBox3.TabIndex = 19;
            checkBox3.Text = "Present";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(333, 93);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(77, 24);
            checkBox4.TabIndex = 20;
            checkBox4.Text = "Absent";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(226, 135);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(79, 24);
            checkBox5.TabIndex = 21;
            checkBox5.Text = "Present";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(333, 135);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(77, 24);
            checkBox6.TabIndex = 22;
            checkBox6.Text = "Absent";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(226, 177);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(79, 24);
            checkBox7.TabIndex = 23;
            checkBox7.Text = "Present";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(333, 177);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(77, 24);
            checkBox8.TabIndex = 24;
            checkBox8.Text = "Absent";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(40, 399);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 25;
            button2.Text = "Add student";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(checkBox8);
            Controls.Add(checkBox7);
            Controls.Add(checkBox6);
            Controls.Add(checkBox5);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(checkBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private Button button2;
    }
}