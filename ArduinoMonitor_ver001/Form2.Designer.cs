namespace ArduinoMonitor_ver001
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_startGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_startGame
            // 
            this.button_startGame.BackColor = System.Drawing.Color.PaleGreen;
            this.button_startGame.Font = new System.Drawing.Font("HGP創英角ﾎﾟｯﾌﾟ体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button_startGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_startGame.Location = new System.Drawing.Point(54, 51);
            this.button_startGame.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_startGame.Name = "button_startGame";
            this.button_startGame.Size = new System.Drawing.Size(106, 72);
            this.button_startGame.TabIndex = 0;
            this.button_startGame.Text = "Start";
            this.button_startGame.UseVisualStyleBackColor = false;
            this.button_startGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.button_startGame);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "GameMonitor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.SizeChanged += new System.EventHandler(this.Form2_SizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_startGame;
    }
}