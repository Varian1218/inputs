using System;

namespace Inputs
{
    public interface IFloat2InputAction
    {
        event Action<float, float> Action;
    }
}