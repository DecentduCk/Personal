using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace 随机点名
{
    public partial class Form2 : Form
    {
        Point mpoint;
        string[] s = {"郎雅瑞","钱耀胜","钱俊弛","胡云云","严子涵","裴欣然","裴文辉","何昌耀","陈瑞","蔡昊然","宋家乐","贾诗杰","贾荣涵","胡宗杰","晏敏捷","王鑫","裴海峰","冯国庆","陆孝感","贾书婷","赵晶菁","王玲慧","王晶涵","王广涛","蒋爱妍","管毓阳","钱荣博","王子杰","宋祥龙","陶楚涵","毛乐天","郭之霖","徐明运","贾宏康","张牛伟","孙正禹","宋雨晴","林祥东","谢承城","季禹霏","万语晨","申哲宇","聂优","邓子蓉","沈正霞","谢忠诚" };
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "sui";
            await Task.Delay(150);
            label1.Text = "随";
            await Task.Delay(150);
            label1.Text = "随ji";
            await Task.Delay(150);
            label1.Text = "随机";
            await Task.Delay(150);
            label1.Text = "随机dian";
            await Task.Delay(150);
            label1.Text = "随机点";
            await Task.Delay(150);
            label1.Text = "随机点ming";
            await Task.Delay(150);
            label1.Text = "随机点名";
            await Task.Delay(1000);
            label2.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if(label6.Visible==true)
            {
                label6.Visible = false;
                label3.Location = new Point(143, 115);
                label4.Location = new Point(207, 166);
            }
            label3.Text = "是...";
            button1.Enabled = false;
            button1.Font=new Font("微软雅黑", 10);
            button1.Text = "请等待...";
            if(checkBox1.Checked==true)
            {
                Random r1 = new Random();
                int r2 = r1.Next(0, 45);
                label4.Text = s[r2];
                if(r2<10)
                {
                    label4.Text = s[r2 + 8];
                    await Task.Delay(100);
                    label4.Text = s[r2 + 6];
                    await Task.Delay(100);
                    label4.Text = s[r2 + 2];
                    await Task.Delay(100);
                    label4.Text = s[r2 + 1];
                    await Task.Delay(100);
                    label4.Text = s[r2 + 4];
                    await Task.Delay(200);
                    label4.Text = s[r2 + 3];
                    await Task.Delay(200);
                    label4.Text = s[r2 + 5];
                    await Task.Delay(200);
                    label4.Text = s[r2 + 7];
                    await Task.Delay(300);
                    label4.Text = s[r2 + 9];
                    await Task.Delay(400);
                    label4.Text = s[r2 + 10];
                    await Task.Delay(500);
                    label4.Text = s[r2];
                }
                else
                {
                    label4.Text = s[r2 - 8];
                    await Task.Delay(100);
                    label4.Text = s[r2 - 6];
                    await Task.Delay(100);
                    label4.Text = s[r2 - 2];
                    await Task.Delay(100);
                    label4.Text = s[r2 - 1];
                    await Task.Delay(100);
                    label4.Text = s[r2 - 4];
                    await Task.Delay(200);
                    label4.Text = s[r2 - 3];
                    await Task.Delay(200);
                    label4.Text = s[r2 - 5];
                    await Task.Delay(200);
                    label4.Text = s[r2 - 7];
                    await Task.Delay(300);
                    label4.Text = s[r2 - 9];
                    await Task.Delay(400);
                    label4.Text = s[r2 - 10];
                    await Task.Delay(500);
                    label4.Text = s[r2];
                }
            }
            else if (checkBox1.Checked == false)
            {
                int max = 45;
                int rnd = int.MaxValue;
                decimal _base = (decimal)long.MaxValue;
                byte[] rndSeries = new byte[8];
                System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
                rng.GetBytes(rndSeries);
                rnd = (int)
                    (Math.Abs(BitConverter.ToInt64(rndSeries, 0)) / _base * (max + 1));
                if (rnd < 10)
                {
                    label4.Text = s[rnd + 8];
                    await Task.Delay(100);
                    label4.Text = s[rnd + 6];
                    await Task.Delay(100);
                    label4.Text = s[rnd + 2];
                    await Task.Delay(100);
                    label4.Text = s[rnd + 1];
                    await Task.Delay(100);
                    label4.Text = s[rnd + 4];
                    await Task.Delay(200);
                    label4.Text = s[rnd + 3];
                    await Task.Delay(200);
                    label4.Text = s[rnd + 5];
                    await Task.Delay(200);
                    label4.Text = s[rnd + 7];
                    await Task.Delay(300);
                    label4.Text = s[rnd + 9];
                    await Task.Delay(400);
                    label4.Text = s[rnd + 10];
                    await Task.Delay(500);
                    label4.Text = s[rnd];
                }
                else
                {
                    label4.Text = s[rnd - 8];
                    await Task.Delay(100);
                    label4.Text = s[rnd - 6];
                    await Task.Delay(100);
                    label4.Text = s[rnd - 2];
                    await Task.Delay(100);
                    label4.Text = s[rnd - 1];
                    await Task.Delay(100);
                    label4.Text = s[rnd - 4];
                    await Task.Delay(200);
                    label4.Text = s[rnd - 3];
                    await Task.Delay(200);
                    label4.Text = s[rnd - 5];
                    await Task.Delay(200);
                    label4.Text = s[rnd - 7];
                    await Task.Delay(300);
                    label4.Text = s[rnd - 9];
                    await Task.Delay(400);
                    label4.Text = s[rnd - 10];
                    await Task.Delay(500);
                    label4.Text = s[rnd];
                }
            }
                await Task.Delay(500);
                label3.Location = new Point(27, 132);
                label4.Location = new Point(356, 133);
                Random sr = new Random();
                int sr1 = sr.Next(1, 3);
            label3.Text = "恭喜这位同学被抽中！";
            label6.Visible = true;
            switch(sr1)
            {
                case 1:
                    label6.Text="太幸运了 这可是2.1%的几率啊！";
                
                break;
                case 2:
                label6.Text = "你应该去买彩票才对...";
                break;
                case 3:
                label6.Text = "你今天做了什么好事吗？";
                break;
            }
                await Task.Delay(50);
                button1.Text = "点名—3s";
                await Task.Delay(1000);
                button1.Text = "点名—2s";
                await Task.Delay(1000);
                button1.Text = "点名—1s";
                await Task.Delay(1000);
                button1.Font = new Font("微软雅黑", 15);
                button1.Enabled = true;
                button1.Text = "点名";
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);


        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mpoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mpoint.X, this.Location.Y + e.Y - mpoint.Y);
            }
        }
    }
}
