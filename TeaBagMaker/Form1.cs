using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TeaBagMaker
{
    public partial class TeaBagMaker : Form
    {
        String[] tList = new string[] { "홍차", "녹차", "루이보스차", "국화차" };
        String orgStr = "";
        int time2 = 0;
        int CountOrgNum = 0; // 초기 카운터
        public TeaBagMaker()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.teaList.Text != "") 
            {
                if (this.teaList.Equals(tList[0]))
                {
                    time2 = 2;
                }
                else if (this.teaList.Equals(tList[1]))
                {
                    time2 = 3;
                }
                else if (this.teaList.Equals(tList[2]))
                {
                    time2 = 5;
                }
                else {
                    time2 = 2;
                }
                this.time.Text = orgStr + this.teaList.Text+"의 시간은"+time2+"입니다";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < tList.Length; i++)
            {
                this.teaList.Items.Add(tList[i]);
            }

        }

    }
}
