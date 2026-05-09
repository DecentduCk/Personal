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
using System.IO;
using System.Diagnostics;

namespace 随机点名
{
    public partial class Form2 : Form
    {
        Point mpoint;
        string[] s = File.ReadAllLines(Path.GetFullPath(File.ReadAllText("C:\\Users\\Administrator\\Documents\\dcdm\\001").ToString()));
        int zt=-1;
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = "随机点名";
            if(s.Length<=19)
            {
                checkBox1.Visible = false;
                checkBox3.Checked = true;
                checkBox3.Visible = false;
                numericUpDown1.Value = timer1.Interval;
                panel2.Visible = true;
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private async void button1_Click(object sender, EventArgs e)
        {
             
            if (checkBox3.Checked == true)
            {
                if (button1.Text == "点名")
                {
                    button1.Text = "暂停";
                    timer1.Start();
                }
                else if (button1.Text == "暂停")
                {
                    button1.Text = "点名";
                    timer1.Stop();
                }
            }
            else if (checkBox3.Checked == false)
            {
                if (label6.Visible == true)
                {
                    label6.Visible = false;
                    label3.Location = new Point(143, 115);
                    label4.Location = new Point(207, 166);
                }
                label3.Text = "是...";
                button1.Enabled = false;
                button1.Font = new Font("微软雅黑", 10);
                button1.Text = "请等待...";
                if (checkBox1.Checked == true)
                {
                    Random r1 = new Random();
                    int r2 = r1.Next(0, s.Length);
                    if (r2 < 10)
                    {
                        label4.Text = s[r2 + 8];
                        await Task.Delay(50);
                        label4.Text = s[r2 + 6];
                        await Task.Delay(50);
                        label4.Text = s[r2 + 2];
                        await Task.Delay(50);
                        label4.Text = s[r2 + 1];
                        await Task.Delay(50);
                        label4.Text = s[r2 + 4];
                        await Task.Delay(50);
                        label4.Text = s[r2 + 3];
                        await Task.Delay(100);
                        label4.Text = s[r2 + 5];
                        await Task.Delay(200);
                        label4.Text = s[r2 + 7];
                        await Task.Delay(300);
                        label4.Text = s[r2 + 9];
                        await Task.Delay(400);
                        label4.Text = s[r2 + 10];
                        await Task.Delay(800);
                        label4.Text = s[r2];
                    }
                    else
                    {
                        label4.Text = s[r2 - 8];
                        await Task.Delay(50);
                        label4.Text = s[r2 - 6];
                        await Task.Delay(50);
                        label4.Text = s[r2 - 2];
                        await Task.Delay(50);
                        label4.Text = s[r2 - 1];
                        await Task.Delay(50);
                        label4.Text = s[r2 - 4];
                        await Task.Delay(50);
                        label4.Text = s[r2 - 3];
                        await Task.Delay(100);
                        label4.Text = s[r2 - 5];
                        await Task.Delay(200);
                        label4.Text = s[r2 - 7];
                        await Task.Delay(300);
                        label4.Text = s[r2 - 9];
                        await Task.Delay(400);
                        label4.Text = s[r2 - 10];
                        await Task.Delay(800);
                        label4.Text = s[r2];
                    }
                }
                else if (checkBox1.Checked == false)
                {
                    int max = s.Length-1;
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
                label3.Text = "恭喜这位同学被抽中！";
                label6.Visible = true;
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

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Red;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.Black;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox2.Checked==true)
            {
                this.TopMost = true;
            }
            else if(checkBox2.Checked==false)
            {
                this.TopMost = false;
            }
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            label9.ForeColor = Color.Red;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            label9.ForeColor = Color.Black;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox3.Checked==true)
            {
                numericUpDown1.Value = timer1.Interval;
                checkBox1.Visible = false;
                panel2.Visible = true;
            }
            else if(checkBox3.Checked==false)
            {
                checkBox1.Visible = true;
                panel2.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = s[zt+1];
            zt++;
            if(label4.Text==s[s.Length-1])
            {
                zt = -1;
            }
        }

        private void label4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("选择文件后请不要对选择的文件进行操作\n 如移动 删除等");
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Title = "请选择txt文件";
            if(ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                string path = ofd.FileName;
                File.WriteAllText("C:\\Users\\Administrator\\Documents\\dcdm\\001", path);
                File.Create("C:\\Users\\Administrator\\Documents\\dcdm\\prepare");
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Interval = Convert.ToInt32(numericUpDown1.Value);
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
    }
}
