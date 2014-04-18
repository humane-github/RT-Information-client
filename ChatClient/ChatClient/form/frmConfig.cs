using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HFileLib;
using ChatClient.config;

namespace ChatClient.form
{
    public partial class frmConfig : Form
    {
        private ChatClientIniFile IniFile { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public frmConfig(ChatClientIniFile inifile)
        {
            InitializeComponent();
            IniFile = inifile;
            init();
        }

        /// <summary>
        /// 初期化処理
        /// </summary>
        private void init()
        {
            txtRecivePort.Text = IniFile.RecivePort.ToString();
            txtSendPort.Text = IniFile.SendPort.ToString();
            txtSendHost.Text = IniFile.InfoClerkHostname;
            txtBalloontipMilliseconds.Text = IniFile.ShowBalloonTipMilliseconds.ToString();
            txtChaimPath.Text = IniFile.ChaimPath;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            IniFile.RecivePort = int.Parse(txtRecivePort.Text);
            IniFile.SendPort = int.Parse(txtSendPort.Text);
            IniFile.InfoClerkHostname = txtSendHost.Text;
            IniFile.ShowBalloonTipMilliseconds = int.Parse(txtBalloontipMilliseconds.Text);
            IniFile.ChaimPath = txtChaimPath.Text;
            Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnSearchChaimPath_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = txtChaimPath.Text;
            DialogResult res = openFileDialog.ShowDialog();
            if (res == System.Windows.Forms.DialogResult.OK)
            {
                txtChaimPath.Text = openFileDialog.FileName;
            }
        }
    }
}
