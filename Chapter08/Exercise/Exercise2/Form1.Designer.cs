
namespace Exercise2 {
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
            this.components = new System.ComponentModel.Container();
            this.btStart = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btlap = new System.Windows.Forms.Button();
            this.tbLapTime = new System.Windows.Forms.TextBox();
            this.tm = new System.Windows.Forms.Timer(this.components);
            this.lbTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btStart.Location = new System.Drawing.Point(13, 53);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(92, 80);
            this.btStart.TabIndex = 1;
            this.btStart.Text = "スタート";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btReset.Location = new System.Drawing.Point(111, 52);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(92, 80);
            this.btReset.TabIndex = 1;
            this.btReset.Text = "リセット";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // btStop
            // 
            this.btStop.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btStop.Location = new System.Drawing.Point(14, 139);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(92, 81);
            this.btStop.TabIndex = 1;
            this.btStop.Text = "ストップ";
            this.btStop.UseVisualStyleBackColor = true;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btlap
            // 
            this.btlap.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.btlap.Location = new System.Drawing.Point(112, 138);
            this.btlap.Name = "btlap";
            this.btlap.Size = new System.Drawing.Size(92, 82);
            this.btlap.TabIndex = 1;
            this.btlap.Text = "ラップ";
            this.btlap.UseVisualStyleBackColor = true;
            this.btlap.Click += new System.EventHandler(this.btlap_Click);
            // 
            // tbLapTime
            // 
            this.tbLapTime.Location = new System.Drawing.Point(210, 52);
            this.tbLapTime.Multiline = true;
            this.tbLapTime.Name = "tbLapTime";
            this.tbLapTime.Size = new System.Drawing.Size(182, 168);
            this.tbLapTime.TabIndex = 2;
            // 
            // lbTimer
            // 
            this.lbTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lbTimer.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.lbTimer.Location = new System.Drawing.Point(14, 13);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(362, 27);
            this.lbTimer.TabIndex = 3;
            this.lbTimer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 292);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.tbLapTime);
            this.Controls.Add(this.btlap);
            this.Controls.Add(this.btStop);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btStart);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btlap;
        private System.Windows.Forms.TextBox tbLapTime;
        private System.Windows.Forms.Timer tm;
        private System.Windows.Forms.Label lbTimer;
    }
}

