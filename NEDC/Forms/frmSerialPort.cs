using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEDC
{
    public partial class frmSerialPort : Form
    {
        public frmSerialPort(SerialPort serialPort)
        {
            InitializeComponent();
            this.serialPort = serialPort;
        }

        /// <summary>
        /// 调用配置好的串口对象
        /// </summary>
        public SerialPort ConfirmSerialPort
        {
            get
            {
                return serialPort;
            }
        }

        /// <summary>
        /// 串口是否已测试连接成功的标志变量
        /// </summary>
        private bool SetOK = false;

        /// <summary>
        /// 显示的圆形图片，一个红色的，一个绿色的
        /// </summary>
        private static Bitmap Red;

        private static Bitmap Green;

        /// <summary>
        /// 窗体加载时，选择默认项并初始化串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmSerialPort_Load(object sender, EventArgs e)
        {
            cbxBaudRate.SelectedIndex = 7;
            cbxDataBits.SelectedIndex = 3;
            cbxParity.SelectedIndex = 0;
            cbxStopBits.SelectedIndex = 1;
            btnUpdate_Click(null, null);
            InitStatus();
            pbxStatus.Image = Red;
        }

        /// <summary>
        /// 初始化两张图片，加载到全局变量中
        /// </summary>
        private void InitStatus()
        {
            int width = Math.Min(pbxStatus.Width, pbxStatus.Height);
            Red = new Bitmap(pbxStatus.Width, pbxStatus.Height);
            Green = new Bitmap(pbxStatus.Width, pbxStatus.Height);
            Graphics Red_g = Graphics.FromImage(Red);
            Graphics Green_g = Graphics.FromImage(Green);
            Red_g.FillEllipse(Brushes.Red, 0, 5, width, width);
            Green_g.FillEllipse(Brushes.Green, 0, 5, width, width);
            Red_g.Dispose();
            Green_g.Dispose();
        }

        /// <summary>
        /// 根据选择的内容设置串口并返回串口对象
        /// </summary>
        /// <returns></returns>
        private SerialPort CreatSP()
        {
            SerialPort sp = new SerialPort(cbxSerialPort.SelectedItem.ToString());
            sp.BaudRate = Convert.ToInt32(cbxBaudRate.SelectedItem.ToString());
            sp.DataBits = Convert.ToInt16(cbxDataBits.SelectedItem.ToString());
            sp.Parity = (Parity)Enum.Parse(typeof(Parity), cbxParity.SelectedItem.ToString());
            sp.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbxStopBits.SelectedItem.ToString());
            return sp;
        }

        /// <summary>
        /// 测试连接的按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTest_Click(object sender, EventArgs e)
        {
            serialPort = CreatSP();
            try
            {
                serialPort.Open();
                serialPort.Close();
                SetOK = true;
                pbxStatus.Image = Green;
            }
            catch (Exception Ex)
            {
                SetOK = false;
                pbxStatus.Image = Red;
                MessageBox.Show("测试失败\r\n" + Ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 确定连接的按钮，如果已测试连接成功，则不再调用测试连接事件，否则调用测试连接事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (SetOK)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                btnTest_Click(null, null);
                if (SetOK)
                {
                    DialogResult = DialogResult.OK;
                }
            }
        }

        /// <summary>
        /// 串口的任何一个属性改变后将重置测试成功标志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetOK = false;
            pbxStatus.Image = Red;
        }

        /// <summary>
        /// 刷新串口列表，列出所有可用的串口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            cbxSerialPort.Items.Clear();
            for (int i = 0; i < 30; i++)
            {
                try
                {
                    SerialPort sp = new SerialPort("COM" + (i + 1).ToString());
                    sp.Open();
                    sp.Close();
                    cbxSerialPort.Items.Add("COM" + (i + 1).ToString());
                }
                catch { }
                if (cbxSerialPort.Items.Count != 0)
                {
                    cbxSerialPort.SelectedIndex = 0;
                }
                else
                {
                    cbxSerialPort.Items.Add("无可用串口");
                    cbxSerialPort.SelectedIndex = 0;
                }
            }
        }
    }
}
