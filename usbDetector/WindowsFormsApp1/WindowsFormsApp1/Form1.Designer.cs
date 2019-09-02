namespace WindowsFormsApp1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txb_srcPath = new System.Windows.Forms.TextBox();
            this.btn_src = new System.Windows.Forms.Button();
            this.txb_dstPath = new System.Windows.Forms.TextBox();
            this.btn_dst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(66, 318);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // txb_srcPath
            // 
            this.txb_srcPath.Location = new System.Drawing.Point(66, 13);
            this.txb_srcPath.Name = "txb_srcPath";
            this.txb_srcPath.Size = new System.Drawing.Size(270, 21);
            this.txb_srcPath.TabIndex = 1;
            // 
            // btn_src
            // 
            this.btn_src.Location = new System.Drawing.Point(354, 11);
            this.btn_src.Name = "btn_src";
            this.btn_src.Size = new System.Drawing.Size(75, 23);
            this.btn_src.TabIndex = 2;
            this.btn_src.Text = "button1";
            this.btn_src.UseVisualStyleBackColor = true;
            this.btn_src.Click += new System.EventHandler(this.Btn_src_Click);
            // 
            // txb_dstPath
            // 
            this.txb_dstPath.Location = new System.Drawing.Point(66, 79);
            this.txb_dstPath.Name = "txb_dstPath";
            this.txb_dstPath.Size = new System.Drawing.Size(270, 21);
            this.txb_dstPath.TabIndex = 3;
            // 
            // btn_dst
            // 
            this.btn_dst.Location = new System.Drawing.Point(354, 77);
            this.btn_dst.Name = "btn_dst";
            this.btn_dst.Size = new System.Drawing.Size(75, 23);
            this.btn_dst.TabIndex = 4;
            this.btn_dst.Text = "button2";
            this.btn_dst.UseVisualStyleBackColor = true;
            this.btn_dst.Click += new System.EventHandler(this.Btn_dst_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_dst);
            this.Controls.Add(this.txb_dstPath);
            this.Controls.Add(this.btn_src);
            this.Controls.Add(this.txb_srcPath);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txb_srcPath;
        private System.Windows.Forms.Button btn_src;
        private System.Windows.Forms.TextBox txb_dstPath;
        private System.Windows.Forms.Button btn_dst;
    }
}

