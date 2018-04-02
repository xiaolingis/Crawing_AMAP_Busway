using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Collections;

namespace Crawing_Amap_Busway
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList cityNameList = new ArrayList();
        ArrayList cityCodeList = new ArrayList();
        string[] str_Array;
        string[] tmp_Array;
        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream cityCodefs = new FileStream("AMap_adcode_citycode.csv", FileMode.Open);
            StreamReader sr = new StreamReader(cityCodefs,Encoding.UTF8);
            string aryline;
            while ((aryline = sr.ReadLine()) != null)
            {
                string[] tmp = aryline.Split(',');
                if (tmp[0].Substring(tmp[0].Length - 1,1) == "市")
                {
                    if (tmp[1].Length < 3)
                    {
                        tmp[1] = "0" + tmp[1];
                    }
                    cityNameList.Add(tmp[0]);
                    cityCodeList.Add(tmp[1]);
                }
            }

            sr.Close();
            cityCodefs.Close();



        }


        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "csv文件|*.*|csv文件|*.csv|所有文件|*.*";
            dlg.Title = "选择输出文件";
            dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            FileStream Output_fs = null;
            StreamWriter sw = null;
            string cityName = CityName_Text.Text;
            string cityCode = "010";
            bool flag = false;
            foreach (string cyName in cityNameList)
            {
                if (cyName == cityName)
                {
                    cityCode = (string)cityCodeList[cityNameList.IndexOf(cyName)];
                    flag = true;
                    break;
                }
            }
            if (flag == false)
            {
                MessageBox.Show("输入城市名有误，请重新确认!", "错误!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string keyWords = KeyWords_Text.Text;
            string url = string.Format("https://www.amap.com/service/poiInfo?query_type=TQUERY&pagesize=20&pagenum=1&qii=true&cluster_state=5&need_utd=true&utd_sceneid=1000&div=PC1000&addr_poi_merge=true&is_classify=true&zoom=17&city={0}&keywords={1}", cityCode, keyWords);
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(url);
            req.Method = "GET";
            WebResponse wr = req.GetResponse();
            
            //在这里对接收到的页面内容进行处理
            System.IO.Stream respStream = wr.GetResponseStream();
            System.IO.StreamReader reader = new System.IO.StreamReader(respStream, Encoding.UTF8);
            str_Array = reader.ReadToEnd().Split('{');
            string xSum = "", ySum = "";
            string bWayName = "";
            int time = 0;
            for (int i = 16; i < str_Array.Length; i++)
            {
                tmp_Array = str_Array[i].Split('"');
                for (int j = 0; j < tmp_Array.Length; j++)
                {
                    if (tmp_Array[j] == "front_name")       //抓取路径信息
                    {
                        time++;
                        if (time > 2)
                            return;
                        j++;
                        while (j < tmp_Array.Length)
                        {
                            if (tmp_Array[j] == "xs")
                            {
                                j += 2;
                                xSum = tmp_Array[j];
                            }
                            else if (tmp_Array[j] == "ys")
                            {
                                j+=2;
                                ySum = tmp_Array[j];
                            }
                            else if (tmp_Array[j] == "name")
                            {
                                j += 2;
                                bWayName = tmp_Array[j];

                                Output_fs = new FileStream(dlg.FileName, FileMode.Open);
                                sw = new StreamWriter(Output_fs, Encoding.UTF8);
                                sw.BaseStream.Seek(0, SeekOrigin.End);
                                sw.WriteLine(bWayName);
                                sw.WriteLine(xSum);
                                sw.WriteLine(ySum);
                                sw.Close();
                                Output_fs.Close();
                                break;
                            }
                            j++;
                        }
                        break;
                    }
                    else                                    // 抓取站点信息
                    {

                    }
                }

            }


                //MessageBox.Show(str_Array[10]);
            
        }
    }
}
