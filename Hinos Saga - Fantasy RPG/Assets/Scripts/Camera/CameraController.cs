using Camera.Input;
using UnityEngine;

namespace Camera {
    public class CameraController : MonoBehaviour {

        private CameraInput _input;

        private void Awake() {
            _input = GetComponent<CameraInput>();
            if (!_input) _input = gameObject.AddComponent<CameraInput>();
        }
    }
}