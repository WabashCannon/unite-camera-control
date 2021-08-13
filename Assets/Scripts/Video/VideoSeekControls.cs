using System;
using UnityEngine;
using UnityEngine.Video;

namespace Assets.Scripts.Video {
	public class VideoSeekControls : MonoBehaviour {

		public VideoPlayer Player;

		public void SeekBack(float seconds) {
			Player.time = Math.Max(Player.time - seconds, 0);
		}

		public void SeekStart() {
			Player.time = 0f;
		}

		public void SeekEnd() {
			Player.time = Player.length;
		}
	}
}
