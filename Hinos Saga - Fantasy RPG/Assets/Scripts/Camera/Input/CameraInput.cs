using UnityEngine;
using UnityEngine.InputSystem;

namespace Camera.Input {
    public class CameraInput : MonoBehaviour, PlayerControls.ICameraActions {
        public float HorizontalAxis { get; private set; }
        public float VerticalAxis { get; private set; }
    

        private PlayerControls _playerControls;
        public CameraInputPresenter Presenter = new CameraInputPresenter();
    
        private void Awake() {
            _playerControls = new PlayerControls();
            _playerControls.Camera.SetCallbacks(this);
            
            Presenter.Initialize();
        }

        private void OnEnable() => _playerControls.Enable();
        private void OnDisable() => _playerControls.Disable();
        private void LateUpdate() => Presenter.UpdateGUI(this);

        public void OnLook(InputAction.CallbackContext context) {
            var value = context.ReadValue<Vector2>();
            HorizontalAxis = value.x;
            VerticalAxis = value.y;
        }
    }
}
