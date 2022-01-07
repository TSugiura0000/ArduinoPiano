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
        Pen pen2;
        public Form2()
        {
            InitializeComponent();
            br = new SolidBrush(Color.Gray);
            pen = new Pen(br);
            pen2 = new Pen(br);
            pen.Width *= 3;
            BackColor = SystemColors.ActiveCaptionText;
            Paint += new PaintEventHandler(DrawLines);
            SizeChanged += new EventHandler(Form2_SizeChanged);
        }

        private void Form2_SizeChanged(object sender, EventArgs e)
        {
            Invalidate();
        }

        void DrawLines(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point ptLeftUp = new Point(ClientSize.Width * 2 / 5, 0);     //左ラインの上の座標
            Point ptLeftDown = new Point(ClientSize.Width / 6,ClientSize.Height);  //左ラインの下の座標
            Point ptRightUp = new Point(ClientSize.Width * 3 / 5, 0);     //右ラインの上の座標
            Point ptRightDown = new Point(ClientSize.Width * 5 / 6, ClientSize.Height); //右ラインの下の座標
            Point ptCenterUp = new Point(ClientSize.Width / 2, 0);  //センターラインの上の座標
            Point ptCenterDown = new Point(ClientSize.Width / 2, ClientSize.Height);    //センターラインの下の座標
            Point pt1Up = new Point(ClientSize.Width * 13 / 30, 0); //左1上の座標
            Point pt1Down = new Point(ClientSize.Width * 10 / 36, ClientSize.Height);    //左1下の座標
            Point pt2Up = new Point(ClientSize.Width * 14 / 30, 0); //左2上の座標
            Point pt2Down = new Point(ClientSize.Width * 14 / 36, ClientSize.Height);   //左2下の座標
            Point pt4Up = new Point(ClientSize.Width * 16 / 30, 0); //右2上の座標
            Point pt4Down = new Point(ClientSize.Width * 22 / 36, ClientSize.Height);   //右2上の座標
            Point pt5Up = new Point(ClientSize.Width * 17 / 30, 0); //右1上の座標
            Point pt5Down = new Point(ClientSize.Width * 26 / 36, ClientSize.Height);   //右1下の座標
            Point ptReadUpLeft = new Point(0, ClientSize.Height * 4 / 5 - ClientSize.Height / 20);  //判定線の左上の座標
            Point ptReadUpRight = new Point(ClientSize.Width, ClientSize.Height * 4 / 5 - ClientSize.Height / 20);  //判定線の右上の座標
            Point ptReadDownLeft = new Point(0, ClientSize.Height * 4 / 5 + ClientSize.Height / 20);    //判定線の左下の座標
            Point ptReadDownRight = new Point(ClientSize.Width, ClientSize.Height * 4 / 5 + ClientSize.Height / 20);    //判定線の右下の座標
            g.DrawLine(pen,ptLeftUp, ptLeftDown);       //右ラインの描画
            g.DrawLine(pen,ptRightUp, ptRightDown);     //左ラインの描画
            g.DrawLine(pen2,ptCenterUp, ptCenterDown);   //センターラインの描画
            g.DrawLine(pen2,pt1Up,pt1Down); //左1の描画
            g.DrawLine(pen2,pt2Up,pt2Down); //左2の描画
            g.DrawLine(pen2,pt4Up,pt4Down); //右2の描画
            g.DrawLine(pen2,pt5Up,pt5Down); //右1の描画
            g.DrawLine(pen2,ptReadUpLeft,ptReadUpRight);    //判定線上の描画
            g.DrawLine(pen2,ptReadDownLeft,ptReadDownRight);    //判定線下の描画
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
