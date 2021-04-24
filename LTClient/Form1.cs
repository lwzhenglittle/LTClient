using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Uninstall {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void 关于AcrylicDNSGUIToolStripMenuItem_Click(object sender, EventArgs e) {
            AboutBox1 formAbout = new AboutBox1();
            formAbout.ShowDialog();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e) {
            HelpBox helpBox = new HelpBox();
            helpBox.ShowDialog();
        }

        private void 关闭服务ToolStripMenuItem_Click(object sender, EventArgs e) {
            this.label1.Text = "执行关闭服务中...";
            FormAbout formCloseService = new FormAbout();
            formCloseService.ShowDialog();
            this.label1.Text = "服务停止运行。";
        }

        private void button1_Click(object sender, EventArgs e) {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void 打开AcrylicHostsToolStripMenuItem_Click(object sender, EventArgs e) {
            this.label1.Text = "已打开HOSTS。";
            this.listBox1.Items.Add("127.0.0.1      >baidu.com");
            this.listBox1.Items.Add("127.0.0.1      >qq.com");
            this.listBox1.Items.Add("127.0.0.1      >huya.com");
            this.listBox1.Items.Add("127.0.0.1      >douyu.com");
            this.listBox1.Items.Add("127.0.0.1      >163.com");
            this.listBox1.Items.Add("127.0.0.1      >live.bilibili.com");
            this.listBox1.Items.Add("127.0.0.1      >google.com");
            this.listBox1.Items.Add("127.0.0.1      >360.cn");
            this.listBox1.Items.Add("127.0.0.1      >dongqiudi.com");
            this.listBox1.Items.Add("127.0.0.1      >sina.com");
            this.listBox1.Items.Add("127.0.0.1      >weibo.com");
            this.listBox1.Items.Add("127.0.0.1      >sina.cn");
            this.listBox1.Items.Add("127.0.0.1      >sina.com.cn");
            this.listBox1.Items.Add("127.0.0.1      >shogun.fu");
            this.listBox1.Items.Add("127.0.0.1      >press.cao");
            this.listBox1.Items.Add("127.0.0.1      >party.cao");
            this.listBox1.Items.Add("127.0.0.1      >shimbun.cao");
        }

        private void 注册服务ToolStripMenuItem_Click(object sender, EventArgs e) {
            this.label1.Text = "检查服务状态中...";
            Task.Delay(1000).Wait();
            this.label1.Text = "已经注册过服务！";
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e) {
            this.label1.Text = "保存。";
        }
    }
}
