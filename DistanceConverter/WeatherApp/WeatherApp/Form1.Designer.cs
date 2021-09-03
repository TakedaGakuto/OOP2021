
namespace WeatherApp
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
            this.cbPrifecture = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btWeather = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbPrifecture
            // 
            this.cbPrifecture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPrifecture.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.cbPrifecture.FormattingEnabled = true;
            this.cbPrifecture.Items.AddRange(new object[] {
            "栃木",
            "茨城",
            "群馬",
            "埼玉",
            "東京",
            "千葉",
            "神奈川"});
            this.cbPrifecture.Location = new System.Drawing.Point(267, 49);
            this.cbPrifecture.Name = "cbPrifecture";
            this.cbPrifecture.Size = new System.Drawing.Size(180, 33);
            this.cbPrifecture.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(138, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "表示地域";
            // 
            // btWeather
            // 
            this.btWeather.Font = new System.Drawing.Font("MS UI Gothic", 12F);
            this.btWeather.Location = new System.Drawing.Point(453, 48);
            this.btWeather.Name = "btWeather";
            this.btWeather.Size = new System.Drawing.Size(136, 33);
            this.btWeather.TabIndex = 2;
            this.btWeather.Text = "天気を見る";
            this.btWeather.UseVisualStyleBackColor = true;
            this.btWeather.Click += new System.EventHandler(this.btWeather_Click);
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(143, 95);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(446, 293);
            this.tbResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.btWeather);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPrifecture);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPrifecture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btWeather;
        private System.Windows.Forms.TextBox tbResult;
    }
}

