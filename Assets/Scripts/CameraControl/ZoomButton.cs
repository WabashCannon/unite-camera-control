namespace Assets.Scripts.CameraControl {
	public class ZoomButton : CameraControlButton {
		public override void OnStart()
			=> Controller.State.Zoom = Value;

		public override void OnStop()
			=> Controller.State.Zoom = 0f;
	}
}
