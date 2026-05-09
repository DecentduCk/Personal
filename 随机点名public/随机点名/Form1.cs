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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("选择文件后请不要对选择的文件进行操作\n 如移动 删除等");
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = false;
            ofd.Title = "请选择txt文件";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string path = ofd.FileName;
                try
                {
                    File.WriteAllText("C:\\Users\\Administrator\\Documents\\dcdm\\001", path);
                    File.Create("C:\\Users\\Administrator\\Documents\\dcdm\\prepare");
                }
                catch
                {
                    DialogResult dr2 = MessageBox.Show("失败\n 可能原因：\n 1.文件被占用 ", "失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                MessageBox.Show("成功");
                label5.Text = Path.GetFileName(path);
                label5.Visible = true;
                button2.Visible = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists("C:\\Users\\Administrator\\Documents\\dcdm"))
                {
                    Directory.CreateDirectory("C:\\Users\\Administrator\\Documents\\dcdm");
                    if (!Directory.Exists("C:\\Users\\Administrator\\Documents\\dcdm\\001"))
                    {
                        File.Create("C:\\Users\\Administrator\\Documents\\dcdm\\001");
                        MessageBox.Show("初始化完毕，请重新启动！");
                        System.Environment.Exit(0);
                    }
                }
                else if (Directory.Exists("C:\\Users\\Administrator\\Documents\\dcdm"))
                {

                    if (!File.Exists("C:\\Users\\Administrator\\Documents\\dcdm\\001"))
                    {
                        File.Create("C:\\Users\\Administrator\\Documents\\dcdm\\001");
                    }
                }
            }
            catch
            {
                DialogResult dr1 = MessageBox.Show("程序访问异常，请尝试授予管理员权限", "异常", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Black;
        }
    }
}
