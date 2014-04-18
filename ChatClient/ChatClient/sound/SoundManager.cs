using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;
using HFileLib;

namespace ChatClient.sound
{
    public class SoundManager
    {
        private SoundPlayer Player { get; set; }

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="path">Wavファイルパス</param>
        public SoundManager(String path)
        {
            HFile file = new HFile(path);
            if (!file.exists()) { return; }
            Player = new SoundPlayer(path);
        }

        /// <summary>
        /// 音を鳴らす
        /// </summary>
        public void play()
        {
            if (Player != null) { Player.Play(); }
        }

        public void stop()
        {
            if (Player != null) { Player.Stop(); }
        }
    }
}
