using InputSystem;
using UnityEngine;
using Util;

namespace Character {
    public class CharacterController : Entity {
        [SerializeField] private InputProvider _input;

        protected override void Initialize() {
            myRigidbody.freezeRotation = true;

            if (!_input) {
                _input = GetComponent<InputProvider>();
                if(!_input) _input = gameObject.AddComponent<InputProvider>();
            }
        }
    }
}
