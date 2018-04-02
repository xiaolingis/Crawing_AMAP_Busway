namespace Crawing_Amap_Busway
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.CityName_Text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.KeyWords_Text = new System.Windows.Forms.TextBox();
            this.Btn_Confirm = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择城市";
            // 
            // CityName_Text
            // 
            this.CityName_Text.Location = new System.Drawing.Point(89, 18);
            this.CityName_Text.Name = "CityName_Text";
            this.CityName_Text.Size = new System.Drawing.Size(144, 21);
            this.CityName_Text.TabIndex = 2;
            this.CityName_Text.Text = "南京市";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("华文行楷", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "关键字";
            // 
            // KeyWords_Text
            // 
            this.KeyWords_Text.Location = new System.Drawing.Point(89, 59);
            this.KeyWords_Text.Name = "KeyWords_Text";
            this.KeyWords_Text.Size = new System.Drawing.Size(144, 21);
            this.KeyWords_Text.TabIndex = 2;
            this.KeyWords_Text.Text = "1路公交";
            // 
            // Btn_Confirm
            // 
            this.Btn_Confirm.Location = new System.Drawing.Point(32, 103);
            this.Btn_Confirm.Name = "Btn_Confirm";
            this.Btn_Confirm.Size = new System.Drawing.Size(75, 23);
            this.Btn_Confirm.TabIndex = 3;
            this.Btn_Confirm.Text = "确定";
            this.Btn_Confirm.UseVisualStyleBackColor = true;
            this.Btn_Confirm.Click += new System.EventHandler(this.Btn_Confirm_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(136, 103);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 3;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 143);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Confirm);
            this.Controls.Add(this.KeyWords_Text);
            this.Controls.Add(this.CityName_Text);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "高德公交线路爬虫程序";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CityName_Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox KeyWords_Text;
        private System.Windows.Forms.Button Btn_Confirm;
        private System.Windows.Forms.Button Btn_Cancel;
    }
}

