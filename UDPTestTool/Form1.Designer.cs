namespace UDPTestTool
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
            this.ReceiveDataText = new System.Windows.Forms.RichTextBox();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ReceiveDataText
            // 
            this.ReceiveDataText.Location = new System.Drawing.Point(13, 13);
            this.ReceiveDataText.Name = "ReceiveDataText";
            this.ReceiveDataText.Size = new System.Drawing.Size(774, 438);
            this.ReceiveDataText.TabIndex = 0;
            this.ReceiveDataText.Text = "";
            // 
            // ButtonStop
            // 
            this.ButtonStop.Location = new System.Drawing.Point(615, 457);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(171, 60);
            this.ButtonStop.TabIndex = 1;
            this.ButtonStop.Text = "ストップ";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(438, 457);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(171, 60);
            this.ButtonStart.TabIndex = 2;
            this.ButtonStart.Text = "スタート";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 618);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ReceiveDataText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ReceiveDataText;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Button ButtonStart;
    }
}

