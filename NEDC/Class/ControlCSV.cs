using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEDC
{
    public static class ControlCSV
    {
        public static DataTable OpenUploadFile(string filePath)
        {
            if (!File.Exists(filePath)) throw new Exception("文件路径：" + filePath + "不存在！");
            Encoding encoding = Encoding.Default;
            DataTable dt = new DataTable();
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, encoding);
            string strLine = "";
            string[] aryLine = null;
            string[] tableHead = null;
            int columnCount = 0;
            int RowCount = 1;
            bool IsFirst = true;
            while ((strLine = sr.ReadLine()) != null)
            {
                if (IsFirst == true)
                {
                    tableHead = strLine.Split(',');
                    IsFirst = false;
                    columnCount = tableHead.Length;
                    if (columnCount != 3)
                    {
                        sr.Close();
                        fs.Close();
                        dt.Dispose();
                        throw new Exception("要求所打开的文件为3列！\r\n本文件包含：" + columnCount + "列数据！");
                    }
                    string[] LimiteName = { "序号", "转速", "扭矩" };
                    for (int i = 0; i < columnCount; i++)
                    {
                        if (tableHead[i] != LimiteName[i])
                        {
                            sr.Close();
                            fs.Close();
                            dt.Dispose();
                            throw new Exception("要求第" + (i + 1).ToString() + "列的列名为:" + LimiteName[i]);
                        }
                        DataColumn dc = new DataColumn(tableHead[i]);
                        dt.Columns.Add(dc);
                    }
                }
                else
                {
                    aryLine = strLine.Split(',');
                    DataRow dr = dt.NewRow();
                    if (aryLine[0] != (RowCount++).ToString())
                    {
                        if (dr[0].ToString() == string.Empty) continue;
                        sr.Close();
                        fs.Close();
                        dt.Dispose();
                        throw new Exception((RowCount - 1) + ":行标号出现错误\r\n错误的行号：" + aryLine[0]);
                    }
                    for (int j = 0; j < columnCount; j++)
                    {
                        dr[j] = aryLine[j];
                    }
                    dt.Rows.Add(dr);
                }
            }
            sr.Close();
            fs.Close();
            return dt;
        }

        public static void SaveDownloadData(string filePath, DataTable dataTable)
        {
            FileInfo fi = new FileInfo(filePath);
            if (!fi.Directory.Exists)
                fi.Directory.Create();
            FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            try
            {
                string data = "";
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    data += dataTable.Columns[i].ColumnName;
                    if (i < dataTable.Columns.Count - 1)
                    {
                        data += ",";
                    }
                }
                sw.WriteLine(data);
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    data = "";
                    for (int j = 0; j < dataTable.Columns.Count; j++)
                    {
                        string str = dataTable.Rows[i][j].ToString();
                        str = str.Replace("\"", "\"\"");
                        if (str.Contains(',') || str.Contains('"')
                            || str.Contains('\r') || str.Contains('\n'))
                        {
                            str = string.Format("\"{0}\"", str);
                        }

                        data += str;
                        if (j < dataTable.Columns.Count - 1)
                        {
                            data += ",";
                        }
                    }
                    sw.WriteLine(data);
                }
            }
            catch (Exception Ex)
            {
                throw Ex;
            }
            finally
            {
                sw.Close();
                fs.Close();
            }
        }
    }
}
