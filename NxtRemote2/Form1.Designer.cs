namespace NxtRemote2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtComPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnIdle = new System.Windows.Forms.Button();
            this.remoteControlPanel = new System.Windows.Forms.Panel();
            this.hbarTurnRatio = new System.Windows.Forms.HScrollBar();
            this.vbarPower = new System.Windows.Forms.VScrollBar();
            this.remoteControlPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 303);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM";
            // 
            // txtComPort
            // 
            this.txtComPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtComPort.Location = new System.Drawing.Point(53, 299);
            this.txtComPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtComPort.Name = "txtComPort";
            this.txtComPort.Size = new System.Drawing.Size(31, 22);
            this.txtComPort.TabIndex = 2;
            this.txtComPort.Text = "6";
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConnect.Location = new System.Drawing.Point(92, 299);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 28);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDisconnect.Location = new System.Drawing.Point(201, 299);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(100, 28);
            this.btnDisconnect.TabIndex = 4;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnIdle
            // 
            this.btnIdle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIdle.Location = new System.Drawing.Point(309, 299);
            this.btnIdle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIdle.Name = "btnIdle";
            this.btnIdle.Size = new System.Drawing.Size(100, 28);
            this.btnIdle.TabIndex = 5;
            this.btnIdle.Text = "Idle";
            this.btnIdle.UseVisualStyleBackColor = true;
            this.btnIdle.Click += new System.EventHandler(this.btnIdle_Click);
            // 
            // remoteControlPanel
            // 
            this.remoteControlPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remoteControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.remoteControlPanel.Controls.Add(this.hbarTurnRatio);
            this.remoteControlPanel.Controls.Add(this.vbarPower);
            this.remoteControlPanel.Location = new System.Drawing.Point(4, 4);
            this.remoteControlPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.remoteControlPanel.Name = "remoteControlPanel";
            this.remoteControlPanel.Size = new System.Drawing.Size(405, 288);
            this.remoteControlPanel.TabIndex = 6;
            // 
            // hbarTurnRatio
            // 
            this.hbarTurnRatio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hbarTurnRatio.LargeChange = 1;
            this.hbarTurnRatio.Location = new System.Drawing.Point(0, 270);
            this.hbarTurnRatio.Maximum = 10;
            this.hbarTurnRatio.Minimum = -10;
            this.hbarTurnRatio.Name = "hbarTurnRatio";
            this.hbarTurnRatio.Size = new System.Drawing.Size(387, 16);
            this.hbarTurnRatio.TabIndex = 1;
            this.hbarTurnRatio.ValueChanged += new System.EventHandler(this.hbarTurnRatio_ValueChanged);
            // 
            // vbarPower
            // 
            this.vbarPower.Dock = System.Windows.Forms.DockStyle.Right;
            this.vbarPower.Location = new System.Drawing.Point(387, 0);
            this.vbarPower.Minimum = -100;
            this.vbarPower.Name = "vbarPower";
            this.vbarPower.Size = new System.Drawing.Size(16, 286);
            this.vbarPower.TabIndex = 0;
            this.vbarPower.ValueChanged += new System.EventHandler(this.vbarPower_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 327);
            this.Controls.Add(this.remoteControlPanel);
            this.Controls.Add(this.btnIdle);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtComPort);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.remoteControlPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtComPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnIdle;
        private System.Windows.Forms.Panel remoteControlPanel;
        private System.Windows.Forms.VScrollBar vbarPower;
        private System.Windows.Forms.HScrollBar hbarTurnRatio;


    }
}

