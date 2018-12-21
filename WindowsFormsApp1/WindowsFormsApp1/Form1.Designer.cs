namespace WindowsFormsApp1
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
            this.ServerIP = new System.Windows.Forms.TextBox();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.IP = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ServerPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ClientPort = new System.Windows.Forms.TextBox();
            this.ClientIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Connect = new System.Windows.Forms.Button();
            this.Send = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServerIP
            // 
            this.ServerIP.Location = new System.Drawing.Point(65, 19);
            this.ServerIP.Name = "ServerIP";
            this.ServerIP.Size = new System.Drawing.Size(129, 20);
            this.ServerIP.TabIndex = 0;
            // 
            // listMessage
            // 
            this.listMessage.BackColor = System.Drawing.SystemColors.MenuText;
            this.listMessage.ForeColor = System.Drawing.SystemColors.Info;
            this.listMessage.FormattingEnabled = true;
            this.listMessage.Location = new System.Drawing.Point(281, 15);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(499, 303);
            this.listMessage.TabIndex = 1;
            // 
            // IP
            // 
            this.IP.AutoSize = true;
            this.IP.Location = new System.Drawing.Point(32, 22);
            this.IP.Name = "IP";
            this.IP.Size = new System.Drawing.Size(17, 13);
            this.IP.TabIndex = 2;
            this.IP.Text = "IP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ServerPort);
            this.groupBox1.Controls.Add(this.ServerIP);
            this.groupBox1.Controls.Add(this.IP);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 115);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SERVER";
            // 
            // ServerPort
            // 
            this.ServerPort.Location = new System.Drawing.Point(65, 55);
            this.ServerPort.Name = "ServerPort";
            this.ServerPort.Size = new System.Drawing.Size(129, 20);
            this.ServerPort.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PORT";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ClientPort);
            this.groupBox2.Controls.Add(this.ClientIP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 115);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CLIENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "PORT";
            // 
            // ClientPort
            // 
            this.ClientPort.Location = new System.Drawing.Point(65, 55);
            this.ClientPort.Name = "ClientPort";
            this.ClientPort.Size = new System.Drawing.Size(129, 20);
            this.ClientPort.TabIndex = 3;
            // 
            // ClientIP
            // 
            this.ClientIP.Location = new System.Drawing.Point(65, 19);
            this.ClientIP.Name = "ClientIP";
            this.ClientIP.Size = new System.Drawing.Size(129, 20);
            this.ClientIP.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "IP";
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(12, 295);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 5;
            this.Connect.Text = "BAĞLAN";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(696, 369);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 6;
            this.Send.Text = "GÖNDER";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Send_Click);
            // 
            // Message
            // 
            this.Message.BackColor = System.Drawing.SystemColors.MenuText;
            this.Message.ForeColor = System.Drawing.SystemColors.Info;
            this.Message.Location = new System.Drawing.Point(281, 369);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(409, 20);
            this.Message.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.Send);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listMessage);
            this.Name = "Form1";
            this.Text = "ChatApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ServerIP;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.Label IP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ServerPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ClientPort;
        private System.Windows.Forms.TextBox ClientIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.TextBox Message;
    }
}

