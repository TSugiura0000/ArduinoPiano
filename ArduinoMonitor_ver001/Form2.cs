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
            panel1.Location = new Point(ClientSize.Width / 16, ClientSize.Height / 6);
            panel1.Size = new Size(ClientSize.Width * 14 / 16, ClientSize.Height * 4 / 6);
        }
    }
}
