using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.CameraControl {
	public abstract class CameraControlButton
		: MonoBehaviour,
		IPointerUpHandler,
		IPointerDownHandler,
		IPointerExitHandler {

		public float Value;

		protected CameraController Controller;

		public void Awake() {
			Controller = Camera.main.GetComponent<CameraController>();
		}

		public void OnPointerDown(PointerEventData eventData)
			=> OnStart();
		public void OnPointerExit(PointerEventData eventData)
			=> OnStop();
		public void OnPointerUp(PointerEventData eventData)
			=> OnStop();

		public abstract void OnStart();
		public abstract void OnStop();
	}
}
