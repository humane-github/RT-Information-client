namespace ChatClient.form
{
    partial class frmConfig
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtSendHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSendPort = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRecivePort = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCommon = new System.Windows.Forms.TabPage();
            this.txtBalloontipMilliseconds = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabNetwork = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtChaimPath = new System.Windows.Forms.TextBox();
            this.btnSearchChaimPath = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabCommon.SuspendLayout();
            this.tabNetwork.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "受付システム実行ホスト名";
            // 
            // txtSendHost
            // 
            this.txtSendHost.Location = new System.Drawing.Point(142, 62);
            this.txtSendHost.Name = "txtSendHost";
            this.txtSendHost.Size = new System.Drawing.Size(100, 19);
            this.txtSendHost.TabIndex = 16;
            this.txtSendHost.Text = "suzuki-PC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "送信ポート番号";
            // 
            // txtSendPort
            // 
            this.txtSendPort.Location = new System.Drawing.Point(88, 35);
            this.txtSendPort.Name = "txtSendPort";
            this.txtSendPort.Size = new System.Drawing.Size(100, 19);
            this.txtSendPort.TabIndex = 14;
            this.txtSendPort.Text = "10010";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "受信ポート番号";
            // 
            // txtRecivePort
            // 
            this.txtRecivePort.Location = new System.Drawing.Point(88, 9);
            this.txtRecivePort.Name = "txtRecivePort";
            this.txtRecivePort.Size = new System.Drawing.Size(100, 19);
            this.txtRecivePort.TabIndex = 12;
            this.txtRecivePort.Text = "10000";
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(281, 225);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(59, 25);
            this.btnApply.TabIndex = 18;
            this.btnApply.Text = "適用";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(346, 225);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(62, 25);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "キャンセル";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCommon);
            this.tabControl1.Controls.Add(this.tabNetwork);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(400, 207);
            this.tabControl1.TabIndex = 20;
            // 
            // tabCommon
            // 
            this.tabCommon.Controls.Add(this.btnSearchChaimPath);
            this.tabCommon.Controls.Add(this.txtChaimPath);
            this.tabCommon.Controls.Add(this.label5);
            this.tabCommon.Controls.Add(this.txtBalloontipMilliseconds);
            this.tabCommon.Controls.Add(this.label3);
            this.tabCommon.Location = new System.Drawing.Point(4, 22);
            this.tabCommon.Name = "tabCommon";
            this.tabCommon.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommon.Size = new System.Drawing.Size(392, 181);
            this.tabCommon.TabIndex = 0;
            this.tabCommon.Text = "共通";
            this.tabCommon.UseVisualStyleBackColor = true;
            // 
            // txtBalloontipMilliseconds
            // 
            this.txtBalloontipMilliseconds.Location = new System.Drawing.Point(152, 13);
            this.txtBalloontipMilliseconds.Name = "txtBalloontipMilliseconds";
            this.txtBalloontipMilliseconds.Size = new System.Drawing.Size(100, 19);
            this.txtBalloontipMilliseconds.TabIndex = 14;
            this.txtBalloontipMilliseconds.Text = "10000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "バルーンチップ表示時間(ms)";
            // 
            // tabNetwork
            // 
            this.tabNetwork.Controls.Add(this.label4);
            this.tabNetwork.Controls.Add(this.txtRecivePort);
            this.tabNetwork.Controls.Add(this.label1);
            this.tabNetwork.Controls.Add(this.txtSendPort);
            this.tabNetwork.Controls.Add(this.txtSendHost);
            this.tabNetwork.Controls.Add(this.label2);
            this.tabNetwork.Location = new System.Drawing.Point(4, 22);
            this.tabNetwork.Name = "tabNetwork";
            this.tabNetwork.Padding = new System.Windows.Forms.Padding(3);
            this.tabNetwork.Size = new System.Drawing.Size(392, 181);
            this.tabNetwork.TabIndex = 1;
            this.tabNetwork.Text = "通信";
            this.tabNetwork.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "メッセージ受信時のチャイム音";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "wavファイル|*.wav";
            // 
            // txtChaimPath
            // 
            this.txtChaimPath.Location = new System.Drawing.Point(8, 60);
            this.txtChaimPath.Name = "txtChaimPath";
            this.txtChaimPath.Size = new System.Drawing.Size(327, 19);
            this.txtChaimPath.TabIndex = 17;
            // 
            // btnSearchChaimPath
            // 
            this.btnSearchChaimPath.Location = new System.Drawing.Point(341, 60);
            this.btnSearchChaimPath.Name = "btnSearchChaimPath";
            this.btnSearchChaimPath.Size = new System.Drawing.Size(40, 18);
            this.btnSearchChaimPath.TabIndex = 18;
            this.btnSearchChaimPath.Text = "...";
            this.btnSearchChaimPath.UseVisualStyleBackColor = true;
            this.btnSearchChaimPath.Click += new System.EventHandler(this.btnSearchChaimPath_Click);
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 262);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Name = "frmConfig";
            this.Text = "設定";
            this.tabControl1.ResumeLayout(false);
            this.tabCommon.ResumeLayout(false);
            this.tabCommon.PerformLayout();
            this.tabNetwork.ResumeLayout(false);
            this.tabNetwork.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSendHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSendPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRecivePort;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCommon;
        private System.Windows.Forms.TabPage tabNetwork;
        private System.Windows.Forms.TextBox txtBalloontipMilliseconds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchChaimPath;
        private System.Windows.Forms.TextBox txtChaimPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}