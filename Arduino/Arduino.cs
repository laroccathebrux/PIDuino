using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Arduino
{
    public partial class frmArduino : Form
    {
        SerialPort serialPort = new SerialPort();
        const string TERM_CHAR = "\n";
        string msg;

        Thread t;
        ManualResetEvent runThread = new ManualResetEvent(false);

        private delegate void DelegateAddToList(string msg);
        private DelegateAddToList m_DelegateAddToList;
        

        public frmArduino()
        {
            InitializeComponent();

            int[] baudrates =
            {
                4800,
                9600,
                14400,
                19200,
                28800,
                38400,
                57600,
                115200
            };

            foreach(int i in baudrates)
            {
                cmdBaudRate.Items.Add(Convert.ToString(i));
            }

            SerialPort tmp;
            foreach(string str in SerialPort.GetPortNames())
            {
                tmp = new SerialPort(str);
                if (tmp.IsOpen == false)
                    cmdSerial.Items.Add(str);
            }
        }

        private void ReceiveThread()
        {
            while (true)
            {
                runThread.WaitOne(Timeout.Infinite);
                while (true)
                {
                    try
                    {
                        string msg = serialPort.ReadLine();
                        this.Invoke(this.m_DelegateAddToList, new Object[] { msg });
                    }
                    catch
                    {
                        runThread.Reset();
                        break;
                    }
                }
            }
        }

        private void cmdSerial_SelectedIndexChanged(object sender, EventArgs e)
        {
            connectArduino();
        }

        

        private void connectArduino()
        {
            serialPort.PortName = cmdSerial.Text;

            try
            {
                
                serialPort.Open();
                
                cmdSerial.Enabled = false;
                if (cmdBaudRate.Text.CompareTo("") != 0)
                {
                    btnConnect.Enabled = true;
                    cmdBaudRate.Enabled = false;
                }

                btnConnect.Text = "Disconnect";
                int n = lstSerial.Items.Add("Connection established...");
                lstSerial.SelectedIndex = n;
                lstSerial.ClearSelected();

                runThread.Set();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmdSerial.Text = "";
            }
        }

        private void AddToList(string msg)
        {
            int n = lstSerial.Items.Add(msg);
            lstSerial.SelectedIndex = n;
            lstSerial.ClearSelected();
            string[] words = msg.Split(' ');
            foreach (string word in words)
            {
                if (words[0] == "PID" && words.Length == 9)
                {
                    txtSR.Text = words[1];
                    txtInput.Text = words[2];
                    txtOutput.Text = words[3];
                    txtPR.Text = words[4];
                    txtIR.Text = words[5];
                    txtDR.Text = words[6];
                    txtMode.Text = words[7];
                    txtCtrl.Text = words[8];
                    string txtOldSR = txtSR.Text;
                    string txtOldInput = txtInput.Text;
                    chartPID.Series["SetPoint"].Points.AddY(Convert.ToDouble(txtOldSR.Replace('.', ',')));
                    chartPID.Series["Input"].Points.AddY(Convert.ToDouble(txtOldInput.Replace('.', ',')));
                }
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == "Disconnect")
            {
                btnConnect.Text = "Connect";
                if (serialPort.IsOpen == true)
                {
                    serialPort.Close();
                    cmdBaudRate.Enabled = true;
                    cmdSerial.Enabled = true;
                    runThread.Reset();
                    txtPR.Clear();
                    txtP.Clear();
                    txtIR.Clear();
                    txtI.Clear();
                    txtDR.Clear();
                    txtD.Clear();
                    txtSR.Clear();
                    txtS.Clear();
                    txtInput.Clear();
                    txtOutput.Clear();
                }
            }
            else
            {
                connectArduino();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmdBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            serialPort.BaudRate = Convert.ToInt16(cmdBaudRate.Text);
            if (cmdSerial.Text.CompareTo("") != 0)
            {
                btnConnect.Enabled = true;
                cmdBaudRate.Enabled = false;
            }
                

        }



        private void frmArduino_Load(object sender, EventArgs e)
        {
            serialPort.NewLine = TERM_CHAR;

            m_DelegateAddToList = new DelegateAddToList(AddToList);

            t = new Thread(ReceiveThread);
            t.Start();

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string serialSend = "";
            if (txtS.Text != "")
            {
                serialSend += txtS.Text;
                txtS.Clear();
            }
            else
            {
                serialSend += txtSR.Text;
            }
            serialSend += " ";
            if (txtP.Text != "")
            {
                serialSend += txtP.Text;
                txtP.Clear();
            }
            else
            {
                serialSend += txtPR.Text;
            }
            serialSend += " ";
            if (txtI.Text != "")
            {
                serialSend += txtI.Text;
                txtI.Clear();
            }
            else
            {
                serialSend += txtIR.Text;
            }
            serialSend += " ";
            if (txtD.Text != "")
            {
                serialSend += txtD.Text;
                txtD.Clear();
            }
            else
            {
                serialSend += txtDR.Text;
            }
            serialSend += " ";
            if (rdModeAutomatic.Checked == true)
            {
                serialSend += "Automatic";
            }
            else
            {
                serialSend += "Manual";
            }
            serialSend += " ";
            if (rdCtrlDirect.Checked == true)
            {
                serialSend += "Direct";
            }
            else
            {
                serialSend += "Reverse";
            }
            serialSend += "\n";
            try
            {
                serialPort.WriteLine(serialSend);
                int n = lstSerial.Items.Add(serialSend);
                lstSerial.SelectedIndex = n;
                lstSerial.ClearSelected();
                serialSend = "";
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void chrtPid_Click(object sender, EventArgs e)
        {

        }
    }

}
