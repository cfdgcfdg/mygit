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
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace ComSend
{
    public partial class FrmComSend : Form
    {
        public FrmComSend()
        {
            InitializeComponent();
        }
        string[] m_strarr;
        string m_strAll;
        int m_strLineNum,m_CharNums=0;
        string m_pHead,m_pTail; //包头包尾
        
        private void BtnRead_Click(object sender, EventArgs e)
        {
            string strSep = Regex.Unescape(TxtSeparator.Text);//允许文本框中输入转义字符
            //strSep=strSep.Trim(); 会将转义字符去掉
            string[] strSepArr = strSep.Split(',');
            string strall = File.ReadAllText("aaa.txt");
            if (strSep.Trim() != "")
            {
                m_CharNums = 0;
                m_strarr = strall.Split(strSepArr, StringSplitOptions.RemoveEmptyEntries);
            }
            else
            {
                m_CharNums = Convert.ToInt32(TxtCharNums.Text);
                m_strAll = strall;
            }
            //strSep=strSep.Replace("\\\\","\\");
        }

        private void BtnComOpen_Click(object sender, EventArgs e)
        {
            Dictionary<string, Parity> ComParity = new Dictionary<string, Parity>(){
                { "N", Parity.None },{"O",Parity.Odd},{"E",Parity.Even},{"M",Parity.Mark},{"S",Parity.Space}
            };
            Dictionary<int, StopBits> ComStopBits = new Dictionary<int, StopBits>()            {
                {0,StopBits.None},{1,StopBits.One },{2,StopBits.Two},{3,StopBits.OnePointFive}
            };
            string[] strComSet= TxtComSet.Text.Split(',');
            ComName.BaudRate = Convert.ToInt32(strComSet[0]);
            ComName.Parity = ComParity[strComSet[1]];
            ComName.DataBits = Convert.ToInt32(strComSet[2]);
            ComName.StopBits = ComStopBits[Convert.ToInt32(strComSet[3])];

            if (BtnComOpen.Text == "打开")
            {
                BtnComOpen.Text = "关闭";
                ComName.PortName = TxtComPortName.Text;
                if (!ComName.IsOpen)
                    ComName.Open();
                LabelComStatus.Text = "串口已打开";
            }
            else
            {
                BtnComOpen.Text = "打开";
                //MyComPort.PortName = textBox2.Text;
                if (ComName.IsOpen)
                    ComName.Close();
                LabelComStatus.Text = "串口已关闭";
                Timer1.Enabled = false;
            }

        }

        private void BtnSent_Click(object sender, EventArgs e)
        {
            m_pHead = Regex.Unescape(TxtPackageHead.Text);
            m_pTail = Regex.Unescape(TxtPackageTail.Text);
            Timer1.Interval = Convert.ToInt32(TxtTimeInteval.Text);
            Timer1.Enabled = true;
            m_strLineNum = 0;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (m_CharNums > 0)
            {
                if (m_strLineNum >= m_strAll.Length)
                {
                    Timer1.Enabled = false;
                    return;
                }
                string strsend;
                if(m_strAll.Length-m_strLineNum<m_CharNums)
                    strsend = m_pHead + m_strAll.Substring(m_strLineNum) + m_pTail;
                else
                    strsend = m_pHead + m_strAll.Substring(m_strLineNum, m_CharNums) + m_pTail;
                m_strLineNum += m_CharNums;
                ComName.Write(strsend);
            }
            else
            {
                if (m_strLineNum >= m_strarr.Length)
                {
                    Timer1.Enabled = false;
                    return;
                }
                string strsend = m_pHead + m_strarr[m_strLineNum] + m_pTail;
                m_strLineNum++;
                ComName.Write(strsend);
            }
        }
    }
}
