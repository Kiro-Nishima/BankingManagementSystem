namespace BankingManagementSystem
{
    partial class AboutUs
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
            TreeView = new TreeView();
            graphPanel = new Panel();
            label3 = new Label();
            panel1.SuspendLayout();
            graphPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(860, 55);
            panel1.TabIndex = 3;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(12, 9);
            label5.Name = "label5";
            label5.Size = new Size(140, 36);
            label5.TabIndex = 1;
            label5.Text = "About Us";
            // 
            // TreeView
            // 
            TreeView.BackColor = Color.Maroon;
            TreeView.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TreeView.ForeColor = Color.White;
            TreeView.Indent = 25;
            TreeView.LineColor = Color.Gold;
            TreeView.Location = new Point(12, 61);
            TreeView.Name = "TreeView";
            TreeView.Size = new Size(836, 251);
            TreeView.TabIndex = 4;
            // 
            // graphPanel
            // 
            graphPanel.BackColor = Color.DarkRed;
            graphPanel.Controls.Add(label3);
            graphPanel.Location = new Point(12, 327);
            graphPanel.Name = "graphPanel";
            graphPanel.Size = new Size(836, 239);
            graphPanel.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(670, 0);
            label3.Name = "label3";
            label3.Size = new Size(163, 102);
            label3.TabIndex = 0;
            label3.Text = "C - Costumer\r\nMB - Merto Bank\r\nMA - Manage Account\r\nMCA - Manage Created\r\n           Account\r\nT - Transaction";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AboutUs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 0, 0);
            ClientSize = new Size(860, 578);
            Controls.Add(graphPanel);
            Controls.Add(TreeView);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AboutUs";
            Text = "AboutUs";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            graphPanel.ResumeLayout(false);
            graphPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private TreeView TreeView;
        private Panel graphPanel;
        private Label label3;
    }
}