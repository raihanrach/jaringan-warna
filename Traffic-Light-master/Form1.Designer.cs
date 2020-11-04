namespace Trafic_Lamp
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnListen = new System.Windows.Forms.Button();
            this.txtIPServer = new System.Windows.Forms.TextBox();
            this.txtPortServer = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.orangePanel = new System.Windows.Forms.Panel();
            this.yellowPanel = new System.Windows.Forms.Panel();
            this.pinkPanel = new System.Windows.Forms.Panel();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtIPClient = new System.Windows.Forms.TextBox();
            this.txtPortClient = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.blueOff = new System.Windows.Forms.RadioButton();
            this.orangeOff = new System.Windows.Forms.RadioButton();
            this.purpleOff = new System.Windows.Forms.RadioButton();
            this.blueOn = new System.Windows.Forms.RadioButton();
            this.orangeOn = new System.Windows.Forms.RadioButton();
            this.purpleOn = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerServer = new System.Windows.Forms.Timer(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 525);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnListen);
            this.tabPage1.Controls.Add(this.txtIPServer);
            this.tabPage1.Controls.Add(this.txtPortServer);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.orangePanel);
            this.tabPage1.Controls.Add(this.yellowPanel);
            this.tabPage1.Controls.Add(this.pinkPanel);
            this.tabPage1.Controls.Add(this.txtCommand);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(612, 492);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Server";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnListen
            // 
            this.btnListen.Location = new System.Drawing.Point(426, 408);
            this.btnListen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnListen.Name = "btnListen";
            this.btnListen.Size = new System.Drawing.Size(150, 57);
            this.btnListen.TabIndex = 8;
            this.btnListen.Text = "Listen";
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // txtIPServer
            // 
            this.txtIPServer.Location = new System.Drawing.Point(220, 434);
            this.txtIPServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIPServer.Name = "txtIPServer";
            this.txtIPServer.Size = new System.Drawing.Size(148, 26);
            this.txtIPServer.TabIndex = 7;
            this.txtIPServer.Text = "192.168";
            // 
            // txtPortServer
            // 
            this.txtPortServer.Enabled = false;
            this.txtPortServer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPortServer.Location = new System.Drawing.Point(24, 434);
            this.txtPortServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPortServer.Name = "txtPortServer";
            this.txtPortServer.Size = new System.Drawing.Size(90, 26);
            this.txtPortServer.TabIndex = 6;
            this.txtPortServer.Text = "16375";
            this.txtPortServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(216, 408);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(24, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "IP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 408);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Port";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 348);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 37);
            this.label10.TabIndex = 3;
            this.label10.Text = "Network";
            // 
            // orangePanel
            // 
            this.orangePanel.BackColor = System.Drawing.Color.White;
            this.orangePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.orangePanel.Location = new System.Drawing.Point(426, 146);
            this.orangePanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orangePanel.Name = "orangePanel";
            this.orangePanel.Size = new System.Drawing.Size(149, 153);
            this.orangePanel.TabIndex = 2;
            // 
            // yellowPanel
            // 
            this.yellowPanel.BackColor = System.Drawing.Color.White;
            this.yellowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.yellowPanel.Location = new System.Drawing.Point(220, 146);
            this.yellowPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.yellowPanel.Name = "yellowPanel";
            this.yellowPanel.Size = new System.Drawing.Size(149, 153);
            this.yellowPanel.TabIndex = 2;
            // 
            // pinkPanel
            // 
            this.pinkPanel.BackColor = System.Drawing.Color.White;
            this.pinkPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pinkPanel.Location = new System.Drawing.Point(14, 146);
            this.pinkPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pinkPanel.Name = "pinkPanel";
            this.pinkPanel.Size = new System.Drawing.Size(149, 153);
            this.pinkPanel.TabIndex = 1;
            // 
            // txtCommand
            // 
            this.txtCommand.Enabled = false;
            this.txtCommand.Location = new System.Drawing.Point(14, 54);
            this.txtCommand.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(560, 26);
            this.txtCommand.TabIndex = 0;
            this.txtCommand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCommand.TextChanged += new System.EventHandler(this.txtCommand_TextChanged_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtIPClient);
            this.tabPage2.Controls.Add(this.txtPortClient);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.blueOff);
            this.tabPage2.Controls.Add(this.orangeOff);
            this.tabPage2.Controls.Add(this.purpleOff);
            this.tabPage2.Controls.Add(this.blueOn);
            this.tabPage2.Controls.Add(this.orangeOn);
            this.tabPage2.Controls.Add(this.purpleOn);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(612, 492);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Client";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtIPClient
            // 
            this.txtIPClient.Location = new System.Drawing.Point(267, 314);
            this.txtIPClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIPClient.Name = "txtIPClient";
            this.txtIPClient.Size = new System.Drawing.Size(148, 26);
            this.txtIPClient.TabIndex = 16;
            this.txtIPClient.Text = "192.168";
            // 
            // txtPortClient
            // 
            this.txtPortClient.Enabled = false;
            this.txtPortClient.Location = new System.Drawing.Point(56, 314);
            this.txtPortClient.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPortClient.Name = "txtPortClient";
            this.txtPortClient.Size = new System.Drawing.Size(148, 26);
            this.txtPortClient.TabIndex = 15;
            this.txtPortClient.Text = "16375";
            this.txtPortClient.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(262, 289);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "IP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 289);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Port";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 243);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Target";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Mati";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(174, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Hidup";
            // 
            // blueOff
            // 
            this.blueOff.AutoSize = true;
            this.blueOff.Location = new System.Drawing.Point(303, 185);
            this.blueOff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blueOff.Name = "blueOff";
            this.blueOff.Size = new System.Drawing.Size(21, 20);
            this.blueOff.TabIndex = 9;
            this.blueOff.UseVisualStyleBackColor = true;
            this.blueOff.CheckedChanged += new System.EventHandler(this.yellowOff_CheckedChanged);
            // 
            // orangeOff
            // 
            this.orangeOff.AutoSize = true;
            this.orangeOff.Location = new System.Drawing.Point(303, 134);
            this.orangeOff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orangeOff.Name = "orangeOff";
            this.orangeOff.Size = new System.Drawing.Size(21, 20);
            this.orangeOff.TabIndex = 8;
            this.orangeOff.UseVisualStyleBackColor = true;
            this.orangeOff.CheckedChanged += new System.EventHandler(this.orangeOff_CheckedChanged);
            // 
            // purpleOff
            // 
            this.purpleOff.AutoSize = true;
            this.purpleOff.Location = new System.Drawing.Point(303, 83);
            this.purpleOff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.purpleOff.Name = "purpleOff";
            this.purpleOff.Size = new System.Drawing.Size(21, 20);
            this.purpleOff.TabIndex = 7;
            this.purpleOff.UseVisualStyleBackColor = true;
            this.purpleOff.CheckedChanged += new System.EventHandler(this.pinkOff_CheckedChanged);
            // 
            // blueOn
            // 
            this.blueOn.AutoSize = true;
            this.blueOn.Location = new System.Drawing.Point(192, 185);
            this.blueOn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.blueOn.Name = "blueOn";
            this.blueOn.Size = new System.Drawing.Size(21, 20);
            this.blueOn.TabIndex = 6;
            this.blueOn.UseVisualStyleBackColor = true;
            this.blueOn.CheckedChanged += new System.EventHandler(this.yellowOn_CheckedChanged);
            // 
            // orangeOn
            // 
            this.orangeOn.AutoSize = true;
            this.orangeOn.Location = new System.Drawing.Point(192, 134);
            this.orangeOn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.orangeOn.Name = "orangeOn";
            this.orangeOn.Size = new System.Drawing.Size(21, 20);
            this.orangeOn.TabIndex = 5;
            this.orangeOn.UseVisualStyleBackColor = true;
            this.orangeOn.CheckedChanged += new System.EventHandler(this.orangeOn_CheckedChanged);
            // 
            // purpleOn
            // 
            this.purpleOn.AutoSize = true;
            this.purpleOn.Location = new System.Drawing.Point(192, 83);
            this.purpleOn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.purpleOn.Name = "purpleOn";
            this.purpleOn.Size = new System.Drawing.Size(21, 20);
            this.purpleOn.TabIndex = 4;
            this.purpleOn.UseVisualStyleBackColor = true;
            this.purpleOn.CheckedChanged += new System.EventHandler(this.pinkOn_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Orange";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yellow";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pink";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Control";
            // 
            // timerServer
            // 
            this.timerServer.Enabled = true;
            this.timerServer.Tick += new System.EventHandler(this.timerServer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 525);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton blueOff;
        private System.Windows.Forms.RadioButton orangeOff;
        private System.Windows.Forms.RadioButton purpleOff;
        private System.Windows.Forms.RadioButton blueOn;
        private System.Windows.Forms.RadioButton orangeOn;
        private System.Windows.Forms.RadioButton purpleOn;
        private System.Windows.Forms.TextBox txtIPClient;
        private System.Windows.Forms.TextBox txtPortClient;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Button btnListen;
        private System.Windows.Forms.TextBox txtIPServer;
        private System.Windows.Forms.TextBox txtPortServer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel orangePanel;
        private System.Windows.Forms.Panel yellowPanel;
        private System.Windows.Forms.Panel pinkPanel;
        private System.Windows.Forms.Timer timerServer;
    }
}

