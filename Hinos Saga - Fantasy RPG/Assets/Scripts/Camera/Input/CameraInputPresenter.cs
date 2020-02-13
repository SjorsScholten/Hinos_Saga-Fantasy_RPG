using UnityEngine;
using Util;

namespace Camera.Input {
    [System.Serializable]
    public class CameraInputPresenter : BasePresenter<ICameraInputView> {
        public override void UpdateGUI(object source) {
            var input = source as CameraInput;
            
            if(input == null) return;
            
            foreach (var view in InputViews) {
                view.SetLookVectorValue(new Vector2(input.HorizontalAxis, input.VerticalAxis));
            }
        }
    }
}