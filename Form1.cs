using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace 插值小程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<double> xuLieList = new List<double>();
        private void btn_StartInterpolate_Click(object sender, EventArgs e)
        {
            double interlopStartIndex = Convert.ToDouble(tbx_StartIndex.Text.Trim());
            double interlopJianju = Convert.ToDouble( tbx_InterpolateJianju.Text.Trim());
            bool isContainIni = cbx_IsContainInitialData.Checked;
           
           
            //string[] iniData = rtbx_InitialData.Lines;
            string[] iniData = rtbx_InitialData.Lines;
            
            //MessageBox.Show("{}");
            SortedList<double, double> iniDataSList = new SortedList<double, double>();
            for(int i=0; i<iniData.Count();i++)
            {
                if (iniData[i] == "") continue;
            
                string[] tempstr = iniData[i].Split(new char[] { ' ',',','_','\t'},StringSplitOptions.RemoveEmptyEntries);
                if (tempstr.Count() != 2)
                {
                    MessageBox.Show("第" + (i + 1).ToString() + "行数据有问题请检查！索引号为" + tempstr[0]);
                    return;
                }
                double indexTmp = Convert.ToDouble(tempstr[0]);

                if (iniDataSList.ContainsKey(indexTmp))
                {
                    MessageBox.Show("第" + (i + 1).ToString() + "行数据与以前行重复请检查！索引号为" + tempstr[0]);
                    return;
                }
                iniDataSList.Add(Convert.ToDouble(tempstr[0]), Convert.ToDouble(tempstr[1]));
            }


            SortedList<double, double> resultDataSList = new SortedList<double, double>();
            for (double index=interlopStartIndex;index<iniDataSList.Keys[iniDataSList.Count-1];index=index+interlopJianju)
            {
                for(int inner=0;inner<iniDataSList.Count-1;inner++)
                {
                    if(index==iniDataSList.Keys[inner])
                    {
                        if (resultDataSList.ContainsKey(index)) break;
                        resultDataSList.Add(iniDataSList.Keys[inner],Math.Round( iniDataSList.Values[inner],4));

                    }
                    else if (index > iniDataSList.Keys[inner]&& index<iniDataSList.Keys[inner+1])
                    {
                        if (resultDataSList.ContainsKey(index)) break;

                        double tempResult = iniDataSList.Values[inner] + (iniDataSList.Values[inner + 1] - iniDataSList.Values[inner]) /(iniDataSList.Keys[inner+1] - iniDataSList.Keys[inner]) * (index - iniDataSList.Keys[inner]);
                        resultDataSList.Add(index, Math.Round( tempResult,4));
                    }
                }
            }

            if(isContainIni)
            {
                foreach(var temp in iniDataSList)
                {
                    if(!resultDataSList.ContainsKey(temp.Key))
                    {
                        resultDataSList.Add(temp.Key,temp.Value);
                    }
                }
            }


            List<string> resultList = new List<string>();
            foreach(var temp in resultDataSList)
            {
                resultList.Add(temp.Key.ToString()+"\t"+temp.Value.ToString());
            }

            rtbx_InterolatedData.Lines=resultList.ToArray();
        }

        private void btn_rtbx_ClearInitialData_Click(object sender, EventArgs e)
        {
            rtbx_InitialData.Clear();
        }

        private void btn_ClearXuLie_Click(object sender, EventArgs e)
        {
            rtbx_xulie.Clear();
        }

        private void btn_rtbx_InterpolatedData_Click(object sender, EventArgs e)
        {
            rtbx_InterolatedData.Clear();
        }

        private void btn_CreateXuLie_Click(object sender, EventArgs e)
        {
            double interlopStartIndex = Convert.ToDouble(tbx_StartIndex.Text.Trim());
            double interlopJianju = Convert.ToDouble(tbx_InterpolateJianju.Text.Trim());
            bool isContainIni = cbx_IsContainInitialData.Checked;

            //SortedList<double, double> resultDataSList = new SortedList<double, double>();
            for (double index = interlopStartIndex; index < iniDataSList.Keys[iniDataSList.Count - 1]; index = index + interlopJianju)
            {
                for (int inner = 0; inner < iniDataSList.Count - 1; inner++)
                {
                    if (index == iniDataSList.Keys[inner])
                    {
                        if (resultDataSList.ContainsKey(index)) break;
                        resultDataSList.Add(iniDataSList.Keys[inner], Math.Round(iniDataSList.Values[inner], 4));

                    }
                    else if (index > iniDataSList.Keys[inner] && index < iniDataSList.Keys[inner + 1])
                    {
                        if (resultDataSList.ContainsKey(index)) break;

                        double tempResult = iniDataSList.Values[inner] + (iniDataSList.Values[inner + 1] - iniDataSList.Values[inner]) / (iniDataSList.Keys[inner + 1] - iniDataSList.Keys[inner]) * (index - iniDataSList.Keys[inner]);
                        resultDataSList.Add(index, Math.Round(tempResult, 4));
                    }
                }
            }

            if (isContainIni)
            {
                foreach (var temp in iniDataSList)
                {
                    if (!resultDataSList.ContainsKey(temp.Key))
                    {
                        resultDataSList.Add(temp.Key, temp.Value);
                    }
                }
            }



        }
    }
}
