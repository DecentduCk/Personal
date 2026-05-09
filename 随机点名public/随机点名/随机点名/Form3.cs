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
    public partial class Form3 : Form
    {
        Point mpoint;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "随机的算法并非Random类\n 而是System.Security.Cryptography命名空间下的\n system.Security.Cryptography.ENGCryptoServiceProvider类\n 这样会使随机数的质量变高\n 如果是Random类会有大量重复名单\n \n 学生姓名存储在string数组里";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mpoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mpoint.X, this.Location.Y + e.Y - mpoint.Y);
            }   
        }
    }
}
