using UnityEngine;
using UnityEngine.UI;

namespace Camera.Input {
    public class CameraDebugScreenView : MonoBehaviour, ICameraInputView {
        [SerializeField] private Text lookVectorText = null;
        
        public void SetLookVectorValue(Vector2 value) => lookVectorText.text = $"Look: {value.ToString()}";
    }
}