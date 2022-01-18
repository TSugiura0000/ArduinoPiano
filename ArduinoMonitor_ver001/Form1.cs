using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;      // シリアル通信に必要
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace ArduinoMonitor_ver001
{
    public partial class Form1 : Form
    {
        Form2 PianoMonitor;

        private ManualResetEvent IsNotReading = new ManualResetEvent(true);
        String[] separator_newline = new String[] { "\r\n" };   // ArduinoはのSerial.println()は改行コードがCR+LFになっている
        

        public Form1()
        {
            InitializeComponent();
            InitializeSerialComponent();
            PianoMonitor = new Form2(this);
        }


        /*　シリアル通信設定用コンボボックスの初期化処理 */
        private void InitializeSerialComponent()
        {
            // 利用可能なCOMポートをすべて追加
            foreach (var portName in SerialPort.GetPortNames())
            {
                comboBox_COMselect.Items.Add(portName);
            }
            // 利用できるCOMポートが1つでもあるなら、コンボボックスをenabledに設定
            if (comboBox_COMselect.Items.Count > 0)
            {
                comboBox_COMselect.SelectedIndex = 0;
                comboBox_COMselect.Enabled = true;
                comboBox_newline.Enabled = true;
                comboBox_baudrate.Enabled = true;
                button_serial_conn.Enabled = true;
            }
            
        }

        private void button_serial_conn_Click(object sender, EventArgs e)
        {
            if ( button_serial_conn.Enabled == true )
            {
                serialPort_Arduino.PortName = comboBox_COMselect.SelectedItem.ToString();   // 選択されたCOMをポート名に設定
                serialPort_Arduino.BaudRate = int.Parse(comboBox_baudrate.SelectedItem.ToString());
                switch (comboBox_newline.SelectedItem.ToString())
                {
                    case "CR+LF":
                        serialPort_Arduino.NewLine = "\r\n";
                        break;

                    case "CR":
                        serialPort_Arduino.NewLine = "\r";
                        break;

                    case "LF":
                        serialPort_Arduino.NewLine = "\n";
                        break;

                    default:
                        return;
                        
                }
                serialPort_Arduino.Parity = System.IO.Ports.Parity.None;
                serialPort_Arduino.DataBits = 8;
                serialPort_Arduino.StopBits = System.IO.Ports.StopBits.One;
                serialPort_Arduino.Handshake = System.IO.Ports.Handshake.RequestToSend;
                serialPort_Arduino.Encoding = Encoding.UTF8;
                serialPort_Arduino.DtrEnable = true;    // これでシリアルポートを開いたときにArduinoにリセットがかかる 
                textBox_rcv_msg.Clear();    // メッセージウィンドウをクリア
                textBox_rcv_msg.Focus();    // メッセージウィンドウにフォーカスを移動

                System.Threading.Thread.Sleep(500);    // リセット待ち
                serialPort_Arduino.Open();	// ポートを開く
                serialPort_Arduino.DiscardInBuffer();   // 受信バッファのデータを破棄 
                
                button_serial_conn.Enabled = false;	// connectボタンを押した直後、利用できないようにする
                button_serial_disconn.Enabled = true;   // disconnectボタンを利用できるようにする
                button_send_msg.Enabled = true;

                label_serial_status.Text = "connected";

                PianoMonitor.Show();
            }

        }

        private void button_serial_disconn_Click(object sender, EventArgs e)
        {
            if ( serialPort_Arduino.IsOpen == true )
            {
                this.IsNotReading.WaitOne();
                serialPort_Arduino.Close();	// ポートを閉じる
                button_serial_conn.Enabled = true;	// connectボタンを利用可能にする
                button_serial_disconn.Enabled = false;   // disconnectボタンを利用できないようにする
                button_send_msg.Enabled = false;
                label_serial_status.Text = "disconnected";
            }
        }

        private void serialPort_Arduino_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {

            //! シリアルポートをオープンしていない場合、処理を行わない.
            if (serialPort_Arduino.IsOpen == false)
            {
                return;
            }

            try
            {
                this.IsNotReading.Reset();  // 読み込み開始を宣言

                string data = serialPort_Arduino.ReadLine();    // ポートから文字列を受信する

                if (!string.IsNullOrEmpty(data))
                {
                    BeginInvoke((MethodInvoker)(() =>	// Form内コンポーネントの更新を受信とは別スレッドで処理
                    {
                        textBox_rcv_msg.AppendText(data + "\r\n");
                    }));

                    String[] splitted = data.Split(separator_newline, StringSplitOptions.RemoveEmptyEntries);   // 区切り文字で分割して空白を除去

                    String[] digits = splitted[0].Split(',');
                    int numeric_count = 0;
                    for (int j = 0; j < digits.Length; j++)
                    {
                        if (double.TryParse(digits[j], out double tmp_digits))
                        {
                            numeric_count++;
                        }
                    }
                    
                }
                this.IsNotReading.Set();    // 読み込み終了を宣言
                Thread.Sleep(50);

            }
            catch (InvalidOperationException)
            {
                //ReadLineの読み取り待ちをしている間にCloseされると発生します
                return;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           // シリアル通信していた場合は、閉じてから終了する
           if (serialPort_Arduino.IsOpen)
           {
                this.IsNotReading.WaitOne();
                serialPort_Arduino.Close();
           }
        }

        private void button_send_msg_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox_send_msg.Text))
            {
                Serial_send_msg(textBox_send_msg.Text);
                textBox_send_msg.Text = null;
                textBox_rcv_msg.Focus();    // メッセージウィンドウにフォーカスを移動
            }
        }

        private void textBox_send_msg_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Serial_send_msg(textBox_send_msg.Text);
                textBox_send_msg.Text = null;
                textBox_rcv_msg.Focus();    // メッセージウィンドウにフォーカスを移動
            }
        }

        public void Serial_send_msg(string msg)
        {
            try
            {
                serialPort_Arduino.WriteLine(msg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "送信エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_save_log_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();  // 名前を付けて保存ダイアログのクラス

            sfd.FileName = "新しいファイル.txt"; //はじめに「ファイル名」で表示される文字列を指定する
            sfd.InitialDirectory = @"C:\";  //はじめに表示されるフォルダを指定する
            sfd.Filter = "テキスト ファイル (*.txt)|*.txt|すべてのファイル(*.*)|*.*";   //[ファイルの種類]に表示される選択肢を指定する
            sfd.Title = "保存先のファイルを選択してください";            //タイトルを設定する
            sfd.RestoreDirectory = true;    //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする

            sfd.ShowDialog();

            StreamWriter sw = new StreamWriter(sfd.FileName, false, Encoding.ASCII);
            sw.Write(textBox_rcv_msg.Text);
            sw.Close();
            MessageBox.Show("Saved.");

        }
    }
}
