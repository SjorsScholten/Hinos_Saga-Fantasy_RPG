namespace InputSystem.InputHandlers {
    public interface IInputHandler {
        IAxisInput GetHorizontalMoveAxis();
        IAxisInput GetVerticalMoveAxis();
        IAxisInput GetHorizontalLookAxis();
        IAxisInput GetVerticalLookAxis();
        IButtonInput GetJumpButton();
    }
}