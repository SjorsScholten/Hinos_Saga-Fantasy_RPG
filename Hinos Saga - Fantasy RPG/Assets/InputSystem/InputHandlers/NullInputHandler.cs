
namespace InputSystem.InputHandlers {
    public class NullInputHandler : IInputHandler {
        public IAxisInput GetHorizontalMoveAxis() => null;

        public IAxisInput GetVerticalMoveAxis() => null;

        public IAxisInput GetHorizontalLookAxis() => null;

        public IAxisInput GetVerticalLookAxis() => null;

        public IButtonInput GetJumpButton() => null;
    }
}