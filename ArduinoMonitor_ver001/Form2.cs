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
        public Form2()
        {
            InitializeComponent();
            Form2_Resize();
            Panel_Resize();
        }
        private void Form2_SizeChanged_1(object sender, EventArgs e)
        {
            Invalidate();   //コントロールの再描画
        }
        private void Form2_Resize()
        {
            this.Size = new System.Drawing.Size(1920, 1080);
        }
        private void Panel_Resize()
        {
            int Form_horizontal_divid = 15;
            int Form_vertical_divid = 12;
            //ピアノ本体の位置とサイズ変更
            panel_Board.Location = new Point(this.Width / Form_horizontal_divid, this.Height * 2 / Form_vertical_divid);
            panel_Board.Size = new Size(this.Width * 13 / Form_horizontal_divid, this.Height * 8 / Form_vertical_divid);

            //白鍵の位置とサイズ変更
            int panel_Board_horizontal_divid = 9;
            int panel_Board_vertical_divid = 10;
            //C
            panel_C.Location = new Point(
                panel_Board.Width * ((panel_Board_horizontal_divid - 7) / 2) / panel_Board_horizontal_divid,
                panel_Board.Height * 2 / panel_Board_vertical_divid
                );
            panel_C.Size = new Size(
                panel_Board.Width / panel_Board_horizontal_divid,
                panel_Board.Height * (panel_Board_vertical_divid - 3) / panel_Board_vertical_divid
                );
            //D
            panel_D.Location = new Point(
                panel_Board.Width * ((panel_Board_horizontal_divid - 7) / 2 + 1) / panel_Board_horizontal_divid, 
                panel_Board.Height * 2 / panel_Board_vertical_divid
                );
            panel_D.Size = new Size(
                panel_Board.Width / panel_Board_horizontal_divid, 
                panel_Board.Height * (panel_Board_vertical_divid - 3) / panel_Board_vertical_divid
                );
            //E
            panel_E.Location = new Point(
                panel_Board.Width * ((panel_Board_horizontal_divid - 7) / 2 + 2) / panel_Board_horizontal_divid,
                panel_Board.Height * 2 / panel_Board_vertical_divid
                );
            panel_E.Size = new Size(
                panel_Board.Width / panel_Board_horizontal_divid,
                panel_Board.Height * (panel_Board_vertical_divid - 3) / panel_Board_vertical_divid
                );
            //F
            panel_F.Location = new Point(
                panel_Board.Width * ((panel_Board_horizontal_divid - 7) / 2 + 3) / panel_Board_horizontal_divid,
                panel_Board.Height * 2 / panel_Board_vertical_divid
                );
            panel_F.Size = new Size(
                panel_Board.Width / panel_Board_horizontal_divid,
                panel_Board.Height * (panel_Board_vertical_divid - 3) / panel_Board_vertical_divid
                );
            //G
            panel_G.Location = new Point(
                panel_Board.Width * ((panel_Board_horizontal_divid - 7) / 2 + 4) / panel_Board_horizontal_divid,
                panel_Board.Height * 2 / panel_Board_vertical_divid
                );
            panel_G.Size = new Size(
                panel_Board.Width / panel_Board_horizontal_divid,
                panel_Board.Height * (panel_Board_vertical_divid - 3) / panel_Board_vertical_divid
                );
            //A
            panel_A.Location = new Point(
                panel_Board.Width * ((panel_Board_horizontal_divid - 7) / 2 + 5) / panel_Board_horizontal_divid,
                panel_Board.Height * 2 / panel_Board_vertical_divid
                );
            panel_A.Size = new Size(
                panel_Board.Width / panel_Board_horizontal_divid,
                panel_Board.Height * (panel_Board_vertical_divid - 3) / panel_Board_vertical_divid
                );
            //B
            panel_B.Location = new Point(
                panel_Board.Width * ((panel_Board_horizontal_divid - 7) / 2 + 6) / panel_Board_horizontal_divid,
                panel_Board.Height * 2 / panel_Board_vertical_divid
                );
            panel_B.Size = new Size(
                panel_Board.Width / panel_Board_horizontal_divid,
                panel_Board.Height * (panel_Board_vertical_divid - 3) / panel_Board_vertical_divid
                );

            //黒鍵の位置とサイズ変更
            //C#
            panel_Csharp.Location = new Point(
                panel_Board.Width * (((panel_Board_horizontal_divid - 7) / 2) * 4 + 3) / (panel_Board_horizontal_divid * 4),
                panel_Board.Height * 2 / panel_Board_vertical_divid
                );
            panel_Csharp.Size = new Size(
                panel_Board.Width / (panel_Board_horizontal_divid * 2),
                panel_Board.Height * (panel_Board_vertical_divid - 5) / panel_Board_vertical_divid
                );
            //D#
            panel_Dsharp.Location = new Point(
                panel_Board.Width * (((panel_Board_horizontal_divid - 7) / 2 + 1) * 4 + 3) / (panel_Board_horizontal_divid * 4),
                panel_Board.Height * 2 / panel_Board_vertical_divid
                );
            panel_Dsharp.Size = new Size(
                panel_Board.Width / (panel_Board_horizontal_divid * 2),
                panel_Board.Height * (panel_Board_vertical_divid - 5) / panel_Board_vertical_divid
                );
            //F#
            panel_Fsharp.Location = new Point(
                panel_Board.Width * (((panel_Board_horizontal_divid - 7) / 2 + 3) * 4 + 3) / (panel_Board_horizontal_divid * 4),
                panel_Board.Height * 2 / panel_Board_vertical_divid
                );
            panel_Fsharp.Size = new Size(
                panel_Board.Width / (panel_Board_horizontal_divid * 2),
                panel_Board.Height * (panel_Board_vertical_divid - 5) / panel_Board_vertical_divid
                );
            //G#
            panel_Gsharp.Location = new Point(
                panel_Board.Width * (((panel_Board_horizontal_divid - 7) / 2 + 4) * 4 + 3) / (panel_Board_horizontal_divid * 4),
                panel_Board.Height * 2 / panel_Board_vertical_divid
                );
            panel_Gsharp.Size = new Size(
                panel_Board.Width / (panel_Board_horizontal_divid * 2),
                panel_Board.Height * (panel_Board_vertical_divid - 5) / panel_Board_vertical_divid
                );
            //A#
            panel_Asharp.Location = new Point(
                panel_Board.Width * (((panel_Board_horizontal_divid - 7) / 2 + 5) * 4 + 3) / (panel_Board_horizontal_divid * 4),
                panel_Board.Height * 2 / panel_Board_vertical_divid
                );
            panel_Asharp.Size = new Size(
                panel_Board.Width / (panel_Board_horizontal_divid * 2),
                panel_Board.Height * (panel_Board_vertical_divid - 5) / panel_Board_vertical_divid
                );
        }

        private void panel_C_MouseDown(object sender, MouseEventArgs e)
        {
            whitePanel_MouseDown(panel_C);
        }

        private void panel_C_MouseUp(object sender, MouseEventArgs e)
        {
            whitePanel_MouseUp(panel_C);
        }

        private void panel_D_MouseDown(object sender, MouseEventArgs e)
        {
            whitePanel_MouseDown(panel_D);
        }

        private void panel_D_MouseUp(object sender, MouseEventArgs e)
        {
            whitePanel_MouseUp(panel_D);
        }

        private void panel_E_MouseDown(object sender, MouseEventArgs e)
        {
            whitePanel_MouseDown(panel_E);
        }

        private void panel_E_MouseUp(object sender, MouseEventArgs e)
        {
            whitePanel_MouseUp(panel_E);
        }

        private void panel_F_MouseDown(object sender, MouseEventArgs e)
        {
            whitePanel_MouseDown(panel_F);
        }

        private void panel_F_MouseUp(object sender, MouseEventArgs e)
        {
            whitePanel_MouseUp(panel_F);
        }

        private void panel_G_MouseDown(object sender, MouseEventArgs e)
        {
            whitePanel_MouseDown(panel_G);
        }

        private void panel_G_MouseUp(object sender, MouseEventArgs e)
        {
            whitePanel_MouseUp(panel_G);
        }

        private void panel_A_MouseDown(object sender, MouseEventArgs e)
        {
            whitePanel_MouseDown(panel_A);
        }

        private void panel_A_MouseUp(object sender, MouseEventArgs e)
        {
            whitePanel_MouseUp(panel_A);
        }

        private void panel_B_MouseDown(object sender, MouseEventArgs e)
        {
            whitePanel_MouseDown(panel_B);
        }

        private void panel_B_MouseUp(object sender, MouseEventArgs e)
        {
            whitePanel_MouseUp(panel_B);
        }

        private void whitePanel_MouseDown(Panel p)
        {
            p.BackColor = Color.LightGray;
            p.BorderStyle = BorderStyle.FixedSingle;
        }

        private void whitePanel_MouseUp(Panel p)
        {
            p.BackColor = Color.White;
            p.BorderStyle = BorderStyle.Fixed3D;
        }
    }
}
