using InputSystem.View;
using UnityEngine;
using UnityEngine.UI;

namespace Character.Input {
    public class InputDebugScreenView : MonoBehaviour, IInputView {
        [SerializeField] private Text movementVectorText = null;
        [SerializeField] private Text jumpValueText = null;
        [SerializeField] private Text runValueText = null;

        public void SetMovementVectorValue(Vector2 value) => movementVectorText.text = $"Move: {value.ToString()}";

        public void SetJumpValue(bool value) => jumpValueText.text = $"Jump: {value}";

        public void SetRunValue(bool value) => runValueText.text = $"Run: {value}";
    }
}