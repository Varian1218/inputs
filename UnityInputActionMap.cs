using System.Collections.Generic;
using UnityEngine.InputSystem;

namespace Inputs
{
    public class UnityInputActionMap : IInputActionMap
    {
        private readonly Dictionary<string, object> _actions = new();
        private InputActionMap _impl;

        public InputActionMap Impl
        {
            set => _impl = value;
        }

        public void AddAction<T>(string hash, T action) where T : IInputAction
        {
            var iAction = _impl[hash];
            _actions.Add(hash, action); 
            iAction.performed += action.Invoke;
            iAction.Enable();
        }

        public T GetAction<T>(string hash) where T : class
        {
            return _actions[hash] as T;
        }
    }
}