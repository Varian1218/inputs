using System;
using UnityEngine.InputSystem;

namespace Inputs
{
    public class VoidInputAction : IInputAction, IVoidInputAction
    {
        public event Action Action;
        public void Invoke(InputAction.CallbackContext context)
        {
            Action?.Invoke();
        }
    }
}