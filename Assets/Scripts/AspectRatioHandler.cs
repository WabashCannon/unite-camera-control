using UnityEngine;

namespace Assets.Scripts {
	public class AspectRatioHandler : MonoBehaviour {

		public GameObject ControlPanel;

		public Camera MainCamera;
		public Camera UiCamera;

		private const float ControlPanelWidthRatio = 800f / 1920f;

		public void Start() {
			var leftRatio = 1f - ControlPanelWidthRatio;
			var rightRatio = ControlPanelWidthRatio;

			// Set the lecture view camera to fill the left
			MainCamera.rect = new Rect(
				x: 0f,
				y: 0f,
				width: leftRatio,
				height: 1f
			);

			// Set the UI control panel camera to fill the right
			UiCamera.rect = new Rect(
				x: leftRatio,
				y: 0f,
				width: rightRatio,
				height: 1f
			);
		}
	}
}
