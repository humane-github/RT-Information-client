using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HFileLib;

namespace ChatClient.config
{
    public class ChatClientIniFile
    {
        private static String INIFILE = "./chatclient.ini";
        private static String INI_APP_NETWORK = "network";
        private static String INI_APP_COMMON = "common";
        private static String INI_RECIVE_PORT = "RECIVE_PORT";
        private static String INI_SEND_PORT = "SEND_PORT";
        private static String INI_SHOW_BALLOONTIP_MILLISECONDS = "SHOW_BALLOONTIP_MILLISECONDS";
        private static String INI_INFOCLERK_HOST = "INFOCLERK_HOST";
        private static String INI_CHAIMPATH = "CHAIM_PATH";


        private HIniFile IniFile { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ChatClientIniFile()
        {
            init();
        }

        /// <summary>
        /// 初期化処理
        /// </summary>
        private void init()
        {
            IniFile = new HIniFile(INIFILE);
        }

        /// <summary>
        /// 受信ポート番号
        /// </summary>
        public int RecivePort
        {
            get { return IniFile.getInt(INI_APP_NETWORK, INI_RECIVE_PORT, 0); }
            set { IniFile.setInt(INI_APP_NETWORK, INI_RECIVE_PORT, value); }
        }

        /// <summary>
        /// 送信ポート番号
        /// </summary>
        public int SendPort
        {
            get { return IniFile.getInt(INI_APP_NETWORK, INI_SEND_PORT, 0); }
            set { IniFile.setInt(INI_APP_NETWORK, INI_SEND_PORT, value); }
        }

        /// <summary>
        /// 受付システム実行ホスト名
        /// </summary>
        public String InfoClerkHostname
        {
            get { return IniFile.getString(INI_APP_NETWORK, INI_INFOCLERK_HOST, "localhost"); }
            set { IniFile.setString(INI_APP_NETWORK, INI_INFOCLERK_HOST, value); }
        }

        /// <summary>
        /// メッセージ受信時のチャイム音ファイルのパス
        /// </summary>
        public String ChaimPath
        {
            get { return IniFile.getString(INI_APP_NETWORK, INI_CHAIMPATH, ""); }
            set { IniFile.setString(INI_APP_NETWORK, INI_CHAIMPATH, value); }
        }

        /// <summary>
        /// バルーンチップの表示時間（ms)
        /// </summary>
        public int ShowBalloonTipMilliseconds
        {
            get { return IniFile.getInt(INI_APP_COMMON, INI_SHOW_BALLOONTIP_MILLISECONDS, 10000); }
            set { IniFile.setInt(INI_APP_COMMON, INI_SHOW_BALLOONTIP_MILLISECONDS, value); }
        }
    }
}
