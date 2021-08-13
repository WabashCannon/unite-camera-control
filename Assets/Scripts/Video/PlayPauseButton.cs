using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

namespace Assets.Scripts.Video {
	[RequireComponent(typeof(Image))]
	[RequireComponent(typeof(Button))]
	public class PlayPauseButton : MonoBehaviour {

		public Sprite PlaySprite;
		public Sprite PauseSprite;

		public VideoPlayer Player;

		private Button _button;
		private Image _image;
		private IEnumerator _updateButtonCoroutine;

		public void Awake() {
			_button = GetComponent<Button>();
			_image = GetComponent<Image>();
		}

		public void OnEnable() {
			_button.onClick.AddListener(TogglePlay);
			_updateButtonCoroutine = SyncImage();
			StartCoroutine(_updateButtonCoroutine);
			UpdateImage();
		}

		public void OnDisable() {
			_button.onClick.RemoveListener(TogglePlay);
			StopCoroutine(_updateButtonCoroutine);
			_updateButtonCoroutine = null;
		}

		public void TogglePlay() {
			if (Player.isPlaying) {
				Player.Pause();
			} else {
				Player.Play();
			}
			UpdateImage();
		}

		private void UpdateImage() {
			_image.sprite = Player.isPlaying
				? PauseSprite
				: PlaySprite;
		}

		private IEnumerator SyncImage() {
			// If the player is started or stopped externally we want
			// to update the button, but it doesn't expose events to
			// trigger that update so we're stuck with polling
			while (true) {
				yield return new WaitForSeconds(0.1f);
				UpdateImage();
			}
		}
	}
}
