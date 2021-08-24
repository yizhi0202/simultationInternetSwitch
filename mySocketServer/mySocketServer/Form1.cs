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
using System.Threading;
using System.Timers;
using mySocketServer.Properties;
using System.Text.RegularExpressions;

namespace mySocketServer
{
    public partial class mySocketServer : Form
    {
        public mySocketServer()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        //存储已经连接至服务器的客户端信息，如IP 和端口号
        private static Dictionary<string, Socket> socketLists = new Dictionary<string, Socket>();
        string []pysicalPortToIP =  new string [5];                         //零号位不用，1-4四个接口
        //定义一个阈值类
        ThreshHold mythreshhold = new ThreshHold();
        //int addrlistrows = 0;
        bool listenflag = true;
        List<AddrList> AddrLists = new List<AddrList>();           //存储地址表数据
        /// <summary>
        /// 在地址转发表中查找数据
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int SearchInAdLists(string str)
        {
            int i = 0;
            foreach(AddrList al in AddrLists)
            {
                if(al.GetMac()==str)
                {
                    return i;
                }
                i++;
            }
            return -1;
        }

        /// <summary>
        /// 接收连接
        /// </summary>
        /// <param name="obj"></param>
        Socket socketSend;                  //控制监听与停止
        public void StartServer(object obj)
        {
            string str;

            while (true)
            {
                //等待客户端连接
                socketSend = ((Socket)obj).Accept();

                if(listenflag == false)
                {
                    socketSend.Close();
                    processListRichTextBox.Invoke(new Action(() => { processListRichTextBox.AppendText("已经停止监听！"); }));
                    break;
                }
                //连接后存储socket和IP、端口信息
                str = socketSend.RemoteEndPoint.ToString();
                socketLists.Add(str, socketSend);

                //控件调用更新界面
                processListRichTextBox.Invoke(new Action(() => processListRichTextBox.AppendText(str + "已连接" + "\n")));

                //连接完成后，创建新线程监控接收新的客户端的请求数据
                Thread thread = new Thread(StartReceive);
                thread.IsBackground = true;
                thread.Start(socketSend);
            }
        }

       /// <summary>
       /// 更新转发表的显示
       /// </summary>


