namespace NEDC
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.ttpDetailMessage = new System.Windows.Forms.ToolTip(this.components);
            this.cbxSendNewLine = new System.Windows.Forms.CheckBox();
            this.pnl1 = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出实验数据OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选项OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.配置串口属性SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开串口OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭串口CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.控制CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.测试连接TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.启动设备SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.停止设备TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上传配置文件PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开配置文件OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开始上传UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.高压电池BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开高压电池OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭高压电池CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl6 = new System.Windows.Forms.Panel();
            this.llbSerial = new System.Windows.Forms.LinkLabel();
            this.lbSplite5 = new System.Windows.Forms.Label();
            this.lbRx = new System.Windows.Forms.Label();
            this.lbSplite4 = new System.Windows.Forms.Label();
            this.lbTx = new System.Windows.Forms.Label();
            this.lbSplite3 = new System.Windows.Forms.Label();
            this.pbxRun = new System.Windows.Forms.PictureBox();
            this.lbRun = new System.Windows.Forms.Label();
            this.lbSplite2 = new System.Windows.Forms.Label();
            this.pbxInit = new System.Windows.Forms.PictureBox();
            this.lbInit = new System.Windows.Forms.Label();
            this.lbSplite1 = new System.Windows.Forms.Label();
            this.pbxSerial = new System.Windows.Forms.PictureBox();
            this.lbSerial = new System.Windows.Forms.Label();
            this.pnl8 = new System.Windows.Forms.Panel();
            this.pnl12 = new System.Windows.Forms.Panel();
            this.pgbMain = new System.Windows.Forms.ProgressBar();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbMsg = new System.Windows.Forms.Label();
            this.lbPercent = new System.Windows.Forms.Label();
            this.llbCancel = new System.Windows.Forms.LinkLabel();
            this.pnl11 = new System.Windows.Forms.Panel();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.pnl10 = new System.Windows.Forms.Panel();
            this.TimerTx = new System.Windows.Forms.Timer(this.components);
            this.TimerRx = new System.Windows.Forms.Timer(this.components);
            this.TimerSys = new System.Windows.Forms.Timer(this.components);
            this.WaitFeedback = new System.ComponentModel.BackgroundWorker();
            this.UploadCommands = new System.ComponentModel.BackgroundWorker();
            this.pnl2 = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl18 = new System.Windows.Forms.Panel();
            this.pnl7 = new System.Windows.Forms.Panel();
            this.pnlMsg = new System.Windows.Forms.Panel();
            this.tbxSend = new System.Windows.Forms.TextBox();
            this.pnl14 = new System.Windows.Forms.Panel();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.gpbMsg = new System.Windows.Forms.GroupBox();
            this.tbxMsg = new System.Windows.Forms.TextBox();
            this.gpbRx = new System.Windows.Forms.GroupBox();
            this.tbxRx = new System.Windows.Forms.TextBox();
            this.gpbTx = new System.Windows.Forms.GroupBox();
            this.tbxTx = new System.Windows.Forms.TextBox();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.llbClearTx = new System.Windows.Forms.LinkLabel();
            this.llbClearRx = new System.Windows.Forms.LinkLabel();
            this.llbClearMsg = new System.Windows.Forms.LinkLabel();
            this.lbSplite7 = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.pnlUpload = new System.Windows.Forms.Panel();
            this.dgvUploadData = new System.Windows.Forms.DataGridView();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.crtUpload = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnl5 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbSplit8 = new System.Windows.Forms.Label();
            this.btnClearUpload = new System.Windows.Forms.Button();
            this.lbSplit6 = new System.Windows.Forms.Label();
            this.btnStartUpload = new System.Windows.Forms.Button();
            this.btnBigImage = new System.Windows.Forms.Button();
            this.tbxFilepath = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnl15 = new System.Windows.Forms.Panel();
            this.lbUpload = new System.Windows.Forms.Label();
            this.pnlDownload = new System.Windows.Forms.Panel();
            this.dgvDownloadData = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTotalCount = new System.Windows.Forms.Label();
            this.btnUpdateDownload = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnClearShow = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbShowRowsCount = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pnl16 = new System.Windows.Forms.Panel();
            this.lbDownload = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.display1 = new NEDC.Display();
            this.pnl1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.pnl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSerial)).BeginInit();
            this.pnl8.SuspendLayout();
            this.pnl12.SuspendLayout();
            this.pnl11.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlMsg.SuspendLayout();
            this.pnl14.SuspendLayout();
            this.gpbMsg.SuspendLayout();
            this.gpbRx.SuspendLayout();
            this.gpbTx.SuspendLayout();
            this.pnl3.SuspendLayout();
            this.pnlUpload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUploadData)).BeginInit();
            this.pnl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtUpload)).BeginInit();
            this.pnl5.SuspendLayout();
            this.pnl15.SuspendLayout();
            this.pnlDownload.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDownloadData)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnl16.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            // 
            // cbxSendNewLine
            // 
            this.cbxSendNewLine.AutoSize = true;
            this.cbxSendNewLine.Checked = true;
            this.cbxSendNewLine.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxSendNewLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxSendNewLine.Location = new System.Drawing.Point(0, 0);
            this.cbxSendNewLine.Name = "cbxSendNewLine";
            this.cbxSendNewLine.Size = new System.Drawing.Size(174, 25);
            this.cbxSendNewLine.TabIndex = 1;
            this.cbxSendNewLine.TabStop = false;
            this.cbxSendNewLine.Text = "发送新行";
            this.ttpDetailMessage.SetToolTip(this.cbxSendNewLine, "发送时自动添加换行符");
            this.cbxSendNewLine.UseVisualStyleBackColor = true;
            // 
            // pnl1
            // 
            this.pnl1.Controls.Add(this.menuStrip);
            this.pnl1.Controls.Add(this.pnl6);
            this.pnl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl1.Location = new System.Drawing.Point(0, 0);
            this.pnl1.Name = "pnl1";
            this.pnl1.Size = new System.Drawing.Size(1354, 25);
            this.pnl1.TabIndex = 21;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.选项OToolStripMenuItem,
            this.控制CToolStripMenuItem,
            this.上传配置文件PToolStripMenuItem,
            this.高压电池BToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(688, 25);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出实验数据OToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 导出实验数据OToolStripMenuItem
            // 
            this.导出实验数据OToolStripMenuItem.Name = "导出实验数据OToolStripMenuItem";
            this.导出实验数据OToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.导出实验数据OToolStripMenuItem.Text = "导出实验数据(&O)";
            this.导出实验数据OToolStripMenuItem.Click += new System.EventHandler(this.导出实验数据OToolStripMenuItem_Click);
            // 
            // 选项OToolStripMenuItem
            // 
            this.选项OToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.配置串口属性SToolStripMenuItem,
            this.打开串口OToolStripMenuItem,
            this.关闭串口CToolStripMenuItem});
            this.选项OToolStripMenuItem.Name = "选项OToolStripMenuItem";
            this.选项OToolStripMenuItem.Size = new System.Drawing.Size(62, 21);
            this.选项OToolStripMenuItem.Text = "选项(&O)";
            // 
            // 配置串口属性SToolStripMenuItem
            // 
            this.配置串口属性SToolStripMenuItem.Name = "配置串口属性SToolStripMenuItem";
            this.配置串口属性SToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.配置串口属性SToolStripMenuItem.Text = "配置串口属性(&S)";
            this.配置串口属性SToolStripMenuItem.Click += new System.EventHandler(this.配置串口属性SToolStripMenuItem_Click);
            // 
            // 打开串口OToolStripMenuItem
            // 
            this.打开串口OToolStripMenuItem.Name = "打开串口OToolStripMenuItem";
            this.打开串口OToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.打开串口OToolStripMenuItem.Text = "打开串口(&O)";
            this.打开串口OToolStripMenuItem.Click += new System.EventHandler(this.打开串口OToolStripMenuItem_Click);
            // 
            // 关闭串口CToolStripMenuItem
            // 
            this.关闭串口CToolStripMenuItem.Enabled = false;
            this.关闭串口CToolStripMenuItem.Name = "关闭串口CToolStripMenuItem";
            this.关闭串口CToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.关闭串口CToolStripMenuItem.Text = "关闭串口(&C)";
            this.关闭串口CToolStripMenuItem.Click += new System.EventHandler(this.关闭串口CToolStripMenuItem_Click);
            // 
            // 控制CToolStripMenuItem
            // 
            this.控制CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.测试连接TToolStripMenuItem,
            this.启动设备SToolStripMenuItem,
            this.停止设备TToolStripMenuItem});
            this.控制CToolStripMenuItem.Name = "控制CToolStripMenuItem";
            this.控制CToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.控制CToolStripMenuItem.Text = "控制(&C)";
            // 
            // 测试连接TToolStripMenuItem
            // 
            this.测试连接TToolStripMenuItem.Name = "测试连接TToolStripMenuItem";
            this.测试连接TToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.测试连接TToolStripMenuItem.Text = "测试连接(&T)";
            this.测试连接TToolStripMenuItem.Click += new System.EventHandler(this.测试连接TToolStripMenuItem_Click);
            // 
            // 启动设备SToolStripMenuItem
            // 
            this.启动设备SToolStripMenuItem.Name = "启动设备SToolStripMenuItem";
            this.启动设备SToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.启动设备SToolStripMenuItem.Text = "启动设备(&S)";
            this.启动设备SToolStripMenuItem.Click += new System.EventHandler(this.启动设备SToolStripMenuItem_Click);
            // 
            // 停止设备TToolStripMenuItem
            // 
            this.停止设备TToolStripMenuItem.Name = "停止设备TToolStripMenuItem";
            this.停止设备TToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.停止设备TToolStripMenuItem.Text = "停止设备(&T)";
            this.停止设备TToolStripMenuItem.Click += new System.EventHandler(this.停止设备TToolStripMenuItem_Click);
            // 
            // 上传配置文件PToolStripMenuItem
            // 
            this.上传配置文件PToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开配置文件OToolStripMenuItem,
            this.开始上传UToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem2,
            this.toolStripTextBox1});
            this.上传配置文件PToolStripMenuItem.Name = "上传配置文件PToolStripMenuItem";
            this.上传配置文件PToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.上传配置文件PToolStripMenuItem.Text = "配置文件(&P)";
            // 
            // 打开配置文件OToolStripMenuItem
            // 
            this.打开配置文件OToolStripMenuItem.Name = "打开配置文件OToolStripMenuItem";
            this.打开配置文件OToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.打开配置文件OToolStripMenuItem.Text = "打开配置文件(&O)";
            this.打开配置文件OToolStripMenuItem.Click += new System.EventHandler(this.打开配置文件OToolStripMenuItem_Click);
            // 
            // 开始上传UToolStripMenuItem
            // 
            this.开始上传UToolStripMenuItem.Name = "开始上传UToolStripMenuItem";
            this.开始上传UToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.开始上传UToolStripMenuItem.Text = "开始上传(&U)";
            this.开始上传UToolStripMenuItem.Click += new System.EventHandler(this.开始上传UToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(170, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(173, 22);
            this.toolStripMenuItem2.Text = "上传时间间隔(ms)";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "100";
            // 
            // 高压电池BToolStripMenuItem
            // 
            this.高压电池BToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开高压电池OToolStripMenuItem,
            this.关闭高压电池CToolStripMenuItem});
            this.高压电池BToolStripMenuItem.Name = "高压电池BToolStripMenuItem";
            this.高压电池BToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.高压电池BToolStripMenuItem.Text = "高压电池(&B)";
            // 
            // 打开高压电池OToolStripMenuItem
            // 
            this.打开高压电池OToolStripMenuItem.Name = "打开高压电池OToolStripMenuItem";
            this.打开高压电池OToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.打开高压电池OToolStripMenuItem.Text = "打开高压电池(&O)";
            this.打开高压电池OToolStripMenuItem.Click += new System.EventHandler(this.打开高压电池OToolStripMenuItem_Click);
            // 
            // 关闭高压电池CToolStripMenuItem
            // 
            this.关闭高压电池CToolStripMenuItem.Name = "关闭高压电池CToolStripMenuItem";
            this.关闭高压电池CToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.关闭高压电池CToolStripMenuItem.Text = "关闭高压电池(&C)";
            this.关闭高压电池CToolStripMenuItem.Click += new System.EventHandler(this.关闭高压电池CToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.Blue;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(166, 21);
            this.toolStripMenuItem1.Text = "↑：0.00KB/s  ↓：0.00KB/s";
            // 
            // pnl6
            // 
            this.pnl6.BackColor = System.Drawing.SystemColors.Control;
            this.pnl6.Controls.Add(this.llbSerial);
            this.pnl6.Controls.Add(this.lbSplite5);
            this.pnl6.Controls.Add(this.lbRx);
            this.pnl6.Controls.Add(this.lbSplite4);
            this.pnl6.Controls.Add(this.lbTx);
            this.pnl6.Controls.Add(this.lbSplite3);
            this.pnl6.Controls.Add(this.pbxRun);
            this.pnl6.Controls.Add(this.lbRun);
            this.pnl6.Controls.Add(this.lbSplite2);
            this.pnl6.Controls.Add(this.pbxInit);
            this.pnl6.Controls.Add(this.lbInit);
            this.pnl6.Controls.Add(this.lbSplite1);
            this.pnl6.Controls.Add(this.pbxSerial);
            this.pnl6.Controls.Add(this.lbSerial);
            this.pnl6.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl6.Location = new System.Drawing.Point(688, 0);
            this.pnl6.Name = "pnl6";
            this.pnl6.Size = new System.Drawing.Size(666, 25);
            this.pnl6.TabIndex = 0;
            // 
            // llbSerial
            // 
            this.llbSerial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.llbSerial.Location = new System.Drawing.Point(462, 0);
            this.llbSerial.Name = "llbSerial";
            this.llbSerial.Size = new System.Drawing.Size(204, 25);
            this.llbSerial.TabIndex = 39;
            this.llbSerial.TabStop = true;
            this.llbSerial.Text = "串口号：COM1；波特率：115200";
            this.llbSerial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llbSerial.VisitedLinkColor = System.Drawing.Color.Blue;
            this.llbSerial.Click += new System.EventHandler(this.配置串口属性SToolStripMenuItem_Click);
            // 
            // lbSplite5
            // 
            this.lbSplite5.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSplite5.Location = new System.Drawing.Point(454, 0);
            this.lbSplite5.Name = "lbSplite5";
            this.lbSplite5.Size = new System.Drawing.Size(8, 25);
            this.lbSplite5.TabIndex = 38;
            this.lbSplite5.Text = "|";
            this.lbSplite5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRx
            // 
            this.lbRx.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbRx.Location = new System.Drawing.Point(377, 0);
            this.lbRx.Name = "lbRx";
            this.lbRx.Size = new System.Drawing.Size(77, 25);
            this.lbRx.TabIndex = 37;
            this.lbRx.Text = "RX:0";
            this.lbRx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSplite4
            // 
            this.lbSplite4.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSplite4.Location = new System.Drawing.Point(369, 0);
            this.lbSplite4.Name = "lbSplite4";
            this.lbSplite4.Size = new System.Drawing.Size(8, 25);
            this.lbSplite4.TabIndex = 36;
            this.lbSplite4.Text = "|";
            this.lbSplite4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTx
            // 
            this.lbTx.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTx.Location = new System.Drawing.Point(292, 0);
            this.lbTx.Name = "lbTx";
            this.lbTx.Size = new System.Drawing.Size(77, 25);
            this.lbTx.TabIndex = 35;
            this.lbTx.Text = "TX:0";
            this.lbTx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSplite3
            // 
            this.lbSplite3.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSplite3.Location = new System.Drawing.Point(284, 0);
            this.lbSplite3.Name = "lbSplite3";
            this.lbSplite3.Size = new System.Drawing.Size(8, 25);
            this.lbSplite3.TabIndex = 34;
            this.lbSplite3.Text = "|";
            this.lbSplite3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxRun
            // 
            this.pbxRun.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxRun.Location = new System.Drawing.Point(259, 0);
            this.pbxRun.Name = "pbxRun";
            this.pbxRun.Size = new System.Drawing.Size(25, 25);
            this.pbxRun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxRun.TabIndex = 33;
            this.pbxRun.TabStop = false;
            this.pbxRun.Tag = "-1";
            // 
            // lbRun
            // 
            this.lbRun.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbRun.Location = new System.Drawing.Point(199, 0);
            this.lbRun.Name = "lbRun";
            this.lbRun.Size = new System.Drawing.Size(60, 25);
            this.lbRun.TabIndex = 32;
            this.lbRun.Text = "运行状态";
            this.lbRun.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSplite2
            // 
            this.lbSplite2.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSplite2.Location = new System.Drawing.Point(191, 0);
            this.lbSplite2.Name = "lbSplite2";
            this.lbSplite2.Size = new System.Drawing.Size(8, 25);
            this.lbSplite2.TabIndex = 31;
            this.lbSplite2.Text = "|";
            this.lbSplite2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxInit
            // 
            this.pbxInit.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxInit.Location = new System.Drawing.Point(166, 0);
            this.pbxInit.Name = "pbxInit";
            this.pbxInit.Size = new System.Drawing.Size(25, 25);
            this.pbxInit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxInit.TabIndex = 30;
            this.pbxInit.TabStop = false;
            this.pbxInit.Tag = "-1";
            // 
            // lbInit
            // 
            this.lbInit.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbInit.Location = new System.Drawing.Point(93, 0);
            this.lbInit.Name = "lbInit";
            this.lbInit.Size = new System.Drawing.Size(73, 25);
            this.lbInit.TabIndex = 29;
            this.lbInit.Text = "初始化状态";
            this.lbInit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbSplite1
            // 
            this.lbSplite1.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSplite1.Location = new System.Drawing.Point(85, 0);
            this.lbSplite1.Name = "lbSplite1";
            this.lbSplite1.Size = new System.Drawing.Size(8, 25);
            this.lbSplite1.TabIndex = 28;
            this.lbSplite1.Text = "|";
            this.lbSplite1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbxSerial
            // 
            this.pbxSerial.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxSerial.Location = new System.Drawing.Point(60, 0);
            this.pbxSerial.Name = "pbxSerial";
            this.pbxSerial.Size = new System.Drawing.Size(25, 25);
            this.pbxSerial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxSerial.TabIndex = 27;
            this.pbxSerial.TabStop = false;
            this.pbxSerial.Tag = "-1";
            // 
            // lbSerial
            // 
            this.lbSerial.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSerial.Location = new System.Drawing.Point(0, 0);
            this.lbSerial.Name = "lbSerial";
            this.lbSerial.Size = new System.Drawing.Size(60, 25);
            this.lbSerial.TabIndex = 26;
            this.lbSerial.Text = "串口状态";
            this.lbSerial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnl8
            // 
            this.pnl8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl8.Controls.Add(this.pnl12);
            this.pnl8.Controls.Add(this.lbMsg);
            this.pnl8.Controls.Add(this.lbPercent);
            this.pnl8.Controls.Add(this.llbCancel);
            this.pnl8.Controls.Add(this.pnl11);
            this.pnl8.Controls.Add(this.pnl10);
            this.pnl8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl8.Location = new System.Drawing.Point(0, 721);
            this.pnl8.Name = "pnl8";
            this.pnl8.Size = new System.Drawing.Size(1354, 25);
            this.pnl8.TabIndex = 22;
            // 
            // pnl12
            // 
            this.pnl12.Controls.Add(this.pgbMain);
            this.pnl12.Controls.Add(this.panel6);
            this.pnl12.Controls.Add(this.panel5);
            this.pnl12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl12.Location = new System.Drawing.Point(660, 0);
            this.pnl12.Name = "pnl12";
            this.pnl12.Size = new System.Drawing.Size(563, 23);
            this.pnl12.TabIndex = 19;
            // 
            // pgbMain
            // 
            this.pgbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgbMain.Location = new System.Drawing.Point(0, 5);
            this.pgbMain.Name = "pgbMain";
            this.pgbMain.Size = new System.Drawing.Size(563, 13);
            this.pgbMain.TabIndex = 3;
            this.pgbMain.Value = 100;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 18);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(563, 5);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(563, 5);
            this.panel5.TabIndex = 0;
            // 
            // lbMsg
            // 
            this.lbMsg.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbMsg.ForeColor = System.Drawing.Color.Red;
            this.lbMsg.Location = new System.Drawing.Point(208, 0);
            this.lbMsg.Name = "lbMsg";
            this.lbMsg.Size = new System.Drawing.Size(452, 23);
            this.lbMsg.TabIndex = 18;
            this.lbMsg.Text = "系统正在运行...";
            this.lbMsg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMsg.TextChanged += new System.EventHandler(this.lbMsg_TextChanged);
            // 
            // lbPercent
            // 
            this.lbPercent.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbPercent.Location = new System.Drawing.Point(1223, 0);
            this.lbPercent.Name = "lbPercent";
            this.lbPercent.Size = new System.Drawing.Size(59, 23);
            this.lbPercent.TabIndex = 16;
            this.lbPercent.Text = "100%";
            this.lbPercent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // llbCancel
            // 
            this.llbCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.llbCancel.Enabled = false;
            this.llbCancel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.llbCancel.Location = new System.Drawing.Point(1282, 0);
            this.llbCancel.Name = "llbCancel";
            this.llbCancel.Size = new System.Drawing.Size(60, 23);
            this.llbCancel.TabIndex = 15;
            this.llbCancel.TabStop = true;
            this.llbCancel.Text = "取消";
            this.llbCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llbCancel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.llbCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbCancel_LinkClicked);
            // 
            // pnl11
            // 
            this.pnl11.Controls.Add(this.lbAuthor);
            this.pnl11.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl11.Location = new System.Drawing.Point(0, 0);
            this.pnl11.Name = "pnl11";
            this.pnl11.Size = new System.Drawing.Size(208, 23);
            this.pnl11.TabIndex = 2;
            // 
            // lbAuthor
            // 
            this.lbAuthor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAuthor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAuthor.ForeColor = System.Drawing.Color.Blue;
            this.lbAuthor.Location = new System.Drawing.Point(0, 0);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(208, 23);
            this.lbAuthor.TabIndex = 0;
            this.lbAuthor.Text = "Author：zzudongxiang@163.com";
            this.lbAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl10
            // 
            this.pnl10.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl10.Location = new System.Drawing.Point(1342, 0);
            this.pnl10.Name = "pnl10";
            this.pnl10.Size = new System.Drawing.Size(10, 23);
            this.pnl10.TabIndex = 1;
            // 
            // TimerTx
            // 
            this.TimerTx.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TimerRx
            // 
            this.TimerRx.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TimerSys
            // 
            this.TimerSys.Enabled = true;
            this.TimerSys.Interval = 500;
            this.TimerSys.Tick += new System.EventHandler(this.TimerSys_Tick);
            // 
            // WaitFeedback
            // 
            this.WaitFeedback.WorkerReportsProgress = true;
            this.WaitFeedback.WorkerSupportsCancellation = true;
            this.WaitFeedback.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WaitFeedback_DoWork);
            this.WaitFeedback.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.WaitFeedback_ProgressChanged);
            this.WaitFeedback.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.WaitFeedback_RunWorkerCompleted);
            // 
            // UploadCommands
            // 
            this.UploadCommands.WorkerReportsProgress = true;
            this.UploadCommands.WorkerSupportsCancellation = true;
            this.UploadCommands.DoWork += new System.ComponentModel.DoWorkEventHandler(this.UploadCommands_DoWork);
            this.UploadCommands.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.WaitFeedback_ProgressChanged);
            this.UploadCommands.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.WaitFeedback_RunWorkerCompleted);
            // 
            // pnl2
            // 
            this.pnl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl2.Location = new System.Drawing.Point(0, 691);
            this.pnl2.Name = "pnl2";
            this.pnl2.Size = new System.Drawing.Size(1354, 5);
            this.pnl2.TabIndex = 22;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.display1);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Controls.Add(this.pnl18);
            this.pnlMain.Controls.Add(this.pnl7);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.pnlMain.Size = new System.Drawing.Size(1354, 691);
            this.pnlMain.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1331, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(23, 656);
            this.panel1.TabIndex = 2;
            // 
            // pnl18
            // 
            this.pnl18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl18.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl18.Location = new System.Drawing.Point(0, 0);
            this.pnl18.Name = "pnl18";
            this.pnl18.Size = new System.Drawing.Size(23, 656);
            this.pnl18.TabIndex = 1;
            // 
            // pnl7
            // 
            this.pnl7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl7.Location = new System.Drawing.Point(0, 656);
            this.pnl7.Name = "pnl7";
            this.pnl7.Size = new System.Drawing.Size(1354, 20);
            this.pnl7.TabIndex = 0;
            // 
            // pnlMsg
            // 
            this.pnlMsg.Controls.Add(this.tbxSend);
            this.pnlMsg.Controls.Add(this.pnl14);
            this.pnlMsg.Controls.Add(this.gpbMsg);
            this.pnlMsg.Controls.Add(this.gpbRx);
            this.pnlMsg.Controls.Add(this.gpbTx);
            this.pnlMsg.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pnlMsg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMsg.Location = new System.Drawing.Point(0, 521);
            this.pnlMsg.Name = "pnlMsg";
            this.pnlMsg.Size = new System.Drawing.Size(1354, 170);
            this.pnlMsg.TabIndex = 24;
            // 
            // tbxSend
            // 
            this.tbxSend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxSend.Location = new System.Drawing.Point(1180, 0);
            this.tbxSend.Multiline = true;
            this.tbxSend.Name = "tbxSend";
            this.tbxSend.Size = new System.Drawing.Size(174, 145);
            this.tbxSend.TabIndex = 4;
            // 
            // pnl14
            // 
            this.pnl14.Controls.Add(this.btnSend);
            this.pnl14.Controls.Add(this.panel7);
            this.pnl14.Controls.Add(this.cbxSendNewLine);
            this.pnl14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl14.Location = new System.Drawing.Point(1180, 145);
            this.pnl14.Name = "pnl14";
            this.pnl14.Size = new System.Drawing.Size(174, 25);
            this.pnl14.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSend.Location = new System.Drawing.Point(47, 0);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(108, 25);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(155, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(19, 25);
            this.panel7.TabIndex = 2;
            // 
            // gpbMsg
            // 
            this.gpbMsg.Controls.Add(this.tbxMsg);
            this.gpbMsg.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpbMsg.Location = new System.Drawing.Point(800, 0);
            this.gpbMsg.Name = "gpbMsg";
            this.gpbMsg.Size = new System.Drawing.Size(380, 170);
            this.gpbMsg.TabIndex = 2;
            this.gpbMsg.TabStop = false;
            this.gpbMsg.Text = "系统日志";
            // 
            // tbxMsg
            // 
            this.tbxMsg.BackColor = System.Drawing.Color.Black;
            this.tbxMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxMsg.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbxMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxMsg.ForeColor = System.Drawing.Color.Yellow;
            this.tbxMsg.Location = new System.Drawing.Point(3, 17);
            this.tbxMsg.Multiline = true;
            this.tbxMsg.Name = "tbxMsg";
            this.tbxMsg.ReadOnly = true;
            this.tbxMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxMsg.Size = new System.Drawing.Size(374, 150);
            this.tbxMsg.TabIndex = 1;
            this.tbxMsg.TabStop = false;
            this.tbxMsg.WordWrap = false;
            // 
            // gpbRx
            // 
            this.gpbRx.Controls.Add(this.tbxRx);
            this.gpbRx.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpbRx.Location = new System.Drawing.Point(400, 0);
            this.gpbRx.Name = "gpbRx";
            this.gpbRx.Size = new System.Drawing.Size(400, 170);
            this.gpbRx.TabIndex = 1;
            this.gpbRx.TabStop = false;
            this.gpbRx.Text = "接收的消息";
            // 
            // tbxRx
            // 
            this.tbxRx.BackColor = System.Drawing.Color.Black;
            this.tbxRx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxRx.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbxRx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxRx.ForeColor = System.Drawing.Color.Lime;
            this.tbxRx.Location = new System.Drawing.Point(3, 17);
            this.tbxRx.Multiline = true;
            this.tbxRx.Name = "tbxRx";
            this.tbxRx.ReadOnly = true;
            this.tbxRx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxRx.Size = new System.Drawing.Size(394, 150);
            this.tbxRx.TabIndex = 1;
            this.tbxRx.TabStop = false;
            this.tbxRx.WordWrap = false;
            // 
            // gpbTx
            // 
            this.gpbTx.Controls.Add(this.tbxTx);
            this.gpbTx.Dock = System.Windows.Forms.DockStyle.Left;
            this.gpbTx.Location = new System.Drawing.Point(0, 0);
            this.gpbTx.Name = "gpbTx";
            this.gpbTx.Size = new System.Drawing.Size(400, 170);
            this.gpbTx.TabIndex = 0;
            this.gpbTx.TabStop = false;
            this.gpbTx.Text = "发送的消息";
            // 
            // tbxTx
            // 
            this.tbxTx.BackColor = System.Drawing.Color.Black;
            this.tbxTx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxTx.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbxTx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxTx.ForeColor = System.Drawing.Color.White;
            this.tbxTx.Location = new System.Drawing.Point(3, 17);
            this.tbxTx.Multiline = true;
            this.tbxTx.Name = "tbxTx";
            this.tbxTx.ReadOnly = true;
            this.tbxTx.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxTx.Size = new System.Drawing.Size(394, 150);
            this.tbxTx.TabIndex = 0;
            this.tbxTx.TabStop = false;
            this.tbxTx.WordWrap = false;
            // 
            // splitter3
            // 
            this.splitter3.BackColor = System.Drawing.SystemColors.Control;
            this.splitter3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitter3.Location = new System.Drawing.Point(0, 516);
            this.splitter3.MinSize = 100;
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(1354, 5);
            this.splitter3.TabIndex = 33;
            this.splitter3.TabStop = false;
            this.splitter3.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter_SplitterMoved);
            // 
            // pnl3
            // 
            this.pnl3.Controls.Add(this.llbClearTx);
            this.pnl3.Controls.Add(this.llbClearRx);
            this.pnl3.Controls.Add(this.llbClearMsg);
            this.pnl3.Controls.Add(this.lbSplite7);
            this.pnl3.Controls.Add(this.lbMessage);
            this.pnl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl3.Location = new System.Drawing.Point(0, 484);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(1354, 32);
            this.pnl3.TabIndex = 41;
            // 
            // llbClearTx
            // 
            this.llbClearTx.Dock = System.Windows.Forms.DockStyle.Right;
            this.llbClearTx.Location = new System.Drawing.Point(976, 0);
            this.llbClearTx.Name = "llbClearTx";
            this.llbClearTx.Size = new System.Drawing.Size(89, 32);
            this.llbClearTx.TabIndex = 22;
            this.llbClearTx.TabStop = true;
            this.llbClearTx.Text = "清空发送区";
            this.llbClearTx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llbClearTx.VisitedLinkColor = System.Drawing.Color.Blue;
            this.llbClearTx.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbClearClicked);
            // 
            // llbClearRx
            // 
            this.llbClearRx.Dock = System.Windows.Forms.DockStyle.Right;
            this.llbClearRx.Location = new System.Drawing.Point(1065, 0);
            this.llbClearRx.Name = "llbClearRx";
            this.llbClearRx.Size = new System.Drawing.Size(89, 32);
            this.llbClearRx.TabIndex = 21;
            this.llbClearRx.TabStop = true;
            this.llbClearRx.Text = "清空接收区";
            this.llbClearRx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llbClearRx.VisitedLinkColor = System.Drawing.Color.Blue;
            this.llbClearRx.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbClearClicked);
            // 
            // llbClearMsg
            // 
            this.llbClearMsg.Dock = System.Windows.Forms.DockStyle.Right;
            this.llbClearMsg.Location = new System.Drawing.Point(1154, 0);
            this.llbClearMsg.Name = "llbClearMsg";
            this.llbClearMsg.Size = new System.Drawing.Size(89, 32);
            this.llbClearMsg.TabIndex = 20;
            this.llbClearMsg.TabStop = true;
            this.llbClearMsg.Text = "清空系统日志";
            this.llbClearMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.llbClearMsg.VisitedLinkColor = System.Drawing.Color.Blue;
            this.llbClearMsg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbClearClicked);
            // 
            // lbSplite7
            // 
            this.lbSplite7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbSplite7.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbSplite7.Location = new System.Drawing.Point(1243, 0);
            this.lbSplite7.Name = "lbSplite7";
            this.lbSplite7.Size = new System.Drawing.Size(10, 32);
            this.lbSplite7.TabIndex = 19;
            this.lbSplite7.Text = "| ";
            this.lbSplite7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMessage
            // 
            this.lbMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbMessage.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbMessage.Location = new System.Drawing.Point(1253, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(101, 32);
            this.lbMessage.TabIndex = 18;
            this.lbMessage.Tag = "";
            this.lbMessage.Text = "隐藏消息框▼";
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbMessage.Click += new System.EventHandler(this.lbVisible_Click);
            // 
            // pnlUpload
            // 
            this.pnlUpload.Controls.Add(this.dgvUploadData);
            this.pnlUpload.Controls.Add(this.pnl4);
            this.pnlUpload.Controls.Add(this.tbxFilepath);
            this.pnlUpload.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlUpload.Location = new System.Drawing.Point(0, 0);
            this.pnlUpload.Name = "pnlUpload";
            this.pnlUpload.Size = new System.Drawing.Size(425, 484);
            this.pnlUpload.TabIndex = 42;
            // 
            // dgvUploadData
            // 
            this.dgvUploadData.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUploadData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUploadData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUploadData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUploadData.Location = new System.Drawing.Point(0, 21);
            this.dgvUploadData.Name = "dgvUploadData";
            this.dgvUploadData.RowTemplate.Height = 23;
            this.dgvUploadData.Size = new System.Drawing.Size(425, 257);
            this.dgvUploadData.TabIndex = 2;
            this.dgvUploadData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUploadData_CellValueChanged);
            // 
            // pnl4
            // 
            this.pnl4.Controls.Add(this.crtUpload);
            this.pnl4.Controls.Add(this.pnl5);
            this.pnl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl4.Location = new System.Drawing.Point(0, 278);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(425, 206);
            this.pnl4.TabIndex = 1;
            // 
            // crtUpload
            // 
            this.crtUpload.BackColor = System.Drawing.SystemColors.Control;
            this.crtUpload.BorderlineColor = System.Drawing.Color.Black;
            this.crtUpload.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.crtUpload.BorderSkin.PageColor = System.Drawing.Color.Black;
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MinorTickMark.Enabled = true;
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.BackColor = System.Drawing.SystemColors.Control;
            chartArea1.Name = "ChartArea1";
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisX.MinorTickMark.Enabled = true;
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea2";
            this.crtUpload.ChartAreas.Add(chartArea1);
            this.crtUpload.ChartAreas.Add(chartArea2);
            this.crtUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crtUpload.Location = new System.Drawing.Point(0, 0);
            this.crtUpload.Name = "crtUpload";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Name = "Series1";
            series1.XValueMember = "序号";
            series1.YValueMembers = "转速";
            series2.ChartArea = "ChartArea2";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series2";
            series2.XValueMember = "序号";
            series2.YValueMembers = "扭矩";
            this.crtUpload.Series.Add(series1);
            this.crtUpload.Series.Add(series2);
            this.crtUpload.Size = new System.Drawing.Size(341, 206);
            this.crtUpload.TabIndex = 3;
            this.crtUpload.Text = "chart1";
            // 
            // pnl5
            // 
            this.pnl5.Controls.Add(this.btnUpdate);
            this.pnl5.Controls.Add(this.lbSplit8);
            this.pnl5.Controls.Add(this.btnClearUpload);
            this.pnl5.Controls.Add(this.lbSplit6);
            this.pnl5.Controls.Add(this.btnStartUpload);
            this.pnl5.Controls.Add(this.btnBigImage);
            this.pnl5.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl5.Location = new System.Drawing.Point(341, 0);
            this.pnl5.Name = "pnl5";
            this.pnl5.Size = new System.Drawing.Size(84, 206);
            this.pnl5.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate.Location = new System.Drawing.Point(0, 86);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 33);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "更新图像";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lbSplit8
            // 
            this.lbSplit8.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSplit8.Location = new System.Drawing.Point(0, 76);
            this.lbSplit8.Name = "lbSplit8";
            this.lbSplit8.Size = new System.Drawing.Size(84, 10);
            this.lbSplit8.TabIndex = 4;
            this.lbSplit8.Text = "----------";
            this.lbSplit8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClearUpload
            // 
            this.btnClearUpload.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClearUpload.Location = new System.Drawing.Point(0, 43);
            this.btnClearUpload.Name = "btnClearUpload";
            this.btnClearUpload.Size = new System.Drawing.Size(84, 33);
            this.btnClearUpload.TabIndex = 3;
            this.btnClearUpload.Text = "清除数据";
            this.btnClearUpload.UseVisualStyleBackColor = true;
            this.btnClearUpload.Click += new System.EventHandler(this.btnClearUpload_Click);
            // 
            // lbSplit6
            // 
            this.lbSplit6.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbSplit6.Location = new System.Drawing.Point(0, 33);
            this.lbSplit6.Name = "lbSplit6";
            this.lbSplit6.Size = new System.Drawing.Size(84, 10);
            this.lbSplit6.TabIndex = 2;
            this.lbSplit6.Text = "----------";
            this.lbSplit6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStartUpload
            // 
            this.btnStartUpload.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStartUpload.Location = new System.Drawing.Point(0, 151);
            this.btnStartUpload.Name = "btnStartUpload";
            this.btnStartUpload.Size = new System.Drawing.Size(84, 55);
            this.btnStartUpload.TabIndex = 1;
            this.btnStartUpload.Text = "上传数据";
            this.btnStartUpload.UseVisualStyleBackColor = true;
            this.btnStartUpload.Click += new System.EventHandler(this.开始上传UToolStripMenuItem_Click);
            // 
            // btnBigImage
            // 
            this.btnBigImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBigImage.Location = new System.Drawing.Point(0, 0);
            this.btnBigImage.Name = "btnBigImage";
            this.btnBigImage.Size = new System.Drawing.Size(84, 33);
            this.btnBigImage.TabIndex = 0;
            this.btnBigImage.Text = "查看大图";
            this.btnBigImage.UseVisualStyleBackColor = true;
            this.btnBigImage.Click += new System.EventHandler(this.btnBigImage_Click);
            // 
            // tbxFilepath
            // 
            this.tbxFilepath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxFilepath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbxFilepath.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxFilepath.Location = new System.Drawing.Point(0, 0);
            this.tbxFilepath.Name = "tbxFilepath";
            this.tbxFilepath.ReadOnly = true;
            this.tbxFilepath.Size = new System.Drawing.Size(425, 21);
            this.tbxFilepath.TabIndex = 0;
            this.tbxFilepath.Text = "点击选择文件路径";
            this.tbxFilepath.Click += new System.EventHandler(this.打开配置文件OToolStripMenuItem_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.Control;
            this.splitter1.Location = new System.Drawing.Point(425, 0);
            this.splitter1.MinSize = 100;
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 484);
            this.splitter1.TabIndex = 43;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter_SplitterMoved);
            this.splitter1.DoubleClick += new System.EventHandler(this.splitter_DoubleClick);
            // 
            // pnl15
            // 
            this.pnl15.Controls.Add(this.lbUpload);
            this.pnl15.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl15.Location = new System.Drawing.Point(430, 0);
            this.pnl15.Name = "pnl15";
            this.pnl15.Size = new System.Drawing.Size(20, 484);
            this.pnl15.TabIndex = 44;
            // 
            // lbUpload
            // 
            this.lbUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbUpload.Location = new System.Drawing.Point(0, 0);
            this.lbUpload.Name = "lbUpload";
            this.lbUpload.Size = new System.Drawing.Size(20, 484);
            this.lbUpload.TabIndex = 16;
            this.lbUpload.Tag = "";
            this.lbUpload.Text = ">\r\n\r\n显\r\n示\r\n上\r\n传\r\n窗\r\n口\r\n\r\n>\r\n";
            this.lbUpload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbUpload.Click += new System.EventHandler(this.lbVisible_Click);
            // 
            // pnlDownload
            // 
            this.pnlDownload.Controls.Add(this.dgvDownloadData);
            this.pnlDownload.Controls.Add(this.panel2);
            this.pnlDownload.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDownload.Location = new System.Drawing.Point(554, 0);
            this.pnlDownload.Name = "pnlDownload";
            this.pnlDownload.Size = new System.Drawing.Size(800, 484);
            this.pnlDownload.TabIndex = 45;
            // 
            // dgvDownloadData
            // 
            this.dgvDownloadData.AllowUserToAddRows = false;
            this.dgvDownloadData.AllowUserToDeleteRows = false;
            this.dgvDownloadData.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDownloadData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDownloadData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDownloadData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvDownloadData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDownloadData.Location = new System.Drawing.Point(0, 0);
            this.dgvDownloadData.Name = "dgvDownloadData";
            this.dgvDownloadData.ReadOnly = true;
            this.dgvDownloadData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDownloadData.RowHeadersVisible = false;
            this.dgvDownloadData.RowTemplate.Height = 23;
            this.dgvDownloadData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDownloadData.Size = new System.Drawing.Size(800, 453);
            this.dgvDownloadData.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "序号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Width = 75;
            // 
            // Column2
            // 
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "时间/s";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "转速/rpm";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.Frozen = true;
            this.Column4.HeaderText = "扭矩/N·m";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.Frozen = true;
            this.Column5.HeaderText = "油门/%";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.Frozen = true;
            this.Column6.HeaderText = "电流/A";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.Frozen = true;
            this.Column7.HeaderText = "电压/V";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.Frozen = true;
            this.Column8.HeaderText = "电量/%";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.Width = 80;
            // 
            // Column9
            // 
            this.Column9.Frozen = true;
            this.Column9.HeaderText = "温度/℃";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column9.Width = 80;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lbTotalCount);
            this.panel2.Controls.Add(this.btnUpdateDownload);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnClearShow);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lbShowRowsCount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 453);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 31);
            this.panel2.TabIndex = 5;
            // 
            // lbTotalCount
            // 
            this.lbTotalCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTotalCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbTotalCount.ForeColor = System.Drawing.Color.Black;
            this.lbTotalCount.Location = new System.Drawing.Point(248, 0);
            this.lbTotalCount.Name = "lbTotalCount";
            this.lbTotalCount.Size = new System.Drawing.Size(222, 31);
            this.lbTotalCount.TabIndex = 11;
            this.lbTotalCount.Text = "总计：0 行数据";
            this.lbTotalCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnUpdateDownload
            // 
            this.btnUpdateDownload.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUpdateDownload.Location = new System.Drawing.Point(470, 0);
            this.btnUpdateDownload.Name = "btnUpdateDownload";
            this.btnUpdateDownload.Size = new System.Drawing.Size(180, 31);
            this.btnUpdateDownload.TabIndex = 10;
            this.btnUpdateDownload.Text = "显示数据";
            this.btnUpdateDownload.UseVisualStyleBackColor = true;
            this.btnUpdateDownload.Click += new System.EventHandler(this.btnUpdateDownload_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(650, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(23, 31);
            this.panel4.TabIndex = 9;
            // 
            // btnClearShow
            // 
            this.btnClearShow.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearShow.Location = new System.Drawing.Point(673, 0);
            this.btnClearShow.Name = "btnClearShow";
            this.btnClearShow.Size = new System.Drawing.Size(75, 31);
            this.btnClearShow.TabIndex = 8;
            this.btnClearShow.Text = "清除显示";
            this.btnClearShow.UseVisualStyleBackColor = true;
            this.btnClearShow.Click += new System.EventHandler(this.btnClearShow_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(748, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(52, 31);
            this.panel3.TabIndex = 7;
            // 
            // lbShowRowsCount
            // 
            this.lbShowRowsCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbShowRowsCount.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbShowRowsCount.ForeColor = System.Drawing.Color.Black;
            this.lbShowRowsCount.Location = new System.Drawing.Point(0, 0);
            this.lbShowRowsCount.Name = "lbShowRowsCount";
            this.lbShowRowsCount.Size = new System.Drawing.Size(800, 31);
            this.lbShowRowsCount.TabIndex = 6;
            this.lbShowRowsCount.Text = "显示的数据：0 行数据";
            this.lbShowRowsCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.Control;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(549, 0);
            this.splitter2.MinSize = 100;
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(5, 484);
            this.splitter2.TabIndex = 46;
            this.splitter2.TabStop = false;
            this.splitter2.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter_SplitterMoved);
            // 
            // pnl16
            // 
            this.pnl16.Controls.Add(this.lbDownload);
            this.pnl16.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl16.Location = new System.Drawing.Point(529, 0);
            this.pnl16.Name = "pnl16";
            this.pnl16.Size = new System.Drawing.Size(20, 484);
            this.pnl16.TabIndex = 47;
            // 
            // lbDownload
            // 
            this.lbDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDownload.Location = new System.Drawing.Point(0, 0);
            this.lbDownload.Name = "lbDownload";
            this.lbDownload.Size = new System.Drawing.Size(20, 484);
            this.lbDownload.TabIndex = 17;
            this.lbDownload.Tag = "";
            this.lbDownload.Text = "<\r\n\r\n显\r\n示\r\n下\r\n载\r\n窗\r\n口\r\n\r\n<";
            this.lbDownload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDownload.Click += new System.EventHandler(this.lbVisible_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.pnl16);
            this.pnlForm.Controls.Add(this.splitter2);
            this.pnlForm.Controls.Add(this.pnlDownload);
            this.pnlForm.Controls.Add(this.pnl15);
            this.pnlForm.Controls.Add(this.splitter1);
            this.pnlForm.Controls.Add(this.pnlUpload);
            this.pnlForm.Controls.Add(this.pnl3);
            this.pnlForm.Controls.Add(this.splitter3);
            this.pnlForm.Controls.Add(this.pnlMsg);
            this.pnlForm.Controls.Add(this.pnlMain);
            this.pnlForm.Controls.Add(this.pnl2);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 25);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1354, 696);
            this.pnlForm.TabIndex = 23;
            // 
            // display1
            // 
            this.display1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.display1.Location = new System.Drawing.Point(23, 0);
            this.display1.Name = "display1";
            this.display1.Size = new System.Drawing.Size(1308, 656);
            this.display1.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 746);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnl8);
            this.Controls.Add(this.pnl1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1370, 785);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "纯电动汽车试验平台";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnl1.ResumeLayout(false);
            this.pnl1.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.pnl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxRun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxInit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSerial)).EndInit();
            this.pnl8.ResumeLayout(false);
            this.pnl12.ResumeLayout(false);
            this.pnl11.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.pnlMsg.ResumeLayout(false);
            this.pnlMsg.PerformLayout();
            this.pnl14.ResumeLayout(false);
            this.pnl14.PerformLayout();
            this.gpbMsg.ResumeLayout(false);
            this.gpbMsg.PerformLayout();
            this.gpbRx.ResumeLayout(false);
            this.gpbRx.PerformLayout();
            this.gpbTx.ResumeLayout(false);
            this.gpbTx.PerformLayout();
            this.pnl3.ResumeLayout(false);
            this.pnlUpload.ResumeLayout(false);
            this.pnlUpload.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUploadData)).EndInit();
            this.pnl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.crtUpload)).EndInit();
            this.pnl5.ResumeLayout(false);
            this.pnl15.ResumeLayout(false);
            this.pnlDownload.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDownloadData)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnl16.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip ttpDetailMessage;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Panel pnl1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出实验数据OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选项OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 配置串口属性SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开串口OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭串口CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 控制CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 测试连接TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 启动设备SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 停止设备TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上传配置文件PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开配置文件OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开始上传UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 高压电池BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开高压电池OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭高压电池CToolStripMenuItem;
        private System.Windows.Forms.Panel pnl6;
        private System.Windows.Forms.LinkLabel llbSerial;
        private System.Windows.Forms.Label lbSplite5;
        private System.Windows.Forms.Label lbRx;
        private System.Windows.Forms.Label lbSplite4;
        private System.Windows.Forms.Label lbTx;
        private System.Windows.Forms.Label lbSplite3;
        private System.Windows.Forms.PictureBox pbxRun;
        private System.Windows.Forms.Label lbRun;
        private System.Windows.Forms.Label lbSplite2;
        private System.Windows.Forms.PictureBox pbxInit;
        private System.Windows.Forms.Label lbInit;
        private System.Windows.Forms.Label lbSplite1;
        private System.Windows.Forms.PictureBox pbxSerial;
        private System.Windows.Forms.Label lbSerial;
        private System.Windows.Forms.Panel pnl8;
        private System.Windows.Forms.Label lbMsg;
        private System.Windows.Forms.Label lbPercent;
        private System.Windows.Forms.LinkLabel llbCancel;
        private System.Windows.Forms.Panel pnl11;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Panel pnl10;
        private System.Windows.Forms.Timer TimerTx;
        private System.Windows.Forms.Timer TimerRx;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Timer TimerSys;
        private System.ComponentModel.BackgroundWorker WaitFeedback;
        private System.ComponentModel.BackgroundWorker UploadCommands;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.Panel pnl12;
        private System.Windows.Forms.ProgressBar pgbMain;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel pnl2;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl18;
        private System.Windows.Forms.Panel pnl7;
        private System.Windows.Forms.Panel pnlMsg;
        private System.Windows.Forms.TextBox tbxSend;
        private System.Windows.Forms.Panel pnl14;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.CheckBox cbxSendNewLine;
        private System.Windows.Forms.GroupBox gpbMsg;
        private System.Windows.Forms.TextBox tbxMsg;
        private System.Windows.Forms.GroupBox gpbRx;
        private System.Windows.Forms.TextBox tbxRx;
        private System.Windows.Forms.GroupBox gpbTx;
        private System.Windows.Forms.TextBox tbxTx;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.LinkLabel llbClearTx;
        private System.Windows.Forms.LinkLabel llbClearRx;
        private System.Windows.Forms.LinkLabel llbClearMsg;
        private System.Windows.Forms.Label lbSplite7;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Panel pnlUpload;
        private System.Windows.Forms.DataGridView dgvUploadData;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtUpload;
        private System.Windows.Forms.Panel pnl5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbSplit8;
        private System.Windows.Forms.Button btnClearUpload;
        private System.Windows.Forms.Label lbSplit6;
        private System.Windows.Forms.Button btnStartUpload;
        private System.Windows.Forms.Button btnBigImage;
        private System.Windows.Forms.TextBox tbxFilepath;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnl15;
        private System.Windows.Forms.Label lbUpload;
        private System.Windows.Forms.Panel pnlDownload;
        private System.Windows.Forms.DataGridView dgvDownloadData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTotalCount;
        private System.Windows.Forms.Button btnUpdateDownload;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnClearShow;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbShowRowsCount;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel pnl16;
        private System.Windows.Forms.Label lbDownload;
        private System.Windows.Forms.Panel pnlForm;
        private Display display1;
    }
}

