
namespace Exercise1 {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.btRun = new System.Windows.Forms.Button();
            this.tbQ1 = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssTimeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btRun
            // 
            this.btRun.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.btRun.Location = new System.Drawing.Point(147, 71);
            this.btRun.Name = "btRun";
            this.btRun.Size = new System.Drawing.Size(71, 42);
            this.btRun.TabIndex = 0;
            this.btRun.Text = "実行";
            this.btRun.UseVisualStyleBackColor = true;
            this.btRun.Click += new System.EventHandler(this.btRun_Click);
            // 
            // tbQ1
            // 
            this.tbQ1.Font = new System.Drawing.Font("MS UI Gothic", 16F);
            this.tbQ1.Location = new System.Drawing.Point(12, 119);
            this.tbQ1.Multiline = true;
            this.tbQ1.Name = "tbQ1";
            this.tbQ1.Size = new System.Drawing.Size(435, 189);
            this.tbQ1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssTimeLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 422);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(818, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssTimeLabel
            // 
            this.tssTimeLabel.Name = "tssTimeLabel";
            this.tssTimeLabel.Size = new System.Drawing.Size(118, 17);
            this.tssTimeLabel.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 444);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tbQ1);
            this.Controls.Add(this.btRun);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRun;
        private System.Windows.Forms.TextBox tbQ1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssTimeLabel;
    }
}

