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
    public partial class Form3 : Form {
        public Boolean isOK = false;
        public Form3() {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.pictureBox1.BackgroundImage = Uninstall.Resource1.lt;
            this.axWindowsMediaPlayer1.settings.volume = 100;
            this.axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void Form3_Load(object sender, EventArgs e) {

        }
        protected override void OnClosing(CancelEventArgs e) {
            e.Cancel = !isOK; //取消关闭操作
        }

        private void button1_Click(object sender, EventArgs e) {
            this.button1.Text = "请求中。";
            this.button1.Enabled = false;
            Task.Delay(10000).Wait();
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            this.button1.Text = "已批准。";
            Task.Delay(2000).Wait();
            this.button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e) {
            isOK = true;
            this.Close();
            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e) {

        }
    }
}
