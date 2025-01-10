using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BankingManagementSystem
{
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
            InitializeTree();
            LoadHierarchy();

            graphPanel.Paint += new PaintEventHandler(DrawGraph);
            this.Controls.Add(graphPanel);
        }

        //Tree
        private void InitializeTree()
        {
            TreeView.DrawMode = TreeViewDrawMode.OwnerDrawText;
            TreeView.Font = new Font("Century Gothic", 18);
            TreeView.DrawNode += TreeHierarchyDrawMode;
        }

        private void LoadHierarchy()
        {
            TreeView.Nodes.Clear();

            var ceoNode = new TreeNode("Mark Well Merto (CEO)") { Tag = "CEO" };

            var manager = new TreeNode("James Bryan Tolentino (Accounting Manager)") { Tag = "MANAGER" };
            var manager2 = new TreeNode("John Kraevhen Gemanel (Client Officer)") { Tag = "MANAGER" };

            manager.Nodes.Add(new TreeNode("Nice Given Cabañero (Financial Analyst)") { Tag = "EMPLOYEE" });
            manager2.Nodes.Add(new TreeNode("Kayeri Clayer Damian (Loan Specialist)") { Tag = "EMPLOYEE" });
            manager2.Nodes.Add(new TreeNode("Bjorn Marek Maguyon (Stock Broker)") { Tag = "EMPLOYEE" });

            ceoNode.Nodes.Add(manager);
            ceoNode.Nodes.Add(manager2);
            TreeView.Nodes.Add(ceoNode);

            TreeView.ExpandAll();
        }

        private void TreeHierarchyDrawMode(object sender, DrawTreeNodeEventArgs e)
        {
            //Color backgroundColor = Color.White;
            Color textColor = Color.Black;

            if (e.Node.Tag is string role)
            {
                switch (role)
                {
                    case "CEO":
                       //backgroundColor = Color.Red;
                        textColor = Color.White;
                        break;
                    case "MANAGER":
                        //backgroundColor = Color.;
                        textColor = Color.White;
                        break;
                    case "EMPLOYEE":
                        //backgroundColor = Color.Yellow;
                        textColor = Color.White;
                        break;
                }
            }

            //e.Graphics.FillRectangle(new SolidBrush(backgroundColor), e.Bounds);

            TextRenderer.DrawText(
                e.Graphics,
                e.Node.Text,
                TreeView.Font,
                e.Bounds,
                textColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Left
            );

            if ((e.State & TreeNodeStates.Focused) != 0)
            {
                ControlPaint.DrawFocusRectangle(e.Graphics, e.Bounds);
            }
        }

        //Graph
        private void DrawGraph(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Point node1 = new Point(100, 125);
            Point node2 = new Point(250, 125);
            //Point node3 = new Point(250, 200);
            Point node4 = new Point(250, 50);
            Point node5 = new Point(400, 50);
            Point node6 = new Point(400, 125);
            Point node7 = new Point(550, 125);

            int radius = 25;

            g.FillEllipse(Brushes.Blue, new Rectangle(node1.X - radius, node1.Y - radius, 2 * radius, 2 * radius));
            g.FillEllipse(Brushes.Red, new Rectangle(node2.X - radius, node2.Y - radius, 2 * radius, 2 * radius));
            //g.FillEllipse(Brushes.Blue, new Rectangle(node3.X - radius, node3.Y - radius, 2 * radius, 2 * radius));
            g.FillEllipse(Brushes.DarkSalmon, new Rectangle(node4.X - radius, node4.Y - radius, 2 * radius, 2 * radius));
            g.FillEllipse(Brushes.DarkSalmon, new Rectangle(node5.X - radius, node5.Y - radius, 2 * radius, 2 * radius));
            g.FillEllipse(Brushes.DarkSalmon, new Rectangle(node6.X - radius, node6.Y - radius, 2 * radius, 2 * radius));
            g.FillEllipse(Brushes.Green, new Rectangle(node7.X - radius, node7.Y - radius, 2 * radius, 2 * radius));

            Font font = new Font("Century Gothic", 12, FontStyle.Bold);
            Brush textBrush = Brushes.White; 
            g.DrawString("C", font, textBrush, node1.X - radius / 3, node1.Y - radius / 2.5f);
            g.DrawString("MB", font, textBrush, node2.X - radius / 1.8f, node2.Y - radius / 2.5f);
            //g.DrawString("E", font, textBrush, node3.X - radius / 3, node3.Y - radius / 2.5f);
            g.DrawString("MA", font, textBrush, node4.X - radius / 1.8f, node4.Y - radius / 2.5f);
            g.DrawString("MCA", font, textBrush, node5.X - radius / 1.2f, node5.Y - radius / 2.5f);
            g.DrawString("T", font, textBrush, node6.X - radius / 3, node6.Y - radius / 2.5f);
            g.DrawString("END", font, textBrush, node7.X - radius / 1.5f, node7.Y - radius / 2.5f);

            Pen arrowPen = new Pen(Color.Black, 2);

            Point point1 = GetPointOnCircle(node1, node2, radius);
            Point point2 = GetPointOnCircle(node2, node1, radius);

            //Point point3 = GetPointOnCircle(node2, node3, radius);
            //Point point4 = GetPointOnCircle(node3, node2, radius);

            Point point5 = GetPointOnCircle(node2, node4, radius);
            Point point6 = GetPointOnCircle(node4, node2, radius);

            Point point7 = GetPointOnCircle(node4, node5, radius);
            Point point8 = GetPointOnCircle(node5, node4, radius);

            Point point9 = GetPointOnCircle(node5, node6, radius);
            Point point10 = GetPointOnCircle(node6, node5, radius);

            Point point11 = GetPointOnCircle(node6, node7, radius);
            Point point12 = GetPointOnCircle(node7, node6, radius);

            //Point point13 = GetPointOnCircle(node3, node7, radius);
            //Point point14 = GetPointOnCircle(node7, node3, radius);

            Point point15 = GetPointOnCircle(node2, node6, radius);
            Point point16 = GetPointOnCircle(node6, node2, radius);

            g.DrawLine(arrowPen, point1, point2); 
            //g.DrawLine(arrowPen, point3, point4);
            g.DrawLine(arrowPen, point5, point6);
            g.DrawLine(arrowPen, point7, point8);
            g.DrawLine(arrowPen, point9, point10);
            g.DrawLine(arrowPen, point11, point12);
            //g.DrawLine(arrowPen, point13, point14);
            g.DrawLine(arrowPen, point15, point16);

            DrawArrowHead(g, point1, point2);
            //DrawArrowHead(g, point3, point4);
            //DrawArrowHead(g, point4, point3);
            DrawArrowHead(g, point5, point6);
            DrawArrowHead(g, point7, point8);
            DrawArrowHead(g, point9, point10);
            DrawArrowHead(g, point11, point12);
            //DrawArrowHead(g, point13, point14);
            DrawArrowHead(g, point15, point16);
        }

        private Point GetPointOnCircle(Point center, Point target, int radius)
        {
            double angle = Math.Atan2(target.Y - center.Y, target.X - center.X);

            int x = center.X + (int)(radius * Math.Cos(angle));
            int y = center.Y + (int)(radius * Math.Sin(angle));

            return new Point(x, y);
        }

        private void DrawArrowHead(Graphics g, Point start, Point end)
        {
            const int arrowSize = 10;

            double angle = Math.Atan2(end.Y - start.Y, end.X - start.X);

            Point arrowPoint1 = new Point(
                end.X - (int)(arrowSize * Math.Cos(angle - Math.PI / 6)),
                end.Y - (int)(arrowSize * Math.Sin(angle - Math.PI / 6))
            );

            Point arrowPoint2 = new Point(
                end.X - (int)(arrowSize * Math.Cos(angle + Math.PI / 6)),
                end.Y - (int)(arrowSize * Math.Sin(angle + Math.PI / 6))
            );

            g.DrawLine(Pens.White, end, arrowPoint1);
            g.DrawLine(Pens.White, end, arrowPoint2);
        }
    }
}
