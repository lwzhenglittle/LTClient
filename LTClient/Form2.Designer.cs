﻿namespace Uninstall {
    partial class FormAbout {
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
            this.buttonAcceptAbout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAcceptAbout
            // 
            this.buttonAcceptAbout.Enabled = false;
            this.buttonAcceptAbout.Location = new System.Drawing.Point(322, 168);
            this.buttonAcceptAbout.Name = "buttonAcceptAbout";
            this.buttonAcceptAbout.Size = new System.Drawing.Size(104, 48);
            this.buttonAcceptAbout.TabIndex = 0;
            this.buttonAcceptAbout.Text = "好";
            this.buttonAcceptAbout.UseVisualStyleBackColor = true;
            this.buttonAcceptAbout.Click += new System.EventHandler(this.buttonAcceptAbout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "关闭中。";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 238);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAcceptAbout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.Text = "关闭服务";
            this.Load += new System.EventHandler(this.FormAbout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAcceptAbout;
        private System.Windows.Forms.Label label1;
    }
}