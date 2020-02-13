using System.Collections.Generic;
using InputSystem.View;
using UnityEngine;
using Util;

namespace Character.Input {
    [System.Serializable]
    public class InputPresenter : BasePresenter<IInputView> {
        
        public override void UpdateGUI(object source) {
            var input = source as CharacterInput;
            
            if(input == null) return;
            
            foreach (var view in InputViews) {
                view.SetMovementVectorValue(new Vector2(input.HorizontalAxis, input.VerticalAxis));
                view.SetJumpValue(input.PeekJumpRequest);
                view.SetRunValue(input.PeekRunRequest);
            }
        }
    }
}