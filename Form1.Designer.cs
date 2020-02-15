namespace FirefoxSeleniumBot
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
            this.btnRun = new System.Windows.Forms.Button();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxuserAgents = new System.Windows.Forms.ListBox();
            this.listBoxLogs = new System.Windows.Forms.ListBox();
            this.richTextBoxProxies = new System.Windows.Forms.RichTextBox();
            this.btnKillProcess = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabelpoxy = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabeluseragent = new System.Windows.Forms.LinkLabel();
            this.linkLabelLocate = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonsaveLogs = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(569, 433);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(190, 40);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "START";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtLink
            // 
            this.txtLink.BackColor = System.Drawing.SystemColors.Info;
            this.txtLink.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLink.Location = new System.Drawing.Point(100, 441);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(411, 29);
            this.txtLink.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 441);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "LINK :";
            // 
            // listBoxuserAgents
            // 
            this.listBoxuserAgents.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxuserAgents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxuserAgents.FormattingEnabled = true;
            this.listBoxuserAgents.Location = new System.Drawing.Point(348, 42);
            this.listBoxuserAgents.Name = "listBoxuserAgents";
            this.listBoxuserAgents.Size = new System.Drawing.Size(411, 303);
            this.listBoxuserAgents.TabIndex = 3;
            // 
            // listBoxLogs
            // 
            this.listBoxLogs.BackColor = System.Drawing.SystemColors.Info;
            this.listBoxLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxLogs.FormattingEnabled = true;
            this.listBoxLogs.Location = new System.Drawing.Point(806, 42);
            this.listBoxLogs.Name = "listBoxLogs";
            this.listBoxLogs.Size = new System.Drawing.Size(365, 303);
            this.listBoxLogs.TabIndex = 4;
            // 
            // richTextBoxProxies
            // 
            this.richTextBoxProxies.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBoxProxies.Location = new System.Drawing.Point(6, 18);
            this.richTextBoxProxies.Name = "richTextBoxProxies";
            this.richTextBoxProxies.ReadOnly = true;
            this.richTextBoxProxies.Size = new System.Drawing.Size(295, 303);
            this.richTextBoxProxies.TabIndex = 5;
            this.richTextBoxProxies.Text = "";
            // 
            // btnKillProcess
            // 
            this.btnKillProcess.Location = new System.Drawing.Point(844, 433);
            this.btnKillProcess.Name = "btnKillProcess";
            this.btnKillProcess.Size = new System.Drawing.Size(190, 40);
            this.btnKillProcess.TabIndex = 6;
            this.btnKillProcess.Text = "KILL PROCESS";
            this.btnKillProcess.UseVisualStyleBackColor = true;
            this.btnKillProcess.Click += new System.EventHandler(this.btnKillProcess_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBoxProxies);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 334);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PROXIES";
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(338, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(433, 334);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "USERAGENTS";
            // 
            // groupBox3
            // 
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(795, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(389, 334);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LOGS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 371);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "CURRENT PROXY ->";
            // 
            // linkLabelpoxy
            // 
            this.linkLabelpoxy.AutoSize = true;
            this.linkLabelpoxy.Location = new System.Drawing.Point(156, 371);
            this.linkLabelpoxy.Name = "linkLabelpoxy";
            this.linkLabelpoxy.Size = new System.Drawing.Size(40, 13);
            this.linkLabelpoxy.TabIndex = 10;
            this.linkLabelpoxy.TabStop = true;
            this.linkLabelpoxy.Text = "-----------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 403);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "CURRENT USERAGENT ->";
            // 
            // linkLabeluseragent
            // 
            this.linkLabeluseragent.AutoSize = true;
            this.linkLabeluseragent.Location = new System.Drawing.Point(183, 403);
            this.linkLabeluseragent.Name = "linkLabeluseragent";
            this.linkLabeluseragent.Size = new System.Drawing.Size(40, 13);
            this.linkLabeluseragent.TabIndex = 12;
            this.linkLabeluseragent.TabStop = true;
            this.linkLabeluseragent.Text = "-----------";
            // 
            // linkLabelLocate
            // 
            this.linkLabelLocate.AutoSize = true;
            this.linkLabelLocate.Location = new System.Drawing.Point(615, 371);
            this.linkLabelLocate.Name = "linkLabelLocate";
            this.linkLabelLocate.Size = new System.Drawing.Size(40, 13);
            this.linkLabelLocate.TabIndex = 14;
            this.linkLabelLocate.TabStop = true;
            this.linkLabelLocate.Text = "-----------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(465, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "CURRENT LOCATION->";
            // 
            // buttonsaveLogs
            // 
            this.buttonsaveLogs.Location = new System.Drawing.Point(1072, 371);
            this.buttonsaveLogs.Name = "buttonsaveLogs";
            this.buttonsaveLogs.Size = new System.Drawing.Size(112, 45);
            this.buttonsaveLogs.TabIndex = 15;
            this.buttonsaveLogs.Text = "SAVE LOGS";
            this.buttonsaveLogs.UseVisualStyleBackColor = true;
            this.buttonsaveLogs.Click += new System.EventHandler(this.buttonsaveLogs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1202, 522);
            this.Controls.Add(this.buttonsaveLogs);
            this.Controls.Add(this.linkLabelLocate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabeluseragent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkLabelpoxy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnKillProcess);
            this.Controls.Add(this.listBoxLogs);
            this.Controls.Add(this.listBoxuserAgents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "SELENİUM BOT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxuserAgents;
        private System.Windows.Forms.ListBox listBoxLogs;
        private System.Windows.Forms.RichTextBox richTextBoxProxies;
        private System.Windows.Forms.Button btnKillProcess;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabelpoxy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabeluseragent;
        private System.Windows.Forms.LinkLabel linkLabelLocate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonsaveLogs;
    }
}

