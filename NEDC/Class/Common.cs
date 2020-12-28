using System;
using System.Management;
using System.Security.Cryptography;
using System.Text;

namespace Common
{
    /// <summary>
    /// 窗体控件功能类，用于窗体控件的一些通用函数
    /// </summary>
    public static class WinformControl
    {

        /// <summary>
        /// 在某一控件内寻找名字为ControlName的子控件，
        /// 如果寻找到，返回该控件的对象，
        /// 否则返回null
        /// </summary>
        /// <param name="ParentContainer">所要查找的父控件</param>
        /// <param name="ControlName">所要查找的控件名</param>
        /// <returns></returns>
        public static System.Windows.Forms.Control FindControl(System.Windows.Forms.Control ParentContainer, string ControlName)
        {
            foreach (System.Windows.Forms.Control item in ParentContainer.Controls)
            {
                if (item.Name == ControlName)
                {
                    return item;
                }
                else
                {
                    if (item.Controls.Count > 0)
                    {
                        try
                        {
                            return FindControl(item, ControlName);
                        }
                        catch
                        {
                            continue;
                        }
                    }
                }
            }
            throw new Exception(ParentContainer.Name + " 中可能不包含名称为：" + ControlName + "的控件！");
        }

    }

    /// <summary>
    /// 登陆验证类，用于验证登陆身份是否已在列表中注册
    /// </summary>
    public static class LoginVerification
    {
        /// <summary>
        /// 获取本机的ID，用来匹配与列表中的ID是否匹配
        /// </summary>
        /// <returns></returns>
        private static string GetLocalID()
        {
            try
            {
                string cpuInfo = "";
                MD5 md5 = new MD5CryptoServiceProvider();
                ManagementClass mc = new ManagementClass("Win32_Processor");
                ManagementObjectCollection moc = mc.GetInstances();
                foreach (ManagementObject mo in moc) cpuInfo = mo.Properties["ProcessorId"].Value.ToString();
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
                return byte2String;
            }
            catch (Exception Ex)
            {
                return Ex.Message;
            }
        }

        /// <summary>
        /// 获取登陆成功之后弹出的信息框内容
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="MachineName"></param>
        /// <param name="DeadTime"></param>
        /// <returns></returns>
        private static string LoginOK(string UserName, string MachineName, DateTime DeadTime)
        {
            string Msg = "****************版权信息****************\r\n";
            Msg += "本软件授权：\r\n    " + UserName + "在" + MachineName + "上使用\r\n";
            Msg += "许可到期时间：\r\n    " + DeadTime.ToString("yyyy年MM月dd日\r\n");
            Msg += "\r\n********** 声 明 **********\r\n";
            Msg += "★注意：未经许可严禁复制传播！\r\n";
            Msg += "\r\n********** 作 者 **********\r\n";
            Msg += "邮箱：zzudongxiang@163.com\r\n";
            return Msg;
        }

