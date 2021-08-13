using System;
using UnityEngine;

namespace Assets.Scripts.CameraControl {
	public class CameraController : MonoBehaviour {

		public CameraState State;
		public float PanRate = 10f;
		public float TiltRate = 5f;
		public float ZoomRate = 1f;

		public float MaxFieldOfView = 16f;
		public float MaxTilt = 45f;
		public float MaxPan = 20f;

		private float _pan = 0;
		private float _tilt = 0;

		public void Awake() {
			State = new CameraState();
		}

		public void Update() {
			if (State.Pan != 0) {
				var deltaPan = Time.deltaTime * State.Pan * PanRate;
				_pan += deltaPan;
				_pan = Mathf.Clamp(_pan, -MaxPan, MaxPan);
			}
			if (State.Tilt != 0) {
				var deltaTilt = Time.deltaTime * State.Tilt * TiltRate;
				_tilt += deltaTilt;
				_tilt = Mathf.Clamp(_tilt, -MaxTilt, MaxTilt);
			}

			transform.rotation = Quaternion.Euler(_tilt, _pan, 0f);

			if (State.Zoom != 0) {
				var deltaZoom = Time.deltaTime * State.Zoom * ZoomRate;
				Camera.main.fieldOfView *= 1f + deltaZoom;
				Camera.main.fieldOfView = Mathf.Clamp(Camera.main.fieldOfView, 0.1f, MaxFieldOfView);
			}
		}
	}
}
