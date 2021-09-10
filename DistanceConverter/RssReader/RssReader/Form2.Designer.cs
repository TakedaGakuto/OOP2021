
namespace RssReader
{
    partial class Form2
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
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.btReturn = new System.Windows.Forms.Button();
            this.btGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wbBrowser
            // 
            this.wbBrowser.Location = new System.Drawing.Point(0, 47);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.ScriptErrorsSuppressed = true;
            this.wbBrowser.Size = new System.Drawing.Size(800, 404);
            this.wbBrowser.TabIndex = 0;
            // 
            // btReturn
            // 
            this.btReturn.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.btReturn.Location = new System.Drawing.Point(0, 7);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(108, 34);
            this.btReturn.TabIndex = 1;
            this.btReturn.Text = "戻る";
            this.btReturn.UseVisualStyleBackColor = true;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // btGo
            // 
            this.btGo.Font = new System.Drawing.Font("MS UI Gothic", 13F);
            this.btGo.Location = new System.Drawing.Point(687, 7);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(101, 34);
            this.btGo.TabIndex = 2;
            this.btGo.Text = "進む";
            this.btGo.UseVisualStyleBackColor = true;
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btGo);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.wbBrowser);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Button btGo;
    }
}