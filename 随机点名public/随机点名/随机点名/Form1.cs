using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 随机点名
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await Task.Delay(50);
            label1.Text = "—                                        5%";
            await Task.Delay(200);
            label1.Text = "———                                   15%";
            await Task.Delay(450);  
            label1.Text = "———————                           40%";
            await Task.Delay(450);
            label1.Text = "—————————————               70%";
            await Task.Delay(250);
            label1.Text = "————————————————         85%";
            await Task.Delay(80); 
            label1.Text = "————————————————         86%";
            await Task.Delay(80);
            label1.Text = "————————————————         87%";
            await Task.Delay(80);
            label1.Text = "————————————————         88%";
            await Task.Delay(80);
            label1.Text = "————————————————         89%";
            await Task.Delay(80);
            label1.Text = "—————————————————       90%";
            await Task.Delay(80);
            label1.Text = "—————————————————       91%";
            await Task.Delay(80);
            label1.Text = "—————————————————       92%";
            await Task.Delay(80);
            label1.Text = "—————————————————       93%";
            await Task.Delay(80);
            label1.Text = "—————————————————       94%";
            await Task.Delay(80);
            label1.Text = "——————————————————     95%";
            await Task.Delay(80);
            label1.Text = "——————————————————     96%";
            await Task.Delay(80);
            label1.Text = "——————————————————     97%";
            await Task.Delay(150);
            label1.Text = "———————————————————   100%";
            label3.Location = new Point(180, 25);
            label4.Visible = true;
            await Task.Delay(1500);
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
