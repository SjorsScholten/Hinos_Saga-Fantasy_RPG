using UnityEngine;
using UnityEngine.UI;

namespace InputSystem.View {
    public class InputDebugScreenView : MonoBehaviour, IInputView {
        [SerializeField] private Text movementVectorText;

        public void SetMovementVectorValue(Vector3 value) {
            movementVectorText.text = $"Move Vector: {value.ToString()}";
        }
    }
}