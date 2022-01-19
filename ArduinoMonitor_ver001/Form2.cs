using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoMonitor_ver001
{
    public partial class Form2 : Form
    {
        Form1 f1;
        public Form2(Form1 f)
        {
            InitializeComponent();
            Form2_Resize();
            Panel_Resize();
            f1 = f;
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


        //各白鍵の反応
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

        //白鍵を押しているときの処理
        public void whitePanel_MouseDown(Panel p)
        {
            string msg;
            p.BackColor = Color.LightGray;
            p.BorderStyle = BorderStyle.FixedSingle;
            msg = p.Name + " ON";
            f1.Serial_send_msg(msg);
        }

        //白鍵を離したときの処理
        public void whitePanel_MouseUp(Panel p)
        {
            string msg;
            p.BackColor = Color.White;
            p.BorderStyle = BorderStyle.Fixed3D;
            msg = p.Name + " OFF";
            f1.Serial_send_msg(msg);
        }

        //各黒鍵の反応
        private void panel_Csharp_MouseDown(object sender, MouseEventArgs e)
        {
            blackPanel_MouseDown(panel_Csharp);
        }
        private void panel_Csharp_MouseUp(object sender, MouseEventArgs e)
        {
            blackPanel_MouseUp(panel_Csharp);
        }
        private void panel_Dsharp_MouseDown(object sender, MouseEventArgs e)
        {
            blackPanel_MouseDown(panel_Dsharp);
        }
        private void panel_Dsharp_MouseUp(object sender, MouseEventArgs e)
        {
            blackPanel_MouseUp(panel_Dsharp);
        }
        private void panel_Fsharp_MouseDown(object sender, MouseEventArgs e)
        {
            blackPanel_MouseDown(panel_Fsharp);
        }
        private void panel_Fsharp_MouseUp(object sender, MouseEventArgs e)
        {
            blackPanel_MouseUp(panel_Fsharp);
        }
        private void panel_Gsharp_MouseDown(object sender, MouseEventArgs e)
        {
            blackPanel_MouseDown(panel_Gsharp);
        }
        private void panel_Gsharp_MouseUp(object sender, MouseEventArgs e)
        {
            blackPanel_MouseUp(panel_Gsharp);
        }
        private void panel_Asharp_MouseDown(object sender, MouseEventArgs e)
        {
            blackPanel_MouseDown(panel_Asharp);
        }
        private void panel_Asharp_MouseUp(object sender, MouseEventArgs e)
        {
            blackPanel_MouseUp(panel_Asharp);
        }

        //黒鍵を押したときの処理
        public void blackPanel_MouseDown(Panel p)
        {
            string msg;
            p.BackColor = Color.DimGray;
            p.BorderStyle = BorderStyle.FixedSingle;
            msg = p.Name + " ON";
            f1.Serial_send_msg(msg);
        }

        //黒鍵を離したときの処理
        public void blackPanel_MouseUp(Panel p)
        {
            string msg;
            p.BackColor = Color.Black;
            p.BorderStyle = BorderStyle.Fixed3D;
            msg = p.Name + " OFF";
            f1.Serial_send_msg(msg);
        }
        public Label GetLabel()
        {
            return label_check;
        }

        private void label_check_TextChanged(object sender, EventArgs e)
        {
            if (label_check.Text == "C ON\r")
            {
                this.whitePanel_MouseDown(panel_C);
            }
            if (label_check.Text == "C OFF\r")
            {
                this.whitePanel_MouseUp(panel_C);
            }
            if (label_check.Text == "Csharp ON\r")
            {
                this.blackPanel_MouseDown(panel_Csharp);
            }
            if (label_check.Text == "Csharp OFF\r")
            {
                this.blackPanel_MouseUp(panel_Csharp);
            }
            if (label_check.Text == "D ON\r")
            {
                this.whitePanel_MouseDown(panel_D);
            }
            if (label_check.Text == "D OFF\r")
            {
                this.whitePanel_MouseUp(panel_D);
            }
            if (label_check.Text == "Dsharp ON\r")
            {
                this.blackPanel_MouseDown(panel_Dsharp);
            }
            if (label_check.Text == "Dsharp OFF\r")
            {
                this.blackPanel_MouseUp(panel_Dsharp);
            }
            if (label_check.Text == "E ON\r")
            {
                this.whitePanel_MouseDown(panel_E);
            }
            if (label_check.Text == "E OFF\r")
            {
                this.whitePanel_MouseUp(panel_E);
            }
            if (label_check.Text == "F ON\r")
            {
                this.whitePanel_MouseDown(panel_F);
            }
            if (label_check.Text == "F OFF\r")
            {
                this.whitePanel_MouseUp(panel_F);
            }
            if (label_check.Text == "Fsharp ON\r")
            {
                this.blackPanel_MouseDown(panel_Fsharp);
            }
            if (label_check.Text == "Fsharp OFF\r")
            {
                this.blackPanel_MouseUp(panel_Fsharp);
            }
            if (label_check.Text == "G ON\r")
            {
                this.whitePanel_MouseDown(panel_G);
            }
            if (label_check.Text == "G OFF\r")
            {
                this.whitePanel_MouseUp(panel_G);
            }
            if (label_check.Text == "Gsharp ON\r")
            {
                this.blackPanel_MouseDown(panel_Gsharp);
            }
            if (label_check.Text == "Gsharp OFF\r")
            {
                this.blackPanel_MouseUp(panel_Gsharp);
            }
            if (label_check.Text == "A ON\r")
            {
                this.whitePanel_MouseDown(panel_A);
            }
            if (label_check.Text == "A OFF\r")
            {
                this.whitePanel_MouseUp(panel_A);
            }
            if (label_check.Text == "Asharp ON\r")
            {
                this.blackPanel_MouseDown(panel_Asharp);
            }
            if (label_check.Text == "Asharp OFF\r")
            {
                this.blackPanel_MouseUp(panel_Asharp);
            }
            if (label_check.Text == "B ON\r")
            {
                this.whitePanel_MouseDown(panel_B);
            }
            if (label_check.Text == "B OFF\r")
            {
                this.whitePanel_MouseUp(panel_B);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
