using UnityEngine;

namespace Assets.Scripts {
	public class CameraViewportMaker : MonoBehaviour {

		public Camera RearCamera;
		public Camera PtzCamera;
		public Camera UiCamera;

		private const float ControlPanelWidthRatio = 800f / 1920f;

		public void Start() {
			var leftRatio = 1f - ControlPanelWidthRatio;
			var rightRatio = ControlPanelWidthRatio;

			// Set the rear camera to the top-left
			RearCamera.rect = new Rect(
				x: 0f,
				y: 0.5f,
				width: leftRatio,
				height: 0.5f
			);

			// Set the ptz camera to the top-left
			PtzCamera.rect = new Rect(
				x: 0f,
				y: 0f,
				width: leftRatio,
				height: 0.5f
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
