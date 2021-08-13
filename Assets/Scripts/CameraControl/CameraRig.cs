using UnityEngine;

namespace Assets.Scripts.CameraControl {
	public class CameraRig : MonoBehaviour {
		public Camera RearCamera;
		public Camera PtzCamera;

		public GameObject RearCameraVideoControls;
		public GameObject PtzCameraVideoControls;

		public CameraController ActiveController;

		private bool _isRearActive = true;

		public void OnEnable() {
			UpdateToMatchMainCamera();
		}

		public void SetRearActive() {
			if (!_isRearActive) {
				SwapCameras();
			}
		}

		public void SetPtzActive() {
			if (_isRearActive) {
				SwapCameras();
			}
		}

		public void SwapCameras() {
			_isRearActive = !_isRearActive;
			var mainCameraRect = RearCamera.rect;
			RearCamera.rect = PtzCamera.rect;
			PtzCamera.rect = mainCameraRect;

			UpdateToMatchMainCamera();
		}

		private void UpdateToMatchMainCamera() {
			ActiveController = _isRearActive
				? RearCamera.GetComponent<CameraController>()
				: PtzCamera.GetComponent<CameraController>();

			RearCameraVideoControls.SetActive(!_isRearActive);
			PtzCameraVideoControls.SetActive(_isRearActive);
		}
	}
}
