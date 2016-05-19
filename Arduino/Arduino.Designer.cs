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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabArduino = new System.Windows.Forms.TabControl();
            this.tabConfig = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmdBaudRate = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.cmdSerial = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPid = new System.Windows.Forms.TabPage();
            this.chartPID = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtCtrl = new System.Windows.Forms.TextBox();
            this.txtMode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdCtrlDirect = new System.Windows.Forms.RadioButton();
            this.rdCtrlReverse = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtSR = new System.Windows.Forms.TextBox();
            this.txtDR = new System.Windows.Forms.TextBox();
            this.txtIR = new System.Windows.Forms.TextBox();
            this.txtPR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtS = new System.Windows.Forms.TextBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtI = new System.Windows.Forms.TextBox();
            this.txtP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdModeAutomatic = new System.Windows.Forms.RadioButton();
            this.rdModeManual = new System.Windows.Forms.RadioButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lstSerial = new System.Windows.Forms.ListBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabArduino.SuspendLayout();
            this.tabConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPID)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabArduino
            // 
            this.tabArduino.Controls.Add(this.tabConfig);
            this.tabArduino.Controls.Add(this.tabPid);
            this.tabArduino.Controls.Add(this.tabPage1);
            this.tabArduino.Location = new System.Drawing.Point(12, 12);
            this.tabArduino.Name = "tabArduino";
            this.tabArduino.SelectedIndex = 0;
            this.tabArduino.Size = new System.Drawing.Size(1008, 433);
            this.tabArduino.TabIndex = 0;
            // 
            // tabConfig
            // 
            this.tabConfig.Controls.Add(this.pictureBox1);
            this.tabConfig.Controls.Add(this.cmdBaudRate);
            this.tabConfig.Controls.Add(this.label8);
            this.tabConfig.Controls.Add(this.btnConnect);
            this.tabConfig.Controls.Add(this.cmdSerial);
            this.tabConfig.Controls.Add(this.label1);
            this.tabConfig.Location = new System.Drawing.Point(4, 22);
            this.tabConfig.Name = "tabConfig";
            this.tabConfig.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfig.Size = new System.Drawing.Size(1000, 407);
            this.tabConfig.TabIndex = 0;
            this.tabConfig.Text = "Setup";
            this.tabConfig.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Arduino.Properties.Resources.illu_arduino_UNO;
            this.pictureBox1.Location = new System.Drawing.Point(203, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // cmdBaudRate
            // 
            this.cmdBaudRate.FormattingEnabled = true;
            this.cmdBaudRate.Location = new System.Drawing.Point(18, 24);
            this.cmdBaudRate.Name = "cmdBaudRate";
            this.cmdBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cmdBaudRate.TabIndex = 8;
            this.cmdBaudRate.SelectedIndexChanged += new System.EventHandler(this.cmdBaudRate_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Baud Rate";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Enabled = false;
            this.btnConnect.Location = new System.Drawing.Point(18, 131);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(121, 23);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // cmdSerial
            // 
            this.cmdSerial.FormattingEnabled = true;
            this.cmdSerial.Location = new System.Drawing.Point(18, 84);
            this.cmdSerial.Name = "cmdSerial";
            this.cmdSerial.Size = new System.Drawing.Size(121, 21);
            this.cmdSerial.TabIndex = 1;
            this.cmdSerial.SelectedIndexChanged += new System.EventHandler(this.cmdSerial_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serial Port";
            // 
            // tabPid
            // 
            this.tabPid.Controls.Add(this.chartPID);
            this.tabPid.Controls.Add(this.txtCtrl);
            this.tabPid.Controls.Add(this.txtMode);
            this.tabPid.Controls.Add(this.groupBox2);
            this.tabPid.Controls.Add(this.label7);
            this.tabPid.Controls.Add(this.label6);
            this.tabPid.Controls.Add(this.txtOutput);
            this.tabPid.Controls.Add(this.txtInput);
            this.tabPid.Controls.Add(this.txtSR);
            this.tabPid.Controls.Add(this.txtDR);
            this.tabPid.Controls.Add(this.txtIR);
            this.tabPid.Controls.Add(this.txtPR);
            this.tabPid.Controls.Add(this.label5);
            this.tabPid.Controls.Add(this.label4);
            this.tabPid.Controls.Add(this.label3);
            this.tabPid.Controls.Add(this.label2);
            this.tabPid.Controls.Add(this.btnSend);
            this.tabPid.Controls.Add(this.txtS);
            this.tabPid.Controls.Add(this.txtD);
            this.tabPid.Controls.Add(this.txtI);
            this.tabPid.Controls.Add(this.txtP);
            this.tabPid.Controls.Add(this.groupBox1);
            this.tabPid.Location = new System.Drawing.Point(4, 22);
            this.tabPid.Name = "tabPid";
            this.tabPid.Padding = new System.Windows.Forms.Padding(3);
            this.tabPid.Size = new System.Drawing.Size(1000, 407);
            this.tabPid.TabIndex = 1;
            this.tabPid.Text = "Pid";
            this.tabPid.UseVisualStyleBackColor = true;
            // 
            // chartPID
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPID.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPID.Legends.Add(legend1);
            this.chartPID.Location = new System.Drawing.Point(150, 9);
            this.chartPID.Name = "chartPID";
            this.chartPID.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "SetPoint";
            series1.YValueMembers = "txtSR.Text";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Input";
            this.chartPID.Series.Add(series1);
            this.chartPID.Series.Add(series2);
            this.chartPID.Size = new System.Drawing.Size(844, 392);
            this.chartPID.TabIndex = 29;
            this.chartPID.Text = "chartPID";
            // 
            // txtCtrl
            // 
            this.txtCtrl.Location = new System.Drawing.Point(81, 319);
            this.txtCtrl.Name = "txtCtrl";
            this.txtCtrl.ReadOnly = true;
            this.txtCtrl.Size = new System.Drawing.Size(62, 20);
            this.txtCtrl.TabIndex = 28;
            // 
            // txtMode
            // 
            this.txtMode.Location = new System.Drawing.Point(7, 319);
            this.txtMode.Name = "txtMode";
            this.txtMode.ReadOnly = true;
            this.txtMode.Size = new System.Drawing.Size(62, 20);
            this.txtMode.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdCtrlDirect);
            this.groupBox2.Controls.Add(this.rdCtrlReverse);
            this.groupBox2.Location = new System.Drawing.Point(6, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(138, 42);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controller";
            // 
            // rdCtrlDirect
            // 
            this.rdCtrlDirect.AutoSize = true;
            this.rdCtrlDirect.Checked = true;
            this.rdCtrlDirect.Location = new System.Drawing.Point(6, 19);
            this.rdCtrlDirect.Name = "rdCtrlDirect";
            this.rdCtrlDirect.Size = new System.Drawing.Size(53, 17);
            this.rdCtrlDirect.TabIndex = 21;
            this.rdCtrlDirect.TabStop = true;
            this.rdCtrlDirect.Tag = "ctrl";
            this.rdCtrlDirect.Text = "Direct";
            this.rdCtrlDirect.UseVisualStyleBackColor = true;
            // 
            // rdCtrlReverse
            // 
            this.rdCtrlReverse.AutoSize = true;
            this.rdCtrlReverse.Location = new System.Drawing.Point(65, 19);
            this.rdCtrlReverse.Name = "rdCtrlReverse";
            this.rdCtrlReverse.Size = new System.Drawing.Size(65, 17);
            this.rdCtrlReverse.TabIndex = 22;
            this.rdCtrlReverse.Tag = "ctrl";
            this.rdCtrlReverse.Text = "Reverse";
            this.rdCtrlReverse.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Output";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Input";
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(82, 202);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(62, 20);
            this.txtOutput.TabIndex = 15;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(7, 202);
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.Size = new System.Drawing.Size(62, 20);
            this.txtInput.TabIndex = 14;
            // 
            // txtSR
            // 
            this.txtSR.Location = new System.Drawing.Point(81, 151);
            this.txtSR.Name = "txtSR";
            this.txtSR.ReadOnly = true;
            this.txtSR.Size = new System.Drawing.Size(63, 20);
            this.txtSR.TabIndex = 13;
            // 
            // txtDR
            // 
            this.txtDR.Location = new System.Drawing.Point(81, 109);
            this.txtDR.Name = "txtDR";
            this.txtDR.ReadOnly = true;
            this.txtDR.Size = new System.Drawing.Size(63, 20);
            this.txtDR.TabIndex = 12;
            // 
            // txtIR
            // 
            this.txtIR.Location = new System.Drawing.Point(81, 67);
            this.txtIR.Name = "txtIR";
            this.txtIR.ReadOnly = true;
            this.txtIR.Size = new System.Drawing.Size(63, 20);
            this.txtIR.TabIndex = 11;
            // 
            // txtPR
            // 
            this.txtPR.Location = new System.Drawing.Point(81, 25);
            this.txtPR.Name = "txtPR";
            this.txtPR.ReadOnly = true;
            this.txtPR.Size = new System.Drawing.Size(63, 20);
            this.txtPR.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "SetPoint";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Derivative";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Integral";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Proportional";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(21, 364);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 23);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send to Arduino";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(6, 151);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(63, 20);
            this.txtS.TabIndex = 4;
            // 
            // txtD
            // 
            this.txtD.Location = new System.Drawing.Point(6, 109);
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(63, 20);
            this.txtD.TabIndex = 3;
            // 
            // txtI
            // 
            this.txtI.Location = new System.Drawing.Point(6, 67);
            this.txtI.Name = "txtI";
            this.txtI.Size = new System.Drawing.Size(63, 20);
            this.txtI.TabIndex = 2;
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(6, 25);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(63, 20);
            this.txtP.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdModeAutomatic);
            this.groupBox1.Controls.Add(this.rdModeManual);
            this.groupBox1.Location = new System.Drawing.Point(6, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(138, 37);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mode";
            // 
            // rdModeAutomatic
            // 
            this.rdModeAutomatic.AutoSize = true;
            this.rdModeAutomatic.Checked = true;
            this.rdModeAutomatic.Location = new System.Drawing.Point(6, 14);
            this.rdModeAutomatic.Name = "rdModeAutomatic";
            this.rdModeAutomatic.Size = new System.Drawing.Size(72, 17);
            this.rdModeAutomatic.TabIndex = 18;
            this.rdModeAutomatic.TabStop = true;
            this.rdModeAutomatic.Tag = "mode";
            this.rdModeAutomatic.Text = "Automatic";
            this.rdModeAutomatic.UseVisualStyleBackColor = true;
            // 
            // rdModeManual
            // 
            this.rdModeManual.AutoSize = true;
            this.rdModeManual.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Arduino.Properties.Settings.Default, "Mode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rdModeManual.Location = new System.Drawing.Point(78, 14);
            this.rdModeManual.Name = "rdModeManual";
            this.rdModeManual.Size = new System.Drawing.Size(60, 17);
            this.rdModeManual.TabIndex = 19;
            this.rdModeManual.Tag = "mode";
            this.rdModeManual.Text = global::Arduino.Properties.Settings.Default.Mode;
            this.rdModeManual.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.pictureBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1000, 407);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Credits";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(438, 289);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Autor: Alessandro La Rocca Silveira";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(492, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Version 0.0.1";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Arduino.Properties.Resources.illu_arduino_UNO;
            this.pictureBox2.Location = new System.Drawing.Point(387, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(258, 187);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lstSerial
            // 
            this.lstSerial.FormattingEnabled = true;
            this.lstSerial.Location = new System.Drawing.Point(12, 451);
            this.lstSerial.Name = "lstSerial";
            this.lstSerial.Size = new System.Drawing.Size(1004, 186);
            this.lstSerial.TabIndex = 2;
            // 
            // frmArduino
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 647);
            this.Controls.Add(this.tabArduino);
            this.Controls.Add(this.lstSerial);
            this.Name = "frmArduino";
            this.Text = "Arduino";
            this.Load += new System.EventHandler(this.frmArduino_Load);
            this.tabArduino.ResumeLayout(false);
            this.tabConfig.ResumeLayout(false);
            this.tabConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPid.ResumeLayout(false);
            this.tabPid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPID)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabArduino;
        private System.Windows.Forms.TabPage tabConfig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPid;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListBox lstSerial;
        private System.Windows.Forms.ComboBox cmdSerial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtI;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtDR;
        private System.Windows.Forms.TextBox txtIR;
        private System.Windows.Forms.TextBox txtPR;
        private System.Windows.Forms.ComboBox cmdBaudRate;
        private System.Windows.Forms.Label label8;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtSR;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.RadioButton rdCtrlReverse;
        private System.Windows.Forms.RadioButton rdCtrlDirect;
        private System.Windows.Forms.RadioButton rdModeManual;
        private System.Windows.Forms.RadioButton rdModeAutomatic;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCtrl;
        private System.Windows.Forms.TextBox txtMode;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPID;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

