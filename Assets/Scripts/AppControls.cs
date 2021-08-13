using UnityEngine;

namespace Assets.Scripts {
	public class AppControls : MonoBehaviour {
		public void CloseApp() {
#if UNITY_EDITOR
			UnityEditor.EditorApplication.isPlaying = false;
#else
			Application.Quit();
#endif
		}
	}
}
