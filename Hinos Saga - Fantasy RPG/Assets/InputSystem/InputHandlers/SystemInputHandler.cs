using UnityEngine;
using UnityEngine.InputSystem;

namespace InputSystem.InputHandlers {
    public class SystemInputHandler : IInputHandler, PlayerControls.ICharacterActions {
    
        private readonly PlayerControls _controls = new PlayerControls();

        
        private class AxisInput : IAxisInput {
            public float Axis;
            public float GetAxis() => Axis;
        }
        
        private readonly AxisInput _horizontalAxisInput = new AxisInput();
        private readonly AxisInput _verticalAxisInput = new AxisInput();
        
        
        public SystemInputHandler(){
            _controls.Character.SetCallbacks(this);
            _controls.Character.Enable();
        }

        
        public IAxisInput GetHorizontalMoveAxis() => _horizontalAxisInput;
        public IAxisInput GetVerticalMoveAxis() => _verticalAxisInput;
        public IAxisInput GetHorizontalLookAxis() => null;
        public IAxisInput GetVerticalLookAxis() => null;
        public IButtonInput GetJumpButton() => null;

        
        public void OnMove(InputAction.CallbackContext context) {
            var value = context.ReadValue<Vector2>();
            _horizontalAxisInput.Axis = value.x;
            _verticalAxisInput.Axis = value.y;
        }

        public void OnJump(InputAction.CallbackContext context) {
            var value = context.ReadValue<bool>();
        }
    }
}
