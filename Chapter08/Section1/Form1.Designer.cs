
namespace Section1 {
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
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.nudYear = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMonth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudDay = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLeapYear = new System.Windows.Forms.TextBox();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).BeginInit();
            this.SuspendLayout();
            // 
            // tbOutput
            // 
            this.tbOutput.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.tbOutput.Location = new System.Drawing.Point(67, 221);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(447, 31);
            this.tbOutput.TabIndex = 0;
            // 
            // RunButton
            // 
            this.RunButton.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.RunButton.Location = new System.Drawing.Point(215, 184);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(98, 31);
            this.RunButton.TabIndex = 1;
            this.RunButton.Text = "実行";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // nudYear
            // 
            this.nudYear.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.nudYear.Location = new System.Drawing.Point(135, 61);
            this.nudYear.Maximum = new decimal(new int[] {
            2200,
            0,
            0,
            0});
            this.nudYear.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudYear.Name = "nudYear";
            this.nudYear.Size = new System.Drawing.Size(69, 31);
            this.nudYear.TabIndex = 2;
            this.nudYear.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label1.Location = new System.Drawing.Point(210, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "年";
            // 
            // nudMonth
            // 
            this.nudMonth.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.nudMonth.Location = new System.Drawing.Point(252, 61);
            this.nudMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMonth.Name = "nudMonth";
            this.nudMonth.Size = new System.Drawing.Size(47, 31);
            this.nudMonth.TabIndex = 2;
            this.nudMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label2.Location = new System.Drawing.Point(305, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "月";
            // 
            // nudDay
            // 
            this.nudDay.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.nudDay.Location = new System.Drawing.Point(350, 61);
            this.nudDay.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.nudDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDay.Name = "nudDay";
            this.nudDay.Size = new System.Drawing.Size(47, 31);
            this.nudDay.TabIndex = 2;
            this.nudDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.label3.Location = new System.Drawing.Point(403, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "日";
            // 
            // tbLeapYear
            // 
            this.tbLeapYear.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.tbLeapYear.Location = new System.Drawing.Point(67, 275);
            this.tbLeapYear.Name = "tbLeapYear";
            this.tbLeapYear.Size = new System.Drawing.Size(447, 31);
            this.tbLeapYear.TabIndex = 4;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(135, 133);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(200, 19);
            this.dtp1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.tbLeapYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudDay);
            this.Controls.Add(this.nudMonth);
            this.Controls.Add(this.nudYear);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.tbOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.NumericUpDown nudYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudDay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLeapYear;
        private System.Windows.Forms.DateTimePicker dtp1;
    }
}

