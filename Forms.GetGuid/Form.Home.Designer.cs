namespace Forms.GetGuid
{
    partial class form_Home
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
            this.btn_Get = new System.Windows.Forms.Button();
            this.btn_Get1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Get
            // 
            this.btn_Get.Location = new System.Drawing.Point(60, 12);
            this.btn_Get.Name = "btn_Get";
            this.btn_Get.Size = new System.Drawing.Size(75, 23);
            this.btn_Get.TabIndex = 0;
            this.btn_Get.Text = "获取Guid";
            this.btn_Get.UseVisualStyleBackColor = true;
            this.btn_Get.Click += new System.EventHandler(this.btn_Get_Click);
            // 
            // btn_Get1
            // 
            this.btn_Get1.Location = new System.Drawing.Point(33, 50);
            this.btn_Get1.Name = "btn_Get1";
            this.btn_Get1.Size = new System.Drawing.Size(128, 23);
            this.btn_Get1.TabIndex = 1;
            this.btn_Get1.Text = "获取Guid不带符号";
            this.btn_Get1.UseVisualStyleBackColor = true;
            this.btn_Get1.Click += new System.EventHandler(this.btn_Get1_Click);
            // 
            // form_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(198, 85);
            this.Controls.Add(this.btn_Get1);
            this.Controls.Add(this.btn_Get);
            this.Name = "form_Home";
            this.Text = "获取Guid";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Get;
        private System.Windows.Forms.Button btn_Get1;
    }
}

