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
            pen.Width *= 3;
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
            Point ptLeftUp = new Point(ClientSize.Width * 2 / 5, 0);     //左ラインの上の座標
            Point ptLeftDown = new Point(ClientSize.Width / 6,ClientSize.Height);  //左ラインの下の座標
            Point ptRightUp = new Point(ClientSize.Width * 3 / 5, 0);     //右ラインの上の座標
            Point ptRightDown = new Point(ClientSize.Width * 5 / 6, ClientSize.Height); //右ラインの下の座標
            Point ptCenterUp = new Point(ClientSize.Width / 2, 0);  //センターラインの上の座標
            Point ptCenterDown = new Point(ClientSize.Width / 2, ClientSize.Height);    //センターラインの下の座標
            g.DrawLine(pen,ptLeftUp, ptLeftDown);       //右ラインの描画
            g.DrawLine(pen,ptRightUp, ptRightDown);     //左ラインの描画
            g.DrawLine(pen,ptCenterUp, ptCenterDown);   //センターラインの描画
        }
    }
}
