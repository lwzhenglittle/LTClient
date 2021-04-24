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
            Thread.Sleep(2000);
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
            Thread.Sleep(5000);
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void FormAbout_Load(object sender, EventArgs e) {
        }
    }
}
