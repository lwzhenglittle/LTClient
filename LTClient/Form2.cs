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
    public partial class FormAbout : Form {
        public FormAbout() {
            InitializeComponent();
            Task.Delay(2000).Wait();
            this.label1.Text = "OK!";
            this.buttonAcceptAbout.Enabled = true;
        }

        protected override void OnClosing(CancelEventArgs e) {
            e.Cancel = true; //取消关闭操作
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void buttonAcceptAbout_Click(object sender, EventArgs e) {
            this.Hide();
            Task.Delay(5000).Wait();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void FormAbout_Load(object sender, EventArgs e) {
        }
    }
}
