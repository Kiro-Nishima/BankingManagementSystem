namespace BankingManagementSystem
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnLogIn = new Button();
            passwordInput = new TextBox();
            usernameInput = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 617);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(311, 617);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnLogIn);
            panel2.Controls.Add(passwordInput);
            panel2.Controls.Add(usernameInput);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(311, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(819, 617);
            panel2.TabIndex = 1;
            // 
            // btnLogIn
            // 
            btnLogIn.AutoSize = true;
            btnLogIn.BackColor = Color.Maroon;
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(220, 453);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(386, 54);
            btnLogIn.TabIndex = 3;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // passwordInput
            // 
            passwordInput.BorderStyle = BorderStyle.None;
            passwordInput.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passwordInput.Location = new Point(220, 309);
            passwordInput.Name = "passwordInput";
            passwordInput.Size = new Size(386, 36);
            passwordInput.TabIndex = 1;
            passwordInput.UseSystemPasswordChar = true;
            // 
            // usernameInput
            // 
            usernameInput.BorderStyle = BorderStyle.None;
            usernameInput.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernameInput.Location = new Point(220, 215);
            usernameInput.Name = "usernameInput";
            usernameInput.Size = new Size(386, 36);
            usernameInput.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(220, 276);
            label3.Name = "label3";
            label3.Size = new Size(95, 22);
            label3.TabIndex = 0;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(215, 182);
            label2.Name = "label2";
            label2.Size = new Size(101, 22);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(283, 9);
            label1.Name = "label1";
            label1.Size = new Size(256, 78);
            label1.TabIndex = 0;
            label1.Text = "LOG IN";
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            ClientSize = new Size(1130, 617);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogIn";
            Text = "LogIn";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private TextBox usernameInput;
        private TextBox passwordInput;
        private Label label3;
        private Label label2;
        private Button btnLogIn;
    }
}