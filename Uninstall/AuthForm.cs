using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uninstall {
    public partial class AuthForm : Form {
        public Boolean isOK = false;
        public int a, b, c, f;
        public String baguaGen;
        public AuthForm() {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void AuthForm_Load(object sender, EventArgs e) {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            int i = rnd.Next(300);//括号中的值可按实际需要而定
            DateTime d = DateTime.Now - new TimeSpan(i);//使用加法或减法依需要而定，也不一定以当前时间为基数
            this.label3.Text = d.ToString("F");
            Random rnd2 = new Random((int)DateTime.Now.Ticks);
            a = rnd2.Next(2);
            b = rnd2.Next(2);
            c = rnd2.Next(2);
            f = rnd2.Next(2);
            this.label4.Text = a.ToString() + b.ToString() + c.ToString() + f.ToString();
            baguaGen = this.label4.Text;
        }
        protected override void OnClosing(CancelEventArgs e) {
            e.Cancel = !isOK; 
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            bool isBaguaOK = false;
            if (baguaGen == "0111" && this.dui.Checked ||
                baguaGen == "0011" && this.qian.Checked||
                baguaGen == "0010" && this.xun.Checked ||
                baguaGen == "0001" && this.kan.Checked ||
                baguaGen == "0000" && this.gen.Checked ||
                baguaGen == "0100" && this.kun.Checked ||
                baguaGen == "0101" && this.zhen.Checked||
                baguaGen == "0110" && this.li.Checked  ||
                baguaGen == "1101" && this.xun.Checked ||
                baguaGen == "1000" && this.li.Checked  ||
                baguaGen == "1110" && this.kun.Checked ||
                baguaGen == "1111" && this.dui.Checked ||
                baguaGen == "1010" && this.qian.Checked||
                baguaGen == "1001" && this.kan.Checked ||
                baguaGen == "1100" && this.gen.Checked ||
                baguaGen == "1011" && this.zhen.Checked
                ) isBaguaOK = true;
            if (this.checkBox7.Checked && this.checkBox19.Checked && isBaguaOK) isOK = true;
            Close();
        }
    }
}