        public void UpdateaddrList()
        {
            //更新页面显示
            string strtodate;
            for (int i = addrList.Items.Count - 1; i >= 1; i--)
            {
                DateTime dt = new DateTime();
                strtodate = addrList.Items[i].SubItems[3].Text.Trim();
                dt = Convert.ToDateTime(strtodate);
                if (mythreshhold.IsTimeOut(dt))
                {
                    //过程记录中显示删除的MAC记录
                    processListRichTextBox.Invoke(new Action(() => { processListRichTextBox.AppendText("MAC地址为:" + addrList.Items[i].SubItems[1].Text + "已经删除，有效期已过！" + "\r\n"); }));
                    addrList.Invoke(new Action(() => { addrList.Items.RemoveAt(i); }));

                }
            }
        }
        /// <summary>
        /// 接收数据并转发，同时处理转发表和listview中的数据
        /// </summary>
        /// <param name="obj"></param>
        public void StartReceive(object obj)
        {
            string str;                             //要使用的数据
            string ip;
            string srcmac, dstmac;
            int idx;                                //查找addrlists返回的索引
            
            while (true)
            {
                int count;
                byte[] buffer = new byte[2048];             //缓冲区
                //string[] myport = new string[2];            //存放IP 和端口以供显示
                Thread thread = new Thread(UpdateaddrList);
                thread.IsBackground = true;
                thread.Start();
                try
                {
                    //将绑定的socket传来的数据放入缓冲区
                    count = ((Socket)obj).Receive(buffer);
                    ip = ((Socket)obj).RemoteEndPoint.ToString();
                    if (count == 0)
                    {
                        processListRichTextBox.Invoke(new Action(() => { processListRichTextBox.AppendText(ip + "已断开连接 " + "\r\n"); }));
                        break;
                    }
                    else
                    {
                        str = Encoding.Default.GetString(buffer, 0, count);
                        //显示已收到数据的过程
                        processListRichTextBox.Invoke(new Action(() => { processListRichTextBox.AppendText("收到" + ip + "数据 " + str + "\r\n"); }));
                        int pysicalport;                    //存放接口值
                        string temppysicalport;
                        temppysicalport = str.Substring(0, 1);
                        pysicalport = int.Parse(temppysicalport);
                        srcmac = str.Substring(1, 17);                  //格式为 xx:xx:xx:xx:xx:xx
                        dstmac = str.Substring(18, 17);
                        //更新转发表
                        for(int i = AddrLists.Count-1; i>=0; i--)
                        {
                            if(mythreshhold.IsTimeOut(AddrLists[i].GetDateTime()))
                            {
                                AddrLists.Remove(AddrLists[i]);
                            }
                        }
                        
                        //1,查看源mac是否在AddrLists中,在里面就返回非负数
                        idx = SearchInAdLists(srcmac);
                        if(idx < 0)             //添加记录至转发表并更新视图
                        {
                            AddrList al = new AddrList();
                            al.SetMac(srcmac);
                            al.SetEndPoint(temppysicalport);
                            al.SetDateTime(DateTime.Now);
                            AddrLists.Add(al);
                            processListRichTextBox.Invoke(new Action(() => { processListRichTextBox.AppendText("本交换机转发表中添加一条地址为" + srcmac + "的记录 " +"\r\n"); }));
                            pysicalPortToIP[pysicalport] = ip;                                  //添加接口到ip的映射
                            addrList.Invoke(new Action(() => {
                                //myport = ip.Split(':');                    //获取端口号
                                string[] listviewdata = new string[4];
                                listviewdata[1] = srcmac;
                                listviewdata[2] = temppysicalport;
                                listviewdata[3] = al.GetDateTime().ToString();
                                ListViewItem lvi = new ListViewItem(listviewdata, addrList.Items.Count);
                                addrList.Items.Add(lvi);
                            }));
                        }
                        else                    //存在更新TTL以及接口号（若接口号不对）
                        {
                            
                            AddrLists[idx].SetDateTime(DateTime.Now);
                            addrList.Invoke(new Action(() => { addrList.Items[idx+1].SubItems[3].Text = AddrLists[idx].GetDateTime().ToString(); }));
                            if(AddrLists[idx].GetEndPoint() != temppysicalport)
                            {
                                pysicalPortToIP[pysicalport] = ip;
                                AddrLists[idx].SetEndPoint(temppysicalport);
                                //myport = ip.Split(':');
                                addrList.Invoke(new Action(() => { addrList.Items[idx+1].SubItems[2].Text = temppysicalport; }));
                            }
                            processListRichTextBox.Invoke(new Action(() => { processListRichTextBox.AppendText("转发表中MAC地址为:" + srcmac + "记录已经更新！"+"\r\n"); }));


                        }

                        //2,查看目的mac是否在转发表中
                        idx = SearchInAdLists(dstmac);
                        
                        if (idx < 0)              // 不在则洪泛
                        {
                            processListRichTextBox.Invoke(new Action(() => { processListRichTextBox.AppendText("目的MAC " + dstmac + "不在转发表中，开始洪范！"+"\r\n"); }));
                            str = str.Substring(1);                 //更换新的接口号，若是发送给另外一个交换机
                            str = pysicalPort.Text + str;
                            byte[] newbuffer = Encoding.Default.GetBytes(str);
                            foreach (KeyValuePair<string,Socket> kvp in socketLists)
                            {
                                if(kvp.Key != ip)
                                {
                                    kvp.Value.Send(newbuffer);
                                }
                            }
                        }
                        else                    //利用转发表直接转发 ？过程记录显示查找到目的MAC并使用相应端口号
                        {
                            string dstip;       //记录目的IP

                            string pport;       //记录接口号
                            pport = AddrLists[idx].GetEndPoint();
                            dstip = pysicalPortToIP[int.Parse(pport)];
                            //myport = dstip.Split(':');
                            processListRichTextBox.Invoke(new Action(() => { processListRichTextBox.AppendText("查找转发表，目的MAC " + dstmac + "对应的端口号为" + pport+"\r\n"); }));
                            str = str.Substring(1);                 //更换新的接口号，若是发送给另外一个交换机
                            str = pysicalPort.Text + str;
                            byte[] newbuffer = Encoding.Default.GetBytes(str);
                            socketLists[dstip].Send(newbuffer);
                        }

                    }
                }
                catch (Exception)
                {

                }
            }
        }


