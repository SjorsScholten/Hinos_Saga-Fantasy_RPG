using Character.Input;
using InputSystem.View;
using UnityEngine;
using UnityEngine.InputSystem;
using Util;

namespace Character {
    public class CharacterInput : MonoBehaviour, PlayerControls.ICharacterActions {
        public float HorizontalAxis { get; private set; }
        public float VerticalAxis { get; private set; }

        private readonly PullResetValue<bool> _jumpRequest = new PullResetValue<bool>(false);
        private readonly PullResetValue<bool> _runRequest = new PullResetValue<bool>(false);
        
        public bool JumpRequest => _jumpRequest.Value;
        public bool RunRequest => _runRequest.Value;

        private PlayerControls _playerControls;
        public InputPresenter presenter = new InputPresenter();
        
        private void Awake() {
            _playerControls = new PlayerControls();
            _playerControls.Character.SetCallbacks(this);
            presenter.Initialize();
        }

        private void OnEnable() => _playerControls.Enable();
        private void OnDisable() => _playerControls.Disable();
        private void LateUpdate() => presenter.UpdateGUI(this);

        public void OnMove(InputAction.CallbackContext context) {
            var value = context.ReadValue<Vector2>();
            HorizontalAxis = value.x;
            VerticalAxis = value.y;
        }

        public void OnJump(InputAction.CallbackContext context) => _jumpRequest.Value = context.performed;

        public void OnRun(InputAction.CallbackContext context) => _runRequest.Value = context.performed;

        public bool PeekJumpRequest => _jumpRequest.Peek();
        public bool PeekRunRequest => _runRequest.Peek();
    }
}