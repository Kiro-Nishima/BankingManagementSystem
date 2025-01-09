namespace BankingManagementSystem
{
    public partial class Main : Form
    {
        private bool isDragging = false;
        private Point startPoint = new Point(0, 0);

        public Main()
        {
            InitializeComponent();
        }

        private void pbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                startPoint = new Point(e.X, e.Y);
            }
        }

        private void mMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point currentScreenPosition = PointToScreen(e.Location);
                this.Location = new Point(
                    currentScreenPosition.X - startPoint.X,
                    currentScreenPosition.Y - startPoint.Y);
            }
        }

        private void mUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
            }
        }

        private void ShowFormInPanel(Form logIn, Panel panelHolder)
        {
            panelHolder.Controls.Clear();

            logIn.TopLevel = false;
            logIn.Dock = DockStyle.Fill;

            panelHolder.Controls.Add(logIn);
            logIn.Show();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            btnLogIn.Click += (s, e) => ShowFormInPanel(new LogIn(), showFormPanel);
        }
    }
}