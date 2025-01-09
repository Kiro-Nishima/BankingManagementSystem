namespace BankingManagementSystem
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            formControlPanel = new Panel();
            pbMin = new PictureBox();
            pbExit = new PictureBox();
            showFormPanel = new Panel();
            btnExit = new Button();
            btnLogIn = new Button();
            mainBg = new PictureBox();
            formControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbExit).BeginInit();
            showFormPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)mainBg).BeginInit();
            SuspendLayout();
            // 
            // formControlPanel
            // 
            formControlPanel.BackColor = Color.Maroon;
            formControlPanel.Controls.Add(pbMin);
            formControlPanel.Controls.Add(pbExit);
            formControlPanel.Dock = DockStyle.Top;
            formControlPanel.Location = new Point(0, 0);
            formControlPanel.Name = "formControlPanel";
            formControlPanel.Size = new Size(1130, 33);
            formControlPanel.TabIndex = 0;
            formControlPanel.MouseDown += mDown;
            formControlPanel.MouseMove += mMove;
            formControlPanel.MouseUp += mUp;
            // 
            // pbMin
            // 
            pbMin.BackgroundImage = (Image)resources.GetObject("pbMin.BackgroundImage");
            pbMin.BackgroundImageLayout = ImageLayout.Zoom;
            pbMin.Dock = DockStyle.Right;
            pbMin.Location = new Point(1055, 0);
            pbMin.Name = "pbMin";
            pbMin.Size = new Size(37, 33);
            pbMin.TabIndex = 1;
            pbMin.TabStop = false;
            pbMin.Click += pbMin_Click;
            // 
            // pbExit
            // 
            pbExit.BackgroundImage = (Image)resources.GetObject("pbExit.BackgroundImage");
            pbExit.BackgroundImageLayout = ImageLayout.Zoom;
            pbExit.Dock = DockStyle.Right;
            pbExit.Location = new Point(1092, 0);
            pbExit.Name = "pbExit";
            pbExit.Size = new Size(38, 33);
            pbExit.TabIndex = 0;
            pbExit.TabStop = false;
            pbExit.Click += pbExit_Click;
            // 
            // showFormPanel
            // 
            showFormPanel.BackColor = Color.Transparent;
            showFormPanel.Controls.Add(btnExit);
            showFormPanel.Controls.Add(btnLogIn);
            showFormPanel.Controls.Add(mainBg);
            showFormPanel.Dock = DockStyle.Fill;
            showFormPanel.Location = new Point(0, 33);
            showFormPanel.Name = "showFormPanel";
            showFormPanel.Size = new Size(1130, 617);
            showFormPanel.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.AutoSize = true;
            btnExit.BackColor = Color.Red;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(390, 517);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(343, 51);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // btnLogIn
            // 
            btnLogIn.AutoSize = true;
            btnLogIn.BackColor = Color.Red;
            btnLogIn.FlatAppearance.BorderSize = 0;
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogIn.ForeColor = Color.White;
            btnLogIn.Location = new Point(390, 447);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(343, 51);
            btnLogIn.TabIndex = 2;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // mainBg
            // 
            mainBg.BackColor = Color.Transparent;
            mainBg.BackgroundImage = (Image)resources.GetObject("mainBg.BackgroundImage");
            mainBg.BackgroundImageLayout = ImageLayout.Stretch;
            mainBg.Dock = DockStyle.Fill;
            mainBg.Location = new Point(0, 0);
            mainBg.Name = "mainBg";
            mainBg.Size = new Size(1130, 617);
            mainBg.TabIndex = 0;
            mainBg.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            ClientSize = new Size(1130, 650);
            Controls.Add(showFormPanel);
            Controls.Add(formControlPanel);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            formControlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbExit).EndInit();
            showFormPanel.ResumeLayout(false);
            showFormPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)mainBg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel formControlPanel;
        private PictureBox pbMin;
        private PictureBox pbExit;
        private PictureBox mainBg;
        private Button btnLogIn;
        private Button btnExit;
        public static Panel showFormPanel;
    }
}
