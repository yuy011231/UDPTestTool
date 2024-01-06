using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDPTestTool
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();
        private IPEndPoint _target = null;
        public Form1()
        {
            InitializeComponent();

            using (StreamWriter writer = new StreamWriter(@"./log.txt", false, Encoding.GetEncoding("Shift_JIS")))
            {
                writer.WriteLine("Start");
            }

            _timer.Interval = 100;
            _timer.Tick += _timer_Tick;
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            byte[] receiveData = { };
            bool receiveResult = Receive(ref receiveData);
            if (receiveResult)
            {
                using (StreamWriter writer = new StreamWriter(@"./log.txt", true, Encoding.GetEncoding("Shift_JIS")))
                {
                    string writeData = string.Empty;
                    foreach(byte data in receiveData)
                    {
                        writeData = writeData + " " + data.ToString("X2");
                    }
                    writer.WriteLine(writeData + "\r\n");
                    ReceiveDataText.Text = writeData;

                    bool sendResult1 = Send(receiveData);
                    if (sendResult1)
                    {
                        writer.WriteLine("SendData--------------------------------------------------------------------------");
                    }
                    else
                    {
                        writer.WriteLine("Failure SendData------------------------------------------------------------------");
                        ReceiveDataText.Text = "Failure SendData";
                    }
                }
            }
            else
            {
                using (StreamWriter writer = new StreamWriter(@"./log.txt", true, Encoding.GetEncoding("Shift_JIS")))
                {
                    writer.WriteLine("Failure Receive-----------------------------------------------------------------------");
                    ReceiveDataText.Text = "Failure Receive";
                }
            }
        }

        private bool Send(byte[] buffer)
        {
            try
            {
                using (UdpClient udpSend = new UdpClient(20501))
                {
                    udpSend.Send(buffer, buffer.Length, _target);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool Receive(ref byte[] buffer)
        {
            IPEndPoint remoteEP = null;//任意の送信元からのデータを受信
            try
            {
                using (UdpClient udpReceive = new UdpClient(20501)) 
                {
                    udpReceive.Client.ReceiveTimeout = 100;
                    buffer = udpReceive.Receive(ref remoteEP);
                    if(_target == null)
                    {
                        _target = new IPEndPoint(remoteEP.Address, 20501);
                    }
                }
                return true;
            }
            catch 
            {
                return false;
            }
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if(_timer.Enabled != true)
            {
                _timer.Start();
            }
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            if (_timer.Enabled == true)
            {
                _timer.Stop();
            }
        }
    }
}
