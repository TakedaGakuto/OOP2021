
namespace Sample0823
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.tbValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbjyou = new System.Windows.Forms.TextBox();
            this.btExec = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbValue
            // 
            this.tbValue.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.tbValue.Location = new System.Drawing.Point(67, 47);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(129, 41);
            this.tbValue.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(202, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "の";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(376, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "乗";
            // 
            // tbjyou
            // 
            this.tbjyou.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.tbjyou.Location = new System.Drawing.Point(241, 47);
            this.tbjyou.Name = "tbjyou";
            this.tbjyou.Size = new System.Drawing.Size(129, 41);
            this.tbjyou.TabIndex = 2;
            // 
            // btExec
            // 
            this.btExec.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.btExec.Location = new System.Drawing.Point(438, 47);
            this.btExec.Name = "btExec";
            this.btExec.Size = new System.Drawing.Size(107, 42);
            this.btExec.TabIndex = 4;
            this.btExec.Text = "結果";
            this.btExec.UseVisualStyleBackColor = true;
            this.btExec.Click += new System.EventHandler(this.btExec_Click);
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.tbResult.Location = new System.Drawing.Point(582, 47);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(129, 41);
            this.tbResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btExec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbjyou);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbjyou;
        private System.Windows.Forms.Button btExec;
        private System.Windows.Forms.TextBox tbResult;
    }
}

