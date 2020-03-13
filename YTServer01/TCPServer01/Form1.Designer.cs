namespace TCPServer01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbConsoleOutput = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbIPAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartListening = new System.Windows.Forms.Button();
            this.btnFindIPv4IP = new System.Windows.Forms.Button();
            this.lbClients = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSh = new System.Windows.Forms.Button();
            this.btnRes = new System.Windows.Forms.Button();
            this.btnVisit = new System.Windows.Forms.Button();
            this.btnEx = new System.Windows.Forms.Button();
            this.btnDw = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtVisitsTime = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTimelength = new System.Windows.Forms.TextBox();
            this.txtClCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.tbPayload = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbConsoleOutput
            // 
            this.tbConsoleOutput.Location = new System.Drawing.Point(6, 266);
            this.tbConsoleOutput.Multiline = true;
            this.tbConsoleOutput.Name = "tbConsoleOutput";
            this.tbConsoleOutput.Size = new System.Drawing.Size(621, 221);
            this.tbConsoleOutput.TabIndex = 0;
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(217, 497);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(100, 20);
            this.tbPort.TabIndex = 1;
            this.tbPort.Text = "23000";
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.Location = new System.Drawing.Point(58, 497);
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.Size = new System.Drawing.Size(153, 20);
            this.tbIPAddress.TabIndex = 2;
            this.tbIPAddress.Text = "127.0.0.1";
            this.tbIPAddress.TextChanged += new System.EventHandler(this.tbIPAddress_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 500);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP/Port: ";
            // 
            // btnStartListening
            // 
            this.btnStartListening.Location = new System.Drawing.Point(58, 523);
            this.btnStartListening.Name = "btnStartListening";
            this.btnStartListening.Size = new System.Drawing.Size(153, 23);
            this.btnStartListening.TabIndex = 4;
            this.btnStartListening.Text = "Start Listening";
            this.btnStartListening.UseVisualStyleBackColor = true;
            this.btnStartListening.Click += new System.EventHandler(this.btnStartListening_Click);
            // 
            // btnFindIPv4IP
            // 
            this.btnFindIPv4IP.Location = new System.Drawing.Point(217, 523);
            this.btnFindIPv4IP.Name = "btnFindIPv4IP";
            this.btnFindIPv4IP.Size = new System.Drawing.Size(100, 23);
            this.btnFindIPv4IP.TabIndex = 8;
            this.btnFindIPv4IP.Text = "Find IP";
            this.btnFindIPv4IP.UseVisualStyleBackColor = true;
            this.btnFindIPv4IP.Click += new System.EventHandler(this.btnFindIPv4IP_Click_1);
            // 
            // lbClients
            // 
            this.lbClients.FormattingEnabled = true;
            this.lbClients.Location = new System.Drawing.Point(633, 64);
            this.lbClients.Name = "lbClients";
            this.lbClients.Size = new System.Drawing.Size(158, 485);
            this.lbClients.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Clients:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtURL);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(6, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 248);
            this.panel1.TabIndex = 11;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(127, 177);
            this.txtURL.Multiline = true;
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(484, 64);
            this.txtURL.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnSh, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnRes, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnVisit, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEx, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnDw, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(607, 167);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnSh
            // 
            this.btnSh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSh.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSh.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSh.Location = new System.Drawing.Point(3, 113);
            this.btnSh.Name = "btnSh";
            this.btnSh.Size = new System.Drawing.Size(297, 51);
            this.btnSh.TabIndex = 5;
            this.btnSh.Text = "Shutdown";
            this.btnSh.UseVisualStyleBackColor = true;
            this.btnSh.Click += new System.EventHandler(this.BtnSh_Click);
            // 
            // btnRes
            // 
            this.btnRes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRes.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRes.Location = new System.Drawing.Point(306, 113);
            this.btnRes.Name = "btnRes";
            this.btnRes.Size = new System.Drawing.Size(298, 51);
            this.btnRes.TabIndex = 4;
            this.btnRes.Text = "Restart";
            this.btnRes.UseVisualStyleBackColor = true;
            this.btnRes.Click += new System.EventHandler(this.BtnRes_Click);
            // 
            // btnVisit
            // 
            this.btnVisit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnVisit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnVisit.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisit.Location = new System.Drawing.Point(306, 3);
            this.btnVisit.Name = "btnVisit";
            this.btnVisit.Size = new System.Drawing.Size(298, 49);
            this.btnVisit.TabIndex = 0;
            this.btnVisit.Text = "Visit";
            this.btnVisit.UseVisualStyleBackColor = true;
            this.btnVisit.Click += new System.EventHandler(this.BtnVisit_Click);
            // 
            // btnEx
            // 
            this.btnEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEx.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEx.Location = new System.Drawing.Point(306, 58);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(298, 49);
            this.btnEx.TabIndex = 1;
            this.btnEx.Text = "Execute";
            this.btnEx.UseVisualStyleBackColor = true;
            // 
            // btnDw
            // 
            this.btnDw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDw.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDw.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDw.Location = new System.Drawing.Point(3, 58);
            this.btnDw.Name = "btnDw";
            this.btnDw.Size = new System.Drawing.Size(297, 49);
            this.btnDw.TabIndex = 2;
            this.btnDw.Text = "Download";
            this.btnDw.UseVisualStyleBackColor = true;
            this.btnDw.Click += new System.EventHandler(this.BtnDw_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.txtVisitsTime, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtTimelength, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.41667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.58334F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(297, 48);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // txtVisitsTime
            // 
            this.txtVisitsTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtVisitsTime.Location = new System.Drawing.Point(151, 19);
            this.txtVisitsTime.Multiline = true;
            this.txtVisitsTime.Name = "txtVisitsTime";
            this.txtVisitsTime.Size = new System.Drawing.Size(143, 26);
            this.txtVisitsTime.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(151, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Time(s) to Visit each Link";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Timelength to visit all Links";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTimelength
            // 
            this.txtTimelength.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTimelength.Location = new System.Drawing.Point(3, 19);
            this.txtTimelength.Multiline = true;
            this.txtTimelength.Name = "txtTimelength";
            this.txtTimelength.Size = new System.Drawing.Size(142, 26);
            this.txtTimelength.TabIndex = 2;
            // 
            // txtClCount
            // 
            this.txtClCount.Location = new System.Drawing.Point(724, 6);
            this.txtClCount.Name = "txtClCount";
            this.txtClCount.Size = new System.Drawing.Size(63, 20);
            this.txtClCount.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(630, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Send to (cl):";
            // 
            // txtClAmount
            // 
            this.txtClAmount.Location = new System.Drawing.Point(724, 32);
            this.txtClAmount.Name = "txtClAmount";
            this.txtClAmount.Size = new System.Drawing.Size(63, 20);
            this.txtClAmount.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "url";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(391, 523);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(178, 23);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "&Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // tbPayload
            // 
            this.tbPayload.Location = new System.Drawing.Point(391, 493);
            this.tbPayload.Name = "tbPayload";
            this.tbPayload.Size = new System.Drawing.Size(175, 20);
            this.tbPayload.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "URL To visit ---->";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 556);
            this.Controls.Add(this.txtClAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClCount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbClients);
            this.Controls.Add(this.btnFindIPv4IP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbPayload);
            this.Controls.Add(this.btnStartListening);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIPAddress);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.tbConsoleOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "YTSrv 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbConsoleOutput;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbIPAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartListening;
        private System.Windows.Forms.Button btnFindIPv4IP;
        private System.Windows.Forms.ListBox lbClients;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnSh;
        private System.Windows.Forms.Button btnRes;
        private System.Windows.Forms.Button btnVisit;
        private System.Windows.Forms.Button btnEx;
        private System.Windows.Forms.Button btnDw;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtVisitsTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTimelength;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtClCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbPayload;
        private System.Windows.Forms.Label label5;
    }
}

