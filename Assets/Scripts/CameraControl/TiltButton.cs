namespace Assets.Scripts.CameraControl {
	public class TiltButton : CameraControlButton {
		public override void OnStart()
			=> Controller.State.Tilt = Value;

		public override void OnStop()
			=> Controller.State.Tilt = 0f;
	}
}
