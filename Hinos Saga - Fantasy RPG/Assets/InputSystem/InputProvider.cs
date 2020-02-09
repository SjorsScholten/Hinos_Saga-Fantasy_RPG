using InputSystem.InputHandlers;
using InputSystem.View;
using UnityEngine;

namespace InputSystem {
    public class InputProvider : MonoBehaviour {
        public IInputHandler inputHandler { get; private set; }
        public InputPresenter presenter = new InputPresenter();

        private void Awake() {
            inputHandler = InputManager.Instance.GetSystemInputHandler();
            presenter.Initialize();
        }

        private void LateUpdate() {
            presenter.UpdateGUI(inputHandler);
        }
    }
}
