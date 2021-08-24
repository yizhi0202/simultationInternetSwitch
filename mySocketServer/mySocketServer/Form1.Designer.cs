namespace mySocketServer
{
    partial class mySocketServer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mySocketServer));
            this.toswitchIp = new Sunny.UI.UILabel();
            this.switchIP = new Sunny.UI.UITextBox();
            this.toswitchPort = new Sunny.UI.UILabel();
            this.switchPort = new Sunny.UI.UITextBox();
            this.closeConnect = new Sunny.UI.UISymbolButton();
            this.toselfMac = new Sunny.UI.UILabel();
            this.selfMAC = new Sunny.UI.UITextBox();
            this.alterMAC = new Sunny.UI.UISymbolButton();
            this.listenSwitch = new Sunny.UI.UISwitch();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.addrList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MacRecord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PortRecord = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TTL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.process = new Sunny.UI.UILabel();
            this.clearProcessList = new Sunny.UI.UISymbolButton();
            this.startConnect = new Sunny.UI.UISymbolButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.processListRichTextBox = new Sunny.UI.UIRichTextBox();
            this.toselfport = new Sunny.UI.UILabel();
            this.selfport = new Sunny.UI.UITextBox();
            this.toselfip = new Sunny.UI.UILabel();
            this.selfip = new Sunny.UI.UITextBox();
            this.macerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pysicalPort = new Sunny.UI.UIComboBox();
            this.uiLabel2 = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)(this.macerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // toswitchIp
            // 
            this.toswitchIp.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toswitchIp.Location = new System.Drawing.Point(12, 9);
            this.toswitchIp.Name = "toswitchIp";
            this.toswitchIp.Size = new System.Drawing.Size(160, 31);
            this.toswitchIp.TabIndex = 0;
            this.toswitchIp.Text = "拟连接交换机IP:";
            this.toswitchIp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toswitchIp.Click += new System.EventHandler(this.toswitchIp_Click);
            // 
            // switchIP
            // 
            this.switchIP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.switchIP.FillColor = System.Drawing.Color.White;
            this.switchIP.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.switchIP.Location = new System.Drawing.Point(179, 9);
            this.switchIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.switchIP.Maximum = 2147483647D;
            this.switchIP.Minimum = -2147483648D;
            this.switchIP.MinimumSize = new System.Drawing.Size(1, 1);
            this.switchIP.Name = "switchIP";
            this.switchIP.Padding = new System.Windows.Forms.Padding(5);
            this.switchIP.Size = new System.Drawing.Size(150, 34);
            this.switchIP.TabIndex = 1;
            this.switchIP.TextChanged += new System.EventHandler(this.switchIP_TextChanged);
            // 
            // toswitchPort
            // 
            this.toswitchPort.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toswitchPort.Location = new System.Drawing.Point(336, 9);
            this.toswitchPort.Name = "toswitchPort";
            this.toswitchPort.Size = new System.Drawing.Size(168, 31);
            this.toswitchPort.TabIndex = 2;
            this.toswitchPort.Text = "拟连接交机端口:";
            this.toswitchPort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toswitchPort.Click += new System.EventHandler(this.toswitchPort_Click);
            // 
            // switchPort
            // 
            this.switchPort.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.switchPort.FillColor = System.Drawing.Color.White;
            this.switchPort.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.switchPort.Location = new System.Drawing.Point(492, 9);
            this.switchPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.switchPort.Maximum = 2147483647D;
            this.switchPort.Minimum = -2147483648D;
            this.switchPort.MinimumSize = new System.Drawing.Size(1, 1);
            this.switchPort.Name = "switchPort";
            this.switchPort.Padding = new System.Windows.Forms.Padding(5);
            this.switchPort.Size = new System.Drawing.Size(97, 34);
            this.switchPort.TabIndex = 2;
            this.switchPort.TextChanged += new System.EventHandler(this.switchPort_TextChanged);
            // 
            // closeConnect
            // 
            this.closeConnect.CircleRectWidth = 20;
            this.closeConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeConnect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.closeConnect.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.closeConnect.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.closeConnect.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.closeConnect.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.closeConnect.ImageInterval = 0;
            this.closeConnect.Location = new System.Drawing.Point(782, 5);
            this.closeConnect.MinimumSize = new System.Drawing.Size(1, 1);
            this.closeConnect.Name = "closeConnect";
            this.closeConnect.Radius = 30;
            this.closeConnect.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.closeConnect.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.closeConnect.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.closeConnect.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.closeConnect.ShowTips = true;
            this.closeConnect.Size = new System.Drawing.Size(113, 42);
            this.closeConnect.Style = Sunny.UI.UIStyle.Red;
            this.closeConnect.Symbol = 61527;
            this.closeConnect.TabIndex = 4;
            this.closeConnect.Text = "断开连接";
            this.closeConnect.TipsColor = System.Drawing.Color.Black;
            this.closeConnect.Click += new System.EventHandler(this.closeConnect_Click);
            // 
            // toselfMac
            // 
            this.toselfMac.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toselfMac.Location = new System.Drawing.Point(12, 48);
            this.toselfMac.Name = "toselfMac";
            this.toselfMac.Size = new System.Drawing.Size(146, 31);
            this.toselfMac.TabIndex = 5;
            this.toselfMac.Text = "本交换机MAC:\r\n";
            this.toselfMac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // selfMAC
            // 
            this.selfMAC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.selfMAC.FillColor = System.Drawing.Color.White;
            this.selfMAC.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.selfMAC.Location = new System.Drawing.Point(165, 48);
            this.selfMAC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selfMAC.Maximum = 2147483647D;
            this.selfMAC.Minimum = -2147483648D;
            this.selfMAC.MinimumSize = new System.Drawing.Size(1, 1);
            this.selfMAC.Name = "selfMAC";
            this.selfMAC.Padding = new System.Windows.Forms.Padding(5);
            this.selfMAC.Size = new System.Drawing.Size(186, 34);
            this.selfMAC.TabIndex = 2;
            // 
            // alterMAC
            // 
            this.alterMAC.CircleRectWidth = 20;
            this.alterMAC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alterMAC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.alterMAC.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.alterMAC.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.alterMAC.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.alterMAC.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.alterMAC.ImageInterval = 0;
            this.alterMAC.Location = new System.Drawing.Point(358, 43);
            this.alterMAC.MinimumSize = new System.Drawing.Size(1, 1);
            this.alterMAC.Name = "alterMAC";
            this.alterMAC.Radius = 30;
            this.alterMAC.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.alterMAC.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.alterMAC.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.alterMAC.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.alterMAC.ShowTips = true;
            this.alterMAC.Size = new System.Drawing.Size(126, 42);
            this.alterMAC.Style = Sunny.UI.UIStyle.Orange;
            this.alterMAC.Symbol = 61508;
            this.alterMAC.TabIndex = 6;
            this.alterMAC.Text = "更改MAC";
            this.alterMAC.TipsColor = System.Drawing.Color.Black;
            this.alterMAC.Click += new System.EventHandler(this.alterMAC_Click);
            // 
            // listenSwitch
            // 
            this.listenSwitch.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.listenSwitch.ActiveText = "开始监听";
            this.listenSwitch.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.listenSwitch.InActiveText = "结束监听";
            this.listenSwitch.Location = new System.Drawing.Point(768, 53);
            this.listenSwitch.MinimumSize = new System.Drawing.Size(1, 1);
            this.listenSwitch.Name = "listenSwitch";
            this.listenSwitch.Size = new System.Drawing.Size(127, 39);
            this.listenSwitch.Style = Sunny.UI.UIStyle.Custom;
            this.listenSwitch.TabIndex = 7;
            this.listenSwitch.Text = "开始监听";
            this.listenSwitch.ValueChanged += new Sunny.UI.UISwitch.OnValueChanged(this.listenSwitch_ValueChanged);
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel1.Location = new System.Drawing.Point(12, 145);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(177, 31);
            this.uiLabel1.TabIndex = 8;
            this.uiLabel1.Text = "地址表：";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addrList
            // 
            this.addrList.BackColor = System.Drawing.SystemColors.Window;
            this.addrList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.MacRecord,
            this.PortRecord,
            this.TTL});
            this.addrList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addrList.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addrList.HideSelection = false;
            listViewItem1.IndentCount = 60;
            listViewItem1.StateImageIndex = 0;
            this.addrList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.addrList.Location = new System.Drawing.Point(3, 184);
            this.addrList.Name = "addrList";
            this.addrList.Size = new System.Drawing.Size(468, 446);
            this.addrList.TabIndex = 9;
            this.addrList.UseCompatibleStateImageBehavior = false;
            this.addrList.View = System.Windows.Forms.View.Details;
            this.addrList.SelectedIndexChanged += new System.EventHandler(this.addrList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.DisplayIndex = 1;
            this.columnHeader1.Width = 0;
            // 
            // MacRecord
            // 
            this.MacRecord.DisplayIndex = 0;
            this.MacRecord.Text = "MAC";
            this.MacRecord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MacRecord.Width = 178;
            // 
            // PortRecord
            // 
            this.PortRecord.Text = "端口号";
            this.PortRecord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PortRecord.Width = 86;
            // 
            // TTL
            // 
            this.TTL.Text = "有效期";
            this.TTL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TTL.Width = 206;
            // 
            // process
            // 
            this.process.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.process.Location = new System.Drawing.Point(473, 145);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(177, 31);
            this.process.TabIndex = 10;
            this.process.Text = "过程：";
            this.process.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // clearProcessList
            // 
            this.clearProcessList.CircleRectWidth = 20;
            this.clearProcessList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearProcessList.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.clearProcessList.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.clearProcessList.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.clearProcessList.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.clearProcessList.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clearProcessList.ImageInterval = 0;
            this.clearProcessList.Location = new System.Drawing.Point(729, 140);
            this.clearProcessList.MinimumSize = new System.Drawing.Size(1, 1);
            this.clearProcessList.Name = "clearProcessList";
            this.clearProcessList.Radius = 30;
            this.clearProcessList.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.clearProcessList.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.clearProcessList.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.clearProcessList.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.clearProcessList.ShowTips = true;
            this.clearProcessList.Size = new System.Drawing.Size(116, 42);
            this.clearProcessList.Style = Sunny.UI.UIStyle.Orange;
            this.clearProcessList.Symbol = 61473;
            this.clearProcessList.TabIndex = 12;
            this.clearProcessList.Text = "清空记录";
            this.clearProcessList.TipsColor = System.Drawing.Color.Black;
            this.clearProcessList.Click += new System.EventHandler(this.clearProcessList_Click);
            // 
            // startConnect
            // 
            this.startConnect.CircleRectWidth = 20;
            this.startConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startConnect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.startConnect.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
            this.startConnect.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.startConnect.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.startConnect.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.startConnect.ImageInterval = 10;
            this.startConnect.Location = new System.Drawing.Point(656, 5);
            this.startConnect.MinimumSize = new System.Drawing.Size(1, 1);
            this.startConnect.Name = "startConnect";
            this.startConnect.Radius = 30;
            this.startConnect.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.startConnect.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
            this.startConnect.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.startConnect.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.startConnect.ShowTips = true;
            this.startConnect.Size = new System.Drawing.Size(103, 42);
            this.startConnect.Style = Sunny.UI.UIStyle.Green;
            this.startConnect.TabIndex = 15;
            this.startConnect.Text = "连接";
            this.startConnect.TipsColor = System.Drawing.Color.Black;
            this.startConnect.Click += new System.EventHandler(this.startConnect_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // processListRichTextBox
            // 
            this.processListRichTextBox.AutoWordSelection = true;
            this.processListRichTextBox.FillColor = System.Drawing.Color.White;
            this.processListRichTextBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.processListRichTextBox.Location = new System.Drawing.Point(478, 184);
            this.processListRichTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.processListRichTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.processListRichTextBox.Name = "processListRichTextBox";
            this.processListRichTextBox.Padding = new System.Windows.Forms.Padding(2);
            this.processListRichTextBox.Size = new System.Drawing.Size(367, 446);
            this.processListRichTextBox.Style = Sunny.UI.UIStyle.Custom;
            this.processListRichTextBox.TabIndex = 17;
            this.processListRichTextBox.TextChanged += new System.EventHandler(this.processListRichTextBox_TextChanged);
            // 
            // toselfport
            // 
            this.toselfport.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toselfport.Location = new System.Drawing.Point(298, 95);
            this.toselfport.Name = "toselfport";
            this.toselfport.Size = new System.Drawing.Size(100, 23);
            this.toselfport.TabIndex = 18;
            this.toselfport.Text = "本机端口:";
            this.toselfport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toselfport.Click += new System.EventHandler(this.toselfport_Click);
            // 
            // selfport
            // 
            this.selfport.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.selfport.FillColor = System.Drawing.Color.White;
            this.selfport.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.selfport.Location = new System.Drawing.Point(405, 92);
            this.selfport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selfport.Maximum = 2147483647D;
            this.selfport.Minimum = -2147483648D;
            this.selfport.MinimumSize = new System.Drawing.Size(1, 1);
            this.selfport.Name = "selfport";
            this.selfport.Padding = new System.Windows.Forms.Padding(5);
            this.selfport.Size = new System.Drawing.Size(150, 34);
            this.selfport.TabIndex = 3;
            this.selfport.TextChanged += new System.EventHandler(this.selfport_TextChanged);
            // 
            // toselfip
            // 
            this.toselfip.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toselfip.Location = new System.Drawing.Point(12, 95);
            this.toselfip.Name = "toselfip";
            this.toselfip.Size = new System.Drawing.Size(81, 23);
            this.toselfip.TabIndex = 20;
            this.toselfip.Text = "本机IP:";
            this.toselfip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toselfip.Click += new System.EventHandler(this.toselfip_Click);
            // 
            // selfip
            // 
            this.selfip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.selfip.FillColor = System.Drawing.Color.White;
            this.selfip.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.selfip.Location = new System.Drawing.Point(100, 92);
            this.selfip.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selfip.Maximum = 2147483647D;
            this.selfip.Minimum = -2147483648D;
            this.selfip.MinimumSize = new System.Drawing.Size(1, 1);
            this.selfip.Name = "selfip";
            this.selfip.Padding = new System.Windows.Forms.Padding(5);
            this.selfip.Size = new System.Drawing.Size(150, 34);
            this.selfip.TabIndex = 4;
            this.selfip.TextChanged += new System.EventHandler(this.selfip_TextChanged);
            // 
            // macerrorProvider
            // 
            this.macerrorProvider.ContainerControl = this;
            this.macerrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("macerrorProvider.Icon")));
            // 
            // pysicalPort
            // 
            this.pysicalPort.FillColor = System.Drawing.Color.White;
            this.pysicalPort.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.pysicalPort.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.pysicalPort.Location = new System.Drawing.Point(595, 92);
            this.pysicalPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pysicalPort.MinimumSize = new System.Drawing.Size(63, 0);
            this.pysicalPort.Name = "pysicalPort";
            this.pysicalPort.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.pysicalPort.Size = new System.Drawing.Size(150, 34);
            this.pysicalPort.TabIndex = 21;
            this.pysicalPort.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.pysicalPort.SelectedIndexChanged += new System.EventHandler(this.pysicalPort_SelectedIndexChanged);
            // 
            // uiLabel2
            // 
            this.uiLabel2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel2.Location = new System.Drawing.Point(540, 59);
            this.uiLabel2.Name = "uiLabel2";
            this.uiLabel2.Size = new System.Drawing.Size(222, 23);
            this.uiLabel2.TabIndex = 22;
            this.uiLabel2.Text = "连接交换机物理端口号:";
            this.uiLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mySocketServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 656);
            this.Controls.Add(this.uiLabel2);
            this.Controls.Add(this.pysicalPort);
            this.Controls.Add(this.selfip);
            this.Controls.Add(this.toselfip);
            this.Controls.Add(this.selfport);
            this.Controls.Add(this.toselfport);
            this.Controls.Add(this.processListRichTextBox);
            this.Controls.Add(this.startConnect);
            this.Controls.Add(this.clearProcessList);
            this.Controls.Add(this.process);
            this.Controls.Add(this.addrList);
            this.Controls.Add(this.uiLabel1);
            this.Controls.Add(this.listenSwitch);
            this.Controls.Add(this.alterMAC);
            this.Controls.Add(this.selfMAC);
            this.Controls.Add(this.toselfMac);
            this.Controls.Add(this.closeConnect);
            this.Controls.Add(this.switchPort);
            this.Controls.Add(this.toswitchPort);
            this.Controls.Add(this.switchIP);
            this.Controls.Add(this.toswitchIp);
            this.Name = "mySocketServer";
            this.Text = "socketServer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.macerrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UILabel toswitchIp;
        private Sunny.UI.UITextBox switchIP;
        private Sunny.UI.UILabel toswitchPort;
        private Sunny.UI.UITextBox switchPort;
        private Sunny.UI.UISymbolButton closeConnect;
        private Sunny.UI.UILabel toselfMac;
        private Sunny.UI.UITextBox selfMAC;
        private Sunny.UI.UISymbolButton alterMAC;
        private Sunny.UI.UISwitch listenSwitch;
        private Sunny.UI.UILabel uiLabel1;
        private System.Windows.Forms.ListView addrList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader MacRecord;
        private System.Windows.Forms.ColumnHeader PortRecord;
        private System.Windows.Forms.ColumnHeader TTL;
        private Sunny.UI.UILabel process;
        private Sunny.UI.UISymbolButton clearProcessList;
        private Sunny.UI.UISymbolButton startConnect;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Sunny.UI.UIRichTextBox processListRichTextBox;
        private Sunny.UI.UILabel toselfport;
        private Sunny.UI.UITextBox selfport;
        private Sunny.UI.UILabel toselfip;
        private Sunny.UI.UITextBox selfip;
        private System.Windows.Forms.ErrorProvider macerrorProvider;
        private Sunny.UI.UIComboBox pysicalPort;
        private Sunny.UI.UILabel uiLabel2;
    }
}

