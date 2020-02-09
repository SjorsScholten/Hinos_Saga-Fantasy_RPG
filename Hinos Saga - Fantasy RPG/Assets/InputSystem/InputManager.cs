using InputSystem.InputHandlers;
using Util;

namespace InputSystem {
    public class InputManager : Singleton<InputManager> {
        private NullInputHandler _nullInputHandler;
        public IInputHandler GetNullInputHandler() => _nullInputHandler ?? (_nullInputHandler = new NullInputHandler());

        private SystemInputHandler _systemInputHandler;

        public IInputHandler GetSystemInputHandler() =>
            _systemInputHandler ?? (_systemInputHandler = new SystemInputHandler());
    }
}