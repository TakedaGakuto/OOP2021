
namespace Exercise3
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
            this.btFile = new System.Windows.Forms.Button();
            this.btAddFile = new System.Windows.Forms.Button();
            this.ofdOpenFile = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveFile = new System.Windows.Forms.SaveFileDialog();
            this.btAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btFile
            // 
            this.btFile.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.btFile.Location = new System.Drawing.Point(28, 42);
            this.btFile.Name = "btFile";
            this.btFile.Size = new System.Drawing.Size(202, 36);
            this.btFile.TabIndex = 0;
            this.btFile.Text = "追加元ファイルを指定...";
            this.btFile.UseVisualStyleBackColor = true;
            this.btFile.Click += new System.EventHandler(this.btFile_Click);
            // 
            // btAddFile
            // 
            this.btAddFile.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.btAddFile.Location = new System.Drawing.Point(28, 85);
            this.btAddFile.Name = "btAddFile";
            this.btAddFile.Size = new System.Drawing.Size(202, 35);
            this.btAddFile.TabIndex = 1;
            this.btAddFile.Text = "追加ファイルを指定...";
            this.btAddFile.UseVisualStyleBackColor = true;
            this.btAddFile.Click += new System.EventHandler(this.btAddFile_Click);
            // 
            // ofdOpenFile
            // 
            this.ofdOpenFile.FileName = "openFileDialog1";
            // 
            // btAdd
            // 
            this.btAdd.Font = new System.Drawing.Font("MS UI Gothic", 14F);
            this.btAdd.Location = new System.Drawing.Point(28, 126);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(202, 32);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "追加";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btAddFile);
            this.Controls.Add(this.btFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btFile;
        private System.Windows.Forms.Button btAddFile;
        private System.Windows.Forms.OpenFileDialog ofdOpenFile;
        private System.Windows.Forms.SaveFileDialog sfdSaveFile;
        private System.Windows.Forms.Button btAdd;
    }
}

