using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NEDC
{
    public partial class frmMain : Form
    {

        #region 窗体初始化和关闭时的任务

        /// <summary>
        /// 类的构造函数，用于窗体的初始化
        /// </summary>
        /// <param name="Enable">传入一个参数，控制整个窗体的使能</param>
        public frmMain(bool Enable)
        {
            InitializeComponent();
            InitControlTag();
            Initbitmap();
            InitDataTable();
            this.Enabled = Enable;
        }

        /// <summary>
        /// 窗体加载时，控件初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                StartTime = DateTime.Now;
                string[] SizeChange = new string[] { "lbUpload", "lbDownload", "lbMessage", };
                foreach (string item in SizeChange) lbVisible_Click(Common.WinformControl.FindControl(pnlForm, item), null);
                string[] ClearChange = new string[] { "llbClearTx", "llbClearRx", "llbClearMsg" };
                foreach (string item in ClearChange) llbClearClicked(Common.WinformControl.FindControl(pnlForm, item), null);
                pbxSerial.Image = Red;
                pbxInit.Image = Red;
                pbxRun.Image = Red;
                SerialWrite("");
                SerialReceive("");
            }
            catch (Exception Ex)
            {
                SystemWriteLog("窗体无法启动！\r\n将退出应用程序！\r\n" + Ex.Message, true);
                Application.Exit();
            }
        }

        /// <summary>
        /// 窗体关闭前关闭串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                DialogResult result = MessageBox.Show("当前串口已打开，可能程序还在运行，是否要退出？", "注意", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.OK) 关闭串口CToolStripMenuItem_Click(null, null);
                else e.Cancel = true;
            }
        }

        #endregion

        #region 私有属性变量

        /// <summary>
        /// 用于储存上传文件的文件内的数据
        /// </summary>
        private static DataTable UploadData;

        /// <summary>
        /// 用于储存下载到的数据
        /// </summary>
        private static DataTable DownloadData;

        /// <summary>
        /// 用于记录开始的时间，以便于算出系统的运行时间
        /// </summary>
        private static DateTime StartTime;

        /// <summary>
        /// 保存红色圆点的图片
        /// </summary>
        private Bitmap Red;

        /// <summary>
        /// 保存绿色圆点的图片
        /// </summary>
        private Bitmap Green;

        /// <summary>
        /// 串口接收的一条数据，用于外部方法调用
        /// </summary>
        private string ReceiveMsg = "";

        /// <summary>
        /// 用于储存串口收到消息的返回值，true为返回OK，false为返回Error
        /// </summary>
        private bool Result = false;

        /// <summary>
        /// 保存是否以测试连接的状态
        /// </summary>
        private bool InitOK = false;

        /// <summary>
        /// 保存是否已运行的状态
        /// </summary>
        private bool StartRun = false;

        /// <summary>
        /// 记录收到数据的大小
        /// </summary>
        private long RxCount = 0;

        /// <summary>
        /// 记录已发送数据的大小
        /// </summary>
        private long TxCount = 0;

        /// <summary>
        /// 记录0.5s之前收到发出数据的大小，用于计算上传速度
        /// </summary>
        private long LastUploadData = 0;

        /// <summary>
        /// 记录0.5s之前发送数据的大小，用于计算下载速度
        /// </summary>
        private long LastDownloadData = 0;

        /// <summary>
        /// 记录接收或发送数据时脉冲激活的颜色值
        /// </summary>
        private Color ActiveColor = Color.FromArgb(255, 255, 128, 0);

        /// <summary>
        /// 记录接收或发送数据时脉冲未激活的颜色值
        /// </summary>
        private Color UnActiveColor = Color.FromArgb(120, 255, 128, 0);

        /// <summary>
        /// 用于记录当前的工作状态
        /// </summary>
        private ModeStatus Mode = ModeStatus.None;

        /// <summary>
        /// 用于记录发送内容时的发送间隔
        /// </summary>
        private int WaitTime = 100;

        /// <summary>
        /// 用于接收计数
        /// </summary>
        private int ReceiveCount = 0;

        private int ReceiveTimes = 0;

        /// <summary>
        /// 所有工作状态的枚举类型
        /// </summary>
        private enum ModeStatus
        {
            None = -1,
            Init = 0,
            Start = 1,
            Stop = 2,
            Update = 3,
            Open = 4,
            Close = 5
        }

        #endregion

        #region 菜单栏功能区

        /// <summary>
        /// 导出实验数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 导出实验数据OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog()
            {
                FileName = "实验数据.csv",
                Filter = "CSV文件(*.csv)|*.csv",
                Title = "选择文件保存位置"
            };
            try
            {
                if (serialPort.IsOpen) throw new Exception("请关闭串口后重试！");
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    ControlCSV.SaveDownloadData(dialog.FileName, DownloadData);
                    SystemWriteLog("导出实验数据成功！");
                    MessageBox.Show("导出实验数据成功", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception Ex)
            {
                SystemWriteLog(Ex.Message, true);
            }
            finally
            {
                dialog.Dispose();
            }
        }

        /// <summary>
        /// 配置串口属性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 配置串口属性SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSerialPort dialog = new frmSerialPort(serialPort);
            try
            {
                if (serialPort.IsOpen)
                {
                    DialogResult result = MessageBox.Show("当前串口已打开，是否关闭后配置新串口属性？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.No) return;
                    else 关闭串口CToolStripMenuItem_Click(null, null);
                }
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    CopySerialPort(dialog.ConfirmSerialPort, ref serialPort);
                    打开串口OToolStripMenuItem_Click(null, null);
                }
                llbSerial.Text = "串口号：" + serialPort.PortName + "；波特率：" + serialPort.BaudRate;
                string tag = "串口号：\t" + serialPort.PortName + "\r\n";
                tag += "波特率：\t" + serialPort.BaudRate + "\r\n";
                tag += "数据位：\t" + serialPort.DataBits.ToString() + "\r\n";
                tag += "奇偶校验：\t" + serialPort.Parity.ToString() + "\r\n";
                tag += "停止位：\t" + serialPort.StopBits.ToString() + "\r\n";
                ttpDetailMessage.SetToolTip(llbSerial, tag);
                SystemWriteLog("已配置串口属性：" + llbSerial.Text);
            }
            catch (Exception Ex)
            {
                SystemWriteLog(Ex.Message, true);
            }
            finally
            {
                dialog.Dispose();
            }
        }

        /// <summary>
        /// 打开串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 打开串口OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Open();
                ChangeSerialPortOpenStatus(true);
                SystemWriteLog("串口打开成功");
            }
            catch (Exception Ex)
            {
                ChangeSerialPortOpenStatus(false);
                SystemWriteLog(Ex.Message, true);
            }
        }

        /// <summary>
        /// 关闭串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 关闭串口CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Close();
                ChangeSerialPortOpenStatus(false);
                SystemWriteLog("串口关闭成功");
            }
            catch (Exception Ex)
            {
                ChangeSerialPortOpenStatus(true);
                SystemWriteLog(Ex.Message, true);
            }
        }

        /// <summary>
        /// 测试连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 测试连接TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen) SendAndWaitFeedback(ModeStatus.Init);
                else SystemWriteLog("请打开串口后尝试操作！", true);
            }
            catch (Exception Ex)
            {
                SystemWriteLog(Ex.Message, true);
            }
        }

        /// <summary>
        /// 启动设备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 启动设备SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen && InitOK) SendAndWaitFeedback(ModeStatus.Start);
                else SystemWriteLog("请确保打开串口后完成初始化操作后尝试！", true);
            }
            catch (Exception Ex)
            {
                SystemWriteLog(Ex.Message, true);
            }
        }

        /// <summary>
        /// 停止设备
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 停止设备TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort.IsOpen && InitOK && StartRun) SendAndWaitFeedback(ModeStatus.Stop);
                else SystemWriteLog("请在启动设备后尝试！", true);
            }
            catch (Exception Ex)
            {
                SystemWriteLog(Ex.Message, true);
            }
        }

        /// <summary>
        /// 打开配置文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 打开配置文件OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                FileName = "Command.csv",
                Filter = "CSV文件(*.csv)|*.csv",
                Multiselect = false,
                Title = "选择要上传的文件"
            };
            try
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    btnClearUpload_Click(null, null);
                    UploadData = ControlCSV.OpenUploadFile(dialog.FileName);
                    dgvUploadData.DataSource = UploadData;
                    foreach (DataGridViewColumn item in dgvUploadData.Columns)
                        dgvUploadData.Columns[item.Name].SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvUploadData.Columns[0].ReadOnly = true;
                    btnUpdate_Click(null, null);
                    SystemWriteLog("加载文件成功！");
                    lbUpload.Tag = "1?" + lbUpload.Tag.ToString().Split('?')[1];
                    lbVisible_Click(lbUpload, null);
                }
            }
            catch (Exception Ex)
            {
                SystemWriteLog(Ex.Message, true);
            }
            finally
            {
                dialog.Dispose();
            }
        }

        /// <summary>
        /// 开始上传
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 开始上传UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> Commands = new List<string> { "Upload" };
            try
            {
                if (UploadData == null || UploadData.Rows.Count <= 0) throw new Exception("请选择上传的数据集！");
                foreach (DataGridViewRow row_item in dgvUploadData.Rows)
                {
                    string Temp = "";
                    bool FristColumn = true;
                    foreach (DataGridViewCell cell_item2 in row_item.Cells)
                    {
                        if (cell_item2.Value == null) break;
                        if (!FristColumn) Temp += Convert.ToInt16(cell_item2.Value.ToString()).ToString("0000") + ";";
                        FristColumn = false;
                    }
                    if (Temp != "") Commands.Add(Temp);
                }
                Commands.Add("End");
                string Notice = "共计生成" + Commands.Count + "条指令，是否继续导入？\r\n\r\n";
                Notice += "1:\t" + Commands[0] + "\r\n";
                Notice += "2:\t" + Commands[1] + "\r\n";
                Notice += "...\t...\r\n";
                Notice += (Commands.Count - 1) + ":\t" + Commands[Commands.Count - 2] + "\r\n";
                Notice += Commands.Count + ":\t" + Commands[Commands.Count - 1] + "\r\n";
                DialogResult result = MessageBox.Show(Notice, "注意", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result != DialogResult.OK) return;
                if (!serialPort.IsOpen) throw new Exception("请打开串口后尝试操作！");
                StartUploadData(Commands.ToArray());
            }
            catch (Exception Ex)
            {
                SystemWriteLog(Ex.Message, true);
            }
        }

        /// <summary>
        /// 打开高压电池
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 打开高压电池OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SendAndWaitFeedback(ModeStatus.Open);
            }
            catch (Exception Ex)
            {
                SystemWriteLog(Ex.Message, true);
            }
        }

        /// <summary>
        /// 关闭高压电池
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 关闭高压电池CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SendAndWaitFeedback(ModeStatus.Close);
            }
            catch (Exception Ex)
            {
                SystemWriteLog(Ex.Message, true);
            }
        }

        #endregion

        #region 自定义方法


        /// <summary>
        /// 生成一个用于绘图的泛型列表
        /// </summary>
        /// <param name="Msg">传入的内容</param>
        /// <returns></returns>
        private List<string> GetShowData(List<string> Msg)
        {
            List<string> Temp = new List<string> { };
            int i = 0;
            foreach (string str in Msg)
            {
                Temp.Add(str);
                if (i++ < 2)
                {
                    try
                    {
                        Temp.Add(UploadData.Rows[ReceiveCount][0].ToString());
                        if (ReceiveTimes++ % 10 == 0) ReceiveCount++;
                    }
                    catch
                    {
                        Temp.Add(str);
                    }
                }
                else
                {
                    Temp.Add(str);
                }
            }
            return Temp;
        }

        /// <summary>
        /// 初始化控件Tag属性的方法体
        /// </summary>
        private void InitControlTag()
        {
            try
            {
                lbUpload.Tag = "0?pnlUpload;425,0;>\n\n显\n示\n上\n传\n窗\n口\n\n>;<\n\n隐\n藏\n上\n传\n窗\n口\n\n<";
                lbDownload.Tag = "0?pnlDownload;800,0;<\n\n显\n示\n下\n载\n窗\n口\n\n<;>\n\n隐\n藏\n下\n载\n窗\n口\n\n>";
                lbMessage.Tag = "0?pnlMsg;0,170;显示消息框▲;隐藏消息框▼";
                llbClearTx.Tag = tbxTx;
                llbClearRx.Tag = tbxRx;
                llbClearMsg.Tag = tbxMsg;
                splitter1.Tag = lbUpload;
                splitter2.Tag = lbDownload;
                splitter3.Tag = lbMessage;
            }
            catch (Exception Ex)
            {
                SystemWriteLog(Ex.Message + "\r\n出现严重错误，程序将退出运行！", true);
                Application.Exit();
            }
        }

        /// <summary>
        /// 初始化红色状态和绿色状态的方法体
        /// </summary>
        private void Initbitmap()
        {
            int pbxWidth = 20;
            Red = new Bitmap(pbxWidth, pbxWidth);
            Graphics Red_g = Graphics.FromImage(Red);
            Red_g.FillEllipse(Brushes.Green, 0, 0, Red.Width, Red.Height);
            Green = (Bitmap)Red.Clone();
            Red_g.FillEllipse(Brushes.Red, 0, 0, Red.Width, Red.Height);
            Red_g.Dispose();
        }

        /// <summary>
        /// 初始化接收数据的DataTable对象，主要目的为加载上列名
        /// </summary>
        private void InitDataTable()
        {
            DownloadData = new DataTable();
            foreach (DataGridViewColumn item in dgvDownloadData.Columns)
            {
                DataColumn dataColumn = new DataColumn(item.HeaderText);
                DownloadData.Columns.Add(dataColumn);
                dataColumn.Dispose();
            }
        }

        /// <summary>
        /// 复制一个串口对象
        /// </summary>
        /// <param name="OriPort">原串口对象</param>
        /// <param name="TarPort">引用的目标串口对象</param>
        private void CopySerialPort(System.IO.Ports.SerialPort OriPort, ref System.IO.Ports.SerialPort TarPort)
        {
            TarPort.PortName = OriPort.PortName;
            TarPort.BaudRate = OriPort.BaudRate;
            TarPort.DataBits = OriPort.DataBits;
            TarPort.StopBits = OriPort.StopBits;
            TarPort.Parity = OriPort.Parity;
        }

        /// <summary>
        /// 当串口打开状态发生改变时改变UI
        /// </summary>
        /// <param name="Open">控件的使能情况</param>
        private void ChangeSerialPortOpenStatus(bool Open)
        {
            if (Open)
            {
                pbxSerial.Image = Green;
                serialPort.DataReceived += serialPort_DataReceived;
            }
            else
            {
                pbxSerial.Image = Red;
                pbxInit.Image = Red;
                pbxRun.Image = Red;
                InitOK = false;
                StartRun = false;
                serialPort.DataReceived -= serialPort_DataReceived;
            }
            打开串口OToolStripMenuItem.Enabled = !Open;
            关闭串口CToolStripMenuItem.Enabled = Open;
        }

        /// <summary>
        /// 串口发送命令
        /// </summary>
        /// <param name="Msg">发送的内容</param>
        /// <param name="NewLine">是否发送新行</param>
        /// <returns></returns>
        private bool SerialWrite(string Msg, bool NewLine = true)
        {
            try
            {
                if (Msg != string.Empty)
                {
                    if (NewLine) serialPort.WriteLine(Msg);
                    else serialPort.Write(Msg);
                }
                this.Invoke((EventHandler)(delegate
                {
                    if (Msg != string.Empty)
                    {
                        tbxTx.AppendText(DateTime.Now.ToString("HH:mm:ss->") + Msg + "\r\n");
                        TxCount += Msg.Length;
                        lbTx.Text = "Tx:" + TxCount.ToString();
                    }
                    lbTx.BackColor = ActiveColor;
                    TimerTx.Enabled = true;
                }));
                return true;
            }
            catch (Exception Ex)
            {
                SystemWriteLog(Ex.Message, true);
                return false;
            }
        }

        /// <summary>
        /// 串口接收时对应UI操作
        /// </summary>
        /// <param name="RxBuff">接收到的数据</param>
        private void SerialReceive(string RxBuff)
        {
            this.Invoke((EventHandler)(delegate
            {
                try
                {
                    if (RxBuff != string.Empty)
                    {
                        tbxRx.AppendText(DateTime.Now.ToString("HH:mm:ss->") + RxBuff + "\r\n");
                        RxCount += RxBuff.Length;
                        lbRx.Text = "Rx:" + RxCount.ToString();
                    }
                    lbRx.BackColor = ActiveColor;
                    TimerRx.Enabled = true;

                }
                catch (Exception Ex)
                {
                    SystemWriteLog(Ex.Message, true);
                }
            }));
        }

        /// <summary>
        /// 写入系统日志
        /// </summary>
        /// <param name="Msg">写入日志的内容</param>
        /// <param name="ShowDialog">是否弹出消息框</param>
        private void SystemWriteLog(string Msg, bool ShowDialog = false)
        {
            try
            {
                this.Invoke((EventHandler)(delegate
                {

                    if (ShowDialog)
                        MessageBox.Show(Msg, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Msg = Msg.Replace("\r", "");
                    Msg = Msg.Replace("\n", " ");
                    tbxMsg.AppendText(DateTime.Now.ToString("HH:mm:ss->") + Msg + "\r\n");
                }));
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message + "\n\n应用程序将退出！", "严重错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        /// <summary>
        /// 根据字节数获取具体大小
        /// </summary>
        /// <param name="Length">字节大小</param>
        /// <returns></returns>
        private string GetSize(double Length)
        {
            string[] units = new string[] { " B", " KB", " MB", " GB", " TB", " PB" };
            double mod = 1024.0;
            int i = 0;
            while (Length >= mod)
            {
                Length /= mod;
                i++;
            }
            return Length.ToString("0.00") + units[i];
        }

        /// <summary>
        /// 发送消息并等待回复
        /// </summary>
        /// <param name="Command">发送的命令（状态）</param>
        private void SendAndWaitFeedback(ModeStatus Command)
        {
            try
            {
                Mode = Command;
                SendAndWaitFeedback(Command.ToString());
            }
            catch (Exception Ex)
            {
                SystemWriteLog(Ex.Message, true);
            }
        }

        /// <summary>
        /// 发送消息并等待回复
        /// </summary>
        /// <param name="Command">发送的命令（字符串）</param>
        private void SendAndWaitFeedback(string Command)
        {
            try
            {
                ControlUI(false);
                WaitFeedback.RunWorkerAsync(Command);
            }
            catch (Exception Ex)
            {
                SystemWriteLog(Ex.Message, true);
            }
        }

        /// <summary>
        /// 控制UI界面的使能
        /// </summary>
        /// <param name="Enable">控件的使能情况</param>
        private void ControlUI(bool Enable)
        {
            try
            {
                llbCancel.Enabled = !Enable;
                文件FToolStripMenuItem.Enabled = Enable;
                选项OToolStripMenuItem.Enabled = Enable;
                控制CToolStripMenuItem.Enabled = Enable;
                上传配置文件PToolStripMenuItem.Enabled = Enable;
                高压电池BToolStripMenuItem.Enabled = Enable;
                pnlUpload.Enabled = Enable;
                pnlDownload.Enabled = Enable;
                btnSend.Enabled = Enable;
                cbxSendNewLine.Enabled = Enable;
                pnl6.Enabled = Enable;
            }
            catch (Exception Ex)
            {
                SystemWriteLog(Ex.Message, true);
            }
        }

        /// <summary>
        /// 开始上传命令
        /// </summary>
        /// <param name="Commands">上传的命令集</param>
        private void StartUploadData(string[] Commands)
        {
            try
            {
                Mode = ModeStatus.Update;
                ControlUI(false);
                WaitTime = Convert.ToInt16(toolStripTextBox1.Text);
                UploadCommands.RunWorkerAsync(Commands);
            }
            catch (Exception Ex)
            {
                ControlUI(true);
                SystemWriteLog(Ex.Message, true);
            }
        }

        #endregion

        #region 后台线程

        /// <summary>
        /// 发送消息并等待回复的后台线程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WaitFeedback_DoWork(object sender, DoWorkEventArgs e)
        {
            ReceiveMsg = "";
            string Status = ReceiveMsg.Split(';')[0].Split(':')[0].ToUpper();
            int TimeCount = -1;
            Result = false;
            while (Status != "OK" && Status != "ERROR")
            {
                if (WaitFeedback.CancellationPending)
                {
                    WaitFeedback.ReportProgress(100, "已成功取消操作...");
                    return;
                }
                else
                {
                    WaitFeedback.ReportProgress(TimeCount, "正在等待设备应答...");
                    if ((TimeCount++) >= 100)
                    {
                        WaitFeedback.ReportProgress(100, "等待超时，设备无应答...");
                        SystemWriteLog("设备无应答，请检查设备连接状态！", true);
                        return;
                    }
                    else
                    {
                        if (TimeCount % 10 == 0)
                        {
                            if (!SerialWrite(e.Argument.ToString()))
                            {
                                WaitFeedback.ReportProgress(100, "串口未开启...");
                                return;
                            }
                        }
                    }
                }
                System.Threading.Thread.Sleep(100);
                Status = ReceiveMsg.Split(';')[0].Split(':')[0].ToUpper();
            }
            if (Status == "OK")
            {
                Result = true;
                WaitFeedback.ReportProgress(100, "设备做出应答：" + ReceiveMsg + "...");
            }
            else if (Status == "ERROR")
            {
                SystemWriteLog("设备异常！", true);
                this.Invoke((EventHandler)(delegate
                {
                    lbMessage.Tag = "1?" + lbMessage.Tag.ToString().Split('?')[1];
                    lbVisible_Click(lbMessage, null);
                }));
                WaitFeedback.ReportProgress(100, "设备异常：" + ReceiveMsg + " 请检查！...");
            }
        }

        /// <summary>
        /// 发送消息并等待回复的线程报告
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WaitFeedback_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            this.Invoke((EventHandler)(delegate
            {
                try
                {
                    lbMsg.Text = e.UserState.ToString();
                    if (e.ProgressPercentage >= pgbMain.Minimum && e.ProgressPercentage <= pgbMain.Maximum) pgbMain.Value = e.ProgressPercentage;
                    lbPercent.Text = ((double)pgbMain.Value / pgbMain.Maximum).ToString("0%");
                }
                catch (Exception Ex)
                {
                    SystemWriteLog(Ex.Message, true);
                }
            }));
        }

        /// <summary>
        /// 发送消息并等待回复的后台线程完成时执行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WaitFeedback_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                pgbMain.Value = pgbMain.Maximum;
                lbPercent.Text = "100%";
                ControlUI(true);
                if (Mode == ModeStatus.Init)
                {
                    if (Result) pbxInit.Image = Green;
                    else pbxInit.Image = Red;
                    InitOK = Result;
                }
                else if (Mode == ModeStatus.Start)
                {
                    if (Result) pbxRun.Image = Green;
                    else pbxRun.Image = Red;
                    StartRun = Result;
                }
                else if (Mode == ModeStatus.Stop)
                {
                    if (Result) pbxRun.Image = Red;
                    else pbxRun.Image = Green;
                    StartRun = !Result;
                    if (!StartRun)
                    {
                        InitOK = false;
                        pbxInit.Image = Red;
                    }

                }
                Mode = ModeStatus.None;
                Result = false;
            }
            catch (Exception Ex)
            {
                SystemWriteLog(Ex.Message, true);
            }
        }

        /// <summary>
        /// 上传命令集时的后台线程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UploadCommands_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string[] Commands = (string[])e.Argument;
                for (int i = 0; i < Commands.Count(); i++)
                {
                    if (UploadCommands.CancellationPending)
                    {
                        WaitFeedback.ReportProgress(100, "已成功取消操作...");
                        return;
                    }
                    int Progress = (i * 100) / Commands.Count();
                    UploadCommands.ReportProgress(Progress, "当前正在发送第" + (i + 1) + "个指令...");
                    SerialWrite(Commands[i]);
                    System.Threading.Thread.Sleep(WaitTime);
                }
                MessageBox.Show("上传完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Ex)
            {
                SystemWriteLog(Ex.Message, true);
            }
        }

        /// <summary>
        /// 串口接收数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                string RxBuff = serialPort.ReadLine().Replace("\r", "");
                ReceiveMsg = RxBuff;
                SerialReceive(RxBuff);
                List<string> ReceiveValue = new List<string>
                    {
                        (DownloadData.Rows.Count + 1).ToString(),
                        (DownloadData.Rows.Count/10.0 + 1).ToString("0.0")
                    };
                ReceiveValue.AddRange(RxBuff.Split(';'));
                ReceiveValue.Remove("");
                if (ReceiveValue.Count != dgvDownloadData.ColumnCount) return;
                DownloadData.Rows.Add(ReceiveValue.ToArray());
                ReceiveValue.RemoveRange(0, 2);
                this.Invoke((EventHandler)(delegate { display1.AddPoint(GetShowData(ReceiveValue).ToArray()); }));
            }
            catch (Exception Ex)
            {
                SystemWriteLog(Ex.Message, true);
            }
        }

        #endregion

        #region 其他功能

        /// <summary>
        /// 显示或隐藏边框内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbVisible_Click(object sender, EventArgs e)
        {
            try
            {
                Label lb = (Label)sender;
                string tag = lb.Tag.ToString();
                int Status = Convert.ToInt16(tag.Split('?')[0]);
                tag = tag.Split('?')[1];
                Panel pnl = (Panel)Common.WinformControl.FindControl(pnlForm, tag.Split(';')[0]);
                string pnlSize = tag.Split(';')[1];
                pnl.Size = new Size(Status * Convert.ToInt16(pnlSize.Split(',')[0]), Status * Convert.ToInt16(pnlSize.Split(',')[1]));
                lb.Text = tag.Split(';')[Status + 2];
                Status = (++Status) % 2;
                lb.Tag = Status + "?" + tag;
            }
            catch (Exception Ex)
            {
                SystemWriteLog("未按照规范编写Tag内容，请检查！\r\n" + Ex.Message, true);
            }
        }

        /// <summary>
        /// 清除消息记录内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void llbClearClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                LinkLabel llb = (LinkLabel)sender;
                TextBox tbx = (TextBox)llb.Tag;
                tbx.Text = string.Empty;
            }
            catch (Exception Ex)
            {
                SystemWriteLog(Ex.Message, true);
            }
        }

        /// <summary>
        /// 显示上传数据的大图
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBigImage_Click(object sender, EventArgs e)
        {
            if (UploadData == null || UploadData.Columns.Count == 0) return;
            frmChart dialog = new frmChart(UploadData);
            try
            {
                dialog.ShowDialog();
            }
            catch (Exception Ex)
            {
                SystemWriteLog(Ex.Message, true);
            }
            finally
            {
                dialog.Dispose();
            }
        }

        /// <summary>
        /// 清除已加载的上传数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearUpload_Click(object sender, EventArgs e)
        {
            try
            {
                UploadData = null;
                dgvUploadData.DataSource = null;
                crtUpload.DataSource = null;
                crtUpload.DataBind();
            }
            catch (Exception Ex)
            {
                SystemWriteLog(Ex.Message, true);
            }
        }

        /// <summary>
        /// 更新图像显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                crtUpload.DataSource = dgvUploadData.DataSource;
                crtUpload.DataBind();
            }
            catch (Exception Ex)
            {
                SystemWriteLog(Ex.Message, true);
            }
        }

        /// <summary>
        /// 当数据表内容发生改变时自动更新图像显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvUploadData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate_Click(null, null);
        }

        /// <summary>
        /// 取消当前进程的命令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void llbCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                SystemWriteLog("正在取消当前操作...");
                WaitFeedback.CancelAsync();
                UploadCommands.CancelAsync();
            }
            catch (Exception Ex)
            {
                SystemWriteLog(Ex.Message, true);
            }
        }

        /// <summary>
        /// 发送单一指令的命令
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                SerialWrite(tbxSend.Text, cbxSendNewLine.Checked);
            }
            catch (Exception Ex)
            {
                SystemWriteLog(Ex.Message, true);
            }
        }

        /// <summary>
        /// 显示已接收的数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateDownload_Click(object sender, EventArgs e)
        {
            try
            {
                btnClearShow_Click(null, null);
                dgvDownloadData.DataSource = DownloadData.Copy();
                lbShowRowsCount.Text = "显示的数据：" + dgvDownloadData.Rows.Count + " 行数据";
            }
            catch (Exception Ex)
            {
                SystemWriteLog(Ex.Message);
            }
        }

        /// <summary>
        /// 清除接收表显示的内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearShow_Click(object sender, EventArgs e)
        {
            dgvDownloadData.DataSource = null;
            dgvDownloadData.Columns.Clear();
            lbShowRowsCount.Text = "显示的数据：0 行数据";
        }

        /// <summary>
        /// 当状态信息发送变动时记录变动信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbMsg_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SystemWriteLog(lbMsg.Text);
            }
            catch(Exception Ex)
            {
                SystemWriteLog(Ex.Message, true);
            }
        }

        /// <summary>
        /// 边缘容器大小发生改动时记录大小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void splitter_SplitterMoved(object sender, SplitterEventArgs e)
        {
            try
            {
                Splitter splitter = (Splitter)sender;
                Label lb = (Label)splitter.Tag;
                string tag = lb.Tag.ToString().Split('?')[1];
                string[] values = tag.Split(';');
                tag = values[0] + ";";
                Panel pnl = (Panel)Common.WinformControl.FindControl(pnlForm, values[0]);
                tag += pnl.Width + "," + pnl.Height + ";";
                tag += values[2] + ";" + values[3];
                lb.Text = values[3];
                lb.Tag = "0?" + tag;
            }
            catch (Exception Ex)
            {
                SystemWriteLog(Ex.Message, true);
            }

        }

        /// <summary>
        /// 双击时恢复默认大小
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void splitter_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Splitter splitter = (Splitter)sender;
                Label lb = (Label)splitter.Tag;
                string tag = lb.Tag.ToString().Split('?')[1];
                string[] values = tag.Split(';');
                Dictionary<Label, string> dic = new Dictionary<Label, string> { };
                dic.Add(lbUpload, "425,0");
                dic.Add(lbDownload, "800,0");
                dic.Add(lbMessage, "0,170");
                tag = values[0] + ";" + dic[lb] + ";" + values[2] + ";" + values[3];
                lb.Tag = "1?" + tag;
                lbVisible_Click(lb, null);
            }
            catch (Exception Ex)
            {
                SystemWriteLog(Ex.Message, true);
            }
        }

        #endregion

        #region 定时器

        /// <summary>
        /// 当发送或接收处于激活状态时，间隔0.1s后恢复为未激活状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                Timer timer = (Timer)sender;
                timer.Enabled = false;
                if (timer == TimerRx) lbRx.BackColor = UnActiveColor;
                else if (timer == TimerTx) lbTx.BackColor = UnActiveColor;
                else throw new Exception("非法调用控件！");
            }
            catch (Exception Ex)
            {
                SystemWriteLog(Ex.Message, true);
            }
        }

        /// <summary>
        /// 系统时钟，每隔0.5s计算一次上传下载速度，更新显示时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerSys_Tick(object sender, EventArgs e)
        {
            TimeSpan timeSpan = DateTime.Now - StartTime;
            //label1.Text = timeSpan.TotalHours.ToString("00:");
            //label1.Text += timeSpan.Minutes.ToString("00:");
            //label1.Text += timeSpan.Seconds.ToString("00");
            toolStripMenuItem1.Text = "↑：" + GetSize((TxCount - LastUploadData) << 1) + "/s  ↓：" + GetSize((RxCount - LastDownloadData) << 1) + "/s";
            ttpDetailMessage.SetToolTip(lbTx, GetSize(TxCount));
            ttpDetailMessage.SetToolTip(lbRx, GetSize(RxCount));
            lbTotalCount.Text = "总计：" + DownloadData.Rows.Count + " 行数据";
            LastUploadData = TxCount;
            LastDownloadData = RxCount;
        }

        #endregion

    }
}
