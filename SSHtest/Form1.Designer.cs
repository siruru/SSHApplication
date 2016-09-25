namespace SSHtest
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
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this.label1 = new System.Windows.Forms.Label();
            this.textboxHostname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mtextPortNumber = new System.Windows.Forms.MaskedTextBox();
            this.ConnectionButton = new System.Windows.Forms.Button();
            this.textBoxConsole = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.buttonKey = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ホスト名";
            // 
            // textboxHostname
            // 
            this.textboxHostname.Location = new System.Drawing.Point(78, 10);
            this.textboxHostname.Name = "textboxHostname";
            this.textboxHostname.Size = new System.Drawing.Size(194, 19);
            this.textboxHostname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "ポート番号";
            // 
            // mtextPortNumber
            // 
            this.mtextPortNumber.Location = new System.Drawing.Point(78, 35);
            this.mtextPortNumber.Mask = "9999";
            this.mtextPortNumber.Name = "mtextPortNumber";
            this.mtextPortNumber.Size = new System.Drawing.Size(74, 19);
            this.mtextPortNumber.TabIndex = 3;
            // 
            // ConnectionButton
            // 
            this.ConnectionButton.Location = new System.Drawing.Point(15, 64);
            this.ConnectionButton.Name = "ConnectionButton";
            this.ConnectionButton.Size = new System.Drawing.Size(257, 49);
            this.ConnectionButton.TabIndex = 4;
            this.ConnectionButton.Text = "接続";
            this.ConnectionButton.UseVisualStyleBackColor = true;
            this.ConnectionButton.Click += new System.EventHandler(this.ConnectionButton_Click);
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.Location = new System.Drawing.Point(12, 119);
            this.textBoxConsole.Multiline = true;
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.Size = new System.Drawing.Size(534, 130);
            this.textBoxConsole.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "秘密鍵";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(290, 86);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(256, 19);
            this.textBoxPath.TabIndex = 7;
            // 
            // buttonKey
            // 
            this.buttonKey.Location = new System.Drawing.Point(471, 58);
            this.buttonKey.Name = "buttonKey";
            this.buttonKey.Size = new System.Drawing.Size(75, 23);
            this.buttonKey.TabIndex = 8;
            this.buttonKey.Text = "参照";
            this.buttonKey.UseVisualStyleBackColor = true;
            this.buttonKey.Click += new System.EventHandler(this.buttonKey_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "ユーザー名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "パスワード";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(362, 10);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(184, 19);
            this.textBoxUserName.TabIndex = 11;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(362, 34);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(184, 19);
            this.textBoxPassword.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 261);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonKey);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxConsole);
            this.Controls.Add(this.ConnectionButton);
            this.Controls.Add(this.mtextPortNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxHostname);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "SSH接続アプリ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxHostname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mtextPortNumber;
        private System.Windows.Forms.Button ConnectionButton;
        private System.Windows.Forms.TextBox textBoxConsole;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Button buttonKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxPassword;
    }
}

