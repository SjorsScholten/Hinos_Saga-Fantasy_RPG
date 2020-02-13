using InputSystem;
using UnityEngine;
using Util;

namespace Character {
    [RequireComponent(typeof(CharacterInput))]
    public class CharacterController : Entity {
        private CharacterInput _input;

        protected override void Initialize() {
            myRigidbody.freezeRotation = true;
            
            _input = GetComponent<CharacterInput>();
            if(!_input) _input = gameObject.AddComponent<CharacterInput>();
        }
    }
}