        /// <summary>
        /// 开始或停止监听
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="value"></param>
        private void listenSwitch_ValueChanged(object sender, bool value)
        {

            if (value == true)                   //按下开始监听，接收连接
            {
                //确定使用的协议和服务类型
                Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                //绑定IP和端口
                IPEndPoint IEP = new IPEndPoint(IPAddress.Parse(selfip.Text), int.Parse(selfport.Text));
                socket.Bind(IEP);

                //开始监听
                socket.Listen(10);
                listenflag = true;
                processListRichTextBox.Invoke(new Action(() => { processListRichTextBox.AppendText("开始监听" + "\r\n"); }));

                Thread thread = new Thread(new ParameterizedThreadStart(StartServer));
                thread.IsBackground = true;
                thread.Start(socket);
            }
            else                            //停止监听
            {
                listenflag = false;
                processListRichTextBox.Invoke(new Action(() => { processListRichTextBox.AppendText("停止监听" + "\r\n"); }));
            }
        }



        private void toswitchIp_Click(object sender, EventArgs e)
        {

        }

        private void switchIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void switchPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void toswitchPort_Click(object sender, EventArgs e)
        {

        }

       

        

        private void alterMAC_Click(object sender, EventArgs e)
        {
            Regex rg = new Regex(@"(^[0-9a-fA-F][0-9a-fA-F]:[0-9a-fA-F][0-9a-fA-F]:[0-9a-fA-F][0-9a-fA-F]:[0-9a-fA-F][0-9a-fA-F]:[0-9a-fA-F][0-9a-fA-F]:[0-9a-fA-F][0-9a-fA-F]$)");
            if (!rg.IsMatch(selfMAC.Text))
            {
                this.macerrorProvider.SetError(selfMAC, "输入MAC不符合规范，请检查后再输入！");
            }
            else
            {
                MessageBox.Show("更改MAC成功！");
                macerrorProvider.Clear();
            }
        }

        

        private void addrList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "socketServer";
        }




        Thread ConnectThread;
        Socket Connectsocket;
       
        /// <summary>
        /// 连接至另一个交换机
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Connectsocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Connectsocket.Connect(new IPEndPoint(IPAddress.Parse(switchIP.Text), int.Parse(switchPort.Text)));
                string str = Connectsocket.RemoteEndPoint.ToString();
                socketLists.Add(str, Connectsocket);
                ConnectThread = new Thread(StartReceive);
                ConnectThread.IsBackground = true;
                ConnectThread.Start(Connectsocket);
            }
            catch(Exception ex)
            {
                processListRichTextBox.Invoke(new Action(() => { processListRichTextBox.AppendText("拟连接交换机异常：" + ex.Message+"\r\n"); }));
            }
            
        }

        /// <summary>
        /// 断开与另外一个交换机的连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void closeConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Connectsocket.Shutdown(SocketShutdown.Both);
                Connectsocket.Close();
                ConnectThread.Abort();
                processListRichTextBox.Invoke(new Action(() => { processListRichTextBox.AppendText("已经断开与交换机的连接！" + "\r\n"); }));

            }
            catch(Exception ex)
            {
                processListRichTextBox.Invoke(new Action(() => { processListRichTextBox.AppendText("断开交换机时异常：" + ex.Message + "\r\n"); }));
            }
        }

        private void processListRichTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toselfport_Click(object sender, EventArgs e)
        {

        }

        private void selfport_TextChanged(object sender, EventArgs e)
        {

        }

        private void toselfip_Click(object sender, EventArgs e)
        {

        }

        private void selfip_TextChanged(object sender, EventArgs e)
        {

        }

        private void alterSelfPort_Click(object sender, EventArgs e)
        {

        }

        private void clearProcessList_Click(object sender, EventArgs e)
        {
            processListRichTextBox.Invoke(new Action(() => { processListRichTextBox.Text = ""; }));                 //清空processListRichTextBox
                
        }

        private void pysicalPort_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
