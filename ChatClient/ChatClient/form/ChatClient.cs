using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.IO;
using ChatClient.config;
using ChatClient.sound;
using NetLib.udp;
using NetLib.tcp;

namespace ChatClient.form
{
    public partial class ChatClient : Form
    {
        private static String MENU_CONFIG = "設定";
        private static String MENU_EXIT = "終了";
        private Encoding encoding;
        private TextUdpReciver TextReciver { get; set; }
        private TextUdpSender TextSender { get; set; }
        private ChatClientIniFile IniFile { get; set; }
        private Thread threadRecive;
        private frmConfig FormConfig { get; set; }
        private SoundManager Sound { get; set; }
        private CameraImageTcpClient m_cameraImageTcpClient { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ChatClient()
        {
            InitializeComponent();
            encoding = Encoding.UTF8;
            IniFile = new ChatClientIniFile();
            StartPosition = FormStartPosition.CenterScreen;
            m_cameraImageTcpClient = new CameraImageTcpClient();
        }

        /// <summary>
        /// 通信監視スレッドにより実行される
        /// </summary>
        private void threadRecive_Start()
        {
            bool responseWait = false;
            while (true)
            {
                if (TextReciver.available() > 0)
                {
                    Object recv = TextReciver.recive();
                    if (recv != null)
                    {
                        String data = (String)recv;
                        showText(data);
                        //カメラ映像を受信するためにServerに接続する
                        if (!m_cameraImageTcpClient.isConnect())
                        {
                            responseWait = false;
                            m_cameraImageTcpClient.connect("suzuki-PC", 10020);
                        }
                    }
                }
                if (m_cameraImageTcpClient.isConnect())
                {
                    if (!responseWait)
                    {
                        DataPacket packet = new DataPacket(DataPacket.TYPE_GETIMG, null);
                        m_cameraImageTcpClient.send(packet.toByteArray());
                        responseWait = true;
                    }
                    if (m_cameraImageTcpClient.available())
                    {
                        try
                        {
                            Bitmap bmp = m_cameraImageTcpClient.getImage();
                            showImage(bmp);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine("不正パケットのため破棄");
                        }
                        responseWait = false;

                        //byte[] recv = m_cameraImageTcpClient.getImage();
                        //MemoryStream ms = new MemoryStream(recv);
                        //try
                        //{
                        //    Bitmap bmp = new Bitmap(ms);
                        //    showImage(bmp);
                        //}
                        //catch (ArgumentException ex)
                        //{
                        //    Console.WriteLine("不正パケットのため破棄");
                        //}
                        //responseWait = false;
                    }
                }
                Thread.Sleep(100);
            }
        }

        /// <summary>
        /// 受信したテキストを表示する
        /// </summary>
        /// <param name="message"></param>
        private void showText(string message)
        {
            try
            {
                Invoke((MethodInvoker)delegate()
                {
                    Console.WriteLine(message);
                    notifyIconChatClient.BalloonTipText = message;
                    notifyIconChatClient.ShowBalloonTip(IniFile.ShowBalloonTipMilliseconds);
                    chaim(true);
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// 受信いた画像を表示する
        /// </summary>
        /// <param name="img"></param>
        private void showImage(Bitmap img)
        {
            try
            {
                Invoke((MethodInvoker)delegate()
                {
                    Bitmap canvas = new Bitmap(picImage.Width, picImage.Height);
                    Graphics g = Graphics.FromImage(canvas);
                    g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                    g.DrawImage(img, 0,0,picImage.Width, picImage.Height);
                    picImage.Image = canvas;
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// 通信監視用スレッドを開始する
        /// </summary>
        private void startNetworkkThread()
        {
            if (threadRecive == null)
            {
                threadRecive = new Thread(threadRecive_Start);
                threadRecive.Start();
            }
        }

        /// <summary>
        /// 通信監視用スレッドを停止する
        /// </summary>
        private void stopNetworkThread()
        {
            if (threadRecive != null)
            {
                threadRecive.Abort();
                threadRecive = null;
            }
        }

        /// <summary>
        /// UDPクライアントを開始する
        /// </summary>
        private void openUdpClient()
        {
            if (TextReciver == null)
            {
                TextReciver = new TextUdpReciver(IniFile.RecivePort, Encoding.UTF8);
            }
            if (TextSender == null)
            {
                TextSender = new TextUdpSender(Encoding.UTF8);
            }
        }

        /// <summary>
        /// UDPクライアントの接続を閉じる
        /// </summary>
        private void closeUdpClient()
        {
            if (TextReciver != null) { TextReciver.close(); }
        }

        /// <summary>
        /// チャイム音を鳴らす
        /// </summary>
        /// <param name="play"></param>
        private void chaim(Boolean play)
        {
            if (Sound == null) { Sound = new SoundManager(IniFile.ChaimPath); }
            if (play) { Sound.play(); }
            else { Sound.stop(); }
        }

        /// <summary>
        /// フォームを表示する
        /// </summary>
        private void showForm()
        {
            Opacity = 100;
            ShowInTaskbar = true;
        }

        /// <summary>
        /// フォームを非表示にする
        /// </summary>
        private void hideForm()
        {
            Opacity = 0;
            ShowInTaskbar = false;
        }

        /// <summary>
        /// アプリを終了する
        /// </summary>
        private void exit()
        {
            notifyIconChatClient.Visible = false;
            closeUdpClient();
            stopNetworkThread();
            Application.Exit();
        }

        /// <summary>
        /// フォームロード時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChatClient_Load(object sender, EventArgs e)
        {
            try
            {
                hideForm();
                openUdpClient();
                startNetworkkThread();
            }
            catch (Exception ex)
            {
                showText("Network error:" + ex.Message);
                return;
            }
        }

        /// <summary>
        /// フォームを閉じたときの処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChatClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            //×ボタンなどでユーザーがフォームを閉じたときは
            //終了処理をキャンセルしてフォームを非表示にする
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                hideForm();
            }
        }

        /// <summary>
        /// 受付側にメッセージを送信する
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            byte[] sendBytes = encoding.GetBytes(txtSendMsg.Text);
            TextSender.send(sendBytes, sendBytes.Length, IniFile.InfoClerkHostname, IniFile.SendPort);
            m_cameraImageTcpClient.close();
            hideForm();
        }

        /// <summary>
        /// バルーンチップクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyIconChatClient_BalloonTipClicked(object sender, EventArgs e)
        {
            showForm();
        }

        /// <summary>
        /// アイコンクリック時の処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void contextMenuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //設定フォームを開く
            if (e.ClickedItem.Text.Equals(MENU_CONFIG))
            {
                FormConfig = new frmConfig(IniFile);
                FormConfig.Show(this);
                showForm();
            }
            //アプリを終了する
            else if (e.ClickedItem.Text.Equals(MENU_EXIT))
            {
                exit();
            }
        }
    }
}
