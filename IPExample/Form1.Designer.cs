﻿namespace IPExample
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonLocal = new System.Windows.Forms.Button();
            this.buttonRemote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(531, 259);
            this.listBox1.TabIndex = 0;
            // 
            // buttonLocal
            // 
            this.buttonLocal.Location = new System.Drawing.Point(83, 277);
            this.buttonLocal.Name = "buttonLocal";
            this.buttonLocal.Size = new System.Drawing.Size(100, 25);
            this.buttonLocal.TabIndex = 1;
            this.buttonLocal.Text = "显示本机IP信息";
            this.buttonLocal.UseVisualStyleBackColor = true;
            this.buttonLocal.Click += new System.EventHandler(this.buttonLocal_Click);
            // 
            // buttonRemote
            // 
            this.buttonRemote.Location = new System.Drawing.Point(361, 277);
            this.buttonRemote.Name = "buttonRemote";
            this.buttonRemote.Size = new System.Drawing.Size(100, 25);
            this.buttonRemote.TabIndex = 2;
            this.buttonRemote.Text = "显示服务器信息";
            this.buttonRemote.UseVisualStyleBackColor = true;
            this.buttonRemote.Click += new System.EventHandler(this.buttonRemote_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 308);
            this.Controls.Add(this.buttonRemote);
            this.Controls.Add(this.buttonLocal);
            this.Controls.Add(this.listBox1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonLocal;
        private System.Windows.Forms.Button buttonRemote;
    }
}

