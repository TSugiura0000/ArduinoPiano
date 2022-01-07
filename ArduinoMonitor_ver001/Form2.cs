using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoMonitor_ver001
{
    public partial class Form2 : Form
    {
        SolidBrush br;
        Pen pen;
        public Form2()
        {
            InitializeComponent();
            br = new SolidBrush(Color.Gray);
            pen = new Pen(br);
            BackColor = SystemColors.ActiveCaptionText;
            Paint += new PaintEventHandler(DrawLine01_Paint);
            SizeChanged += new EventHandler(Form2_SizeChanged);
        }

        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        void DrawLine01_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point pt1 = new Point(ClientSize.Width * 2 / 5, 0);     //左ラインの上の座標
            Point pt2 = new Point(ClientSize.Width / 6,ClientSize.Height);  //左ラインの下の座標
            Point pt3 = new Point(ClientSize.Width * 3 / 5, 0);     //右ラインの上の座標
            Point pt4 = new Point(ClientSize.Width * 5 / 6, ClientSize.Height); //右ラインの下の座標
            g.DrawLine(pen,pt1, pt2);
            g.DrawLine(pen,pt3,pt4);
        }
    }
}
