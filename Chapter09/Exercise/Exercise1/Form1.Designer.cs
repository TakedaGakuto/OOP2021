
namespace Exercise {
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
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.btOpen9_1 = new System.Windows.Forms.Button();
            this.tbSerchKeyWord = new System.Windows.Forms.TextBox();
            this.btOpen9_2 = new System.Windows.Forms.Button();
            this.btOpen9_3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(54, 147);
            this.tbOutput.Multiline = true;
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(611, 270);
            this.tbOutput.TabIndex = 0;
            // 
            // btOpen9_1
            // 
            this.btOpen9_1.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btOpen9_1.Location = new System.Drawing.Point(54, 80);
            this.btOpen9_1.Name = "btOpen9_1";
            this.btOpen9_1.Size = new System.Drawing.Size(67, 44);
            this.btOpen9_1.TabIndex = 1;
            this.btOpen9_1.Text = "9.1";
            this.btOpen9_1.UseVisualStyleBackColor = true;
            this.btOpen9_1.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // tbSerchKeyWord
            // 
            this.tbSerchKeyWord.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.tbSerchKeyWord.Location = new System.Drawing.Point(54, 27);
            this.tbSerchKeyWord.Name = "tbSerchKeyWord";
            this.tbSerchKeyWord.Size = new System.Drawing.Size(292, 31);
            this.tbSerchKeyWord.TabIndex = 2;
            // 
            // btOpen9_2
            // 
            this.btOpen9_2.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btOpen9_2.Location = new System.Drawing.Point(127, 80);
            this.btOpen9_2.Name = "btOpen9_2";
            this.btOpen9_2.Size = new System.Drawing.Size(67, 44);
            this.btOpen9_2.TabIndex = 3;
            this.btOpen9_2.Text = "9.2";
            this.btOpen9_2.UseVisualStyleBackColor = true;
            this.btOpen9_2.Click += new System.EventHandler(this.btOpen9_2_Click);
            // 
            // btOpen9_3
            // 
            this.btOpen9_3.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btOpen9_3.Location = new System.Drawing.Point(201, 80);
            this.btOpen9_3.Name = "btOpen9_3";
            this.btOpen9_3.Size = new System.Drawing.Size(67, 44);
            this.btOpen9_3.TabIndex = 4;
            this.btOpen9_3.Text = "9.3";
            this.btOpen9_3.UseVisualStyleBackColor = true;
            this.btOpen9_3.Click += new System.EventHandler(this.btOpen9_3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btOpen9_3);
            this.Controls.Add(this.btOpen9_2);
            this.Controls.Add(this.tbSerchKeyWord);
            this.Controls.Add(this.btOpen9_1);
            this.Controls.Add(this.tbOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button btOpen9_1;
        private System.Windows.Forms.TextBox tbSerchKeyWord;
        private System.Windows.Forms.Button btOpen9_2;
        private System.Windows.Forms.Button btOpen9_3;
    }
}

