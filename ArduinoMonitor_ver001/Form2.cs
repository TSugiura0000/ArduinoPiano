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
            br = new SolidBrush(Color.White);
            pen = new Pen(br);
        }

        private void DrawStage()
        {

        }
    }
}
