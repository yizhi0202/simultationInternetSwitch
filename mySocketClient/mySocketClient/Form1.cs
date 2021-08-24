using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Threading;

namespace mySocketClient
{
    public partial class mySocketClient : Form
    {
        public mySocketClient()
        {
            InitializeComponent();
        }
        /*private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "socketClient";
        }*/

        
        Socket mysocket;
        Thread mythread;

        private void userAvatar_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog fd = new FolderBrowserDialog();
        }

        private void welcomewords_Click(object sender, EventArgs e)
        {

        }

        private void toswitchIP_Click(object sender, EventArgs e)
        {

        }

        private void switchIPTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toswitchport_Click(object sender, EventArgs e)
        {

        }

        private void switchPortTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 连接交换机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ConnectSwitch_Click(object sender, EventArgs e)
        {
            try
            {
                mysocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                mysocket.Connect(new IPEndPoint(IPAddress.Parse(switchIPTextBox.Text), int.Parse(switchPortTextBox.Text)));
                mythread = new Thread(Receive);
                mythread.IsBackground = true;
                mythread.Start(mysocket);
            }
            catch(Exception ex)
            {
                acceptRichTextBox.Invoke(new Action(() => { acceptRichTextBox.AppendText("服务器异常:" + ex.Message); }));
            }
        }
        /// <summary>
        /// 开始接收数据
        /// </summary>
        /// <param name="obj"></param>
        private void Receive(object obj)
        {
            string str;
            while(true)
            {
                Socket receivesocket = obj as Socket;
                byte[] buffer = new byte[2048];
                try
                {
                    int count = receivesocket.Receive(buffer);
                    if(count == 0)
                    {
                        break;
                    }
                    else
                    {
                        str = Encoding.Default.GetString(buffer);
                        string dstMAC,srcMAC;                                    //暂时存放目的MACdstMAC 和源MAC
                        dstMAC = str.Substring(18, 17);                   //信息中第一位是连接的物理端口号，第2到18为是源MAC
                        srcMAC = str.Substring(1, 17);
                        if(selfMACTextBox.Text.Equals(dstMAC,StringComparison.OrdinalIgnoreCase))
                        {
                            string info;
                            info = str.Substring(35);
                            acceptRichTextBox.Invoke(new Action(() => { acceptRichTextBox.AppendText("\r\n接收到来自MAC地址为:" + srcMAC + "的信息,内容如下:" + info+"\r\n"); }));
                        }
                        
                    }
                }
                catch(Exception ex)
                {
                    acceptRichTextBox.Invoke(new Action(() => { acceptRichTextBox.AppendText("服务器异常:" + ex.Message); }));
                }
            }
        }
        /// <summary>
        /// 关闭与交换机的连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseConnect_Click(object sender, EventArgs e)
        {
            try
            {
                mysocket.Shutdown(SocketShutdown.Both);
                mysocket.Close();
                mythread.Abort();
                acceptRichTextBox.Invoke(new Action(() => { acceptRichTextBox.AppendText("\r已经关闭与交换机的连接！\n"); }));
            }
            catch(Exception ex)
            {
                acceptRichTextBox.Invoke(new Action(() => { acceptRichTextBox.AppendText("\r关闭连接时出现异常，信息如下:\n" + ex.Message); }));
            }
        }

        private void AlterMAC_Click(object sender, EventArgs e)
        {
            Regex rg = new Regex(@"(^[0-9a-fA-F][0-9a-fA-F]:[0-9a-fA-F][0-9a-fA-F]:[0-9a-fA-F][0-9a-fA-F]:[0-9a-fA-F][0-9a-fA-F]:[0-9a-fA-F][0-9a-fA-F]:[0-9a-fA-F][0-9a-fA-F]$)");
            if (!rg.IsMatch(selfMACTextBox.Text))
            {
                this.selfMACerrorProvider.SetError(selfMACTextBox, "输入MAC不符合规范，请检查后再输入！");
            }
            else
            {
                MessageBox.Show("更改MAC成功！");
                selfMACerrorProvider.Clear();
            }
        }

        private void ConfirmAcceptMAC_Click(object sender, EventArgs e)
        {
            Regex rg = new Regex(@"(^[0-9a-fA-F][0-9a-fA-F]:[0-9a-fA-F][0-9a-fA-F]:[0-9a-fA-F][0-9a-fA-F]:[0-9a-fA-F][0-9a-fA-F]:[0-9a-fA-F][0-9a-fA-F]:[0-9a-fA-F][0-9a-fA-F]$)");
            if (!rg.IsMatch(acceptMACTextbox.Text))
            {
                this.acceptMACerrorProvider.SetError(acceptMACTextbox, "输入MAC不符合规范，请检查后再输入！");
            }
            else
            {
                MessageBox.Show("填写目的MAC格式正确！");
                acceptMACerrorProvider.Clear();
            }
        }

        private void SendInfo_Click(object sender, EventArgs e)
        {
            string info;
            info = physicalportComboBox.Text+selfMACTextBox.Text + acceptMACTextbox.Text + sendinginfoTextBox.Text;           //数据中添加源和目的MAC
            mysocket.Send(Encoding.Default.GetBytes(info));
            sendRichTextBox.Invoke(new Action(() => { sendRichTextBox.AppendText("发送一条目的MAC为:" + acceptMACTextbox.Text + "信息内容为:" + sendinginfoTextBox.Text + "的消息。\r\n"); }));
            sendinginfoTextBox.Clear();
        }

        private void acceptMACTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
