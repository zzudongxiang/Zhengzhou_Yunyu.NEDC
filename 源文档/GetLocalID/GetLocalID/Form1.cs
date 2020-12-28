using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetLocalID
{
    public partial class Form1 : Form
    {
        string Key = "";
        public Form1(string Key)
        {
            InitializeComponent();
            this.Key = Key;
            if (this.Key == "") this.Key = "zzudongxiang@163.com";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = GetLocalID();
            Text += "--适用于 " + Key + " 项目";
        }

        private string GetLocalID()
        {
            try
            {
                string cpuInfo = "";
                MD5 md5 = new MD5CryptoServiceProvider();
                ManagementClass mc = new ManagementClass("Win32_Processor");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc) cpuInfo = mo.Properties["ProcessorId"].Value.ToString();
                CspParameters param = new CspParameters();
                param.KeyContainerName = Key;
                moc = null;
                mc = null;
                cpuInfo += "_" + Environment.MachineName + "_" + Environment.UserName;
                byte[] fromData = Encoding.Unicode.GetBytes(cpuInfo);
                byte[] targetData = md5.ComputeHash(fromData);
                string byte2String = null;
                for (int i = 0; i < targetData.Length; i++)
                {
                    if (i != 0 && i % 2 == 0) byte2String += "-";
                    byte2String += targetData[i].ToString("X2");
                }
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(param))
                {
                    byte[] plaindata = Encoding.Default.GetBytes(Environment.MachineName + "@" + Environment.UserName + "@" + byte2String + "@" + DateTime.Now.AddYears(3).ToString("yyyy/MM/dd"));
                    byte[] encryptdata = rsa.Encrypt(plaindata, false);
                    return Convert.ToBase64String(encryptdata);
                }
            }
            catch (Exception Ex)
            {
                return Ex.Message;
            }
        }       


        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(textBox1.Text);
            timer1.Enabled = true;
            label3.Visible = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Visible = false;
            timer1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

