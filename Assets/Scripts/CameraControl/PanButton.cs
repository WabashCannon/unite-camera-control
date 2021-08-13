namespace Assets.Scripts.CameraControl {
	public class PanButton : CameraControlButton {
		public override void OnStart()
			=> Controller.State.Pan = Value;

		public override void OnStop()
			=> Controller.State.Pan = 0f;
	}
}
