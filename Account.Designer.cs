namespace BankingManagementSystem
{
    partial class Account
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
            dataGridView1 = new DataGridView();
            button5 = new Button();
            button4 = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            label7 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            textBox6 = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 327);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Size = new Size(777, 173);
            dataGridView1.TabIndex = 3;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
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
            button5.Size = new Size(115, 33);
            button5.TabIndex = 1;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
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
            button4.Size = new Size(115, 33);
            button4.TabIndex = 1;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(860, 523);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(textBox3);
            panel3.Controls.Add(textBox6);
            panel3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(37, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(785, 505);
            panel3.TabIndex = 2;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(100, 248);
            label7.Name = "label7";
            label7.Size = new Size(74, 21);
            label7.TabIndex = 4;
            label7.Text = "Balance";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(100, 185);
            label2.Name = "label2";
            label2.Size = new Size(142, 21);
            label2.TabIndex = 4;
            label2.Text = "Customer_Name";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(100, 123);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 4;
            label1.Text = "Account_Type";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(100, 66);
            label4.Name = "label4";
            label4.Size = new Size(105, 21);
            label4.TabIndex = 4;
            label4.Text = "Account_ID";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox5.Location = new Point(335, 31);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(338, 27);
            textBox5.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(335, 150);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(338, 27);
            textBox4.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(335, 88);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(338, 27);
            textBox3.TabIndex = 0;
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox6.Location = new Point(335, 210);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(338, 27);
            textBox6.TabIndex = 0;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(351, 9);
            label5.Name = "label5";
            label5.Size = new Size(149, 36);
            label5.TabIndex = 1;
            label5.Text = "Accounts";
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 55);
            panel1.TabIndex = 2;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            ClientSize = new Size(860, 578);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Account";
            Text = "Account";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private Button button5;
        private Button button4;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox6;
        private Label label5;
        private Panel panel1;
        private Label label4;
        private Label label7;
        private Label label2;
        private Label label1;
    }
}