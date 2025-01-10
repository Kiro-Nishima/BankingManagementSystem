namespace BankingManagementSystem
{
    partial class Transaction
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label5 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            button4 = new Button();
            button3 = new Button();
            textBox4 = new TextBox();
            textBox1 = new TextBox();
            textBox5 = new TextBox();
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
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(983, 73);
            panel1.TabIndex = 1;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(383, 12);
            label5.Name = "label5";
            label5.Size = new Size(239, 44);
            label5.TabIndex = 1;
            label5.Text = "Transactions";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 73);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(983, 698);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(textBox1);
            panel3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(42, 8);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(879, 673);
            panel3.TabIndex = 2;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(114, 53);
            label4.Name = "label4";
            label4.Size = new Size(150, 23);
            label4.TabIndex = 12;
            label4.Text = "Transaction_ID";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(383, 312);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(386, 32);
            dateTimePicker1.TabIndex = 12;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(114, 111);
            label1.Name = "label1";
            label1.Size = new Size(176, 23);
            label1.TabIndex = 11;
            label1.Text = "Transaction_Type";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(114, 312);
            label7.Name = "label7";
            label7.Size = new Size(178, 23);
            label7.TabIndex = 9;
            label7.Text = "Transaction_date";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 435);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Size = new Size(870, 232);
            dataGridView1.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(114, 243);
            label2.Name = "label2";
            label2.Size = new Size(88, 23);
            label2.TabIndex = 10;
            label2.Text = "Amount";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(383, 111);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(386, 32);
            textBox3.TabIndex = 7;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(114, 175);
            label8.Name = "label8";
            label8.Size = new Size(125, 23);
            label8.TabIndex = 10;
            label8.Text = "Account_ID";
            // 
            // button4
            // 
            button4.AutoSize = true;
            button4.BackColor = Color.IndianRed;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(499, 371);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(131, 44);
            button4.TabIndex = 1;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.IndianRed;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(253, 371);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(131, 44);
            button3.TabIndex = 1;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(383, 243);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(386, 32);
            textBox4.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(383, 175);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(386, 32);
            textBox1.TabIndex = 6;
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(426, 132);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(386, 32);
            textBox5.TabIndex = 5;
            // 
            // Transaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            ClientSize = new Size(983, 771);
            Controls.Add(textBox5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Transaction";
            Text = "Transaction";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Panel panel2;
        private Panel panel3;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button3;
        private Label label1;
        private Label label7;
        private Label label2;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox4;
        private TextBox textBox1;
        private Label label4;
        private TextBox textBox5;
        private DateTimePicker dateTimePicker1;
    }
}