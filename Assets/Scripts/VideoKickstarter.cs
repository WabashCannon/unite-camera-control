using System.Collections;
using UnityEngine;
using UnityEngine.Video;

namespace Assets.Scripts {
	public class VideoKickstarter : MonoBehaviour {
		
		public float StartDelay = 0.5f;
		public VideoPlayer Player;

		public void Start() {
			StartCoroutine(Kickoff());
		}

		private IEnumerator Kickoff() {
			yield return new WaitForSeconds(StartDelay);
			Player.Play();
		}
	}
}
