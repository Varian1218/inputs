using UnityEngine.InputSystem;

namespace Inputs
{
    public interface IInputAction
    {
        void Invoke(InputAction.CallbackContext context);
    }
}