using System;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Inputs
{
    public class Float2InputAction : IFloat2InputAction, IInputAction
    {
        public event Action<float, float> Action;

        public void Invoke(InputAction.CallbackContext context)
        {
            var value = context.ReadValue<Vector2>();
            Action?.Invoke(value.x, value.y);
        }
    }
}