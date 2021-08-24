namespace mySocketClient
{
    partial class mySocketClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mySocketClient));
            this.userAvatar = new Sunny.UI.UIAvatar();
            this.welcomewords = new Sunny.UI.UIScrollingText();
            this.toswitchIP = new Sunny.UI.UILabel();
            this.switchIPTextBox = new Sunny.UI.UITextBox();
            this.switchPortTextBox = new Sunny.UI.UITextBox();
            this.toswitchport = new Sunny.UI.UILabel();
            this.ConnectSwitch = new Sunny.UI.UISymbolButton();
            this.CloseConnect = new Sunny.UI.UISymbolButton();
            this.toselfMAC = new Sunny.UI.UILabel();
            this.selfMACTextBox = new Sunny.UI.UITextBox();
            this.AlterMAC = new Sunny.UI.UISymbolButton();
            this.toswitchphysicalport = new Sunny.UI.UILabel();
            this.physicalportComboBox = new Sunny.UI.UIComboBox();
            this.tosendinfo = new Sunny.UI.UILabel();
            this.toacceptinfo = new Sunny.UI.UILabel();
            this.sendRichTextBox = new Sunny.UI.UIRichTextBox();
            this.acceptRichTextBox = new Sunny.UI.UIRichTextBox();
            this.toacceptMAC = new Sunny.UI.UILabel();
            this.tosendinginfo = new Sunny.UI.UILabel();
            this.ConfirmAcceptMAC = new Sunny.UI.UISymbolButton();
            this.SendInfo = new Sunny.UI.UISymbolButton();
            this.acceptMACTextbox = new Sunny.UI.UITextBox();
            this.sendinginfoTextBox = new Sunny.UI.UITextBox();
            this.selfMACerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.acceptMACerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.selfMACerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptMACerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // userAvatar
            // 
            this.userAvatar.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.userAvatar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.userAvatar.Icon = Sunny.UI.UIAvatar.UIIcon.Image;
            this.userAvatar.Image = ((System.Drawing.Image)(resources.GetObject("userAvatar.Image")));
            this.userAvatar.Location = new System.Drawing.Point(12, 12);
            this.userAvatar.MinimumSize = new System.Drawing.Size(1, 1);
            this.userAvatar.Name = "userAvatar";
            this.userAvatar.Size = new System.Drawing.Size(81, 73);
            this.userAvatar.Style = Sunny.UI.UIStyle.Orange;
            this.userAvatar.TabIndex = 0;
            this.userAvatar.Text = "uiAvatar1";
            this.userAvatar.Click += new System.EventHandler(this.userAvatar_Click);
            // 
            // welcomewords
            // 
            this.welcomewords.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(245)))), ((int)(((byte)(233)))));
            this.welcomewords.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.welcomewords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.welcomewords.Location = new System.Drawing.Point(247, 12);
            this.welcomewords.MinimumSize = new System.Drawing.Size(1, 1);
            this.welcomewords.Name = "welcomewords";
            this.welcomewords.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.welcomewords.Size = new System.Drawing.Size(355, 35);
            this.welcomewords.Style = Sunny.UI.UIStyle.Orange;
            this.welcomewords.TabIndex = 1;
            this.welcomewords.Text = "热烈欢迎您使用本主机，祝您生活愉快";
            this.welcomewords.Click += new System.EventHandler(this.welcomewords_Click);
            // 
            // toswitchIP
            // 
            this.toswitchIP.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toswitchIP.Location = new System.Drawing.Point(7, 88);
            this.toswitchIP.Name = "toswitchIP";
            this.toswitchIP.Size = new System.Drawing.Size(150, 23);
            this.toswitchIP.TabIndex = 2;
            this.toswitchIP.Text = "拟连接交换机IP:";
            this.toswitchIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toswitchIP.Click += new System.EventHandler(this.toswitchIP_Click);
            // 
            // switchIPTextBox
            // 
            this.switchIPTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.switchIPTextBox.FillColor = System.Drawing.Color.White;
            this.switchIPTextBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.switchIPTextBox.Location = new System.Drawing.Point(164, 88);
            this.switchIPTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.switchIPTextBox.Maximum = 2147483647D;
            this.switchIPTextBox.Minimum = -2147483648D;
            this.switchIPTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.switchIPTextBox.Name = "switchIPTextBox";
            this.switchIPTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.switchIPTextBox.Size = new System.Drawing.Size(170, 34);
            this.switchIPTextBox.TabIndex = 3;
            this.switchIPTextBox.TextChanged += new System.EventHandler(this.switchIPTextBox_TextChanged);
            // 
            // switchPortTextBox
            // 
            this.switchPortTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.switchPortTextBox.FillColor = System.Drawing.Color.White;
            this.switchPortTextBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.switchPortTextBox.Location = new System.Drawing.Point(533, 88);
            this.switchPortTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.switchPortTextBox.Maximum = 2147483647D;
            this.switchPortTextBox.Minimum = -2147483648D;
            this.switchPortTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.switchPortTextBox.Name = "switchPortTextBox";
            this.switchPortTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.switchPortTextBox.Size = new System.Drawing.Size(86, 34);
            this.switchPortTextBox.TabIndex = 4;
            this.switchPortTextBox.TextChanged += new System.EventHandler(this.switchPortTextBox_TextChanged);
            // 
            // toswitchport
            // 
            this.toswitchport.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toswitchport.Location = new System.Drawing.Point(351, 88);
            this.toswitchport.Name = "toswitchport";
            this.toswitchport.Size = new System.Drawing.Size(175, 23);
            this.toswitchport.TabIndex = 5;
            this.toswitchport.Text = "拟连接交换机端口:";
            this.toswitchport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toswitchport.Click += new System.EventHandler(this.toswitchport_Click);
            // 
            // ConnectSwitch
            // 
            this.ConnectSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ConnectSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConnectSwitch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ConnectSwitch.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
            this.ConnectSwitch.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.ConnectSwitch.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.ConnectSwitch.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConnectSwitch.Location = new System.Drawing.Point(652, 88);
            this.ConnectSwitch.MinimumSize = new System.Drawing.Size(1, 1);
            this.ConnectSwitch.Name = "ConnectSwitch";
            this.ConnectSwitch.Radius = 30;
            this.ConnectSwitch.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.ConnectSwitch.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
            this.ConnectSwitch.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.ConnectSwitch.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.ConnectSwitch.Size = new System.Drawing.Size(100, 35);
            this.ConnectSwitch.Style = Sunny.UI.UIStyle.Custom;
            this.ConnectSwitch.TabIndex = 6;
            this.ConnectSwitch.Text = "连接";
            this.ConnectSwitch.Click += new System.EventHandler(this.ConnectSwitch_Click);
            // 
            // CloseConnect
            // 
            this.CloseConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseConnect.FillColor = System.Drawing.Color.Red;
            this.CloseConnect.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.CloseConnect.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.CloseConnect.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.CloseConnect.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CloseConnect.ImageInterval = 0;
            this.CloseConnect.Location = new System.Drawing.Point(775, 88);
            this.CloseConnect.MinimumSize = new System.Drawing.Size(1, 1);
            this.CloseConnect.Name = "CloseConnect";
            this.CloseConnect.Radius = 30;
            this.CloseConnect.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.CloseConnect.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(127)))), ((int)(((byte)(128)))));
            this.CloseConnect.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.CloseConnect.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(87)))), ((int)(((byte)(89)))));
            this.CloseConnect.Size = new System.Drawing.Size(100, 35);
            this.CloseConnect.Style = Sunny.UI.UIStyle.Custom;
            this.CloseConnect.Symbol = 61453;
            this.CloseConnect.TabIndex = 7;
            this.CloseConnect.Text = "断开连接";
            this.CloseConnect.Click += new System.EventHandler(this.CloseConnect_Click);
            // 
            // toselfMAC
            // 
            this.toselfMAC.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toselfMAC.Location = new System.Drawing.Point(7, 139);
            this.toselfMAC.Name = "toselfMAC";
            this.toselfMAC.Size = new System.Drawing.Size(150, 23);
            this.toselfMAC.TabIndex = 8;
            this.toselfMAC.Text = "本机MAC:";
            this.toselfMAC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // selfMACTextBox
            // 
            this.selfMACTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.selfMACTextBox.FillColor = System.Drawing.Color.White;
            this.selfMACTextBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.selfMACTextBox.Location = new System.Drawing.Point(143, 139);
            this.selfMACTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selfMACTextBox.Maximum = 2147483647D;
            this.selfMACTextBox.Minimum = -2147483648D;
            this.selfMACTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.selfMACTextBox.Name = "selfMACTextBox";
            this.selfMACTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.selfMACTextBox.Size = new System.Drawing.Size(170, 34);
            this.selfMACTextBox.TabIndex = 4;
            // 
            // AlterMAC
            // 
            this.AlterMAC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AlterMAC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AlterMAC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.AlterMAC.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.AlterMAC.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.AlterMAC.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.AlterMAC.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AlterMAC.ImageInterval = 0;
            this.AlterMAC.Location = new System.Drawing.Point(356, 139);
            this.AlterMAC.MinimumSize = new System.Drawing.Size(1, 1);
            this.AlterMAC.Name = "AlterMAC";
            this.AlterMAC.Radius = 30;
            this.AlterMAC.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(155)))), ((int)(((byte)(40)))));
            this.AlterMAC.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(174)))), ((int)(((byte)(86)))));
            this.AlterMAC.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.AlterMAC.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(137)))), ((int)(((byte)(43)))));
            this.AlterMAC.Size = new System.Drawing.Size(113, 35);
            this.AlterMAC.Style = Sunny.UI.UIStyle.Custom;
            this.AlterMAC.Symbol = 61459;
            this.AlterMAC.TabIndex = 9;
            this.AlterMAC.Text = "更改MAC";
            this.AlterMAC.Click += new System.EventHandler(this.AlterMAC_Click);
            // 
            // toswitchphysicalport
            // 
            this.toswitchphysicalport.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toswitchphysicalport.Location = new System.Drawing.Point(487, 139);
            this.toswitchphysicalport.Name = "toswitchphysicalport";
            this.toswitchphysicalport.Size = new System.Drawing.Size(170, 23);
            this.toswitchphysicalport.TabIndex = 10;
            this.toswitchphysicalport.Text = "连接交换机接口号:";
            this.toswitchphysicalport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // physicalportComboBox
            // 
            this.physicalportComboBox.FillColor = System.Drawing.Color.White;
            this.physicalportComboBox.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.physicalportComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.physicalportComboBox.Location = new System.Drawing.Point(664, 139);
            this.physicalportComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.physicalportComboBox.MinimumSize = new System.Drawing.Size(63, 0);
            this.physicalportComboBox.Name = "physicalportComboBox";
            this.physicalportComboBox.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.physicalportComboBox.Size = new System.Drawing.Size(150, 31);
            this.physicalportComboBox.TabIndex = 11;
            this.physicalportComboBox.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tosendinfo
            // 
            this.tosendinfo.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tosendinfo.Location = new System.Drawing.Point(7, 202);
            this.tosendinfo.Name = "tosendinfo";
            this.tosendinfo.Size = new System.Drawing.Size(150, 23);
            this.tosendinfo.TabIndex = 12;
            this.tosendinfo.Text = "发送的消息:";
            this.tosendinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toacceptinfo
            // 
            this.toacceptinfo.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toacceptinfo.Location = new System.Drawing.Point(12, 402);
            this.toacceptinfo.Name = "toacceptinfo";
            this.toacceptinfo.Size = new System.Drawing.Size(150, 23);
            this.toacceptinfo.TabIndex = 13;
            this.toacceptinfo.Text = "接收的消息:";
            this.toacceptinfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sendRichTextBox
            // 
            this.sendRichTextBox.AutoWordSelection = true;
            this.sendRichTextBox.FillColor = System.Drawing.Color.White;
            this.sendRichTextBox.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sendRichTextBox.Location = new System.Drawing.Point(13, 229);
            this.sendRichTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendRichTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.sendRichTextBox.Name = "sendRichTextBox";
            this.sendRichTextBox.Padding = new System.Windows.Forms.Padding(2);
            this.sendRichTextBox.Size = new System.Drawing.Size(801, 168);
            this.sendRichTextBox.Style = Sunny.UI.UIStyle.Custom;
            this.sendRichTextBox.TabIndex = 14;
            // 
            // acceptRichTextBox
            // 
            this.acceptRichTextBox.AutoWordSelection = true;
            this.acceptRichTextBox.FillColor = System.Drawing.Color.White;
            this.acceptRichTextBox.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.acceptRichTextBox.Location = new System.Drawing.Point(13, 430);
            this.acceptRichTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.acceptRichTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.acceptRichTextBox.Name = "acceptRichTextBox";
            this.acceptRichTextBox.Padding = new System.Windows.Forms.Padding(2);
            this.acceptRichTextBox.Size = new System.Drawing.Size(801, 229);
            this.acceptRichTextBox.Style = Sunny.UI.UIStyle.Custom;
            this.acceptRichTextBox.TabIndex = 15;
            // 
            // toacceptMAC
            // 
            this.toacceptMAC.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toacceptMAC.Location = new System.Drawing.Point(12, 664);
            this.toacceptMAC.Name = "toacceptMAC";
            this.toacceptMAC.Size = new System.Drawing.Size(150, 23);
            this.toacceptMAC.TabIndex = 16;
            this.toacceptMAC.Text = "接收端MAC:";
            this.toacceptMAC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tosendinginfo
            // 
            this.tosendinginfo.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tosendinginfo.Location = new System.Drawing.Point(12, 710);
            this.tosendinginfo.Name = "tosendinginfo";
            this.tosendinginfo.Size = new System.Drawing.Size(150, 23);
            this.tosendinginfo.TabIndex = 17;
            this.tosendinginfo.Text = "发送消息框:";
            this.tosendinginfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ConfirmAcceptMAC
            // 
            this.ConfirmAcceptMAC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ConfirmAcceptMAC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmAcceptMAC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ConfirmAcceptMAC.FillHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
            this.ConfirmAcceptMAC.FillPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.ConfirmAcceptMAC.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.ConfirmAcceptMAC.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConfirmAcceptMAC.Location = new System.Drawing.Point(378, 663);
            this.ConfirmAcceptMAC.MinimumSize = new System.Drawing.Size(1, 1);
            this.ConfirmAcceptMAC.Name = "ConfirmAcceptMAC";
            this.ConfirmAcceptMAC.Radius = 30;
            this.ConfirmAcceptMAC.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(190)))), ((int)(((byte)(40)))));
            this.ConfirmAcceptMAC.RectHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(202)))), ((int)(((byte)(81)))));
            this.ConfirmAcceptMAC.RectPressColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.ConfirmAcceptMAC.RectSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(168)))), ((int)(((byte)(35)))));
            this.ConfirmAcceptMAC.Size = new System.Drawing.Size(100, 35);
            this.ConfirmAcceptMAC.Style = Sunny.UI.UIStyle.Custom;
            this.ConfirmAcceptMAC.Symbol = 61961;
            this.ConfirmAcceptMAC.TabIndex = 18;
            this.ConfirmAcceptMAC.Text = "确认";
            this.ConfirmAcceptMAC.Click += new System.EventHandler(this.ConfirmAcceptMAC_Click);
            // 
            // SendInfo
            // 
            this.SendInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SendInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendInfo.FillColor = System.Drawing.Color.Teal;
            this.SendInfo.FillHoverColor = System.Drawing.Color.Teal;
            this.SendInfo.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SendInfo.Location = new System.Drawing.Point(597, 710);
            this.SendInfo.MinimumSize = new System.Drawing.Size(1, 1);
            this.SendInfo.Name = "SendInfo";
            this.SendInfo.Radius = 30;
            this.SendInfo.Size = new System.Drawing.Size(100, 35);
            this.SendInfo.Style = Sunny.UI.UIStyle.Custom;
            this.SendInfo.Symbol = 61912;
            this.SendInfo.TabIndex = 19;
            this.SendInfo.Text = "发送";
            this.SendInfo.Click += new System.EventHandler(this.SendInfo_Click);
            // 
            // acceptMACTextbox
            // 
            this.acceptMACTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.acceptMACTextbox.FillColor = System.Drawing.Color.White;
            this.acceptMACTextbox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.acceptMACTextbox.Location = new System.Drawing.Point(164, 664);
            this.acceptMACTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.acceptMACTextbox.Maximum = 2147483647D;
            this.acceptMACTextbox.Minimum = -2147483648D;
            this.acceptMACTextbox.MinimumSize = new System.Drawing.Size(1, 1);
            this.acceptMACTextbox.Name = "acceptMACTextbox";
            this.acceptMACTextbox.Padding = new System.Windows.Forms.Padding(5);
            this.acceptMACTextbox.Size = new System.Drawing.Size(170, 34);
            this.acceptMACTextbox.TabIndex = 4;
            this.acceptMACTextbox.TextChanged += new System.EventHandler(this.acceptMACTextbox_TextChanged);
            // 
            // sendinginfoTextBox
            // 
            this.sendinginfoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sendinginfoTextBox.FillColor = System.Drawing.Color.White;
            this.sendinginfoTextBox.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.sendinginfoTextBox.Location = new System.Drawing.Point(164, 710);
            this.sendinginfoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendinginfoTextBox.Maximum = 2147483647D;
            this.sendinginfoTextBox.Minimum = -2147483648D;
            this.sendinginfoTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.sendinginfoTextBox.Name = "sendinginfoTextBox";
            this.sendinginfoTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.sendinginfoTextBox.Size = new System.Drawing.Size(426, 34);
            this.sendinginfoTextBox.TabIndex = 5;
            // 
            // selfMACerrorProvider
            // 
            this.selfMACerrorProvider.ContainerControl = this;
            this.selfMACerrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("selfMACerrorProvider.Icon")));
            // 
            // acceptMACerrorProvider
            // 
            this.acceptMACerrorProvider.ContainerControl = this;
            this.acceptMACerrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("acceptMACerrorProvider.Icon")));
            // 
            // mySocketClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 789);
            this.Controls.Add(this.sendinginfoTextBox);
            this.Controls.Add(this.acceptMACTextbox);
            this.Controls.Add(this.SendInfo);
            this.Controls.Add(this.ConfirmAcceptMAC);
            this.Controls.Add(this.tosendinginfo);
            this.Controls.Add(this.toacceptMAC);
            this.Controls.Add(this.acceptRichTextBox);
            this.Controls.Add(this.sendRichTextBox);
            this.Controls.Add(this.toacceptinfo);
            this.Controls.Add(this.tosendinfo);
            this.Controls.Add(this.physicalportComboBox);
            this.Controls.Add(this.toswitchphysicalport);
            this.Controls.Add(this.AlterMAC);
            this.Controls.Add(this.selfMACTextBox);
            this.Controls.Add(this.toselfMAC);
            this.Controls.Add(this.CloseConnect);
            this.Controls.Add(this.ConnectSwitch);
            this.Controls.Add(this.toswitchport);
            this.Controls.Add(this.switchPortTextBox);
            this.Controls.Add(this.switchIPTextBox);
            this.Controls.Add(this.toswitchIP);
            this.Controls.Add(this.welcomewords);
            this.Controls.Add(this.userAvatar);
            this.Name = "mySocketClient";
            this.Text = "socketClient";
            ((System.ComponentModel.ISupportInitialize)(this.selfMACerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptMACerrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIAvatar userAvatar;
        private Sunny.UI.UIScrollingText welcomewords;
        private Sunny.UI.UILabel toswitchIP;
        private Sunny.UI.UITextBox switchIPTextBox;
        private Sunny.UI.UITextBox switchPortTextBox;
        private Sunny.UI.UILabel toswitchport;
        private Sunny.UI.UISymbolButton ConnectSwitch;
        private Sunny.UI.UISymbolButton CloseConnect;
        private Sunny.UI.UILabel toselfMAC;
        private Sunny.UI.UITextBox selfMACTextBox;
        private Sunny.UI.UISymbolButton AlterMAC;
        private Sunny.UI.UILabel toswitchphysicalport;
        private Sunny.UI.UIComboBox physicalportComboBox;
        private Sunny.UI.UILabel tosendinfo;
        private Sunny.UI.UILabel toacceptinfo;
        private Sunny.UI.UIRichTextBox sendRichTextBox;
        private Sunny.UI.UIRichTextBox acceptRichTextBox;
        private Sunny.UI.UILabel toacceptMAC;
        private Sunny.UI.UILabel tosendinginfo;
        private Sunny.UI.UISymbolButton ConfirmAcceptMAC;
        private Sunny.UI.UISymbolButton SendInfo;
        private Sunny.UI.UITextBox acceptMACTextbox;
        private Sunny.UI.UITextBox sendinginfoTextBox;
        private System.Windows.Forms.ErrorProvider selfMACerrorProvider;
        private System.Windows.Forms.ErrorProvider acceptMACerrorProvider;
    }
}