        /// <summary>
        /// 验证是否能成功登陆
        /// </summary>
        /// <param name="ProjectName">应用程序的名字</param>
        /// <returns></returns>
        public static bool TestCode(string UserCode, string LocalID)
        {
            try
            {
                CspParameters param = new CspParameters();
                param.KeyContainerName = System.Windows.Forms.Application.ProductName;
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(param))
                {
                    byte[] encryptdata = Convert.FromBase64String(UserCode);
                    byte[] decryptdata = rsa.Decrypt(encryptdata, false);
                    UserCode = Encoding.Default.GetString(decryptdata);
                }
                string MachineName = UserCode.Split('@')[0];
                string UserName = UserCode.Split('@')[1];
                string UserKey = UserCode.Split('@')[2];
                DateTime DeadTime = Convert.ToDateTime(UserCode.Split('@')[3]);
                if (UserKey == LocalID)
                {
                    if (DateTime.Now <= DeadTime)
                    {
                        string Info = LoginOK(UserName, MachineName, DeadTime);
                        System.Windows.Forms.MessageBox.Show(Info, "***** 版 权 信 息 *****",
                            System.Windows.Forms.MessageBoxButtons.OK,
                            System.Windows.Forms.MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }

                throw new Exception();
            }
            catch (Exception Ex)
            {
                string a = Ex.Message;
                return false;                           
            }
        }

        public static bool Login()
        {
            try
            {
                string LocalID = GetLocalID();
                foreach (string item in RegisteredUser)
                {
                    if (TestCode(item, LocalID))
                    {
                        return true;
                    }
                }
                throw new Exception("该计算机未获得许可，或许可已到期！\r\n作者：zzudongxiang@163.com");
            }
            catch(Exception Ex)
            {
                System.Windows.Forms.MessageBox.Show(Ex.Message, "错误",
                    System.Windows.Forms.MessageBoxButtons.OK,
                    System.Windows.Forms.MessageBoxIcon.Error);
                return false;
            }
        }

        private static string[] RegisteredUser = new string[]
        {
            //许愿权
            @"AChnbKfbYQNaBLLgNhmqNxfBSPfoy3Ui+KE0Of4OvPzxljJIpUtldP2dPREQAbsNKNhWzXzwKeBzL6/pgF/qsc+t9gt6nE4m62kRySiXD6e6eGpTPjoAB9dXJ1O167run/XeKhN/B0fOKewokKVoqJjJEzg3NTpbY/FhoCiFdsA=",
            //张红旗
            @"NVXue+Y45sQHou6wbosrZw2Uv5uJXBqM5+Qet8qGEpKRzKAiN6EP6DdBcCIZwUl2IB1z2ekQrOYIUTK5KTemb1L9x/c4UD3Q+zH0c+p31RXjZtI5YS3fzX2FgWc/CjlvmP+ACW/9VzxkZ8gU+IM6riPaul583kmiH6qkp4u5d4k=",
            //用户设备1
            @"n7iT7s970nyAw581DzSQn+KL2ZJcZPkWIU8oTGH0KKzTlGpwxqrFVqflxPEKaeBtlBguVkBU8t87F0twFr8qpWow4aPdWtYXZr9HLUJ0gCUg7u/r8yz9J1wr863hGF3kQDEs/T+j+SCdMSt+ELiq6fm8NyaOa+hWZig2tTzNDYQ=",
            //用户设备2
            @"k2NLP8jgbRduh9hJ9LUQdKF9wUKf2LS4ISmbMLzXizYgIsiOAikPhUu3/5s3gZl606fmJakxotc8l/Q2CYs0fClr9G54nte5eMofILBh06usJ6oPvkL+sVA+c71ZJgGqak2fpZJREVJkLzYJ4eJP60MUgXgubnUwqbsFJyGckHM=",
            //用户设备3
            @"DHrrvi9Re/7Ki08I9TS8nfsc0zd9Kl4bWh7L1vwOHyKSOcg755+4HZU6EncV7HCGUKkVM+hccQnlnUq0kkmESJbr/wQMAUvDohzsGQz0tL0Gs7CDanS7jN4lBxZFmJhV1CSolBCZJz6YcJ3jD4b6P8ezbSVpfvwquUcjcumXwSo=",
            //@zzudongxiang的计算机
            @"hiQ97xDq8eNZdx+/X6wfYu6x54QfP2JCd1883whpYQsBZ7r/UdbrkTAxOHP0mguQWF9Yj+dZ9lHh7Z1eyHvzFI+uZbYjsZZOZVgdtk/fYa21ndv77JcwFwLNVpcbJkRmCvuOYJHB30NOWF4z3QCPoiKSgQ7kq6Teyy7fI6W5Jag=",
            //姜宝柱
            @"MESm5AKcMKV6cMfi7BXd+fTV31+/Yl+alLCvweX0LMDY+VuCMQtykhHUjYtcTt+akdJiJQIjiwqq8hW/q2la3/wc/oG0Me2cxabvijX7RKI58qERunQrqJ0peL2hR9eQQVKRfGyZvy7WvyKHLkMLJeOOCyzSC4PdDVJVxg+TRLo=",
        };

    }

}
