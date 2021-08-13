using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

namespace Assets.Scripts.Video {
	[RequireComponent(typeof(Slider))]
	public class VideoProgressBinder : MonoBehaviour {
		
		public VideoPlayer Player;
		private Slider _slider;

		public void Awake() {
			_slider = GetComponent<Slider>();
		}

		public void OnEnable() {
			_slider.onValueChanged.AddListener(OnSliderChange);
			_slider.maxValue = (float) Player.length;
		}

		public void OnDisable() {
			_slider.onValueChanged.RemoveListener(OnSliderChange);
		}

		public void OnSliderChange(float f) {
			Player.time = _slider.value;
		}

		public void Update() {
			_slider.SetValueWithoutNotify((float) Player.time);
		}
	}
}
