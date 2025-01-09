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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label5 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            customers = new DataGridView();
            deleteBtn = new Button();
            updateBtn = new Button();
            addBtn = new Button();
            saveBtn = new Button();
            label4 = new Label();
            label6 = new Label();
            label1 = new Label();
            label3 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            nameInput = new TextBox();
            emailInput = new TextBox();
            numberInput = new TextBox();
            addressInput = new TextBox();
            textBox9 = new TextBox();
            dateOpenedInput = new TextBox();
            typeInput = new TextBox();
            accountIdInput = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customers).BeginInit();
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
            label5.Size = new Size(490, 44);
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
            label2.Size = new Size(125, 23);
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
            panel3.Controls.Add(customers);
            panel3.Controls.Add(deleteBtn);
            panel3.Controls.Add(updateBtn);
            panel3.Controls.Add(addBtn);
            panel3.Controls.Add(saveBtn);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(nameInput);
            panel3.Controls.Add(emailInput);
            panel3.Controls.Add(numberInput);
            panel3.Controls.Add(addressInput);
            panel3.Controls.Add(textBox9);
            panel3.Controls.Add(dateOpenedInput);
            panel3.Controls.Add(typeInput);
            panel3.Controls.Add(accountIdInput);
            panel3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(37, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(785, 505);
            panel3.TabIndex = 2;
            // 
            // customers
            // 
            customers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customers.Location = new Point(3, 326);
            customers.Name = "customers";
            customers.RowHeadersWidth = 51;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            customers.RowsDefaultCellStyle = dataGridViewCellStyle1;
            customers.Size = new Size(777, 174);
            customers.TabIndex = 3;
            // 
            // deleteBtn
            // 
            deleteBtn.AutoSize = true;
            deleteBtn.BackColor = Color.IndianRed;
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Location = new Point(558, 278);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(115, 33);
            deleteBtn.TabIndex = 1;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            // 
            // updateBtn
            // 
            updateBtn.AutoSize = true;
            updateBtn.BackColor = Color.IndianRed;
            updateBtn.FlatAppearance.BorderSize = 0;
            updateBtn.FlatStyle = FlatStyle.Flat;
            updateBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateBtn.ForeColor = Color.White;
            updateBtn.Location = new Point(437, 278);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(115, 33);
            updateBtn.TabIndex = 1;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            // 
            // addBtn
            // 
            addBtn.AutoSize = true;
            addBtn.BackColor = Color.IndianRed;
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(221, 278);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(115, 33);
            addBtn.TabIndex = 1;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.AutoSize = true;
            saveBtn.BackColor = Color.IndianRed;
            saveBtn.FlatAppearance.BorderSize = 0;
            saveBtn.FlatStyle = FlatStyle.Flat;
            saveBtn.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = Color.White;
            saveBtn.Location = new Point(100, 278);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(115, 33);
            saveBtn.TabIndex = 1;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(96, 13);
            label4.Name = "label4";
            label4.Size = new Size(175, 23);
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
            label6.Size = new Size(62, 23);
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
            label1.Size = new Size(157, 23);
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
            label3.Size = new Size(88, 23);
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
            label9.Size = new Size(125, 23);
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
            label8.Size = new Size(152, 23);
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
            label7.Size = new Size(151, 23);
            label7.TabIndex = 1;
            label7.Text = "Account_Type";
            // 
            // nameInput
            // 
            nameInput.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameInput.Location = new Point(100, 37);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(264, 32);
            nameInput.TabIndex = 0;
            // 
            // emailInput
            // 
            emailInput.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailInput.Location = new Point(100, 156);
            emailInput.Name = "emailInput";
            emailInput.Size = new Size(264, 32);
            emailInput.TabIndex = 0;
            // 
            // numberInput
            // 
            numberInput.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numberInput.Location = new Point(100, 94);
            numberInput.Name = "numberInput";
            numberInput.Size = new Size(264, 32);
            numberInput.TabIndex = 0;
            // 
            // addressInput
            // 
            addressInput.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressInput.Location = new Point(100, 216);
            addressInput.Name = "addressInput";
            addressInput.Size = new Size(264, 32);
            addressInput.TabIndex = 0;
            addressInput.TextChanged += textBox6_TextChanged;
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox9.Location = new Point(411, 216);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(264, 32);
            textBox9.TabIndex = 0;
            // 
            // dateOpenedInput
            // 
            dateOpenedInput.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateOpenedInput.Location = new Point(412, 156);
            dateOpenedInput.Name = "dateOpenedInput";
            dateOpenedInput.Size = new Size(264, 32);
            dateOpenedInput.TabIndex = 0;
            // 
            // typeInput
            // 
            typeInput.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            typeInput.Location = new Point(412, 94);
            typeInput.Name = "typeInput";
            typeInput.Size = new Size(264, 32);
            typeInput.TabIndex = 0;
            // 
            // accountIdInput
            // 
            accountIdInput.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            accountIdInput.Location = new Point(413, 37);
            accountIdInput.Name = "accountIdInput";
            accountIdInput.Size = new Size(264, 32);
            accountIdInput.TabIndex = 0;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            ((System.ComponentModel.ISupportInitialize)customers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Button saveBtn;
        private Label label4;
        private Label label1;
        private TextBox nameInput;
        private TextBox numberInput;
        private TextBox accountIdInput;
        private Button deleteBtn;
        private Button updateBtn;
        private Button addBtn;
        private DataGridView customers;
        private Label label5;
        private Label label6;
        private Label label3;
        private TextBox emailInput;
        private TextBox addressInput;
        private Label label9;
        private Label label8;
        private Label label7;
        private TextBox textBox9;
        private TextBox dateOpenedInput;
        private TextBox typeInput;
    }
}