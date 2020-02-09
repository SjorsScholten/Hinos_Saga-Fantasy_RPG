using System.Collections.Generic;
using InputSystem.InputHandlers;
using UnityEngine;
using Util;

namespace InputSystem.View {
    [System.Serializable]
    public class InputPresenter : IPresenter<IInputHandler> {
        private readonly List<IInputView> _inputViews = new List<IInputView>();
        [SerializeField] private GameObject[] views;

        public void Initialize() {
            foreach (var go in views) {
                var view = go.GetComponent<IInputView>();
                if(view != null) _inputViews.Add(view);
            }
        }
        
        public void UpdateGUI(IInputHandler source) {
            foreach (var view in _inputViews) {
                
                view.SetMovementVectorValue(new Vector3(
                    source.GetHorizontalMoveAxis().GetAxis(),
                    0, 
                    source.GetVerticalMoveAxis().GetAxis()
                    ).normalized);
                
            }
        }
    }
}