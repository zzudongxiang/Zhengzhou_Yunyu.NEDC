using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEDC
{
    public partial class frmChart : Form
    {
        public frmChart(DataTable DT)
        {
            InitializeComponent();
            crtUpload.Series[0].XValueMember = DT.Columns[0].ColumnName;
            crtUpload.Series[0].YValueMembers = DT.Columns[1].ColumnName;
            crtUpload.Series[1].XValueMember = DT.Columns[0].ColumnName;
            crtUpload.Series[1].YValueMembers = DT.Columns[2].ColumnName;
            crtUpload.DataSource = DT;
            crtUpload.DataBind();
        }

        private void crtUpload_GetToolTipText(object sender, System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs e)
        {
            if (e.HitTestResult.ChartElementType == System.Windows.Forms.DataVisualization.Charting.ChartElementType.DataPoint)
            {
                this.Cursor = Cursors.Cross;
                int i = e.HitTestResult.PointIndex;
                System.Windows.Forms.DataVisualization.Charting.DataPoint dp = e.HitTestResult.Series.Points[i];
                label1.Text = "当前选择的对象：\t" + e.HitTestResult.Series.ChartArea;
                label3.Text = "当前对象的数值：\t" + dp.YValues[0];

            }
            else
            {
                this.Cursor = Cursors.Default;
            }
        }

    }
}
