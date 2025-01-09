namespace BankingManagementSystem
{
    partial class Customer
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
            panel1 = new Panel();
            label5 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            label4 = new Label();
            label6 = new Label();
            label1 = new Label();
            label3 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox6 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox2 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 55);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(259, 9);
            label5.Name = "label5";
            label5.Size = new Size(386, 36);
            label5.TabIndex = 1;
            label5.Text = "Customer Create Account";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(412, 13);
            label2.Name = "label2";
            label2.Size = new Size(105, 21);
            label2.TabIndex = 1;
            label2.Text = "Account_ID";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(860, 523);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBox6);
            panel3.Controls.Add(textBox9);
            panel3.Controls.Add(textBox8);
            panel3.Controls.Add(textBox7);
            panel3.Controls.Add(textBox2);
            panel3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(37, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(785, 505);
            panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 326);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(777, 174);
            dataGridView1.TabIndex = 3;
            // 
            // button5
            // 
            button5.AutoSize = true;
            button5.BackColor = Color.IndianRed;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(558, 278);
            button5.Name = "button5";
            button5.Size = new Size(115, 31);
            button5.TabIndex = 1;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = Color.IndianRed;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(437, 278);
            button4.Name = "button4";
            button4.Size = new Size(115, 31);
            button4.TabIndex = 1;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.IndianRed;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(221, 278);
            button3.Name = "button3";
            button3.Size = new Size(115, 31);
            button3.TabIndex = 1;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.IndianRed;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(100, 278);
            button2.Name = "button2";
            button2.Size = new Size(115, 31);
            button2.TabIndex = 1;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(96, 13);
            label4.Name = "label4";
            label4.Size = new Size(142, 21);
            label4.TabIndex = 1;
            label4.Text = "Customer_Name";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(99, 132);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 1;
            label6.Text = "Email";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(99, 70);
            label1.Name = "label1";
            label1.Size = new Size(126, 21);
            label1.TabIndex = 1;
            label1.Text = "Phone Number";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(99, 192);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 1;
            label3.Text = "Address";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F);
            label9.ForeColor = Color.White;
            label9.Location = new Point(410, 192);
            label9.Name = "label9";
            label9.Size = new Size(105, 21);
            label9.TabIndex = 1;
            label9.Text = "Account_ID";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(411, 132);
            label8.Name = "label8";
            label8.Size = new Size(124, 21);
            label8.TabIndex = 1;
            label8.Text = "Date_Opened";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(411, 70);
            label7.Name = "label7";
            label7.Size = new Size(125, 21);
            label7.TabIndex = 1;
            label7.Text = "Account_Type";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(100, 37);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(264, 27);
            textBox5.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(100, 156);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(264, 27);
            textBox4.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(100, 94);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(264, 27);
            textBox3.TabIndex = 0;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(100, 216);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(264, 27);
            textBox6.TabIndex = 0;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox9.Location = new Point(411, 216);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(264, 27);
            textBox9.TabIndex = 0;
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox8.Location = new Point(412, 156);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(264, 27);
            textBox8.TabIndex = 0;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox7.Location = new Point(412, 94);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(264, 27);
            textBox7.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(413, 37);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(264, 27);
            textBox2.TabIndex = 0;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            ClientSize = new Size(860, 578);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customer";
            Text = "Account";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Button button2;
        private Label label4;
        private Label label1;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button5;
        private Button button4;
        private Button button3;
        private DataGridView dataGridView1;
        private Label label5;
        private Label label6;
        private Label label3;
        private TextBox textBox4;
        private TextBox textBox6;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
    }
}