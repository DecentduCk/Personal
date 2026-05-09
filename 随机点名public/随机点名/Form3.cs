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
using System.Diagnostics;

namespace 随机点名
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr1=MessageBox.Show("你确定要重置吗\n 重置后需重新选择文件","重置确认",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(dr1==DialogResult.Yes)
            {
                try
                {
                    Directory.Delete("C:\\Users\\Administrator\\Documents\\dcdm", true);
                }
                catch
                {
                    DialogResult dr2 = MessageBox.Show("重置失败\n 可能原因：\n 1.程序未授予管理员权限\n 2.文件夹被占用 请稍后重试 ", "重置失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    System.Environment.Exit(0);
                }
                if(!Directory.Exists("C:\\Users\\Administrator\\Documents\\dcdm"))
                {
                    DialogResult dr2=MessageBox.Show("重置完成 即将退出","重置完成",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    System.Environment.Exit(0);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start(Path.GetFullPath(File.ReadAllText("C:\\Users\\Administrator\\Documents\\dcdm\\001").ToString()));
        }
    }
}
