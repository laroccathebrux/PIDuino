namespace Arduino
{
    partial class frmArduino
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabArduino = new System.Windows.Forms.TabControl();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.tabPid = new System.Windows.Forms.TabPage();
            this.tabTemp = new System.Windows.Forms.TabPage();
            this.tabLumi = new System.Windows.Forms.TabPage();
            this.tabPwm = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdSerial = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtI = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstSerial = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cmdArdType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabArduino.SuspendLayout();
            this.tabConfig.SuspendLayout();
            this.tabPid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabArduino
            // 
            this.tabArduino.Controls.Add(this.tabConfig);
            this.tabArduino.Controls.Add(this.tabPid);
            this.tabArduino.Controls.Add(this.tabTemp);
            this.tabArduino.Controls.Add(this.tabLumi);
            this.tabArduino.Controls.Add(this.tabPwm);
            this.tabArduino.Location = new System.Drawing.Point(12, 12);
            this.tabArduino.Name = "tabArduino";
            this.tabArduino.SelectedIndex = 0;
            this.tabArduino.Size = new System.Drawing.Size(704, 345);
            this.tabArduino.TabIndex = 0;
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.cmdArdType);
            this.tabConfig.Controls.Add(this.label7);
            this.tabConfig.Controls.Add(this.btnConnect);
            this.tabConfig.Controls.Add(this.label6);
            this.tabConfig.Controls.Add(this.lstSerial);
            this.tabConfig.Controls.Add(this.cmdSerial);
            this.tabConfig.Controls.Add(this.label1);
            this.tabConfig.Location = new System.Drawing.Point(4, 22);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(696, 319);
            this.tabConfig.TabIndex = 0;
            this.tabConfig.Text = "Setup";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // tabPid
            // 
            this.tabPid.Controls.Add(this.label5);
            this.tabPid.Controls.Add(this.label4);
            this.tabPid.Controls.Add(this.label3);
            this.tabPid.Controls.Add(this.label2);
            this.tabPid.Controls.Add(this.btnSend);
            this.tabPid.Controls.Add(this.txtE);
            this.tabPid.Controls.Add(this.txtD);
            this.tabPid.Controls.Add(this.txtI);
            this.tabPid.Controls.Add(this.txtP);
            this.tabPid.Controls.Add(this.chart1);
            this.tabPid.Location = new System.Drawing.Point(4, 22);
            this.tabPid.Name = "tabPid";
            this.tabPid.Padding = new System.Windows.Forms.Padding(3);
            this.tabPid.Size = new System.Drawing.Size(696, 319);
            this.tabPid.TabIndex = 1;
            this.tabPid.Text = "Pid";
            this.tabPid.UseVisualStyleBackColor = true;
            // 
            // tabTemp
            // 
            this.tabTemp.Location = new System.Drawing.Point(4, 22);
            this.tabTemp.Name = "tabTemp";
            this.tabTemp.Padding = new System.Windows.Forms.Padding(3);
            this.tabTemp.Size = new System.Drawing.Size(696, 319);
            this.tabTemp.TabIndex = 2;
            this.tabTemp.Text = "Temperature";
            this.tabTemp.UseVisualStyleBackColor = true;
            // 
            // tabLumi
            // 
            this.tabLumi.Location = new System.Drawing.Point(4, 22);
            this.tabLumi.Name = "tabLumi";
            this.tabLumi.Padding = new System.Windows.Forms.Padding(3);
            this.tabLumi.Size = new System.Drawing.Size(696, 319);
            this.tabLumi.TabIndex = 3;
            this.tabLumi.Text = "Luminosity";
            this.tabLumi.UseVisualStyleBackColor = true;
            // 
            // tabPwm
            // 
            this.tabPwm.Location = new System.Drawing.Point(4, 22);
            this.tabPwm.Name = "tabPwm";
            this.tabPwm.Padding = new System.Windows.Forms.Padding(3);
            this.tabPwm.Size = new System.Drawing.Size(696, 319);
            this.tabPwm.TabIndex = 4;
            this.tabPwm.Text = "Pwm";
            this.tabPwm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial Port";
            // 
            // cmdSerial
            // 
            this.cmdSerial.FormattingEnabled = true;
            this.cmdSerial.Location = new System.Drawing.Point(15, 76);
            this.cmdSerial.Name = "cmdSerial";
            this.cmdSerial.Size = new System.Drawing.Size(121, 21);
            this.cmdSerial.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(240, 13);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(450, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(53, 27);
            this.txtP.Name = "txtP";
            this.txtP.ReadOnly = true;
            this.txtP.Size = new System.Drawing.Size(100, 20);
            this.txtP.TabIndex = 1;
            // 
            // txtI
            // 
            this.txtI.Location = new System.Drawing.Point(53, 82);
            this.txtI.Name = "txtI";
            this.txtI.ReadOnly = true;
            this.txtI.Size = new System.Drawing.Size(100, 20);
            this.txtI.TabIndex = 2;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(53, 144);
            this.txtD.Name = "txtD";
            this.txtD.ReadOnly = true;
            this.txtD.Size = new System.Drawing.Size(100, 20);
            this.txtD.TabIndex = 3;
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(53, 206);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(100, 20);
            this.txtE.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(53, 257);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send to Arduino";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Proportional";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Integral";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Derivative";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "SetPoint";
            // 
            // lstSerial
            // 
            this.lstSerial.FormattingEnabled = true;
            this.lstSerial.Location = new System.Drawing.Point(159, 24);
            this.lstSerial.Name = "lstSerial";
            this.lstSerial.Size = new System.Drawing.Size(514, 277);
            this.lstSerial.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(156, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Serial Log";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(15, 126);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(121, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            // 
            // cmdArdType
            // 
            this.cmdArdType.FormattingEnabled = true;
            this.cmdArdType.Location = new System.Drawing.Point(15, 24);
            this.cmdArdType.Name = "cmdArdType";
            this.cmdArdType.Size = new System.Drawing.Size(121, 21);
            this.cmdArdType.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Arduino Type";
            // 
            // frmArduino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 369);
            this.Controls.Add(this.tabArduino);
            this.Name = "frmArduino";
            this.Text = "Arduino";
            this.tabArduino.ResumeLayout(false);
            this.tabConfig.ResumeLayout(false);
            this.tabConfig.PerformLayout();
            this.tabPid.ResumeLayout(false);
            this.tabPid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabArduino;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPid;
        private System.Windows.Forms.TabPage tabTemp;
        private System.Windows.Forms.TabPage tabLumi;
        private System.Windows.Forms.TabPage tabPwm;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstSerial;
        private System.Windows.Forms.ComboBox cmdSerial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtI;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox cmdArdType;
        private System.Windows.Forms.Label label7;
    }
}

