using UnityEngine;

namespace Inputs
{
    [CreateAssetMenu(menuName = "Inputs/Input Action Map", fileName = "Input Action Map", order = 1)]
    public class ScriptableObjectInputActionMap : ScriptableObject, IInputActionMap
    {
        private IInputActionMap _impl;

        public IInputActionMap Impl
        {
            set => _impl = value;
        }

        public T GetAction<T>(string hash) where T : class
        {
            return _impl.GetAction<T>(hash);
        }
    }
}