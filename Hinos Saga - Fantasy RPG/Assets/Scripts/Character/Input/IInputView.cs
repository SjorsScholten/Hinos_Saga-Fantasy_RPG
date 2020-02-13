using UnityEngine;

namespace InputSystem.View {
    public interface IInputView {
        void SetMovementVectorValue(Vector2 value);
        void SetJumpValue(bool value);
        void SetRunValue(bool value);
    }
}