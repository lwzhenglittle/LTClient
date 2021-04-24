namespace Uninstall {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开AcrylicHostsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注册服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关闭服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AcrylicDNSGUIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.服务ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开AcrylicHostsToolStripMenuItem,
            this.保存ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 打开AcrylicHostsToolStripMenuItem
            // 
            this.打开AcrylicHostsToolStripMenuItem.Name = "打开AcrylicHostsToolStripMenuItem";
            this.打开AcrylicHostsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.打开AcrylicHostsToolStripMenuItem.Text = "打开 Acrylic Hosts";
            this.打开AcrylicHostsToolStripMenuItem.Click += new System.EventHandler(this.打开AcrylicHostsToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 服务ToolStripMenuItem
            // 
            this.服务ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注册服务ToolStripMenuItem,
            this.关闭服务ToolStripMenuItem});
            this.服务ToolStripMenuItem.Name = "服务ToolStripMenuItem";
            this.服务ToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.服务ToolStripMenuItem.Text = "服务";
            // 
            // 注册服务ToolStripMenuItem
            // 
            this.注册服务ToolStripMenuItem.Name = "注册服务ToolStripMenuItem";
            this.注册服务ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.注册服务ToolStripMenuItem.Text = "注册服务";
            this.注册服务ToolStripMenuItem.Click += new System.EventHandler(this.注册服务ToolStripMenuItem_Click);
            // 
            // 关闭服务ToolStripMenuItem
            // 
            this.关闭服务ToolStripMenuItem.Name = "关闭服务ToolStripMenuItem";
            this.关闭服务ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.关闭服务ToolStripMenuItem.Text = "关闭服务";
            this.关闭服务ToolStripMenuItem.Click += new System.EventHandler(this.关闭服务ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于AcrylicDNSGUIToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // 关于AcrylicDNSGUIToolStripMenuItem
            // 
            this.关于AcrylicDNSGUIToolStripMenuItem.Name = "关于AcrylicDNSGUIToolStripMenuItem";
            this.关于AcrylicDNSGUIToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.关于AcrylicDNSGUIToolStripMenuItem.Text = "关于 Acrylic DNS GUI";
            this.关于AcrylicDNSGUIToolStripMenuItem.Click += new System.EventHandler(this.关于AcrylicDNSGUIToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.帮助ToolStripMenuItem.Text = "帮助";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(0, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(800, 388);
            this.listBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "没有指示。";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Acrylic DNS 控制台（服务已安装 & 运行中）（俺爱盗版论坛oreaidaoban.com绿色破解）";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开AcrylicHostsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 服务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注册服务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关闭服务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AcrylicDNSGUIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
    }
}

