using UnityEngine;
using UnityEngine.EventSystems;

namespace Assets.Scripts.CameraControl {
	public abstract class CameraControlButton
		: MonoBehaviour,
		IPointerUpHandler,
		IPointerDownHandler,
		IPointerExitHandler 
	{

		public float Value;

		protected CameraController Controller
			=> _rig.ActiveController;

		private CameraRig _rig;

		public void Awake() {
			_rig = FindObjectOfType<CameraRig>();
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
