using System;
using System.Collections.Generic;

namespace Inputs
{
    public class InputActionFactory : IInputActionFactory
    {
        private readonly Dictionary<string, Type> _types;

        public void AddInputAction<TInterface, TClass>() where TClass : TInterface
        {
            _types.Add(GetHash<TInterface>(), typeof(TClass));
        }

        public T CreateInputAction<T>() where T : class
        {
            return Activator.CreateInstance(_types[GetHash<T>()]) as T;
        }

        private static string GetHash<T>()
        {
            return typeof(T).Name;
        }
    }
}