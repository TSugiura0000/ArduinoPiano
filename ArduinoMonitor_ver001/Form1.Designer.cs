namespace ArduinoMonitor_ver001
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox_COMselect = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_baudrate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_newline = new System.Windows.Forms.ComboBox();
            this.button_serial_conn = new System.Windows.Forms.Button();
            this.button_serial_disconn = new System.Windows.Forms.Button();
            this.serialPort_Arduino = new System.IO.Ports.SerialPort(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label_serial_status = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_send_msg = new System.Windows.Forms.TextBox();
            this.button_send_msg = new System.Windows.Forms.Button();
            this.button_save_log = new System.Windows.Forms.Button();
            this.textBox_rcv_msg = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_COMselect
            // 
            this.comboBox_COMselect.Enabled = false;
            this.comboBox_COMselect.FormattingEnabled = true;
            this.comboBox_COMselect.Location = new System.Drawing.Point(127, 31);
            this.comboBox_COMselect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_COMselect.Name = "comboBox_COMselect";
            this.comboBox_COMselect.Size = new System.Drawing.Size(121, 23);
            this.comboBox_COMselect.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "baudrate [bps]:";
            // 
            // comboBox_baudrate
            // 
            this.comboBox_baudrate.Enabled = false;
            this.comboBox_baudrate.FormattingEnabled = true;
            this.comboBox_baudrate.Items.AddRange(new object[] {
            "2000000",
            "1000000",
            "500000",
            "250000",
            "230400",
            "115200",
            "74880",
            "57600",
            "38400",
            "19200",
            "9600",
            "4800",
            "2400",
            "1200",
            "300"});
            this.comboBox_baudrate.Location = new System.Drawing.Point(127, 60);
            this.comboBox_baudrate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_baudrate.Name = "comboBox_baudrate";
            this.comboBox_baudrate.Size = new System.Drawing.Size(121, 23);
            this.comboBox_baudrate.TabIndex = 2;
            this.comboBox_baudrate.Text = "9600";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "new line code:";
            // 
            // comboBox_newline
            // 
            this.comboBox_newline.Enabled = false;
            this.comboBox_newline.FormattingEnabled = true;
            this.comboBox_newline.Items.AddRange(new object[] {
            "CR+LF",
            "CR",
            "LF"});
            this.comboBox_newline.Location = new System.Drawing.Point(127, 89);
            this.comboBox_newline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_newline.MaxDropDownItems = 4;
            this.comboBox_newline.Name = "comboBox_newline";
            this.comboBox_newline.Size = new System.Drawing.Size(121, 23);
            this.comboBox_newline.TabIndex = 4;
            this.comboBox_newline.Text = "LF";
            // 
            // button_serial_conn
            // 
            this.button_serial_conn.Enabled = false;
            this.button_serial_conn.Location = new System.Drawing.Point(267, 31);
            this.button_serial_conn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_serial_conn.Name = "button_serial_conn";
            this.button_serial_conn.Size = new System.Drawing.Size(109, 46);
            this.button_serial_conn.TabIndex = 6;
            this.button_serial_conn.Text = "connect";
            this.button_serial_conn.UseVisualStyleBackColor = true;
            this.button_serial_conn.Click += new System.EventHandler(this.button_serial_conn_Click);
            // 
            // button_serial_disconn
            // 
            this.button_serial_disconn.Enabled = false;
            this.button_serial_disconn.Location = new System.Drawing.Point(383, 31);
            this.button_serial_disconn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_serial_disconn.Name = "button_serial_disconn";
            this.button_serial_disconn.Size = new System.Drawing.Size(109, 46);
            this.button_serial_disconn.TabIndex = 7;
            this.button_serial_disconn.Text = "disconnect";
            this.button_serial_disconn.UseVisualStyleBackColor = true;
            this.button_serial_disconn.Click += new System.EventHandler(this.button_serial_disconn_Click);
            // 
            // serialPort_Arduino
            // 
            this.serialPort_Arduino.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_Arduino_DataReceived);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Status:";
            // 
            // label_serial_status
            // 
            this.label_serial_status.AutoSize = true;
            this.label_serial_status.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label_serial_status.Location = new System.Drawing.Point(367, 92);
            this.label_serial_status.Name = "label_serial_status";
            this.label_serial_status.Size = new System.Drawing.Size(0, 15);
            this.label_serial_status.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Received messages:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sending messages:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox_COMselect);
            this.groupBox1.Controls.Add(this.comboBox_baudrate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox_newline);
            this.groupBox1.Controls.Add(this.label_serial_status);
            this.groupBox1.Controls.Add(this.button_serial_conn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button_serial_disconn);
            this.groupBox1.Location = new System.Drawing.Point(35, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(513, 131);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial communication setting";
            // 
            // textBox_send_msg
            // 
            this.textBox_send_msg.Font = new System.Drawing.Font("MS UI Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox_send_msg.Location = new System.Drawing.Point(35, 186);
            this.textBox_send_msg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_send_msg.Name = "textBox_send_msg";
            this.textBox_send_msg.Size = new System.Drawing.Size(395, 30);
            this.textBox_send_msg.TabIndex = 15;
            this.textBox_send_msg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_send_msg_KeyDown);
            // 
            // button_send_msg
            // 
            this.button_send_msg.Enabled = false;
            this.button_send_msg.Location = new System.Drawing.Point(436, 186);
            this.button_send_msg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_send_msg.Name = "button_send_msg";
            this.button_send_msg.Size = new System.Drawing.Size(112, 32);
            this.button_send_msg.TabIndex = 16;
            this.button_send_msg.Text = "send";
            this.button_send_msg.UseVisualStyleBackColor = true;
            this.button_send_msg.Click += new System.EventHandler(this.button_send_msg_Click);
            // 
            // button_save_log
            // 
            this.button_save_log.Location = new System.Drawing.Point(392, 475);
            this.button_save_log.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_save_log.Name = "button_save_log";
            this.button_save_log.Size = new System.Drawing.Size(156, 32);
            this.button_save_log.TabIndex = 19;
            this.button_save_log.Text = "save";
            this.button_save_log.UseVisualStyleBackColor = true;
            this.button_save_log.Click += new System.EventHandler(this.button_save_log_Click);
            // 
            // textBox_rcv_msg
            // 
            this.textBox_rcv_msg.Location = new System.Drawing.Point(35, 249);
            this.textBox_rcv_msg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_rcv_msg.Multiline = true;
            this.textBox_rcv_msg.Name = "textBox_rcv_msg";
            this.textBox_rcv_msg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_rcv_msg.Size = new System.Drawing.Size(513, 222);
            this.textBox_rcv_msg.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 540);
            this.Controls.Add(this.textBox_rcv_msg);
            this.Controls.Add(this.button_save_log);
            this.Controls.Add(this.button_send_msg);
            this.Controls.Add(this.textBox_send_msg);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "ArduinoMonitor ver.001";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_COMselect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_baudrate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_newline;
        private System.Windows.Forms.Button button_serial_conn;
        private System.Windows.Forms.Button button_serial_disconn;
        private System.IO.Ports.SerialPort serialPort_Arduino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_serial_status;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_send_msg;
        private System.Windows.Forms.Button button_send_msg;
        private System.Windows.Forms.Button button_save_log;
        private System.Windows.Forms.TextBox textBox_rcv_msg;
    }
}

