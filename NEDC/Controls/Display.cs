using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NEDC
{
    public partial class Display : UserControl
    {
        public Display()
        {
            InitializeComponent();
        }

        int SelectIndex = 0;

        DataHelper[] data = new DataHelper[14]
        {
            new DataHelper(),//转速
            new DataHelper(),
            new DataHelper(),//扭矩
            new DataHelper(),
            new DataHelper(),//油门
            new DataHelper(),
            new DataHelper(),//电流
            new DataHelper(),
            new DataHelper(),//电压
            new DataHelper(),
            new DataHelper(),//电池
            new DataHelper(),
            new DataHelper(),//温度
            new DataHelper(),
        };

        public void AddPoint(string[] Value)
        {
            try
            {
                for (int i = 0; i < Value.Count(); i++)
                {
                    if (Value[i] == "") Value[i] = "0";
                    data[i].Value.Add(Convert.ToDouble(Value[i]));
                }
                label2.Text = Value[0] + myWave2.Unit;
                label3.Text = Value[2] + myWave3.Unit;
                label5.Text = (Convert.ToDouble(Value[4]) * 100) + myWave4.Unit;
                label7.Text = Value[6] + myWave5.Unit;
                label9.Text = Value[8] + myWave6.Unit;
                label11.Text = (Convert.ToDouble(Value[10]) * 100) + myWave7.Unit;
                label13.Text = Value[12] + myWave8.Unit;
                myWave2.DrawLine(data[0].Value, data[1].Value);
                myWave3.DrawLine(data[2].Value, data[3].Value);
                myWave4.DrawLine(data[4].Value, data[5].Value);
                myWave5.DrawLine(data[6].Value, data[7].Value);
                myWave6.DrawLine(data[8].Value, data[9].Value);
                myWave7.DrawLine(data[10].Value, data[11].Value);
                myWave8.DrawLine(data[12].Value, data[13].Value);
                myWave1.DrawLine(data[SelectIndex << 1].Value, data[1 + (SelectIndex << 1)].Value);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void myWave_Click(object sender, EventArgs e)
        {
            MyWave mw = (MyWave)sender;
            TagHelper th = (TagHelper)mw.Tag;
            Setect(th);
        }

        private void label_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            TagHelper th = (TagHelper)lb.Tag;
            Setect(th);
        }

        private void Setect(TagHelper th)
        {
            label15.Text = th.lbName.Text;
            label16.Text = "  " + th.wave.Unit;
            label17.Text = th.wave.MaxValue.ToString();
            label18.Text = th.wave.MinValue.ToString();
            myWave1.GridColor = th.wave.GridColor;
            myWave1.Clear();
            myWave1.MinValue = th.wave.MinValue;
            myWave1.MaxValue = th.wave.MaxValue;
            myWave1.Unit = th.wave.Unit;
            Clear();
            th.pnl.BackColor = Color.Silver;
            SelectIndex = th.SI;
        }

        private void Clear()
        {
            panel2.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;
            panel8.BackColor = Color.Transparent;
            panel11.BackColor = Color.Transparent;
            panel14.BackColor = Color.Transparent;
            panel17.BackColor = Color.Transparent;
            panel20.BackColor = Color.Transparent;
        }

        private void Display_Load(object sender, EventArgs e)
        {

            label1.Tag = new TagHelper(label1, panel2, myWave2, 0);
            label2.Tag = new TagHelper(label1, panel2, myWave2, 0);
            myWave2.Tag = new TagHelper(label1, panel2, myWave2, 0);

            label3.Tag = new TagHelper(label4, panel5, myWave3, 1);
            label4.Tag = new TagHelper(label4, panel5, myWave3, 1);
            myWave3.Tag = new TagHelper(label4, panel5, myWave3, 1);

            label5.Tag = new TagHelper(label6, panel8, myWave4, 2);
            label6.Tag = new TagHelper(label6, panel8, myWave4, 2);
            myWave4.Tag = new TagHelper(label6, panel8, myWave4, 2);

            label7.Tag = new TagHelper(label8, panel11, myWave5, 3);
            label8.Tag = new TagHelper(label8, panel11, myWave5, 3);
            myWave5.Tag = new TagHelper(label8, panel11, myWave5, 3);

            label9.Tag = new TagHelper(label10, panel14, myWave6, 4);
            label10.Tag = new TagHelper(label10, panel14, myWave6, 4);
            myWave6.Tag = new TagHelper(label10, panel14, myWave6, 4);

            label11.Tag = new TagHelper(label12, panel17, myWave7, 5);
            label12.Tag = new TagHelper(label12, panel17, myWave7, 5);
            myWave7.Tag = new TagHelper(label12, panel17, myWave7, 5);

            label13.Tag = new TagHelper(label14, panel20, myWave8, 6);
            label14.Tag = new TagHelper(label14, panel20, myWave8, 6);
            myWave8.Tag = new TagHelper(label14, panel20, myWave8, 6);

            myWave_Click(myWave2, null);
        }

        //public void ClearUI()
        //{
        //    myWave1.DrawLine(null, null);
        //    myWave2.DrawLine(null, null);
        //    myWave3.DrawLine(null, null);
        //    myWave4.DrawLine(null, null);
        //    myWave5.DrawLine(null, null);
        //    myWave6.DrawLine(null, null);
        //    myWave7.DrawLine(null, null);
        //    myWave8.DrawLine(null, null);
        //}

    }

    public class TagHelper
    {
        public Label lbName;
        public Panel pnl;
        public MyWave wave;
        public int SI = 0;
        public TagHelper(Label lbName, Panel pnl, MyWave wave, int SI) 
        {
            this.lbName = lbName;
            this.pnl = pnl;
            this.wave = wave;
            this.SI = SI;
        }
    }

    public class DataHelper
    {
        public List<double> Value = new List<double> { };
    }
}
