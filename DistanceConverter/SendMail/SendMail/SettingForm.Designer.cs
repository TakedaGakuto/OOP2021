
namespace SendMail
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSSL = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.tbPassWord = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbSender = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btDefault = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.btAdaption = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbSSL);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Label);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbHost);
            this.groupBox2.Controls.Add(this.tbUserName);
            this.groupBox2.Controls.Add(this.tbPort);
            this.groupBox2.Controls.Add(this.tbPassWord);
            this.groupBox2.Location = new System.Drawing.Point(32, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 112);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "サーバー情報";
            // 
            // cbSSL
            // 
            this.cbSSL.AutoSize = true;
            this.cbSSL.Location = new System.Drawing.Point(387, 90);
            this.cbSSL.Name = "cbSSL";
            this.cbSSL.Size = new System.Drawing.Size(68, 16);
            this.cbSSL.TabIndex = 2;
            this.cbSSL.Text = "SSL有効";
            this.cbSSL.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.label2.Location = new System.Drawing.Point(5, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "送信サーバー：";
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.Label.Location = new System.Drawing.Point(271, 30);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(50, 15);
            this.Label.TabIndex = 1;
            this.Label.Text = "ポート：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.label1.Location = new System.Drawing.Point(21, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "ユーザー名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.label4.Location = new System.Drawing.Point(249, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "パスワード：";
            // 
            // tbHost
            // 
            this.tbHost.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.tbHost.Location = new System.Drawing.Point(105, 27);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(128, 22);
            this.tbHost.TabIndex = 0;
            // 
            // tbUserName
            // 
            this.tbUserName.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.tbUserName.Location = new System.Drawing.Point(105, 55);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(128, 22);
            this.tbUserName.TabIndex = 0;
            // 
            // tbPort
            // 
            this.tbPort.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.tbPort.Location = new System.Drawing.Point(327, 27);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(128, 22);
            this.tbPort.TabIndex = 0;
            // 
            // tbPassWord
            // 
            this.tbPassWord.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.tbPassWord.Location = new System.Drawing.Point(327, 55);
            this.tbPassWord.Name = "tbPassWord";
            this.tbPassWord.PasswordChar = '*';
            this.tbPassWord.Size = new System.Drawing.Size(128, 22);
            this.tbPassWord.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSender);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(32, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ユーザー情報";
            // 
            // tbSender
            // 
            this.tbSender.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.tbSender.Location = new System.Drawing.Point(105, 30);
            this.tbSender.Name = "tbSender";
            this.tbSender.Size = new System.Drawing.Size(128, 22);
            this.tbSender.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.label3.Location = new System.Drawing.Point(21, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "送信元：";
            // 
            // btDefault
            // 
            this.btDefault.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.btDefault.Location = new System.Drawing.Point(32, 254);
            this.btDefault.Name = "btDefault";
            this.btDefault.Size = new System.Drawing.Size(81, 35);
            this.btDefault.TabIndex = 2;
            this.btDefault.Text = "デフォルト";
            this.btDefault.UseVisualStyleBackColor = true;
            this.btDefault.Click += new System.EventHandler(this.btDefault_Click);
            // 
            // btOK
            // 
            this.btOK.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.btOK.Location = new System.Drawing.Point(359, 254);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(74, 35);
            this.btOK.TabIndex = 2;
            this.btOK.Text = "OK";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // btCancel
            // 
            this.btCancel.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.btCancel.Location = new System.Drawing.Point(439, 254);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 35);
            this.btCancel.TabIndex = 2;
            this.btCancel.Text = "キャンセル";
            this.btCancel.UseVisualStyleBackColor = true;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btAdaption
            // 
            this.btAdaption.Font = new System.Drawing.Font("MS UI Gothic", 11F);
            this.btAdaption.Location = new System.Drawing.Point(519, 254);
            this.btAdaption.Name = "btAdaption";
            this.btAdaption.Size = new System.Drawing.Size(75, 35);
            this.btAdaption.TabIndex = 2;
            this.btAdaption.Text = "適応";
            this.btAdaption.UseVisualStyleBackColor = true;
            this.btAdaption.Click += new System.EventHandler(this.btAdaption_Click);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 301);
            this.Controls.Add(this.btAdaption);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.btDefault);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.TextBox tbPassWord;
        private System.Windows.Forms.CheckBox cbSSL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSender;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btDefault;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btAdaption;
    }
}